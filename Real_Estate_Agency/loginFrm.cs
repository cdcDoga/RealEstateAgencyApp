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
    public partial class loginFrm : Form
    {
        public loginFrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(tbPssword.Text == "password")
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please check the password.", "Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
