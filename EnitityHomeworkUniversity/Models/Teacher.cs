using EnitityHomeworkUniversity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnitityHomeworkUniversity.Models
{
    public class Teacher : Employee
    {
        public Subject Subject { get; set; }

        public virtual ICollection<Group> Groups { get;  }

        public Teacher()
        {
            Groups = new List<Group>();
        }
    }
}
