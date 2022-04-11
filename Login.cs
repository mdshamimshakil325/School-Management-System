using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFASchoolManagementSystem.Teachers;
using WFASchoolManagementSystem.Student;
using WFASchoolManagementSystem.Admin;
using WFASchoolManagementSystem.Information;
using WFASchoolManagementSystem.Grid_View;

namespace WFASchoolManagementSystem
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select type from AllUser where userId = '" + this.textBoxUserId.Text + "' and password = '" + this.textBoxPassword.Text + "';";
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);
             

                if (ds.Tables[0].Rows.Count == 1)
                {
                    if (ds.Tables[0].Rows[0][0].ToString() == "student")
                    {
                        formStudent s = new formStudent();
                        this.Hide();
                        s.Username = textBoxUserId.Text;
                        s.password = textBoxPassword.Text;
                        s.Show();
                        
                    }
                    else if (ds.Tables[0].Rows[0][0].ToString() == "teacher")
                    {
                        formTeacher t = new formTeacher();
                        this.Hide();
                        t.Username = textBoxUserId.Text;
                        t.password = textBoxPassword.Text;
                        t.Show();
                    }
                    else if (ds.Tables[0].Rows[0][0].ToString() == "admin")
                    {
                        formAdmin a = new formAdmin();
                        this.Hide();
                        a.Username = textBoxUserId.Text;
                        a.password = textBoxPassword.Text;
                        a.Show();
                        FormStudentInfo FS = new FormStudentInfo();
                        FS.Username = textBoxUserId.Text;
                        FS.password = textBoxPassword.Text;
                    }
                    else
                    {
                        label3.Text = "User Not Created.";
                    }
                }
                else
                {
                    label3.Text = "Invalid Username or Password.";
                    label4.Text = "";
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            label4.Text = "Please Contact With Your Administrator.";
        }
        private void testBoxUserId_Enter(object sender, EventArgs e)
        {
            if (textBoxUserId.Text == "USER ID" )
            {
                textBoxUserId.Text = "";

                textBoxUserId.ForeColor = Color.CornflowerBlue;

               
            }
        }

        private void textBoxUserId_Leave(object sender, EventArgs e)
        {
            if (textBoxUserId.Text == "")
            {
                textBoxUserId.Text = "USER ID"; 

                textBoxUserId.ForeColor = Color.LightGray;
            }
        }

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "PASSWORD")
            {
                textBoxPassword.Text = "";

                textBoxPassword.ForeColor = Color.CornflowerBlue;
                textBoxPassword.UseSystemPasswordChar = true;
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = "PASSWORD";

                textBoxPassword.ForeColor = Color.LightGray;

                textBoxPassword.UseSystemPasswordChar = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
