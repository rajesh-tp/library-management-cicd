using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Library.Models;

namespace LibraryManagement.Controllers
{
    public class BorrowerController : Controller
    {
        static IList<Borrower> bookList = new List<Borrower>{
                new Borrower() { BorrowerId = 1, BookId = 1, BorrowedFromDate = DateTime.Parse("10/01/2022"), BorrowedToDate = DateTime.Parse("10/02/2022"), ActualReturnDate = DateTime.Parse("25/01/2022"),IssuedBy = 1 } ,
                new Borrower() { BorrowerId = 2, BookId = 2,  BorrowedFromDate = DateTime.Parse("05/01/2022"), BorrowedToDate = DateTime.Parse("10/02/2022"), ActualReturnDate = DateTime.Parse("20/01/2022"), IssuedBy = 2 } ,                
            };
        // GET: Borrower
        //[Authorize]
        public ActionResult Index()
        {
            return View(bookList);
        }

        // GET: Borrower/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Borrower/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Borrower/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Borrower/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Borrower/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Borrower/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Borrower/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
