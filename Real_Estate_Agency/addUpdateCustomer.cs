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
using System.Collections;
using System.Data.OleDb;

namespace Real_Estate_Agency
{
    public partial class addUpdateCustomer : Form
    {
        OleDbConnection oledbConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Directory.GetCurrentDirectory().ToString() + @"\RealEstateAgency.mdb");
        int temp = -1;

        public addUpdateCustomer()
        {
            InitializeComponent();
            this.Text = "Add Owner";
        }

        public addUpdateCustomer(int i)
        {
            InitializeComponent();
            this.Text = "Add Purchaser";
            temp = i;
        }

        private void insert_owner()
        {
            string command = @"INSERT INTO [Owner] ([ownerTCID],[ownerName],[ownerSurname],[ownerAdress],[ownerPhoneNum],[o_RegDate]) VALUES (?,?,?,?,?,?)";
            OleDbCommand cmd = new OleDbCommand(command, oledbConn);

            cmd.Parameters.Add(":ownerId", OleDbType.Char).Value = tb_ID.Text;
            cmd.Parameters.Add(":ownerName", OleDbType.Char).Value = tbName.Text;
            cmd.Parameters.Add(":ownerSName", OleDbType.Char).Value = tbSurname.Text;
            cmd.Parameters.Add(":ownerAdress", OleDbType.Char).Value = tbAdress.Text;
            cmd.Parameters.Add(":ownerPhone", OleDbType.Char).Value = tbPhone.Text;
            cmd.Parameters.Add(":regisDateO", OleDbType.Date).Value = DateTime.Parse(DateTime.Today.ToString());
            try
            {
                oledbConn.Open();
                cmd.ExecuteNonQuery();
                oledbConn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("A problem occured in inserting owner. Please try again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void insert_purchaser()
        {
            string command = @"INSERT INTO [Purchaser] ([purchaserTCID],[purchaserName],[purchaserSurname],[purchaserAdress],[purchaserPhoneNum],[p_RegDate]) VALUES (?,?,?,?,?,?)";
            OleDbCommand cmd = new OleDbCommand(command, oledbConn);

            cmd.Parameters.Add(":pId", OleDbType.Char).Value = tb_ID.Text;
            cmd.Parameters.Add(":pName", OleDbType.Char).Value = tbName.Text;
            cmd.Parameters.Add(":pSName", OleDbType.Char).Value = tbSurname.Text;
            cmd.Parameters.Add(":pAdress", OleDbType.Char).Value = tbAdress.Text;
            cmd.Parameters.Add(":pPhone", OleDbType.Char).Value = tbPhone.Text;
            cmd.Parameters.Add(":regisDateP", OleDbType.Date).Value = DateTime.Parse(DateTime.Today.ToString());
            try
            {
                oledbConn.Open();
                cmd.ExecuteNonQuery();
                oledbConn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("A problem occured in inserting purchaser. Please try again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSubmitContract_Click(object sender, EventArgs e)
        {
            if (tbAdress.Text != "" && tbName.Text != "" && tbPhone.Text != "" && tbSurname.Text != "" && tb_ID.Text != "" && number_control(tb_ID.Text) && number_control(tbPhone.Text))
            {
                if(temp == -1)  // for owner
                {
                    insert_owner();
                    MessageBox.Show("Add successfully!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else  // for purchaser
                {
                    insert_purchaser();
                    MessageBox.Show("Add successfully!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "mainFrm")
                {
                    Application.OpenForms[i].Close();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
