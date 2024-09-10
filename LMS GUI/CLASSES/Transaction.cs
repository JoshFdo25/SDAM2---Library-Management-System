using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_GUI
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public int BookID { get; set; }
        public int StudentID { get; set; }
        public DateTime DateIssued { get; set; }

        public Transaction(int transactionID, int bookID, int studentID, DateTime dateIssued)
        {
            TransactionID = transactionID;
            BookID = bookID;
            StudentID = studentID;
            DateIssued = dateIssued;
        }
    }
}
