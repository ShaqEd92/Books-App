using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Lybrary.Models;

namespace Lybrary.Controllers
{
    public class HomeController : Controller
    {
        // Database Connection
        private MyContext dbContext;

        public HomeController(MyContext context)
        {
            dbContext = context;
        }


        // <----- USE LOGIN METHODS -----> 


        // Registration page
        [Route("/")]
        [HttpGet]
        public IActionResult Index()
        {
            return View("Index");
        }


        // Post request for registration - add new reader to database
        [Route("registration")]
        [HttpPost]
        public IActionResult Registration(Reader newReader)
        {
            if (ModelState.IsValid)
            {
                if (dbContext.Readers.Any(r => r.Email == newReader.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Index");
                }
                PasswordHasher<Reader> Hasher = new PasswordHasher<Reader>();
                newReader.Password = Hasher.HashPassword(newReader, newReader.Password);
                dbContext.Add(newReader);
                dbContext.SaveChanges();
                HttpContext.Session.SetString("loggedin", "yes");
                HttpContext.Session.SetInt32("id", newReader.ReaderID);
                return RedirectToAction("Dashboard");
            }
            return View("Index");
        }


        // Sign in page
        [Route("Login")]
        [HttpGet]
        public IActionResult Login()
        {
            return View("Login");
        }


        // Post request for sign in page 
        [Route("LoggingIn")]
        [HttpPost]
        public IActionResult LoggingIn(LoginReader logReader)
        {
            if (ModelState.IsValid)
            {
                Reader emailInDb = dbContext.Readers.FirstOrDefault(e => e.Email == logReader.LoginEmail);
                if (emailInDb == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("login");
                }
                var hasher = new PasswordHasher<LoginReader>();
                var result = hasher.VerifyHashedPassword(logReader, emailInDb.Password, logReader.LoginPassword);
                if (result == 0)
                {
                    ModelState.AddModelError("Password", "Invalid Email/Password");
                    return View("login");
                }
                else
                {
                    HttpContext.Session.SetString("loggedin", "yes");
                    HttpContext.Session.SetInt32("id", emailInDb.ReaderID);
                    return RedirectToAction("Dashboard");
                }
            }
            return View("Login");
        }


        // Log out page
        [Route("Logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }


        // <----- MAIN APPLICATION METHODS -----> 


        // Main page - display books in database, links to add, update, delete
        [Route("Dashboard")]
        [HttpGet]
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("loggedin") == null)
            {
                return RedirectToAction("index");
            }
            else
            {
                // Who is in session? //
                Reader ReaderInSession = dbContext.Readers.FirstOrDefault(r => r.ReaderID == (int)HttpContext.Session.GetInt32("id"));
                ViewBag.ReaderID = HttpContext.Session.GetInt32("id");
                ViewBag.ReaderName = ReaderInSession.FirstName;
                ViewBag.ReaderInSession = ReaderInSession;
                // List of books and all attached info for table //
                IEnumerable<Book> AllBooks = dbContext.Books
                .Include(s => s.Submitter) // Who submitted book
                .Include(r => r.ReadBy) // List of readers who read book
                .ThenInclude(t => t.TheReader) // Use list of readers who read book to get reader info
                .Include(tr => tr.ToRead) // List of readers who have book on to-read-list
                .ThenInclude(thr => thr.TheReader) // Use lis of readers who have book on to-read-list to get reader info
                .Include(f => f.Faved) // List of readers who have book on favorite list
                .ThenInclude(thr => thr.TheReader) // Use list of readers who have book on favorite list to get reader info 
                .Include(bc => bc.BookComments) // List of comments on book
                .ThenInclude(rc => rc.TheReader) // Use list of comments on book to get reader info
                .ToList();
                ViewBag.AllBooks = AllBooks;
                // All current genres
                List<string> AllGenres = new List<string>();
                foreach (var g in AllBooks)
                {
                    if (!AllGenres.Contains(g.Genre))
                    {
                        AllGenres.Add(g.Genre);
                    }
                }
                ViewBag.AllGenres = AllGenres;
                ViewBag.Home = "Home";
                return View("Dashboard");
            }
        }


        // Form to add new book, if logged in
        [Route("AddBook")]
        [HttpGet]
        public IActionResult AddBook()
        {
            if (HttpContext.Session.GetString("loggedin") == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                // List of books and all attached info for table (For the nav bar) //
                IEnumerable<Book> AllBooks = dbContext.Books.ToList();
                ViewBag.AllBooks = AllBooks;
                // All current genres
                List<string> AllGenres = new List<string>();
                foreach (var g in AllBooks)
                {
                    if (!AllGenres.Contains(g.Genre))
                    {
                        AllGenres.Add(g.Genre);
                    }
                }
                ViewBag.AllGenres = AllGenres;
                return View("AddBook");
            }
        }


        // Add book to database post method
        [Route("CreateBook")]
        [HttpPost]
        public IActionResult CreateBook(Book newBook)
        {
            IEnumerable<Book> AllBooks = dbContext.Books.ToList();
            ViewBag.AllBooks = AllBooks;
            // All current genres
            List<string> AllGenres = new List<string>();
            foreach (var g in AllBooks)
            {
                if (!AllGenres.Contains(g.Genre))
                {
                    AllGenres.Add(g.Genre);
                }
            }
            ViewBag.AllGenres = AllGenres;
            if (ModelState.IsValid)
            {
                newBook.ReaderID = (int)HttpContext.Session.GetInt32("id");
                dbContext.Books.Add(newBook);
                dbContext.SaveChanges();
                return RedirectToAction("DisplayBook", new { BookID = newBook.BookID });
            }
            return View("AddBook");
        }


        // Display single book on page by finding in the database using BookID passed in as a parameter
        [Route("DisplayBook/{BookID}")]
        [HttpGet]
        public IActionResult DisplayBook(int BookID)
        {
            if (HttpContext.Session.GetString("loggedin") == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                // List of books and all attached info for table //
                IEnumerable<Book> AllBooks = dbContext.Books
                .Include(s => s.Submitter) // Who submitted book
                .Include(r => r.ReadBy) // List of readers who read book
                .ThenInclude(t => t.TheReader) // Use list of readers who read book to get reader info
                .Include(tr => tr.ToRead) // List of readers who have book on to-read-list
                .ThenInclude(thr => thr.TheReader) // Use lis of readers who have book on to-read-list to get reader info
                .Include(f => f.Faved) // List of readers who have book as a favorite
                .ThenInclude(thr => thr.TheReader) // Use list of readers who have book on favorite list to get reader info
                .Include(bc => bc.BookComments) // List of comments on book
                .ThenInclude(rc => rc.TheReader) // Use list of comments on book to get reader info
                .ToList();
                ViewBag.AllBooks = AllBooks;
                // All current genres
                List<string> AllGenres = new List<string>();
                foreach (var g in AllBooks)
                {
                    if (!AllGenres.Contains(g.Genre))
                    {
                        AllGenres.Add(g.Genre);
                    }
                }
                ViewBag.AllGenres = AllGenres;
                Book TheBook = dbContext.Books.FirstOrDefault(b => b.BookID == BookID);
                return View("DisplayBook", TheBook);
            }
        }


        // Filter books by genre, passed in as a parameter in URL
        [Route("FilterGenre/{Genre}")]
        [HttpGet]
        public IActionResult FilterGenre(string Genre)
        {
            if (HttpContext.Session.GetString("loggedin") == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                // List of books and all attached info for table //
                IEnumerable<Book> AllBooks = dbContext.Books
                .Include(s => s.Submitter) // Who submitted book
                .Include(r => r.ReadBy) // List of readers who read book
                .ThenInclude(t => t.TheReader) // Use list of readers who read book to get reader info
                .Include(tr => tr.ToRead) // List of readers who have book on to-read-list
                .ThenInclude(thr => thr.TheReader) // Use lis of readers who have book on to-read-list to get reader info
                .Include(f => f.Faved) // List of readers who have book as a favorite
                .ThenInclude(thr => thr.TheReader) // Use list of readers who have book on favorite list to get reader info
                .Include(bc => bc.BookComments) // List of comments on book
                .ThenInclude(rc => rc.TheReader) // Use list of comments on book to get reader info
                .ToList();
                ViewBag.AllBooks = AllBooks;
                // All current genres
                List<string> AllGenres = new List<string>();
                foreach (var g in AllBooks)
                {
                    if (!AllGenres.Contains(g.Genre))
                    {
                        AllGenres.Add(g.Genre);
                    }
                }
                ViewBag.AllGenres = AllGenres;
                IEnumerable<Book> SomeBooks = dbContext.Books.Where(b => b.Genre == Genre);
                ViewBag.TheGenre = Genre;
                ViewBag.SomeBooks = SomeBooks;
                ViewBag.WhichFilter = "Genre";
                return View("FilterBooks");
            }
        }


        // Filter books by author, passed in as a parameter in URL
        [Route("FilterAuthor/{Author}")]
        [HttpGet]
        public IActionResult FilterAuthor(string Author)
        {
            if (HttpContext.Session.GetString("loggedin") == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                // List of books and all attached info for table //
                IEnumerable<Book> AllBooks = dbContext.Books
                .Include(s => s.Submitter) // Who submitted book
                .Include(r => r.ReadBy) // List of readers who read book
                .ThenInclude(t => t.TheReader) // Use list of readers who read book to get reader info
                .Include(tr => tr.ToRead) // List of readers who have book on to-read-list
                .ThenInclude(thr => thr.TheReader) // Use lis of readers who have book on to-read-list to get reader info
                .Include(f => f.Faved) // List of readers who have book as a favorite
                .ThenInclude(thr => thr.TheReader) // Use list of readers who have book on favorite list to get reader info
                .Include(bc => bc.BookComments) // List of comments on book
                .ThenInclude(rc => rc.TheReader) // Use list of comments on book to get reader info
                .ToList();
                ViewBag.AllBooks = AllBooks;
                // All current genres
                List<string> AllGenres = new List<string>();
                foreach (var g in AllBooks)
                {
                    if (!AllGenres.Contains(g.Genre))
                    {
                        AllGenres.Add(g.Genre);
                    }
                }
                ViewBag.AllGenres = AllGenres;
                IEnumerable<Book> SomeBooks = dbContext.Books.Where(b => b.Author == Author);
                ViewBag.TheAuthor = Author;
                ViewBag.SomeBooks = SomeBooks;
                ViewBag.WhichFilter = "Author";
                return View("FilterBooks");
            }
        }


        // Filter books by search, passed in as a parameter in URL
        [Route("Search")]
        [HttpGet]
        public IActionResult Search(string search)
        {
            if (HttpContext.Session.GetString("loggedin") == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                // List of books and all attached info for table //
                IEnumerable<Book> AllBooks = dbContext.Books
                .Include(s => s.Submitter) // Who submitted book
                .Include(r => r.ReadBy) // List of readers who read book
                .ThenInclude(t => t.TheReader) // Use list of readers who read book to get reader info
                .Include(tr => tr.ToRead) // List of readers who have book on to-read-list
                .ThenInclude(thr => thr.TheReader) // Use lis of readers who have book on to-read-list to get reader info
                .Include(f => f.Faved) // List of readers who have book as a favorite
                .ThenInclude(thr => thr.TheReader) // Use list of readers who have book on favorite list to get reader info
                .Include(bc => bc.BookComments) // List of comments on book
                .ThenInclude(rc => rc.TheReader) // Use list of comments on book to get reader info
                .ToList();
                ViewBag.AllBooks = AllBooks;
                // All current genres
                List<string> AllGenres = new List<string>();
                foreach (var g in AllBooks)
                {
                    if (!AllGenres.Contains(g.Genre))
                    {
                        AllGenres.Add(g.Genre);
                    }
                }
                ViewBag.AllGenres = AllGenres;
                IEnumerable<Book> SomeBooks = dbContext.Books.Where(b => b.Description.Contains(search));
                ViewBag.Search = search;
                ViewBag.SomeBooks = SomeBooks;
                ViewBag.WhichFilter = "Search";
                return View("FilterBooks");
            }
        }

        // Add book to 'To Read List' by creating new instance of ReadList
        [Route("WillRead/{BookID}")]
        [HttpPost]
        public IActionResult WillRead(int BookID, ReadList BookAdded)
        {
            BookAdded.BookID = BookID;
            BookAdded.ReaderID = (int)HttpContext.Session.GetInt32("id");
            dbContext.Add(BookAdded);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }


        // Remove book from 'To Read List' by deleting instance of ReadList
        [Route("WontRead/{BookID}")]
        [HttpPost]
        public IActionResult WontRead(int BookID)
        {
            IEnumerable<ReadList> YourReadLists = dbContext.ReadLists
             .Where(b => b.BookID == BookID)
             .Where(r => r.ReaderID == (int)HttpContext.Session.GetInt32("id"))
             .ToList();
            ReadList BookToRemove = YourReadLists.FirstOrDefault();
            dbContext.Remove(BookToRemove);
            dbContext.SaveChanges();
            return RedirectToAction("YourBooks", new { List = "ReadList" });
        }


        // Add book to 'To Already Read List' by creating new instance of Read
        [Route("DidRead/{BookID}")]
        [HttpPost]
        public IActionResult DidRead(int BookID, Read BookRead)
        {
            // Add to 'Already Read' list
            BookRead.BookID = BookID;
            BookRead.ReaderID = (int)HttpContext.Session.GetInt32("id");
            dbContext.Add(BookRead);
            dbContext.SaveChanges();
            // If on 'To Read List', find and delete
            IEnumerable<ReadList> BookToRead = dbContext.ReadLists
            .Where(b => b.BookID == BookID)
            .Where(r => r.ReaderID == (int)HttpContext.Session.GetInt32("id"))
            .ToList();
            if (BookToRead.Count() > 0)
            {
                ReadList BookToRemove = BookToRead.FirstOrDefault();
                dbContext.Remove(BookToRemove);
                dbContext.SaveChanges();
            }
            return RedirectToAction("DisplayBook", new { BookID = BookID });
        }


        // Add book as a Favorite by creating new instance of Favorite
        [Route("AddToFaves/{BookID}")]
        [HttpPost]
        public IActionResult AddToFaves(int BookID, Favorite Liked)
        {
            Liked.BookID = BookID;
            Liked.ReaderID = (int)HttpContext.Session.GetInt32("id");
            dbContext.Favorites.Add(Liked);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }


        // Edit book page
        [Route("EditBook/{BookID}")]
        [HttpGet]
        public IActionResult EditBook(int BookID)
        {
            Book TheBook = dbContext.Books.FirstOrDefault(b => b.BookID == BookID);
            if (HttpContext.Session.GetString("loggedin") == null || TheBook.ReaderID != (int)HttpContext.Session.GetInt32("id"))
            {
                return RedirectToAction("Dashboard");
            }
            else
            {
                // List of books and all attached info for table (For nav bar) //
                IEnumerable<Book> AllBooks = dbContext.Books.ToList();
                ViewBag.AllBooks = AllBooks;
                // All current genres
                List<string> AllGenres = new List<string>();
                foreach (var g in AllBooks)
                {
                    if (!AllGenres.Contains(g.Genre))
                    {
                        AllGenres.Add(g.Genre);
                    }
                }
                ViewBag.AllGenres = AllGenres;
                ViewBag.TheBook = TheBook;
                return View("EditBook");
            }
        }


        // Update book post method
        [Route("UpdateBook/{BookID}")]
        [HttpPost]
        public IActionResult UpdateBook(int BookID)
        {
            Book UpdatedBook = dbContext.Books.FirstOrDefault(b => b.BookID == BookID);
            if (HttpContext.Session.GetString("loggedin") == null || UpdatedBook.ReaderID != (int)HttpContext.Session.GetInt32("id"))
            {
                return RedirectToAction("Dashboard");
            }
            else
            {
                UpdatedBook.Title = Request.Form["Title"];
                UpdatedBook.Author = Request.Form["Author"];
                UpdatedBook.Genre = Request.Form["Genre"];
                UpdatedBook.Description = Request.Form["Description"];
                dbContext.SaveChanges();
                return RedirectToAction("DisplayBook", new { BookID = UpdatedBook.BookID });
            }
        }


        // Delete book
        [Route("Delete/{BookID}")]
        [HttpPost]
        public IActionResult Delete(int BookID, string Check)
        {
            if (Check == "No")
            {
                Book OneBook = dbContext.Books.FirstOrDefault(b => b.BookID == BookID);
                if (HttpContext.Session.GetString("loggedin") == null || OneBook.ReaderID != (int)HttpContext.Session.GetInt32("id"))
                {
                    return RedirectToAction("Dashboard");
                }
                dbContext.Books.Remove(OneBook);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Dashboard");
        }


        // Display page for books added, books on reading list and books read
        [Route("YourBooks/{List}")]
        [HttpGet]
        public IActionResult YourBooks(string List)
        {
            if (HttpContext.Session.GetString("loggedin") == null)
            {
                return RedirectToAction("index");
            }
            else
            {
                // Who is in session? //
                Reader ReaderInSession = dbContext.Readers.FirstOrDefault(r => r.ReaderID == (int)HttpContext.Session.GetInt32("id"));
                ViewBag.ReaderID = HttpContext.Session.GetInt32("id");
                ViewBag.ReaderName = ReaderInSession.FirstName;
                ViewBag.ReaderInSession = ReaderInSession;
                // List of books and all attached info for table //
                IEnumerable<Book> AllBooks = dbContext.Books
                .Include(s => s.Submitter) // Who submitted book
                .Include(r => r.ReadBy) // List of readers who read book
                .ThenInclude(t => t.TheReader) // Use list of readers who read book to get reader info
                .Include(tr => tr.ToRead) // List of readers who have book on to-read-list
                .ThenInclude(thr => thr.TheReader) // Use lis of readers who have book on to-read-list to get reader info
                .Include(f => f.Faved) // List of readers who have book as a favorite
                .ThenInclude(thr => thr.TheReader) // Use list of readers who have book on favorite list to get reader info
                .Include(bc => bc.BookComments) // List of comments on book
                .ThenInclude(rc => rc.TheReader) // Use list of comments on book to get reader info
                .ToList();
                ViewBag.AllBooks = AllBooks;
                // All current genres
                List<string> AllGenres = new List<string>();
                foreach (var g in AllBooks)
                {
                    if (!AllGenres.Contains(g.Genre))
                    {
                        AllGenres.Add(g.Genre);
                    }
                }
                ViewBag.AllGenres = AllGenres;
                ViewBag.Home = "Home";
                // Books added by user in session added
                IEnumerable<Book> BooksAdded = dbContext.Books.Where(r => r.ReaderID == HttpContext.Session.GetInt32("id")).ToList();
                ViewBag.BooksAdded = BooksAdded;
                // Which list to view
                ViewBag.List = List;
                return View("YourBooks");
            }
        }


        // <----- ACCOUNT INFORMATION METHODS -----> 


        [Route("YourAccount")]
        [HttpGet]
        public IActionResult YourAccount()
        {
            if (HttpContext.Session.GetString("loggedin") == null)
            {
                return RedirectToAction("index");
            }
            else
            {
                // Who is in session? //
                Reader ReaderInSession = dbContext.Readers.FirstOrDefault(r => r.ReaderID == (int)HttpContext.Session.GetInt32("id"));
                ViewBag.ReaderID = HttpContext.Session.GetInt32("id");
                ViewBag.ReaderName = ReaderInSession.FirstName;
                ViewBag.ReaderInSession = ReaderInSession;
                // List of books and all attached info for table //
                IEnumerable<Book> AllBooks = dbContext.Books
                .Include(s => s.Submitter) // Who submitted book
                .Include(r => r.ReadBy) // List of readers who read book
                .ThenInclude(t => t.TheReader) // Use list of readers who read book to get reader info
                .Include(tr => tr.ToRead) // List of readers who have book on to-read-list
                .ThenInclude(thr => thr.TheReader) // Use lis of readers who have book on to-read-list to get reader info
                .Include(f => f.Faved) // List of readers who have book as a favorite
                .ThenInclude(thr => thr.TheReader) // Use list of readers who have book on favorite list to get reader info
                .Include(bc => bc.BookComments) // List of comments on book
                .ThenInclude(rc => rc.TheReader) // Use list of comments on book to get reader info
                .ToList();
                ViewBag.AllBooks = AllBooks;
                // All current genres
                List<string> AllGenres = new List<string>();
                foreach (var g in AllBooks)
                {
                    if (!AllGenres.Contains(g.Genre))
                    {
                        AllGenres.Add(g.Genre);
                    }
                }
                ViewBag.AllGenres = AllGenres;
                ViewBag.Home = "Home";
                // Number of books added
                IEnumerable<Book> BooksAdded = dbContext.Books.Where(r => r.ReaderID == HttpContext.Session.GetInt32("id")).ToList();
                ViewBag.NumAdded = BooksAdded.Count();
                return View("YourAccount");
            }
        }


        [Route("UpdateAccount")]
        [HttpGet]
        public IActionResult UpdateAccount()
        {
            if (HttpContext.Session.GetString("loggedin") == null)
            {
                return RedirectToAction("index");
            }
            else
            {
                // Who is in session? //
                Reader ReaderInSession = dbContext.Readers.FirstOrDefault(r => r.ReaderID == (int)HttpContext.Session.GetInt32("id"));
                ViewBag.ReaderID = HttpContext.Session.GetInt32("id");
                ViewBag.ReaderName = ReaderInSession.FirstName;
                ViewBag.ReaderInSession = ReaderInSession;
                // List of books for nav bar//
                IEnumerable<Book> AllBooks = dbContext.Books.ToList();
                ViewBag.AllBooks = AllBooks;
                // All current genres
                List<string> AllGenres = new List<string>();
                foreach (var g in AllBooks)
                {
                    if (!AllGenres.Contains(g.Genre))
                    {
                        AllGenres.Add(g.Genre);
                    }
                }
                ViewBag.AllGenres = AllGenres;
                ViewBag.Home = "Home";
                return View("UpdateAccount");
            }
        }


        [Route("Update/{info}")]
        [HttpGet]
        public IActionResult Update(string info)
        {
            if (HttpContext.Session.GetString("loggedin") == null)
            {
                return RedirectToAction("index");
            }
            else
            {
                // Who is in session? //
                Reader ReaderInSession = dbContext.Readers.FirstOrDefault(r => r.ReaderID == (int)HttpContext.Session.GetInt32("id"));
                ViewBag.ReaderID = HttpContext.Session.GetInt32("id");
                ViewBag.ReaderName = ReaderInSession.FirstName;
                ViewBag.ReaderInSession = ReaderInSession;
                // List of books for nav bar //
                IEnumerable<Book> AllBooks = dbContext.Books.ToList();
                ViewBag.AllBooks = AllBooks;
                // All current genres
                List<string> AllGenres = new List<string>();
                foreach (var g in AllBooks)
                {
                    if (!AllGenres.Contains(g.Genre))
                    {
                        AllGenres.Add(g.Genre);
                    }
                }
                ViewBag.AllGenres = AllGenres;
                ViewBag.Home = "Home";
                ViewBag.Info = info;
                return View("UpdateInfo");
            }
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
