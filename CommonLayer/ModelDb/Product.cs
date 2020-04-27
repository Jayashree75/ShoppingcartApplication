namespace CommonLayer.ModelDb
{
  using System;
  using System.Collections.Generic;
  using System.ComponentModel.DataAnnotations;
  using System.ComponentModel.DataAnnotations.Schema;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;


  public class Product
  {

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProductId { get; set; }
    [Required]
    public string ProductName { get; set; }
    public string ProductImage { get; set; }
    public int ProductQuantity { get; set; }
    public int ProductPrice { get; set; }

  }
}
