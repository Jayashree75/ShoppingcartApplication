using CommonLayer.ModelDb;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Context
{
  public class ProductContext:DbContext
  {
    public ProductContext():base("ProductCardDb")
    { }
    public DbSet<Product> products { get; set; }
  }
}
