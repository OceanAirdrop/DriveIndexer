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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelTimeElapsed = new System.Windows.Forms.Label();
            this.labelCurrentDirectory = new System.Windows.Forms.Label();
            this.labelFileIndexCount = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDriveUserComment = new System.Windows.Forms.Label();
            this.labelDriveSize = new System.Windows.Forms.Label();
            this.labelDriveModel = new System.Windows.Forms.Label();
            this.labelDriveName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelDriveUserComment);
            this.panel1.Controls.Add(this.labelDriveSize);
            this.panel1.Controls.Add(this.labelDriveModel);
            this.panel1.Controls.Add(this.labelDriveName);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.labelTimeElapsed);
            this.panel1.Controls.Add(this.labelCurrentDirectory);
            this.panel1.Controls.Add(this.labelFileIndexCount);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 483);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(564, 446);
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
            this.labelTimeElapsed.Location = new System.Drawing.Point(11, 450);
            this.labelTimeElapsed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimeElapsed.Name = "labelTimeElapsed";
            this.labelTimeElapsed.Size = new System.Drawing.Size(113, 16);
            this.labelTimeElapsed.TabIndex = 106;
            this.labelTimeElapsed.Text = "Time Elapsed: ";
            // 
            // labelCurrentDirectory
            // 
            this.labelCurrentDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCurrentDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentDirectory.Location = new System.Drawing.Point(59, 154);
            this.labelCurrentDirectory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentDirectory.Name = "labelCurrentDirectory";
            this.labelCurrentDirectory.Size = new System.Drawing.Size(589, 31);
            this.labelCurrentDirectory.TabIndex = 105;
            this.labelCurrentDirectory.Text = "Scanning: ";
            // 
            // labelFileIndexCount
            // 
            this.labelFileIndexCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFileIndexCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileIndexCount.Location = new System.Drawing.Point(460, 410);
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
            this.listBox1.Location = new System.Drawing.Point(62, 206);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(586, 199);
            this.listBox1.TabIndex = 103;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(0, 119);
            this.label12.MaximumSize = new System.Drawing.Size(9800, 3);
            this.label12.MinimumSize = new System.Drawing.Size(300, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(673, 3);
            this.label12.TabIndex = 102;
            this.label12.Text = "111";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DriveIndexer.Properties.Resources.Search_24;
            this.pictureBox1.Location = new System.Drawing.Point(14, 154);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 29);
            this.pictureBox1.TabIndex = 100;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 115;
            this.label2.Text = "Comment:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 114;
            this.label3.Text = "Size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 113;
            this.label4.Text = "Model:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 112;
            this.label5.Text = "Name:";
            // 
            // labelDriveUserComment
            // 
            this.labelDriveUserComment.AutoSize = true;
            this.labelDriveUserComment.Location = new System.Drawing.Point(126, 84);
            this.labelDriveUserComment.Name = "labelDriveUserComment";
            this.labelDriveUserComment.Size = new System.Drawing.Size(98, 13);
            this.labelDriveUserComment.TabIndex = 111;
            this.labelDriveUserComment.Text = "DriveUserComment";
            // 
            // labelDriveSize
            // 
            this.labelDriveSize.AutoSize = true;
            this.labelDriveSize.Location = new System.Drawing.Point(126, 65);
            this.labelDriveSize.Name = "labelDriveSize";
            this.labelDriveSize.Size = new System.Drawing.Size(52, 13);
            this.labelDriveSize.TabIndex = 110;
            this.labelDriveSize.Text = "DriveSize";
            // 
            // labelDriveModel
            // 
            this.labelDriveModel.AutoSize = true;
            this.labelDriveModel.Location = new System.Drawing.Point(125, 42);
            this.labelDriveModel.Name = "labelDriveModel";
            this.labelDriveModel.Size = new System.Drawing.Size(61, 13);
            this.labelDriveModel.TabIndex = 109;
            this.labelDriveModel.Text = "DriveModel";
            // 
            // labelDriveName
            // 
            this.labelDriveName.AutoSize = true;
            this.labelDriveName.Location = new System.Drawing.Point(125, 19);
            this.labelDriveName.Name = "labelDriveName";
            this.labelDriveName.Size = new System.Drawing.Size(60, 13);
            this.labelDriveName.TabIndex = 108;
            this.labelDriveName.Text = "DriveName";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DriveIndexer.Properties.Resources.Text_24;
            this.pictureBox2.Location = new System.Drawing.Point(14, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 34);
            this.pictureBox2.TabIndex = 107;
            this.pictureBox2.TabStop = false;
            // 
            // IndexFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 483);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Label labelTimeElapsed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDriveUserComment;
        private System.Windows.Forms.Label labelDriveSize;
        private System.Windows.Forms.Label labelDriveModel;
        private System.Windows.Forms.Label labelDriveName;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}