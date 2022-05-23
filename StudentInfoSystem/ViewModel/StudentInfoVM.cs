using StudentInfoSystem.Command;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using UserLogin;

namespace StudentInfoSystem
{
    internal class StudentInfoVM : ObservableObject
    {
        private Student _student;
        public Student Student
        {
            get { return _student; }
            set { _student = value; RaisePropertyChangedEvent("Student"); }
        }

        private User _user;

        public User User
        {
            set
            {
                if (_user == null)
                {
                    _user = value;
                }
            }
            get { return _user; }
        }

        public List<string> StudStatusChoices { get; set; }

        private InitDataCommand _initDataCommand = new InitDataCommand();

        public InitDataCommand InitDataCommand
        {
            get { return _initDataCommand; }
        }

        public StudentInfoVM(User user)
        {
            var studentValidation = new StudentValidation();
            User = user;
            Student = studentValidation.GetStudentDataByUser(user);
            FillStudStatusChoices();
        }

        private void FillStudStatusChoices()
        {
            StudStatusChoices = new List<string>();
            using (IDbConnection connection = new SqlConnection(Properties.Settings.Default.DbConnect))
            {
                string sqlquery = @"SELECT StatusDescr FROM StudStatus";
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                connection.Open();
                command.CommandText = sqlquery;
                IDataReader reader = command.ExecuteReader();
                bool notEndOfResult;
                notEndOfResult = reader.Read();
                while (notEndOfResult)

                {
                    string s = reader.GetString(0);
                    StudStatusChoices.Add(s);
                    notEndOfResult = reader.Read();
                }
            }
        }
    }
}
