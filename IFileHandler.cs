﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public interface IFileHandler
    {
        public string[] readFile(string path);



    }
}
