﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Brooke Daniels
// Project 3

namespace P3starter
{
    public class News
    {
        public List<Older> older { get; set; }
    }

    public class Older
    {
        public string date { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }
}
