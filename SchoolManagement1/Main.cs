using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            Students Sdt=new Students();
            Sdt.Show();
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            Subjects sbj=new Subjects();
            sbj.Show();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            Teachers Tr=new Teachers();
            Tr.Show();
        }

        private void btnSection_Click(object sender, EventArgs e)
        {
            Sections sc=new Sections();
            sc.Show();
        }

        private void btnEnrollment_Click(object sender, EventArgs e)
        {
            Enrollment Em=new Enrollment();
            Em.Show();
        }

        private void btnAttendence_Click(object sender, EventArgs e)
        {
            Attendence at=new Attendence();
            at.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            DashBoard db=new    DashBoard();
            db.Show();
        }
    }
}
