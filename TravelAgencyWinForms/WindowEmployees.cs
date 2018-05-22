using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgencyWinForms
{
    public partial class WindowEmployees : Form
    {
        private SqlConnection ActiveConnection { get; set; }

        public WindowEmployees(SqlConnection connection)
        {
            InitializeComponent();
            ActiveConnection = connection;
        }

        private void WindowEmployees_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void FillDataGrid()
        {
            DataSet dataSetPositions = new DataSet("Employees");
            SqlCommand sqlCommand = new SqlCommand
            {
                CommandText = "EXEC AllEmployees",
                Connection = ActiveConnection
            };
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataSetPositions);
            dataGridViewEmployees.DataSource = dataSetPositions.Tables[0];
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            (new WindowLoginActions(ActiveConnection)).ShowDialog(this);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            (new WindowEmployeeActions(ActiveConnection, (int)dataGridViewEmployees.CurrentRow.Cells[0].Value,
                (string)(dataGridViewEmployees.CurrentRow.Cells[1].Value),
                (string)(dataGridViewEmployees.CurrentRow.Cells[2].Value),
                (string)(dataGridViewEmployees.CurrentRow.Cells[3].Value),
                (string)(dataGridViewEmployees.CurrentRow.Cells[7].Value),
                (string)(dataGridViewEmployees.CurrentRow.Cells[5].Value),
                (string)(dataGridViewEmployees.CurrentRow.Cells[6].Value),
                (int)(dataGridViewEmployees.CurrentRow.Cells[4].Value))
            ).ShowDialog(this);
            FillDataGrid();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selectedID = (int)dataGridViewEmployees.CurrentRow.Cells[0].Value;

            if (MessageBox.Show(
                    "Вы уверены? Действие не может быть отменено!", "Подтверждение действия", MessageBoxButtons.YesNo
                    ) == DialogResult.Yes
               )
            {
                SqlCommand sqlCommand = new SqlCommand
                {
                    CommandText = $"EXEC DeleteEmployee {selectedID}",
                    Connection = ActiveConnection
                };
                if (sqlCommand.ExecuteNonQuery() != 0)
                {
                    FillDataGrid();
                }
                else
                {
                    MessageBox.Show("Призошла ошибка при удалении.", "Ошибка", MessageBoxButtons.OK);
                }
            }
            else
            {
                selectedID = 0;
            }
        }
    }
}
