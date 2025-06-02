using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Management
{
    public partial class ShopManagement : Form
    {
        public ShopManagement()
        {
            InitializeComponent();
            LoadScreen(new DashboardScreen());
        }



        private void LoadScreen(UserControl screen)
        {
            mainContentPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            mainContentPanel.Controls.Add(screen);
        }


        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
