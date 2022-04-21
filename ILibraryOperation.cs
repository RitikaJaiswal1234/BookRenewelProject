using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    internal interface ILibraryOperation
    {
        public List<BookResultByStatus> getBookResultByStatus(List<BookDetails> listofBooks, List<BookRenewel> listofBookRental);
        public List<UserResultByNumberOfBooks> getUserResultByNumberOfBooks(List<BookDetails> listofBooks, List<BookRenewel> listofBookRental);
    }
}
