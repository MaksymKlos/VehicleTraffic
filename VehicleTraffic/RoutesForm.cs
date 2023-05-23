using Database.Models;
using Database;

namespace VehicleTraffic
{
    public partial class RoutesForm : Form
    {
        private List<Route> loadedRoutes;
        private List<Route> updatedRoutes;
        private bool isFormReady;

        public RoutesForm()
        {
            InitializeComponent();
        }

        private void RoutesForm_Load(object sender, EventArgs e)
        {
            RefreshForm();
            isFormReady = true;
        }
        

        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool isUpdated = false;

            for (int i = 0; i < RoutesGridView.RowCount; i++)
            {
                var route = loadedRoutes[i];
                if (updatedRoutes.Contains(route))
                {
                    DatabaseController.RouteRepository.Update(route);

                    isUpdated = true;
                }
            }

            updatedRoutes = new List<Route>();

            if (isUpdated)
            {
                RoutesGridView.Refresh();
                MessageBox.Show("Дані змінено!", "Успіх!");
            }
            else
            {
                MessageBox.Show("Ніяких змін не було!", "Попередження!");
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            new AddRouteForm().ShowDialog();
            RefreshForm();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var selected = (Route)RoutesGridView.SelectedRows[0].DataBoundItem;
            DatabaseController.RouteRepository.Remove(selected.Код_Маршруту);
            RefreshForm();
        }

        private void RefreshForm()
        {
            RoutesGridView.DataSource = null;
            RoutesGridView.Columns.Clear();

            loadedRoutes = DatabaseController.RouteRepository.GetAll();
            RoutesGridView.DataSource = loadedRoutes;
            updatedRoutes = new List<Route>();
        }

        private void GridViewOnCellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && isFormReady)
            {
                var driver = (Route)RoutesGridView.Rows[e.RowIndex].DataBoundItem;

                if (driver != null && !updatedRoutes.Contains(driver))
                {
                    updatedRoutes.Add(driver);
                }
            }
        }
    }
}