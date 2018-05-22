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
    public partial class WindowFoodTypeActions : Form
    {
        private SqlConnection ActiveConnection { get; set; }

        private int TypeID { get; set; }

        private string TypeName { get; set; }

        private string TypeEngName { get; set; }

        private string TypeSymbolicName { get; set; }

        private string TypeDescription { get; set; }

        private delegate void Del();

        public WindowFoodTypeActions(SqlConnection connection)
        {
            InitializeComponent();
            ActiveConnection = connection;
        }

        public WindowFoodTypeActions(SqlConnection connection, int typeID
            , string typeName, string typeEngName, string typeSymbol, string typeDescription)
        {
            InitializeComponent();
            ActiveConnection = connection;
            TypeID = typeID;
            TypeName = typeName;
            TypeEngName = typeEngName;
            TypeSymbolicName = typeSymbol;
            TypeDescription = typeDescription;
            Del del = () =>
            {
                textBoxName.Text = TypeName; textBoxTransName.Text = TypeEngName;
                textBoxSymbolicName.Text = TypeSymbolicName; richTextBoxDescription.Text = TypeDescription;
            };
            del();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand
            {
                CommandText = $"EXEC NewFoodType N'{textBoxName.Text}', N'{textBoxTransName.Text}'," +
                $" N'{textBoxSymbolicName.Text}', N'{richTextBoxDescription.Text}'",
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
                CommandText = $"EXEC UpdateFoodType {TypeID}, N'{textBoxName.Text}', N'{textBoxTransName.Text}'," +
                $" N'{textBoxSymbolicName.Text}', N'{richTextBoxDescription.Text}'",
                Connection = ActiveConnection
            };

            try
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
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
            Owner.Activate();
        }
    }
}
