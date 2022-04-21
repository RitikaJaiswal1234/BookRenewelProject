using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class ExcecuteFile
    {
        public static void Main(String[] args)
        {
            FileHandlerImplement file = new FileHandlerImplement();
            String[] linesofBook = file.readFile(@"C:\Users\Ritika Jaiswal\Desktop\Book.csv");
            String[] linesofBookRental = file.readFile(@"C:\Users\Ritika Jaiswal\Desktop\BookRenewel.csv");
            CreateList createList = new CreateList();
            List<BookDetails> listofBooks = createList.createListofBooks(linesofBook);
            List<BookRenewel> listofBookRental = createList.createListofBookRental(linesofBookRental);
            LibraryOperationImpl opt = new LibraryOperationImpl();
            List<BookResultByStatus> resultListBook = opt.getBookResultByStatus(listofBooks, listofBookRental);
            file.writeFile("C:\\Users\\Ritika Jaiswal\\Documents\\result1.csv", resultListBook);


            List<UserResultByNumberOfBooks> resultlistUser = opt.getUserResultByNumberOfBooks(listofBooks, listofBookRental);
            file.writeFile("C:\\Users\\Ritika Jaiswal\\Documents\\result2.csv", resultlistUser);
        }
    }
}
             
            
                
            
            

           
            
        
    
