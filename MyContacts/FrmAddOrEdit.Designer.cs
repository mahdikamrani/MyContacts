namespace MyContacts
{
    partial class FrmAddOrEdit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.LblFamily = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.LblMobile = new System.Windows.Forms.Label();
            this.LblAge = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblٍEmail = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.btnSubmit);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblٍEmail);
            this.groupBox1.Controls.Add(this.LblAge);
            this.groupBox1.Controls.Add(this.txtMobile);
            this.groupBox1.Controls.Add(this.LblMobile);
            this.groupBox1.Controls.Add(this.txtFamily);
            this.groupBox1.Controls.Add(this.LblFamily);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات فرد";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(412, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(24, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "نام:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(273, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(133, 21);
            this.txtName.TabIndex = 1;
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(50, 35);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(131, 21);
            this.txtFamily.TabIndex = 3;
            // 
            // LblFamily
            // 
            this.LblFamily.AutoSize = true;
            this.LblFamily.Location = new System.Drawing.Point(187, 38);
            this.LblFamily.Name = "LblFamily";
            this.LblFamily.Size = new System.Drawing.Size(69, 13);
            this.LblFamily.TabIndex = 2;
            this.LblFamily.Text = "نام خانوادگی:";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(273, 62);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(133, 21);
            this.txtMobile.TabIndex = 5;
            // 
            // LblMobile
            // 
            this.LblMobile.AutoSize = true;
            this.LblMobile.Location = new System.Drawing.Point(412, 65);
            this.LblMobile.Name = "LblMobile";
            this.LblMobile.Size = new System.Drawing.Size(35, 13);
            this.LblMobile.TabIndex = 4;
            this.LblMobile.Text = "موبایل";
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.Location = new System.Drawing.Point(189, 65);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(30, 13);
            this.LblAge.TabIndex = 6;
            this.LblAge.Text = "سن:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(50, 105);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(356, 21);
            this.txtEmail.TabIndex = 9;
            // 
            // lblٍEmail
            // 
            this.lblٍEmail.AutoSize = true;
            this.lblٍEmail.Location = new System.Drawing.Point(412, 108);
            this.lblٍEmail.Name = "lblٍEmail";
            this.lblٍEmail.Size = new System.Drawing.Size(36, 13);
            this.lblٍEmail.TabIndex = 8;
            this.lblٍEmail.Text = "ایمیل:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(50, 132);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(356, 81);
            this.txtAddress.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "آدرس:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(370, 219);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "ثبت";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(50, 63);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(131, 21);
            this.txtAge.TabIndex = 13;
            // 
            // FrmAddOrEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 279);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAddOrEdit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmAddOrEdit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label LblMobile;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.Label LblFamily;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblٍEmail;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.NumericUpDown txtAge;
    }
}