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
    public partial class AdminHomePagePanel : Form
    {
        public AdminHomePagePanel()
        {
            InitializeComponent();
        }

        private void btnStudentGridView_Click(object sender, EventArgs e)
        {
            panelChidAdminForm.Controls.Clear();
            AllStudentInformationByIDForAdmin asia = new AllStudentInformationByIDForAdmin();
            asia.TopLevel = false;
            panelChidAdminForm.Controls.Add(asia);
            asia.BringToFront();
            asia.Show();

            
        }

        private void bthTeacherGridView_Click(object sender, EventArgs e)
        {
           
            panelChidAdminForm.Controls.Clear();
            AllTeacherInformationByIDForAdmin atia = new AllTeacherInformationByIDForAdmin();
            atia.TopLevel = false;
            panelChidAdminForm.Controls.Add(atia);
            atia.BringToFront();
            atia.Show();
        }

        private void bthAdminGridView_Click(object sender, EventArgs e)
        {
            panelChidAdminForm.Controls.Clear();
            AllAdminInformationByIDForAdmin aaia = new AllAdminInformationByIDForAdmin();
            aaia.TopLevel = false;
            panelChidAdminForm.Controls.Add(aaia);
            aaia.BringToFront();
            aaia.Show();
        }

        private void panelChidAdminForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminHomepagePanel_Load(object sender, EventArgs e)
        {

        }
    }
}
