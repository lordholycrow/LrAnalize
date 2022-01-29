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
    public partial class Form7 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=lrdanalysis;Integrated Security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public Form7()
        {
            InitializeComponent();
           
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            label4.Text = Form1.SetValueForText1;
            TakeCategs();
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
        private void TakeCategs()
        {
            SqlCommand cmd4 = new SqlCommand();
            con.Open();
            cmd4.Connection = con;
            cmd4.CommandText = "select puppet_classcateg1 from  puppet_info where puppet_name = '" + Form1.SetValueForText1 + "'";
            int classcateg1 = (int)cmd4.ExecuteScalar();
            cmd4.Dispose();
            con.Close();

            SqlCommand cmd5 = new SqlCommand();
            con.Open();
            cmd5.Connection = con;
            cmd5.CommandText = "select puppet_classcateg2 from  puppet_info where puppet_name = '" + Form1.SetValueForText1 + "'";
            int classcateg2 = (int)cmd5.ExecuteScalar();
            cmd5.Dispose();
            con.Close();

            SqlCommand cmd1 = new SqlCommand();
            con.Open();
            cmd1.Connection = con;
            cmd1.CommandText = "select puppet_classcateg3 from  puppet_info where puppet_name = '" + Form1.SetValueForText1 + "'";
            int classcateg3 = (int)cmd1.ExecuteScalar();
            cmd1.Dispose();
            con.Close();

            SqlCommand cmd2 = new SqlCommand();
            con.Open();
            cmd2.Connection = con;
            cmd2.CommandText = "select puppet_classcateg4 from  puppet_info where puppet_name = '" + Form1.SetValueForText1 + "'";
            int classcateg4 = (int)cmd2.ExecuteScalar();
            cmd2.Dispose();
            con.Close();
            //herhangi biri büyük
            if(classcateg1>classcateg2 & classcateg1 > classcateg3 & classcateg1 > classcateg4 )
            {
                label2.Text = "Kesin sonuçlu";
                cmd = new SqlCommand("update puppet_info set puppet_class= 'Kesin sonuçlu' where puppet_name=@puppet_name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@puppet_name", Form1.SetValueForText1);
                cmd.ExecuteNonQuery();
                con.Close();

            }     
           
 else if (classcateg2 > classcateg1 & classcateg2 > classcateg3 & classcateg2 > classcateg4)
            {
                label2.Text = "Olumsuz ";
                cmd = new SqlCommand("update puppet_info set puppet_class= 'Olumsuz' where puppet_name=@puppet_name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@puppet_name", Form1.SetValueForText1);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            else if (classcateg3 > classcateg1 & classcateg3 > classcateg2 & classcateg3 > classcateg4)
            {
                label2.Text = "Gerçekçi";
                cmd = new SqlCommand("update puppet_info set puppet_class= 'Gerçekçi' where puppet_name=@puppet_name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@puppet_name", Form1.SetValueForText1);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            else if (classcateg4 > classcateg1 & classcateg4 > classcateg2 & classcateg4 > classcateg3)
            {
                label2.Text = "Şüpheci";
                cmd = new SqlCommand("update puppet_info set puppet_class= 'Şüpheci' where puppet_name=@puppet_name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@puppet_name", Form1.SetValueForText1);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            //1ve 
            else if(classcateg1 == classcateg2 & classcateg1>classcateg3 & classcateg1 >  classcateg4 & classcateg2 > classcateg3 & classcateg2 > classcateg4 )
            {
                label2.Text = "karamsar";
                cmd = new SqlCommand("update puppet_info set puppet_class= 'karamsar' where puppet_name=@puppet_name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@puppet_name", Form1.SetValueForText1);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            else if (classcateg1 == classcateg3 & classcateg1 > classcateg2 & classcateg1 > classcateg4 & classcateg3 > classcateg2 & classcateg3 > classcateg4)
            {
                label2.Text = "kendinden emin";
                cmd = new SqlCommand("update puppet_info set puppet_class= 'kendinden emin' where puppet_name=@puppet_name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@puppet_name", Form1.SetValueForText1);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            else if (classcateg1 == classcateg4 & classcateg1 > classcateg2 & classcateg1 > classcateg3 & classcateg4 > classcateg2 & classcateg3 < classcateg4)
            {
                label2.Text = "tutarsız";
                cmd = new SqlCommand("update puppet_info set puppet_class= 'tutarsız' where puppet_name=@puppet_name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@puppet_name", Form1.SetValueForText1);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            //2ve 
            else if (classcateg2 == classcateg3 & classcateg2 > classcateg1 & classcateg2 > classcateg4 & classcateg3 > classcateg1 & classcateg3 > classcateg4)
            {
                label2.Text = "negatif";
                cmd = new SqlCommand("update puppet_info set puppet_class= 'negatif' where puppet_name=@puppet_name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@puppet_name", Form1.SetValueForText1);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            else if (classcateg2 == classcateg4 & classcateg2 > classcateg1 & classcateg2 > classcateg3 & classcateg4 > classcateg1 & classcateg3 < classcateg4)
            {
                label2.Text = "Paranoyak";
                cmd = new SqlCommand("update puppet_info set puppet_class= 'Paranoyak' where puppet_name=@puppet_name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@puppet_name", Form1.SetValueForText1);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            //3-4
            else if (classcateg3 == classcateg4 & classcateg3 > classcateg1 & classcateg3 > classcateg2 & classcateg4 > classcateg1 & classcateg4 > classcateg2)
            {
                label2.Text = "Mantık Arayan";
                cmd = new SqlCommand("update puppet_info set puppet_class= 'Mantık Arayan' where puppet_name=@puppet_name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@puppet_name", Form1.SetValueForText1);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            //eşit
            else
            {
                label2.Text = "kararsız";
                cmd = new SqlCommand("update puppet_info set puppet_class= 'kararsız' where puppet_name=@puppet_name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@puppet_name", Form1.SetValueForText1);
                cmd.ExecuteNonQuery();
                con.Close();
            }
              
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 shouldntgothere = new Form9();
            shouldntgothere.Show();
            this.Hide();
        }
    }
}
