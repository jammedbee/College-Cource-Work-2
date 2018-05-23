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
    public partial class WindowCountryActions : Form
    {
        private SqlConnection ActiveConnection { get; set; }

        private int CountryID { get; set; }

        private delegate void Del();

        public WindowCountryActions(SqlConnection connection)
        {
            InitializeComponent();
            ActiveConnection = connection;
            GetDataFromServer();
        }

        public WindowCountryActions(SqlConnection connection, int countryID, string countryName, int countryClimate)
        {
            InitializeComponent();
            ActiveConnection = connection;
            CountryID = countryID;
            GetDataFromServer();

            Del del = () =>
            {
                textBoxName.Text = countryName;
                comboBoxClimate.SelectedValue = countryClimate;
            };
            del();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
            Owner.Activate();
        }

        private void GetDataFromServer()
        {
            SqlCommand sqlCommand = new SqlCommand
            {
                CommandText = "EXEC AllClimates",
                Connection = ActiveConnection
            };
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            comboBoxClimate.DataSource = dataSet.Tables[0];
            comboBoxClimate.DisplayMember = "Название";
            comboBoxClimate.ValueMember = "#";
            sqlDataAdapter.Dispose();
            sqlCommand.Dispose();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand
            {
                CommandText = $"EXEC NewCountry N'{textBoxName.Text}', {comboBoxClimate.SelectedValue}",
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand
            {
                CommandText = $"EXEC UpdateCountry {CountryID}, N'{textBoxName.Text}', {(int)comboBoxClimate.SelectedValue}",
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

        private void WindowCountryActions_Load(object sender, EventArgs e)
        {

        }
    }
}
