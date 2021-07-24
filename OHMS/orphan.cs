using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace OHMS
{
    public partial class orphan : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-H8CICF1Q;Initial Catalog=orphan;Integrated Security=True;Pooling=False");
        String Gender;
        public orphan()
        {
            InitializeComponent();
        }
     

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into register values('"+txtInmateID.Text+"','"+txtInmateName.Text+"','"+Gender+"','"+InmateDOA.Text+"','"+InmateDOB.Text+"','"+richdeficiencies.Text+"','"+txtInmateguardianN.Text+"','"+txtInmateguardianNic.Text+"','"+txtInmateguardianaddress.Text+"','"+txtInmateguardiancontcat.Text+"','"+richhowboarded.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record added successfully");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void txtInmateID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
