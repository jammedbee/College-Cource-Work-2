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
    public partial class WindowPassportActions : Form
    {
        private SqlConnection ActiveConnection { get; set; }

        private string PassportNumber { get; set; }

        public WindowPassportActions(SqlConnection connection)
        {
            InitializeComponent();
            ActiveConnection = connection;
            GetDataFromServer(ActiveConnection);
            buttonEditNumber.Visible = false;
        }

        public WindowPassportActions(SqlConnection connection, string passportNumber,
            string authority, string dateOfIssue, string dateOfExpiration,
            int typeID, int authorityCountryID)
        {
            InitializeComponent();
            textBoxPassportNumber.Enabled = false;
            ActiveConnection = connection;
            GetDataFromServer(ActiveConnection);
            textBoxPassportNumber.Text = passportNumber;
            PassportNumber = passportNumber;
            textBoxAuthority.Text = authority;
            dateTimePickerIssueDate.Value = Convert.ToDateTime(dateOfIssue);
            dateTimePickerExpirationDate.Value = Convert.ToDateTime(dateOfExpiration);
            comboBoxAuthorityCountry.SelectedValue = authorityCountryID;
            comboBoxType.SelectedValue = typeID;
            buttonEditNumber.Visible = true;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
            Owner.Activate();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (SqlCommand sqlCommand = new SqlCommand($"EXEC NewPassport '{textBoxPassportNumber.Text}', N'{textBoxAuthority.Text}'," +
                $"'{dateTimePickerIssueDate.Value.ToShortDateString()}', '{dateTimePickerExpirationDate.Value.ToShortDateString()}', " +
                $"{comboBoxType.SelectedValue}, {comboBoxAuthorityCountry.SelectedValue}", ActiveConnection))
            {
                try
                {
                    if (sqlCommand.ExecuteNonQuery() > 0)
                    {
                        if (Owner is WindowClientActions)
                        {
                            (Owner as WindowClientActions).SetPassport(textBoxPassportNumber.Text);
                        }
                        Close();
                        Owner.Activate();
                    }
                    else
                    {
                        MessageBox.Show("Не удалось добавить запись :(", "Ошибка", MessageBoxButtons.OK);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Ошибка");
                }
            }
        }

        private void buttonEditNumber_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите изменить это поле?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                textBoxPassportNumber.Enabled = true;
                textBoxPassportNumber.Focus();
            }
        }

        private void GetDataFromServer(SqlConnection connection)
        {
            DataSet dataSet = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("EXEC AllPassportTypes", ActiveConnection);
            DataTable dataTablePassportTypes = new DataTable();
            dataAdapter.Fill(dataTablePassportTypes);
            dataAdapter.SelectCommand = new SqlCommand("EXEC AllAuthorityCountries", ActiveConnection);
            DataTable dataTableAuthorityCountries = new DataTable();
            dataAdapter.Fill(dataTableAuthorityCountries);
            dataSet.Tables.Add(dataTablePassportTypes);
            dataSet.Tables.Add(dataTableAuthorityCountries);
            dataAdapter.Dispose();
            comboBoxAuthorityCountry.DataSource = dataSet.Tables[1];
            comboBoxAuthorityCountry.ValueMember = "#";
            comboBoxAuthorityCountry.DisplayMember = "Название";
            comboBoxType.DataSource = dataSet.Tables[0];
            comboBoxType.ValueMember = "#";
            comboBoxType.DisplayMember = "Название";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (SqlCommand sqlCommand = new SqlCommand($"EXEC UpdatePassport '{PassportNumber}'," +
                $"'{textBoxPassportNumber.Text}', N'{textBoxAuthority.Text}'," +
                $"'{dateTimePickerIssueDate.Value.ToShortDateString()}', '{dateTimePickerExpirationDate.Value.ToShortDateString()}', " +
                $"{comboBoxType.SelectedValue}, {comboBoxAuthorityCountry.SelectedValue}", ActiveConnection))
            {
                try
                {
                    if (sqlCommand.ExecuteNonQuery() > 0)
                    {
                        if (Owner is WindowClientActions)
                        {
                            (Owner as WindowClientActions).SetPassport(textBoxPassportNumber.Text);
                        }
                        Close();
                        Owner.Activate();
                    }
                    else
                    {
                        MessageBox.Show("Не удалось обновить запись :(", "Ошибка", MessageBoxButtons.OK);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Ошибка");
                }
            }
        }
    }
}
