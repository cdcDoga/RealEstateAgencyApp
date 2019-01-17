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
    public partial class help_for_estateFrm : Form
    {
        public help_for_estateFrm()
        {
            InitializeComponent();
            this.Text = "Help";
        }

        private void help_for_estateFrm_Load(object sender, EventArgs e)
        {
            rtbHelp.Text = "To change information about estates; double click on the related line.\n\nTo add a new estate; press the Add Estate button.\n\nThe notation '#of' is used for 'number of'";
        }

        private void btnHelpOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
