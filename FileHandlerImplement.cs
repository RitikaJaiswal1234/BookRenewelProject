using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class FileHandlerImplement : IFileHandler
    {
        public string[] readFile(string Path)
        {
            string[] lines = System.IO.File.ReadAllLines(Path);
            return lines;
        }

        public void writeFile(string path, List<BookResultByStatus>resultList)
        {
            using (StreamWriter file = new StreamWriter(path))
                foreach (var entry in resultList)
                    file.WriteLine(entry);
        }
        public void writeFile(string path, List<UserResultByNumberOfBooks> resultList)
        {
            using (StreamWriter file = new StreamWriter(path))
                foreach (var entry in resultList)
                    file.WriteLine(entry);
        }

    }
}
