using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Library.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace Library.Controllers
{
  [Authorize]
  public class BooksController : Controller
  {
    private readonly LibraryContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public BooksController(UserManager<ApplicationUser> userManager, LibraryContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public async Task<ActionResult> Index()
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      var userBooks = _db.Books.Where(entry => entry.User.Id == currentUser.Id).ToList();
      return View(userBooks);
    }
    
    public ActionResult Create()
    {
      ViewBag.CatalogId = new SelectList(_db.Catalogs, "CatalogId", "Ticket");
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Create(Book book, int CatalogId)
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      var currentUser = await _userManager.FindByIdAsync(userId);
      book.User = currentUser;
      _db.Books.Add(book);
      _db.SaveChanges();
      if (CatalogId != 0)
      {
        _db.Storage.Add(new Storage() { CatalogId = CatalogId, BookId = book.BookId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
      var thisBook = _db.Books
        .Include(book => book.JoinEntities)
        .ThenInclude(join => join.Catalog)
        .FirstOrDefault(book => book.BookId == id);
        return View(thisBook);
    }

    public ActionResult Edit(int id)
    {
      var thisBook = _db.Books.FirstOrDefault(book => book.BookId == id);
      ViewBag.CatalogId = new SelectList(_db.Catalogs, "CatalogId", "Ticket");
      return View(thisBook);
    }

    [HttpPost]
    public ActionResult Edit(Book book, int CatalogId)
    {
      if (CatalogId != 0)
      {
        _db.Storage.Add(new Storage() { CatalogId = CatalogId, BookId = book.BookId });
      }
      _db.Entry(book).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult AddCatalog(int id)
    {
      var thisBook = _db.Books.FirstOrDefault(book => book.BookId == id);
      ViewBag.CatalogId = new SelectList(_db.Catalogs, "CatalogId", "Ticket");
      return View(thisBook);
    }

    [HttpPost]
    public ActionResult AddCatalog(Book book, int CatalogId)
    {
      if (CatalogId != 0)
      {
        _db.Storage.Add(new Storage() { CatalogId = CatalogId, BookId = book.BookId });
      }
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      var thisBook = _db.Books.FirstOrDefault(book => book.BookId == id);
      return View(thisBook);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      var thisBook = _db.Books.FirstOrDefault(book => book.BookId == id);
      _db.Books.Remove(thisBook);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult DeleteCatalog(int joinId)
    {
      var joinEntry = _db.Storage.FirstOrDefault(entry => entry.StorageId == joinId);
      _db.Storage.Remove(joinEntry);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}