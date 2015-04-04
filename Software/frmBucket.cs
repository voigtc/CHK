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
   public partial class frmBucket : Form
   {
      public Bucket bucket = null;
      
      public frmBucket(Bucket b)
      {
         InitializeComponent();
         bucket = b;
         udAmount.Value = (decimal)-bucket.Amount;
         udIncrement.Value = (decimal)bucket.IncrementAmount;
         txtDescription.Text = bucket.Description;
      }
      
      private void btnOK_Click(object sender, EventArgs e)
      {
         if (txtDescription.Text == "")
         {
            MessageBox.Show("Description Empty", "Bucket Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
         }
         bucket.Amount = -udAmount.Value;
         bucket.Description = txtDescription.Text;
         bucket.IncrementAmount = udIncrement.Value;
         DialogResult = DialogResult.OK;
         Close();
      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         bucket = null;
         DialogResult = DialogResult.Cancel;
         Close();
      }

      private void btnDelete_Click(object sender, EventArgs e)
      {
         DialogResult = DialogResult.Ignore;
         bucket = null;
      }

      private void frmBucket_KeyPress(object sender, KeyPressEventArgs e)
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
         }
      }

      private void frmBucket_Load(object sender, EventArgs e)
      {
         Left = MousePosition.X - udAmount.Location.X - udAmount.Width;
         Top  = MousePosition.Y - udAmount.Location.Y - udAmount.Height;
      }
   }
}
