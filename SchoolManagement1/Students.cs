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
    public partial class Students : Form
    {
        SqlCommand Cmd;
        string StrQuery;
        public Students()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            

            SqlConnection Con = new SqlConnection(@"server=MADHU0123\MADHUBABU0123;database=STUDENTdb; integrated security=true;");
            StrQuery = "insert into Students values( @p1,@p2,@p3,@P4,@p5,@p6)";
            Cmd = new SqlCommand(StrQuery, Con);
            Cmd.CommandType = CommandType.Text;
            Cmd.Parameters.AddWithValue("@p1", txtStd_ID.Text);
            Cmd.Parameters.AddWithValue("@p2", txtStd_Name.Text);
            Cmd.Parameters.AddWithValue("@p3", dateTimePicker1.Text);
            Cmd.Parameters.AddWithValue("@p4", txtStd_Gender.Text);
            Cmd.Parameters.AddWithValue("@p5", txtStd_Phone.Text);
            Cmd.Parameters.AddWithValue("@p6", txtStd_Email.Text);
            Con.Open();
            int i = Cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Record Added Successfully,Save " + MessageBoxButtons.OK);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"server=MADHU0123\MADHUBABU0123;database=STUDENTdb; integrated security=true;");
            StrQuery = "update Students set Name=@p2,DOB=@p3,Gender=@p4,Phone=@p5,Email=@p6 where ID=@p1";
            Cmd = new SqlCommand(StrQuery, Con);
            Cmd.CommandType = CommandType.Text;
            Cmd.Parameters.AddWithValue("@p1", txtStd_ID.Text);
            Cmd.Parameters.AddWithValue("@p2", txtStd_Name.Text);
            Cmd.Parameters.AddWithValue("@p3", dateTimePicker1.Text);
            Cmd.Parameters.AddWithValue("@p4", txtStd_Gender.Text);
            Cmd.Parameters.AddWithValue("@p5", txtStd_Phone.Text);
            Cmd.Parameters.AddWithValue("@p6", txtStd_Email.Text);
            Con.Open();
            int i = Cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show(i + "Record Updated Successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"server=MADHU0123\MADHUBABU0123;database=STUDENTdb; integrated security=true;");
            StrQuery = "delete Students where ID=@p1";
            Cmd = new SqlCommand(StrQuery, Con);
            Cmd.CommandType = CommandType.Text;
            Cmd.Parameters.AddWithValue("@p1", txtStd_ID.Text);
            Con.Open();
            int i = Cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show(i + "Record Deleted Successfully");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStd_ID.Text = " ";
            txtStd_Name.Text = " ";

            txtStd_Gender.Text = " ";
            txtStd_Phone.Text = " ";
            txtStd_Email.Text = " ";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"server=MADHU0123\MADHUBABU0123;database=STUDENTdb; integrated security=true;");
            Con.Open();
            StrQuery = "select * from Students";
            Cmd = new SqlCommand(StrQuery, Con);
            Cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Con.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Back)
            {
                dateTimePicker1.CustomFormat = " ";
            }
        }
    }
}
