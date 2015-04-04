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
   public partial class frmTextEntry : Form
   {
      public frmTextEntry(string prompt)
      {
         InitializeComponent();
         label1.Text = prompt;
      }

      private void frmTextEntry_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (e.KeyChar == '\r')
         {
            DialogResult = DialogResult.OK;
            e.Handled = true;
            Close();
         }
         if (e.KeyChar == 27)
         {
            // esc..
            DialogResult = DialogResult.Cancel;
            e.Handled = true;
            Close();
         }
      }

      private void btnOK_Click(object sender, EventArgs e)
      {
            DialogResult = DialogResult.OK;
            Close();
      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
            DialogResult = DialogResult.Cancel;
            Close();
      }
   }
}
