﻿namespace AttendanceSysytem
{
    partial class teacherFunctionalitiesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacherFunctionalitiesForm));
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnViewAttendance = new System.Windows.Forms.Button();
            this.btnTakeAttendance = new System.Windows.Forms.Button();
            this.settings = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnSignOut, "btnSignOut");
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnViewAttendance
            // 
            this.btnViewAttendance.BackColor = System.Drawing.Color.White;
            this.btnViewAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnViewAttendance, "btnViewAttendance");
            this.btnViewAttendance.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnViewAttendance.Name = "btnViewAttendance";
            this.btnViewAttendance.UseVisualStyleBackColor = false;
            this.btnViewAttendance.Click += new System.EventHandler(this.btnViewAttendance_Click);
            // 
            // btnTakeAttendance
            // 
            this.btnTakeAttendance.BackColor = System.Drawing.Color.White;
            this.btnTakeAttendance.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnTakeAttendance, "btnTakeAttendance");
            this.btnTakeAttendance.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnTakeAttendance.Name = "btnTakeAttendance";
            this.btnTakeAttendance.UseVisualStyleBackColor = false;
            this.btnTakeAttendance.Click += new System.EventHandler(this.btnTakeAttendance_Click);
            // 
            // settings
            // 
            resources.ApplyResources(this.settings, "settings");
            this.settings.BackColor = System.Drawing.Color.White;
            this.settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings.ForeColor = System.Drawing.Color.OrangeRed;
            this.settings.Name = "settings";
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::AttendanceSysytem.Properties.Resources.background;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // teacherFunctionalitiesForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.settings);
            this.Controls.Add(this.btnTakeAttendance);
            this.Controls.Add(this.btnViewAttendance);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.pictureBox1);
            this.Name = "teacherFunctionalitiesForm";
            this.Load += new System.EventHandler(this.teacherFunctionalitiesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnViewAttendance;
        private System.Windows.Forms.Button btnTakeAttendance;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}