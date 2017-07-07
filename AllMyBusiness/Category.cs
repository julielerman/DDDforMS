using System.Collections.Generic;

namespace AllMyBusiness.Domain
{
  public class Category
  {
    public Category()
    {
      Products = new List<Product>();
    }

    public int CategoryId { get; set; }
    public string Name { get; set; }

    public ICollection<Product> Products { get; set; }
  }
}