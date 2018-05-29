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
    public partial class WindowSexActions : Form
    {
        private SqlConnection ActiveConnection { get; set; }

        private int SexID { get; set; }

        public WindowSexActions(SqlConnection connecton)
        {
            InitializeComponent();
            ActiveConnection = connecton;
            buttonSave.Visible = false;
            this.Text = "Добавить";
        }

        public WindowSexActions(SqlConnection connection, int sexID,
            string sexName, string sexCode)
        {
            InitializeComponent();
            ActiveConnection = connection;
            SexID = sexID;
            textBoxName.Text = sexName;
            textBoxCode.Text = sexCode;
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
            SqlCommand sqlCommand = new SqlCommand
            {
                CommandText = $"EXEC NewSex N'{textBoxName.Text}', N'{textBoxCode.Text}'",
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
            sqlCommand.Dispose();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (SqlCommand sqlCommand = new SqlCommand($"EXEC UpdateSex {SexID}, " +
                $"N'{textBoxName.Text}', N'{textBoxCode.Text}'", ActiveConnection))
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
