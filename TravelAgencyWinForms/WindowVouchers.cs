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
    public partial class WindowVouchers : Form
    {
        private SqlConnection ActiveConnection { get; set; }

        public WindowVouchers(SqlConnection connection)
        {
            InitializeComponent();
            ActiveConnection = connection;
        }

        private void WindowVouchers_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            SqlCommand sqlCommand = new SqlCommand
            {
                CommandText = $"EXEC AllVouchers",
                Connection = ActiveConnection
            };
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridViewVouchers.DataSource = dataSet.Tables[0];
            sqlDataAdapter.Dispose();
            sqlCommand.Dispose();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            (new WindowVoucherActions(ActiveConnection)).ShowDialog(this);
            GetData();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            (new WindowVoucherActions(ActiveConnection, 
                (int)dataGridViewVouchers.CurrentRow.Cells[0].Value,
                (string)dataGridViewVouchers.CurrentRow.Cells[1].Value,
                (int)dataGridViewVouchers.CurrentRow.Cells[2].Value,
                (int)dataGridViewVouchers.CurrentRow.Cells[3].Value,
                (decimal)dataGridViewVouchers.CurrentRow.Cells[4].Value)).ShowDialog(this);
            GetData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены? Действие не может быть отменено!", "Подтверждение действия", MessageBoxButtons.YesNo) == DialogResult.Yes)
            { 
                SqlCommand sqlCommand = new SqlCommand
                {
                    CommandText = $"EXEC DeleteVoucher {(int)dataGridViewVouchers.CurrentRow.Cells[0].Value}",
                    Connection = ActiveConnection
                };

                if (sqlCommand.ExecuteNonQuery() != 0)
                {
                    GetData();
                    sqlCommand.Dispose();
                }
                else
                {
                    MessageBox.Show("Призошла ошибка при удалении.", "Ошибка", MessageBoxButtons.OK);
                    sqlCommand.Dispose();
                }
            }
        }
    }
}
