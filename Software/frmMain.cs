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
	public partial class frmMain : Form
	{
	   Register data = new Register();
	   frmViewer viewRegister  = null;
	   frmViewer viewStatement = null;
      bool bStealth = true;
      
		public frmMain()
		{
			InitializeComponent();
         toolStripcbColor.SelectedIndex = 1;
         //Version v = System.Reflection.Assembly.GetExecutingAssembly().
         Text = "Checking v" + Application.ProductVersion;
		}

      private void frmMain_Load(object sender, EventArgs e)
      {
         frmAbout frm = new frmAbout();
			if (!System.Diagnostics.Debugger.IsAttached)
         {
			   frm.ShowDialog();
            if (frm.txtPassword.Text != "sw3E3ti3")
            {
               MessageBox.Show("Invalid Password");
               Close();
               return;
            }
         }
         else
         {
            frm.txtPassword.Text = "sw3E3ti3";
            frm.ShowDialog();
         }
			
			data = Register.Load(frm.txtPassword.Text);
         if (data == null)
         {
            MessageBox.Show("Failed to Load Data file.");
            Close();
            return;
         }
         Register._Status += new StatusHandler(data__Status);
         Register._BalanceItemsCleared += new BalanceItemsClearedHandler(Register__BalanceItemsCleared);
         if (data.Data.Count == 0)
         {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.FileName = "Register.csv";
            openFileDialog1.Title = "Data Load Failed, Select File to Import";
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
               data.Import_CvCheck(openFileDialog1.FileName);
            }
         }
         lvBuckets.PopulateForm(data.Data);
         lvBuckets._TransactionChanged += new TransactionChangedHandler(bucket_ListView1__BucketChanged);
         lvBuckets._TransactionRemoved += new TransactionRemovedHandler(bucket_ListView1__BucketRemoved);


         viewRegister   = new frmViewer(data.Data, true);
         viewRegister.FormClosed += new FormClosedEventHandler(frm_FormClosed);
         viewRegister._TransactionChanged += new TransactionChangedHandler(viewRegister__TransactionChanged);
         viewRegister._TransactionRemoved += new TransactionRemovedHandler(viewRegister__TransactionRemoved);
         viewStatement  = new frmViewer(data.BankData, false);

			PopulateForm();
      }

      void data__Status(string stat)
      {
         Text = "Checking v" + Application.ProductVersion + " - " + stat;
      }

      void bucket_ListView1__BucketChanged()
      {
         PopulateForm();
      }
		
      void bucket_ListView1__BucketRemoved()
      {
         data.bTransactionListModified = true;  // Set dirty flag
         PopulateForm();
      }

      void viewRegister__TransactionChanged()
      {
         PopulateForm();
      }

      void viewRegister__TransactionRemoved()
      {
         data.bTransactionListModified = true;  // Set Dirty flag
         PopulateForm();
      }

		private void PopulateForm()
		{
         data.Compute();
		   txtBalance.Text         = data.Balance.ToString("F2");
		   txtTotalUncleared.Text  = data.TotalUncleared.ToString("F2");
		   txtTotalCredits.Text    = data.TotalCredits.ToString("F2");
		   txtTotalDebits.Text     = data.TotalDebits.ToString("F2");
         txtNumTransactions.Text = data.Data.Count.ToString();
         txtBankBalance.Text     = data.BankBalance.ToString("F2");
         txtDiscrepancies.Text   = data.TotalDiscrepancies.ToString("F2");
         decimal buckets         = -data.TotalBuckets;
         lblBuckets.Text         = "Buckets $" + buckets.ToString("F2");
         if (viewRegister != null)
         {
           viewRegister.SetDiscrepancies(data.TotalDiscrepancies);
         }
		}
      
      private void ShowBankData()
      {
         viewStatement.PopulateForm();
         if (!viewStatement.Visible)
         {
            viewStatement.Show();
         }
         viewStatement.BringToFront();
      }

      private void btnImportStatement_Click(object sender, EventArgs e)
      {
            // Show the statement details
         ShowBankData();
      }

      #region NEW TRANSACTIONS
      private void NewTransaction(Category_T cat)
      {
         frmTransaction frm = new frmTransaction(cat);
         DialogResult res = frm.ShowDialog();
         if (res == DialogResult.OK)
         {
            data.Data.Add(frm.transaction);
            PopulateForm();
         }
      }
      
      private void btnCredit_Click(object sender, EventArgs e)
      {
         NewTransaction(Category_T.Credit);
      }

      private void btnDebitFood_Click(object sender, EventArgs e)
      {
         NewTransaction(Category_T.Food);
      }

      private void btnDebitDining_Click(object sender, EventArgs e)
      {
         NewTransaction(Category_T.Dining);
      }

      private void btnDebitJoy_Click(object sender, EventArgs e)
      {
         NewTransaction(Category_T.Joy);
      }

      private void btnDebitMisc_Click(object sender, EventArgs e)
      {
         NewTransaction(Category_T.Misc);
      }

      private void btnDebitSchool_Click(object sender, EventArgs e)
      {
         NewTransaction(Category_T.School);
      }

      private void btnDebitAuto_Click(object sender, EventArgs e)
      {
         NewTransaction(Category_T.Auto);
      }

      private void btnMedical_Click(object sender, EventArgs e)
      {
         NewTransaction(Category_T.Medical);
      }

      private void btnActivity_Click(object sender, EventArgs e)
      {
         NewTransaction(Category_T.Activity);
      }

      private void btnExport_Click(object sender, EventArgs e)
      {
         frmDateTimePicker _frm = new frmDateTimePicker();
         if (_frm.ShowDialog() == DialogResult.OK)
         {
            try
            {
               data.Export_CSV(_frm.txtFilename.Text, _frm.dtPicker.Value);
               data.Compute();
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, "Export Failed");
            }
         }
      }

      private void btnDeleteBankData_Click(object sender, EventArgs e)
      {
         DialogResult _res;
         _res = MessageBox.Show("Delete All Cleared and NON-Flagged bank data?", "Delete Bank Data", MessageBoxButtons.YesNo);
         if (_res == System.Windows.Forms.DialogResult.Yes)
         {
            data.ClearBankData();
         }
      }
      #endregion NEW TRANSACTIONS
      
      private void btnSave_Click(object sender, EventArgs e)
      {
         data.Save();
      }

      private void ShowRegisterData()
      {
         viewRegister.PopulateForm();
         if (!viewRegister.Visible)
         {
            viewRegister.Show();
         }
         viewRegister.BringToFront();
      }

      private void btnView_Click(object sender, EventArgs e)
      {
         ShowRegisterData();
      }

      void frm_FormClosed(object sender, FormClosedEventArgs e)
      {
         PopulateForm();
      }

      private void btnDebitUtility_Click(object sender, EventArgs e)
      {
         NewTransaction(Category_T.Utility);
      }

      private void btnDebitHouse_Click(object sender, EventArgs e)
      {
         NewTransaction(Category_T.House);
      }

      private void btnDebit_Click(object sender, EventArgs e)
      {
         NewTransaction(Category_T.Misc);
      }

      private void btnBucketAdd_Click(object sender, EventArgs e)
      {
         frmBucket frm = new frmBucket(new Bucket());
         DialogResult res = frm.ShowDialog();
         if (res == DialogResult.OK)
         {
            data.Data.Add(frm.bucket);
            lvBuckets.PopulateForm(data.Data);
         }
      }

      private void frmMain_KeyDown(object sender, KeyEventArgs e)
      {
         if (e.Alt)
         {
            if (e.KeyCode == Keys.F4)
            {
               Close();
               e.SuppressKeyPress = true; // Prevent ALT+F4 from closing form without prompting user
            }
         }
      }

      private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
      {
         if (data.Modified())
         {
            DialogResult res = MessageBox.Show("Data has been changed, do you want to save?", "Exit Save Prompt", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
               data.Save();
            }
            else if (res == DialogResult.No)
            {
               res = MessageBox.Show("Exit without Saving Data?", "Exit Save Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
               if (res == DialogResult.No)
               {
                  e.Cancel = true;
               }
            }
            else if (res == DialogResult.Cancel)
            {
               e.Cancel = true;
            }
         }
      }

      private void btnBalance_Click(object sender, EventArgs e)
      {
         frmNumericEntry frm = new frmNumericEntry("Enter New Bank Blance");
         frm.numericUpDown1.Value = data.BankBalance;
         DialogResult res = frm.ShowDialog(this);
         if (res == DialogResult.OK)
         {
            data.BankBalance = frm.numericUpDown1.Value;
            PopulateForm();
         }
         else if (res == DialogResult.Cancel)
         {
            return;
         }

         res = MessageBox.Show("Do you want to import Statement Transactions?", "Import Statement", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
         if (res == DialogResult.Yes)
         {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.FileName = "SHANE_txns.csv";
            openFileDialog1.Title = "Select File to Import or Cancel To View Existing Data";
            res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
               for (int i = 0; i < 1; i++)
               {
                  data.Import_BankData(openFileDialog1.FileName);
                  PopulateForm();
               }
            }
            else
            {
               MessageBox.Show("Bank Data Import Cancelled!!");
            }
         }
         
         ShowBankData();
         ShowRegisterData();
         
         res = MessageBox.Show("Do you want to Automatically Balance", "AUTO BALANCE PROMPT", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
         if (res == DialogResult.Yes)
         {
            data.AutoBalance();
            PopulateForm();
            if (data.TotalDiscrepancies != 0)
            {
               MessageBox.Show("Balance Complete, Discrepancies not Zero");
               ShowBankData();
               ShowRegisterData();
            }  
            else
            {
               MessageBox.Show("Balanced!");
            }          
         }
      }

      void Register__BalanceItemsCleared()
      {
         viewRegister.PopulateForm();
         viewStatement.PopulateForm();
      }

      private void ShowAmounts(bool bShow)
      {
         txtBalance.Visible         = bShow || !bStealth;
         txtBankBalance.Visible     = bShow || !bStealth;
         txtDiscrepancies.Visible   = bShow || !bStealth;
         txtTotalCredits.Visible    = bShow || !bStealth;
         txtTotalDebits.Visible     = bShow || !bStealth;
         txtTotalUncleared.Visible  = bShow || !bStealth;
         txtNumTransactions.Visible = bShow || !bStealth;
         lblBuckets.Visible         = bShow || !bStealth;
         lvBuckets.ShowAmounts(bShow || !bStealth);
      }
      
      private void lblBalance_MouseEnter(object sender, EventArgs e)
      {
         ShowAmounts(true);
      }

      private void lblBalance_MouseLeave(object sender, EventArgs e)
      {
         ShowAmounts(false);
      }

      private void stealthModeOffForeverToolStripMenuItem_Click(object sender, EventArgs e)
      {
         bStealth = !stealthModeOffForeverToolStripMenuItem.Checked;
         ShowAmounts(!bStealth);
         contextMenuStrip1.Close();
         tmrStealthAutoOn.Enabled = false;
      }

      private void stealthModeOff10SecondsToolStripMenuItem_Click(object sender, EventArgs e)
      {
         bStealth = !stealthModeOff10SecondsToolStripMenuItem.Checked;
         ShowAmounts(!bStealth);
         contextMenuStrip1.Close();
         if (!bStealth)
         {
            tmrStealthAutoOn.Interval = 10000;
            tmrStealthAutoOn.Enabled = true; // Start the auto stealth On timer.
         }
      }
      private void toolStrip_StealthOff2Seconds_Click(object sender, EventArgs e)
      {
         bStealth = !toolStrip_StealthOff2Seconds.Checked;
         ShowAmounts(!bStealth);
         contextMenuStrip1.Close();
         if (!bStealth)
         {
            tmrStealthAutoOn.Interval = 2000;
            tmrStealthAutoOn.Enabled = true; // Start the auto stealth On timer.
         }
      }

      private void toolStripcbColor_SelectedIndexChanged(object sender, EventArgs e)
      {
         Color newColor = SystemColors.Control;
         if (toolStripcbColor.SelectedIndex == 0)
         {
            newColor = Color.Pink;
         }
         
         BackColor                     = newColor;
         lvBuckets.BackColor           = newColor;
         txtBalance.BackColor          = newColor;
         txtBankBalance.BackColor      = newColor;
         txtDiscrepancies.BackColor    = newColor;
         txtTotalCredits.BackColor     = newColor;
         txtTotalDebits.BackColor      = newColor;
         txtTotalUncleared.BackColor   = newColor;
         txtNumTransactions.BackColor  = newColor;
         lblBuckets.BackColor          = newColor;
         
         contextMenuStrip1.Close();
      }

      private void tmrStealthAutoOn_Tick(object sender, EventArgs e)
      {
         tmrStealthAutoOn.Enabled = false;
         bStealth = true;
         ShowAmounts(false);
         toolStrip_StealthOff2Seconds.Checked = false;
         stealthModeOff10SecondsToolStripMenuItem.Checked = false;
         stealthModeOffForeverToolStripMenuItem.Checked = false;
      }

	}
}
