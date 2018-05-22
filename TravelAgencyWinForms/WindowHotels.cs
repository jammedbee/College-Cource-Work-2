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
    public partial class WindowHotels : Form
    {
        private SqlConnection ActiveConnection { get; set; }

        public WindowHotels(SqlConnection connection)
        {
            InitializeComponent();
            ActiveConnection = connection;
        }

        private void FillDataGrid()
        {
            DataSet dataSet = new DataSet("Hotels");
            SqlCommand sqlCommand = new SqlCommand("EXEC AllHotels", ActiveConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataSet);
            dataGridViewHotels.DataSource = dataSet.Tables[0];
            dataGridViewHotels.Columns[6].Visible = false;
        }

        private void WindowHotels_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            (new WindowHotelActions(ActiveConnection)).ShowDialog(this);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand
            {
                CommandText = $"SELECT HotelImage FROM [Hotel] WHERE " +
                    $"(HotelID = {(int)dataGridViewHotels.CurrentRow.Cells[0].Value})",
                Connection = ActiveConnection
            };

            (new WindowHotelActions(ActiveConnection,
                Convert.ToInt32(dataGridViewHotels.CurrentRow.Cells[0].Value),
                Convert.ToString(dataGridViewHotels.CurrentRow.Cells[1].Value),
                Convert.ToString(dataGridViewHotels.CurrentRow.Cells[3].Value),
                Convert.ToInt32(dataGridViewHotels.CurrentRow.Cells[2].Value),
                Convert.ToDecimal(dataGridViewHotels.CurrentRow.Cells[4].Value),
                Convert.ToInt32(dataGridViewHotels.CurrentRow.Cells[5].Value),
                (byte[])sqlCommand.ExecuteScalar())
            ).ShowDialog(this);
            FillDataGrid();
            sqlCommand.Dispose();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    "Вы уверены? Действие не может быть отменено!", "Подтверждение действия", MessageBoxButtons.YesNo
                    ) == DialogResult.Yes
               )
            {
                SqlCommand sqlCommand = new SqlCommand
                {
                    CommandText = $"EXEC DeleteHotel {(int)dataGridViewHotels.CurrentRow.Cells[0].Value}",
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
        }
    }
}
