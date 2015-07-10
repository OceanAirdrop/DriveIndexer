namespace DriveIndexer.Dialogs
{
    partial class IndexFilesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexFilesForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDriveLabel = new System.Windows.Forms.Label();
            this.labelCurrentDirectory = new System.Windows.Forms.Label();
            this.labelFileIndexCount = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelTimeElapsed = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.labelTimeElapsed);
            this.panel1.Controls.Add(this.labelDriveLabel);
            this.panel1.Controls.Add(this.labelCurrentDirectory);
            this.panel1.Controls.Add(this.labelFileIndexCount);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 377);
            this.panel1.TabIndex = 0;
            // 
            // labelDriveLabel
            // 
            this.labelDriveLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDriveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDriveLabel.ForeColor = System.Drawing.Color.Black;
            this.labelDriveLabel.Location = new System.Drawing.Point(54, 13);
            this.labelDriveLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDriveLabel.Name = "labelDriveLabel";
            this.labelDriveLabel.Size = new System.Drawing.Size(310, 20);
            this.labelDriveLabel.TabIndex = 106;
            this.labelDriveLabel.Text = "Drive Name";
            // 
            // labelCurrentDirectory
            // 
            this.labelCurrentDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrentDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentDirectory.Location = new System.Drawing.Point(7, 52);
            this.labelCurrentDirectory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentDirectory.Name = "labelCurrentDirectory";
            this.labelCurrentDirectory.Size = new System.Drawing.Size(357, 31);
            this.labelCurrentDirectory.TabIndex = 105;
            this.labelCurrentDirectory.Text = "Scanning: ";
            // 
            // labelFileIndexCount
            // 
            this.labelFileIndexCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFileIndexCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileIndexCount.Location = new System.Drawing.Point(171, 304);
            this.labelFileIndexCount.Name = "labelFileIndexCount";
            this.labelFileIndexCount.Size = new System.Drawing.Size(195, 13);
            this.labelFileIndexCount.TabIndex = 104;
            this.labelFileIndexCount.Text = "File Index Count: 0";
            this.labelFileIndexCount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(357, 199);
            this.listBox1.TabIndex = 103;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(55, 42);
            this.label12.MaximumSize = new System.Drawing.Size(9800, 3);
            this.label12.MinimumSize = new System.Drawing.Size(300, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(311, 3);
            this.label12.TabIndex = 102;
            this.label12.Text = "111";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DriveIndexer.Properties.Resources.scan_drive_24;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 29);
            this.pictureBox1.TabIndex = 100;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(275, 340);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(89, 25);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel Scan";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelTimeElapsed
            // 
            this.labelTimeElapsed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTimeElapsed.AutoSize = true;
            this.labelTimeElapsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeElapsed.Location = new System.Drawing.Point(11, 344);
            this.labelTimeElapsed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimeElapsed.Name = "labelTimeElapsed";
            this.labelTimeElapsed.Size = new System.Drawing.Size(113, 16);
            this.labelTimeElapsed.TabIndex = 106;
            this.labelTimeElapsed.Text = "Time Elapsed: ";
            // 
            // IndexFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 377);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IndexFilesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Index Fles";
            this.Load += new System.EventHandler(this.IndexFilesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelFileIndexCount;
        private System.Windows.Forms.Label labelCurrentDirectory;
        private System.Windows.Forms.Label labelDriveLabel;
        private System.Windows.Forms.Label labelTimeElapsed;
    }
}