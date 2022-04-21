using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class BookResultByStatus
    {
        public int bookId;
        public string bookName;
        public string status;
        public string username;
        public DateTime issueDate;

        public override string ToString()
        {
            return bookId + " " + status + " " + username + " " + issueDate;        
        }

        public BookResultByStatus(int bookId,string bookName,string status,string username,DateTime issueDate)
        {
            this.bookId = bookId;
            this.bookName = bookName;
            this.status = status;
            this.username = username;
            this.issueDate = issueDate;
        }

    }

    public class UserResultByNumberOfBooks
    {
        public string userName;
        public int numberOfIssuedBooks;
        public int numberOfreturndOfBooks;

        public override string ToString()
        {
            return userName + "," + numberOfIssuedBooks + "," + numberOfreturndOfBooks;
        }
        public UserResultByNumberOfBooks()
        {

        }
        public UserResultByNumberOfBooks(string userName,int numberOfIssuedBooks, int numberOfreturndOfBooks)
        {
           this.userName = userName;
            this.numberOfIssuedBooks = numberOfIssuedBooks;
            this.numberOfreturndOfBooks = numberOfreturndOfBooks;
        }
    }
}
