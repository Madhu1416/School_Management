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

namespace SchoolManagement1
{
    public partial class Subjects : Form
    {
        SqlCommand Cmd;
        string StrQuery;
        public Subjects()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"server=MADHU0123\MADHUBABU0123;database=STUDENTdb; integrated security=true;");
            StrQuery = "insert into Subjects values( @p1,@p2)";
            Cmd = new SqlCommand(StrQuery, Con);
            Cmd.CommandType = CommandType.Text;
            Cmd.Parameters.AddWithValue("@p1", txtSubj_ID.Text);
            Cmd.Parameters.AddWithValue("@p2", txtSubj_Name.Text);
            Con.Open();
            int i = Cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Record Added Successfully,Save " + MessageBoxButtons.OK);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"server=MADHU0123\MADHUBABU0123;database=STUDENTdb; integrated security=true;");
            StrQuery = "update Subjects set Name=@p2 where ID=@p1";
            Cmd = new SqlCommand(StrQuery, Con);
            Cmd.CommandType = CommandType.Text;
            Cmd.Parameters.AddWithValue("@p1", txtSubj_ID.Text);
            Cmd.Parameters.AddWithValue("@p2", txtSubj_Name.Text);
            Con.Open();
            int i = Cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Record Added Successfully,Save " + MessageBoxButtons.OK);


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"server=MADHU0123\MADHUBABU0123;database=STUDENTdb; integrated security=true;");
            StrQuery = "delete Subjects where ID=@p1";
            Cmd = new SqlCommand(StrQuery, Con);
            Cmd.CommandType = CommandType.Text;
            Cmd.Parameters.AddWithValue("@p1", txtSubj_ID.Text);
            Con.Open();
            int i = Cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Record Added Successfully,Save " + MessageBoxButtons.OK);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSubj_ID.Text = "";
            txtSubj_Name.Text = "";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"server=MADHU0123\MADHUBABU0123;database=STUDENTdb; integrated security=true;");
            Con.Open();
            StrQuery = "select * from Subjects";
            Cmd = new SqlCommand(StrQuery, Con);
            Cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Con.Close();
        }
    }
}
