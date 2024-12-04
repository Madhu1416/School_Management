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
    public partial class Teachers : Form
    {
        SqlCommand Cmd;
        string StrQuery;
        public Teachers()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"server=MADHU0123\MADHUBABU0123;database=STUDENTdb; integrated security=true;");
            StrQuery = "insert into Teachers values( @p1,@p2,@p3,@P4)";
            Cmd = new SqlCommand(StrQuery, Con);
            Cmd.CommandType = CommandType.Text;
            Cmd.Parameters.AddWithValue("@p1", txttchr_ID.Text);
            Cmd.Parameters.AddWithValue("@p2", txttchr_Name.Text);
            Cmd.Parameters.AddWithValue("@p3", txttchr_Gender.Text);
            Cmd.Parameters.AddWithValue("@p4", txttchr_Subject.Text);
            Con.Open();
            int i = Cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Record Added Successfully,Save " + MessageBoxButtons.OK);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"server=MADHU0123\MADHUBABU0123;database=STUDENTdb; integrated security=true;");
            StrQuery = "update Teachers set Name=@P2,Gender=@p3,Subject=@p4 where ID=@p1";
            Cmd = new SqlCommand(StrQuery, Con);
            Cmd.CommandType = CommandType.Text;
            Cmd.Parameters.AddWithValue("@p1", txttchr_ID.Text);
            Cmd.Parameters.AddWithValue("@p2", txttchr_Name.Text);
            Cmd.Parameters.AddWithValue("@p3", txttchr_Gender.Text);
            Cmd.Parameters.AddWithValue("@p4", txttchr_Subject.Text);
            Con.Open();
            int i = Cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Record Updated Successfully,Save " + MessageBoxButtons.OK);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"server=MADHU0123\MADHUBABU0123;database=STUDENTdb; integrated security=true;");
            StrQuery = "delete Teachers where ID=@p1";
            Cmd = new SqlCommand(StrQuery, Con);
            Cmd.CommandType = CommandType.Text;
            Cmd.Parameters.AddWithValue("@p1", txttchr_ID.Text);
            Con.Open();
            int i = Cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Record Deleted Successfully,Save " + MessageBoxButtons.OK);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"server=MADHU0123\MADHUBABU0123;database=STUDENTdb; integrated security=true;");
            Con.Open();
            StrQuery = "select * from Teachers";
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
