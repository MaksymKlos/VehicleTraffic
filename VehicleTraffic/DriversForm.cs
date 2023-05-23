using Database;
using Database.Models;

namespace VehicleTraffic
{
    public partial class DriversForm : Form
    {
        private List<Driver> loadedDrivers;
        private List<Driver> updatedDrivers;
        private bool isFormReady;

        public DriversForm()
        {
            InitializeComponent();
        }

        private void DriversForm_Load(object sender, EventArgs e)
        {
            RefreshForm();
            isFormReady = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool isUpdated = false;

            for (int i = 0; i < DriversGridView.RowCount; i++)
            {
                var driver = loadedDrivers[i];
                if (updatedDrivers.Contains(driver))
                {
                    DatabaseController.DriverRepository.Update(driver);

                    isUpdated = true;
                }
            }

            updatedDrivers = new List<Driver>();

            if (isUpdated)
            {
                DriversGridView.Refresh();
                MessageBox.Show("Дані змінено!", "Успіх!");
            }
            else
            {
                MessageBox.Show("Ніяких змін не було!", "Попередження!");
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            new AddDriverForm().ShowDialog();
            RefreshForm();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var selected = (Driver)DriversGridView.SelectedRows[0].DataBoundItem;
            DatabaseController.DriverRepository.Remove(selected.Код_Водія);
            RefreshForm();
        }

        private void RefreshForm()
        {
            DriversGridView.DataSource = null;
            DriversGridView.Columns.Clear();

            loadedDrivers = DatabaseController.DriverRepository.GetAll();
            DriversGridView.DataSource = loadedDrivers;
            updatedDrivers = new List<Driver>();
        }

        private void GridViewOnCellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && isFormReady)
            {
                var driver = (Driver)DriversGridView.Rows[e.RowIndex].DataBoundItem;

                if (driver != null && !updatedDrivers.Contains(driver))
                {
                    updatedDrivers.Add(driver);
                }
            }
        }
    }
}
