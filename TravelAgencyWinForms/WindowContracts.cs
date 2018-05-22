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

namespace TravelAgencyWinForms
{
    public partial class WindowContracts : Form
    {
        private SqlConnection ActiveConnection { get; set; }

        public WindowContracts(SqlConnection connection)
        {
            InitializeComponent();
            ActiveConnection = connection;
        }

        private void POSITIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new WindowPositions(ActiveConnection)).Show();
        }

        private void nEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new WindowPositionActions(ActiveConnection)).ShowDialog(this);
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new WindowPositionActions(ActiveConnection, "Тесто", 100, 5)).ShowDialog(this);
        }

        private void nEWToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void eDITToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            (new WindowEmployeeActions(ActiveConnection, 7, "тесть", "тест", "тест", "8(800)000-00-00", "ads@gd.com", "1111222233334444", 2)).ShowDialog(this);
        }

        private void eMPLOYEEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new WindowEmployees(ActiveConnection)).Show();
        }

        private void nEWToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            (new WindowLoginActions(ActiveConnection)).ShowDialog(this);
        }

        private void nEWToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            (new WindowFoodTypeActions(ActiveConnection)).ShowDialog(this);
        }

        private void eDITToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            (new WindowFoodTypeActions(ActiveConnection, 10, "Тест", "Тест", "Тест", "Описание")).ShowDialog(this);
        }
    }
}
