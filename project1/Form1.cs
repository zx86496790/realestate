using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class frmBranchSales : Form
    {
        decimal[] list = new decimal[5];
        public frmBranchSales()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addBranchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBranchList fbl = new frmBranchList(list);
            fbl.ShowDialog();
            decimal totalPrice=0;
            string temp="";
            if (list[0] != 0)
            {
                temp += "Brampton = $" + list[0] + Environment.NewLine;
            }
            if (list[1] != 0)
            {
                temp += "Oakville = $" + list[1] + Environment.NewLine;
            }
            if (list[2] != 0)
            {
                temp += "Toronto = $" + list[2] + Environment.NewLine;
            }
            if (list[3] != 0)
            {
                temp += "Mississauga = $" + list[3] + Environment.NewLine;
            }
            if (list[4] != 0)
            {
                temp += "Hamliton = $" + list[4] + Environment.NewLine;
            }
            foreach(decimal d in list)
            {
                totalPrice+=d;
            }
            txtTotalSales.Text = temp;
            lblPrice.Text = "$" + totalPrice;
        }

    }
}
