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
    public partial class WindowClients : Form
    {
        private SqlConnection ActiveConnection { get; set; }

        public WindowClients(SqlConnection connection)
        {
            InitializeComponent();
            ActiveConnection = connection;
            GetDataFromServer();
        }

        private void WindowClients_Load(object sender, EventArgs e)
        {
            
        }

        private void GetDataFromServer()
        {
            DataSet dataSet = new DataSet();
            using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
            {
                sqlDataAdapter.SelectCommand = new SqlCommand("EXEC AllClients", ActiveConnection);
                sqlDataAdapter.Fill(dataSet);
            }
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            (new WindowClientActions(ActiveConnection)).ShowDialog(this);
            GetDataFromServer();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            (new WindowClientActions(ActiveConnection,
                (string)dataGridView1.CurrentRow.Cells[8].Value,
                (int)dataGridView1.CurrentRow.Cells[0].Value,
                (string)dataGridView1.CurrentRow.Cells[1].Value,
                (string)dataGridView1.CurrentRow.Cells[2].Value,
                (string)dataGridView1.CurrentRow.Cells[3].Value,
                (int)dataGridView1.CurrentRow.Cells[4].Value,
                Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value),
                (string)dataGridView1.CurrentRow.Cells[6].Value,
                (string)dataGridView1.CurrentRow.Cells[7].Value)).ShowDialog(this);
            GetDataFromServer();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены? Действие не может быть отменено!", "Подтверждение действия", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string passport = (string)dataGridView1.CurrentRow.Cells[8].Value;

                SqlCommand sqlCommand = new SqlCommand
                {
                    CommandText = $"EXEC DeleteClient {(int)dataGridView1.CurrentRow.Cells[0].Value}",
                    Connection = ActiveConnection
                };
                if (sqlCommand.ExecuteNonQuery() != 0)
                {
                    GetDataFromServer();
                }
                else
                {
                    MessageBox.Show("Призошла ошибка при удалении.", "Ошибка", MessageBoxButtons.OK);
                }

                sqlCommand.CommandText = $"EXEC DeletePassport '{passport}'";
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }

            GetDataFromServer();
        }
    }
}
