using BusinessLayer.Interfaces;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using CommonLayer.ModelDb;
using Microsoft.Ajax.Utilities;
using RepositoryLayer.Context;
using ShoppingCartApplication.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingCartApplication.Controllers
{
  public class ProductController : Controller
  {
    private readonly IProductBL _productBL;

    public ProductController(IProductBL productBL)
    {
      _productBL = productBL;
    }
   

    [HttpGet]
    public ActionResult Add()
    {
      return View();
    }
    [HttpGet]
    public ActionResult Display()
    {

      
      var result = _productBL.GetAllProduct();
      return View(result);
    }
    [HttpPost]
    public ActionResult Add(ProductModel productModel)
    {

      if (ModelState.IsValid)
      {
        HttpPostedFileBase productImage = productModel.ProductImage;
        string productImagePath = UploadProductImageToCloudinary(productImage);

        Product productRequest = new Product
        {
          ProductName = productModel.ProductName,
          ProductImage = productImagePath,
          ProductQuantity = productModel.ProductQuantity,
          ProductPrice = productModel.ProductPrice
        };

        var product = _productBL.AddProduct(productRequest);
      }

      return View();
    }
 
    [NonAction]
    private string UploadProductImageToCloudinary(HttpPostedFileBase productImage)
    {


      var Account = new Account(ConfigurationManager.AppSettings["Cloud_Name"],
          ConfigurationManager.AppSettings["Api_Key"], ConfigurationManager.AppSettings["Api_Secret"]);

      Cloudinary cloudinary = new Cloudinary(Account);

      var imageUpload = new ImageUploadParams
      {
        File = new FileDescription(productImage.FileName, productImage.InputStream),
        Folder = "Shopping Cart"
      };

      var uploadImage = cloudinary.Upload(imageUpload);

      return uploadImage.SecureUri.AbsoluteUri;

    }


  }
}
