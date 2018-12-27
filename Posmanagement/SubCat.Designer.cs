namespace Posmanagement
{
    partial class SubCat
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
            this.txtCatID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveSubItm = new System.Windows.Forms.Button();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBActive = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGBBottom = new System.Windows.Forms.DataGridView();
            this.txtSubcatDes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubCatName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubCatId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSubCatCrNew = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGBBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCatID
            // 
            this.txtCatID.Location = new System.Drawing.Point(191, 23);
            this.txtCatID.Multiline = true;
            this.txtCatID.Name = "txtCatID";
            this.txtCatID.Size = new System.Drawing.Size(153, 24);
            this.txtCatID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(71, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Category ID :";
            // 
            // btnSaveSubItm
            // 
            this.btnSaveSubItm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnSaveSubItm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveSubItm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveSubItm.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSubItm.ForeColor = System.Drawing.Color.White;
            this.btnSaveSubItm.Location = new System.Drawing.Point(412, 255);
            this.btnSaveSubItm.Name = "btnSaveSubItm";
            this.btnSaveSubItm.Size = new System.Drawing.Size(123, 31);
            this.btnSaveSubItm.TabIndex = 8;
            this.btnSaveSubItm.Text = "Save Sub Item";
            this.btnSaveSubItm.UseVisualStyleBackColor = false;
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(191, 70);
            this.txtCatName.Multiline = true;
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(153, 24);
            this.txtCatName.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(71, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Category Name :";
            // 
            // checkBActive
            // 
            this.checkBActive.AutoSize = true;
            this.checkBActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBActive.ForeColor = System.Drawing.Color.Transparent;
            this.checkBActive.Location = new System.Drawing.Point(191, 106);
            this.checkBActive.Name = "checkBActive";
            this.checkBActive.Size = new System.Drawing.Size(64, 20);
            this.checkBActive.TabIndex = 11;
            this.checkBActive.Text = "Active";
            this.checkBActive.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DGBBottom);
            this.panel1.Controls.Add(this.txtSubcatDes);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSubCatName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSaveSubItm);
            this.panel1.Controls.Add(this.txtSubCatId);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(27, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 296);
            this.panel1.TabIndex = 13;
            // 
            // DGBBottom
            // 
            this.DGBBottom.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGBBottom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGBBottom.Location = new System.Drawing.Point(18, 99);
            this.DGBBottom.Name = "DGBBottom";
            this.DGBBottom.Size = new System.Drawing.Size(518, 150);
            this.DGBBottom.TabIndex = 20;
            // 
            // txtSubcatDes
            // 
            this.txtSubcatDes.Location = new System.Drawing.Point(383, 38);
            this.txtSubcatDes.Multiline = true;
            this.txtSubcatDes.Name = "txtSubcatDes";
            this.txtSubcatDes.Size = new System.Drawing.Size(153, 24);
            this.txtSubcatDes.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(417, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Description";
            // 
            // txtSubCatName
            // 
            this.txtSubCatName.Location = new System.Drawing.Point(202, 38);
            this.txtSubCatName.Multiline = true;
            this.txtSubCatName.Name = "txtSubCatName";
            this.txtSubCatName.Size = new System.Drawing.Size(153, 24);
            this.txtSubCatName.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(213, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Sub Category Name";
            // 
            // txtSubCatId
            // 
            this.txtSubCatId.Location = new System.Drawing.Point(18, 38);
            this.txtSubCatId.Multiline = true;
            this.txtSubCatId.Name = "txtSubCatId";
            this.txtSubCatId.Size = new System.Drawing.Size(153, 24);
            this.txtSubCatId.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(43, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sub Category ID ";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(27, 452);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 31);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(165, 452);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 31);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(303, 452);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 31);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnSubCatCrNew
            // 
            this.btnSubCatCrNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnSubCatCrNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubCatCrNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubCatCrNew.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubCatCrNew.ForeColor = System.Drawing.Color.White;
            this.btnSubCatCrNew.Location = new System.Drawing.Point(440, 452);
            this.btnSubCatCrNew.Name = "btnSubCatCrNew";
            this.btnSubCatCrNew.Size = new System.Drawing.Size(123, 31);
            this.btnSubCatCrNew.TabIndex = 24;
            this.btnSubCatCrNew.Text = "Create New";
            this.btnSubCatCrNew.UseVisualStyleBackColor = false;
            this.btnSubCatCrNew.Click += new System.EventHandler(this.btnSubCatCrNew_Click);
            // 
            // SubCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(615, 517);
            this.Controls.Add(this.btnSubCatCrNew);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBActive);
            this.Controls.Add(this.txtCatName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCatID);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SubCat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sub Category";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGBBottom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCatID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveSubItm;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBActive;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSubcatDes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubCatName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubCatId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGBBottom;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSubCatCrNew;
    }
}