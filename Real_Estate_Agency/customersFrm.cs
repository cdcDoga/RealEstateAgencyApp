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
    public partial class customersFrm : Form
    {
        OleDbConnection oledbConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Directory.GetCurrentDirectory().ToString() + @"\RealEstateAgency.mdb");
        ArrayList ALownerID = new ArrayList();
        ArrayList ALpurchaserID = new ArrayList();


        public customersFrm()
        {
            InitializeComponent();
            this.Text = "Agency >> List Customers";
        }

        private void btnHomeCustomer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHelpCustomer_Click(object sender, EventArgs e)
        {
            help_for_customer customerHelp = new help_for_customer();
            if(customerHelp.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        private void fill_listView_owner()
        {
            string command = @"SELECT Owner.* FROM Owner";
            OleDbCommand cmd = new OleDbCommand(command, oledbConn);

            try
            {
                oledbConn.Open();
                lvOwners.Items.Clear();
                ALownerID.Clear();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DateTime ownerDate = DateTime.Parse(reader["o_RegDate"].ToString());
                    string[] subitems = { reader["ownerTCID"].ToString(), reader["ownerName"].ToString(), reader["ownerSurname"].ToString(), reader["ownerAdress"].ToString(), reader["ownerPhoneNum"].ToString(), ownerDate.ToString("dd.MM.yyyy") };
                    ListViewItem items = new ListViewItem(subitems);
                    lvOwners.Items.Add(items);
                    ALownerID.Add(reader["ownerTCID"].ToString());
                }
                reader.Close();
                oledbConn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("A problem occured in filling lists. Please try again" + e, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fill_listView_purchaser()
        {
            string command = @"SELECT Purchaser.* FROM Purchaser";
            OleDbCommand cmd = new OleDbCommand(command, oledbConn);

            try
            {
                oledbConn.Open();
                lvPurchasers.Items.Clear();
                ALpurchaserID.Clear();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DateTime purchaserDate = DateTime.Parse(reader["p_RegDate"].ToString());
                    string[] subitems_2 = { reader["purchaserTCID"].ToString(), reader["purchaserName"].ToString(), reader["purchaserSurname"].ToString(), reader["purchaserAdress"].ToString(), reader["purchaserPhoneNum"].ToString(), purchaserDate.ToString("dd.MM.yyyy") };
                    ListViewItem items_2 = new ListViewItem(subitems_2);
                    lvPurchasers.Items.Add(items_2);
                    ALpurchaserID.Add(reader["purchaserTCID"].ToString());
                }
                reader.Close();
                oledbConn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("A problem occured in filling lists. Please try again" + e, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void customersFrm_Load(object sender, EventArgs e)
        {
            DateTime tarih = DateTime.Today;
            label1.Text = tarih.ToString("dd.MM.yyyy");
            fill_listView_owner();
            fill_listView_purchaser();
        }

        private void btnAddOwner_Click(object sender, EventArgs e)
        {
            addUpdateCustomer addOwner = new addUpdateCustomer();
            if(addOwner.ShowDialog(this) == DialogResult.OK)
            {
                fill_listView_owner();
            }
        }

        private void btnAddPurchaser_Click(object sender, EventArgs e)
        {
            addUpdateCustomer addPurchaser = new addUpdateCustomer(0);
            if (addPurchaser.ShowDialog(this) == DialogResult.OK)
            {
                fill_listView_purchaser();
            }
        }
    }
}
