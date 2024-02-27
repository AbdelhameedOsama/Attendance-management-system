﻿using AttendanceSysytem.Classes;
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

namespace AttendanceSysytem.UserControls
{
    public partial class Settings : UserControl
    {
        public User Recived { get; set; }
        public XmlDocument Document { get; set; }
        public XmlElement User { get; set; }
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Font = DataManagement.MyFont;
            Document = DataManagement.xmlDoc();
            User = DataManagement.GetElementById(Document, Recived.UserID, "Admin");

            XmlNode password = User.SelectSingleNode("Password");
            password_box.Text = password.InnerText;
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

        private void font_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.ShowDialog();

            DataManagement.ChangeFontForAllPages(font.Font);
        }
    }
}
