using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TravelAgencyWinForms
{
    public partial class WindowContracts : Form
    {
        private SqlConnection ActiveConnection { get; set; }

        private int EmployeeID { get; set; }

        public WindowContracts(SqlConnection connection, int employeeID)
        {
            InitializeComponent();
            ActiveConnection = connection;
            EmployeeID = employeeID;
        }

        private void POSITIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new WindowPositions(ActiveConnection)).Show();
        }

        private void nEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new WindowPositionActions(ActiveConnection)).ShowDialog(this);
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new WindowPositionActions(ActiveConnection, "Тесто", 100, 5)).ShowDialog(this);
        }

        private void nEWToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void eDITToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            (new WindowEmployeeActions(ActiveConnection, 7, "тесть", "тест", "тест", "8(800)000-00-00", "ads@gd.com", "1111222233334444", 2)).ShowDialog(this);
        }

        private void eMPLOYEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new WindowEmployees(ActiveConnection)).Show();
        }

        private void nEWToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            (new WindowLoginActions(ActiveConnection)).ShowDialog(this);
        }

        private void nEWToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            (new WindowFoodTypeActions(ActiveConnection)).ShowDialog(this);
        }

        private void eDITToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            (new WindowFoodTypeActions(ActiveConnection, 7, "Тест", "Тест", "Тест", "Описание")).ShowDialog(this);
        }

        private void nEWToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            (new WindowHotelActions(ActiveConnection)).ShowDialog(this);
        }

        private void eDITToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            SqlCommand cn = new SqlCommand("SELECT HotelImage FROM [Hotel] WHERE (HotelID = 5)", ActiveConnection);
            
            (new WindowHotelActions(ActiveConnection, 5, "aaaaa", "bbbbb", 5, (decimal)10.01, 6, (byte[])cn.ExecuteScalar(), 4)).ShowDialog(this);
        }

        private void hOTELToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new WindowHotels(ActiveConnection)).Show();
        }

        private void nEWToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            (new WindowCityActions(ActiveConnection)).ShowDialog(this);
        }

        private void nEWToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            (new WindowClimateActions(ActiveConnection)).ShowDialog(this);
        }

        private void eDITToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            (new WindowClimateActions(ActiveConnection, 5, "test", "test")).ShowDialog(this);
        }

        private void nEWToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            (new WindowCountryActions(ActiveConnection)).ShowDialog(this);
        }

        private void eDITToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            (new WindowCountryActions(ActiveConnection, 5, "тсеь", 5)).ShowDialog(this);
        }

        private void eDITToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            (new WindowCityActions(ActiveConnection, 5, "Hello", 5)).ShowDialog(this);
        }

        private void WindowContracts_Load(object sender, EventArgs e)
        {
            DataSet dataSet = new DataSet();

            using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("EXEC AllContracts", ActiveConnection))
            {
                sqlDataAdapter.Fill(dataSet.Tables.Add());
                sqlDataAdapter.SelectCommand = new SqlCommand("EXEC AllVouchers", ActiveConnection);
                sqlDataAdapter.Fill(dataSet.Tables.Add());
                sqlDataAdapter.SelectCommand = new SqlCommand("EXEC AllClients", ActiveConnection);
                sqlDataAdapter.Fill(dataSet.Tables.Add());
            }

            dataGridViewContracts.DataSource = dataSet.Tables[0];
            dataGridView1.DataSource = dataSet.Tables[1];
            dataGridView2.DataSource = dataSet.Tables[2];
        }

        private void WindowContracts_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void nEWToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            (new WindowRouteActions(ActiveConnection)).ShowDialog(this);
        }

        private void eDITToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            (new WindowRouteActions(ActiveConnection, 5, 12, 5, (decimal)10000.100)).ShowDialog(this);
        }

        private void nEWToolStripMenuItem14_Click(object sender, EventArgs e)
        {
            (new WindowVoucherActions(ActiveConnection)).ShowDialog(this);
        }

        private void eDITToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            (new WindowVoucherActions(ActiveConnection, 5, "21/05/2018", 4, 4, (decimal)10000.111)).ShowDialog(this);
        }

        private void vOUCHERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new WindowVouchers(ActiveConnection)).Show();
        }

        private void nEWToolStripMenuItem15_Click(object sender, EventArgs e)
        {
            (new WindowSexActions(ActiveConnection)).ShowDialog(this);
        }

        private void eDITToolStripMenuItem14_Click(object sender, EventArgs e)
        {
            (new WindowSexActions(ActiveConnection, 3, "тест", "Т")).ShowDialog(this);
        }

        private void nEWToolStripMenuItem16_Click(object sender, EventArgs e)
        {
            (new WindowPassportTypeActions(ActiveConnection)).ShowDialog(this);
        }

        private void eDITToolStripMenuItem15_Click(object sender, EventArgs e)
        {
            (new WindowPassportTypeActions(ActiveConnection, 3, "asd")).ShowDialog(this);
        }

        private void nEWToolStripMenuItem17_Click(object sender, EventArgs e)
        {
            (new WindowAuthorityCountry(ActiveConnection)).ShowDialog(this);
        }

        private void eDITToolStripMenuItem16_Click(object sender, EventArgs e)
        {
            (new WindowAuthorityCountry(ActiveConnection, 4, "tes", "test")).ShowDialog(this);
        }

        private void nEWToolStripMenuItem18_Click(object sender, EventArgs e)
        {
            (new WindowPassportActions(ActiveConnection)).ShowDialog(this);
        }

        private void eDITToolStripMenuItem17_Click(object sender, EventArgs e)
        {
            (new WindowPassportActions(ActiveConnection, "00000000", "TEST", "01/02/2018", "01/02/2028", 2, 1)).ShowDialog(this);
        }

        private void nEWToolStripMenuItem19_Click(object sender, EventArgs e)
        {
            (new WindowClientActions(ActiveConnection)).ShowDialog(this);
        }

        private void eDITToolStripMenuItem18_Click(object sender, EventArgs e)
        {
            (new WindowClientActions(ActiveConnection, "00000003", 10, "aa", "sdafda", "sadsa",
                1, "01/01/2018", "+0(000)000-00-00", "aa@aa.com")).ShowDialog(this);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.CommandText = $"SELECT VoucherDepartDate, VoucherPrice, HotelName, RouteTimeLength, CountryName " +
                $"FROM Voucher JOIN Hotel ON VoucherHotelID = HotelID " +
                $"JOIN Route ON VoucherRouteID = RouteID JOIN Country ON RouteCountryID = CountryID " +
                $"WHERE(VoucherID = {(int)dataGridView1.CurrentRow.Cells[0].Value})";
            sqlCommand.Connection = ActiveConnection;

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                sqlDataReader.Read();

                label1.Text = "Дата отправления: " + Convert.ToString(sqlDataReader[0]);
                label2.Text = "Цена: " + Convert.ToString(sqlDataReader[1]);
                label3.Text = "Отель: " + Convert.ToString(sqlDataReader[2]);
                label4.Text = "Длительность маршрута: " + Convert.ToString(sqlDataReader[3]);
                label5.Text = "Страна назначения: " + Convert.ToString(sqlDataReader[4]);
            }

            sqlDataReader.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (SqlCommand sqlCommand = new SqlCommand())
            {
                sqlCommand.CommandText = $"EXEC NewContract '{dateTimePicker1.Value.ToString()}'," +
                    $"{(decimal)dataGridView1.CurrentRow.Cells[4].Value}, {EmployeeID}," +
                    $"{(int)dataGridView2.CurrentRow.Cells[0].Value}, {(int)dataGridView1.CurrentRow.Cells[0].Value}";
                sqlCommand.Connection = ActiveConnection;

                try
                {
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void маршрутыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new WindowRoutes(ActiveConnection)).Show(this);
        }

        private void путёвкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new WindowVouchers(ActiveConnection)).Show(this);
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(maskedTextBox1.Text);
        }
    }
}
