using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Brooke Daniels
// Project 3

namespace P3starter
{
    class Employment
    {
        public Introduction introduction { get; set; }
        public DegreeStatistics degreeStatistics { get; set; }
        public CoopTable coopTable { get; set; }
        public EmploymentTable employmentTable { get; set; }
        public Employers employers { get; set; }
        public Careers careers { get; set; }
    }

    class Introduction
    {
        public string title { get; set; }
        public List<Content> content { get; set; }
    }

    class Content
    {
        public string title { get; set; }
        public string description { get; set; }
    }

    class CoopTable
    {
        public string title { get; set; }
        public List<CoopInformation> coopInformation { get; set; }
    }

    class CoopInformation
    {
        public string employer { get; set; }
        public string degree { get; set; }
        public string city { get; set; }
        public string term { get; set; }
    }

    class EmploymentTable
    {
        public string title { get; set; }
        public List<ProfessionalEmploymentInformation> professionalEmploymentInformation { get; set; }
    }

    class ProfessionalEmploymentInformation
    {
        public string employer { get; set; }
        public string degree { get; set; }
        public string city { get; set; }
        public string title { get; set; }
        public string startDate { get; set; }
    }

    class DegreeStatistics
    {
        public string title { get; set; }
        public List<Statistics> statistics { get; set; }
    }

    class Statistics
    {
        public string value { get; set; }
        public string description { get; set; }
    }

    class Employers
    {
        public string title { get; set; }
        public string[] employerNames { get; set; }
    }

    class Careers
    {
        public string title { get; set; }
        public string[] careerNames { get; set; }
    }
}
