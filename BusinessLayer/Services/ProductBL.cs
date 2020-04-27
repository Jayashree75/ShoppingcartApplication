namespace BusinessLayer.Services
{
  using BusinessLayer.Interfaces;
  using CommonLayer.ModelDb;
  using CommonLayer.ResponseModel;
  using RepositoryLayer.Interfaces;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;


  public class ProductBL : IProductBL
  {
    private readonly IProductRL _productRepository;
    public ProductBL(IProductRL productRepository)
    {
      _productRepository = productRepository;
    }

    public ProductResponseModel AddProduct(Product product)
    {
      try
      {
        if (product != null)
        {
          return _productRepository.AddProduct(product);
        }
        else
        {
          throw new Exception("Product Details is Empty");
        }
      }
      catch (Exception e)
      {
        throw new Exception(e.Message);
      }
    }
    public List<ProductResponseModel> GetAllProduct()
    {
      return _productRepository.GetAllProduct();
    }
  }
}
