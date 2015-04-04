using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CV_Checking
{
   public partial class frmTransaction : Form
   {
      public Transaction transaction = null;
      Category_T newCat;
      
      public frmTransaction(Category_T cat)
      {
         InitializeComponent();
         newCat = cat;
         chkCleared.Visible = false;
         chkFlagged.Visible = false;
         btnDelete.Visible  = false;
      }
      
      public frmTransaction(Transaction tEdit)
      {
         InitializeComponent();
         transaction = tEdit;
         chkCleared.Visible = true;
         chkFlagged.Visible = true;
         btnDelete.Visible  = true;
      }
      
      private void frmTransaction_Load(object sender, EventArgs e)
      {
         Left = MousePosition.X - udAmount.Left - udAmount.Width/2;
         Top  = MousePosition.Y - udAmount.Top - udAmount.Height;
         if (Left < 0) Left = 0;
         if (Top < 0)  Top = 0;
         if (Right > Screen.PrimaryScreen.Bounds.Right)     Left = Screen.PrimaryScreen.Bounds.Width - Width;
         if (Bottom > Screen.PrimaryScreen.Bounds.Bottom)   Top  = Screen.PrimaryScreen.Bounds.Height - Height;
         
         cbCategory.Items.Clear();
         for (int i = 0; i < (int)Category_T.NUM_CATEGORIES; i++)
         {
            cbCategory.Items.Add((Category_T)i);
         }

         udAmount.Select(0, 100);

         if (transaction != null)
         {
            cbCategory.SelectedItem = transaction.Category;
            txtDescription.Text = transaction.Description;
            
            try
            {
               if (transaction.Category == Category_T.Credit)
               {
                  udAmount.Value = transaction.Amount;
               }
               else
               {
                  udAmount.Value = -transaction.Amount;
               }
            }
            catch (Exception)
            {
            }
         }
         else
         {
            cbCategory.SelectedItem = newCat;
         }
      }

      private void btnOK_Click(object sender, EventArgs e)
      {
         if (txtDescription.Text == "")
         {
            MessageBox.Show("Description Empty", "Transaction Data Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
         }
         if (udAmount.Value < 0)
         {
            MessageBox.Show("Amount cannot be negative", "Transaction Data Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
         }
         if (transaction == null)
         {
            // Creating a new transaction
            if ((Category_T)cbCategory.SelectedItem == Category_T.Credit)
            {
               transaction = new Transaction((Category_T)cbCategory.SelectedItem, txtDescription.Text, udAmount.Value);
            }
            else
            {
               transaction = new Transaction((Category_T)cbCategory.SelectedItem, txtDescription.Text, -udAmount.Value);
            }
         }
         else
         {
            // Editing an existing transaction
            transaction.Category = (Category_T)cbCategory.SelectedItem;
            transaction.Description = txtDescription.Text;
            if (transaction.Category == Category_T.Credit)
            {
               transaction.Amount = udAmount.Value;
            }
            else
            {
               transaction.Amount = -udAmount.Value;
            }
         }
         DialogResult = DialogResult.OK;
         Close();
      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         transaction = null;
         DialogResult = DialogResult.Cancel;
         Close();
      }

      private void btnDelete_Click(object sender, EventArgs e)
      {
         DialogResult = DialogResult.Ignore;
         transaction = null;
         Close();
      }

      private void frmDebit_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (e.KeyChar == '\r')
         {
            btnOK_Click(null, null);
            e.Handled = true;
         }
         if (e.KeyChar == 27)
         {
            // esc..
            btnCancel_Click(null, null);
            e.Handled = true;
         }
      }
   }
}
