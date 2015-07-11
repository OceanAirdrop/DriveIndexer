namespace DriveIndexer.Dialogs
{
    partial class FileTypeManagerForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Everything");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Documents");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Code");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Movies");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Music");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Games");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Pictures");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileTypeManagerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDelFileType = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonAddFileType = new System.Windows.Forms.Button();
            this.buttonDeleteFileGroup = new System.Windows.Forms.Button();
            this.buttonAddFileGroup = new System.Windows.Forms.Button();
            this.checkBoxEverything = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.treeViewFileTypes = new System.Windows.Forms.TreeView();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.buttonDelFileType);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.buttonAddFileType);
            this.panel1.Controls.Add(this.buttonDeleteFileGroup);
            this.panel1.Controls.Add(this.buttonAddFileGroup);
            this.panel1.Controls.Add(this.checkBoxEverything);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.treeViewFileTypes);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 366);
            this.panel1.TabIndex = 0;
            // 
            // buttonDelFileType
            // 
            this.buttonDelFileType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelFileType.Image = global::DriveIndexer.Properties.Resources.Button_Close_icon24;
            this.buttonDelFileType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelFileType.Location = new System.Drawing.Point(552, 187);
            this.buttonDelFileType.Name = "buttonDelFileType";
            this.buttonDelFileType.Size = new System.Drawing.Size(112, 34);
            this.buttonDelFileType.TabIndex = 104;
            this.buttonDelFileType.Text = "Del FileType";
            this.buttonDelFileType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelFileType.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(0, 42);
            this.label12.MaximumSize = new System.Drawing.Size(9800, 3);
            this.label12.MinimumSize = new System.Drawing.Size(300, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(676, 3);
            this.label12.TabIndex = 103;
            this.label12.Text = "111";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(581, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "User Actions";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::DriveIndexer.Properties.Resources.application_32;
            this.pictureBox3.Location = new System.Drawing.Point(552, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 33);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "File Types";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DriveIndexer.Properties.Resources.filetype_24;
            this.pictureBox1.Location = new System.Drawing.Point(151, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 33);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "File Groups";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DriveIndexer.Properties.Resources.fileviewer_24;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 33);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // buttonAddFileType
            // 
            this.buttonAddFileType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddFileType.Image = global::DriveIndexer.Properties.Resources.Button_Add_icon24;
            this.buttonAddFileType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddFileType.Location = new System.Drawing.Point(552, 146);
            this.buttonAddFileType.Name = "buttonAddFileType";
            this.buttonAddFileType.Size = new System.Drawing.Size(112, 34);
            this.buttonAddFileType.TabIndex = 16;
            this.buttonAddFileType.Text = "Add FileType";
            this.buttonAddFileType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddFileType.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteFileGroup
            // 
            this.buttonDeleteFileGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteFileGroup.Image = global::DriveIndexer.Properties.Resources.folder_delete_icon_24;
            this.buttonDeleteFileGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeleteFileGroup.Location = new System.Drawing.Point(552, 91);
            this.buttonDeleteFileGroup.Name = "buttonDeleteFileGroup";
            this.buttonDeleteFileGroup.Size = new System.Drawing.Size(112, 34);
            this.buttonDeleteFileGroup.TabIndex = 15;
            this.buttonDeleteFileGroup.Text = "Del File Group";
            this.buttonDeleteFileGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDeleteFileGroup.UseVisualStyleBackColor = true;
            // 
            // buttonAddFileGroup
            // 
            this.buttonAddFileGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddFileGroup.Image = global::DriveIndexer.Properties.Resources.folder_add_icon_24;
            this.buttonAddFileGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddFileGroup.Location = new System.Drawing.Point(552, 51);
            this.buttonAddFileGroup.Name = "buttonAddFileGroup";
            this.buttonAddFileGroup.Size = new System.Drawing.Size(112, 34);
            this.buttonAddFileGroup.TabIndex = 14;
            this.buttonAddFileGroup.Text = "Add File Group";
            this.buttonAddFileGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddFileGroup.UseVisualStyleBackColor = true;
            // 
            // checkBoxEverything
            // 
            this.checkBoxEverything.AllowDrop = true;
            this.checkBoxEverything.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxEverything.AutoSize = true;
            this.checkBoxEverything.Location = new System.Drawing.Point(151, 333);
            this.checkBoxEverything.Name = "checkBoxEverything";
            this.checkBoxEverything.Size = new System.Drawing.Size(114, 17);
            this.checkBoxEverything.TabIndex = 11;
            this.checkBoxEverything.Text = "Include Everything";
            this.checkBoxEverything.UseVisualStyleBackColor = true;
            this.checkBoxEverything.CheckedChanged += new System.EventHandler(this.checkBoxEverything_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(152, 51);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(390, 266);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // treeViewFileTypes
            // 
            this.treeViewFileTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewFileTypes.Location = new System.Drawing.Point(12, 51);
            this.treeViewFileTypes.Name = "treeViewFileTypes";
            treeNode1.Name = "Everything";
            treeNode1.Text = "Everything";
            treeNode2.Name = "Documents";
            treeNode2.Text = "Documents";
            treeNode3.Name = "Code";
            treeNode3.Text = "Code";
            treeNode4.Name = "Movies";
            treeNode4.Text = "Movies";
            treeNode5.Name = "Music";
            treeNode5.Text = "Music";
            treeNode6.Name = "Games";
            treeNode6.Text = "Games";
            treeNode7.Name = "Pictures";
            treeNode7.Text = "Pictures";
            this.treeViewFileTypes.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            this.treeViewFileTypes.Size = new System.Drawing.Size(127, 236);
            this.treeViewFileTypes.TabIndex = 2;
            this.treeViewFileTypes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewFileTypes_AfterSelect);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(589, 329);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(508, 329);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // FileTypeManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 366);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FileTypeManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "File Type Manager";
            this.Load += new System.EventHandler(this.FileTypeManagerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TreeView treeViewFileTypes;
        private System.Windows.Forms.CheckBox checkBoxEverything;
        private System.Windows.Forms.Button buttonAddFileType;
        private System.Windows.Forms.Button buttonDeleteFileGroup;
        private System.Windows.Forms.Button buttonAddFileGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonDelFileType;
    }
}