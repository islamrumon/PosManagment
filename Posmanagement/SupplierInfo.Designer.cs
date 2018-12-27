namespace Posmanagement
{
    partial class SupplierInfo
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
            this.btnBlUpdate = new System.Windows.Forms.Button();
            this.btnAdNVen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBlUpdate
            // 
            this.btnBlUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnBlUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBlUpdate.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlUpdate.ForeColor = System.Drawing.Color.White;
            this.btnBlUpdate.Location = new System.Drawing.Point(590, 69);
            this.btnBlUpdate.Name = "btnBlUpdate";
            this.btnBlUpdate.Size = new System.Drawing.Size(155, 31);
            this.btnBlUpdate.TabIndex = 3;
            this.btnBlUpdate.Text = "Balance Update";
            this.btnBlUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdNVen
            // 
            this.btnAdNVen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.btnAdNVen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdNVen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdNVen.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdNVen.ForeColor = System.Drawing.Color.White;
            this.btnAdNVen.Location = new System.Drawing.Point(419, 69);
            this.btnAdNVen.Name = "btnAdNVen";
            this.btnAdNVen.Size = new System.Drawing.Size(155, 31);
            this.btnAdNVen.TabIndex = 2;
            this.btnAdNVen.Text = "Add New Vendor";
            this.btnAdNVen.UseVisualStyleBackColor = false;
            this.btnAdNVen.Click += new System.EventHandler(this.btnAdNVen_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(784, 208);
            this.dataGridView1.TabIndex = 4;
            // 
            // SupplierInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(782, 394);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBlUpdate);
            this.Controls.Add(this.btnAdNVen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SupplierInfo";
            this.Text = "Supplier Info";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBlUpdate;
        private System.Windows.Forms.Button btnAdNVen;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}