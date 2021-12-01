using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using WIA;
using System.Runtime.InteropServices;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;

namespace Scannerprj1
{    
    public partial class Form1 : Form
    {
        DeviceManager deviceManager = new DeviceManager();
        string[] fileName = new string[7];
        string[] csvInitials = new string[7];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
                {
                    if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                    {
                        continue;
                    }
                    labelScannerSelected.Text = deviceManager.DeviceInfos[i].Properties["Name"].get_Value().ToString().ToUpper();
                    txtStudentName.Text = Form2.student_father[0];
                    txtFatherName.Text = Form2.student_father[1];
                }
            }
            catch (COMException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            try
            {               
                pbLoading.Visible = true;
                lblScanning.Visible = true;
                var deviceManager = new DeviceManager();
                string buttonName = ((Button)sender).Name;
                Control ctrl = ((Control)sender);
                //string fileName = "";                
                DeviceInfo AvailableScanner = null;
                for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
                {
                    if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                    {
                        continue;
                    }
                    AvailableScanner = deviceManager.DeviceInfos[i];
                    break;
                }
                var device = AvailableScanner.Connect();
                var ScannerItem = device.Items[1];
                var imgFile = (ImageFile)ScannerItem.Transfer(FormatID.wiaFormatPNG);
                string directory = @"C:\\Users\\MuhammadUsmanSaleem\\OneDrive - njv\\Documents\\Scanned Documents";
                //bool buttonRFpressed = false;
                //bool buttonBFpressed = false;
                string combinedPath = "";
                switch (buttonName)
                {
                    case "btnRF":
                        //buttonRFpressed = true;
                        //fileName[0] = Form2.student_father[2] + "-RF.png";
                        combinedPath = Path.Combine(directory, Form2.student_father[2] + "-RF.png");
                        csvInitials[0] = "Y";
                        break;
                    case "btnScan":
                        //buttonBFpressed = true;
                        //fileName[1] = Form2.student_father[2] + "-BF.png";
                        combinedPath = Path.Combine(directory, Form2.student_father[2] + "-BF.png");
                        csvInitials[1] = "Y";
                        break;
                }
                //if(buttonRFpressed)
                //{
                //    combinedPath = Path.Combine(directory, fileName[0]);
                //}
                //else if(buttonBFpressed){
                //    combinedPath = Path.Combine(directory, fileName[1]);
                //}                
                
                if (File.Exists(combinedPath))
                {
                    File.Delete(combinedPath);
                }
                imgFile.SaveFile(combinedPath);
                pictureBox1.ImageLocation = combinedPath;
                pbLoading.Visible= false;
                lblScanning.Visible = false;
                ctrl.BackColor = Color.Green;
                ctrl.ForeColor = Color.White;                
            }
            catch (COMException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WIA.CommonDialog wiaDlg;
            WIA.Device wiaDevice;
            WIA.DeviceManager wiaManager = new DeviceManager();

            wiaDlg = new WIA.CommonDialog();
            wiaDevice = wiaDlg.ShowSelectDevice(WiaDeviceType.ScannerDeviceType, false, false);
            string buttonName = ((Button)sender).Name;
            Control ctrl = ((Control)sender);
            pbLoading.Visible = true;
            lblScanning.Visible = true;

            foreach (WIA.Item item in wiaDevice.Items)
            {               

                foreach (WIA.Property itemProperty in item.Properties)
                {
                    IProperty tempProperty;
                    Object tempNewProperty;

                    if (itemProperty.Name.Equals("Horizontal Resolution"))
                    {
                        tempNewProperty = 100;
                        ((IProperty)itemProperty).set_Value(ref tempNewProperty);
                    }
                    else if (itemProperty.Name.Equals("Vertical Resolution"))
                    {
                        tempNewProperty = 100;
                        ((IProperty)itemProperty).set_Value(ref tempNewProperty);
                    }
                    else if (itemProperty.Name.Equals("Horizontal Extent"))
                    {
                        tempNewProperty = 473;
                        ((IProperty)itemProperty).set_Value(ref tempNewProperty);
                    }
                    else if (itemProperty.Name.Equals("Vertical Extent"))
                    {
                        tempNewProperty = 300;
                        ((IProperty)itemProperty).set_Value(ref tempNewProperty);
                    }
                }

                var image = (ImageFile)item.Transfer(WIA.FormatID.wiaFormatPNG);
                string directory = @"C:\\Users\\MuhammadUsmanSaleem\\OneDrive - njv\\Documents\\Scanned Documents";                
                string combinedPath = "";

                switch (buttonName)
                {
                    case "button2":
                        combinedPath = Path.Combine(directory, Form2.student_father[2] + "-FCF.png");
                        csvInitials[2] = "Y";                        
                        break;
                    case "btnFCB":
                        combinedPath = Path.Combine(directory, Form2.student_father[2] + "-FCB.png");
                        csvInitials[3] = "Y";
                        break;
                    case "btnMCF":
                        combinedPath = Path.Combine(directory, Form2.student_father[2] + "-MCF.png");
                        csvInitials[4] = "Y";
                        break;
                    case "btnMCB":
                        combinedPath = Path.Combine(directory, Form2.student_father[2] + "-MCB.png");
                        csvInitials[5] = "Y";
                        break;
                }

                if (File.Exists(combinedPath))
                {
                    File.Delete(combinedPath);
                }
                image.SaveFile(combinedPath);
                pictureBox1.ImageLocation = combinedPath;
                pbLoading.Visible = false;
                lblScanning.Visible = false;
                ctrl.BackColor = Color.Green;
                ctrl.ForeColor = Color.White;
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }    

        private void btnPicScan_Click(object sender, EventArgs e)
        {
            WIA.CommonDialog wiaDlg;
            WIA.Device wiaDevice;
            WIA.DeviceManager wiaManager = new DeviceManager();

            wiaDlg = new WIA.CommonDialog();
            wiaDevice = wiaDlg.ShowSelectDevice(WiaDeviceType.ScannerDeviceType, false, false);
            Control ctrl = ((Control)sender);
            pbLoading.Visible = true;
            lblScanning.Visible = true;

            foreach (WIA.Item item in wiaDevice.Items)
            {

                foreach (WIA.Property itemProperty in item.Properties)
                {
                    IProperty tempProperty;
                    Object tempNewProperty;

                    if (itemProperty.Name.Equals("Horizontal Resolution"))
                    {
                        tempNewProperty = 100;
                        ((IProperty)itemProperty).set_Value(ref tempNewProperty);
                    }
                    else if (itemProperty.Name.Equals("Vertical Resolution"))
                    {
                        tempNewProperty = 100;
                        ((IProperty)itemProperty).set_Value(ref tempNewProperty);
                    }
                    else if (itemProperty.Name.Equals("Horizontal Extent"))
                    {
                        tempNewProperty = 250;
                        ((IProperty)itemProperty).set_Value(ref tempNewProperty);
                    }
                    else if (itemProperty.Name.Equals("Vertical Extent"))
                    {
                        tempNewProperty = 250;
                        ((IProperty)itemProperty).set_Value(ref tempNewProperty);
                    }
                }

                var image = (ImageFile)item.Transfer(WIA.FormatID.wiaFormatPNG);
                string directory = @"C:\\Users\\MuhammadUsmanSaleem\\OneDrive - njv\\Documents\\Scanned Documents";
                string combinedPath = "";
                combinedPath = Path.Combine(directory, Form2.student_father[2] + "-PIC.png");
                csvInitials[6] = "Y";                

                if (File.Exists(combinedPath))
                {
                    File.Delete(combinedPath);
                }
                image.SaveFile(combinedPath);
                pictureBox1.ImageLocation = combinedPath;
                pbLoading.Visible = false;
                lblScanning.Visible = false;
                ctrl.BackColor = Color.Green;
                ctrl.ForeColor = Color.White;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Appending to CSV
            var CSVpath = @"C:\\Users\\MuhammadUsmanSaleem\\OneDrive - njv\\Documents\\ScanningRecord.csv";
            var records = new List<ScannedValuestoCSV>
                {
                    new ScannedValuestoCSV {
                        ID = Form2.student_father[2],
                        Time = DateTime.Now.ToString("MM/dd/yyyy HH:mm"),
                        RG = csvInitials[0] == "Y" ? "Y" : "N",
                        BF = csvInitials[1] == "Y" ? "Y" : "N",
                        FCF = csvInitials[2] == "Y" ? "Y" : "N",
                        FCB = csvInitials[3] == "Y" ? "Y" : "N",
                        MCF = csvInitials[4] == "Y" ? "Y" : "N",
                        MCB = csvInitials[5] == "Y" ? "Y" : "N",
                        Pic  = csvInitials[6] == "Y" ? "Y" : "N",
                    },
                };
            if (File.Exists(CSVpath))
            {
                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    // Don't write the header again.
                    HasHeaderRecord = false,
                };
                using (var stream = File.Open(CSVpath, FileMode.Append))
                using (var writer = new StreamWriter(stream))
                using (var csv = new CsvWriter(writer, config))
                {
                    csv.WriteRecords(records);
                }


                Form2 oldSearchForm = (Form2)Application.OpenForms["Form2"];
                oldSearchForm.Show();
                this.Close();
                //this.Dispose();
                //Form2 NewSearch = new Form2();
                //NewSearch.Show();

                ////NewSearch.Closed += (s, args) => this.Close();

                //this.Show();                
            }
            else
            {
                MessageBox.Show("No CSV File Found!");
            }
        }
    }
    public class ScannedValuestoCSV
    {
        public string ID { get; set; }
        public string Time { get; set; }
        public string RG { get; set; }
        public string BF { get; set; }
        public string FCF { get; set; }
        public string FCB { get; set; }
        public string MCF { get; set; }
        public string MCB { get; set; }
        public string Pic { get; set; }
    }
}
