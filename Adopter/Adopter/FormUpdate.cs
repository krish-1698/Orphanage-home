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
    public partial class FormUpdate : Form
    {
        function fn = new function();
        string query; 
        public FormUpdate()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdopterUpdate_Click(object sender, EventArgs e)
        {
            query = "update adopter.adopter_details orphan_id= " + this.txtOrphanID.Text + ", adoption_date = '" + this.AdoptionDate.Text + "', NIC= '" + this.txtAdopterNIC.Text + "', first_name = '" + this.txtAdopterFName.Text + "', last_name = '" + this.txtAdopterLName.Text + "', contact_no= " + this.txtAdopterContact.Text + ", email ='" + this.txtAdopterEmail.Text + "', address = '" + this.txtAdopterAddress.Text + "', city = '" + this.txtAdopterCity.Text + "' where orphan_id = " + this.txtOrphanID.Text + " ";
            fn.setData(query);
        }
    }
}
