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
    public partial class WindowPassportTypeActions : Form
    {
        private SqlConnection ActiveConnection { get; set; }

        private int PassportTypeID { get; set; }

        public WindowPassportTypeActions(SqlConnection connection)
        {
            InitializeComponent();
            ActiveConnection = connection;
            buttonSave.Visible = false;
            this.Text = "Добавить";
        }

        public WindowPassportTypeActions(SqlConnection connection, int passportTypeID,
            string passportTypeName)
        {
            InitializeComponent();
            ActiveConnection = connection;
            PassportTypeID = passportTypeID;
            textBoxName.Text = passportTypeName;
            buttonAdd.Visible = false;
            this.Text = "Изменить";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
            Owner.Activate();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (SqlCommand sqlCommand = new SqlCommand($"EXEC NewPassportType N'{textBoxName.Text}'", ActiveConnection))
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
            using (SqlCommand sqlCommand = new SqlCommand($"EXEC UpdatePassportType {PassportTypeID}," +
                $" N'{textBoxName.Text}'", ActiveConnection))
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
