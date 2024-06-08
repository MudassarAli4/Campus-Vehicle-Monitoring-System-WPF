using Microsoft.Data.SqlClient;
using System.Windows;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using p2.Model9;



namespace p2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        //  database connection
        private readonly CUsersAhmadMurtazaDocumentsEndMdfContext db;

        // Constructor
        public MainWindow()
        {
            InitializeComponent();
            db = new CUsersAhmadMurtazaDocumentsEndMdfContext();
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            // Validate user credentials
            bool isAuthenticated = ValidateCredentials(username, password);

            if (isAuthenticated)
            {
                // Retrieve user role from the database
                string userRole = GetUserRole(username);

                // Perform actions based on user role
                switch (userRole)
                {
                    case "Admin":
                        // Navigate to Admin Dashboard or perform admin-related actions
                        MessageBox.Show("Welcome, Admin!");

                        admin1 ad = new admin1();
                        ad.Show();
                        this.Close();
                        break;
                    case "SuperAdmin":
                        // Navigate to SuperAdmin Dashboard or perform SuperAdmin-related actions
                        MessageBox.Show("Welcome, SuperAdmin!");
                        SuperAdmin superAdminWindow = new SuperAdmin();
                        superAdminWindow.Show();
                        this.Close();
                        break;
                    case "Guard":
                        // Navigate to Guard Dashboard or perform Guard-related actions
                        MessageBox.Show("Welcome, Guard!");
                        InOutWindow guardWindow = new InOutWindow();
                        guardWindow.Show();
                        this.Close();
                        break;
                    default:
                        MessageBox.Show("Invalid user role.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private bool ValidateCredentials(string username, string password)
        {
            // Check if the username and password match any user record in the database
            return db.Users.Any(u => u.Name == username && u.Password == password);
        }

        private string GetUserRole(string username)
        {
            // Retrieve the user record based on the username
            var user = db.Users.FirstOrDefault(u => u.Name == username);

            if (user != null)
            {
                // Return the role of the user directly from the database
                return user.Role;
            }

            return "Unknown";
        }


        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Background = System.Windows.Media.Brushes.Black;
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
