using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adopter
{
    public partial class Adopter_Controler : Form
    {
        function fn = new function();
        String query;
        public Adopter_Controler()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        protected int n, total = 0;
        private void btnAdopterSave_Click(object sender, EventArgs e)
        {
            query = "insert into adopter (orphan_id,adoption_date,NIC,first_name,last_name,contact_no,email,address,city) values (" + txtOrphanID.Text + ",'" + AdoptionDate.Text + "','" + txtAdopterNIC.Text + "','" + txtAdopterFName.Text + "','" + txtAdopterLName.Text + "'," + txtAdopterContact.Text + ",'" + txtAdopterEmail.Text + "','" + txtAdopterAddress + "','" + txtAdopterCity.Text + "')";
            fn.setData(query);
            clearAll();

        }

        public void clearAll()
        {
            txtOrphanID.Clear();
            txtAdopterNIC.Clear();
            txtAdopterFName.Clear();
            txtAdopterLName.Clear();
            txtAdopterContact.Clear();
            txtAdopterEmail.Clear();
            txtAdopterAddress.Clear();
            txtAdopterCity.Clear();

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void txtAdopterFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setTxtData()
        {
            //txtOrphanID.Text= sdr["orphan_id"].ToString();
           
        }

        
    }
}
