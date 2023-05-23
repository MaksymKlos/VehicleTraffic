using Database;

namespace VehicleTraffic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         
        private void DriversButton_Click(object sender, EventArgs e)
        {
            new DriversForm().ShowDialog();
        }

        private void TransportButton_Click(object sender, EventArgs e)
        {
            new TransportForm().ShowDialog();
        }

        private void RoutesButton_Click(object sender, EventArgs e)
        {
            new RoutesForm().ShowDialog();
        }

        private void FineButton_Click(object sender, EventArgs e)
        {
            new FinesForm().ShowDialog();
        }

        private void ShippingButton_Click(object sender, EventArgs e)
        {
            new ShippingForm().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DatabaseController.FillDataBase();
        }
    }
}