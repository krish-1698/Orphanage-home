using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace OHMS
{
    public partial class orphan_dailyActivity : Form
    {
        public orphan_dailyActivity()
        {
            InitializeComponent();
        }

        private void orphan_dailyActivity_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost; username=root; password=; database=OHMS");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from ", con);
            MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);

           
            con.Close();
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtInmateID_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id, date, intime, outtime, purpose;
            id = txtInmateID.Text;
            date = dateTimePicker1;
            intime = ;
            outtime = ;
            purpose = richTxtPurpose.Text;
        }
    }
}
