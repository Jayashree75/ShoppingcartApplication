namespace BusinessLayer.Interfaces
{
  using CommonLayer.ModelDb;
  using CommonLayer.ResponseModel;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;


  public interface IProductBL
  {
    ProductResponseModel AddProduct(Product product);
    List<ProductResponseModel> GetAllProduct();
  }
}
