using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShoppingCartApplication.Models
{
  public class ProductModel
  {
    [Key]
    public int ProductId { get; set; }
    [Required(ErrorMessage = "Product Name is Required.")]
    public string ProductName { set; get; }

    [Required(ErrorMessage = "Please Select the Images")]
    [RegularExpression(@"([^\s]+(\.(?i)(jpg|png|gif|bmp))$)", ErrorMessage = "Only .png, .jpg files are allowed.")]
    public HttpPostedFileBase ProductImage { set; get; }

    [Required(ErrorMessage = "Product Quantity is Required.")]
    [RegularExpression("^[1-9][0-9]{0,3}$", ErrorMessage = "Min 1 and Max 9999 Quantity Of the Product Required.")]
    public int ProductQuantity { set; get; }

    [Required(ErrorMessage = "Product Price is Required.")]
    [RegularExpression("^[1-9][0-9]{0,6}$", ErrorMessage = "Price Of the Product Should be More than 0")]
    public int ProductPrice { set; get; }

  }
  
}