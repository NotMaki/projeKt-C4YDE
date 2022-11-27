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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace projeKt_C4YDE
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            this.Close();
            register.ShowDialog();

        }

        private void ShowPassword_OnClick(object sender, RoutedEventArgs e)
        {
            {
                if (togglepassword.Content == FindResource("Show"))
                {
                    togglepassword.Content = FindResource("Hide");
                }
                else
                {
                    togglepassword.Content = FindResource("Show");
                }
            }
        }
    }
}
