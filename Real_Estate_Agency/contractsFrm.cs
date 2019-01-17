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

    public partial class contractsFrm : Form
    {
        OleDbConnection oledbConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Directory.GetCurrentDirectory().ToString() + @"\RealEstateAgency.mdb");
        ArrayList ALcontractID = new ArrayList();
        ArrayList ALestateID = new ArrayList();

        public contractsFrm()
        {
            InitializeComponent();
            this.Text = "Agency >> List Contracts";
        }

        private void contractsFrm_Load(object sender, EventArgs e)
        {
            DateTime tarih = DateTime.Today;
            label1.Text = tarih.ToString("dd.MM.yyyy");
            fill_listView();
        }
        
        private void fill_listView()
        {
            string command = @"SELECT Contract.contractNO, Contract.ownerTCID, Contract.purchaserTCID, Contract.estateNO, Contract.contractDate, Real_Estate.type, Real_Estate.location, Real_Estate.price
                               FROM Real_Estate INNER JOIN Contract ON Real_Estate.estateNO = Contract.estateNO";
            OleDbCommand cmd = new OleDbCommand(command, oledbConn);

            try
            {
                oledbConn.Open();
                lvContracts.Items.Clear();
                ALcontractID.Clear();
                ALestateID.Clear();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DateTime cDate = DateTime.Parse(reader["contractDate"].ToString());
                    string[] subitems = { reader["contractNO"].ToString(), cDate.ToString("dd.MM.yyyy"), reader["ownerTCID"].ToString(), reader["purchaserTCID"].ToString(), reader["estateNO"].ToString(), reader["type"].ToString(), reader["price"].ToString(), reader["location"].ToString() };
                    ListViewItem items = new ListViewItem(subitems);
                    lvContracts.Items.Add(items);
                    ALcontractID.Add(reader["contractNO"].ToString());
                    ALestateID.Add(reader["estateNO"].ToString());
                }
                reader.Close();
                oledbConn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("A problem occured in filling list. Please try again" + e, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            helpFrm help = new helpFrm();
            if (help.ShowDialog(this) == DialogResult.OK)
            {
                help.Close();
            }
        }

        private void btnHomeContract_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddContract_Click(object sender, EventArgs e)
        {
            AddUpdateContract addContract = new AddUpdateContract();
            if (addContract.ShowDialog(this) == DialogResult.OK)
            {
                fill_listView();
            }
        }
    }
}
