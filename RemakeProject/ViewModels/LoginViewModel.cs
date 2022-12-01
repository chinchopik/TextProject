using RemakeProject.ViewModels.Commands;
using RemakeProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace RemakeProject.ViewModels
{
    /// <summary>
    /// Логика взаимодействия для LoginMenu.xaml
    /// </summary>
    class LoginViewModel : ViewModelBase
    {

        private string _password;
        public string Login
        {
            get => Properties.Settings.Default.UserLogin;
            set
            {
                Properties.Settings.Default.UserLogin = value;
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged("Password");
            }
        }


        public Auth Authentification { get; private set; }

        public LoginViewModel()
        {
            Authentification = new Auth(Auth);
        }

        public void Auth()
        {

            if (Properties.Settings.Default.UserLogin == "admin" && Password == "admin")
            {
                AnalyzerMenu analyzerMenu = new();

                Window window = Application.Current.MainWindow;
                window.Close();
                analyzerMenu.Show();
            }
            else
            {
                MessageBox.Show("Invalid login or password!", "Error!");
            }

        }

        private bool _isChecked;

        public bool IsChecked
        {
            get => _isChecked;
            set
            {
                if (_isChecked == value) return;
                _isChecked = value;
            }
        }
    }
}
