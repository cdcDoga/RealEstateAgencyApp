using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Real_Estate_Agency
{
    public partial class mainFrm : Form
    {
        public mainFrm()
        {
            InitializeComponent();
            this.Text = "Agency";
        }
        
        private void mainFrm_Load(object sender, EventArgs e)
        {
            login_control();
        }

        private void login_control()
        {
            loginFrm login = new loginFrm();
            if (login.ShowDialog(this) == DialogResult.OK)
            {

            }
            else
            {
                this.Close();
            }
        }

        private void btnListContracts_Click(object sender, EventArgs e)
        {
            contractsFrm contracts = new contractsFrm();
            if(contracts.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        private void btnListEsatates_Click(object sender, EventArgs e)
        {
            estatesFrm estates = new estatesFrm();
            if(estates.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        private void btnListCustomers_Click(object sender, EventArgs e)
        {
            customersFrm customers = new customersFrm();
            if(customers.ShowDialog(this) == DialogResult.OK)
            {

            }
        }
    }
}
