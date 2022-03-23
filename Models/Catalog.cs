using System.Collections.Generic;

namespace Library.Models
{
  public class Catalog
  {
    public Catalog()
    {
      this.JoinEntities = new HashSet<Storage>();
    }

    public int CatalogId { get; set; }
    public string Ticket { get; set; }
    
    public virtual ICollection<Storage> JoinEntities { get; set; }
  }
}