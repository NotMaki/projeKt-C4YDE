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

namespace projeKt_C4YDE
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }


        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.ShowDialog();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void ShowPassword_OnClick(object sender, RoutedEventArgs e)
        {
            {
                if (togglepassword.Content == FindResource("Show"))
                {
                    togglepassword.Content = FindResource("Hide");

                    MyPasswordBox.Visibility = System.Windows.Visibility.Collapsed;
                    MyTextBox.Visibility = System.Windows.Visibility.Visible;

                    MyTextBox.Focus();
                }
                else
                {
                    togglepassword.Content = FindResource("Show");
                    MyPasswordBox.Visibility = System.Windows.Visibility.Visible;
                    MyTextBox.Visibility = System.Windows.Visibility.Collapsed;

                    MyPasswordBox.Focus();
                }
            }


        }
    }
}
