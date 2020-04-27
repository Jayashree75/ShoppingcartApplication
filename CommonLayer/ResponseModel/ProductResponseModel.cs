namespace CommonLayer.ResponseModel
{
  using System;
  using System.Collections.Generic;
  using System.ComponentModel.DataAnnotations;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;


  public class ProductResponseModel
  {
    [Key]
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string ProductImage { get; set; }
    public int ProductQuantity { get; set; }
    public int ProductPrice { get; set; }

  }
}
