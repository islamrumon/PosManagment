namespace Posmanagement
{
    partial class Registration
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
            this.lblempName = new System.Windows.Forms.Label();
            this.txtempName = new System.Windows.Forms.TextBox();
            this.txtempID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CMBType = new System.Windows.Forms.ComboBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnRegBrowse = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.RadioBtnMale = new System.Windows.Forms.RadioButton();
            this.RadioBtnFemale = new System.Windows.Forms.RadioButton();
            this.CMBComName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ChkBStore = new System.Windows.Forms.CheckBox();
            this.ChkBSale = new System.Windows.Forms.CheckBox();
            this.ChkBReport = new System.Windows.Forms.CheckBox();
            this.ChkBCrm = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PBemp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBemp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblempName
            // 
            this.lblempName.AutoSize = true;
            this.lblempName.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblempName.Location = new System.Drawing.Point(28, 75);
            this.lblempName.Name = "lblempName";
            this.lblempName.Size = new System.Drawing.Size(128, 19);
            this.lblempName.TabIndex = 0;
            this.lblempName.Text = "Employee Name:";
            // 
            // txtempName
            // 
            this.txtempName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempName.Location = new System.Drawing.Point(179, 72);
            this.txtempName.Multiline = true;
            this.txtempName.Name = "txtempName";
            this.txtempName.Size = new System.Drawing.Size(244, 25);
            this.txtempName.TabIndex = 1;
            // 
            // txtempID
            // 
            this.txtempID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempID.Location = new System.Drawing.Point(179, 24);
            this.txtempID.Multiline = true;
            this.txtempID.Name = "txtempID";
            this.txtempID.Size = new System.Drawing.Size(244, 25);
            this.txtempID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee ID:";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegister.Location = new System.Drawing.Point(353, 429);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(70, 30);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "Submit";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(267, 429);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 30);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type :";
            // 
            // CMBType
            // 
            this.CMBType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBType.FormattingEnabled = true;
            this.CMBType.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.CMBType.Location = new System.Drawing.Point(179, 169);
            this.CMBType.Name = "CMBType";
            this.CMBType.Size = new System.Drawing.Size(142, 24);
            this.CMBType.TabIndex = 17;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(179, 119);
            this.txtpass.Multiline = true;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(244, 25);
            this.txtpass.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Store :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "Company Name:";
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDel.Location = new System.Drawing.Point(179, 429);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(70, 30);
            this.btnDel.TabIndex = 35;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnRegBrowse
            // 
            this.btnRegBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnRegBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegBrowse.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegBrowse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegBrowse.Location = new System.Drawing.Point(482, 219);
            this.btnRegBrowse.Name = "btnRegBrowse";
            this.btnRegBrowse.Size = new System.Drawing.Size(97, 30);
            this.btnRegBrowse.TabIndex = 37;
            this.btnRegBrowse.Text = "Browse";
            this.btnRegBrowse.UseVisualStyleBackColor = false;
            this.btnRegBrowse.Click += new System.EventHandler(this.btnRegBrowse_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 38;
            this.label6.Text = "Gender :";
            // 
            // RadioBtnMale
            // 
            this.RadioBtnMale.AutoSize = true;
            this.RadioBtnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioBtnMale.Location = new System.Drawing.Point(179, 218);
            this.RadioBtnMale.Name = "RadioBtnMale";
            this.RadioBtnMale.Size = new System.Drawing.Size(56, 20);
            this.RadioBtnMale.TabIndex = 39;
            this.RadioBtnMale.TabStop = true;
            this.RadioBtnMale.Text = "Male";
            this.RadioBtnMale.UseVisualStyleBackColor = true;
            this.RadioBtnMale.CheckedChanged += new System.EventHandler(this.RadioBtnMale_CheckedChanged);
            // 
            // RadioBtnFemale
            // 
            this.RadioBtnFemale.AutoSize = true;
            this.RadioBtnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadioBtnFemale.Location = new System.Drawing.Point(253, 219);
            this.RadioBtnFemale.Name = "RadioBtnFemale";
            this.RadioBtnFemale.Size = new System.Drawing.Size(72, 20);
            this.RadioBtnFemale.TabIndex = 40;
            this.RadioBtnFemale.TabStop = true;
            this.RadioBtnFemale.Text = "Female";
            this.RadioBtnFemale.UseVisualStyleBackColor = true;
            this.RadioBtnFemale.CheckedChanged += new System.EventHandler(this.RadioBtnFemale_CheckedChanged);
            // 
            // CMBComName
            // 
            this.CMBComName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBComName.FormattingEnabled = true;
            this.CMBComName.Location = new System.Drawing.Point(179, 386);
            this.CMBComName.Name = "CMBComName";
            this.CMBComName.Size = new System.Drawing.Size(142, 24);
            this.CMBComName.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 19);
            this.label7.TabIndex = 42;
            this.label7.Text = "Sale :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(226, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 43;
            this.label8.Text = "Report :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(226, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 19);
            this.label9.TabIndex = 44;
            this.label9.Text = "Crm :";
            // 
            // ChkBStore
            // 
            this.ChkBStore.AutoSize = true;
            this.ChkBStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBStore.Location = new System.Drawing.Point(133, 280);
            this.ChkBStore.Name = "ChkBStore";
            this.ChkBStore.Size = new System.Drawing.Size(15, 14);
            this.ChkBStore.TabIndex = 45;
            this.ChkBStore.UseVisualStyleBackColor = true;
            // 
            // ChkBSale
            // 
            this.ChkBSale.AutoSize = true;
            this.ChkBSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBSale.Location = new System.Drawing.Point(133, 323);
            this.ChkBSale.Name = "ChkBSale";
            this.ChkBSale.Size = new System.Drawing.Size(15, 14);
            this.ChkBSale.TabIndex = 46;
            this.ChkBSale.UseVisualStyleBackColor = true;
            // 
            // ChkBReport
            // 
            this.ChkBReport.AutoSize = true;
            this.ChkBReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBReport.Location = new System.Drawing.Point(340, 279);
            this.ChkBReport.Name = "ChkBReport";
            this.ChkBReport.Size = new System.Drawing.Size(15, 14);
            this.ChkBReport.TabIndex = 47;
            this.ChkBReport.UseVisualStyleBackColor = true;
            // 
            // ChkBCrm
            // 
            this.ChkBCrm.AutoSize = true;
            this.ChkBCrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkBCrm.Location = new System.Drawing.Point(340, 322);
            this.ChkBCrm.Name = "ChkBCrm";
            this.ChkBCrm.Size = new System.Drawing.Size(15, 14);
            this.ChkBCrm.TabIndex = 48;
            this.ChkBCrm.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PBemp
            // 
            this.PBemp.Location = new System.Drawing.Point(439, 24);
            this.PBemp.Name = "PBemp";
            this.PBemp.Size = new System.Drawing.Size(159, 163);
            this.PBemp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBemp.TabIndex = 49;
            this.PBemp.TabStop = false;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 475);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ChkBCrm);
            this.Controls.Add(this.PBemp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CMBComName);
            this.Controls.Add(this.ChkBReport);
            this.Controls.Add(this.RadioBtnFemale);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RadioBtnMale);
            this.Controls.Add(this.ChkBSale);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ChkBStore);
            this.Controls.Add(this.btnRegBrowse);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CMBType);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtempID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtempName);
            this.Controls.Add(this.lblempName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblempName;
        private System.Windows.Forms.TextBox txtempName;
        private System.Windows.Forms.TextBox txtempID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CMBType;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnRegBrowse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton RadioBtnMale;
        private System.Windows.Forms.RadioButton RadioBtnFemale;
        private System.Windows.Forms.ComboBox CMBComName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ChkBStore;
        private System.Windows.Forms.CheckBox ChkBSale;
        private System.Windows.Forms.CheckBox ChkBReport;
        private System.Windows.Forms.CheckBox ChkBCrm;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox PBemp;
    }
}