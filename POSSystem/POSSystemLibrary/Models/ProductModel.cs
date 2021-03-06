﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSSystemLibrary.Models
{
    public class ProductModel
    {
        public int Id_Product { get; set; }
        public string Code { get; set; }
        public int Id_Brand { get; set; }
        public int Id_Subcategory { get; set; }
        public string Description { get; set; }
        public int Quantity_Stock { get; set; }
        public decimal Price { get; set; }
        public decimal Lower_Price { get; set; }
        public byte[] Image { get; set; }
        public bool Ivi { get; set; }
    }
}
