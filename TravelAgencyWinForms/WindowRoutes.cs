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
    public partial class WindowRoutes : Form
    {
        private SqlConnection ActiveConnection { get; set; }

        public WindowRoutes(SqlConnection connection)
        {
            InitializeComponent();
            ActiveConnection = connection;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            (new WindowRouteActions(ActiveConnection)).ShowDialog(this);
            GetDataFromServer();
        }

        private void WindowRoutes_Load(object sender, EventArgs e)
        {
            GetDataFromServer();
        }

        private void GetDataFromServer()
        {
            DataSet dataSet = new DataSet();

            using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
            {
                sqlDataAdapter.SelectCommand = new SqlCommand($"EXEC AllRoutes", ActiveConnection);
                sqlDataAdapter.Fill(dataSet);
            }

            dataGridViewRoutes.DataSource = dataSet.Tables[0];
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            (new WindowRouteActions(ActiveConnection, (int)dataGridViewRoutes.CurrentRow.Cells[0].Value,
                (int)dataGridViewRoutes.CurrentRow.Cells[1].Value, (int)dataGridViewRoutes.CurrentRow.Cells[2].Value,
                (decimal)dataGridViewRoutes.CurrentRow.Cells[3].Value)).ShowDialog(this);
            GetDataFromServer();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены? Действие не может быть отменено!", "Подтверждение действия", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlCommand sqlCommand = new SqlCommand(
                $"EXEC DeleteRoute {(int)dataGridViewRoutes.CurrentRow.Cells[0].Value}",
                ActiveConnection))
                {
                    if (sqlCommand.ExecuteNonQuery() != 0)
                    {
                        GetDataFromServer();
                    }
                    else
                    {
                        MessageBox.Show("Призошла ошибка при удалении.", "Ошибка", MessageBoxButtons.OK);
                    }
                }
            }
        }
    }
}
