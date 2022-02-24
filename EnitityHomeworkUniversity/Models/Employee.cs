using EnitityHomeworkUniversity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnitityHomeworkUniversity.Models
{
    public class Employee : Person
    {
        public int Experience { get; set; }

        public DateTime StartDate { get; set; }

        public string CardNumber { get; set; }

        public Department Department { get; set; }
    }
}
