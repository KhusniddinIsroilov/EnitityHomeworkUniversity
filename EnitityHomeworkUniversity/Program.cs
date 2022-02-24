using EnitityHomeworkUniversity.Data.IRepositories;
using EnitityHomeworkUniversity.Data.Repositories;
using EnitityHomeworkUniversity.Enums;
using EnitityHomeworkUniversity.Models;
using System;
using System.Threading.Tasks;

namespace EnitityHomeworkUniversity
{
    internal class Program
    {
        
       
       
       
        static async Task Main(string[] args)
        {

            IEmployeeRepository employeeRepository = new EmployeeRepository();
            IGroupRepository groupRepository = new GroupRepository();
            ITeacherRepository teacherRepository = new TeacherRepository();
            IStudentRepository studentRepository = new StudentRepository();

            Teacher teacher = new Teacher()
            {
                Id = 1,
                Firstname = "Mirkomil",
                Lastname = "Meliqoziyev",
                Gender = Gender.Male,
                BirthDate = DateTime.Now,
                PhoneNumber = "90069390"

            };

              await  teacherRepository.CreateAsync(teacher);

        }
    }
}
