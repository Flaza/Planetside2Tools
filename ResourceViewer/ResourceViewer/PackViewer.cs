using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace ResourceViewer {
	public partial class PackViewer : Form {

		Dictionary<String, PackFile> loadedFiles = new Dictionary<string, PackFile>();
		private int sortColumnMain = -1;
		private int sortColumnSearch = -1;

		public PackViewer(String[] args) {
			InitializeComponent();

			List<string> initialFiles = new List<string>();

			foreach (String arg in args) {
				if (File.Exists(arg)) {
					initialFiles.Add(arg);
				}
			}

			LoadFiles(initialFiles.ToArray());
		}

		private void LoadFiles(String[] files) {

			ReadyProgressBar(files.Length);

			for (int f = 0; f < files.Length; f++) {

				String filename = files[f];
				String[] filenameParts = files[f].Split(Path.DirectorySeparatorChar);

				statuslabel_Main.Text = String.Format("Loading {0} ({1} of {2}) ", filenameParts[filenameParts.Length - 1], progressbar_Main.Value, files.Length);
				statuslabel_Main.Visible = true;

				PackFile loadedFile = new PackFile(filename);

				if (loadedFile == null)
					return;

				loadedFiles.Add(filenameParts[filenameParts.Length - 1], loadedFile);

				foreach (KeyValuePair<String, FileData> entry in loadedFile.Files) {

					ListViewItem item = new ListViewItem(entry.Key);

					item.SubItems.Add(String.Format(new FileSizeFormatProvider(), "{0:fs}", entry.Value.size));
					item.SubItems.Add(entry.Key.Substring((entry.Key.Length - 3)));
					item.SubItems.Add(filenameParts[filenameParts.Length - 1]);

					item.SubItems[1].Tag = entry.Value.size;

					listview_Main.Items.Add(item);
				}

				progressbar_Main.Value = f + 1;
			}

			ResetProgressBar();
		}

		private void openpackToolStripMenuItem_Click(object sender, EventArgs e) {
			if (openFileDialog1.ShowDialog() == DialogResult.OK) {

				loadedFiles.Clear();
				listview_Main.Items.Clear();

				LoadFiles(openFileDialog1.FileNames);
			}
		}

		private void exportToolStripMenuItem1_Click(object sender, EventArgs e) {
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {

				ReadyProgressBar(loadedFiles.Values.Count);

				foreach (PackFile f in loadedFiles.Values) {
					f.Extract(folderBrowserDialog1.SelectedPath);

					progressbar_Main.Value += 1;
				}

				ResetProgressBar();
			}
		}

		private void listView1_MouseDoubleClick(object sender, MouseEventArgs e) {
			ListViewItem selectedItem = listview_Main.SelectedItems[0];

			object foo = selectedItem.SubItems[1].Tag;
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e) {
			if (saveFileDialog1.ShowDialog() == DialogResult.OK) {

				StringBuilder output = new StringBuilder();

				ReadyProgressBar(loadedFiles.Values.Count);

				foreach (PackFile f in loadedFiles.Values) {

					String[] filenameParts = f.FileName.Split(Path.DirectorySeparatorChar);
					foreach (KeyValuePair<String, FileData> entry in f.Files) {
						output.AppendLine(filenameParts[filenameParts.Length - 1] + "\t\t" + entry.Key);
					}

					progressbar_Main.Value += 1;
				}

				File.WriteAllText(saveFileDialog1.FileName, output.ToString());

				ResetProgressBar();
			}
		}

		private void listviewmain_MenuExtract_Click(object sender, EventArgs e) {

			if (listview_Main.SelectedItems == null || listview_Main.SelectedItems.Count < 1)
				return;

			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {

				ReadyProgressBar(listview_Main.SelectedItems.Count);

				foreach (ListViewItem listItem in listview_Main.SelectedItems) {

					PackFile file = loadedFiles[listItem.SubItems[3].Text];
					file.Extract(listItem.Text, folderBrowserDialog1.SelectedPath);
					progressbar_Main.Value += 1;

				}
				ResetProgressBar();
			}
		}

		private void listviewsearch_MenuExtract_Click(object sender, EventArgs e) {

			if (listview_Search.SelectedItems == null || listview_Search.SelectedItems.Count < 1)
				return;

			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {

				ReadyProgressBar(listview_Search.SelectedItems.Count);

				foreach (ListViewItem listItem in listview_Search.SelectedItems) {

					PackFile file = loadedFiles[listItem.SubItems[3].Text];
					file.Extract(listItem.Text, folderBrowserDialog1.SelectedPath);
					progressbar_Main.Value += 1;

				}
				ResetProgressBar();
			}
		}

		private void listview_Main_ColumnClick(object sender, ColumnClickEventArgs e) {
			// Determine whether the column is the same as the last column clicked.
			if (e.Column != sortColumnMain) {
				// Set the sort column to the new column.
				sortColumnMain = e.Column;
				// Set the sort order to ascending by default.
				listview_Main.Sorting = SortOrder.Ascending;
			} else {
				// Determine what the last sort order was and change it.
				if (listview_Main.Sorting == SortOrder.Ascending)
					listview_Main.Sorting = SortOrder.Descending;
				else
					listview_Main.Sorting = SortOrder.Ascending;
			}

			// Call the sort method to manually sort.
			listview_Main.Sort();
			// Set the ListViewItemSorter property to a new ListViewItemComparer
			// object.
			this.listview_Main.ListViewItemSorter = new ListViewItemComparer(e.Column, listview_Main.Sorting);
		}

		private void listview_Search_ColumnClick(object sender, ColumnClickEventArgs e) {
			// Determine whether the column is the same as the last column clicked.
			if (e.Column != sortColumnSearch) {
				// Set the sort column to the new column.
				sortColumnSearch = e.Column;
				// Set the sort order to ascending by default.
				listview_Search.Sorting = SortOrder.Ascending;
			} else {
				// Determine what the last sort order was and change it.
				if (listview_Search.Sorting == SortOrder.Ascending)
					listview_Search.Sorting = SortOrder.Descending;
				else
					listview_Search.Sorting = SortOrder.Ascending;
			}

			// Call the sort method to manually sort.
			listview_Search.Sort();
			// Set the ListViewItemSorter property to a new ListViewItemComparer
			// object.
			this.listview_Search.ListViewItemSorter = new ListViewItemComparer(e.Column, listview_Search.Sorting);
		}

		private void ReadyProgressBar(int maxAmount) {
			progressbar_Main.Visible = true;
			progressbar_Main.Maximum = maxAmount;
			progressbar_Main.Value = 0;

			statuslabel_Main.Visible = true;
			statuslabel_Main.Text = "";
		}

		private void ResetProgressBar() {
			progressbar_Main.Visible = false;
			progressbar_Main.Maximum = 100;
			progressbar_Main.Value = 0;

			statuslabel_Main.Visible = false;
			statuslabel_Main.Text = "";
		}

		private void PerformSearch() {

			string needle = textbox_Search.Text;

			if (needle == null || needle.Length < 1)
				return;

			listview_Search.Items.Clear();
			List<ListViewItem> results = new List<ListViewItem>();

			Regex reg = null;

			if (search_MenuUseRegex.Checked) {

				try {
					reg = new Regex(needle, RegexOptions.IgnoreCase | RegexOptions.Singleline);
					statuslabel_Main.Text = "";
					statuslabel_Main.Visible = false;

				} catch (Exception e) {
					statuslabel_Main.Text = e.Message;
					statuslabel_Main.Visible = true;
				}
			} 

			foreach (ListViewItem haystack in listview_Main.Items) {


				if (search_MenuUseRegex.Checked) {
					if (reg.IsMatch(haystack.Text)) {
						results.Add((ListViewItem)haystack.Clone());
					}
				} else {
					if (haystack.Text.ToLower().Contains(needle.ToLower())) {
						results.Add((ListViewItem)haystack.Clone());
					}
				}
			}

			if (results.Count > 0) {
				listview_Search.Items.AddRange(results.ToArray());
			}

			label_SearchResults.Text = String.Format("Found {0} matches", results.Count);
			label_SearchResults.Visible = true;

		}

		private void searchToolStripMenuItem_Click(object sender, EventArgs e) {
			splitContainer1.Panel2Collapsed = false;
			textbox_Search.Text = "";
			textbox_Search.Focus();
		}

		private void toolStripButton1_Click(object sender, EventArgs e) {
			splitContainer1.Panel2Collapsed = true;
			label_SearchResults.Text = "";
			label_SearchResults.Visible = false;
			listview_Search.Items.Clear();
		}

		private void toolStripButton2_Click(object sender, EventArgs e) {
			PerformSearch();
		}

		private void textbox_Search_KeyPress(object sender, KeyPressEventArgs e) {
			if (e.KeyChar == Convert.ToChar(Keys.Return)) {
				PerformSearch();
				e.Handled = true;
			}
		}

		private void viewDiffToolStripMenuItem_Click(object sender, EventArgs e) {
			DiffViewer newWindow = new DiffViewer();
			newWindow.Show();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
			new AboutBox().ShowDialog(this);
		}
	}
}
