﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDemo_Models.LearnBlazorModel
{
    public class Demo_Product
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public double Price { get; set; }
        public bool IsActive { get; set; }
        public IEnumerable<Demo_ProductProp> Prop { get; set; } 
    }
}
