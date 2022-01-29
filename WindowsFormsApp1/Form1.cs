using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
   
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=lrdanalysis;Integrated Security=true;");
        SqlCommand cmd;
        DataSet ds = new DataSet();
        public static string SetValueForText1 = "";

        public Form1()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommand("SELECT * from puppet_info where puppet_name='"+textBox1.Text+"'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i>0)
            {
                MessageBox.Show("Böyle biri zaten var");
                ds.Clear();
            }
           else
            {   
                cmd = new SqlCommand("insert into puppet_info(puppet_name,puppet_classcateg1,puppet_classcateg2,puppet_classcateg3,puppet_classcateg4) values(@puppet_name,@puppet_classcateg1,@puppet_classcateg2,@puppet_classcateg3,@puppet_classcateg4)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@puppet_name", textBox1.Text);
                cmd.Parameters.AddWithValue("@puppet_classcateg1", 0);
                cmd.Parameters.AddWithValue("@puppet_classcateg2", 0);
                cmd.Parameters.AddWithValue("@puppet_classcateg3", 0);
                cmd.Parameters.AddWithValue("@puppet_classcateg4", 0);
                cmd.ExecuteNonQuery();
                con.Close();
                SetValueForText1 = textBox1.Text;
                ds.Clear();
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            

                
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

 
    }
}
