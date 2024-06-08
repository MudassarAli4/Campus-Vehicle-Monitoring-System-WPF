
using p2.Model9;
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

namespace p2
{
    /// <summary>
    /// Interaction logic for bus_register.xaml
    /// </summary>
    public partial class bus_register : Page
    {
        private readonly CUsersAhmadMurtazaDocumentsEndMdfContext db;

        public bus_register()
        {
            InitializeComponent();
            db = new CUsersAhmadMurtazaDocumentsEndMdfContext(); // Instantiate your DbContext
            LoadVehicles(); // Load existing vehicles from the database
        }

        private void LoadVehicles()
        {
            // Load existing vehicles from the database and set them as the DataGrid's item source
            mygrid.ItemsSource = db.Vehicles.ToList();
        }

        //private void add_btn(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        // Create a new Vehicle object with the data from the text boxes
        //        Vehicle newVehicle = new Vehicle
        //        {
        //            Vname = txtVehicleName.Text,
        //            Vtype = txtVehicleType.Text,
        //            Vplate = txtNoPlate.Text,
        //            Vowner = txtVehicleOwner.Text
        //        };

        //        // Add the new vehicle to the database
        //        db.Vehicles.Add(newVehicle);
        //        db.SaveChanges(); // Save changes to the database

        //        // Refresh the DataGrid to reflect the changes
        //        LoadVehicles();

        //        // Show a success message
        //        MessageBox.Show("Vehicle added successfully!");
        //    }
        //    catch (Exception ex)
        //    {
        //        // Show an error message if an exception occurs
        //        MessageBox.Show($"Error adding vehicle: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        //    }
        //}

        //private void del_btn(object sender, RoutedEventArgs e)
        //{
        //    // Get the selected vehicle from the DataGrid
        //    var selectedVehicle = mygrid.SelectedItem as Vehicle;

        //    if (selectedVehicle != null)
        //    {
        //        // Remove the selected vehicle from the database
        //        db.Vehicles.Remove(selectedVehicle);
        //        db.SaveChanges(); // Save changes to the database

        //        // Refresh the DataGrid to reflect the changes
        //        LoadVehicles();

        //        // Show a success message
        //        MessageBox.Show("Vehicle deleted successfully!");
        //    }
        //    else
        //    {
        //        // Show a message if no vehicle is selected
        //        MessageBox.Show("Please select a vehicle to delete.");
        //    }
        //}

        //private void update_btn(object sender, RoutedEventArgs e)
        //{
        //    // Get the selected vehicle from the DataGrid
        //    var selectedVehicle = mygrid.SelectedItem as Vehicle;

        //    if (selectedVehicle != null)
        //    {
        //        try
        //        {
        //            // Update the selected vehicle's properties with the data from the text boxes
        //            selectedVehicle.Vname = txtVehicleName.Text;
        //            selectedVehicle.Vtype = txtVehicleType.Text;
        //            selectedVehicle.Vplate = txtNoPlate.Text;
        //            selectedVehicle.Vowner = txtVehicleOwner.Text;

        //            // Save changes to the database
        //            db.SaveChanges();

        //            // Refresh the DataGrid to reflect the changes
        //            LoadVehicles();

        //            // Show a success message
        //            MessageBox.Show("Vehicle updated successfully!");
        //        }
        //        catch (Exception ex)
        //        {
        //            // Show an error message if an exception occurs
        //            MessageBox.Show($"Error updating vehicle: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        //        }
        //    }
        //    else
        //    {
        //        // Show a message if no vehicle is selected
        //        MessageBox.Show("Please select a vehicle to update.");
        //    }
        //}

        private void add_btn(object sender, RoutedEventArgs e)
        {
            try
            {
                // Validate input fields
                if (string.IsNullOrWhiteSpace(txtVehicleName.Text) ||
                    string.IsNullOrWhiteSpace(txtVehicleOwner.Text) ||
                    string.IsNullOrWhiteSpace(txtVehicleType.Text) ||
                    string.IsNullOrWhiteSpace(txtNoPlate.Text))
                {
                    MessageBox.Show("All fields are required.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Create a new Vehicle object with the data from the text boxes
                Vehicle newVehicle = new Vehicle
                {
                    Vname = txtVehicleName.Text,
                    Vtype = txtVehicleType.Text,
                    Vplate = txtNoPlate.Text,
                    Vowner = txtVehicleOwner.Text
                };

                // Add the new vehicle to the database
                db.Vehicles.Add(newVehicle);
                db.SaveChanges(); // Save changes to the database

                // Refresh the DataGrid to reflect the changes
                LoadVehicles();

                // Show a success message
                MessageBox.Show("Vehicle added successfully!");
            }
            catch (Exception ex)
            {
                // Show an error message if an exception occurs
                MessageBox.Show($"Error adding vehicle: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void del_btn(object sender, RoutedEventArgs e)
        {
            // Get the selected vehicle from the DataGrid
            var selectedVehicle = mygrid.SelectedItem as Vehicle;

            if (selectedVehicle != null)
            {
                // Remove the selected vehicle from the database
                db.Vehicles.Remove(selectedVehicle);
                db.SaveChanges(); // Save changes to the database

                // Refresh the DataGrid to reflect the changes
                LoadVehicles();

                // Show a success message
                MessageBox.Show("Vehicle deleted successfully!");
            }
            else
            {
                // Show a message if no vehicle is selected
                MessageBox.Show("Please select a vehicle to delete.");
            }
        }

        private void update_btn(object sender, RoutedEventArgs e)
        {
            // Get the selected vehicle from the DataGrid
            var selectedVehicle = mygrid.SelectedItem as Vehicle;

            if (selectedVehicle != null)
            {
                try
                {
                    // Validate input fields
                    if (string.IsNullOrWhiteSpace(txtVehicleName.Text) ||
                        string.IsNullOrWhiteSpace(txtVehicleOwner.Text) ||
                        string.IsNullOrWhiteSpace(txtVehicleType.Text) ||
                        string.IsNullOrWhiteSpace(txtNoPlate.Text))
                    {
                        MessageBox.Show("All fields are required.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        return;
                    }

                    // Update the selected vehicle's properties with the data from the text boxes
                    selectedVehicle.Vname = txtVehicleName.Text;
                    selectedVehicle.Vtype = txtVehicleType.Text;
                    selectedVehicle.Vplate = txtNoPlate.Text;
                    selectedVehicle.Vowner = txtVehicleOwner.Text;

                    // Save changes to the database
                    db.SaveChanges();

                    // Refresh the DataGrid to reflect the changes
                    LoadVehicles();

                    // Show a success message
                    MessageBox.Show("Vehicle updated successfully!");
                }
                catch (Exception ex)
                {
                    // Show an error message if an exception occurs
                    MessageBox.Show($"Error updating vehicle: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                // Show a message if no vehicle is selected
                MessageBox.Show("Please select a vehicle to update.");
            }
        }


        private void mygrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get the selected vehicle from the DataGrid
            var selectedVehicle = mygrid.SelectedItem as Vehicle;

            if (selectedVehicle != null)
            {
                // Populate the text boxes with the selected vehicle's data
                txtVehicleName.Text = selectedVehicle.Vname;
                txtVehicleType.Text = selectedVehicle.Vtype;
                txtNoPlate.Text = selectedVehicle.Vplate;
                txtVehicleOwner.Text = selectedVehicle.Vowner;
            }
        }
    }
}
