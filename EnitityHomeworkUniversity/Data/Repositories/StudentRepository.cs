using EnitityHomeworkUniversity.Data.IRepositories;
using EnitityHomeworkUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnitityHomeworkUniversity.Data.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
    }
}
