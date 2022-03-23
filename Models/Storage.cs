namespace Library.Models
{
  public class Storage
  {       
    public int StorageId { get; set; }
    public int BookId { get; set; }
    public int CatalogId { get; set; }
    public virtual Book Book { get; set; }
    public virtual Catalog Catalog { get; set; }
  }
}