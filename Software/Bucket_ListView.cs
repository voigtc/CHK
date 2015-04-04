﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CV_Checking
{
   public partial class Bucket_ListView : ListView
   {
      List<Transaction> data = null;
		private ColumnHeader columnHeader1; // Button Show Area
		private ColumnHeader columnHeader2; // Statio
      private ColumnHeader columnHeader3; // Stop

		private ListViewItem li;
		private int X=0;
		private int Y=0;
      private bool bShowAmounts = false;
      
      public event TransactionChangedHandler _TransactionChanged;
      public event TransactionRemovedHandler _TransactionRemoved;
      
      public Bucket_ListView()
      {
         this.SuspendLayout();

			Dock = System.Windows.Forms.DockStyle.Fill;
			Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			FullRowSelect = true;
			Name = "listView1";
			Size = new System.Drawing.Size(0,0);
			TabIndex = 0;
			View = System.Windows.Forms.View.Details;
         //this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Recipe_ListView_MouseDown);
         //this.DoubleClick += new System.EventHandler(this.Recipe_ListView_DoubleClick);
         //this.SelectedIndexChanged += new EventHandler(Recipe_ListView_SelectedIndexChanged);
			GridLines = true;

			columnHeader1 = new System.Windows.Forms.ColumnHeader();
			columnHeader1.Text = "Description";
			columnHeader1.Width = 200;
			
			columnHeader2 = new System.Windows.Forms.ColumnHeader();
			columnHeader2.Text = "Amount";
			columnHeader2.TextAlign = HorizontalAlignment.Right;
			columnHeader2.Width = 90;

			columnHeader3 = new System.Windows.Forms.ColumnHeader();
			columnHeader3.Text = "Increment";
			columnHeader3.TextAlign = HorizontalAlignment.Right;
			columnHeader3.Width = 90;

			Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																			this.columnHeader1,
																			this.columnHeader2});//,
																			//this.columnHeader3});
         this.MouseMove += new MouseEventHandler(Bucket_ListView_MouseMove);
         this.Resize += new EventHandler(Bucket_ListView_Resize);
         this.MouseUp += new MouseEventHandler(Bucket_ListView_MouseUp);
         this.MouseLeave += new EventHandler(Bucket_ListView_MouseLeave);
         InitializeComponent();
      }

      void Bucket_ListView_MouseLeave(object sender, EventArgs e)
      {
         if (li != null && !bShowAmounts)
         {
            li.SubItems[1].Text = "------";
         }
      }

      private void btnIncrement_MouseMove(object sender, MouseEventArgs e)
      {
         if (li != null)
         {
            string amt = ((Bucket)li.Tag).Amount.ToString("F2");
            if (li.SubItems[1].Text != amt)
            {
			      li.SubItems[1].Text = amt;
			   }
         }
      }

      private void btnIncrement_MouseLeave(object sender, EventArgs e)
      {

      }

      void Bucket_ListView_MouseUp(object sender, MouseEventArgs e)
      {
         frmBucket frm = null;
         DialogResult res;
         if (li != null)
         {
            Bucket b = (Bucket)li.Tag;
            frm = new frmBucket(b);
            res = frm.ShowDialog();
            if (res == DialogResult.Cancel)
            {
               return;
            }
            else if (res == DialogResult.OK)
            {
               li.SubItems[0].Text = frm.bucket.Description;
               li.SubItems[1].Text = frm.bucket.Amount.ToString("F2");
               //li.SubItems[2].Text = frm.bucket.IncrementAmount.ToString("F2");
               Fire_BucketChanged();
            }
            else if (res == DialogResult.Ignore)
            {
               Items.Remove(li);
               data.Remove((Transaction)li.Tag);
               if (_TransactionRemoved != null)
               {
                  _TransactionRemoved();
                  UpdateForm();
               }
               Fire_BucketChanged();
            }
         }
      }

      void Bucket_ListView_Resize(object sender, EventArgs e)
      {
         btnIncrement.Hide();
			columnHeader1.Width = this.ClientRectangle.Width - 120-1;//240 -1;
			columnHeader2.Width = 120;
			//columnHeader3.Width = 120;
      }

      void Bucket_ListView_MouseMove(object sender, MouseEventArgs e)
      {
         // Show buttons to increment, edit, and delete the bucket.
         // Edit will edit the amount, and the increment amount
			ListViewItem newLvi = this.GetItemAt(e.X, e.Y);
			if (newLvi == null)
			{
            if (li != null && !bShowAmounts)
            {
               li.SubItems[1].Text = "------";
            }
			   li = null;
			   ShowButtons(false);
			}
			else if (li != newLvi)
			{
			   // Hide old items amount
			   if (li != null && !bShowAmounts)
			   {
			      li.SubItems[1].Text = "------";
			   }
			   li = newLvi;
			   li.SubItems[1].Text = ((Bucket)li.Tag).Amount.ToString("F2");
			   X = e.X;
			   Y = e.Y;
			   ShowButtons(true);
         }
      }

      private void ShowButtons(bool bShow)
      {
         if (li == null)
         {
            return;
         }
         
         if (bShow)
         {
			   // Get position of the button from the subitem clicked's position info..
            Size btnSize = new Size(Math.Max(35, Columns[0].Width/10), li.Bounds.Height);

            Point btnLoc2 = new Point(li.Bounds.Left + Columns[0].Width/* + Columns[1].Width*/, li.Bounds.Y);
            btnIncrement.Size = btnSize;
            btnIncrement.Location = btnLoc2;
            btnIncrement.Show();
            btnIncrement.Visible = true;
            btnIncrement.BringToFront();
         }
         else
         {
            btnIncrement.Hide();
         }
      }

      private void btnIncrement_Click(object sender, EventArgs e)
      {
         if (li != null)
         {
            Bucket b = (Bucket)li.Tag;
            b.Increment();
            li.SubItems[1].Text = b.Amount.ToString("F2");
            Fire_BucketChanged();
         }
      }

      private void Fire_BucketChanged()
      {
         if (_TransactionChanged != null)
         {
            _TransactionChanged();
         }
      }
      
      internal void ShowAmounts(bool bShow)
      {
         bShowAmounts = bShow;
         foreach (ListViewItem lvi in Items)
         {
            if (bShow)
            {
               lvi.SubItems[1].Text = ((Bucket)lvi.Tag).Amount.ToString("F2");
            }
            else
            {
               lvi.SubItems[1].Text = "------";
            }
         }
      }

      private void UpdateForm()
      {
			Items.Clear();
			BeginUpdate();
         foreach (Transaction t in data)
         {
            if (t.GetType() == typeof(Bucket))
            {
               Bucket b = (Bucket)t;
               ListViewItem lvi = new ListViewItem(new string[] {b.Description, "------"});
               if (bShowAmounts == true)
               {
                  lvi.SubItems[1].Text = ((Bucket)li.Tag).Amount.ToString("F2");
               }
               lvi.Tag = b;
               Items.Add(lvi);
            }
         }
         EndUpdate();
      }
      
      internal void PopulateForm(List<Transaction> _data)
      {
         data = _data;
         UpdateForm();
         Fire_BucketChanged();
      }

   }
}
