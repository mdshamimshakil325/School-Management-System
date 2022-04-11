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
using WFASchoolManagementSystem.Teachers;
using WFASchoolManagementSystem.Information;
using WFASchoolManagementSystem.Admin;

namespace WFASchoolManagementSystem.Teachers
{
    public partial class formTeacher : Form
    {
        public string Username;
        public string password;


        public formTeacher()
        {
            InitializeComponent();
            customizeDesing();
        }



        private void customizeDesing()
        {
           // panelStudentResult.Visible = false;
        }

        private void hideSubMenu()
        {
         //   if (panelStudentResult.Visible == true)
           //     panelStudentResult.Visible = false;
 
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                this.hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


        private void bthShowAllResult_Click(object sender, EventArgs e)
        {
            Resultinfo ri = new Resultinfo();
            ri.Show();
            hideSubMenu();
        }

        private void bthInsertResult_Click(object sender, EventArgs e)
        {
            Resultinfo ri = new Resultinfo();
            ri.Show();
            hideSubMenu();
        }

        private void btnUpdateResult_Click(object sender, EventArgs e)
        {
            Resultinfo ri = new Resultinfo();
            ri.Show();
            hideSubMenu();
        }



        private void formTeachers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        private void formTeacher_Load(object sender, EventArgs e)
        {
            UserId.Text = Username;
            UserPassword.Text = password;

            string sql = "select fullname from Teacher where userId = '" + this.UserId.Text + "'";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);
            // WelcomeMessage1.Text += ds.Tables[0].Rows[0][0].ToString();
            button7.Text = ds.Tables[0].Rows[0][0].ToString();

           
            //AllStudentInformationByIDForAdmin asibifa = new AllStudentInformationByIDForAdmin();
            //asibifa.TopLevel = false;
            //panel4.Controls.Add(asibifa);
            //asibifa.BringToFront();
            //asibifa.Show();

            try
            {
                panel4.Controls.Clear();
                TeacherCourseDetails cd1 = new TeacherCourseDetails();
                cd1.Username = Username;
                cd1.TopLevel = false;
                panel4.Controls.Add(cd1);
                cd1.BringToFront();
                cd1.Show();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserId_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //button1.BackColor = Color.LightSteelBlue;
                button2.BackColor = Color.SkyBlue;
                button3.BackColor = Color.LightSteelBlue;
                button4.BackColor = Color.LightSteelBlue;
                button5.BackColor = Color.LightSteelBlue;
                button8.BackColor = Color.LightSteelBlue;
                panel4.Controls.Clear();
                formTeacherInindividualInfo ti = new formTeacherInindividualInfo();
                ti.Username = UserId.Text;
                ti.password = UserPassword.Text;
                ti.TopLevel = false;
                panel4.Controls.Add(ti);
                ti.BringToFront();
                ti.Show();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }



        private void button1_Click_2(object sender, EventArgs e)
        {
           // button1.BackColor = Color.SkyBlue;
            button2.BackColor = Color.LightSteelBlue;
            button3.BackColor = Color.LightSteelBlue;
            button4.BackColor = Color.LightSteelBlue;
            button5.BackColor = Color.LightSteelBlue;
            button8.BackColor = Color.LightSteelBlue;
            panel4.Controls.Clear();
            TeacherCourseDetails cd1 = new TeacherCourseDetails();
            cd1.Username = Username;
            cd1.TopLevel = false;
            panel4.Controls.Add(cd1);
            cd1.BringToFront();
            cd1.Show();
        }

        private void btnStudentLogOut_Click(object sender, EventArgs e)
        {
            formLogin login2 = new formLogin();
            this.Hide();
            login2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          //  button1.BackColor = Color.LightSteelBlue;
            button2.BackColor = Color.LightSteelBlue;
            button3.BackColor = Color.SkyBlue;
            button4.BackColor = Color.LightSteelBlue;
            button5.BackColor = Color.LightSteelBlue;
            button8.BackColor = Color.LightSteelBlue;
            panel4.Controls.Clear();
            TeacherPasswordChange ps1 = new TeacherPasswordChange();
            ps1.Username = Username;
            ps1.password = password;
            ps1.TopLevel = false;
            panel4.Controls.Add(ps1);
            ps1.BringToFront();
            ps1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           // button1.BackColor = Color.LightSteelBlue;
            button2.BackColor = Color.LightSteelBlue;
            button3.BackColor = Color.LightSteelBlue;
            button4.BackColor = Color.SkyBlue;
            button5.BackColor = Color.LightSteelBlue;
            button8.BackColor = Color.LightSteelBlue;
            panel4.Controls.Clear();
            AllStudentInformationByIDForAdmin aaibifa = new AllStudentInformationByIDForAdmin();
            aaibifa.TopLevel = false;
            panel4.Controls.Add(aaibifa);
            aaibifa.BringToFront();
            aaibifa.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          //  button1.BackColor = Color.LightSteelBlue;
            button2.BackColor = Color.LightSteelBlue;
            button3.BackColor = Color.LightSteelBlue;
            button4.BackColor = Color.LightSteelBlue;
            button5.BackColor = Color.SkyBlue;
            button8.BackColor = Color.LightSteelBlue;
            panel4.Controls.Clear();
            Resultinfo ri1 = new Resultinfo();
            ri1.Username = Username;
            ri1.TopLevel = false;
            panel4.Controls.Add(ri1);
            ri1.BringToFront();
            ri1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                panel4.Controls.Clear();
                TeacherCourseDetails cd1 = new TeacherCourseDetails();
                cd1.Username = Username;
                cd1.TopLevel = false;
                panel4.Controls.Add(cd1);
                cd1.BringToFront();
                cd1.Show();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void WelcomeMessage1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            formTeacherInindividualInfo ti = new formTeacherInindividualInfo();
            ti.Username = UserId.Text;
            ti.password = UserPassword.Text;
            ti.TopLevel = false;
            panel4.Controls.Add(ti);
            ti.BringToFront();
            ti.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //button1.BackColor = Color.LightSteelBlue;
            button2.BackColor = Color.LightSteelBlue;
            button3.BackColor = Color.LightSteelBlue;
            button4.BackColor = Color.LightSteelBlue;
            button5.BackColor = Color.LightSteelBlue;
            button8.BackColor = Color.SkyBlue;
            panel4.Controls.Clear();
            StudentGradeReportByClassAndYear ps1 = new StudentGradeReportByClassAndYear();
            ps1.TopLevel = false;
            panel4.Controls.Add(ps1);
            ps1.BringToFront();
            ps1.Show();
        }
    }
}
