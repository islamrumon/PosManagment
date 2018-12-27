namespace Posmanagement
{
    partial class CRM
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
            this.txtcustIDCrm = new System.Windows.Forms.TextBox();
            this.lblcrmCustID = new System.Windows.Forms.Label();
            this.btnCrmSearch = new System.Windows.Forms.Button();
            this.btnCreatecustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcustIDCrm
            // 
            this.txtcustIDCrm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustIDCrm.Location = new System.Drawing.Point(139, 56);
            this.txtcustIDCrm.Multiline = true;
            this.txtcustIDCrm.Name = "txtcustIDCrm";
            this.txtcustIDCrm.Size = new System.Drawing.Size(229, 29);
            this.txtcustIDCrm.TabIndex = 3;
            // 
            // lblcrmCustID
            // 
            this.lblcrmCustID.AutoSize = true;
            this.lblcrmCustID.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcrmCustID.Location = new System.Drawing.Point(12, 61);
            this.lblcrmCustID.Name = "lblcrmCustID";
            this.lblcrmCustID.Size = new System.Drawing.Size(106, 19);
            this.lblcrmCustID.TabIndex = 2;
            this.lblcrmCustID.Text = "Customer ID :";
            // 
            // btnCrmSearch
            // 
            this.btnCrmSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnCrmSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrmSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrmSearch.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrmSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrmSearch.Location = new System.Drawing.Point(402, 56);
            this.btnCrmSearch.Name = "btnCrmSearch";
            this.btnCrmSearch.Size = new System.Drawing.Size(77, 29);
            this.btnCrmSearch.TabIndex = 15;
            this.btnCrmSearch.Text = "Search";
            this.btnCrmSearch.UseVisualStyleBackColor = false;
            // 
            // btnCreatecustomer
            // 
            this.btnCreatecustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(82)))), ((int)(((byte)(110)))));
            this.btnCreatecustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreatecustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatecustomer.Font = new System.Drawing.Font("Roboto Lt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatecustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreatecustomer.Location = new System.Drawing.Point(139, 126);
            this.btnCreatecustomer.Name = "btnCreatecustomer";
            this.btnCreatecustomer.Size = new System.Drawing.Size(229, 29);
            this.btnCreatecustomer.TabIndex = 16;
            this.btnCreatecustomer.Text = "Create Customer";
            this.btnCreatecustomer.UseVisualStyleBackColor = false;
            this.btnCreatecustomer.Click += new System.EventHandler(this.btnCreatecustomer_Click);
            // 
            // CRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 491);
            this.Controls.Add(this.btnCreatecustomer);
            this.Controls.Add(this.btnCrmSearch);
            this.Controls.Add(this.txtcustIDCrm);
            this.Controls.Add(this.lblcrmCustID);
            this.Name = "CRM";
            this.Text = "CRM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcustIDCrm;
        private System.Windows.Forms.Label lblcrmCustID;
        private System.Windows.Forms.Button btnCrmSearch;
        private System.Windows.Forms.Button btnCreatecustomer;
    }
}