namespace Posmanagement
{
    partial class company
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
            this.lblDname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtComID = new System.Windows.Forms.TextBox();
            this.txtComName = new System.Windows.Forms.TextBox();
            this.txtComPhone = new System.Windows.Forms.TextBox();
            this.txtComMail = new System.Windows.Forms.TextBox();
            this.txtComaddress = new System.Windows.Forms.TextBox();
            this.btnComDel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnComSubmit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CMBcomCountry = new System.Windows.Forms.ComboBox();
            this.PBcom = new System.Windows.Forms.PictureBox();
            this.btnComBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnComUpdate = new System.Windows.Forms.Button();
            this.DGBProCat = new System.Windows.Forms.DataGridView();
            this.btnCatShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBcom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGBProCat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDname
            // 
            this.lblDname.AutoSize = true;
            this.lblDname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDname.Location = new System.Drawing.Point(43, 42);
            this.lblDname.Name = "lblDname";
            this.lblDname.Size = new System.Drawing.Size(92, 15);
            this.lblDname.TabIndex = 9;
            this.lblDname.Text = "Company ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(42, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Company Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(43, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Company Phone :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(42, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Company Email :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(42, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Company Address :";
            // 
            // txtComID
            // 
            this.txtComID.Location = new System.Drawing.Point(196, 35);
            this.txtComID.Multiline = true;
            this.txtComID.Name = "txtComID";
            this.txtComID.Size = new System.Drawing.Size(177, 26);
            this.txtComID.TabIndex = 15;
            // 
            // txtComName
            // 
            this.txtComName.Location = new System.Drawing.Point(196, 80);
            this.txtComName.Multiline = true;
            this.txtComName.Name = "txtComName";
            this.txtComName.Size = new System.Drawing.Size(177, 26);
            this.txtComName.TabIndex = 16;
            // 
            // txtComPhone
            // 
            this.txtComPhone.Location = new System.Drawing.Point(196, 172);
            this.txtComPhone.Multiline = true;
            this.txtComPhone.Name = "txtComPhone";
            this.txtComPhone.Size = new System.Drawing.Size(177, 26);
            this.txtComPhone.TabIndex = 18;
            // 
            // txtComMail
            // 
            this.txtComMail.Location = new System.Drawing.Point(196, 127);
            this.txtComMail.Multiline = true;
            this.txtComMail.Name = "txtComMail";
            this.txtComMail.Size = new System.Drawing.Size(177, 26);
            this.txtComMail.TabIndex = 17;
            // 
            // txtComaddress
            // 
            this.txtComaddress.Location = new System.Drawing.Point(196, 218);
            this.txtComaddress.Multiline = true;
            this.txtComaddress.Name = "txtComaddress";
            this.txtComaddress.Size = new System.Drawing.Size(177, 26);
            this.txtComaddress.TabIndex = 19;
            // 
            // btnComDel
            // 
            this.btnComDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnComDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComDel.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnComDel.Location = new System.Drawing.Point(331, 315);
            this.btnComDel.Name = "btnComDel";
            this.btnComDel.Size = new System.Drawing.Size(70, 28);
            this.btnComDel.TabIndex = 38;
            this.btnComDel.Text = "Delete";
            this.btnComDel.UseVisualStyleBackColor = false;
            this.btnComDel.Click += new System.EventHandler(this.btnComDel_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(417, 315);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 28);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnComSubmit
            // 
            this.btnComSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnComSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComSubmit.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnComSubmit.Location = new System.Drawing.Point(502, 315);
            this.btnComSubmit.Name = "btnComSubmit";
            this.btnComSubmit.Size = new System.Drawing.Size(70, 28);
            this.btnComSubmit.TabIndex = 36;
            this.btnComSubmit.Text = "Submit";
            this.btnComSubmit.UseVisualStyleBackColor = false;
            this.btnComSubmit.Click += new System.EventHandler(this.btnComSubmit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(42, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 15);
            this.label4.TabIndex = 39;
            this.label4.Text = "Company Country :";
            // 
            // CMBcomCountry
            // 
            this.CMBcomCountry.FormattingEnabled = true;
            this.CMBcomCountry.Items.AddRange(new object[] {
            "BD",
            "Feni"});
            this.CMBcomCountry.Location = new System.Drawing.Point(196, 263);
            this.CMBcomCountry.Name = "CMBcomCountry";
            this.CMBcomCountry.Size = new System.Drawing.Size(124, 21);
            this.CMBcomCountry.TabIndex = 40;
            // 
            // PBcom
            // 
            this.PBcom.Location = new System.Drawing.Point(396, 35);
            this.PBcom.Name = "PBcom";
            this.PBcom.Size = new System.Drawing.Size(176, 163);
            this.PBcom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBcom.TabIndex = 41;
            this.PBcom.TabStop = false;
            // 
            // btnComBrowse
            // 
            this.btnComBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnComBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComBrowse.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComBrowse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnComBrowse.Location = new System.Drawing.Point(434, 218);
            this.btnComBrowse.Name = "btnComBrowse";
            this.btnComBrowse.Size = new System.Drawing.Size(92, 28);
            this.btnComBrowse.TabIndex = 42;
            this.btnComBrowse.Text = "Browse";
            this.btnComBrowse.UseVisualStyleBackColor = false;
            this.btnComBrowse.Click += new System.EventHandler(this.btnComBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnComUpdate
            // 
            this.btnComUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnComUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComUpdate.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnComUpdate.Location = new System.Drawing.Point(246, 315);
            this.btnComUpdate.Name = "btnComUpdate";
            this.btnComUpdate.Size = new System.Drawing.Size(70, 28);
            this.btnComUpdate.TabIndex = 43;
            this.btnComUpdate.Text = "Update";
            this.btnComUpdate.UseVisualStyleBackColor = false;
            this.btnComUpdate.Click += new System.EventHandler(this.btnComUpdate_Click);
            // 
            // DGBProCat
            // 
            this.DGBProCat.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.DGBProCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGBProCat.Location = new System.Drawing.Point(8, 351);
            this.DGBProCat.Name = "DGBProCat";
            this.DGBProCat.Size = new System.Drawing.Size(710, 223);
            this.DGBProCat.TabIndex = 44;
            // 
            // btnCatShow
            // 
            this.btnCatShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnCatShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatShow.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCatShow.Location = new System.Drawing.Point(322, 580);
            this.btnCatShow.Name = "btnCatShow";
            this.btnCatShow.Size = new System.Drawing.Size(70, 28);
            this.btnCatShow.TabIndex = 45;
            this.btnCatShow.Text = "Show";
            this.btnCatShow.UseVisualStyleBackColor = false;
            this.btnCatShow.Click += new System.EventHandler(this.btnCatShow_Click);
            // 
            // company
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(727, 620);
            this.Controls.Add(this.btnCatShow);
            this.Controls.Add(this.DGBProCat);
            this.Controls.Add(this.btnComUpdate);
            this.Controls.Add(this.btnComBrowse);
            this.Controls.Add(this.PBcom);
            this.Controls.Add(this.CMBcomCountry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnComDel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnComSubmit);
            this.Controls.Add(this.txtComaddress);
            this.Controls.Add(this.txtComPhone);
            this.Controls.Add(this.txtComMail);
            this.Controls.Add(this.txtComName);
            this.Controls.Add(this.txtComID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "company";
            this.Text = "company";
            ((System.ComponentModel.ISupportInitialize)(this.PBcom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGBProCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtComID;
        private System.Windows.Forms.TextBox txtComName;
        private System.Windows.Forms.TextBox txtComPhone;
        private System.Windows.Forms.TextBox txtComMail;
        private System.Windows.Forms.TextBox txtComaddress;
        private System.Windows.Forms.Button btnComDel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnComSubmit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CMBcomCountry;
        private System.Windows.Forms.PictureBox PBcom;
        private System.Windows.Forms.Button btnComBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnComUpdate;
        private System.Windows.Forms.DataGridView DGBProCat;
        private System.Windows.Forms.Button btnCatShow;
    }
}