using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Brooke Daniels
// Project 3

namespace P3starter
{
    class Research
    {
        public List<ByInterestArea> byInterestArea { get; set; }
        public List<ByFaculty> byFaculty { get; set; }
    }

    class ByInterestArea
    {
        public string areaName { get; set; }
        public string[] citations { get; set; }
    }

    class ByFaculty
    {
        public string facultyName { get; set; }
        public string username { get; set; }
        public string[] citations { get; set; }
    }
}
