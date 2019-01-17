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
    public partial class estatesFrm : Form
    {

        OleDbConnection oledbConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Directory.GetCurrentDirectory().ToString() + @"\RealEstateAgency.mdb");
        ArrayList ALestateNO = new ArrayList();

        public estatesFrm()
        {
            InitializeComponent();
            this.Text = "Agency >> List Estates";
        }

        private void btnHomeEstate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void estatesFrm_Load(object sender, EventArgs e)
        {
            DateTime tarih = DateTime.Today;
            label1.Text = tarih.ToString("dd.MM.yyyy");
            fill_listView();
        }

        private void fill_listView()
        {
            string command = @"SELECT Real_Estate.* FROM Real_Estate";
            OleDbCommand cmd = new OleDbCommand(command, oledbConn);

            try
            {
                oledbConn.Open();
                lvEstates.Items.Clear();
                ALestateNO.Clear();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DateTime cyDate = DateTime.Parse(reader["constructionYear"].ToString());
                    DateTime estateDate = DateTime.Parse(reader["e_RegDate"].ToString());
                    string[] subitems = { reader["estateNO"].ToString(), reader["type"].ToString(), reader["location"].ToString(), reader["m^2"].ToString(), reader["level"].ToString(), reader["number_of_room"].ToString(), reader["status"].ToString(), cyDate.ToString("dd.MM.yyyy"), reader["heating_system"].ToString(), reader["extra"].ToString(), reader["price"].ToString(), estateDate.ToString("dd.MM.yyyy") };
                    ListViewItem items = new ListViewItem(subitems);
                    lvEstates.Items.Add(items);
                    ALestateNO.Add(reader["estateNO"].ToString());
                }
                reader.Close();
                oledbConn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("A problem occured in filling list. Please try again" + e, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHelpEstate_Click(object sender, EventArgs e)
        {
            help_for_estateFrm estateHelp = new help_for_estateFrm();
            if(estateHelp.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        private void btnAddEstate_Click(object sender, EventArgs e)
        {
            AddUpdateEstate addEstate = new AddUpdateEstate();
            if(addEstate.ShowDialog(this) == DialogResult.OK)
            {
                fill_listView();
            }
        }
    }
}
