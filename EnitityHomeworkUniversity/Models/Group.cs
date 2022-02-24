using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnitityHomeworkUniversity.Models
{
    public class Group : BaseEntity
    {
        public String Name { get; set; }

        public DateTime OpenedDate { get; set; }


        public virtual Teacher Teacher { get; set; }

        public virtual ICollection<Student> Students { get; set; }

        public Group()
        {
            Students = new List<Student>();
        }
    }
}
