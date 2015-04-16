namespace ResourceViewer {
	partial class DiffViewer {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiffViewer));
			this.listview_Main = new System.Windows.Forms.ListView();
			this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.FileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.FileType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.AssetFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolstrip_ExtractOriginal = new System.Windows.Forms.ToolStripMenuItem();
			this.toolstrip_ExtractNew = new System.Windows.Forms.ToolStripMenuItem();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.button_LoadFile1 = new System.Windows.Forms.Button();
			this.button_LoadFile2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
			this.checkbox_Unchanged = new System.Windows.Forms.CheckBox();
			this.checkbox_Changed = new System.Windows.Forms.CheckBox();
			this.checkbox_Added = new System.Windows.Forms.CheckBox();
			this.checkbox_Removed = new System.Windows.Forms.CheckBox();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listview_Main
			// 
			this.listview_Main.AllowColumnReorder = true;
			this.listview_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listview_Main.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.FileSize,
            this.FileType,
            this.AssetFile});
			this.listview_Main.ContextMenuStrip = this.contextMenuStrip1;
			this.listview_Main.FullRowSelect = true;
			this.listview_Main.GridLines = true;
			this.listview_Main.HideSelection = false;
			this.listview_Main.Location = new System.Drawing.Point(12, 93);
			this.listview_Main.Name = "listview_Main";
			this.listview_Main.Size = new System.Drawing.Size(489, 437);
			this.listview_Main.SmallImageList = this.imageList1;
			this.listview_Main.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listview_Main.TabIndex = 5;
			this.listview_Main.UseCompatibleStateImageBehavior = false;
			this.listview_Main.View = System.Windows.Forms.View.Details;
			this.listview_Main.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listview_Main_ColumnClick);
			this.listview_Main.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listview_Main_ItemSelectionChanged);
			// 
			// FileName
			// 
			this.FileName.Text = "File Name";
			this.FileName.Width = 219;
			// 
			// FileSize
			// 
			this.FileSize.Text = "File Size";
			this.FileSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.FileSize.Width = 78;
			// 
			// FileType
			// 
			this.FileType.Text = "File Type";
			// 
			// AssetFile
			// 
			this.AssetFile.Text = "Asset File";
			this.AssetFile.Width = 120;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrip_ExtractOriginal,
            this.toolstrip_ExtractNew});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(205, 48);
			// 
			// toolstrip_ExtractOriginal
			// 
			this.toolstrip_ExtractOriginal.Name = "toolstrip_ExtractOriginal";
			this.toolstrip_ExtractOriginal.Size = new System.Drawing.Size(204, 22);
			this.toolstrip_ExtractOriginal.Text = "Extract from &Original File";
			this.toolstrip_ExtractOriginal.Click += new System.EventHandler(this.toolstrip_ExtractOriginal_Click);
			// 
			// toolstrip_ExtractNew
			// 
			this.toolstrip_ExtractNew.Name = "toolstrip_ExtractNew";
			this.toolstrip_ExtractNew.Size = new System.Drawing.Size(204, 22);
			this.toolstrip_ExtractNew.Text = "Extract from &New File";
			this.toolstrip_ExtractNew.Click += new System.EventHandler(this.toolstrip_ExtractNew_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "same");
			this.imageList1.Images.SetKeyName(1, "changed");
			this.imageList1.Images.SetKeyName(2, "added");
			this.imageList1.Images.SetKeyName(3, "removed");
			// 
			// button_LoadFile1
			// 
			this.button_LoadFile1.Location = new System.Drawing.Point(12, 10);
			this.button_LoadFile1.Name = "button_LoadFile1";
			this.button_LoadFile1.Size = new System.Drawing.Size(101, 23);
			this.button_LoadFile1.TabIndex = 6;
			this.button_LoadFile1.Text = "Load &Original File";
			this.button_LoadFile1.UseVisualStyleBackColor = true;
			this.button_LoadFile1.Click += new System.EventHandler(this.button_LoadFile1_Click);
			// 
			// button_LoadFile2
			// 
			this.button_LoadFile2.Location = new System.Drawing.Point(12, 40);
			this.button_LoadFile2.Name = "button_LoadFile2";
			this.button_LoadFile2.Size = new System.Drawing.Size(101, 23);
			this.button_LoadFile2.TabIndex = 7;
			this.button_LoadFile2.Text = "Load &New File";
			this.button_LoadFile2.UseVisualStyleBackColor = true;
			this.button_LoadFile2.Click += new System.EventHandler(this.button_LoadFile2_Click);
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.BackColor = System.Drawing.SystemColors.Window;
			this.textBox1.Location = new System.Drawing.Point(119, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(382, 20);
			this.textBox1.TabIndex = 8;
			// 
			// textBox2
			// 
			this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox2.BackColor = System.Drawing.SystemColors.Window;
			this.textBox2.Location = new System.Drawing.Point(119, 42);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(382, 20);
			this.textBox2.TabIndex = 9;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "Asset File";
			this.openFileDialog1.Filter = "Pack Files|*.pack";
			this.openFileDialog1.RestoreDirectory = true;
			// 
			// openFileDialog2
			// 
			this.openFileDialog2.FileName = "Asset File";
			this.openFileDialog2.Filter = "Pack Files|*.pack";
			this.openFileDialog2.RestoreDirectory = true;
			// 
			// checkbox_Unchanged
			// 
			this.checkbox_Unchanged.AutoSize = true;
			this.checkbox_Unchanged.Checked = true;
			this.checkbox_Unchanged.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkbox_Unchanged.Location = new System.Drawing.Point(13, 70);
			this.checkbox_Unchanged.Name = "checkbox_Unchanged";
			this.checkbox_Unchanged.Size = new System.Drawing.Size(112, 17);
			this.checkbox_Unchanged.TabIndex = 10;
			this.checkbox_Unchanged.Text = "Show &Unchanged";
			this.checkbox_Unchanged.UseVisualStyleBackColor = true;
			this.checkbox_Unchanged.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
			// 
			// checkbox_Changed
			// 
			this.checkbox_Changed.AutoSize = true;
			this.checkbox_Changed.Checked = true;
			this.checkbox_Changed.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkbox_Changed.Location = new System.Drawing.Point(132, 70);
			this.checkbox_Changed.Name = "checkbox_Changed";
			this.checkbox_Changed.Size = new System.Drawing.Size(99, 17);
			this.checkbox_Changed.TabIndex = 11;
			this.checkbox_Changed.Text = "Show &Changed";
			this.checkbox_Changed.UseVisualStyleBackColor = true;
			this.checkbox_Changed.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
			// 
			// checkbox_Added
			// 
			this.checkbox_Added.AutoSize = true;
			this.checkbox_Added.Checked = true;
			this.checkbox_Added.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkbox_Added.Location = new System.Drawing.Point(237, 70);
			this.checkbox_Added.Name = "checkbox_Added";
			this.checkbox_Added.Size = new System.Drawing.Size(87, 17);
			this.checkbox_Added.TabIndex = 12;
			this.checkbox_Added.Text = "Show &Added";
			this.checkbox_Added.UseVisualStyleBackColor = true;
			this.checkbox_Added.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
			// 
			// checkbox_Removed
			// 
			this.checkbox_Removed.AutoSize = true;
			this.checkbox_Removed.Checked = true;
			this.checkbox_Removed.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkbox_Removed.Location = new System.Drawing.Point(330, 70);
			this.checkbox_Removed.Name = "checkbox_Removed";
			this.checkbox_Removed.Size = new System.Drawing.Size(102, 17);
			this.checkbox_Removed.TabIndex = 13;
			this.checkbox_Removed.Text = "Show &Removed";
			this.checkbox_Removed.UseVisualStyleBackColor = true;
			this.checkbox_Removed.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
			// 
			// DiffViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(513, 542);
			this.Controls.Add(this.checkbox_Removed);
			this.Controls.Add(this.checkbox_Added);
			this.Controls.Add(this.checkbox_Changed);
			this.Controls.Add(this.checkbox_Unchanged);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button_LoadFile2);
			this.Controls.Add(this.button_LoadFile1);
			this.Controls.Add(this.listview_Main);
			this.MinimumSize = new System.Drawing.Size(520, 580);
			this.Name = "DiffViewer";
			this.Text = ".Pack Diff Viewer";
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listview_Main;
		private System.Windows.Forms.ColumnHeader FileName;
		private System.Windows.Forms.ColumnHeader FileSize;
		private System.Windows.Forms.ColumnHeader FileType;
		private System.Windows.Forms.ColumnHeader AssetFile;
		private System.Windows.Forms.Button button_LoadFile1;
		private System.Windows.Forms.Button button_LoadFile2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog2;
		private System.Windows.Forms.CheckBox checkbox_Unchanged;
		private System.Windows.Forms.CheckBox checkbox_Changed;
		private System.Windows.Forms.CheckBox checkbox_Added;
		private System.Windows.Forms.CheckBox checkbox_Removed;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolstrip_ExtractOriginal;
		private System.Windows.Forms.ToolStripMenuItem toolstrip_ExtractNew;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
	}
}