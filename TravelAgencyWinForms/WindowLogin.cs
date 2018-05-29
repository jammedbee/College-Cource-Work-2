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
using System.Security;

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
                int emp;
                string empName;

                using (SqlCommand command = new SqlCommand(
                    $"SELECT EmployeeFirstName + ' ' + EmployeeMiddleName" +
                    $",EmployeeID FROM Employee WHERE(EmployeeLogin LIKE '{textBoxLogin.Text}')",
                    ActiveConnection))
                {
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    sqlDataReader.Read();
                    empName = "Привет, " + Convert.ToString(sqlDataReader[0]);
                    emp = Convert.ToInt32(sqlDataReader[1]);
                    sqlDataReader.Close();
                }

                var contractsForm = new WindowContracts(ActiveConnection, emp);
                contractsForm.Show();
                contractsForm.SayHello(empName);
            }
            else
            {
                if (MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                {
                    foreach (var control in this.Controls)
                    {
                        if (control is TextBox)
                        {
                            (control as TextBox).Clear();
                        }
                    }

                    bytePassword = null;
                    password = null;
                }
                else
                {
                    Dispose();
                }
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var contractsForm = new WindowContracts(ActiveConnection, 1);
            contractsForm.Show();
            Dispose();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ActiveConnection.Close();
            ActiveConnection.Dispose();
            Dispose();
            Application.Exit();
        }

        private void WindowLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                ActiveConnection.Close();
                Application.Exit();
            }
        }
    }
}
