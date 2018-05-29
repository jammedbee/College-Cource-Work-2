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
    public partial class WindowVoucherActions : Form
    {
        private SqlConnection ActiveConnection { get; set; }

        private int VoucherID { get; set; }

        public WindowVoucherActions(SqlConnection connection)
        {
            InitializeComponent();
            ActiveConnection = connection;
            GetDataFromServer();
            buttonSave.Visible = false;
            this.Text = "Добавить";
        }

        public WindowVoucherActions(SqlConnection connection, int voucherID, 
            string departDate, int route, int hotel, decimal price)
        {
            InitializeComponent();
            ActiveConnection = connection;
            VoucherID = voucherID;
            GetDataFromServer();
            dateTimePickerDepart.Value = Convert.ToDateTime(departDate);
            comboBoxHotelID.SelectedValue = hotel;
            comboBoxRouteID.SelectedValue = route;
            textBoxPrice.Text = Convert.ToString(price);
            buttonAdd.Visible = false;
            this.Text = "Изменить";
        }

        private void GetDataFromServer()
        {
            SqlCommand sqlCommand = new SqlCommand
            {
                CommandText = $"EXEC AllHotels",
                Connection = ActiveConnection
            };
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            comboBoxHotelID.DataSource = dataSet.Tables[0];
            comboBoxHotelID.ValueMember = "#";
            comboBoxHotelID.DisplayMember = "Название";

            DataSet dataSet1 = new DataSet();
            sqlCommand.CommandText = "EXEC AllRoutes";
            sqlDataAdapter.Fill(dataSet1);
            comboBoxRouteID.DataSource = dataSet1.Tables[0];
            comboBoxRouteID.DisplayMember = "#";
            comboBoxRouteID.ValueMember = "#";
            sqlDataAdapter.Dispose();
            sqlCommand.Dispose();
        }

        private decimal GetPrice(int routeID, int hotelID)
        {
            SqlCommand sqlCommand = new SqlCommand
            {
                CommandText = $"SELECT dbo.CalculateVoucherPrice({routeID}, {hotelID})",
                Connection = ActiveConnection
            };

            return (decimal)sqlCommand.ExecuteScalar();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
            Owner.Activate();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand
            {
                CommandText = $"EXEC NewVoucher '{dateTimePickerDepart.Value.ToShortDateString()}', {comboBoxRouteID.SelectedValue}," +
                $"{Convert.ToDecimal(textBoxPrice.Text)}, {comboBoxHotelID.SelectedValue}",
                Connection = ActiveConnection
            };

            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                Close();
                Owner.Activate();
            }
            else
            {
                MessageBox.Show("Не удалось добавить запись :(", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void comboBoxRouteID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBoxPrice.Text = Convert.ToString(GetPrice((int)comboBoxRouteID.SelectedValue, (int)comboBoxHotelID.SelectedValue));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand
            {
                CommandText = $"EXEC UpdateVoucher {VoucherID},'{dateTimePickerDepart.Value.ToShortDateString()}', " +
                $"{comboBoxRouteID.SelectedValue}," +
                $"{Convert.ToDecimal(textBoxPrice.Text)}, {comboBoxHotelID.SelectedValue}",
                Connection = ActiveConnection
            };

            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                Close();
                Owner.Activate();
            }
            else
            {
                MessageBox.Show("Не удалось обновить запись :(", "Ошибка", MessageBoxButtons.OK);
            }
        }
    }
}
