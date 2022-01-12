﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerVO
{
    public class MaterialVO
    {
        public string MaterialID { get; set; }
        public string MaterialName { get; set; }
        public string MaterialType { get; set; }
        public string MaterialUnit { get; set; }
        public string MatStock { get; set; }
        public string MaterialImage { get; set; }
        public string MatCategory { get; set; }       
        public int SafeStock { get; set; }
        public int EmergenctStock { get; set; }
        public int MaterialToDate { get; set; }
        public string MainCustomer { get; set; }
        public int MatPrice { get; set; }


    }
}
