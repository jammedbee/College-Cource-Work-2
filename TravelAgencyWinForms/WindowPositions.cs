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
    public partial class WindowPositions : Form
    {
        private SqlConnection ActiveConnection { get; set; }

        private int SelectedID { get; set; }

        private int SelectedOverheadPercentage { get; set; }

        private string SelectedName { get; set; }

        public WindowPositions(SqlConnection connection)
        {
            InitializeComponent();
            ActiveConnection = connection;
        }

        private void WindowPositions_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            SelectedID = (int)dataGridViewPositions.CurrentRow.Cells[0].Value;
            SelectedName = (string)dataGridViewPositions.CurrentRow.Cells[1].Value;
            SelectedOverheadPercentage = Convert.ToInt32(dataGridViewPositions.CurrentRow.Cells[2].Value);

            (new WindowPositionActions(ActiveConnection, SelectedName, SelectedOverheadPercentage, SelectedID)).ShowDialog(this);

            FillDataGrid();
        }

        private void FillDataGrid()
        {
            DataSet dataSetPositions = new DataSet("Positions");
            SqlCommand sqlCommand = new SqlCommand
            {
                CommandText = "EXEC AllPositions",
                Connection = ActiveConnection
            };
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataSetPositions);
            dataGridViewPositions.DataSource = dataSetPositions.Tables[0];
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SelectedID = (int)dataGridViewPositions.CurrentRow.Cells[0].Value;
            
            if (MessageBox.Show("Вы уверены? Действие не может быть отменено!", "Подтверждение действия", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand sqlCommand = new SqlCommand
                {
                    CommandText = $"EXEC DeletePosition {SelectedID}",
                    Connection = ActiveConnection
                };
                if (sqlCommand.ExecuteNonQuery() != 0)
                {
                    FillDataGrid();
                }
                else
                {
                    MessageBox.Show("Призошла ошибка при удалении.", "Ошибка", MessageBoxButtons.OK);
                }
            }
            else
            {
                SelectedID = 0;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            (new WindowPositionActions(ActiveConnection)).ShowDialog(this);
        }
    }
}
