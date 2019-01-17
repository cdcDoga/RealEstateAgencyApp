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
    public partial class help_for_customer : Form
    {
        public help_for_customer()
        {
            InitializeComponent();
        }

        private void help_for_customer_Load(object sender, EventArgs e)
        {
            rtbHelp.Text = "To update information about contracts; double click on the related line.\n\nTo add a new customer; press the Add Owner/Purchaser button.";
        }

        private void btnHelpOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
