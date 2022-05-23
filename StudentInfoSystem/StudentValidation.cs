using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    public class StudentValidation
    {
        public Student GetStudentDataByUser(User user)
        {
            if (TestStudentsIfEmpty())
            {
                CopyTestStudents();
            }

            Student student;
            if (user != null && user.FakNum != null)
            {
                student = (from s in new StudentInfoContext().Students
                           where s.FacNum.Equals(user.FakNum)
                           select s).DefaultIfEmpty(null).First() ?? throw new StudentNotFoundException("Student was not found");
            }
            else
            {
                throw new UserNotValidException("User data is not valid");
            }

            return student;
        }
        private void CopyTestStudents()
        {
            StudentInfoContext context = new StudentInfoContext();
            StudentData sd = new StudentData();
            foreach (Student student in StudentData.TestStudents)
            {
                context.Students.Add(student);
            }

            context.SaveChanges();
        }

        public bool TestStudentsIfEmpty()
        {
            StudentInfoContext context = new StudentInfoContext();
            IEnumerable<Student> students = context.Students;
            int studentsCount = students.Count();
            return studentsCount == 0;
        }

    }
}