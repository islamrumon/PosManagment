namespace Posmanagement
{
    partial class ProductCategory
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.btnCatDel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCatSubmit = new System.Windows.Forms.Button();
            this.txtCatsrc = new System.Windows.Forms.TextBox();
            this.btnCatSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGBCat = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCatID = new System.Windows.Forms.TextBox();
            this.btnCatShow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGBCat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCatID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCatName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Category Name :";
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(138, 71);
            this.txtCatName.Multiline = true;
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(183, 27);
            this.txtCatName.TabIndex = 0;
            // 
            // btnCatDel
            // 
            this.btnCatDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnCatDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCatDel.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCatDel.Location = new System.Drawing.Point(12, 149);
            this.btnCatDel.Name = "btnCatDel";
            this.btnCatDel.Size = new System.Drawing.Size(110, 28);
            this.btnCatDel.TabIndex = 41;
            this.btnCatDel.Text = "Delete";
            this.btnCatDel.UseVisualStyleBackColor = false;
            this.btnCatDel.Click += new System.EventHandler(this.btnCatDel_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(132, 149);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 28);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "New";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCatSubmit
            // 
            this.btnCatSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnCatSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCatSubmit.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCatSubmit.Location = new System.Drawing.Point(253, 149);
            this.btnCatSubmit.Name = "btnCatSubmit";
            this.btnCatSubmit.Size = new System.Drawing.Size(110, 28);
            this.btnCatSubmit.TabIndex = 39;
            this.btnCatSubmit.Text = "Save";
            this.btnCatSubmit.UseVisualStyleBackColor = false;
            this.btnCatSubmit.Click += new System.EventHandler(this.btnCatSubmit_Click);
            // 
            // txtCatsrc
            // 
            this.txtCatsrc.Location = new System.Drawing.Point(6, 30);
            this.txtCatsrc.Multiline = true;
            this.txtCatsrc.Name = "txtCatsrc";
            this.txtCatsrc.Size = new System.Drawing.Size(192, 27);
            this.txtCatsrc.TabIndex = 1;
            // 
            // btnCatSearch
            // 
            this.btnCatSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnCatSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCatSearch.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCatSearch.Location = new System.Drawing.Point(232, 30);
            this.btnCatSearch.Name = "btnCatSearch";
            this.btnCatSearch.Size = new System.Drawing.Size(94, 28);
            this.btnCatSearch.TabIndex = 42;
            this.btnCatSearch.Text = "Search";
            this.btnCatSearch.UseVisualStyleBackColor = false;
            this.btnCatSearch.Click += new System.EventHandler(this.btnCatSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCatsrc);
            this.groupBox2.Controls.Add(this.btnCatSearch);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(12, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 78);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Option";
            // 
            // DGBCat
            // 
            this.DGBCat.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.DGBCat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGBCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGBCat.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DGBCat.Location = new System.Drawing.Point(12, 282);
            this.DGBCat.Name = "DGBCat";
            this.DGBCat.Size = new System.Drawing.Size(351, 126);
            this.DGBCat.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category ID :";
            // 
            // txtCatID
            // 
            this.txtCatID.Location = new System.Drawing.Point(138, 21);
            this.txtCatID.Multiline = true;
            this.txtCatID.Name = "txtCatID";
            this.txtCatID.Size = new System.Drawing.Size(183, 27);
            this.txtCatID.TabIndex = 2;
            // 
            // btnCatShow
            // 
            this.btnCatShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnCatShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCatShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCatShow.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCatShow.Location = new System.Drawing.Point(126, 414);
            this.btnCatShow.Name = "btnCatShow";
            this.btnCatShow.Size = new System.Drawing.Size(113, 28);
            this.btnCatShow.TabIndex = 43;
            this.btnCatShow.Text = "Show";
            this.btnCatShow.UseVisualStyleBackColor = false;
            this.btnCatShow.Click += new System.EventHandler(this.btnCatShow_Click);
            // 
            // ProductCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(379, 450);
            this.Controls.Add(this.btnCatShow);
            this.Controls.Add(this.DGBCat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCatDel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCatSubmit);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ProductCategory";
            this.Text = "Product Category";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGBCat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.Button btnCatDel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCatSubmit;
        private System.Windows.Forms.TextBox txtCatsrc;
        private System.Windows.Forms.Button btnCatSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGBCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCatID;
        private System.Windows.Forms.Button btnCatShow;
    }
}