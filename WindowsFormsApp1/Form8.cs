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
    public partial class Form8 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=lrdanalysis;Integrated Security=true;");
        SqlCommand cmd;
    
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update puppet_info set puppet_classcateg1= puppet_classcateg1 + 1 where puppet_name=@puppet_name", con);
            con.Open();
            cmd.Parameters.AddWithValue("@puppet_name", Form1.SetValueForText1);
            cmd.ExecuteNonQuery();
            con.Close();
            Form7 que7 = new Form7();
            que7.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update puppet_info set puppet_classcateg2= puppet_classcateg2 + 1 where puppet_name=@puppet_name", con);
            con.Open();
            cmd.Parameters.AddWithValue("@puppet_name", Form1.SetValueForText1);
            cmd.ExecuteNonQuery();
            con.Close();
            Form7 que7 = new Form7();
            que7.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update puppet_info set puppet_classcateg3= puppet_classcateg3 + 1 where puppet_name=@puppet_name", con);
            con.Open();
            cmd.Parameters.AddWithValue("@puppet_name", Form1.SetValueForText1);
            cmd.ExecuteNonQuery();
            con.Close();
            Form7 que7 = new Form7();
            que7.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("update puppet_info set puppet_classcateg4= puppet_classcateg4 + 1 where puppet_name=@puppet_name", con);
            con.Open();
            cmd.Parameters.AddWithValue("@puppet_name", Form1.SetValueForText1);
            cmd.ExecuteNonQuery();
            con.Close();
            Form7 que7 = new Form7();
            que7.Show();
            this.Hide();
        }
    }
}
