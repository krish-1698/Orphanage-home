using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adopter
{
    class function
    {
        public SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source =DESKTOP-OKCEBSS;Database=adopter_details;Trusted_Connection=True";
            return conn;
        }

        public DataSet getData(string query)
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(string query)
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Data Processed Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void searchData(string query)
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.CommandText = query;
            SqlDataAdapter adapt = new SqlDataAdapter();
            adapt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            //dt.Fill(dt);
            //dataGridView.DataSource = dt;


        }

        public void updateData(string query)
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand();
            conn.Open();
            cmd.CommandText = query;
            using (SqlDataReader sdr = cmd.ExecuteReader())
            {
                sdr.Read();
                //txtOrphanID.text = sdr["orphan_id"].ToString();
                //txtAdopterNIC=sdr["NIC"].ToString;
                //txtAdopterFName.Text =sdr["first_name"].ToString;
                //txtAdopterLName=sdr["last_name"].ToString;
                //txtAdopterContact=sdr["contact_no"].ToString;
                //txtAdopterEmail=sdr["email"].ToString;
                //txtAdopterAddress=sdr["address"].ToString;
                //txtAdopterCity=sdr["city"].ToString;

            }
            conn.Close();
        }



    }
}
