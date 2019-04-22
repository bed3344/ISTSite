namespace P3starter
{
    partial class MinorDialog
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
            this.minorLbl = new System.Windows.Forms.Label();
            this.minorDesc = new System.Windows.Forms.RichTextBox();
            this.coursesList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // minorLbl
            // 
            this.minorLbl.AutoSize = true;
            this.minorLbl.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minorLbl.Location = new System.Drawing.Point(13, 11);
            this.minorLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.minorLbl.Name = "minorLbl";
            this.minorLbl.Size = new System.Drawing.Size(141, 29);
            this.minorLbl.TabIndex = 0;
            this.minorLbl.Text = "minor name";
            // 
            // minorDesc
            // 
            this.minorDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.minorDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.minorDesc.Cursor = System.Windows.Forms.Cursors.Default;
            this.minorDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(92)))));
            this.minorDesc.Location = new System.Drawing.Point(18, 59);
            this.minorDesc.Name = "minorDesc";
            this.minorDesc.ReadOnly = true;
            this.minorDesc.Size = new System.Drawing.Size(1019, 222);
            this.minorDesc.TabIndex = 1;
            this.minorDesc.Text = "description goes here";
            // 
            // coursesList
            // 
            this.coursesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.coursesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.coursesList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(92)))));
            this.coursesList.FormattingEnabled = true;
            this.coursesList.ItemHeight = 22;
            this.coursesList.Location = new System.Drawing.Point(18, 325);
            this.coursesList.Name = "coursesList";
            this.coursesList.Size = new System.Drawing.Size(836, 198);
            this.coursesList.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Courses:";
            // 
            // MinorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1060, 547);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coursesList);
            this.Controls.Add(this.minorDesc);
            this.Controls.Add(this.minorLbl);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(127)))), ((int)(((byte)(196)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MinorDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minorLbl;
        private System.Windows.Forms.RichTextBox minorDesc;
        private System.Windows.Forms.ListBox coursesList;
        private System.Windows.Forms.Label label1;
    }
}