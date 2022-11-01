using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public bool Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int BorrowerId { get; set; }
        public string Department { get; set; }
        public string ContactNumber { get; set; }
    }
}
