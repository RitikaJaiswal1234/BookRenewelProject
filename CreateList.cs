using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    internal class CreateList
    {
        public List<BookDetails> createListofBooks(String[] lines)
        {
            List<BookDetails> list = new List<BookDetails>();
            foreach (string line in lines)
            {
                String[] columns = line.Split(',');
                list.Add(new BookDetails(Convert.ToInt32(columns[0]), columns[1], Convert.ToInt32(columns[2]), Convert.ToInt32(columns[3]), columns[4]));
            }
            return list;

        }
        public List<BookRenewel> createListofBookRental(String[] lines)
        {
            List<BookRenewel> list = new List<BookRenewel>();
            foreach (string line in lines)
            {
                String[] columns = line.Split(',');
                list.Add(new BookRenewel(Convert.ToInt32(columns[0]), columns[1],
                    Convert.ToInt32(columns[2]), Convert.ToDateTime(columns[3]), columns[4], Convert.ToDateTime(columns[5]), Convert.ToInt32(columns[6])));
            }
            return list;

        }
    }

}
