using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFASchoolManagementSystem.Admin;
using WFASchoolManagementSystem.Teachers;
using WFASchoolManagementSystem.Grid_View;
using WFASchoolManagementSystem.Information;

namespace WFASchoolManagementSystem.Admin
{
    public partial class formAdmin : Form
    {
        public string Username;
        public string password;

        public formAdmin()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void btnAdminLogOut_Click(object sender, EventArgs e)
        {
            try
            {
                formLogin login3 = new formLogin();
                this.Hide();
                login3.Show();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void customizeDesing()
        {
            try
            {
                paneInsert.Visible = false;
                //panelUpdate.Visible = false;
                panel8.Visible = false;
                //panelPassword.Visible = false;
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
            
        }

        private void hideSubMenu()
        {
            try
            {
                if (paneInsert.Visible == true)
                    paneInsert.Visible = false;
                if (panel8.Visible == true)
                    panel8.Visible = false;
              //  if (panelPassword.Visible == true)
              //      panelPassword.Visible = false;
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
            
        }

        private void showSubMenu(Panel subMenu)
        {
            try
            {
                if (subMenu.Visible == false)
                {
                    this.hideSubMenu();
                    subMenu.Visible = true;
                }
                else
                    subMenu.Visible = false;
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
            
        }

        private void btnInsertInfo_Click(object sender, EventArgs e)
        {
            showSubMenu(paneInsert);
        }

        private void StudentInsert_Click(object sender, EventArgs e)
        {

            panelChidAdminForm.Controls.Clear();
            FormStudentInfo sinfo = new FormStudentInfo();
            sinfo.TopLevel = false;
            panelChidAdminForm.Controls.Add(sinfo);
            sinfo.BringToFront();
            sinfo.Show();
            hideSubMenu();

            
        }

        private void TeacherInsert_Click(object sender, EventArgs e)
        {
            panelChidAdminForm.Controls.Clear();
            FormTeacherInfo tinfo = new FormTeacherInfo();
            tinfo.TopLevel = false;
            panelChidAdminForm.Controls.Add(tinfo);
            tinfo.BringToFront();
            tinfo.Show();
            hideSubMenu();
            
        }



        private void btnDeleteInfo_Click(object sender, EventArgs e)
        {
          //  showSubMenu(panelDelete);
        }

        private void btnTeacherDelete_Click(object sender, EventArgs e)
        {
            panelChidAdminForm.Controls.Clear();
            FormTeacherInfo tinfo = new FormTeacherInfo();
            tinfo.TopLevel = false;
            panelChidAdminForm.Controls.Add(tinfo);
            tinfo.BringToFront();
            tinfo.Show();
            hideSubMenu();
            panelChidAdminForm.Controls.Clear();
            FormStudentInfo sinfo = new FormStudentInfo();
            sinfo.TopLevel = false;
            panelChidAdminForm.Controls.Add(sinfo);
            sinfo.BringToFront();
            sinfo.Show();
            hideSubMenu();
        }

        private void btnStudentDelete_Click(object sender, EventArgs e)
        {
            panelChidAdminForm.Controls.Clear();
            FormStudentInfo sinfo = new FormStudentInfo();
            sinfo.TopLevel = false;
            panelChidAdminForm.Controls.Add(sinfo);
            sinfo.BringToFront();
            sinfo.Show();
            hideSubMenu();
        }

        private void bthPassword_Click(object sender, EventArgs e)
        {
            panelChidAdminForm.Controls.Clear();
            UserAccountInsertDeleteUpdate pw = new UserAccountInsertDeleteUpdate();
            pw.TopLevel = false;
            panelChidAdminForm.Controls.Add(pw);
            pw.BringToFront();
            pw.Show();
           // hideSubMenu();
           // hideSubMenu();
        }

        private void bthTeacherPassword_Click(object sender, EventArgs e)
        {
            UserAccountInsertDeleteUpdate pi = new UserAccountInsertDeleteUpdate();
            pi.Show();
            hideSubMenu();
        }

        private void bthStudentPassword_Click(object sender, EventArgs e)
        {
            UserAccountInsertDeleteUpdate pi = new UserAccountInsertDeleteUpdate();
            pi.Show();
            hideSubMenu();
        }

        private void formAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void formAdmin_Load(object sender, EventArgs e)
        {
            UserId.Text = Username;
            UserPassword.Text = password;

            string sql = "select fullname from Admin where userId = '" + this.UserId.Text + "';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);
            //WelcomeMessage.Text += ds.Tables[0].Rows[0][0].ToString();
            button7.Text = ds.Tables[0].Rows[0][0].ToString();

            panelChidAdminForm.Controls.Clear();
            AdminHomePagePanel ahp = new AdminHomePagePanel();
            ahp.TopLevel = false;
            panelChidAdminForm.Controls.Add(ahp);
            ahp.BringToFront();
            ahp.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelChidAdminForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.LightSteelBlue;
            button4.BackColor = Color.LightSteelBlue;
            button5.BackColor = Color.LightSteelBlue;
            button8.BackColor = Color.LightSteelBlue;
            button10.BackColor = Color.LightSteelBlue;
            button18.BackColor = Color.LightSteelBlue;
            button22.BackColor = Color.LightSteelBlue;
            button30.BackColor = Color.LightSteelBlue;
            button31.BackColor = Color.LightSteelBlue;
            panelChidAdminForm.Controls.Clear();
            AdminHomePagePanel ahp = new AdminHomePagePanel();
            ahp.TopLevel = false;
            panelChidAdminForm.Controls.Add(ahp);
            ahp.BringToFront();
            ahp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          //  showSubMenu(panelDelete);
        }

        private void btnTeacherDelete_Click_1(object sender, EventArgs e)
        {
            panelChidAdminForm.Controls.Clear();
            AllStudentInformationDataTableForAdmin asidta = new AllStudentInformationDataTableForAdmin();
            asidta.TopLevel = false;
            panelChidAdminForm.Controls.Add(asidta);
            asidta.BringToFront();
            asidta.Show();
            hideSubMenu();
        }

        private void btnStudentDelete_Click_1(object sender, EventArgs e)
        {
            panelChidAdminForm.Controls.Clear();
            AllTeacherInformationDataTableForAdmin atidta = new AllTeacherInformationDataTableForAdmin();
            atidta.TopLevel = false;
            panelChidAdminForm.Controls.Add(atidta);
            atidta.BringToFront();
            atidta.Show();
            hideSubMenu();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelChidAdminForm.Controls.Clear();
            AllAdminInformationDataTableForAdmin aaidta = new AllAdminInformationDataTableForAdmin();
            aaidta.TopLevel = false;
            panelChidAdminForm.Controls.Add(aaidta);
            aaidta.BringToFront();
            aaidta.Show();
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.SkyBlue;
            button4.BackColor = Color.LightSteelBlue;
            button5.BackColor = Color.LightSteelBlue;
            button8.BackColor = Color.LightSteelBlue;
            button10.BackColor = Color.LightSteelBlue;
            button18.BackColor = Color.LightSteelBlue;
            button22.BackColor = Color.LightSteelBlue;
            button30.BackColor = Color.LightSteelBlue;
            button31.BackColor = Color.LightSteelBlue;

            panelChidAdminForm.Controls.Clear();
            AdminPersonalInformation pia = new AdminPersonalInformation();
            pia.Username = UserId.Text;
            pia.TopLevel = false;
            panelChidAdminForm.Controls.Add(pia);
            pia.BringToFront();
            pia.Show();
        }

        private void WelcomeMessage_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            panelChidAdminForm.Controls.Clear();
            AdminPersonalInformation pia = new AdminPersonalInformation();
            pia.Username = UserId.Text;
            pia.TopLevel = false;
            panelChidAdminForm.Controls.Add(pia);
            pia.BringToFront();
            pia.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.SkyBlue;
            button4.BackColor = Color.LightSteelBlue;
            button5.BackColor = Color.LightSteelBlue;
            button30.BackColor = Color.LightSteelBlue;
            button10.BackColor = Color.LightSteelBlue;
            button3.BackColor = Color.LightSteelBlue;
            button22.BackColor = Color.LightSteelBlue;
            button18.BackColor = Color.LightSteelBlue;
            button31.BackColor = Color.LightSteelBlue;
            panelChidAdminForm.Controls.Clear();
            CourseInsertDeleteUpdate cidu = new CourseInsertDeleteUpdate();
            cidu.TopLevel = false;
            panelChidAdminForm.Controls.Add(cidu);
            cidu.BringToFront();
            cidu.Show();
        }



        private void button18_Click(object sender, EventArgs e)
        {
            showSubMenu(panel8);
        }

        private void btnInsertInfo_Click_1(object sender, EventArgs e)
        {
            showSubMenu(paneInsert);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button18.BackColor = Color.SkyBlue;
            button4.BackColor = Color.LightSteelBlue;
            button5.BackColor = Color.LightSteelBlue;
            button8.BackColor = Color.LightSteelBlue;
            button10.BackColor = Color.LightSteelBlue;
            button3.BackColor = Color.LightSteelBlue;
            button22.BackColor = Color.LightSteelBlue;
            button30.BackColor = Color.LightSteelBlue;
            button31.BackColor = Color.LightSteelBlue;
            panelChidAdminForm.Controls.Clear();
            AllStudentInformationDataTableForAdmin asidta = new AllStudentInformationDataTableForAdmin();
            asidta.TopLevel = false;
            panelChidAdminForm.Controls.Add(asidta);
            asidta.BringToFront();
            asidta.Show();
            hideSubMenu();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button18.BackColor = Color.SkyBlue;
            button4.BackColor = Color.LightSteelBlue;
            button5.BackColor = Color.LightSteelBlue;
            button8.BackColor = Color.LightSteelBlue;
            button10.BackColor = Color.LightSteelBlue;
            button3.BackColor = Color.LightSteelBlue;
            button22.BackColor = Color.LightSteelBlue;
            button30.BackColor = Color.LightSteelBlue;
            button31.BackColor = Color.LightSteelBlue;
            panelChidAdminForm.Controls.Clear();
            AllTeacherInformationDataTableForAdmin atidta = new AllTeacherInformationDataTableForAdmin();
            atidta.TopLevel = false;
            panelChidAdminForm.Controls.Add(atidta);
            atidta.BringToFront();
            atidta.Show();
            hideSubMenu();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button18.BackColor = Color.SkyBlue;
            button4.BackColor = Color.LightSteelBlue;
            button5.BackColor = Color.LightSteelBlue;
            button8.BackColor = Color.LightSteelBlue;
            button10.BackColor = Color.LightSteelBlue;
            button3.BackColor = Color.LightSteelBlue;
            button22.BackColor = Color.LightSteelBlue;
            button30.BackColor = Color.LightSteelBlue;
            button31.BackColor = Color.LightSteelBlue;
            panelChidAdminForm.Controls.Clear();
            AllAdminInformationDataTableForAdmin aaidta = new AllAdminInformationDataTableForAdmin();
            aaidta.TopLevel = false;
            panelChidAdminForm.Controls.Add(aaidta);
            aaidta.BringToFront();
            aaidta.Show();
            hideSubMenu();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.BackColor = Color.SkyBlue;
            button4.BackColor = Color.LightSteelBlue;
            button5.BackColor = Color.LightSteelBlue;
            button8.BackColor = Color.LightSteelBlue;
            button10.BackColor = Color.LightSteelBlue;
            button3.BackColor = Color.LightSteelBlue;
            button18.BackColor = Color.LightSteelBlue;
            button30.BackColor = Color.LightSteelBlue;
            button31.BackColor = Color.LightSteelBlue;
            panelChidAdminForm.Controls.Clear();
            StudentGradeReportByClassAndYear sgrcy = new StudentGradeReportByClassAndYear();
            sgrcy.TopLevel = false;
            panelChidAdminForm.Controls.Add(sgrcy);
            sgrcy.BringToFront();
            sgrcy.Show();
        }

        private void btnTeacherInsert_Click(object sender, EventArgs e)
        {
            button30.BackColor = Color.SkyBlue;
            button4.BackColor = Color.LightSteelBlue;
            button5.BackColor = Color.LightSteelBlue;
            button8.BackColor = Color.LightSteelBlue;
            button10.BackColor = Color.LightSteelBlue;
            button3.BackColor = Color.LightSteelBlue;
            button22.BackColor = Color.LightSteelBlue;
            button18.BackColor = Color.LightSteelBlue;
            button31.BackColor = Color.LightSteelBlue;
            panelChidAdminForm.Controls.Clear();
            FormStudentInfo sinfo = new FormStudentInfo();
            sinfo.TopLevel = false;
            panelChidAdminForm.Controls.Add(sinfo);
            sinfo.BringToFront();
            sinfo.Show();
            hideSubMenu();
        }

        private void btnStudentInsert_Click(object sender, EventArgs e)
        {
            button30.BackColor = Color.SkyBlue;
            button4.BackColor = Color.LightSteelBlue;
            button5.BackColor = Color.LightSteelBlue;
            button8.BackColor = Color.LightSteelBlue;
            button10.BackColor = Color.LightSteelBlue;
            button3.BackColor = Color.LightSteelBlue;
            button22.BackColor = Color.LightSteelBlue;
            button18.BackColor = Color.LightSteelBlue;
            button31.BackColor = Color.LightSteelBlue;
            panelChidAdminForm.Controls.Clear();
            FormTeacherInfo tinfo = new FormTeacherInfo();
            tinfo.TopLevel = false;
            panelChidAdminForm.Controls.Add(tinfo);
            tinfo.BringToFront();
            tinfo.Show();
            hideSubMenu();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button30.BackColor = Color.SkyBlue;
            button4.BackColor = Color.LightSteelBlue;
            button5.BackColor = Color.LightSteelBlue;
            button8.BackColor = Color.LightSteelBlue;
            button10.BackColor = Color.LightSteelBlue;
            button3.BackColor = Color.LightSteelBlue;
            button22.BackColor = Color.LightSteelBlue;
            button18.BackColor = Color.LightSteelBlue;
            button31.BackColor = Color.LightSteelBlue;
            panelChidAdminForm.Controls.Clear();
            AdminInformationInsertDeleteUpdate aiidu = new AdminInformationInsertDeleteUpdate();
            aiidu.TopLevel = false;
            panelChidAdminForm.Controls.Add(aiidu);
            aiidu.BringToFront();
            aiidu.Show();
            hideSubMenu();
        }

        private void bthPassword_Click_1(object sender, EventArgs e)
        {
            button31.BackColor = Color.SkyBlue;
            button4.BackColor = Color.LightSteelBlue;
            button5.BackColor = Color.LightSteelBlue;
            button8.BackColor = Color.LightSteelBlue;
            button10.BackColor = Color.LightSteelBlue;
            button3.BackColor = Color.LightSteelBlue;
            button22.BackColor = Color.LightSteelBlue;
            button18.BackColor = Color.LightSteelBlue;
            button30.BackColor = Color.LightSteelBlue;
            panelChidAdminForm.Controls.Clear();
            UserAccountInsertDeleteUpdate pw = new UserAccountInsertDeleteUpdate();
            pw.TopLevel = false;
            panelChidAdminForm.Controls.Add(pw);
            pw.BringToFront();
            pw.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            button4.BackColor = Color.SkyBlue;
            button30.BackColor = Color.LightSteelBlue;
            button5.BackColor = Color.LightSteelBlue;
            button8.BackColor = Color.LightSteelBlue;
            button10.BackColor = Color.LightSteelBlue;
            button3.BackColor = Color.LightSteelBlue;
            button22.BackColor = Color.LightSteelBlue;
            button18.BackColor = Color.LightSteelBlue;
            button31.BackColor = Color.LightSteelBlue;
            panelChidAdminForm.Controls.Clear();
            StudentEntryInTheCourse seitc = new StudentEntryInTheCourse();
            seitc.TopLevel = false;
            panelChidAdminForm.Controls.Add(seitc);
            seitc.BringToFront();
            seitc.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            button5.BackColor = Color.SkyBlue;
            button4.BackColor = Color.LightSteelBlue;
            button30.BackColor = Color.LightSteelBlue;
            button8.BackColor = Color.LightSteelBlue;
            button10.BackColor = Color.LightSteelBlue;
            button3.BackColor = Color.LightSteelBlue;
            button22.BackColor = Color.LightSteelBlue;
            button18.BackColor = Color.LightSteelBlue;
            button31.BackColor = Color.LightSteelBlue;
            panelChidAdminForm.Controls.Clear();
            StudentEntryInTheResultSheet seitrs = new StudentEntryInTheResultSheet();
            seitrs.TopLevel = false;
            panelChidAdminForm.Controls.Add(seitrs);
            seitrs.BringToFront();
            seitrs.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.SkyBlue;
            button4.BackColor = Color.LightSteelBlue;
            button5.BackColor = Color.LightSteelBlue;
            button8.BackColor = Color.LightSteelBlue;
            button30.BackColor = Color.LightSteelBlue;
            button3.BackColor = Color.LightSteelBlue;
            button22.BackColor = Color.LightSteelBlue;
            button18.BackColor = Color.LightSteelBlue;
            button31.BackColor = Color.LightSteelBlue;
            panelChidAdminForm.Controls.Clear();
            AdminPasswordChange apc = new AdminPasswordChange();
            apc.Username = UserId.Text;
            apc.TopLevel = false;
            panelChidAdminForm.Controls.Add(apc);
            apc.BringToFront();
            apc.Show();
        }
    }
}
