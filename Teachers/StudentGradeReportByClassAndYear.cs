using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFASchoolManagementSystem.Teachers
{
    public partial class StudentGradeReportByClassAndYear : Form
    {
        public StudentGradeReportByClassAndYear()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StudentGradeReportByClassAndYear_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select Course.courseId,Course.coursename,result.result,Course.section,Teacher.fullname from Course inner join studentenrollment on Course.courseId = studentenrollment.courseId inner join result on result.studentenrollmentId = studentenrollment.studentenrollmentId inner join Teacher on Course.teacherId = Teacher.userId where studentenrollment.studentId = '" + this.textBox1.Text + "' and Course.year = '" + this.textBox3.Text + "' and Course.classdescrip = '" + this.textBox2.Text + "';";
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count >= 1)
                {
                    panel2.Controls.Clear();
                    StudentGradeReportByClassAndYear1 ps1 = new StudentGradeReportByClassAndYear1();
                    
                    ps1.Username = textBox1.Text;
                    ps1.year1 = textBox3.Text;
                    ps1.class1 = textBox2.Text;
                    ps1.TopLevel = false;
                    panel2.Controls.Add(ps1);
                    ps1.BringToFront();
                    ps1.Show();
                    textBox3.Text = "";
                    textBox2.Text = "";
                    textBox1.Text = "";
                    label4.Text = "";
                }
                else
                {
                    label4.Text = "Not Match Data.";
                    textBox3.Text = "";
                    textBox2.Text = "";
                    textBox1.Text = "";
                    panel2.Controls.Clear();
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }
    }
}
