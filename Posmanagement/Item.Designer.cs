namespace Posmanagement
{
    partial class Item
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
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDname = new System.Windows.Forms.Label();
            this.btnItemUpdate = new System.Windows.Forms.Button();
            this.btnItemDel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnItemSubmit = new System.Windows.Forms.Button();
            this.DGBitem = new System.Windows.Forms.DataGridView();
            this.btnShowItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGBitem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(155, 68);
            this.txtItemName.Multiline = true;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(177, 26);
            this.txtItemName.TabIndex = 20;
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(155, 23);
            this.txtItemID.Multiline = true;
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(177, 26);
            this.txtItemID.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(10, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Item Name :";
            // 
            // lblDname
            // 
            this.lblDname.AutoSize = true;
            this.lblDname.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDname.Location = new System.Drawing.Point(11, 30);
            this.lblDname.Name = "lblDname";
            this.lblDname.Size = new System.Drawing.Size(60, 15);
            this.lblDname.TabIndex = 17;
            this.lblDname.Text = "Item ID :";
            // 
            // btnItemUpdate
            // 
            this.btnItemUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnItemUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItemUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemUpdate.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnItemUpdate.Location = new System.Drawing.Point(12, 128);
            this.btnItemUpdate.Name = "btnItemUpdate";
            this.btnItemUpdate.Size = new System.Drawing.Size(70, 28);
            this.btnItemUpdate.TabIndex = 47;
            this.btnItemUpdate.Text = "Update";
            this.btnItemUpdate.UseVisualStyleBackColor = false;
            this.btnItemUpdate.Click += new System.EventHandler(this.btnItemUpdate_Click);
            // 
            // btnItemDel
            // 
            this.btnItemDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnItemDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItemDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemDel.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnItemDel.Location = new System.Drawing.Point(92, 128);
            this.btnItemDel.Name = "btnItemDel";
            this.btnItemDel.Size = new System.Drawing.Size(70, 28);
            this.btnItemDel.TabIndex = 46;
            this.btnItemDel.Text = "Delete";
            this.btnItemDel.UseVisualStyleBackColor = false;
            this.btnItemDel.Click += new System.EventHandler(this.btnItemDel_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNew.Location = new System.Drawing.Point(174, 128);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(70, 28);
            this.btnNew.TabIndex = 45;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnItemSubmit
            // 
            this.btnItemSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnItemSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnItemSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemSubmit.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItemSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnItemSubmit.Location = new System.Drawing.Point(256, 128);
            this.btnItemSubmit.Name = "btnItemSubmit";
            this.btnItemSubmit.Size = new System.Drawing.Size(76, 28);
            this.btnItemSubmit.TabIndex = 44;
            this.btnItemSubmit.Text = " Submit";
            this.btnItemSubmit.UseVisualStyleBackColor = false;
            this.btnItemSubmit.Click += new System.EventHandler(this.btnItemSubmit_Click);
            // 
            // DGBitem
            // 
            this.DGBitem.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGBitem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGBitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGBitem.Location = new System.Drawing.Point(12, 160);
            this.DGBitem.Name = "DGBitem";
            this.DGBitem.Size = new System.Drawing.Size(320, 150);
            this.DGBitem.TabIndex = 48;
            // 
            // btnShowItem
            // 
            this.btnShowItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnShowItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowItem.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShowItem.Location = new System.Drawing.Point(126, 319);
            this.btnShowItem.Name = "btnShowItem";
            this.btnShowItem.Size = new System.Drawing.Size(76, 28);
            this.btnShowItem.TabIndex = 49;
            this.btnShowItem.Text = "Show";
            this.btnShowItem.UseVisualStyleBackColor = false;
            this.btnShowItem.Click += new System.EventHandler(this.btnShowItem_Click);
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(350, 359);
            this.Controls.Add(this.btnShowItem);
            this.Controls.Add(this.DGBitem);
            this.Controls.Add(this.btnItemUpdate);
            this.Controls.Add(this.btnItemDel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnItemSubmit);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item";
            ((System.ComponentModel.ISupportInitialize)(this.DGBitem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDname;
        private System.Windows.Forms.Button btnItemUpdate;
        private System.Windows.Forms.Button btnItemDel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnItemSubmit;
        private System.Windows.Forms.DataGridView DGBitem;
        private System.Windows.Forms.Button btnShowItem;
    }
}