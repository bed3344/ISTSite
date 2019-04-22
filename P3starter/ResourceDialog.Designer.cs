namespace P3starter
{
    partial class ResourceDialog
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
            this.resourcePopupDesc = new System.Windows.Forms.RichTextBox();
            this.resourcePopupLbl = new System.Windows.Forms.Label();
            this.resDesc2 = new System.Windows.Forms.RichTextBox();
            this.resourcePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.resourcePic)).BeginInit();
            this.SuspendLayout();
            // 
            // resourcePopupDesc
            // 
            this.resourcePopupDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.resourcePopupDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resourcePopupDesc.Cursor = System.Windows.Forms.Cursors.Default;
            this.resourcePopupDesc.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resourcePopupDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(92)))));
            this.resourcePopupDesc.Location = new System.Drawing.Point(26, 58);
            this.resourcePopupDesc.Name = "resourcePopupDesc";
            this.resourcePopupDesc.ReadOnly = true;
            this.resourcePopupDesc.Size = new System.Drawing.Size(962, 192);
            this.resourcePopupDesc.TabIndex = 5;
            this.resourcePopupDesc.Text = "description goes here";
            // 
            // resourcePopupLbl
            // 
            this.resourcePopupLbl.AutoSize = true;
            this.resourcePopupLbl.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resourcePopupLbl.Location = new System.Drawing.Point(21, 13);
            this.resourcePopupLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resourcePopupLbl.Name = "resourcePopupLbl";
            this.resourcePopupLbl.Size = new System.Drawing.Size(171, 29);
            this.resourcePopupLbl.TabIndex = 4;
            this.resourcePopupLbl.Text = "resource name";
            // 
            // resDesc2
            // 
            this.resDesc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.resDesc2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resDesc2.Cursor = System.Windows.Forms.Cursors.Default;
            this.resDesc2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resDesc2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(92)))));
            this.resDesc2.Location = new System.Drawing.Point(26, 292);
            this.resDesc2.Name = "resDesc2";
            this.resDesc2.ReadOnly = true;
            this.resDesc2.Size = new System.Drawing.Size(962, 389);
            this.resDesc2.TabIndex = 6;
            this.resDesc2.Text = "description goes here";
            this.resDesc2.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.resDesc2_LinkClicked);
            // 
            // resourcePic
            // 
            this.resourcePic.Location = new System.Drawing.Point(309, 74);
            this.resourcePic.Name = "resourcePic";
            this.resourcePic.Size = new System.Drawing.Size(389, 212);
            this.resourcePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resourcePic.TabIndex = 7;
            this.resourcePic.TabStop = false;
            // 
            // ResourceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1016, 739);
            this.Controls.Add(this.resDesc2);
            this.Controls.Add(this.resourcePopupDesc);
            this.Controls.Add(this.resourcePopupLbl);
            this.Controls.Add(this.resourcePic);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.Name = "ResourceDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.resourcePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox resourcePopupDesc;
        private System.Windows.Forms.Label resourcePopupLbl;
        private System.Windows.Forms.RichTextBox resDesc2;
        private System.Windows.Forms.PictureBox resourcePic;
    }
}