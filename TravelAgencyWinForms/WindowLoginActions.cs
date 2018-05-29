using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgencyWinForms
{
    public partial class WindowLoginActions : Form
    {
        private SqlConnection ActiveConnection { get; set; }

        public WindowLoginActions(SqlConnection connection)
        {
            InitializeComponent();
            ActiveConnection = connection;
            buttonSave.Visible = false;
            this.Text = "Добавить";
        }

        public WindowLoginActions(SqlConnection connection, string login)
        {
            InitializeComponent();
            ActiveConnection = connection;
            textBoxName.Text = login;
            textBoxName.ReadOnly = true;
            buttonAdd.Visible = false;
            this.Text = "Изменить";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
            Owner.Activate();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            byte[] bytePassword = (new SHA512Managed()).ComputeHash(Encoding.Unicode.GetBytes(textBoxPassword.Text));

            StringBuilder password = new StringBuilder();

            for (int i = 0; i < bytePassword.Length; i++)
            {
                password.Append(bytePassword[i].ToString("x2"));
            }

            SqlCommand sqlCommand = new SqlCommand
            {
                CommandText = $"EXEC AddLogin {textBoxName.Text}, {password}",
                Connection = ActiveConnection
            };

            if (sqlCommand.ExecuteNonQuery() != 0)
            {
                (new WindowEmployeeActions(ActiveConnection, textBoxName.Text)).ShowDialog(this);
                Close();
            }
        }

        private void textBoxConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }
    }
}
