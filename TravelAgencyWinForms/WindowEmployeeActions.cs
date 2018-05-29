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
    public partial class WindowEmployeeActions : Form
    {
        private SqlConnection ActiveConnection { get; set; }

        private string Login { get; set; }

        private int EmployeeID { get; set; }

        private int EmployeePositionID { get; set; }

        public WindowEmployeeActions(SqlConnection connection, string login)
        {
            InitializeComponent();
            ActiveConnection = connection;
            Login = login;
            buttonSave.Visible = false;
            this.Text = "Добавить";
        }

        public WindowEmployeeActions(SqlConnection connection, int employeeID,
            string employeeFirstName, string employeeLastName, string employeeMiddleName,
            string employeePhone, string employeeEmail, string employeePaymentCardNumber,
            int employeePositionID)
        {
            InitializeComponent();
            ActiveConnection = connection;
            EmployeeID = employeeID;

            textBoxFirstName.Text = employeeFirstName;
            textBoxLastName.Text = employeeLastName;
            textBoxMiddleName.Text = employeeMiddleName;
            maskedTextBoxPhone.Text = employeePhone;
            textBoxEmail.Text = employeeEmail;
            textBoxPaymentCardNumber.Text = employeePaymentCardNumber;
            EmployeePositionID = employeePositionID;
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
            SqlCommand sqlCommand = new SqlCommand
            {
                CommandText = $"EXEC NewEmployee N'{textBoxFirstName.Text}', N'{textBoxLastName.Text}', " +
                $"N'{textBoxMiddleName.Text}', N'{maskedTextBoxPhone.Text}', N'{textBoxEmail.Text}', " +
                $"N'{textBoxPaymentCardNumber.Text}', {comboBoxPositionID.SelectedValue}, '{Login}'",
                Connection = ActiveConnection
            };

            if (sqlCommand.ExecuteNonQuery() != 0)
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
                CommandText = $"EXEC UpdateEmployee {EmployeeID}, N'{textBoxFirstName.Text}', N'{textBoxLastName.Text}', " +
                $"N'{textBoxMiddleName.Text}', N'{maskedTextBoxPhone.Text}', N'{textBoxEmail.Text}', " +
                $"N'{textBoxPaymentCardNumber.Text}', {comboBoxPositionID.SelectedValue}",
                Connection = ActiveConnection
            };

            if (sqlCommand.ExecuteNonQuery() != 0)
            {
                Close();
                Owner.Activate();
            }
            else
            {
                MessageBox.Show("Не удалось обновить запись :(", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void WindowEmployeeActions_Load(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("EXEC AllPositions", ActiveConnection);

            DataSet dataSet = new DataSet();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataSet);
            comboBoxPositionID.DataSource = dataSet.Tables[0];
            comboBoxPositionID.ValueMember = "#";
            comboBoxPositionID.DisplayMember = "Название";
            comboBoxPositionID.SelectedValue = EmployeePositionID;
        }
    }
}
