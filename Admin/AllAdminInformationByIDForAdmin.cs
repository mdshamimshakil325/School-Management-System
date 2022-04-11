using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFASchoolManagementSystem.Admin
{
    public partial class AllAdminInformationByIDForAdmin : Form
    {
        private DataAccess da { get; set; }
        private DataSet ds { get; set; }
        public AllAdminInformationByIDForAdmin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AllAdminInformationByIDForAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select userId from AllUser where userId = '" + this.txtSearch.Text + "';";
                DataAccess da = new DataAccess();
                DataSet ds = da.ExecuteQuery(sql);


                if (ds.Tables[0].Rows.Count == 1)
                {
                    label4.Text = "";
                    AdminPersonalInformation pia = new AdminPersonalInformation();
                    pia.Username = txtSearch.Text;
                    txtSearch.Text = "";
                    pia.TopLevel = false;
                    panel1.Controls.Add(pia);
                    pia.BringToFront();
                    pia.Show();
                }
                else
                {
                    panel1.Controls.Clear();
                    label4.Text = "Invalid Admin ID.";
                }
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }
    }
}
