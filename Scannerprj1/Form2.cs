using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;
using System.IO;
using System.Runtime.InteropServices;

namespace Scannerprj1
{
    public partial class Form2 : Form
    {
        public static String[] student_father;
        DeviceManager deviceManager = new DeviceManager();
        public Form2()
        {
            InitializeComponent();                        
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelFatherName_Click(object sender, EventArgs e)
        {

        }

        private void labelStudentName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxGetLMS_TextChanged(object sender, EventArgs e)
        {

        }
        String[] search_student_father(String searchID)
        {
            var strLines = System.IO.File.ReadLines(".\\ForBatchScanning.csv");
            foreach (var line in strLines)
            {
                if (line.Split(',')[0].Equals(searchID))
                {
                    string[] student_father = { line.Split(',')[1], line.Split(',')[2], line.Split(',')[0] };
                    return student_father;
                }              
            }

            return new string[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            if (!string.IsNullOrEmpty(textBoxGetLMS.Text))
            {
                int lMS_ID = Int32.Parse(textBoxGetLMS.Text);
                student_father = search_student_father(lMS_ID.ToString());
                if (student_father.Length != 0)
                {
                    labelStudentName.Text = student_father[0];
                    labelFatherName.Text = student_father[1];                   
                }
                else
                {
                    MessageBox.Show("Invalid LMS ID entered");
                }
            }
            else
            {
                MessageBox.Show("Text Box Empty!");
            }            
        }

        private void btnToScanForm_Click(object sender, EventArgs e)
        {
            int scannerCount = 0;
            if (!string.IsNullOrEmpty(textBoxGetLMS.Text))
            {
                if (!string.IsNullOrEmpty(labelStudentName.Text) )
                {
                    for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
                    {
                        
                        if (deviceManager.DeviceInfos[i].Type == WiaDeviceType.ScannerDeviceType)
                        {
                            scannerCount++;
                            continue;
                        }
                    }
                    #if DEBUG
                        if (scannerCount >=0) {
                    #else
                        if (scannerCount > 0) {              
                    #endif                        
                    
                        this.Hide();
                        Form1 scanForm = new Form1();
                        //scanForm.Closed += (s, args) => this.Close();
                        scanForm.ShowDialog();
                        this.Show();                        
                    }
                    else
                    {
                        MessageBox.Show("No Scanner Detected");
                    }                   
                }
                else
                {
                    MessageBox.Show("Search Before Scan!");
                }
            }
            else
            {
                MessageBox.Show("Text Box Empty!");
            }
        }

        private void textBoxGetLMS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
