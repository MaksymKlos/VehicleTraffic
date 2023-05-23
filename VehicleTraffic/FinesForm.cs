using Database.Models;
using Database;
using System.Security.Policy;

namespace VehicleTraffic
{
    public partial class FinesForm : Form
    {
        private List<Fine> loadedFines;
        private List<Fine> updatedFines;
        private bool isFormReady;

        public FinesForm()
        {
            InitializeComponent();
        }

        private void FinesForm_Load(object sender, EventArgs e)
        {
            RefreshForm();
            isFormReady = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool isUpdated = false;

            for (int i = 0; i < FinesGridView.RowCount; i++)
            {
                var fine = loadedFines[i];
                if (updatedFines.Contains(fine))
                {
                    var transportCell = (DataGridViewComboBoxCell)FinesGridView.Rows[i].Cells[1];
                    var driverCell = (DataGridViewComboBoxCell)FinesGridView.Rows[i].Cells[2];
                    var descriptionCell = (DataGridViewTextBoxCell)FinesGridView.Rows[i].Cells[3];
                    var sumCell = (DataGridViewTextBoxCell)FinesGridView.Rows[i].Cells[4];

                    var driverId = (int)driverCell.Value;
                    var transportId = (int)transportCell.Value;

                    fine.Водій = DatabaseController.DriverRepository.GetById(driverId)!;
                    fine.Транспорт = DatabaseController.TransportRepository.GetById(transportId)!;
                    fine.Опис = descriptionCell.Value.ToString();
                    fine.Сума = decimal.Parse(sumCell.Value.ToString()!);

                    DatabaseController.FineRepository.Update(fine);

                    isUpdated = true;
                }
            }

            updatedFines = new List<Fine>();

            if (isUpdated)
            {
                FinesGridView.Refresh();
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
            var selected = (Fine)FinesGridView.SelectedRows[0].DataBoundItem;
            DatabaseController.FineRepository.Remove(selected.Код_Штрафу);
            RefreshForm();
        }

        private void RefreshForm()
        {
            FinesGridView.DataSource = null;
            FinesGridView.Columns.Clear();

            loadedFines = DatabaseController.FineRepository.GetAll();
            FinesGridView.DataSource = loadedFines;

            FinesGridView.Columns.RemoveAt(1);
            FinesGridView.Columns.RemoveAt(1);
            FinesGridView.Columns.RemoveAt(1);
            FinesGridView.Columns.RemoveAt(1);
            AddTransportComboBox();
            AddDriverComboBox();
            AddDescriptionTextBox();
            AddSumTextBox();

            updatedFines = new List<Fine>();
        }

        private void AddTransportComboBox()
        {
            var fineColumn = new DataGridViewComboBoxColumn();
            fineColumn.DisplayMember = "VIN";
            fineColumn.ValueMember = "Код_Транспорту";
            fineColumn.HeaderText = "VIN транспорту";
            fineColumn.DataSource = DatabaseController.TransportRepository.GetAll();

            FinesGridView.Columns.Add(fineColumn);

            foreach (DataGridViewRow row in FinesGridView.Rows)
            {
                if (row.DataBoundItem is Fine fine)
                {
                    row.Cells[fineColumn.Index].Value = fine.Транспорт.Код_Транспорту;
                }
            }
        }

        private void AddDriverComboBox()
        {
            var driverColumn = new DataGridViewComboBoxColumn();
            driverColumn.DisplayMember = "Прізвище";
            driverColumn.ValueMember = "Код_Водія";
            driverColumn.HeaderText = "Прізвище водія";
            driverColumn.DataSource = DatabaseController.DriverRepository.GetAll();

            FinesGridView.Columns.Add(driverColumn);

            foreach (DataGridViewRow row in FinesGridView.Rows)
            {
                if (row.DataBoundItem is Fine fine)
                {
                    row.Cells[driverColumn.Index].Value = fine.Водій.Код_Водія;
                }
            }
        }

        private void AddDescriptionTextBox()
        {
            var column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Опис";
            FinesGridView.Columns.Add(column);

            foreach (DataGridViewRow row in FinesGridView.Rows)
            {
                if (row.DataBoundItem is Fine fine)
                {
                    row.Cells[column.Index].Value = fine.Опис;
                }
            }
        }

        private void AddSumTextBox()
        {
            var column = new DataGridViewTextBoxColumn();
            column.HeaderText = "Сума";
            FinesGridView.Columns.Add(column);

            foreach (DataGridViewRow row in FinesGridView.Rows)
            {
                if (row.DataBoundItem is Fine fine)
                {
                    row.Cells[column.Index].Value = fine.Сума;
                }
            }
        }

        private void GridViewOnCellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && isFormReady)
            {
                var fine = (Fine)FinesGridView.Rows[e.RowIndex].DataBoundItem;

                if (fine != null && !updatedFines.Contains(fine))
                {
                    updatedFines.Add(fine);
                }
            }
        }
    }
}
