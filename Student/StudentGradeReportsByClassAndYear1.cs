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

namespace WFASchoolManagementSystem.Student
{
    public partial class previousresultbyclassandyear1 : Form
    {
        public string Username;
        public string year1;
        public string class1;
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }
        public previousresultbyclassandyear1()
        {
            InitializeComponent();
            this.da = new DataAccess();
        }
        private void PopulateGridView(string sql)
        {
            this.ds = this.da.ExecuteQuery(sql);
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = this.ds.Tables[0];
        }

        private void previousresultbyclassandyear1_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime dt2 = DateTime.Now;
                label1.Text = (dt2.ToString("yyyy"));
                textBox1.Text = class1;
                textBox2.Text = year1;
                label10.Text = year1;
                label11.Text = class1;
                label13.Text = Username;
                textBox3.Text = Username;
                label2.Text = "0";
                counter.Text = "0";
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    label2.Text = Convert.ToString(double.Parse(label2.Text) + double.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()));
                    if(dataGridView1.Rows[i].Cells[2].Value.ToString() == "0")
                    {
                        counter.Text += "1";
                    }  
                }
                label3.Text = ds.Tables[0].Rows.Count.ToString();
                double firstnumber = Convert.ToDouble(label2.Text);
                double secondnumber = Convert.ToDouble(label3.Text);
                if(counter.Text == "0") 
                {
                    double result = firstnumber / secondnumber;
                    label4.Text = Math.Round(result, 2, MidpointRounding.ToEven).ToString();
                }
                else
                {
                    label4.Text = "Fail";
                }
                //double result = firstnumber / secondnumber;
               // label4.Text = Math.Round(result, 2, MidpointRounding.ToEven).ToString();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select Course.courseId,Course.coursename,result.result,Course.section,Teacher.fullname from Course inner join studentenrollment on Course.courseId = studentenrollment.courseId inner join result on result.studentenrollmentId = studentenrollment.studentenrollmentId inner join Teacher on Course.teacherId = Teacher.userId where studentenrollment.studentId = '" + this.textBox3.Text + "' and Course.year = '" + this.textBox2.Text + "' and Course.classdescrip = '" + this.textBox1.Text + "';";
                this.PopulateGridView(sql);
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void counter_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
