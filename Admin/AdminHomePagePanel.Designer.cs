
namespace WFASchoolManagementSystem.Admin
{
    partial class AdminHomePagePanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelChidAdminForm = new System.Windows.Forms.Panel();
            this.bthAdminGridView = new System.Windows.Forms.Button();
            this.bthTeacherGridView = new System.Windows.Forms.Button();
            this.btnStudentGridView = new System.Windows.Forms.Button();
            this.panelChidAdminForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChidAdminForm
            // 
            this.panelChidAdminForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChidAdminForm.AutoScroll = true;
            this.panelChidAdminForm.AutoSize = true;
            this.panelChidAdminForm.BackColor = System.Drawing.Color.SkyBlue;
            this.panelChidAdminForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChidAdminForm.Controls.Add(this.bthAdminGridView);
            this.panelChidAdminForm.Controls.Add(this.bthTeacherGridView);
            this.panelChidAdminForm.Controls.Add(this.btnStudentGridView);
            this.panelChidAdminForm.Location = new System.Drawing.Point(-3, -4);
            this.panelChidAdminForm.Margin = new System.Windows.Forms.Padding(2);
            this.panelChidAdminForm.Name = "panelChidAdminForm";
            this.panelChidAdminForm.Size = new System.Drawing.Size(1272, 684);
            this.panelChidAdminForm.TabIndex = 8;
            this.panelChidAdminForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChidAdminForm_Paint);
            // 
            // bthAdminGridView
            // 
            this.bthAdminGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bthAdminGridView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bthAdminGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthAdminGridView.Image = global::WFASchoolManagementSystem.Properties.Resources.pngegg__4_;
            this.bthAdminGridView.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bthAdminGridView.Location = new System.Drawing.Point(777, 130);
            this.bthAdminGridView.Margin = new System.Windows.Forms.Padding(2);
            this.bthAdminGridView.Name = "bthAdminGridView";
            this.bthAdminGridView.Size = new System.Drawing.Size(184, 262);
            this.bthAdminGridView.TabIndex = 2;
            this.bthAdminGridView.Text = "ADMIN \r\nINFORMATION";
            this.bthAdminGridView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bthAdminGridView.UseVisualStyleBackColor = false;
            this.bthAdminGridView.Click += new System.EventHandler(this.bthAdminGridView_Click);
            // 
            // bthTeacherGridView
            // 
            this.bthTeacherGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bthTeacherGridView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bthTeacherGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthTeacherGridView.Image = global::WFASchoolManagementSystem.Properties.Resources.pngegg__3_;
            this.bthTeacherGridView.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bthTeacherGridView.Location = new System.Drawing.Point(537, 130);
            this.bthTeacherGridView.Margin = new System.Windows.Forms.Padding(2);
            this.bthTeacherGridView.Name = "bthTeacherGridView";
            this.bthTeacherGridView.Size = new System.Drawing.Size(184, 262);
            this.bthTeacherGridView.TabIndex = 1;
            this.bthTeacherGridView.Text = "TEACHER INFORMATION";
            this.bthTeacherGridView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bthTeacherGridView.UseVisualStyleBackColor = false;
            this.bthTeacherGridView.Click += new System.EventHandler(this.bthTeacherGridView_Click);
            // 
            // btnStudentGridView
            // 
            this.btnStudentGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStudentGridView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStudentGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentGridView.Image = global::WFASchoolManagementSystem.Properties.Resources.pngwing_com__3_;
            this.btnStudentGridView.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStudentGridView.Location = new System.Drawing.Point(299, 130);
            this.btnStudentGridView.Margin = new System.Windows.Forms.Padding(2);
            this.btnStudentGridView.Name = "btnStudentGridView";
            this.btnStudentGridView.Size = new System.Drawing.Size(184, 262);
            this.btnStudentGridView.TabIndex = 0;
            this.btnStudentGridView.Text = "STUDENT INFORMATION";
            this.btnStudentGridView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStudentGridView.UseVisualStyleBackColor = false;
            this.btnStudentGridView.Click += new System.EventHandler(this.btnStudentGridView_Click);
            // 
            // AdminHomePagePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 677);
            this.Controls.Add(this.panelChidAdminForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminHomePagePanel";
            this.Text = "AdminHomepagePanel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminHomepagePanel_Load);
            this.panelChidAdminForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelChidAdminForm;
        private System.Windows.Forms.Button bthAdminGridView;
        private System.Windows.Forms.Button bthTeacherGridView;
        private System.Windows.Forms.Button btnStudentGridView;
    }
}