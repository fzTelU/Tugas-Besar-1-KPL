﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes1KPL_Kelompok7
{
    public class ClassTestExistingFile
    {
        // Unit Testing untuk mengecek apakah terdapat file MoneyConfig.json pada projek ini
        public bool isExistingFileJson()
        {
            if (File.Exists("../../../../Tubes-KPL/json/MoneyConfig.json"))
            {
                return true;
            }
            return false;
        }
    }
}
