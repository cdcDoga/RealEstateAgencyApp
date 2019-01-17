using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Collections;

namespace Real_Estate_Agency
{
    public partial class AddUpdateEstate : Form
    {
        OleDbConnection oledbConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Directory.GetCurrentDirectory().ToString() + @"\RealEstateAgency.mdb");
        int estateId = -1;

        public AddUpdateEstate()
        {
            InitializeComponent();
            this.Text = "Add Estate";
        }

        private void btnBackEstate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHomeEstate_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "mainFrm")
                {
                    Application.OpenForms[i].Close();
                }  
            }
        }

        private void insert_Estate()
        {
            string command = @"INSERT INTO [Real_Estate] ([type],[location],[m^2],[level],[number_of_room],[status],[constructionYear],[heating_system],[extra],[price],[e_RegDate]) VALUES (?,?,?,?,?,?,?,?,?,?,?)";
            OleDbCommand cmd = new OleDbCommand(command, oledbConn);

            cmd.Parameters.Add(":type", OleDbType.Char).Value = cbType.Text;
            cmd.Parameters.Add(":location", OleDbType.Char).Value = tbLocation.Text;
            cmd.Parameters.Add(":m²", OleDbType.BigInt).Value = tb_mSquare.Text;
            cmd.Parameters.Add(":level", OleDbType.Char).Value = tbLevel.Text;
            cmd.Parameters.Add(":room", OleDbType.Char).Value = tbRooms.Text;
            cmd.Parameters.Add(":status", OleDbType.Char).Value = tbStatus.Text;
            cmd.Parameters.Add(":CYear", OleDbType.Date).Value = DateTime.Parse(dtpCYear.Text);
            cmd.Parameters.Add(":heat", OleDbType.Char).Value = cbHeating.Text;
            cmd.Parameters.Add(":extra", OleDbType.Char).Value = tbExtra.Text;
            cmd.Parameters.Add(":price", OleDbType.Char).Value = tbPrice.Text;
            cmd.Parameters.Add(":regisDate", OleDbType.Date).Value = DateTime.Parse(DateTime.Today.ToString());
            try
            {
                oledbConn.Open();
                cmd.ExecuteNonQuery();
                oledbConn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("A problem occured in inserting estate. Please try again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSubmitEstate_Click(object sender, EventArgs e)
        {
            if(cbType.Text != "" && cbHeating.Text != "" && tbLevel.Text != "" && tbLocation.Text != "" && tbPrice.Text != "" && tbRooms.Text != "" && tbStatus.Text != "" && tb_mSquare.Text != "" && number_control(tb_mSquare.Text) && number_control(tbPrice.Text))
            {
                if(estateId == -1)
                {
                    insert_Estate();
                    MessageBox.Show("Add successfully!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else     // for updating
                {

                }
            }
            else   
            {
                MessageBox.Show("Please check your information", "Not Valid", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private bool number_control(string x)
        {
            bool b = x.All(char.IsDigit);
            return b;
        }
    }
}
