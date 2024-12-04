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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SchoolManagement1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection(@"server=MADHU0123\MADHUBABU0123;database=STUDENTdb; integrated security=true;");
            Con.Open();
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            SqlCommand cmd = new SqlCommand("select * from Login where Username='" + username + "' and Password='" + password + "'", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Main mn = new Main();
                this.Hide();
                mn.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password !");
            }
            Con.Close();
        }
    }
    
}
