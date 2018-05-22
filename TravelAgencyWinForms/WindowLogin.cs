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
using System.Security.Cryptography;

namespace TravelAgencyWinForms
{
    public partial class WindowLogin : Form
    {
        private SqlConnection ActiveConnection { get; set; }

        public WindowLogin()
        {
            InitializeComponent();
            ActiveConnection = new SqlConnection
            {
                ConnectionString = "Data Source=JMMDBEE-LAPTOP;Initial Catalog=TravelAgency;Integrated Security=True"
            };

            try
            {
                ActiveConnection.Open();
            }
            catch
            {
                MessageBox.Show("Не удалось додключиться к серверу.", "Ошибка поключения", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            byte[] bytePassword = (new SHA512Managed()).ComputeHash(Encoding.Unicode.GetBytes(textBoxPassword.Text));

            StringBuilder password = new StringBuilder();

            for (int i = 0; i < bytePassword.Length; i++)
            {
                password.Append(bytePassword[i].ToString("x2"));
            }

            SqlCommand sqlCommand = new SqlCommand($"SELECT dbo.[Authorization]('{textBoxLogin.Text}', '{password.ToString()}')", ActiveConnection);

            if ((bool)sqlCommand.ExecuteScalar())
            {
                var contractsForm = new WindowContracts(ActiveConnection);
                contractsForm.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                foreach (var control in this.Controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var contractsForm = new WindowContracts(ActiveConnection);
            contractsForm.Show();
        }
    }
}
