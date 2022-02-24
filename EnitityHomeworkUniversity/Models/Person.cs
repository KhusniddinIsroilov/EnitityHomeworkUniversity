using EnitityHomeworkUniversity.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnitityHomeworkUniversity.Models
{
    public abstract class Person : BaseEntity
    {
        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }
      
        public DateTime BirthDate { get; set; }

        public string PhoneNumber { get; set; }

        public Gender Gender { get; set; }



    }
}
