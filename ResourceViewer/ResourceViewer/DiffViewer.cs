using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ResourceViewer {
	public partial class DiffViewer : Form {

		private int sortColumnMain = -1;
		PackFile file1 = null;
		PackFile file2 = null;

		public DiffViewer() {
			InitializeComponent();
		}

		private void button_LoadFile1_Click(object sender, EventArgs e) {

			if (File.Exists(textBox1.Text)) {
				openFileDialog1.InitialDirectory = Path.GetDirectoryName(textBox1.Text);
			}


			if (openFileDialog1.ShowDialog() == DialogResult.OK) {
				textBox1.Text = openFileDialog1.FileName;
				file1 = new PackFile(openFileDialog1.FileName);

				TryCompare();
			}
		}

		private void button_LoadFile2_Click(object sender, EventArgs e) {

			if (File.Exists(textBox2.Text)) {
				openFileDialog2.InitialDirectory = Path.GetDirectoryName(textBox2.Text);
			}

			if (openFileDialog2.ShowDialog() == DialogResult.OK) {
				textBox2.Text = openFileDialog2.FileName;
				file2 = new PackFile(openFileDialog2.FileName);

				TryCompare();
			}
		}

		private void TryCompare() {

			if (file1 == null || file2 == null)
				return;

			listview_Main.Items.Clear();

			List<ListViewItem> results = new List<ListViewItem>();

			Dictionary<String, FileData> allFiles = new Dictionary<string, FileData>();

			foreach (KeyValuePair<String, FileData> entry in file1.Files) {
				allFiles.Add(entry.Key, entry.Value);
			}

			foreach (KeyValuePair<String, FileData> entry in file2.Files) {
				if (!allFiles.ContainsKey(entry.Key)) {
					allFiles.Add(entry.Key, entry.Value);
				}
			}

			foreach (KeyValuePair<String, FileData> entry in allFiles) {

				String[] filenameParts = entry.Value.filename.Split(Path.DirectorySeparatorChar);
				ListViewItem item = new ListViewItem(entry.Key);

				item.SubItems.Add(String.Format(new FileSizeFormatProvider(), "{0:fs}", entry.Value.size));
				item.SubItems.Add(entry.Key.Substring((entry.Key.Length - 3)));
				item.SubItems.Add(filenameParts[filenameParts.Length - 1]);
				item.SubItems[1].Tag = entry.Value.size;

				if (!file2.Files.ContainsKey(entry.Key)) { //if new file does not contain the entry
					// removed file
					item.ImageKey = "removed";
					if (checkbox_Removed.Checked) results.Add(item);
					continue;
				}
				
				if (!file1.Files.ContainsKey(entry.Key)) { // if old file does not contain the entry
					// added file
					item.ImageKey = "added";
					if (checkbox_Added.Checked) results.Add(item);
					continue;
				}

				byte[] fileData1 = file1.GetFile(entry.Key);
				byte[] fileData2 = file2.GetFile(entry.Key);

				bool sameFile = (fileData1.Length == fileData2.Length);

				if (sameFile) {
					for (int i = 0; i < fileData1.Length; i++) {
						sameFile = (fileData1[i] == fileData2[i]);
						if (!sameFile) break;
					}
				}

				if (!file1.Files[entry.Key].Equals(file2.Files[entry.Key]) || !sameFile) {
					// changed file
					item.ImageKey = "changed";
					if (checkbox_Changed.Checked) results.Add(item);
					continue;

				} 

				// unchanged file
				item.ImageKey = "same";
				if (checkbox_Unchanged.Checked) results.Add(item);
			}

			if (results.Count > 0) {
				listview_Main.Items.AddRange(results.ToArray());
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

		private void checkbox_CheckedChanged(object sender, EventArgs e) {
			TryCompare();
		}

		private void listview_Main_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {


			if (listview_Main.SelectedItems == null || listview_Main.SelectedItems.Count < 1)
				return;

			bool showExtract1 = true;
			bool showExtract2 = true;

			foreach (ListViewItem item in listview_Main.SelectedItems) {

				if (item.ImageKey == "removed") {
					showExtract2 = false;
				} else if (item.ImageKey == "added") {
					showExtract1 = false;
				}
			}

			toolstrip_ExtractOriginal.Enabled = showExtract1;
			toolstrip_ExtractNew.Enabled = showExtract2;

		}

		private void toolstrip_ExtractOriginal_Click(object sender, EventArgs e) {

			if (file1 == null || listview_Main.SelectedItems == null || listview_Main.SelectedItems.Count < 1)
				return;

			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {

				foreach (ListViewItem item in listview_Main.SelectedItems) {
					if (item.ImageKey != "added") {
						file1.Extract(item.Text, folderBrowserDialog1.SelectedPath);
					}
				}
			}
		}

		private void toolstrip_ExtractNew_Click(object sender, EventArgs e) {
			if (file2 == null || listview_Main.SelectedItems == null || listview_Main.SelectedItems.Count < 1)
				return;

			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {

				foreach (ListViewItem item in listview_Main.SelectedItems) {
					if (item.ImageKey != "removed") {
						file2.Extract(item.Text, folderBrowserDialog1.SelectedPath);
					}
				}
			}
		}
	}
}
