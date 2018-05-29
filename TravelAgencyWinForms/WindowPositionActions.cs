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
    public partial class WindowPositionActions : Form
    {
        private SqlConnection ActiveConnection { get; set; }

        private int PositionID { get; set; }

        public WindowPositionActions(SqlConnection connection)
        {
            InitializeComponent();
            ActiveConnection = connection;
            buttonSave.Visible = false;
            this.Text = "Добавить";
        }

        public WindowPositionActions(SqlConnection connection, string positionName, int overheadPercentage, int positionID)
        {
            InitializeComponent();
            ActiveConnection = connection;
            textBoxPositionName.Text = positionName;
            numericUpDownPositionOverheadPercentage.Value = overheadPercentage;
            PositionID = positionID;
            this.Text = "Изменить";
            buttonAdd.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand
            {
                CommandText = $"EXEC NewPosition N'{textBoxPositionName.Text}', {numericUpDownPositionOverheadPercentage.Value}",
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
                CommandText = $"EXEC UpdatePosition {PositionID}, N'{textBoxPositionName.Text}', {numericUpDownPositionOverheadPercentage.Value}",
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
            Owner.Activate();
        }
    }
}
