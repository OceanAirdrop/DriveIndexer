namespace DriveIndexer
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDrives = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriveSerialNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriveModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InterfaceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Partitions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriveSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRefreshDriveInfo = new System.Windows.Forms.Button();
            this.buttonIndexFiles = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrives)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ready...";
            // 
            // dataGridViewDrives
            // 
            this.dataGridViewDrives.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDrives.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDrives.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.DriveSerialNum,
            this.DriveModel,
            this.InterfaceType,
            this.Partitions,
            this.DriveSize});
            this.dataGridViewDrives.Location = new System.Drawing.Point(13, 13);
            this.dataGridViewDrives.Name = "dataGridViewDrives";
            this.dataGridViewDrives.Size = new System.Drawing.Size(700, 358);
            this.dataGridViewDrives.TabIndex = 4;
            this.dataGridViewDrives.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDrives_CellClick);
            this.dataGridViewDrives.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDrives_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Description";
            this.Column1.Name = "Column1";
            // 
            // DriveSerialNum
            // 
            this.DriveSerialNum.HeaderText = "DriveSerial#";
            this.DriveSerialNum.Name = "DriveSerialNum";
            this.DriveSerialNum.Width = 120;
            // 
            // DriveModel
            // 
            this.DriveModel.HeaderText = "DriveModel";
            this.DriveModel.Name = "DriveModel";
            this.DriveModel.Width = 180;
            // 
            // InterfaceType
            // 
            this.InterfaceType.HeaderText = "Type";
            this.InterfaceType.Name = "InterfaceType";
            this.InterfaceType.Width = 50;
            // 
            // Partitions
            // 
            this.Partitions.HeaderText = "Partitions";
            this.Partitions.Name = "Partitions";
            this.Partitions.Width = 70;
            // 
            // DriveSize
            // 
            this.DriveSize.HeaderText = "DriveSize";
            this.DriveSize.Name = "DriveSize";
            // 
            // buttonRefreshDriveInfo
            // 
            this.buttonRefreshDriveInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefreshDriveInfo.Location = new System.Drawing.Point(719, 13);
            this.buttonRefreshDriveInfo.Name = "buttonRefreshDriveInfo";
            this.buttonRefreshDriveInfo.Size = new System.Drawing.Size(118, 50);
            this.buttonRefreshDriveInfo.TabIndex = 5;
            this.buttonRefreshDriveInfo.Text = "Refresh Drive Info";
            this.buttonRefreshDriveInfo.UseVisualStyleBackColor = true;
            this.buttonRefreshDriveInfo.Click += new System.EventHandler(this.buttonRefreshDriveInfo_Click);
            // 
            // buttonIndexFiles
            // 
            this.buttonIndexFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIndexFiles.Location = new System.Drawing.Point(719, 69);
            this.buttonIndexFiles.Name = "buttonIndexFiles";
            this.buttonIndexFiles.Size = new System.Drawing.Size(118, 53);
            this.buttonIndexFiles.TabIndex = 6;
            this.buttonIndexFiles.Text = "Index Files";
            this.buttonIndexFiles.UseVisualStyleBackColor = true;
            this.buttonIndexFiles.Click += new System.EventHandler(this.buttonIndexFiles_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(719, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 53);
            this.button1.TabIndex = 7;
            this.button1.Text = "Database Statistics";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(719, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 53);
            this.button2.TabIndex = 8;
            this.button2.Text = "FileType Blacklist / Whitelist";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 409);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonIndexFiles);
            this.Controls.Add(this.buttonRefreshDriveInfo);
            this.Controls.Add(this.dataGridViewDrives);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Drive Indexer - By Ocean Airdrop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrives)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDrives;
        private System.Windows.Forms.Button buttonRefreshDriveInfo;
        private System.Windows.Forms.Button buttonIndexFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriveSerialNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriveModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterfaceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partitions;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriveSize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

