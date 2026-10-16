using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Student
    {
        public int ID { get; set; }
        public string FullName { get; set; } = "";
        public double Grade { get; set; }
    }
}
