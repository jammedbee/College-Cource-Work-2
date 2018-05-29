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
    public partial class WindowCityActions : Form
    {
        private SqlConnection ActiveConnection { get; set; }

        private int CityID { get; set; }
        
        private int CountryID { get; set; }

        private delegate void Del();

        public WindowCityActions(SqlConnection connection)
        {
            InitializeComponent();
            ActiveConnection = connection;
            GetDataFromServer();
            buttonSave.Visible = false;
            this.Text = "Добавить";
        }

        public WindowCityActions(SqlConnection connection, int cityID, string cityName, int countryID)
        {
            InitializeComponent();
            ActiveConnection = connection;
            CityID = cityID;
            CountryID = countryID;
            GetDataFromServer();
            Del del = () =>
            {
                textBoxName.Text = cityName;
                comboBoxCountry.SelectedValue = countryID;
            };
            del();
            buttonAdd.Visible = false;
            this.Text = "Изменить";
        }

        private void GetDataFromServer()
        {
            SqlCommand sqlCommand = new SqlCommand
            {
                CommandText = "EXEC AllCountries",
                Connection = ActiveConnection
            };
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            comboBoxCountry.DataSource = dataSet.Tables[0];
            comboBoxCountry.ValueMember = "#";
            comboBoxCountry.DisplayMember = "Название";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand
            {
                CommandText = $"EXEC NewCity N'{textBoxName.Text}', {comboBoxCountry.SelectedValue}",
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
                CommandText = $"EXEC UpdateCity {CityID}, N'{textBoxName.Text}', {comboBoxCountry.SelectedValue}",
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
