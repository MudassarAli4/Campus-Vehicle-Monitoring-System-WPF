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

namespace p2
{
    /// <summary>
    /// Interaction logic for SuperAdmin.xaml
    /// </summary>
    public partial class SuperAdmin : Window
    {
        manageAdmin m1=new manageAdmin();
        //manageGuard m2=new manageGuard();
        MainWindow mainWindow = new MainWindow();
        public SuperAdmin()
        {
            InitializeComponent();
            myframe.Content= m1;
         /*   myframe.Content= m2*/;
        }

        private void AdminButton_Click(object sender, RoutedEventArgs e)
        {
            myframe.Content = m1;
        }

        //private void GuardButton_Click(object sender, RoutedEventArgs e)
        //{
        //    myframe.Content = m2;
        //}

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            // Close the current SuperAdmin window
            this.Close();

            // Open a new instance of the MainWindow
            
            mainWindow.Show();
        }
    }
}
