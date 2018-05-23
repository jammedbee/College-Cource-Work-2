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
    public partial class WindowClimateActions : Form
    {
        private SqlConnection ActiveConnection { get; set; }

        private int ClimateID { get; set; }

        private delegate void Del();

        public WindowClimateActions(SqlConnection connection)
        {
            InitializeComponent();
            ActiveConnection = connection;
        }

        public WindowClimateActions(SqlConnection connection, int climateID, string cliamateName, string climateDescription)
        {
            InitializeComponent();
            ActiveConnection = connection;
            ClimateID = climateID;
            Del del = () =>
            {
                textBoxName.Text = cliamateName;
                richTextBoxDescription.Text = climateDescription;
            };
            del();
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
                CommandText = $"EXEC NewClimate N'{textBoxName.Text}', N'{richTextBoxDescription.Text}'",
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
                CommandText = $"EXEC UpdateClimate {ClimateID}, N'{textBoxName.Text}', N'{richTextBoxDescription.Text}'",
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

