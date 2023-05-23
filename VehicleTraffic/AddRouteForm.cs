using Database;
using Database.Models;

namespace VehicleTraffic
{
    public partial class AddRouteForm : Form
    {
        public AddRouteForm()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            var route = new Route
            {
                Назва = RouteName.Text,
                Початкова_Точка = Start.Text,
                Кінцева_Точка = End.Text,
                Протяжність_Маршруту = double.Parse(Duration.Text),
            };

            DatabaseController.RouteRepository.Create(route);

            MessageBox.Show("Маршрут створено", "Успіх!");
            Close();
        }
    }
}
