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
    public partial class WindowRouteActions : Form
    {
        private SqlConnection ActiveConnection { get; set; }

        private int RouteID { get; set; }

        private delegate void Del();

        public WindowRouteActions(SqlConnection connection)
        {
            InitializeComponent();
            ActiveConnection = connection;
            GetDataFromServer();
            buttonSave.Visible = false;
            this.Text = "Добавить";
        }

        public WindowRouteActions(SqlConnection connection, int routeID, int routeLength, int routeCountry, decimal routePrice)
        {
            InitializeComponent();
            ActiveConnection = connection;
            RouteID = routeID;
            GetDataFromServer();

            Del del = () =>
            {
                comboBoxLength.SelectedItem = Convert.ToString(routeLength);
                comboBoxCountry.SelectedValue = routeCountry;
                numericUpDownPrice.Value = routePrice;
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
            Owner.Activate();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand
            {
                CommandText =
                    $"EXEC NewRoute {Convert.ToInt32(comboBoxLength.SelectedItem)}, {comboBoxCountry.SelectedValue}, " +
                    $"{numericUpDownPrice.Value}",
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
                CommandText = $"EXEC UpdateRoute {RouteID}, {Convert.ToInt32(comboBoxLength.SelectedItem)}, " +
                $"{comboBoxCountry.SelectedValue}, {numericUpDownPrice.Value}",
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
