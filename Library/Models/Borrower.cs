using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Borrower
    {
        public int BorrowerId { get; set; }
        public int BookId { get; set; }
        public DateTime BorrowedFromDate { get; set; }
        public DateTime BorrowedToDate { get; set; }
        public DateTime ActualReturnDate { get; set; }
        public int IssuedBy { get; set; }
    }
}
