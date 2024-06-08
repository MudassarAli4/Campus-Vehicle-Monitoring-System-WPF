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
    /// Interaction logic for admin1.xaml
    /// </summary>
    public partial class admin1 : Window
    {
        bus_register b1 = new bus_register();
        MainWindow mainWindow = new MainWindow();
        manageGuard g1 = new manageGuard();
        report r1=new report();
        public admin1()
        {
            InitializeComponent();
            AdminFrame.Content = g1; 
            AdminFrame.Content = b1;
            AdminFrame.Content = r1;
        }
        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            // Close the current SuperAdmin window
            this.Close();

            // Open a new instance of the MainWindow

            mainWindow.Show();
        }
        private void guard_Button_Click(object sender, RoutedEventArgs e)
        {
            AdminFrame.Content = g1;
        }

        private void vehicle_Button_Click(object sender, RoutedEventArgs e)
        {
            AdminFrame.Content = b1;
        }

        private void report_page(object sender, RoutedEventArgs e)
        {
            AdminFrame.Content = r1;
        }
    }
}
