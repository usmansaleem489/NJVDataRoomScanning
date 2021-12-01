namespace Scannerprj1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxGetLMS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.labelFatherName = new System.Windows.Forms.Label();
            this.btnToScanForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Student LMS ID:";
            // 
            // textBoxGetLMS
            // 
            this.textBoxGetLMS.Location = new System.Drawing.Point(132, 22);
            this.textBoxGetLMS.Name = "textBoxGetLMS";
            this.textBoxGetLMS.Size = new System.Drawing.Size(153, 20);
            this.textBoxGetLMS.TabIndex = 1;
            this.textBoxGetLMS.TextChanged += new System.EventHandler(this.textBoxGetLMS_TextChanged);
            this.textBoxGetLMS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGetLMS_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Father Name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudentName.Location = new System.Drawing.Point(132, 50);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(0, 16);
            this.labelStudentName.TabIndex = 5;
            this.labelStudentName.Click += new System.EventHandler(this.labelStudentName_Click);
            // 
            // labelFatherName
            // 
            this.labelFatherName.AutoSize = true;
            this.labelFatherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFatherName.Location = new System.Drawing.Point(132, 75);
            this.labelFatherName.Name = "labelFatherName";
            this.labelFatherName.Size = new System.Drawing.Size(0, 16);
            this.labelFatherName.TabIndex = 6;
            this.labelFatherName.Click += new System.EventHandler(this.labelFatherName_Click);
            // 
            // btnToScanForm
            // 
            this.btnToScanForm.Location = new System.Drawing.Point(291, 114);
            this.btnToScanForm.Name = "btnToScanForm";
            this.btnToScanForm.Size = new System.Drawing.Size(75, 23);
            this.btnToScanForm.TabIndex = 7;
            this.btnToScanForm.Text = "Lets Scan";
            this.btnToScanForm.UseVisualStyleBackColor = true;
            this.btnToScanForm.Click += new System.EventHandler(this.btnToScanForm_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 149);
            this.Controls.Add(this.btnToScanForm);
            this.Controls.Add(this.labelFatherName);
            this.Controls.Add(this.labelStudentName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxGetLMS);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NJV Data Room Scanning";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxGetLMS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.Label labelFatherName;
        private System.Windows.Forms.Button btnToScanForm;
    }
}