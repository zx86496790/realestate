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
    public partial class frmBranchList : Form
    {
        decimal[] list;
        Branches branches = new Branches();
        public frmBranchList(decimal[] list)
        {
            this.list = list;
            InitializeComponent();
            foreach (Branch b in branches.getCities())
            {
                cmbCities.Items.Add(b.City);
            }
            cmbCities.SelectedIndex=0;
            initInformation();
        }
        public void initInformation()
        { lblCity.Text = "City :" + branches.getCities()[cmbCities.SelectedIndex].City;
            lblPhone.Text = "Phone :" + branches.getCities()[cmbCities.SelectedIndex].Phone;
            lblPostal.Text = "Postal :" + branches.getCities()[cmbCities.SelectedIndex].Postal;
            lblStreet.Text = "Street :" + branches.getCities()[cmbCities.SelectedIndex].Street;
            picCities.ImageLocation = "Images/" + branches.getCities()[cmbCities.SelectedIndex].City + ".jpg";
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbCities.SelectedIndex = 0;
            initInformation();
            txtAmount.Text = "";
        }

        private void cmbCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            initInformation();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            bool flag = false;
            try { Convert.ToDecimal(txtAmount.Text); }
            catch(Exception e1)
            {
                MessageBox.Show("Sales amount for location incorrect", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmount.Text = "";
                flag = true;
            }
            if (flag == false)
            {
                DialogResult dr = MessageBox.Show("Do you want to add this record?\n" + cmbCities.SelectedItem + "\n" + string.Format("{0:F2}", Convert.ToDouble(txtAmount.Text)), "Add Sales Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    list[cmbCities.SelectedIndex] = Convert.ToDecimal(txtAmount.Text);
                    cmbCities.SelectedIndex = 0;
                    initInformation();
                    txtAmount.Text = "";
                }

            }
        }

        private void browsesToolStripMenuItem_Click(object sender, EventArgs e)
        {
             ofd.ShowDialog();
                if (ofd.FileName != "")
                {
                    if (ofd.SafeFileName == "Brampton.jpg")
                    {
                        cmbCities.SelectedIndex = 0;
                        initInformation();
                    }
                    else if (ofd.SafeFileName == "Oakville.jpg")
                    {
                        cmbCities.SelectedIndex = 1;
                        initInformation();
                    }
                    else if (ofd.SafeFileName == "Toronto.jpg")
                    {
                        cmbCities.SelectedIndex = 2;
                        initInformation();
                    }
                    else if (ofd.SafeFileName == "Mississauga.jpg")
                    {
                        cmbCities.SelectedIndex = 3;
                        initInformation();
                    }
                    else if (ofd.SafeFileName == "Hamilton.jpg")
                    {
                        cmbCities.SelectedIndex = 4;
                        initInformation();
                    }
            }
        }
    }
}
