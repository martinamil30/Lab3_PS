using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using UserLogin;

namespace StudentInfoSystem
{
 
    public partial class StudentInfo : Window
    {

        private StudentInfoVM vm;

        public StudentInfo()
        {
            InitializeComponent();
        }

        public StudentInfo(User user)
        {
            vm = new StudentInfoVM(user);
            this.DataContext = vm;
            InitializeComponent();
        }

        public void EnterStudentData(Student student)
        {
            inputFirstName.Text = student.FirstName;
            inputSecondName.Text = student.SecondName;
            inputLastName.Text = student.LastName;
            inputFac.Text = student.Faculty;
            inputMajor.Text = student.Major;
            inputOKS.Text = student.OKS;
            inputFacNum.Text = student.FacNum;
            inputCourse.Text = student.Course.ToString();
            inputStream.Text = student.Stream.ToString();
            inputGroup.Text = student.Group.ToString();
        }

        public void CleanInputs()
        {
            foreach (var item in MainGrid.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text = "";
                }
            }
        }
        public void EnableInputs()
        {
            foreach (var item in MainGrid.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = true;
                }
            }
        }
        public void DisableInputs()
        {
            foreach (var item in MainGrid.Children)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).IsEnabled = false;
                }
            }
        }
    }
}