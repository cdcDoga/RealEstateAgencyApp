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
    public partial class helpFrm : Form
    {
        public helpFrm()  // For contractsFrm
        {
            InitializeComponent();
        }

        private void helpFrm_Load(object sender, EventArgs e)
        {
            rtbHelp.Text = "Estate informations are given in this form just because Fahrettin Ak has told theese informations are primary for him. So you are not allowed to change them. Theese changes can only be made by Home >> List Estates.\n\nTo add a new contract; press the Add Contract button. Again you are not allowed to add estate informations from here.";
        }

        private void btnHelpOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
