using System;
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
		private ColumnHeader colHeaderDescription;
		private ColumnHeader colHeaderAmount;


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

			colHeaderDescription = new System.Windows.Forms.ColumnHeader();
			colHeaderDescription.Text = "Description";
			colHeaderDescription.Width = 180;
			
			colHeaderAmount = new System.Windows.Forms.ColumnHeader();
			colHeaderAmount.Text = "Amount";
			colHeaderAmount.TextAlign = HorizontalAlignment.Right;
			colHeaderAmount.Width = 110;

			Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																			this.colHeaderDescription,
																			this.colHeaderAmount});//,
         this.MouseMove += new MouseEventHandler(Bucket_ListView_MouseMove);
         this.Resize += new EventHandler(Bucket_ListView_Resize);
         this.MouseUp += new MouseEventHandler(Bucket_ListView_MouseUp);
         this.MouseEnter += new EventHandler(Bucket_ListView_MouseEnter);
         this.MouseLeave += new EventHandler(Bucket_ListView_MouseLeave);
         InitializeComponent();
      }

      void Bucket_ListView_MouseEnter(object sender, EventArgs e)
      {
         ShowButtons(true);
      }

      void Bucket_ListView_MouseLeave(object sender, EventArgs e)
      {
         if (li != null && !bShowAmounts)
         {
            li.SubItems[0].Text = "??????";
            li.SubItems[1].Text = "------";
         } 
      }

      private void btnIncrement_MouseMove(object sender, MouseEventArgs e)
      {
         if (li != null)
         {
            string amt = ((Bucket)li.Tag).Amount.ToString("F2").Replace("-","");
            if (li.SubItems[1].Text != amt)
            {
			      li.SubItems[0].Text = ((Bucket)li.Tag).Description;
               li.SubItems[1].Text = amt;
			   }
         }
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
               li.SubItems[1].Text = frm.bucket.Amount.ToString("F2").Replace("-","");
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
			colHeaderAmount.Width = 150;
			colHeaderDescription.Width = this.ClientRectangle.Width - colHeaderAmount.Width - 1;
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
               li.SubItems[0].Text = "??????";
               li.SubItems[1].Text = "------";
            }
            btnIncrement.Hide();
			   li = null;
			   ShowButtons(false);
			}
			else if (li != newLvi)
			{
			   // Hide old items amount
			   if (li != null && !bShowAmounts)
			   {
			      li.SubItems[0].Text = "??????";
               li.SubItems[1].Text = "------";
			   }
			   li = newLvi;
            li.SubItems[0].Text = ((Bucket)li.Tag).Description;
			   li.SubItems[1].Text = ((Bucket)li.Tag).Amount.ToString("F2").Replace("-","");
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
            li.SubItems[1].Text = b.Amount.ToString("F2").Replace("-","");
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
               lvi.SubItems[0].Text = ((Bucket)lvi.Tag).Description;
               lvi.SubItems[1].Text = ((Bucket)lvi.Tag).Amount.ToString("F2").Replace("-","");
            }
            else
            {
               lvi.SubItems[0].Text = "??????";
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
               ListViewItem lvi = new ListViewItem(new string[] {"??????", "------"});
               if (bShowAmounts == true)
               {
                  if (li  != null)
                  {
                     lvi.SubItems[0].Text = ((Bucket)li.Tag).Description;
                     lvi.SubItems[1].Text = ((Bucket)li.Tag).Amount.ToString("F2").Replace("-","");
                  }
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
