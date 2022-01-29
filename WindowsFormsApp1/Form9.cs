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
    public partial class Form9 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=lrdanalysis;Integrated Security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            label4.Text = "KISKANÇ";
            cmd = new SqlCommand("update puppet_info set puppet_class= 'kıskanç' where puppet_name=@puppet_name", con);
            con.Open();
            cmd.Parameters.AddWithValue("@puppet_name", Form1.SetValueForText1);
            cmd.ExecuteNonQuery();
            con.Close();
            DisplayData();
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select puppet_name, puppet_class from puppet_info", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
