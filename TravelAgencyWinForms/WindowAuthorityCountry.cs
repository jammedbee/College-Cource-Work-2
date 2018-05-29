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
    public partial class WindowAuthorityCountry : Form
    {
        private SqlConnection ActiveConnection { get; set; }

        private int CountryID { get; set; }

        public WindowAuthorityCountry(SqlConnection connection)
        {
            InitializeComponent();
            ActiveConnection = connection;
            buttonSave.Visible = false;
            this.Text = "Добавить";
        }

        public WindowAuthorityCountry(SqlConnection connection, int countryID,
            string countryName, string countryISOCode)
        {
            InitializeComponent();
            ActiveConnection = connection;
            CountryID = countryID;
            textBoxName.Text = countryName;
            textBoxISOCode.Text = countryISOCode;
            buttonAdd.Visible = false;
            this.Text = "Изменить";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (SqlCommand sqlCommand = new SqlCommand($"EXEC NewAuthorityCountry N'{textBoxName.Text}'," +
                $" N'{textBoxISOCode.Text}'", ActiveConnection))
            {
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
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (SqlCommand sqlCommand = new SqlCommand($"EXEC UpdateAuthorityCountry {CountryID}," +
                $"N'{textBoxName.Text}', N'{textBoxISOCode.Text}'", ActiveConnection))
            {
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
}
