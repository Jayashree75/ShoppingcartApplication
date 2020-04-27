namespace RepositoryLayer.Services
{
  using CommonLayer.ModelDb;
  using CommonLayer.ResponseModel;
  using RepositoryLayer.Context;
  using RepositoryLayer.Interfaces;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;


  public class ProductRL : IProductRL
  {
    private readonly ProductContext _productContext;

    public ProductRL(ProductContext productContext)
    {
      _productContext = productContext;
    }
    public ProductResponseModel AddProduct(Product product)
    {
      try
      {
        var model = new Product()
        {
          ProductName = product.ProductName,
          ProductImage = product.ProductImage,
          ProductPrice = product.ProductPrice,
          ProductQuantity = product.ProductQuantity
        };
        _productContext.products.Add(model);
        _productContext.SaveChanges();
        ProductResponseModel responseModel = new ProductResponseModel()
        {
          ProductId = model.ProductId,
          ProductName = model.ProductName,
          ProductImage = model.ProductImage,
          ProductPrice = model.ProductPrice,
          ProductQuantity = model.ProductQuantity
        };
        return responseModel;
      }
      catch (Exception e)
      {
        throw new Exception(e.Message);
      }
    }
    public List<ProductResponseModel> GetAllProduct()
    {
      List<ProductResponseModel> productResponses = _productContext.products.Select(product => new ProductResponseModel
      {
        ProductName=product.ProductName,
        ProductImage=product.ProductImage,
        ProductPrice=product.ProductPrice,
        ProductQuantity=product.ProductQuantity
      }).ToList();
      return productResponses;
    }
  }
}
