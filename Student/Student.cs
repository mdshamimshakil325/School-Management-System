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

namespace WFASchoolManagementSystem
{
    public partial class formStudent : Form
    {
        public string Username;
        public string password;
        public double resultall;
        public formStudent()
        {
            InitializeComponent();  
        }

        private void btnStudentLogOut_Click(object sender, EventArgs e)
        {
            formLogin login1 = new formLogin();
            this.Hide();
            login1.Show();
        }

        private void btnPersonalInfo_Click(object sender, EventArgs e)
        {
            btnPersonalInfo.BackColor = Color.SkyBlue;
            button2.BackColor = Color.LightSteelBlue;
            button4.BackColor = Color.LightSteelBlue;
            button5.BackColor = Color.LightSteelBlue;

            panel4.Controls.Clear();
            formStudentInindividualInfo si = new formStudentInindividualInfo();
            si.Username = UserId.Text;
            si.password = UserPassword.Text;
            si.TopLevel = false;
            panel4.Controls.Add(si);
            si.BringToFront();
            si.Show();
        }

        private void formStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public formStudent(string Username) : this()
        {
            this.lblWelcome.Text += Username;
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //string sql = "select name from AllUser where userId = '" + this.textBoxUserId.Text + "' and password = '" + this.textBoxPassword.Text + "';";

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void formStudent_Load(object sender, EventArgs e)
        {
            UserId.Text = Username;
            UserPassword.Text = password;

            string sql = "select fullname from Student where userId = '" + this.UserId.Text + "'";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);
            //WelcomeMessage.Text += ds.Tables[0].Rows[0][0].ToString();
            button1.Text = ds.Tables[0].Rows[0][0].ToString();

            panel4.Controls.Clear();
            studentcoursedetails sd1 = new studentcoursedetails();
            sd1.Username = Username;
            sd1.TopLevel = false;
            panel4.Controls.Add(sd1);
            sd1.BringToFront();
            sd1.Show();

        }

        private void UserId_Click(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //panel4.Controls.Clear();
        //    //studentcoursedetails sd1 = new studentcoursedetails();
        //    //sd1.Username = Username;
        //    //sd1.TopLevel = false;
        //    //panel4.Controls.Add(sd1);
        //    //sd1.BringToFront();
        //    //sd1.Show();
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            btnPersonalInfo.BackColor = Color.LightSteelBlue;
            button2.BackColor = Color.SkyBlue;
            button4.BackColor = Color.LightSteelBlue;
            button5.BackColor = Color.LightSteelBlue;

            panel4.Controls.Clear();
            courseresult sd1 = new courseresult();
            sd1.Username = Username;
            sd1.TopLevel = false;
            panel4.Controls.Add(sd1);
            sd1.BringToFront();
            sd1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnPersonalInfo.BackColor = Color.LightSteelBlue;
            button2.BackColor = Color.LightSteelBlue;
            button4.BackColor = Color.LightSteelBlue;
            button5.BackColor = Color.LightSteelBlue;
            panel4.Controls.Clear();
            studentcoursedetails sd1 = new studentcoursedetails();
            sd1.Username = Username;
            sd1.TopLevel = false;
            panel4.Controls.Add(sd1);
            sd1.BringToFront();
            sd1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnPersonalInfo.BackColor = Color.LightSteelBlue;
            button2.BackColor = Color.LightSteelBlue;
            button4.BackColor = Color.SkyBlue;
            button5.BackColor = Color.LightSteelBlue;

            panel4.Controls.Clear();
            previousresultbyclassandyear ps1 = new previousresultbyclassandyear();
            ps1.Username = Username;
            ps1.TopLevel = false;
            panel4.Controls.Add(ps1);
            ps1.BringToFront();
            ps1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btnPersonalInfo.BackColor = Color.LightSteelBlue;
            button2.BackColor = Color.LightSteelBlue;
            button4.BackColor = Color.LightSteelBlue;
            button5.BackColor = Color.SkyBlue;

            panel4.Controls.Clear();
            passwordchangepagestudent ps1 = new passwordchangepagestudent();
            ps1.Username = Username;
            ps1.password = password;
            ps1.TopLevel = false;
            panel4.Controls.Add(ps1);
            ps1.BringToFront();
            ps1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            formStudentInindividualInfo si = new formStudentInindividualInfo();
            si.Username = UserId.Text;
            si.password = UserPassword.Text;
            si.TopLevel = false;
            panel4.Controls.Add(si);
            si.BringToFront();
            si.Show();
        }
    }
}
