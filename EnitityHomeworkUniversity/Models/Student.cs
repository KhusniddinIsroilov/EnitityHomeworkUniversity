using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnitityHomeworkUniversity.Models
{
    public class Student : Person
    {
        public virtual Group Group { get; }
    }
}
