using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CV_Checking
{

   public partial class frmViewer : Form
   {
      public event TransactionChangedHandler _TransactionChanged;
      public event TransactionRemovedHandler _TransactionRemoved;
      
      List<Transaction> data = null;
      ListViewItem li = null;
      int X = 0;
      int Y = 0;
      SortOrder [] sortCol;
      String [] txtCol;
      bool bIsRegisterData = false;
      
      // Searching vars
      int searchStartIx = 0;
      string searchField = null;
      ListViewItem lviSearch = null;
      
      public frmViewer(List<Transaction> _data, bool _bIsRegisterData)
      {
         InitializeComponent();
         bIsRegisterData = _bIsRegisterData;
         if (bIsRegisterData)
         {
            Text = "Register Data";
         }
         else
         {
            Text = "Bank Data";
         }
         data = _data;
      }

      #region FORM LOAD / CLOSING / RESIZE HANDLERS
      private void frmTransactions_Load(object sender, EventArgs e)
      {
         // Position form for optimal viewing
         this.Width = Screen.PrimaryScreen.Bounds.Width;
         this.Height = Screen.PrimaryScreen.Bounds.Height/2;
         this.Left = 0;
         this.Top = 0;
         
         if (Text == "Bank Data")
         {
            this.Top = Screen.PrimaryScreen.Bounds.Height/2;
            bIsRegisterData = false;
         }
         else
         {
            bIsRegisterData = true;
         }

         // Keep track of last sort order.
         sortCol = new SortOrder[lvTrans.Columns.Count];
         txtCol  = new string[lvTrans.Columns.Count];
         for (int i = 0; i < lvTrans.Columns.Count; i++)
         {
            sortCol[i] = SortOrder.None;
            txtCol[i] = lvTrans.Columns[i].Text;
         }
      }
      
      private void frmViewer_FormClosing(object sender, FormClosingEventArgs e)
      {
         Hide();
         e.Cancel = true;  // Don't actually close the form, just hide it.
      }

      private void frmViewer_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (e.KeyChar == 27)
         {
            // esc..
            Close();
            e.Handled = true;
         }
      }

      private void lvTrans_Resize(object sender, EventArgs e)
      {
         int SEQ_WIDTH     = 75; 
         int DATE_WIDTH    = 100;
         int AMOUNT_WIDTH  = 100;
         int CLEARED_WIDTH = 75;
         int FLAGGED_WIDTH = 75;
         int DESC_WIDTH    = lvTrans.ClientRectangle.Width - SEQ_WIDTH - DATE_WIDTH - AMOUNT_WIDTH - CLEARED_WIDTH - FLAGGED_WIDTH - 5;
         
         
         lvTrans.Columns[0].Width = SEQ_WIDTH;
         lvTrans.Columns[1].Width = DATE_WIDTH;
         lvTrans.Columns[2].Width = DESC_WIDTH;
         lvTrans.Columns[3].Width = AMOUNT_WIDTH;
         lvTrans.Columns[4].Width = CLEARED_WIDTH;
         lvTrans.Columns[5].Width = FLAGGED_WIDTH;
      }
      #endregion FORM LOAD / CLOSING / RESIZE HANDLERS

      #region HELPERS
      /// <summary>
      /// Adds Items to the listview control based on current filter flags.
      /// </summary>
      internal void PopulateForm()
      {
         bool bShowCleared   = chkShowCleared.Checked;
         bool bShowUncleared = chkShowUncleared.Checked;
         bool bShowFlagged   = chkShowFlagged.Checked;
         
         lvTrans_Resize(null, null);
         lvTrans.BeginUpdate();
         lvTrans.Items.Clear();
         foreach (Transaction t in data)
         {
            if (t.GetType() != typeof(Transaction))
            {
               continue;
            }
           
            if (!bShowFlagged && t.Flagged)
            {
               continue;
            }
            
            if (t.Cleared)
            {
               if (t.Flagged && bShowFlagged)
               {
                  // Always show Flagged when requested
               }
               else if (!bShowCleared)
               {
                  continue; // skip this item
               }
            }
            else
            {
               if (t.Flagged && bShowFlagged)
               {
                  // Always show Flagged when requested
               }
               else if (!bShowUncleared)
               {
                  continue;   // Skip this item
               }
            }

            if (chkDateRange.Checked)
            {
               if ((t.Date() < dtStart.Value) || (t.Date() > dtEnd.Value))
               {
                  continue;
               }
            }
            string[] strings = new string[] {t.ID.ToString(),
                                             t.Date().ToString("yyyy-MM-dd"),
                                             t.Description,
                                             t.Amount.ToString("F2"),
                                             t.Cleared ? "X" : "",
                                             t.Flagged ? "X" : ""};
                                             
            ListViewItem lvi = new ListViewItem(strings);
            lvi.Tag = t;
            lvTrans.Items.Add(lvi);
         }
         lvTrans.View = View.Details;
         
         if (searchField != null)
         {
            if (lvTrans.Items.Count > 0)
            {
               lviSearch = lvTrans.Items[0];
               searchStartIx = 0;
            }
         }
         lvTrans.EndUpdate();
      }
      
      /// <summary>
      /// Displays/Hides the Cycle Cleared and Cycle Flagged buttons on the currently
      /// selected Transaction
      /// </summary>
      /// <param name="bShow"></param>
      private void ShowButtons(bool bShow)
      {
         if (li == null)
         {
            return;
         }
         if (bShow)
         {
            int clearedX = li.Bounds.Left + lvTrans.Columns[0].Width +
                                            lvTrans.Columns[1].Width +
                                            lvTrans.Columns[2].Width +
                                            lvTrans.Columns[3].Width;
            int flaggedX = clearedX + lvTrans.Columns[4].Width;

            Size btnSize = new Size(li.Bounds.Height, li.Bounds.Height);
            Point btnLoc;
            btnLoc = new Point(flaggedX, li.Bounds.Y);
            btnToggleFlagged.Size = btnSize;
            btnToggleFlagged.Location = btnLoc;
            btnToggleFlagged.Visible = true;
            btnToggleFlagged.BringToFront();

            btnLoc = new Point(clearedX, li.Bounds.Y);
            btnToggleCleared.Size = btnSize;
            btnToggleCleared.Location = btnLoc;
            btnToggleCleared.Visible = true;
            btnToggleCleared.BringToFront();
         }
         else
         {
            btnToggleFlagged.Hide();
            btnToggleCleared.Hide();
         }
      }

      private void Fire_TransactionChanged()
      {
         if (_TransactionChanged != null)
         {
            _TransactionChanged();
         }   
      }
      #endregion HELPERS

      #region FILTER SELECTION HANDLERS
      private void chkDateRange_CheckedChanged(object sender, EventArgs e)
      {
         dtStart.Enabled = chkDateRange.Checked;
         dtEnd.Enabled   = chkDateRange.Checked;
         PopulateForm();
      }

      private void btnToggleCleared_Click(object sender, EventArgs e)
      {
         if (li != null)
         {
            Transaction t = (Transaction)li.Tag;
            t.Cleared = !t.Cleared;
            li.SubItems[4].Text = t.Cleared ? "X":"";
            Fire_TransactionChanged();
         }
      }

      private void btnToggleFlagged_Click(object sender, EventArgs e)
      {
         if (li != null)
         {
            Transaction t = (Transaction)li.Tag;
            t.Flagged = !t.Flagged;
            li.SubItems[5].Text = t.Flagged ? "X":"";
            //Fire_TransactionChanged(); // No need to notify anyone of this
         }
      }
      #endregion FILTER SELECTION HANDLERS

      #region LIST VIEW HANDLERS
      /// <summary>
      /// Tracks which ListViewItem is currently under the mouse (if any)
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void lvTrans_MouseMove(object sender, MouseEventArgs e)
      {
         // Show buttons to toggle cleared and flagged flags
			ListViewItem newLvi = lvTrans.GetItemAt(10, e.Y);
			if (newLvi == null)
			{
			   li = null;
			   ShowButtons(false);
			}
			else if (li != newLvi)
			{
            if (li != null)
            {
               // restore color
               li.BackColor = lvTrans.BackColor;
            }
			   li = newLvi;
			   X = e.X;
			   Y = e.Y;
			   ShowButtons(true);
			   li.BackColor = Color.SteelBlue;
         }
      }

      /// <summary>
      /// Allows editing of the Clicked on transaction
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void lvTrans_MouseUp(object sender, MouseEventArgs e)
      {
         if (li == null)
         {
           return; 
         }
         
         Transaction t = (Transaction)li.Tag;
         frmTransaction frm = new frmTransaction(t);
         frm.transaction = t;
         DialogResult res = frm.ShowDialog();
         if (res == DialogResult.OK)
         {
            // t has been modified.. update data in lvTrans
            li.SubItems[2].Text = t.Description;
            li.SubItems[3].Text = t.Amount.ToString("F2");
            Fire_TransactionChanged();
            //MessageBox.Show("New Transaction Entered\r\n\r\n" + t.ToString());
         }
         else if (res == DialogResult.Cancel)
         {
            //MessageBox.Show("Transaction Cancelled");
         }
         else if (res == DialogResult.Ignore)
         {
            res = MessageBox.Show("Delete Item:  " + t.ToString(), "Delete Transaction", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
               lvTrans.Items.Remove(li);
               data.Remove(t);
               if (_TransactionRemoved != null)
               {
                  _TransactionRemoved();
               }
            }
         }
      }

      /// <summary>
      /// Sorts the List based on the column header clicked on
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
      private void lvTrans_ColumnClick(object sender, ColumnClickEventArgs e)
      {
         // Set the ListViewItemSorter property to a new ListViewItemComparer 
         // object. Setting this property immediately sorts the 
         // ListView using the ListViewItemComparer object.
         for (int i = 0; i < lvTrans.Columns.Count; i++)
         {
            lvTrans.Columns[i].ImageIndex = 2;  // Reset all images
            lvTrans.Columns[e.Column].Text = txtCol[e.Column];
            if (e.Column != i)
            {
               sortCol[i] = SortOrder.None;
            }
         }
         switch (sortCol[e.Column])
         {
         case SortOrder.None:       sortCol[e.Column] = SortOrder.Ascending;
                                    lvTrans.Columns[e.Column].ImageIndex = 0;
                                    //lvTrans.Columns[e.Column].Text = "";
                                    break;
         case SortOrder.Ascending:  sortCol[e.Column] = SortOrder.Descending;
                                    lvTrans.Columns[e.Column].ImageIndex = 1;
                                    //lvTrans.Columns[e.Column].Text = "";
                                    break;
         case SortOrder.Descending: sortCol[e.Column] = SortOrder.None;
                                    lvTrans.Columns[e.Column].ImageIndex = 2;
                                    break;
         }
         if (sortCol[e.Column] == SortOrder.None)
         {
            // Sort none - just sort by sequence number ascending to put list back to it's original state
            lvTrans.ListViewItemSorter = new ListViewItemComparer(0, SortOrder.Ascending);
         }
         else
         {
            lvTrans.ListViewItemSorter = new ListViewItemComparer(e.Column, sortCol[e.Column]);
         }
      }
      #endregion LIST VIEW HANDLERS

      internal void SetDiscrepancies(decimal p)
      {
         if (bIsRegisterData)
         {
            Text = "Register Data  -  Discrepancies: $" + p.ToString("F2");
         }
      }

      private void dtStart_ValueChanged(object sender, EventArgs e)
      {
         PopulateForm();
      }

      private void btnFind_Click(object sender, EventArgs e)
      {
         if (lvTrans.Items.Count == 0)
         {
            MessageBox.Show("No searchable items currently displayed");
            return;
         }
         frmTextEntry frmTxt = new frmTextEntry("Enter text to search for");
         if (frmTxt.ShowDialog(this) == DialogResult.Cancel)
         {
            return;
         }
         searchField = frmTxt.txtBox1.Text;
         if (searchField != null)
         {
            if (lviSearch == null)
            {
               lviSearch = lvTrans.Items[0];
            }
            searchStartIx = lviSearch.Index;
            btnFindNext_Click(this, null);
         }
      }

      
      private void btnFindNext_Click(object sender, EventArgs e)
      {
         if (lviSearch == null)
         {
            return;
         }
         bool bFound = false;
         int ix = searchStartIx;
         do
         {
            ix++;
            if (ix >= lvTrans.Items.Count)
            {
               ix = 0;
            }
            lviSearch = lvTrans.Items[ix];
            Transaction t = (Transaction)lviSearch.Tag;
            if (t.Description.IndexOf(searchField,StringComparison.CurrentCultureIgnoreCase) >= 0)
            {
               lviSearch.Selected = true;
               lviSearch.BackColor = Color.Orange;
               lvTrans.EnsureVisible(lviSearch.Index);
               bFound = true;
            }
         }
         while (!bFound && (lviSearch.Index != searchStartIx));
         if (!bFound)
         {
            MessageBox.Show("Search Text:  " + searchField + " Not Found");
         }
      }
   }

   #region LV COLUMN SORTER
   // Implements the manual sorting of items by columns.
   class ListViewItemComparer : IComparer
   {
      private int col;
      SortOrder orderOfSort = SortOrder.Ascending;
      
      public ListViewItemComparer()
      {
         col = 0;
      }
      public ListViewItemComparer(int column, SortOrder order)
      {
         col = column;
         orderOfSort = order;
      }
      public int Compare(object x, object y)
      {
         int result = 0;   // Default to items equal
         string xTxt = ((ListViewItem)x).SubItems[col].Text;
         string yTxt = ((ListViewItem)y).SubItems[col].Text;
         
         if (col == 0)  // Sequence Id
         {
            int xSeq = 0;
            int ySeq = 0;
            if (int.TryParse(xTxt, out xSeq) && int.TryParse(yTxt, out ySeq))
            {
               if (xSeq > ySeq)  result =  1;
               if (xSeq < ySeq)  result = -1;
            }
         }
         else if (col == 3)   // Amount (decimal)
         {
            decimal xSeq = 0;
            decimal ySeq = 0;
            if (decimal.TryParse(xTxt, out xSeq) && decimal.TryParse(yTxt, out ySeq))
            {
               if (xSeq > ySeq)  result =  1;
               if (xSeq < ySeq)  result = -1;
            }
         }
         else  // Just use standard Text comparer
         {
            result = String.Compare(xTxt, yTxt);
         }

         // Filp result if order is reversed
         if (orderOfSort == SortOrder.Descending)
         {
            return -result; // Return negative of result
         }
         return result;
      }
   }
   #endregion LV COLUMN SORTER
}
