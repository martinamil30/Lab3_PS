using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem.TestData
{
    static public class StudentData
    {
        static public List<Student> TestStudents
        {
            get
            {
                ResetTestStudentData();
                return _testStudents;
            }
            set { }
        }

        static private List<Student> _testStudents;

        static private void ResetTestStudentData()
        {
            if (_testStudents == null)
            {
                _testStudents = new List<Student>
                {
                    new Student
                    {
                        FirstName = "Martina",
                        SecondName = "Goranova",
                        LastName = "Milanov",
                        Faculty = "FCST",
                        Major = "CSE",
                        OKS = "Bachelor",
                        Status = "Редовен",
                        FacNum = "123219014",
                        Course = 3,
                        Stream = 9,
                        Group = 31,
                    },
                    new Student
                    {
                        FirstName = "Yasna",
                        SecondName = "Dushanova",
                        LastName = "Vladimirov",
                        Faculty = "FCST",
                        Major = "CSE",
                        OKS = "Bachelor",
                        Status = "Редовен",
                        FacNum = "123219010",
                        Course = 1,
                        Stream = 9,
                        Group = 33,
                    },

                };
            }
        }
    }
}