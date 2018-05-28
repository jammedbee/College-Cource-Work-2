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
    public partial class WindowClientActions : Form
    {
        private SqlConnection ActiveConnection { get; set; }

        private string PassportNumber { get; set; }

        private int ClientID { get; set; }

        public void SetPassport(string number)
        {
            PassportNumber = number;
            textBoxPassportNumber.Text = number;
        }

        public WindowClientActions(SqlConnection connection)
        {
            InitializeComponent();
            ActiveConnection = connection;
            GetDataFromServer();
        }

        public WindowClientActions(SqlConnection connection, string passportNumber,
            int clientID, string firstName, string lastName, string middleName,
            int sexID, string birthDate, string phone, string email)
        {
            InitializeComponent();
            ActiveConnection = connection;
            GetDataFromServer();
            ClientID = clientID;
            PassportNumber = passportNumber;
            textBoxPassportNumber.Text = passportNumber;
            textBoxFirstName.Text = firstName;
            textBoxLastName.Text = lastName;
            textBoxMiddleName.Text = middleName;
            dateTimePickerBirthDate.Value = Convert.ToDateTime(birthDate);
            comboBoxSex.SelectedValue = sexID;
            textBoxEmail.Text = email;
            textBoxPhone.Text = phone;
        }

        private void GetDataFromServer()
        {
            DataSet dataSet = new DataSet();

            using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("EXEC AllSexes", ActiveConnection))
            {
                sqlDataAdapter.Fill(dataSet);
            }

            comboBoxSex.DataSource = dataSet.Tables[0];
            comboBoxSex.ValueMember = "#";
            comboBoxSex.DisplayMember = "Название";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
            Owner.Activate();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxMiddleName.Text))
            {
                textBoxMiddleName.Text = " ";
            }
            using (SqlCommand sqlCommand = new SqlCommand(
                $"EXEC NewClient N'{textBoxFirstName.Text}', N'{textBoxLastName.Text}'," +
                $"N'{textBoxMiddleName.Text}', '{dateTimePickerBirthDate.Value.ToShortDateString()}'," +
                $" '{textBoxPhone.Text}', N'{textBoxEmail.Text}', " +
                $"{comboBoxSex.SelectedValue}, N'{textBoxPassportNumber.Text}'", ActiveConnection))
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

        private void buttonNewPassport_Click(object sender, EventArgs e)
        {
            (new WindowPassportActions(ActiveConnection)).ShowDialog(this);
        }

        private void buttonEditPassport_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand(
                $"SELECT * FROM Passport WHERE PassportNumber LIKE '{textBoxPassportNumber.Text}'",
                ActiveConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            sqlDataReader.Read();

            sqlCommand.Dispose();

            string[] vs = new string[]
            {
                Convert.ToString(sqlDataReader[0]),
                Convert.ToString(sqlDataReader[1]),
                Convert.ToString(sqlDataReader[2]),
                Convert.ToString(sqlDataReader[3])
            };

            int[] vs1 = new int[]
            {
                Convert.ToInt32(sqlDataReader[4]),
                Convert.ToInt32(sqlDataReader[5])
            };
       
            sqlDataReader.Close();

            (new WindowPassportActions(ActiveConnection,
                vs[0], vs[1], vs[2], vs[3], vs1[0], vs1[1])).ShowDialog(this);

            vs = null;
            vs1 = null;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(textBoxMiddleName.Text))
                {
                    textBoxMiddleName.Text = " ";
                }
                using (SqlCommand sqlCommand = new SqlCommand(
                    $"EXEC UpdateClient {ClientID}, N'{textBoxFirstName.Text}', N'{textBoxLastName.Text}'," +
                    $"N'{textBoxMiddleName.Text}', '{dateTimePickerBirthDate.Value.ToShortDateString()}'," +
                    $" '{textBoxPhone.Text}', N'{textBoxEmail.Text}', " +
                    $"{comboBoxSex.SelectedValue}, N'{textBoxPassportNumber.Text}'", ActiveConnection))
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
