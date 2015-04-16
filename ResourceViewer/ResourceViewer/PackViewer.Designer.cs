namespace ResourceViewer
{
    partial class PackViewer
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackViewer));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolstrip_Open = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolstrip_ExportAll = new System.Windows.Forms.ToolStripMenuItem();
			this.toolstrip_ExtractList = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewDiffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.listview_Main = new System.Windows.Forms.ListView();
			this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.FileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.FileType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.AssetFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.listview_MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.listviewmain_MenuExtract = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.progressbar_Main = new System.Windows.Forms.ToolStripProgressBar();
			this.statuslabel_Main = new System.Windows.Forms.ToolStripStatusLabel();
			this.label_SearchResults = new System.Windows.Forms.ToolStripStatusLabel();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.textbox_Search = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
			this.search_MenuUseRegex = new System.Windows.Forms.ToolStripMenuItem();
			this.listview_Search = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.search_MenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.listviewsearch_MenuExtract = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.listview_MenuStrip.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.search_MenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(812, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrip_Open,
            this.toolStripSeparator1,
            this.toolstrip_ExportAll,
            this.toolstrip_ExtractList});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// toolstrip_Open
			// 
			this.toolstrip_Open.Name = "toolstrip_Open";
			this.toolstrip_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.toolstrip_Open.Size = new System.Drawing.Size(164, 22);
			this.toolstrip_Open.Text = "&Open";
			this.toolstrip_Open.ToolTipText = "Open the .pack file";
			this.toolstrip_Open.Click += new System.EventHandler(this.openpackToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
			// 
			// toolstrip_ExportAll
			// 
			this.toolstrip_ExportAll.Name = "toolstrip_ExportAll";
			this.toolstrip_ExportAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.toolstrip_ExportAll.Size = new System.Drawing.Size(164, 22);
			this.toolstrip_ExportAll.Text = "Export &All";
			this.toolstrip_ExportAll.Click += new System.EventHandler(this.exportToolStripMenuItem1_Click);
			// 
			// toolstrip_ExtractList
			// 
			this.toolstrip_ExtractList.Name = "toolstrip_ExtractList";
			this.toolstrip_ExtractList.Size = new System.Drawing.Size(164, 22);
			this.toolstrip_ExtractList.Text = "Export File &List";
			this.toolstrip_ExtractList.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDiffToolStripMenuItem,
            this.searchToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.optionsToolStripMenuItem.Text = "&Options";
			// 
			// viewDiffToolStripMenuItem
			// 
			this.viewDiffToolStripMenuItem.Name = "viewDiffToolStripMenuItem";
			this.viewDiffToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
			this.viewDiffToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.viewDiffToolStripMenuItem.Text = "&Diff Viewer";
			this.viewDiffToolStripMenuItem.Click += new System.EventHandler(this.viewDiffToolStripMenuItem_Click);
			// 
			// searchToolStripMenuItem
			// 
			this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
			this.searchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.searchToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.searchToolStripMenuItem.Text = "&Search";
			this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.aboutToolStripMenuItem.Text = "&About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "Asset File";
			this.openFileDialog1.Filter = "Pack Files|*.pack";
			this.openFileDialog1.Multiselect = true;
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
			this.listview_Main.ContextMenuStrip = this.listview_MenuStrip;
			this.listview_Main.FullRowSelect = true;
			this.listview_Main.GridLines = true;
			this.listview_Main.HideSelection = false;
			this.listview_Main.Location = new System.Drawing.Point(0, 0);
			this.listview_Main.Name = "listview_Main";
			this.listview_Main.Size = new System.Drawing.Size(812, 220);
			this.listview_Main.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listview_Main.TabIndex = 4;
			this.listview_Main.UseCompatibleStateImageBehavior = false;
			this.listview_Main.View = System.Windows.Forms.View.Details;
			this.listview_Main.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listview_Main_ColumnClick);
			this.listview_Main.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
			// 
			// FileName
			// 
			this.FileName.Text = "File Name";
			this.FileName.Width = 541;
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
			// listview_MenuStrip
			// 
			this.listview_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listviewmain_MenuExtract});
			this.listview_MenuStrip.Name = "listview_MenuStrip";
			this.listview_MenuStrip.Size = new System.Drawing.Size(157, 26);
			// 
			// listviewmain_MenuExtract
			// 
			this.listviewmain_MenuExtract.Name = "listviewmain_MenuExtract";
			this.listviewmain_MenuExtract.Size = new System.Drawing.Size(156, 22);
			this.listviewmain_MenuExtract.Text = "E&xtract Selected";
			this.listviewmain_MenuExtract.Click += new System.EventHandler(this.listviewmain_MenuExtract_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressbar_Main,
            this.statuslabel_Main,
            this.label_SearchResults});
			this.statusStrip1.Location = new System.Drawing.Point(0, 455);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(812, 22);
			this.statusStrip1.TabIndex = 5;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// progressbar_Main
			// 
			this.progressbar_Main.Name = "progressbar_Main";
			this.progressbar_Main.Size = new System.Drawing.Size(100, 16);
			this.progressbar_Main.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressbar_Main.Visible = false;
			// 
			// statuslabel_Main
			// 
			this.statuslabel_Main.Name = "statuslabel_Main";
			this.statuslabel_Main.Size = new System.Drawing.Size(0, 17);
			this.statuslabel_Main.Visible = false;
			// 
			// label_SearchResults
			// 
			this.label_SearchResults.Name = "label_SearchResults";
			this.label_SearchResults.Size = new System.Drawing.Size(0, 17);
			this.label_SearchResults.Visible = false;
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "txt";
			this.saveFileDialog1.FileName = "FilesList";
			this.saveFileDialog1.Filter = "Text Files|*.txt";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 24);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.listview_Main);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
			this.splitContainer1.Panel2.Controls.Add(this.listview_Search);
			this.splitContainer1.Size = new System.Drawing.Size(812, 431);
			this.splitContainer1.SplitterDistance = 220;
			this.splitContainer1.SplitterWidth = 10;
			this.splitContainer1.TabIndex = 7;
			// 
			// toolStrip1
			// 
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.textbox_Search,
            this.toolStripButton1,
            this.toolStripSplitButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(812, 25);
			this.toolStrip1.TabIndex = 6;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.BackColor = System.Drawing.Color.Transparent;
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(68, 22);
			this.toolStripLabel1.Text = "Search For: ";
			// 
			// textbox_Search
			// 
			this.textbox_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textbox_Search.Name = "textbox_Search";
			this.textbox_Search.Size = new System.Drawing.Size(400, 25);
			this.textbox_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_Search_KeyPress);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "Close Search Panel";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripSplitButton1
			// 
			this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.search_MenuUseRegex});
			this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
			this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripSplitButton1.Name = "toolStripSplitButton1";
			this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
			this.toolStripSplitButton1.Text = "Search";
			this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripButton2_Click);
			// 
			// search_MenuUseRegex
			// 
			this.search_MenuUseRegex.CheckOnClick = true;
			this.search_MenuUseRegex.Image = ((System.Drawing.Image)(resources.GetObject("search_MenuUseRegex.Image")));
			this.search_MenuUseRegex.Name = "search_MenuUseRegex";
			this.search_MenuUseRegex.Size = new System.Drawing.Size(127, 22);
			this.search_MenuUseRegex.Text = "Use &Regex";
			// 
			// listview_Search
			// 
			this.listview_Search.AllowColumnReorder = true;
			this.listview_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listview_Search.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.listview_Search.ContextMenuStrip = this.search_MenuStrip;
			this.listview_Search.FullRowSelect = true;
			this.listview_Search.GridLines = true;
			this.listview_Search.HideSelection = false;
			this.listview_Search.Location = new System.Drawing.Point(0, 28);
			this.listview_Search.Name = "listview_Search";
			this.listview_Search.Size = new System.Drawing.Size(812, 145);
			this.listview_Search.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listview_Search.TabIndex = 5;
			this.listview_Search.UseCompatibleStateImageBehavior = false;
			this.listview_Search.View = System.Windows.Forms.View.Details;
			this.listview_Search.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listview_Search_ColumnClick);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "File Name";
			this.columnHeader1.Width = 541;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "File Size";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.columnHeader2.Width = 78;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "File Type";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Asset File";
			this.columnHeader4.Width = 120;
			// 
			// search_MenuStrip
			// 
			this.search_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listviewsearch_MenuExtract});
			this.search_MenuStrip.Name = "listview_MenuStrip";
			this.search_MenuStrip.Size = new System.Drawing.Size(157, 26);
			// 
			// listviewsearch_MenuExtract
			// 
			this.listviewsearch_MenuExtract.Name = "listviewsearch_MenuExtract";
			this.listviewsearch_MenuExtract.Size = new System.Drawing.Size(156, 22);
			this.listviewsearch_MenuExtract.Text = "E&xtract Selected";
			this.listviewsearch_MenuExtract.Click += new System.EventHandler(this.listviewsearch_MenuExtract_Click);
			// 
			// PackViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(812, 477);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MinimumSize = new System.Drawing.Size(545, 515);
			this.Name = "PackViewer";
			this.Text = ".Pack Viewer";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.listview_MenuStrip.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.search_MenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolstrip_Open;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolstrip_ExportAll;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem viewDiffToolStripMenuItem;
        private System.Windows.Forms.ListView listview_Main;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader FileSize;
		private System.Windows.Forms.ColumnHeader FileType;
		private System.Windows.Forms.ColumnHeader AssetFile;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripProgressBar progressbar_Main;
		private System.Windows.Forms.ToolStripMenuItem toolstrip_ExtractList;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ContextMenuStrip listview_MenuStrip;
		private System.Windows.Forms.ToolStripMenuItem listviewmain_MenuExtract;
		private System.Windows.Forms.ToolStripStatusLabel statuslabel_Main;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListView listview_Search;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripTextBox textbox_Search;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip search_MenuStrip;
		private System.Windows.Forms.ToolStripMenuItem listviewsearch_MenuExtract;
		private System.Windows.Forms.ToolStripStatusLabel label_SearchResults;
		private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
		private System.Windows.Forms.ToolStripMenuItem search_MenuUseRegex;

    }
}

