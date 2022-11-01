using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Library.Models;

namespace LibraryManagement.Areas.admin.Controllers
{
    public class BookController : Controller
    {
        static IList<Book> bookList = new List<Book>{
                new Book() { BookId = 1, BookTitle = "C#", ISBN = "1234560", Language = "EN", NumberOfCopiesActual = 10, NumberOfCopiesCurrent=10 } ,
                new Book() { BookId = 2, BookTitle = "ASP.NET",  ISBN = "1234561", Language = "EN", NumberOfCopiesActual = 10, NumberOfCopiesCurrent=10 } ,
                new Book() { BookId = 3, BookTitle = "Java",  ISBN = "1234562", Language = "FR", NumberOfCopiesActual = 10, NumberOfCopiesCurrent=10 } ,
                new Book() { BookId = 4, BookTitle = "React" , ISBN = "1234563", Language = "EN", NumberOfCopiesActual = 10, NumberOfCopiesCurrent=10 } ,
                new Book() { BookId = 5, BookTitle = "nestJs" , ISBN = "1234564", Language = "EN", NumberOfCopiesActual = 10, NumberOfCopiesCurrent=10 } ,
                new Book() { BookId = 6, BookTitle = "Ms Word" , ISBN = "1234565", Language = "DE", NumberOfCopiesActual = 10, NumberOfCopiesCurrent=10 } ,
                new Book() { BookId = 7, BookTitle = "Ms Excel" , ISBN = "1234566", Language = "DE", NumberOfCopiesActual = 10, NumberOfCopiesCurrent=10 }
            };
        // GET: admin/Book
        //[Authorize]
        public ActionResult Index()
        {
            return View(bookList);
        }        
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Details(int id)
        {
            Book book = bookList.Where(b => b.BookId == id).FirstOrDefault();
            return View(book);
        }
        public ActionResult Edit(int id)
        {
            Book book = bookList.Where(b => b.BookId == id).FirstOrDefault();
            return View(book);
        }
        [HttpPost]
        public ActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                Book bk = bookList.Where(b => b.BookId == book.BookId).FirstOrDefault();
                UpdateBookDetails(bk, book);
                return RedirectToAction("Index");
            }

            return View(book);
        }

        private void UpdateBookDetails(Book bk, Book book)
        {
            bk.ISBN = book.ISBN;
            bk.BookTitle = book.BookTitle;
            bk.Language = book.Language;
            bk.NumberOfCopiesActual = book.NumberOfCopiesActual;
            bk.NumberOfCopiesCurrent = book.NumberOfCopiesCurrent;
        }
                
        /*public ActionResult Delete(int id)
        {
            Book book = bookList.Where(b => b.BookId == id).FirstOrDefault();           

            return View(book);
        }*/
        [HttpPost, ActionName("Delete")]
        public JsonResult DeleteConfirmed(int id)
        {            
            var book = bookList.Where(b => b.BookId == id).FirstOrDefault();            
            bookList.Remove(book);

            return Json(new { status = "Success" });
            //return RedirectToAction("Index");
        }
        
        public FileResult Download(int id)
        {            
            //string path = Server.MapPath("./Books");
            byte[] fileBytes = System.IO.File.ReadAllBytes(@"D:\RajeshTP\MVC\LibraryManagement\LibraryManagement\App_Data\Books\TestBook.pdf");
            string fileName = id + ".pdf";
            
            //string filePath = Server.MapPath(@"D:\RajeshTP\MVC\LibraryManagement\LibraryManagement\App_Data\Books\TestBook.pdf");
            //Response.TransmitFile(filePath);

            return File(fileBytes, "application/octet-stream", fileName);
        }
    }
}