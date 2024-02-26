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

namespace AttendanceSysytem.Forms
{
    public partial class TakeAttendanceForm : Form
    {
        public TakeAttendanceForm()
        {
            InitializeComponent();
        }


        
        private void TakeAttendanceForm_Load(object sender, EventArgs e)
        {
            //'select track' is displayed by default
            ClassComboBox.Text = "Select Class";

            dataGridViewTakeAttendance.AllowUserToAddRows = false;
            

        }

        private void ClassComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //clear the datagridview
            dataGridViewTakeAttendance.Columns.Clear();

            //display the students of the selected class from the combobox in the datagridview
            try
            {
                XmlDataDocument xmlData = new XmlDataDocument();
                string xmlPath = DataManagement.xmlPath();
                xmlData.DataSet.ReadXml(xmlPath);

                //filtering the students of the selected class according to the class name
                DataView dv = new DataView(xmlData.DataSet.Tables["Student"]);
                dv.RowFilter = "ClassName = '" + ClassComboBox.Text + "'";

                //display the name of the user id and the name of the students in the datagridview
                DataTable dc = dv.ToTable(true, "UserID", "Name");
                dataGridViewTakeAttendance.DataSource = dc;

                // add a checkbox column to the datagridview
                DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
                checkColumn.Name = "AttendanceStatusCheckBox";
                checkColumn.HeaderText = "Status";
                checkColumn.Width = 100;
                checkColumn.ReadOnly = false;


                //add event on checkbox cell click
                


                /*checkColumn.TrueValue = true;
                checkColumn.FalseValue = false;

                //print the state of the checkbox
                Console.WriteLine(checkColumn.TrueValue);
                Console.WriteLine(checkColumn.FalseValue);*/


                dataGridViewTakeAttendance.Columns.Add(checkColumn);

                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!! please try again later");
            }


        }

        private void dataGridViewTakeAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //change the state of the checkbox when clicked
            //change the apperance of the checkbox when clicked
            if (e.ColumnIndex == 2)
            {
                if (dataGridViewTakeAttendance.Rows[e.RowIndex].Cells[2].Value == null)
                {
                    dataGridViewTakeAttendance.Rows[e.RowIndex].Cells[2].Value = true;
                }
                else
                {
                    if ((bool)dataGridViewTakeAttendance.Rows[e.RowIndex].Cells[2].Value == true)
                    {
                        dataGridViewTakeAttendance.Rows[e.RowIndex].Cells[2].Value = false;
                    }
                    else
                    {
                        dataGridViewTakeAttendance.Rows[e.RowIndex].Cells[2].Value = true;
                    }
                }
            }



        }
    }
}