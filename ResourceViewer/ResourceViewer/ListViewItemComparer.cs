using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace ResourceViewer {
	// Implements the manual sorting of items by column.
	class ListViewItemComparer : IComparer {
		private int col;
		private SortOrder order;
		public ListViewItemComparer() {
			col = 0;
			order = SortOrder.Ascending;
		}

		public ListViewItemComparer(int column, SortOrder order) {
			col = column;
			this.order = order;
		}

		public int Compare(object x, object y) {
			int returnVal = -1;

			if (col != 1) {
				String value1 = ((ListViewItem)x).SubItems[col].Text;
				String value2 = ((ListViewItem)y).SubItems[col].Text;

				returnVal = String.Compare(value1, value2);
			} else {

				int value1 = (int)((ListViewItem)x).SubItems[col].Tag;
				int value2 = (int)((ListViewItem)y).SubItems[col].Tag;


				if (value1 == value2) {
					returnVal = 0;
				} else if (value1 > value2) {
					returnVal = 1;
				}
			}
			// Determine whether the sort order is descending.
			if (order == SortOrder.Descending) {
				// Invert the value returned by String.Compare.
				returnVal *= -1;
			}
			return returnVal;
		}
	}
}
