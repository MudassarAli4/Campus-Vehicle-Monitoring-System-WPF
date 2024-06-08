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
    /// Interaction logic for report.xaml
    /// </summary>
    public partial class report : Page
    {
        private readonly CUsersAhmadMurtazaDocumentsEndMdfContext db;
        public report()
        {
            InitializeComponent();
            db = new CUsersAhmadMurtazaDocumentsEndMdfContext();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FilterButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected start and end dates from the DatePicker controls
            DateTime startDate = startDatePicker.SelectedDate ?? DateTime.MinValue;
            DateTime endDate = endDatePicker.SelectedDate ?? DateTime.MaxValue;

            try
            {
                // Retrieve reports data based on the date range
                var reports = db.InOuts
                    .Where(io => io.EntryDateTime >= startDate && io.EntryDateTime <= endDate)
                    .Select(io => new
                    {
                        io.EntryId,
                        io.VehicleId,
                        io.EntryDateTime,
                        io.ExitDateTime
                    })
                    .ToList();

                // Bind the filtered reports data to the DataGrid
                mygrid.ItemsSource = reports;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving reports: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //private void GenerateReportButton_Click(object sender, RoutedEventArgs e)
        //{
        //    // Get the selected date from the DatePicker control
        //    DateTime selectedDate = startDatePicker.SelectedDate ?? DateTime.MinValue;

        //    try
        //    {
        //        // Retrieve reports data for the selected date
        //        var reports = db.InOuts
        //            .Where(io => io.EntryDateTime.Date == selectedDate.Date) // Filter by the selected date
        //            .Select(io => new
        //            {
        //                io.EntryId,
        //                io.VehicleId,
        //                io.EntryDateTime,
        //                io.ExitDateTime
        //            })
        //            .ToList();

        //        // Generate report content
        //        StringBuilder reportContent = new StringBuilder();
        //        reportContent.AppendLine($"Report for {selectedDate.ToShortDateString()}:");
        //        foreach (var report in reports)
        //        {
        //            reportContent.AppendLine($"Entry ID: {report.EntryId}, Vehicle ID: {report.VehicleId}, Entry DateTime: {report.EntryDateTime}, Exit DateTime: {report.ExitDateTime}");
        //        }

        //        // Save report to a text file
        //        string fileName = $"Report_{selectedDate.ToString("yyyyMMdd")}.txt"; // Format file name with date
        //        string filePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);
        //        System.IO.File.WriteAllText(filePath, reportContent.ToString());

        //        MessageBox.Show($"Report generated successfully and saved to {filePath}", "Report Generated", MessageBoxButton.OK, MessageBoxImage.Information);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error generating report: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        //    }
        //}





        private void GenerateReportButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected date from the DatePicker control
            DateTime selectedDate = startDatePicker.SelectedDate ?? DateTime.MinValue;

            try
            {
                // Retrieve reports data for the selected date
                var reports = db.InOuts
                    .Where(io => io.EntryDateTime.Date == selectedDate.Date) // Filter by the selected date
                    .Select(io => new
                    {
                        io.EntryId,
                        io.VehicleId,
                        io.EntryDateTime,
                        io.ExitDateTime,
                        Vehicle = io.Vehicle // Include full vehicle details
                    })
                    .ToList();

                // Generate report content
                StringBuilder reportContent = new StringBuilder();
                reportContent.AppendLine($"Report for {selectedDate.ToShortDateString()}:\n");

                foreach (var report in reports)
                {
                    reportContent.AppendLine($"Entry ID: {report.EntryId}, Vehicle ID: {report.VehicleId}, Entry DateTime: {report.EntryDateTime}, Exit DateTime: {report.ExitDateTime}");

                    // Vehicle details
                    reportContent.AppendLine("Vehicle Details:");
                    reportContent.AppendLine($"    Vehicle ID: {report.Vehicle.Vid}");
                    reportContent.AppendLine($"    Vehicle Name: {report.Vehicle.Vname}");
                    reportContent.AppendLine($"    Vehicle Type: {report.Vehicle.Vtype}");
                    reportContent.AppendLine($"    Vehicle Plate: {report.Vehicle.Vplate}");
                    reportContent.AppendLine($"    Vehicle Owner: {report.Vehicle.Vowner}");

                    reportContent.AppendLine(); // Add an empty line for separation
                }

                // Save report to a text file
                string fileName = $"Report_{selectedDate.ToString("yyyyMMdd")}.txt"; // Format file name with date
                string filePath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);
                System.IO.File.WriteAllText(filePath, reportContent.ToString());

                MessageBox.Show($"Report generated successfully and saved to {filePath}", "Report Generated", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }








    }
}
