namespace TimeShiftSRT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.cmdFileBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtShift = new System.Windows.Forms.TextBox();
            this.cmdShift = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chkBackup = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "File";
            // 
            // txtFilename
            // 
            this.txtFilename.AllowDrop = true;
            this.txtFilename.Location = new System.Drawing.Point(92, 14);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(434, 23);
            this.txtFilename.TabIndex = 1;
            this.txtFilename.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtFilename_DragDrop);
            this.txtFilename.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtFilename_DragEnter);
            // 
            // cmdFileBrowse
            // 
            this.cmdFileBrowse.Location = new System.Drawing.Point(532, 16);
            this.cmdFileBrowse.Name = "cmdFileBrowse";
            this.cmdFileBrowse.Size = new System.Drawing.Size(27, 23);
            this.cmdFileBrowse.TabIndex = 2;
            this.cmdFileBrowse.Text = "...";
            this.cmdFileBrowse.UseVisualStyleBackColor = true;
            this.cmdFileBrowse.Click += new System.EventHandler(this.cmdFileBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time Shift (s)";
            // 
            // txtShift
            // 
            this.txtShift.Location = new System.Drawing.Point(92, 59);
            this.txtShift.Name = "txtShift";
            this.txtShift.Size = new System.Drawing.Size(59, 23);
            this.txtShift.TabIndex = 4;
            // 
            // cmdShift
            // 
            this.cmdShift.Location = new System.Drawing.Point(169, 58);
            this.cmdShift.Name = "cmdShift";
            this.cmdShift.Size = new System.Drawing.Size(75, 23);
            this.cmdShift.TabIndex = 5;
            this.cmdShift.Text = "Shift";
            this.cmdShift.UseVisualStyleBackColor = true;
            this.cmdShift.Click += new System.EventHandler(this.cmdShift_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // chkBackup
            // 
            this.chkBackup.AutoSize = true;
            this.chkBackup.Location = new System.Drawing.Point(443, 61);
            this.chkBackup.Name = "chkBackup";
            this.chkBackup.Size = new System.Drawing.Size(97, 19);
            this.chkBackup.TabIndex = 6;
            this.chkBackup.Text = "Make backup";
            this.chkBackup.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 136);
            this.Controls.Add(this.chkBackup);
            this.Controls.Add(this.cmdShift);
            this.Controls.Add(this.txtShift);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdFileBrowse);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtFilename;
        private Button cmdFileBrowse;
        private Label label2;
        private TextBox txtShift;
        private Button cmdShift;
        private OpenFileDialog openFileDialog1;
        private CheckBox chkBackup;
    }
}