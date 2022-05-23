using StudentInfoSystem.Command;
using StudentInfoSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace StudentInfoSystem.ViewModel
{
    public class LoginVM : ObservableObject
    {
        private UserLoginModel _userLogin;

        public UserLoginModel UserLoginModel
        {
            get { return _userLogin; }
            set { _userLogin = value; RaisePropertyChangedEvent("UserLogin"); }
        }

        private LoginCommand _loginCommand = new LoginCommand();

        public LoginCommand LoginCommand
        {
            get { return _loginCommand; }
        }

        public LoginVM()
        {
            _userLogin = new UserLoginModel();
        }
    }
}
