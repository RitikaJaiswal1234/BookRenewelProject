using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    internal class LibraryOperationImpl : ILibraryOperation
    {
        
        public List<BookResultByStatus> getBookResultByStatus(List<BookDetails> listofBooks, List<BookRenewel> listofBookRental)
        {
            List<BookResultByStatus> resultList = new List<BookResultByStatus>();
            Dictionary<int, String> obj = new Dictionary<int, String>();
            foreach (BookDetails book in listofBooks)
            {
                if (!obj.ContainsKey(book.BookId))
                    obj.Add(book.BookId, book.BookName);

            }
            foreach (BookRenewel bookRental in listofBookRental)
            {
                if (bookRental.Status == "issued")
                    resultList.Add(new BookResultByStatus(bookRental.BookId, obj[bookRental.BookId], bookRental.Status, bookRental.UserName, bookRental.IssueDate));

            }
            return resultList;
        }
        public List<UserResultByNumberOfBooks> getUserResultByNumberOfBooks(List<BookDetails> listofBooks, List<BookRenewel> listofBookRental)
        {
            Dictionary<String, UserResultByNumberOfBooks> obj = new Dictionary<String, UserResultByNumberOfBooks>();
            foreach (BookRenewel bookRental in listofBookRental)
            {
                if (obj.ContainsKey(bookRental.UserName))
                {
                    UserResultByNumberOfBooks oldResult = obj[bookRental.UserName];
                    if (bookRental.Status == "issued")
                        oldResult.numberOfIssuedBooks++;
                    else
                        oldResult.numberOfreturndOfBooks++;


                }
                else
                {
                    UserResultByNumberOfBooks newResult = new UserResultByNumberOfBooks();
                    newResult.userName = bookRental.UserName;
                    if (bookRental.Status == "issued")
                        newResult.numberOfIssuedBooks++;
                    else
                        newResult.numberOfreturndOfBooks++;
                    obj.Add(bookRental.UserName, newResult);

                }
            }
            List<UserResultByNumberOfBooks> resultList = new List<UserResultByNumberOfBooks>();
            foreach (var element in obj)
            {
                if (element.Value.numberOfIssuedBooks > 1 || element.Value.numberOfreturndOfBooks > 1)
                    resultList.Add(element.Value);

            }
            return resultList;
        }
    }
}
    

