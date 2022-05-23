using StudentInfoSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StudentInfoSystem.View
{
   
    public partial class Login : Window
    {
        private LoginVM _loginVM = new LoginVM();

        public LoginVM LoginVM
        {
            get { return _loginVM; }
        }

        public Login()
        {
            this.DataContext = _loginVM;
            InitializeComponent();
        }
        private void password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            _loginVM.UserLoginModel.Password = ((PasswordBox)sender).Password;
            _loginVM.RaisePropertyChangedEvent("UserLogin");
        }

    }
}