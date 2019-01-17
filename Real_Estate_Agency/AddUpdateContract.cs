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
    public partial class AddUpdateContract : Form
    {

        OleDbConnection oledbConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Directory.GetCurrentDirectory().ToString() + @"\RealEstateAgency.mdb");
        int constractID = -1;
        int estateNo = -1;

        public AddUpdateContract()
        {
            InitializeComponent();
            this.Text = "Add Contract";
            tbType.Clear();
            tbPrice.Clear();
            rtbLocation.Clear();
        }

        private void btnBackContract_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHomeContract_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "mainFrm")
                {
                    Application.OpenForms[i].Close();
                }
            }
        }

        private void fill_cbOwnerID()
        {
            string command = @"SELECT Owner.ownerTCID FROM Owner";
            OleDbCommand cmd = new OleDbCommand(command, oledbConn);
            try
            {
                oledbConn.Open();
                cbOwnerID.Items.Clear();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbOwnerID.Items.Add(reader["ownerTCID"].ToString());
                }
                reader.Close();
                oledbConn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("A problem occured in filling owners. Please try again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fill_cbPurchaserID()
        {
            string command = @"SELECT Purchaser.purchaserTCID FROM Purchaser";
            OleDbCommand cmd = new OleDbCommand(command, oledbConn);
            try
            {
                oledbConn.Open();
                cbPurchaserID.Items.Clear();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbPurchaserID.Items.Add(reader["purchaserTCID"].ToString());
                }
                reader.Close();
                oledbConn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("A problem occured in filling purchasers. Please try again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fill_estateID()
        {
            string command = @"SELECT Real_Estate.estateNO FROM Real_Estate";
            OleDbCommand cmd = new OleDbCommand(command, oledbConn);
            try
            {
                oledbConn.Open();
                cbEstateNo.Items.Clear();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbEstateNo.Items.Add(reader["estateNO"].ToString());
                }
                reader.Close();
                oledbConn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("A problem occured in filling estates. Please try again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddUpdateContract_Load(object sender, EventArgs e)
        {
            fill_cbOwnerID();
            fill_cbPurchaserID();
            fill_estateID();
        }

        private void cbEstateNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string command = @"SELECT Real_Estate.estateNO, Real_Estate.type, Real_Estate.location, Real_Estate.price
                               FROM Real_Estate WHERE [estateNO]=?";
            OleDbCommand cmd = new OleDbCommand(command, oledbConn);

            cmd.Parameters.Add(":estate_no", OleDbType.BigInt).Value = Convert.ToInt32(cbEstateNo.SelectedItem);
            try
            {
                oledbConn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tbType.Text = reader["type"].ToString();
                    tbPrice.Text = reader["price"].ToString();
                    rtbLocation.Text = reader["location"].ToString();
                }
                reader.Close();
                oledbConn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("A problem occured in filling the improtant information. Please try again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void insert_contract()
        {
            string command = @"INSERT INTO [Contract] ([ownerTCID],[purchaserTCID],[estateNO],[contractDate]) VALUES (?,?,?,?)";
            OleDbCommand cmd = new OleDbCommand(command, oledbConn);

            cmd.Parameters.Add(":ownerId", OleDbType.Char).Value = cbOwnerID.SelectedItem.ToString();
            cmd.Parameters.Add(":purchaserId", OleDbType.Char).Value = cbPurchaserID.SelectedItem.ToString();
            cmd.Parameters.Add(":estateNo", OleDbType.BigInt).Value = Convert.ToUInt32(cbEstateNo.SelectedItem);
            cmd.Parameters.Add(":date", OleDbType.Date).Value = DateTime.Parse(dtpContractDate.Text);
            try
            {
                oledbConn.Open();
                cmd.ExecuteNonQuery();
                oledbConn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("A problem occured in inserting contract. Please try again", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSubmitContract_Click(object sender, EventArgs e)
        {
            if (cbOwnerID.Text != "" && cbPurchaserID.Text != "" && cbEstateNo.Text != "" && number_control(cbOwnerID.Text) && number_control(cbPurchaserID.Text) && number_control(cbEstateNo.Text) && dtpContractDate.Value <= DateTime.Now)
            {
                if (constractID == -1 && estateNo == -1)
                {
                    insert_contract();
                    MessageBox.Show("Add successfully!", ":)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;  
                    this.Close();
                }
                else      //for updating
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
