using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Book
    {        
        public int BookId { get; set; }
        public string ISBN { get; set; }
        [Display(Name = "Book Title")]
        public string BookTitle { get; set; }
        [Display(Name = "Publication Year")]
        public int PublicationYear { get; set; }
        public string Language { get; set; }
        public int CategoryId { get; set; }
        public int BindingId { get; set; }
        [Display(Name = "Number of copies actual")]
        public int NumberOfCopiesActual { get; set; }
        [Display(Name = "Number of copies current")]
        public int NumberOfCopiesCurrent { get; set; }
    }
}
