namespace Scannerprj1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelListOfScanners = new System.Windows.Forms.Label();
            this.labelScannerSelected = new System.Windows.Forms.Label();
            this.btnScan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.Label();
            this.lblFatherName = new System.Windows.Forms.Label();
            this.txtFatherName = new System.Windows.Forms.Label();
            this.btnRF = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFCB = new System.Windows.Forms.Button();
            this.btnMCF = new System.Windows.Forms.Button();
            this.btnMCB = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            this.lblScanning = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPicScan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // labelListOfScanners
            // 
            this.labelListOfScanners.AutoSize = true;
            this.labelListOfScanners.Location = new System.Drawing.Point(13, 13);
            this.labelListOfScanners.Name = "labelListOfScanners";
            this.labelListOfScanners.Size = new System.Drawing.Size(95, 13);
            this.labelListOfScanners.TabIndex = 1;
            this.labelListOfScanners.Text = "Scanner Selected:";
            this.labelListOfScanners.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelScannerSelected
            // 
            this.labelScannerSelected.AutoSize = true;
            this.labelScannerSelected.Location = new System.Drawing.Point(104, 13);
            this.labelScannerSelected.Name = "labelScannerSelected";
            this.labelScannerSelected.Size = new System.Drawing.Size(117, 13);
            this.labelScannerSelected.TabIndex = 2;
            this.labelScannerSelected.Text = "labelScannnerSelected";
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(16, 127);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(164, 23);
            this.btnScan.TabIndex = 3;
            this.btnScan.Text = "B-Form Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(240, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 414);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(13, 39);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(78, 13);
            this.lblStudentName.TabIndex = 5;
            this.lblStudentName.Text = "Student Name:";
            this.lblStudentName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtStudentName
            // 
            this.txtStudentName.AutoSize = true;
            this.txtStudentName.Location = new System.Drawing.Point(104, 39);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(83, 13);
            this.txtStudentName.TabIndex = 6;
            this.txtStudentName.Text = "txtStudentName";
            // 
            // lblFatherName
            // 
            this.lblFatherName.AutoSize = true;
            this.lblFatherName.Location = new System.Drawing.Point(13, 65);
            this.lblFatherName.Name = "lblFatherName";
            this.lblFatherName.Size = new System.Drawing.Size(68, 13);
            this.lblFatherName.TabIndex = 7;
            this.lblFatherName.Text = "Father Name";
            // 
            // txtFatherName
            // 
            this.txtFatherName.AutoSize = true;
            this.txtFatherName.Location = new System.Drawing.Point(104, 64);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(76, 13);
            this.txtFatherName.TabIndex = 8;
            this.txtFatherName.Text = "txtFatherName";
            // 
            // btnRF
            // 
            this.btnRF.Location = new System.Drawing.Point(16, 93);
            this.btnRF.Name = "btnRF";
            this.btnRF.Size = new System.Drawing.Size(164, 23);
            this.btnRF.TabIndex = 9;
            this.btnRF.Text = "Registration Form Scan";
            this.btnRF.UseVisualStyleBackColor = true;
            this.btnRF.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Father CNIC Front Scan";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFCB
            // 
            this.btnFCB.Location = new System.Drawing.Point(16, 195);
            this.btnFCB.Name = "btnFCB";
            this.btnFCB.Size = new System.Drawing.Size(164, 23);
            this.btnFCB.TabIndex = 11;
            this.btnFCB.Text = "Father CNIC Back Scan";
            this.btnFCB.UseVisualStyleBackColor = true;
            this.btnFCB.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMCF
            // 
            this.btnMCF.Location = new System.Drawing.Point(16, 229);
            this.btnMCF.Name = "btnMCF";
            this.btnMCF.Size = new System.Drawing.Size(164, 23);
            this.btnMCF.TabIndex = 12;
            this.btnMCF.Text = "Mother CNIC Front Scan";
            this.btnMCF.UseVisualStyleBackColor = true;
            this.btnMCF.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMCB
            // 
            this.btnMCB.Location = new System.Drawing.Point(16, 263);
            this.btnMCB.Name = "btnMCB";
            this.btnMCB.Size = new System.Drawing.Size(164, 23);
            this.btnMCB.TabIndex = 13;
            this.btnMCB.Text = "Mother CNIC Back Scan";
            this.btnMCB.UseVisualStyleBackColor = true;
            this.btnMCB.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(16, 405);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(75, 23);
            this.btnGoBack.TabIndex = 14;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // pbLoading
            // 
            this.pbLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbLoading.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.pbLoading.Image = ((System.Drawing.Image)(resources.GetObject("pbLoading.Image")));
            this.pbLoading.Location = new System.Drawing.Point(34, 339);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(129, 63);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoading.TabIndex = 15;
            this.pbLoading.TabStop = false;
            this.pbLoading.Visible = false;
            // 
            // lblScanning
            // 
            this.lblScanning.AutoSize = true;
            this.lblScanning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanning.Location = new System.Drawing.Point(22, 320);
            this.lblScanning.Name = "lblScanning";
            this.lblScanning.Size = new System.Drawing.Size(153, 16);
            this.lblScanning.TabIndex = 16;
            this.lblScanning.Text = "Scanning in Process:";
            this.lblScanning.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Save and Start New";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPicScan
            // 
            this.btnPicScan.Location = new System.Drawing.Point(16, 293);
            this.btnPicScan.Name = "btnPicScan";
            this.btnPicScan.Size = new System.Drawing.Size(164, 23);
            this.btnPicScan.TabIndex = 18;
            this.btnPicScan.Text = "Picture Scan";
            this.btnPicScan.UseVisualStyleBackColor = true;
            this.btnPicScan.Click += new System.EventHandler(this.btnPicScan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 439);
            this.Controls.Add(this.btnPicScan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblScanning);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnMCB);
            this.Controls.Add(this.btnMCF);
            this.Controls.Add(this.btnFCB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRF);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.lblFatherName);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.labelScannerSelected);
            this.Controls.Add(this.labelListOfScanners);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NJV Data Room Scanning";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelListOfScanners;
        private System.Windows.Forms.Label labelScannerSelected;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label txtStudentName;
        private System.Windows.Forms.Label lblFatherName;
        private System.Windows.Forms.Label txtFatherName;
        private System.Windows.Forms.Button btnRF;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnFCB;
        private System.Windows.Forms.Button btnMCF;
        private System.Windows.Forms.Button btnMCB;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.PictureBox pbLoading;
        private System.Windows.Forms.Label lblScanning;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPicScan;
    }
}

