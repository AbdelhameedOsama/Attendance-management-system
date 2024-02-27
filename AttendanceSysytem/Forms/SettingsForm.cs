﻿using AttendanceSysytem.Classes;
using AttendanceSysytem.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AttendanceSysytem.Forms
{
    public partial class SettingsForm : Form
    {
        public User Recived { get; set; }
        public XmlDocument Document { get; set; }
        public XmlElement User { get; set; }

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            this.Font = DataManagement.MyFont;
            Document = DataManagement.xmlDoc();
            //Console.WriteLine(Recived.Name);
            string type="Student";
            if (Recived.UserID[0]=='T')
            {
                type = "Teacher";
            }else if (Recived.UserID[0]=='A')
            {
                type = "Admin";

            }
            User = DataManagement.GetElementById(Document, Recived.UserID, type);

            XmlNode password = User.SelectSingleNode("Password");
            password_box.Text = password.InnerText;
        }


        private void font_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowDialog();
            
            DataManagement.ChangeFontForAllPages(font.Font);
        }

        private void Langauge_Click(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            XmlNode password = User.SelectSingleNode("Password");
            if (password_box.Text != password.InnerText)
            {
                password.InnerText = password_box.Text;
                DataManagement.SaveXml(Document);
                MessageBox.Show("Password updated successfully");
            }
            else
            {
                MessageBox.Show("Password didn't change");
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
