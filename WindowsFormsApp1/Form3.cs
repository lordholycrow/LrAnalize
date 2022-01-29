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

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=lrdanalysis;Integrated Security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;


        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = Form1.SetValueForText1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cmd = new SqlCommand("update puppet_info set puppet_classcateg1= puppet_classcateg1 + 1 where puppet_name=@puppet_name", con);
            con.Open();
            cmd.Parameters.AddWithValue("@puppet_name", Form1.SetValueForText1);
            cmd.ExecuteNonQuery();
            con.Close();
            Form4 que4 = new Form4();
            que4.Show();
            this.Hide();

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update puppet_info set puppet_classcateg2= puppet_classcateg2 + 1 where puppet_name=@puppet_name", con);
            con.Open();
            cmd.Parameters.AddWithValue("@puppet_name", Form1.SetValueForText1);
            cmd.ExecuteNonQuery();
            con.Close();
            Form4 que4 = new Form4();
            que4.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update puppet_info set puppet_classcateg3= puppet_classcateg3 + 1 where puppet_name=@puppet_name", con);
            con.Open();
            cmd.Parameters.AddWithValue("@puppet_name", Form1.SetValueForText1);
            cmd.ExecuteNonQuery();
            con.Close();
            Form4 que4 = new Form4();
            que4.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update puppet_info set puppet_classcateg4= puppet_classcateg4 + 1 where puppet_name=@puppet_name", con);
            con.Open();
            cmd.Parameters.AddWithValue("@puppet_name", Form1.SetValueForText1);
            cmd.ExecuteNonQuery();
            con.Close();
            Form4 que4 = new Form4();
            que4.Show();
            this.Hide();
        }
    }
}
