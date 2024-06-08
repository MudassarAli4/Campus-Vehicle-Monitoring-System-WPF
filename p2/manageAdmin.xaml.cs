using MaterialDesignThemes.Wpf;

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
    public partial class manageAdmin : Page
    {

        CUsersAhmadMurtazaDocumentsEndMdfContext dbb = new CUsersAhmadMurtazaDocumentsEndMdfContext();
       
        public manageAdmin()
        {
            InitializeComponent();
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            mygrid.ItemsSource = dbb.Users.ToList();
        }

        //private void add_btn(object sender, RoutedEventArgs e)
        //{

        //    try
        //    {
        //        User newAdmin = new User
        //        {
        //            Name = txtName.Text,
        //            Phone = txtPhone.Text,
        //            Cnic = txtCNIC.Text,
        //            Password = txtPassword.Text,
        //            Role = (RoleComboBox.SelectedItem as ComboBoxItem)?.Content.ToString()
        //        };

        //        dbb.Users.Add(newAdmin);
        //        dbb.SaveChanges();

        //        RefreshDataGrid();

        //        // Show message box depending on the role
        //        switch (newAdmin.Role)
        //        {
        //            case "Admin":
        //                MessageBox.Show("Admin added successfully!");
        //                break;
        //            case "Guard":
        //                MessageBox.Show("Guard added successfully!");
        //                break;
        //            case "SuperAdmin":
        //                MessageBox.Show("SuperAdmin added successfully!");
        //                break;
        //            default:
        //                MessageBox.Show("User added successfully!");
        //                break;
        //        }

        //        // Clear the text boxes and reset ComboBox selection
        //        txtName.Text = "";
        //        txtPhone.Text = "";
        //        txtCNIC.Text = "";
        //        txtPassword.Text = "";
        //        RoleComboBox.SelectedIndex = -1; // Clear the selected item in the ComboBox
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error Registration: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        //    }

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

                // If all validations pass, proceed to add the user
                User newAdmin = new User
                {
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    Cnic = txtCNIC.Text,
                    Password = txtPassword.Text,
                    Role = (RoleComboBox.SelectedItem as ComboBoxItem)?.Content.ToString()
                };

                dbb.Users.Add(newAdmin);
                dbb.SaveChanges();

                RefreshDataGrid();

                // Show message box depending on the role
                switch (newAdmin.Role)
                {
                    case "Admin":
                        MessageBox.Show("Admin added successfully!");
                        break;
                    case "Guard":
                        MessageBox.Show("Guard added successfully!");
                        break;
                    case "SuperAdmin":
                        MessageBox.Show("SuperAdmin added successfully!");
                        break;
                    default:
                        MessageBox.Show("User added successfully!");
                        break;
                }

                // Clear the text boxes and reset ComboBox selection
                txtName.Text = "";
                txtPhone.Text = "";
                txtCNIC.Text = "";
                txtPassword.Text = "";
                RoleComboBox.SelectedIndex = -1; // Clear the selected item in the ComboBox
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Registration: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        //private void update_btn(object sender, RoutedEventArgs e)
        //{
        //    // Check if there is a selected user
        //    if (mygrid.SelectedItem != null)
        //    {
        //        // Get the selected user
        //        User selectedUser = (User)mygrid.SelectedItem;

        //        // Update the properties of the selected user
        //        selectedUser.Name = txtName.Text;
        //        selectedUser.Phone = txtPhone.Text;
        //        selectedUser.Cnic = txtCNIC.Text;
        //        selectedUser.Password = txtPassword.Text;
        //        selectedUser.Role = (RoleComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();

        //        try
        //        {
        //            // Save changes to the database
        //            dbb.SaveChanges();

        //            // Refresh the DataGrid to reflect the changes
        //            RefreshDataGrid();

        //            // Display a success message
        //            MessageBox.Show("User updated successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        //        }
        //        catch (Exception ex)
        //        {
        //            // Display an error message if there is an exception
        //            MessageBox.Show($"Error updating user: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        //        }
        //    }
        //    else
        //    {
        //        // Display a message if no user is selected
        //        MessageBox.Show("Please select a user to update.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        //    }
        //}

        private void update_btn(object sender, RoutedEventArgs e)
        {
            try
            {
                // Check if there is a selected user
                if (mygrid.SelectedItem != null)
                {
                    // Get the selected user
                    User selectedUser = (User)mygrid.SelectedItem;

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

                    // Update the properties of the selected user
                    selectedUser.Name = txtName.Text;
                    selectedUser.Phone = txtPhone.Text;
                    selectedUser.Cnic = txtCNIC.Text;
                    selectedUser.Password = txtPassword.Text;
                    selectedUser.Role = (RoleComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();

                    // Save changes to the database
                    dbb.SaveChanges();

                    // Refresh the DataGrid to reflect the changes
                    RefreshDataGrid();

                    // Display a success message
                    MessageBox.Show("User updated successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    // Display a message if no user is selected
                    MessageBox.Show("Please select a user to update.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                // Display an error message if there is an exception
                MessageBox.Show($"Error updating user: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void mygrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Check if there is a selected item
            if (mygrid.SelectedItem != null)
            {
                // Get the selected User object
                User selectedUser = (User)mygrid.SelectedItem;

                // Set the TextBoxes and ComboBox with the values from the selected User object
                txtName.Text = selectedUser.Name;
                txtPhone.Text = selectedUser.Phone;
                txtCNIC.Text = selectedUser.Cnic;
                txtPassword.Text = selectedUser.Password;
                RoleComboBox.SelectedItem = RoleComboBox.Items.Cast<ComboBoxItem>()
                    .FirstOrDefault(item => item.Content.ToString() == selectedUser.Role);
            }
        }

        private void del_btn(object sender, RoutedEventArgs e)
        {
            // Get the selected row
            var selectedRow = (mygrid.SelectedItem as User);

            if (selectedRow != null)
            {
                // Remove the selected row from the DataGrid's item source
                dbb.Users.Remove(selectedRow);
                dbb.SaveChanges();

                // Refresh the DataGrid to reflect the changes
                RefreshDataGrid();

                // Display a success message
                MessageBox.Show("Row deleted successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            string searchText = txtSearch.Text.Trim(); // Get the text from the search TextBox

            if (!string.IsNullOrEmpty(searchText)) // Check if the search text is not empty
            {
                // Filter the data based on the search text
                var filteredData = dbb.Users.Where(user => user.Name.Contains(searchText)).ToList();

                // Update the DataGrid with the filtered data
                mygrid.ItemsSource = filteredData;
            }
            else
            {
                // If the search text is empty, refresh the DataGrid to show the original data
                RefreshDataGrid();
            }


        }

    }
}
