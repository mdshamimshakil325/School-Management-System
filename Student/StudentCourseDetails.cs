using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFASchoolManagementSystem.Student;
using WFASchoolManagementSystem.Information;


namespace WFASchoolManagementSystem.Student
{
    public partial class studentcoursedetails : Form
    {
        public string Username;
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }
        public studentcoursedetails()
        {
            InitializeComponent();
            this.da = new DataAccess();

          //  string sql = "select * from studentenrollment"; 
          //  this.PopulateGridView(sql);
        }
        private void PopulateGridView(string sql)
        {
            this.ds = this.da.ExecuteQuery(sql);
            this.dgvAdmin.AutoGenerateColumns = false;
            this.dgvAdmin.DataSource = this.ds.Tables[0];
        }

        private void studentcoursedetails_Load(object sender, EventArgs e)
        {
            DateTime dt1 = DateTime.Now;
            label39.Text = (dt1.ToString("yyyy"));
            label1.Text = Username;
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select Course.courseId,Course.coursename,Course.section,Teacher.fullname  from Course inner join studentenrollment on Course.courseId = studentenrollment.courseId inner join Teacher on Teacher.userId = Course.teacherId  where studentenrollment.studentId = '" + this.label1.Text + "' and Course.year = '" + this.label39.Text + "'";
                this.PopulateGridView(sql);
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }
    }
}
