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

namespace RemakeProject.Views
{
    /// <summary>
    /// Логика взаимодействия для LoginMenu.xaml
    /// </summary>
    public partial class LoginMenu : Window
    {
        public LoginMenu()
        {
            InitializeComponent();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {

            Application.Current.Shutdown();
        }

    }
}
