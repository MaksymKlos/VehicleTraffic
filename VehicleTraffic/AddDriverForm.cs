using Database;
using Database.Models;

namespace VehicleTraffic
{
    public partial class AddDriverForm : Form
    {
        public AddDriverForm()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e) 
        {
            var driver = new Driver
            {
                Імя = DriverName.Text,
                Прізвище = Surname.Text,
                Адреса = Address.Text,
                Номер_Телефону = Phone.Text
            };

            DatabaseController.DriverRepository.Create(driver);

            MessageBox.Show("Водія створено", "Успіх!");
            Close();
        }
    }
}
