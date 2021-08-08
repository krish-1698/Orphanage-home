using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adopter
    
{
    public partial class Form1 : Form     {
        function fn = new function();
        String query;
        public Form1()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void InmateDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonAddAdopter_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddAdopter_Click_1(object sender, EventArgs e)
        {
            using (Adopter_Controler f1 = new Adopter_Controler())
            {
                f1.ShowDialog();

            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            query = "select * from adopter_details where orphan_id like ('" + txtSearch + "')";
            fn.searchData(query);
        }

        private void btnAdopterUpdate_Click(object sender, EventArgs e)
        {
            FormUpdate f2 = new FormUpdate();
            f2.Show();

            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adopter_Controler f2 = new Adopter_Controler();
            f2.Show();


        }

        private void btnView_Click(object sender, EventArgs e)
        {
            query = "select * from adopter_details where orphan_id like ('" + txtSearch + "%')";
            fn.searchData(query);
        }
    }
}
