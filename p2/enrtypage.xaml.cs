
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
    /// Interaction logic for enrtypage.xaml
    /// </summary>
    
    public partial class enrtypage : Page
    {
        private readonly CUsersAhmadMurtazaDocumentsEndMdfContext db;

        public enrtypage()
        {
            InitializeComponent();
            db = new CUsersAhmadMurtazaDocumentsEndMdfContext();
            LoadVehicleNoPlates();
            LoadEntries();
        }

        private void LoadVehicleNoPlates()
        {
            try
            {
                // Retrieve all vehicle plates from the Vehicles table
                var vehiclePlates = db.Vehicles.Select(v => v.Vplate).ToList();

                // Set the items source of the ComboBox to the list of plates
                cmbVehicleNoPlate.ItemsSource = vehiclePlates;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading vehicle plates: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //private void InBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    string selectedPlate = cmbVehicleNoPlate.SelectedItem as string;
        //    if (selectedPlate != null)
        //    {
        //        // Save the entry in the database
        //        db.InOuts.Add(new InOut
        //        {
        //            VehicleId = db.Vehicles.FirstOrDefault(v => v.Vplate == selectedPlate)?.Vid ?? 0,
        //            EntryDateTime = DateTime.Now
        //        });
        //        db.SaveChanges();

        //        // Refresh the DataGrid
        //        LoadEntries();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please select a vehicle plate.");
        //    }
        //}
        private void InBtn_Click(object sender, RoutedEventArgs e)
        {
            string selectedPlate = cmbVehicleNoPlate.SelectedItem as string;
            if (selectedPlate != null)
            {
                var selectedVehicle = db.Vehicles.FirstOrDefault(v => v.Vplate == selectedPlate);
                if (selectedVehicle != null)
                {
                    MessageBoxResult result = MessageBox.Show($"Vehicle Name: {selectedVehicle.Vname}\n" +
                                                                $"Vehicle Type: {selectedVehicle.Vtype}\n" +
                                                                $"Vehicle Plate: {selectedVehicle.Vplate}\n" +
                                                                $"Vehicle Owner: {selectedVehicle.Vowner}\n\n" +
                                                                $"Confirm vehicle entry?", "Confirm Entry", MessageBoxButton.OKCancel, MessageBoxImage.Information);

                    if (result == MessageBoxResult.OK)
                    {
                        db.InOuts.Add(new InOut
                        {
                            VehicleId = selectedVehicle.Vid,
                            EntryDateTime = DateTime.Now
                        });
                        db.SaveChanges();

                        // Refresh the DataGrid
                        LoadEntries();
                    }
                }
                else
                {
                    MessageBox.Show("Selected vehicle not found.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a vehicle plate.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void OutBtn_Click(object sender, RoutedEventArgs e)
        {
            // Check if a vehicle plate is selected in the combo box
            if (cmbVehicleNoPlate.SelectedItem != null)
            {
                string selectedPlate = cmbVehicleNoPlate.SelectedItem.ToString();

                // Retrieve the corresponding entry from the InOuts table based on the selected plate
                var selectedEntry = db.InOuts.FirstOrDefault(io => io.Vehicle.Vplate == selectedPlate && io.ExitDateTime == null);

                if (selectedEntry != null)
                {
                    // Update the exit date and time for the selected entry
                    selectedEntry.ExitDateTime = DateTime.Now;

                    // Save changes to the database
                    db.SaveChanges();

                    // Refresh the DataGrid
                    LoadEntries();
                }
                else
                {
                    MessageBox.Show("No entry found for the selected vehicle plate or the vehicle has already exited.");
                }
            }
            else
            {
                MessageBox.Show("Please select a vehicle plate.");
            }
        }


        private void mygrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Check if an item is selected
            if (mygrid.SelectedItem != null)
            {
                // Get the selected item from the DataGrid (assuming it's an InOut object)
                InOut selectedEntry = mygrid.SelectedItem as InOut;

                // Retrieve the associated Vehicle from the database based on the VehicleId
                Vehicle selectedVehicle = db.Vehicles.FirstOrDefault(v => v.Vid == selectedEntry.VehicleId);

                if (selectedVehicle != null)
                {
                    // Display details about the selected vehicle
                    MessageBox.Show($"Vehicle Name: {selectedVehicle.Vname}\n" +
                                    $"Vehicle Type: {selectedVehicle.Vtype}\n" +
                                    $"Vehicle Plate: {selectedVehicle.Vplate}\n" +
                                    $"Vehicle Owner: {selectedVehicle.Vowner}");
                }
                else
                {
                    // If the associated vehicle is not found, display a message
                    MessageBox.Show("Selected vehicle information not found.");
                }
            }
        }

        private void LoadEntries()
        {
            // Retrieve all entries from the InOuts table and bind them to the DataGrid
            mygrid.ItemsSource = db.InOuts.ToList();
        }

    }

}
