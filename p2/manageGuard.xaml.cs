using MaterialDesignThemes.Wpf;
using Microsoft.VisualBasic.ApplicationServices;
using p2.Model9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using System.Xml.Linq;

namespace p2
{
    /// <summary>
    /// Interaction logic for manageGuard.xaml
    /// </summary>
    public partial class manageGuard : Page
    {
        private readonly CUsersAhmadMurtazaDocumentsEndMdfContext db;

        public manageGuard()
        {
            InitializeComponent();
            db = new CUsersAhmadMurtazaDocumentsEndMdfContext();
            LoadGuards();
        }

        private void LoadGuards()
        {
            mygrid.ItemsSource = db.Users.Where(u => u.Role == "Guard").ToList();
        }

        //private void add_btn(object sender, RoutedEventArgs e)
        //{
        //    // Create a new guard object
        //    p2.Model9.User newGuard = new p2.Model9.User
        //    {
        //        Name = txtName.Text,
        //        Phone = txtPhone.Text,
        //        Cnic = txtCNIC.Text,
        //        Password = txtPassword.Text,
        //        Role = "Guard"
        //    };

        //    // Add the guard to the database
        //    db.Users.Add(newGuard);
        //    db.SaveChanges();

        //    // Reload the guards in the data grid
        //    LoadGuards();
        //    MessageBox.Show("Guard added successfully.");
        //}

        private void add_btn(object sender, RoutedEventArgs e)
        {
            try
            {
                // Validate name (only characters)
                if (!Regex.IsMatch(txtName.Text, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("Name can only contain letters.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Validate password (at least one uppercase, one lowercase, one digit, and one special character)
                if (!Regex.IsMatch(txtPassword.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"))
                {
                    MessageBox.Show("Password must contain at least one uppercase letter, one lowercase letter, one digit, one special character, and be at least 8 characters long.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Validate phone number (exactly 11 digits)
                if (!Regex.IsMatch(txtPhone.Text, @"^\d{11}$"))
                {
                    MessageBox.Show("Phone number must be exactly 11 digits long.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Validate CNIC (exactly 13 digits)
                if (!Regex.IsMatch(txtCNIC.Text, @"^\d{13}$"))
                {
                    MessageBox.Show("CNIC must be exactly 13 digits long.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // If all validations pass, proceed to add the guard
                // Create a new guard object
                p2.Model9.User newGuard = new p2.Model9.User
                {
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    Cnic = txtCNIC.Text,
                    Password = txtPassword.Text,
                    Role = "Guard"
                };

                // Add the guard to the database
                db.Users.Add(newGuard);
                db.SaveChanges();

                // Reload the guards in the data grid
                LoadGuards();
                MessageBox.Show("Guard added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding guard: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void del_btn(object sender, RoutedEventArgs e)
        {
            // Get the selected guard
            p2.Model9.User selectedGuard = mygrid.SelectedItem as p2.Model9.User;
            if (selectedGuard != null)
            {
                // Remove the selected guard from the database
                db.Users.Remove(selectedGuard);
                db.SaveChanges();

                // Reload the guards in the data grid
                LoadGuards();
                MessageBox.Show("Guard deketed successfully.");
            }
            else
            {
                MessageBox.Show("Please select a guard to delete.");
            }
        }

        //private void update_btn(object sender, RoutedEventArgs e)
        //{
        //    // Get the selected guard
        //    p2.Model9.User selectedGuard = mygrid.SelectedItem as p2.Model9.User;
        //    if (selectedGuard != null)
        //    {
        //        // Update the selected guard with the new values
        //        selectedGuard.Name = txtName.Text;
        //        selectedGuard.Phone = txtPhone.Text;
        //        selectedGuard.Cnic = txtCNIC.Text;
        //        selectedGuard.Password = txtPassword.Text;

        //        // Save changes to the database
        //        db.SaveChanges();

        //        // Reload the guards in the data grid
        //        LoadGuards();
        //        MessageBox.Show("Guard updated successfully.");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please select a guard to update.");
        //    }
        //}

        private void update_btn(object sender, RoutedEventArgs e)
        {
            try
            {
                // Get the selected guard
                p2.Model9.User selectedGuard = mygrid.SelectedItem as p2.Model9.User;
                if (selectedGuard != null)
                {
                    // Validate name (only characters)
                    if (!Regex.IsMatch(txtName.Text, @"^[a-zA-Z\s]+$"))
                    {
                        MessageBox.Show("Name can only contain letters.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }

                    // Validate password (at least one uppercase, one lowercase, one digit, and one special character)
                    if (!Regex.IsMatch(txtPassword.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"))
                    {
                        MessageBox.Show("Password must contain at least one uppercase letter, one lowercase letter, one digit, one special character, and be at least 8 characters long.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }

                    // Validate phone number (exactly 11 digits)
                    if (!Regex.IsMatch(txtPhone.Text, @"^\d{11}$"))
                    {
                        MessageBox.Show("Phone number must be exactly 11 digits long.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }

                    // Validate CNIC (exactly 13 digits)
                    if (!Regex.IsMatch(txtCNIC.Text, @"^\d{13}$"))
                    {
                        MessageBox.Show("CNIC must be exactly 13 digits long.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }

                    // Update the selected guard with the new values
                    selectedGuard.Name = txtName.Text;
                    selectedGuard.Phone = txtPhone.Text;
                    selectedGuard.Cnic = txtCNIC.Text;
                    selectedGuard.Password = txtPassword.Text;

                    // Save changes to the database
                    db.SaveChanges();

                    // Reload the guards in the data grid
                    LoadGuards();
                    MessageBox.Show("Guard updated successfully.");
                }
                else
                {
                    MessageBox.Show("Please select a guard to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating guard: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void mygrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get the selected guard
            p2.Model9.User selectedGuard = mygrid.SelectedItem as p2.Model9.User;
            if (selectedGuard != null)
            {
                // Display the selected guard's information in the text boxes
                txtName.Text = selectedGuard.Name;
                txtPhone.Text = selectedGuard.Phone;
                txtCNIC.Text = selectedGuard.Cnic;
                txtPassword.Text = selectedGuard.Password;
            }
        }
    }
}
