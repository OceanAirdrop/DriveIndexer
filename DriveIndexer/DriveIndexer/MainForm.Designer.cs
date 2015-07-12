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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewDrives = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxHelp = new System.Windows.Forms.PictureBox();
            this.buttonFileSearch = new System.Windows.Forms.Button();
            this.buttonFileViewer = new System.Windows.Forms.Button();
            this.buttonRefreshDriveInfo = new System.Windows.Forms.Button();
            this.buttonFileTypes = new System.Windows.Forms.Button();
            this.buttonIndexFiles = new System.Windows.Forms.Button();
            this.buttonDatabaseStatistics = new System.Windows.Forms.Button();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.DriveName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriveSerialNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriveModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InterfaceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Partitions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DriveSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrives)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 345);
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
            this.Column2,
            this.DriveName,
            this.Column1,
            this.DriveSerialNum,
            this.DriveModel,
            this.InterfaceType,
            this.Partitions,
            this.DriveSize,
            this.Column3});
            this.dataGridViewDrives.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewDrives.Name = "dataGridViewDrives";
            this.dataGridViewDrives.Size = new System.Drawing.Size(599, 319);
            this.dataGridViewDrives.TabIndex = 4;
            this.dataGridViewDrives.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDrives_CellClick);
            this.dataGridViewDrives.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDrives_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBoxHelp);
            this.panel1.Controls.Add(this.buttonFileSearch);
            this.panel1.Controls.Add(this.dataGridViewDrives);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonFileViewer);
            this.panel1.Controls.Add(this.buttonRefreshDriveInfo);
            this.panel1.Controls.Add(this.buttonFileTypes);
            this.panel1.Controls.Add(this.buttonIndexFiles);
            this.panel1.Controls.Add(this.buttonDatabaseStatistics);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 367);
            this.panel1.TabIndex = 10;
            // 
            // pictureBoxHelp
            // 
            this.pictureBoxHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxHelp.Image = global::DriveIndexer.Properties.Resources.help16;
            this.pictureBoxHelp.Location = new System.Drawing.Point(736, 344);
            this.pictureBoxHelp.Name = "pictureBoxHelp";
            this.pictureBoxHelp.Size = new System.Drawing.Size(23, 20);
            this.pictureBoxHelp.TabIndex = 12;
            this.pictureBoxHelp.TabStop = false;
            this.pictureBoxHelp.Click += new System.EventHandler(this.pictureBoxHelp_Click);
            // 
            // buttonFileSearch
            // 
            this.buttonFileSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFileSearch.Image = global::DriveIndexer.Properties.Resources.Search_24;
            this.buttonFileSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFileSearch.Location = new System.Drawing.Point(617, 257);
            this.buttonFileSearch.Name = "buttonFileSearch";
            this.buttonFileSearch.Size = new System.Drawing.Size(134, 43);
            this.buttonFileSearch.TabIndex = 11;
            this.buttonFileSearch.Text = "File Search";
            this.buttonFileSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFileSearch.UseVisualStyleBackColor = true;
            this.buttonFileSearch.Click += new System.EventHandler(this.buttonFileSearch_Click);
            // 
            // buttonFileViewer
            // 
            this.buttonFileViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFileViewer.Image = global::DriveIndexer.Properties.Resources.fileviewer_24;
            this.buttonFileViewer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFileViewer.Location = new System.Drawing.Point(617, 208);
            this.buttonFileViewer.Name = "buttonFileViewer";
            this.buttonFileViewer.Size = new System.Drawing.Size(134, 43);
            this.buttonFileViewer.TabIndex = 9;
            this.buttonFileViewer.Text = "File Viewer";
            this.buttonFileViewer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFileViewer.UseVisualStyleBackColor = true;
            this.buttonFileViewer.Click += new System.EventHandler(this.buttonFileViewer_Click);
            // 
            // buttonRefreshDriveInfo
            // 
            this.buttonRefreshDriveInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefreshDriveInfo.Image = global::DriveIndexer.Properties.Resources.refresh2_24;
            this.buttonRefreshDriveInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefreshDriveInfo.Location = new System.Drawing.Point(617, 12);
            this.buttonRefreshDriveInfo.Name = "buttonRefreshDriveInfo";
            this.buttonRefreshDriveInfo.Size = new System.Drawing.Size(134, 43);
            this.buttonRefreshDriveInfo.TabIndex = 5;
            this.buttonRefreshDriveInfo.Text = "Refresh Drive Info";
            this.buttonRefreshDriveInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRefreshDriveInfo.UseVisualStyleBackColor = true;
            this.buttonRefreshDriveInfo.Click += new System.EventHandler(this.buttonRefreshDriveInfo_Click);
            // 
            // buttonFileTypes
            // 
            this.buttonFileTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFileTypes.Image = global::DriveIndexer.Properties.Resources.filetype_24;
            this.buttonFileTypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFileTypes.Location = new System.Drawing.Point(617, 159);
            this.buttonFileTypes.Name = "buttonFileTypes";
            this.buttonFileTypes.Size = new System.Drawing.Size(134, 43);
            this.buttonFileTypes.TabIndex = 8;
            this.buttonFileTypes.Text = "FileType Manager";
            this.buttonFileTypes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonFileTypes.UseVisualStyleBackColor = true;
            this.buttonFileTypes.Click += new System.EventHandler(this.buttonFileTypes_Click);
            // 
            // buttonIndexFiles
            // 
            this.buttonIndexFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonIndexFiles.Image = global::DriveIndexer.Properties.Resources.application_32;
            this.buttonIndexFiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonIndexFiles.Location = new System.Drawing.Point(617, 61);
            this.buttonIndexFiles.Name = "buttonIndexFiles";
            this.buttonIndexFiles.Size = new System.Drawing.Size(134, 43);
            this.buttonIndexFiles.TabIndex = 6;
            this.buttonIndexFiles.Text = "Scan Drive";
            this.buttonIndexFiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonIndexFiles.UseVisualStyleBackColor = true;
            this.buttonIndexFiles.Click += new System.EventHandler(this.buttonIndexFiles_Click);
            // 
            // buttonDatabaseStatistics
            // 
            this.buttonDatabaseStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDatabaseStatistics.Image = global::DriveIndexer.Properties.Resources.statistics2_24;
            this.buttonDatabaseStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDatabaseStatistics.Location = new System.Drawing.Point(617, 110);
            this.buttonDatabaseStatistics.Name = "buttonDatabaseStatistics";
            this.buttonDatabaseStatistics.Size = new System.Drawing.Size(134, 43);
            this.buttonDatabaseStatistics.TabIndex = 7;
            this.buttonDatabaseStatistics.Text = "File Statistics";
            this.buttonDatabaseStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDatabaseStatistics.UseVisualStyleBackColor = true;
            this.buttonDatabaseStatistics.Click += new System.EventHandler(this.buttonDatabaseStatistics_Click);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DriveScanned";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DriveName
            // 
            this.DriveName.HeaderText = "Name";
            this.DriveName.Name = "DriveName";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Description";
            this.Column1.Name = "Column1";
            // 
            // DriveSerialNum
            // 
            this.DriveSerialNum.HeaderText = "DriveSerial";
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
            // Column3
            // 
            this.Column3.HeaderText = "DriveScannedDate";
            this.Column3.Name = "Column3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 367);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Drive Indexer - By Ocean Airdrop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrives)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDrives;
        private System.Windows.Forms.Button buttonRefreshDriveInfo;
        private System.Windows.Forms.Button buttonIndexFiles;
        private System.Windows.Forms.Button buttonDatabaseStatistics;
        private System.Windows.Forms.Button buttonFileTypes;
        private System.Windows.Forms.Button buttonFileViewer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonFileSearch;
        private System.Windows.Forms.PictureBox pictureBoxHelp;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriveName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriveSerialNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriveModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterfaceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Partitions;
        private System.Windows.Forms.DataGridViewTextBoxColumn DriveSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

