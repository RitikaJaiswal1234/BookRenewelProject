using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class BookDetails
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int Isbn { get; set; }
        public int BookPrice { get; set; }
        public string BookAuthour { get; set; }


        public BookDetails(int bookId, string bookName, int isbn, int bookPrice, string bookAuthour)
        {
            BookId = bookId;
            BookName = bookName;
            Isbn = isbn;
            BookPrice = bookPrice;
            BookAuthour = bookAuthour;
        }

        public override string ToString()
        {
            return BookId + "," + BookName + "," + Isbn + "," + BookPrice + "," + BookAuthour;
        }
    }
    public class BookRenewel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int BookId { get; set; }
        public DateTime IssueDate { get; set; }
        public String Status { get; set; }
        public DateTime ReturnDate { get; set; }
        public int Pincode { get; set; }



        public BookRenewel(int userId, string userName, int bookId, DateTime issueDate, String status, DateTime returnDate, int pincode)
        {
            UserId = userId;
            UserName = userName;
            BookId = bookId;
            IssueDate = issueDate;
            Status = status;
            ReturnDate = returnDate;
            Pincode = pincode;
        }
        public override string ToString()
        {
            return UserId + "," + UserName + "," + BookId + "," + IssueDate + "," + Status + "," + ReturnDate + "," + Pincode;
        }
    }
}

