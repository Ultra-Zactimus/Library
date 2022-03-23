using System.Collections.Generic;

namespace Library.Models
{
  public class Book
  {
    public Book()
    {
      this.JoinEntities = new HashSet<Storage>();
    }

    public int BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<Storage> JoinEntities { get; set; }

  }
}