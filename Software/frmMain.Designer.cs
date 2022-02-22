namespace CV_Checking
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
         this.splitContainer1 = new System.Windows.Forms.SplitContainer();
         this.splitContainer2 = new System.Windows.Forms.SplitContainer();
         this.splitContainer4 = new System.Windows.Forms.SplitContainer();
         this.lblSummary = new System.Windows.Forms.Label();
         this.txtTotalUncleared = new System.Windows.Forms.TextBox();
         this.label4 = new System.Windows.Forms.Label();
         this.txtNumTransactions = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.txtTotalCredits = new System.Windows.Forms.TextBox();
         this.txtTotalDebits = new System.Windows.Forms.TextBox();
         this.txtDiscrepancies = new System.Windows.Forms.TextBox();
         this.txtBankBalance = new System.Windows.Forms.TextBox();
         this.txtBalance = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.lblDiscrepancies = new System.Windows.Forms.Label();
         this.lblBalance = new System.Windows.Forms.Label();
         this.lblBankBalance = new System.Windows.Forms.Label();
         this.splitContainer3 = new System.Windows.Forms.SplitContainer();
         this.btnBucketAdd = new System.Windows.Forms.Button();
         this.lblBuckets = new System.Windows.Forms.Label();
         this.lvBuckets = new CV_Checking.Bucket_ListView();
         this.btnExport = new System.Windows.Forms.Button();
         this.btnDeleteBankData = new System.Windows.Forms.Button();
         this.btnActivity = new System.Windows.Forms.Button();
         this.btnMedical = new System.Windows.Forms.Button();
         this.btnDebitHouse = new System.Windows.Forms.Button();
         this.btnDebitUtility = new System.Windows.Forms.Button();
         this.btnBalance = new System.Windows.Forms.Button();
         this.btnDebit = new System.Windows.Forms.Button();
         this.btnSave = new System.Windows.Forms.Button();
         this.btnImportStatement = new System.Windows.Forms.Button();
         this.btnCredit = new System.Windows.Forms.Button();
         this.btnDebitAuto = new System.Windows.Forms.Button();
         this.btnViewData = new System.Windows.Forms.Button();
         this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
         this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
         this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.stealthModeOffForeverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.stealthModeOff10SecondsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStrip_StealthOff2Seconds = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this.toolStripcbColor = new System.Windows.Forms.ToolStripComboBox();
         this.tmrStealthAutoOn = new System.Windows.Forms.Timer(this.components);
         this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
         this.splitContainer1.Panel1.SuspendLayout();
         this.splitContainer1.Panel2.SuspendLayout();
         this.splitContainer1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
         this.splitContainer2.Panel1.SuspendLayout();
         this.splitContainer2.Panel2.SuspendLayout();
         this.splitContainer2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
         this.splitContainer4.Panel1.SuspendLayout();
         this.splitContainer4.Panel2.SuspendLayout();
         this.splitContainer4.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
         this.splitContainer3.Panel1.SuspendLayout();
         this.splitContainer3.Panel2.SuspendLayout();
         this.splitContainer3.SuspendLayout();
         this.contextMenuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // splitContainer1
         // 
         this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
         this.splitContainer1.Location = new System.Drawing.Point(0, 0);
         this.splitContainer1.Name = "splitContainer1";
         this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // splitContainer1.Panel1
         // 
         this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
         // 
         // splitContainer1.Panel2
         // 
         this.splitContainer1.Panel2.Controls.Add(this.btnExport);
         this.splitContainer1.Panel2.Controls.Add(this.btnDeleteBankData);
         this.splitContainer1.Panel2.Controls.Add(this.btnActivity);
         this.splitContainer1.Panel2.Controls.Add(this.btnMedical);
         this.splitContainer1.Panel2.Controls.Add(this.btnDebitHouse);
         this.splitContainer1.Panel2.Controls.Add(this.btnDebitUtility);
         this.splitContainer1.Panel2.Controls.Add(this.btnBalance);
         this.splitContainer1.Panel2.Controls.Add(this.btnDebit);
         this.splitContainer1.Panel2.Controls.Add(this.btnSave);
         this.splitContainer1.Panel2.Controls.Add(this.btnImportStatement);
         this.splitContainer1.Panel2.Controls.Add(this.btnCredit);
         this.splitContainer1.Panel2.Controls.Add(this.btnDebitAuto);
         this.splitContainer1.Panel2.Controls.Add(this.btnViewData);
         this.splitContainer1.Size = new System.Drawing.Size(786, 321);
         this.splitContainer1.SplitterDistance = 230;
         this.splitContainer1.TabIndex = 1;
         // 
         // splitContainer2
         // 
         this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
         this.splitContainer2.Location = new System.Drawing.Point(0, 0);
         this.splitContainer2.Name = "splitContainer2";
         // 
         // splitContainer2.Panel1
         // 
         this.splitContainer2.Panel1.Controls.Add(this.splitContainer4);
         // 
         // splitContainer2.Panel2
         // 
         this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
         this.splitContainer2.Size = new System.Drawing.Size(786, 230);
         this.splitContainer2.SplitterDistance = 286;
         this.splitContainer2.TabIndex = 1;
         // 
         // splitContainer4
         // 
         this.splitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
         this.splitContainer4.IsSplitterFixed = true;
         this.splitContainer4.Location = new System.Drawing.Point(0, 0);
         this.splitContainer4.Name = "splitContainer4";
         this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // splitContainer4.Panel1
         // 
         this.splitContainer4.Panel1.Controls.Add(this.lblSummary);
         // 
         // splitContainer4.Panel2
         // 
         this.splitContainer4.Panel2.Controls.Add(this.txtTotalUncleared);
         this.splitContainer4.Panel2.Controls.Add(this.label4);
         this.splitContainer4.Panel2.Controls.Add(this.txtNumTransactions);
         this.splitContainer4.Panel2.Controls.Add(this.label3);
         this.splitContainer4.Panel2.Controls.Add(this.txtTotalCredits);
         this.splitContainer4.Panel2.Controls.Add(this.txtTotalDebits);
         this.splitContainer4.Panel2.Controls.Add(this.txtDiscrepancies);
         this.splitContainer4.Panel2.Controls.Add(this.txtBankBalance);
         this.splitContainer4.Panel2.Controls.Add(this.txtBalance);
         this.splitContainer4.Panel2.Controls.Add(this.label2);
         this.splitContainer4.Panel2.Controls.Add(this.label1);
         this.splitContainer4.Panel2.Controls.Add(this.lblDiscrepancies);
         this.splitContainer4.Panel2.Controls.Add(this.lblBalance);
         this.splitContainer4.Panel2.Controls.Add(this.lblBankBalance);
         this.splitContainer4.Size = new System.Drawing.Size(286, 230);
         this.splitContainer4.SplitterDistance = 35;
         this.splitContainer4.TabIndex = 1;
         // 
         // lblSummary
         // 
         this.lblSummary.Dock = System.Windows.Forms.DockStyle.Fill;
         this.lblSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblSummary.Location = new System.Drawing.Point(0, 0);
         this.lblSummary.Name = "lblSummary";
         this.lblSummary.Size = new System.Drawing.Size(282, 31);
         this.lblSummary.TabIndex = 1;
         this.lblSummary.Text = "Summary";
         this.lblSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.lblSummary.MouseEnter += new System.EventHandler(this.lblBalance_MouseEnter);
         this.lblSummary.MouseLeave += new System.EventHandler(this.lblBalance_MouseLeave);
         // 
         // txtTotalUncleared
         // 
         this.txtTotalUncleared.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.txtTotalUncleared.BackColor = System.Drawing.SystemColors.Control;
         this.txtTotalUncleared.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtTotalUncleared.Location = new System.Drawing.Point(177, 81);
         this.txtTotalUncleared.Name = "txtTotalUncleared";
         this.txtTotalUncleared.Size = new System.Drawing.Size(104, 20);
         this.txtTotalUncleared.TabIndex = 25;
         this.txtTotalUncleared.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         this.txtTotalUncleared.Visible = false;
         // 
         // label4
         // 
         this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(95, 80);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(82, 17);
         this.label4.TabIndex = 24;
         this.label4.Text = "Uncleared";
         // 
         // txtNumTransactions
         // 
         this.txtNumTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.txtNumTransactions.BackColor = System.Drawing.SystemColors.Control;
         this.txtNumTransactions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtNumTransactions.Location = new System.Drawing.Point(178, 153);
         this.txtNumTransactions.Name = "txtNumTransactions";
         this.txtNumTransactions.Size = new System.Drawing.Size(104, 20);
         this.txtNumTransactions.TabIndex = 23;
         this.txtNumTransactions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         this.txtNumTransactions.Visible = false;
         // 
         // label3
         // 
         this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(112, 152);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(64, 17);
         this.label3.TabIndex = 22;
         this.label3.Text = "# Trans";
         // 
         // txtTotalCredits
         // 
         this.txtTotalCredits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.txtTotalCredits.BackColor = System.Drawing.SystemColors.Control;
         this.txtTotalCredits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtTotalCredits.Location = new System.Drawing.Point(178, 129);
         this.txtTotalCredits.Name = "txtTotalCredits";
         this.txtTotalCredits.Size = new System.Drawing.Size(104, 20);
         this.txtTotalCredits.TabIndex = 21;
         this.txtTotalCredits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         this.txtTotalCredits.Visible = false;
         // 
         // txtTotalDebits
         // 
         this.txtTotalDebits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.txtTotalDebits.BackColor = System.Drawing.SystemColors.Control;
         this.txtTotalDebits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtTotalDebits.Location = new System.Drawing.Point(178, 105);
         this.txtTotalDebits.Name = "txtTotalDebits";
         this.txtTotalDebits.Size = new System.Drawing.Size(104, 20);
         this.txtTotalDebits.TabIndex = 20;
         this.txtTotalDebits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         this.txtTotalDebits.Visible = false;
         // 
         // txtDiscrepancies
         // 
         this.txtDiscrepancies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.txtDiscrepancies.BackColor = System.Drawing.SystemColors.Control;
         this.txtDiscrepancies.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtDiscrepancies.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtDiscrepancies.Location = new System.Drawing.Point(178, 57);
         this.txtDiscrepancies.Name = "txtDiscrepancies";
         this.txtDiscrepancies.Size = new System.Drawing.Size(104, 19);
         this.txtDiscrepancies.TabIndex = 18;
         this.txtDiscrepancies.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         this.toolTip1.SetToolTip(this.txtDiscrepancies, "\'Bank - Balance - TotalUncleared");
         this.txtDiscrepancies.Visible = false;
         // 
         // txtBankBalance
         // 
         this.txtBankBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.txtBankBalance.BackColor = System.Drawing.SystemColors.Control;
         this.txtBankBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtBankBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtBankBalance.Location = new System.Drawing.Point(178, 34);
         this.txtBankBalance.Name = "txtBankBalance";
         this.txtBankBalance.Size = new System.Drawing.Size(104, 19);
         this.txtBankBalance.TabIndex = 17;
         this.txtBankBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         this.toolTip1.SetToolTip(this.txtBankBalance, "Balance According to the Bank\r\nEntered Each Time You Balance");
         this.txtBankBalance.Visible = false;
         // 
         // txtBalance
         // 
         this.txtBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.txtBalance.BackColor = System.Drawing.SystemColors.Control;
         this.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtBalance.Location = new System.Drawing.Point(178, 3);
         this.txtBalance.Name = "txtBalance";
         this.txtBalance.Size = new System.Drawing.Size(104, 26);
         this.txtBalance.TabIndex = 16;
         this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         this.toolTip1.SetToolTip(this.txtBalance, "Balance according to this application.\r\n\r\nAfter you Balance and \'Discrepancies\' =" +
        " 0, This should equal the Total available at \'Bank\' - \'Uncleared\'.");
         this.txtBalance.Visible = false;
         // 
         // label2
         // 
         this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(82, 104);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(96, 17);
         this.label2.TabIndex = 15;
         this.label2.Text = "Total Debits";
         // 
         // label1
         // 
         this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(76, 128);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(101, 17);
         this.label1.TabIndex = 14;
         this.label1.Text = "Total Credits";
         // 
         // lblDiscrepancies
         // 
         this.lblDiscrepancies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.lblDiscrepancies.AutoSize = true;
         this.lblDiscrepancies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblDiscrepancies.Location = new System.Drawing.Point(67, 57);
         this.lblDiscrepancies.Name = "lblDiscrepancies";
         this.lblDiscrepancies.Size = new System.Drawing.Size(110, 17);
         this.lblDiscrepancies.TabIndex = 4;
         this.lblDiscrepancies.Text = "Discrepancies";
         // 
         // lblBalance
         // 
         this.lblBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.lblBalance.AutoSize = true;
         this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblBalance.Location = new System.Drawing.Point(99, 5);
         this.lblBalance.Name = "lblBalance";
         this.lblBalance.Size = new System.Drawing.Size(74, 20);
         this.lblBalance.TabIndex = 3;
         this.lblBalance.Text = "Balance";
         // 
         // lblBankBalance
         // 
         this.lblBankBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.lblBankBalance.AutoSize = true;
         this.lblBankBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblBankBalance.Location = new System.Drawing.Point(130, 33);
         this.lblBankBalance.Name = "lblBankBalance";
         this.lblBankBalance.Size = new System.Drawing.Size(44, 17);
         this.lblBankBalance.TabIndex = 2;
         this.lblBankBalance.Text = "Bank";
         // 
         // splitContainer3
         // 
         this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
         this.splitContainer3.IsSplitterFixed = true;
         this.splitContainer3.Location = new System.Drawing.Point(0, 0);
         this.splitContainer3.Name = "splitContainer3";
         this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // splitContainer3.Panel1
         // 
         this.splitContainer3.Panel1.Controls.Add(this.btnBucketAdd);
         this.splitContainer3.Panel1.Controls.Add(this.lblBuckets);
         // 
         // splitContainer3.Panel2
         // 
         this.splitContainer3.Panel2.Controls.Add(this.lvBuckets);
         this.splitContainer3.Size = new System.Drawing.Size(496, 230);
         this.splitContainer3.SplitterDistance = 35;
         this.splitContainer3.TabIndex = 1;
         // 
         // btnBucketAdd
         // 
         this.btnBucketAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.btnBucketAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnBucketAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnBucketAdd.Image")));
         this.btnBucketAdd.Location = new System.Drawing.Point(465, -1);
         this.btnBucketAdd.Name = "btnBucketAdd";
         this.btnBucketAdd.Size = new System.Drawing.Size(26, 26);
         this.btnBucketAdd.TabIndex = 20;
         this.toolTip1.SetToolTip(this.btnBucketAdd, "Adds a new Bucket to the Bucket List");
         this.btnBucketAdd.UseVisualStyleBackColor = true;
         this.btnBucketAdd.Click += new System.EventHandler(this.btnBucketAdd_Click);
         // 
         // lblBuckets
         // 
         this.lblBuckets.Dock = System.Windows.Forms.DockStyle.Fill;
         this.lblBuckets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblBuckets.Location = new System.Drawing.Point(0, 0);
         this.lblBuckets.Name = "lblBuckets";
         this.lblBuckets.Size = new System.Drawing.Size(492, 31);
         this.lblBuckets.TabIndex = 0;
         this.lblBuckets.Text = "Buckets";
         this.lblBuckets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.lblBuckets.Visible = false;
         this.lblBuckets.MouseEnter += new System.EventHandler(this.lblBalance_MouseEnter);
         this.lblBuckets.MouseLeave += new System.EventHandler(this.lblBalance_MouseLeave);
         // 
         // lvBuckets
         // 
         this.lvBuckets.Dock = System.Windows.Forms.DockStyle.Fill;
         this.lvBuckets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lvBuckets.FullRowSelect = true;
         this.lvBuckets.GridLines = true;
         this.lvBuckets.HideSelection = false;
         this.lvBuckets.Location = new System.Drawing.Point(0, 0);
         this.lvBuckets.Name = "lvBuckets";
         this.lvBuckets.Size = new System.Drawing.Size(492, 187);
         this.lvBuckets.TabIndex = 0;
         this.lvBuckets.UseCompatibleStateImageBehavior = false;
         this.lvBuckets.View = System.Windows.Forms.View.Details;
         // 
         // btnExport
         // 
         this.btnExport.BackColor = System.Drawing.SystemColors.Control;
         this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnExport.Location = new System.Drawing.Point(480, 6);
         this.btnExport.Name = "btnExport";
         this.btnExport.Size = new System.Drawing.Size(86, 34);
         this.btnExport.TabIndex = 26;
         this.btnExport.Text = "E&xport";
         this.toolTip1.SetToolTip(this.btnExport, "Exports ALL transactions < selected Date.\r\nA confirmation Dialog asks if you want" +
        " to Remove these exported transactions and replace with a single summary transac" +
        "tion");
         this.btnExport.UseVisualStyleBackColor = false;
         this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
         // 
         // btnDeleteBankData
         // 
         this.btnDeleteBankData.BackColor = System.Drawing.SystemColors.Control;
         this.btnDeleteBankData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnDeleteBankData.Location = new System.Drawing.Point(480, 46);
         this.btnDeleteBankData.Name = "btnDeleteBankData";
         this.btnDeleteBankData.Size = new System.Drawing.Size(86, 34);
         this.btnDeleteBankData.TabIndex = 25;
         this.btnDeleteBankData.Text = "-BankData";
         this.toolTip1.SetToolTip(this.btnDeleteBankData, "Deletes imported bank data greater than 6 Months old which is both Cleared and NO" +
        "T Flagged");
         this.btnDeleteBankData.UseVisualStyleBackColor = false;
         this.btnDeleteBankData.Click += new System.EventHandler(this.btnDeleteBankData_Click);
         // 
         // btnActivity
         // 
         this.btnActivity.BackColor = System.Drawing.Color.Tomato;
         this.btnActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnActivity.Location = new System.Drawing.Point(246, 6);
         this.btnActivity.Name = "btnActivity";
         this.btnActivity.Size = new System.Drawing.Size(76, 34);
         this.btnActivity.TabIndex = 24;
         this.btnActivity.Text = "Acti&vity";
         this.toolTip1.SetToolTip(this.btnActivity, "Enter a new Debit with Category = House");
         this.btnActivity.UseVisualStyleBackColor = false;
         this.btnActivity.Click += new System.EventHandler(this.btnActivity_Click);
         // 
         // btnMedical
         // 
         this.btnMedical.BackColor = System.Drawing.Color.Tomato;
         this.btnMedical.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnMedical.Location = new System.Drawing.Point(164, 6);
         this.btnMedical.Name = "btnMedical";
         this.btnMedical.Size = new System.Drawing.Size(76, 34);
         this.btnMedical.TabIndex = 23;
         this.btnMedical.Text = "&Medical";
         this.toolTip1.SetToolTip(this.btnMedical, "Enter a new Debit with Category = House");
         this.btnMedical.UseVisualStyleBackColor = false;
         this.btnMedical.Click += new System.EventHandler(this.btnMedical_Click);
         // 
         // btnDebitHouse
         // 
         this.btnDebitHouse.BackColor = System.Drawing.Color.Tomato;
         this.btnDebitHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnDebitHouse.Location = new System.Drawing.Point(164, 45);
         this.btnDebitHouse.Name = "btnDebitHouse";
         this.btnDebitHouse.Size = new System.Drawing.Size(76, 34);
         this.btnDebitHouse.TabIndex = 22;
         this.btnDebitHouse.Text = "&House";
         this.toolTip1.SetToolTip(this.btnDebitHouse, "Enter a new Debit with Category = House");
         this.btnDebitHouse.UseVisualStyleBackColor = false;
         this.btnDebitHouse.Click += new System.EventHandler(this.btnDebitHouse_Click);
         // 
         // btnDebitUtility
         // 
         this.btnDebitUtility.BackColor = System.Drawing.Color.Tomato;
         this.btnDebitUtility.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnDebitUtility.Location = new System.Drawing.Point(246, 45);
         this.btnDebitUtility.Name = "btnDebitUtility";
         this.btnDebitUtility.Size = new System.Drawing.Size(76, 34);
         this.btnDebitUtility.TabIndex = 21;
         this.btnDebitUtility.Text = "&Utility";
         this.toolTip1.SetToolTip(this.btnDebitUtility, "Enter a new Debit with Category = Utility");
         this.btnDebitUtility.UseVisualStyleBackColor = false;
         this.btnDebitUtility.Click += new System.EventHandler(this.btnDebitUtility_Click);
         // 
         // btnBalance
         // 
         this.btnBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnBalance.Location = new System.Drawing.Point(690, 6);
         this.btnBalance.Name = "btnBalance";
         this.btnBalance.Size = new System.Drawing.Size(82, 34);
         this.btnBalance.TabIndex = 20;
         this.btnBalance.Text = "&Balance";
         this.toolTip1.SetToolTip(this.btnBalance, "Automatically Balances matching up Uncleared Bank Transactions to Uncleared Regis" +
        "ter Transactions");
         this.btnBalance.UseVisualStyleBackColor = true;
         this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
         // 
         // btnDebit
         // 
         this.btnDebit.BackColor = System.Drawing.Color.Tomato;
         this.btnDebit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnDebit.Location = new System.Drawing.Point(82, 6);
         this.btnDebit.Name = "btnDebit";
         this.btnDebit.Size = new System.Drawing.Size(76, 34);
         this.btnDebit.TabIndex = 19;
         this.btnDebit.Text = "&Misc";
         this.toolTip1.SetToolTip(this.btnDebit, "Enter a new Debit with Category = Misc");
         this.btnDebit.UseVisualStyleBackColor = false;
         this.btnDebit.Click += new System.EventHandler(this.btnDebit_Click);
         // 
         // btnSave
         // 
         this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnSave.Location = new System.Drawing.Point(690, 46);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(82, 34);
         this.btnSave.TabIndex = 16;
         this.btnSave.Text = "Save";
         this.toolTip1.SetToolTip(this.btnSave, "Save Register Data and Bank Data To Disk");
         this.btnSave.UseVisualStyleBackColor = true;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // btnImportStatement
         // 
         this.btnImportStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnImportStatement.Location = new System.Drawing.Point(572, 46);
         this.btnImportStatement.Name = "btnImportStatement";
         this.btnImportStatement.Size = new System.Drawing.Size(112, 34);
         this.btnImportStatement.TabIndex = 15;
         this.btnImportStatement.Text = "&Statement";
         this.toolTip1.SetToolTip(this.btnImportStatement, "View previously imported Bank Statement Data");
         this.btnImportStatement.UseVisualStyleBackColor = true;
         this.btnImportStatement.Click += new System.EventHandler(this.btnImportStatement_Click);
         // 
         // btnCredit
         // 
         this.btnCredit.BackColor = System.Drawing.Color.SpringGreen;
         this.btnCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnCredit.Location = new System.Drawing.Point(3, 6);
         this.btnCredit.Name = "btnCredit";
         this.btnCredit.Size = new System.Drawing.Size(73, 73);
         this.btnCredit.TabIndex = 13;
         this.btnCredit.Text = "&Credit";
         this.toolTip1.SetToolTip(this.btnCredit, "Enter a new Credit");
         this.btnCredit.UseVisualStyleBackColor = false;
         this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
         // 
         // btnDebitAuto
         // 
         this.btnDebitAuto.BackColor = System.Drawing.Color.Tomato;
         this.btnDebitAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnDebitAuto.Location = new System.Drawing.Point(82, 46);
         this.btnDebitAuto.Name = "btnDebitAuto";
         this.btnDebitAuto.Size = new System.Drawing.Size(76, 34);
         this.btnDebitAuto.TabIndex = 9;
         this.btnDebitAuto.Text = "&Auto";
         this.toolTip1.SetToolTip(this.btnDebitAuto, "Enter a new Debit with Category = Auto");
         this.btnDebitAuto.UseVisualStyleBackColor = false;
         this.btnDebitAuto.Click += new System.EventHandler(this.btnDebitAuto_Click);
         // 
         // btnViewData
         // 
         this.btnViewData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnViewData.Location = new System.Drawing.Point(572, 6);
         this.btnViewData.Name = "btnViewData";
         this.btnViewData.Size = new System.Drawing.Size(112, 34);
         this.btnViewData.TabIndex = 4;
         this.btnViewData.Text = "&Register";
         this.toolTip1.SetToolTip(this.btnViewData, "View Register Data");
         this.btnViewData.UseVisualStyleBackColor = true;
         this.btnViewData.Click += new System.EventHandler(this.btnView_Click);
         // 
         // openFileDialog1
         // 
         this.openFileDialog1.FileName = "openFileDialog1";
         this.openFileDialog1.Filter = "Comma Seperated Data Files|*.csv";
         this.openFileDialog1.RestoreDirectory = true;
         // 
         // contextMenuStrip1
         // 
         this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
         this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stealthModeOffForeverToolStripMenuItem,
            this.stealthModeOff10SecondsToolStripMenuItem,
            this.toolStrip_StealthOff2Seconds,
            this.toolStripSeparator1,
            this.toolStripcbColor});
         this.contextMenuStrip1.Name = "contextMenuStrip1";
         this.contextMenuStrip1.ShowCheckMargin = true;
         this.contextMenuStrip1.Size = new System.Drawing.Size(249, 103);
         // 
         // stealthModeOffForeverToolStripMenuItem
         // 
         this.stealthModeOffForeverToolStripMenuItem.CheckOnClick = true;
         this.stealthModeOffForeverToolStripMenuItem.Name = "stealthModeOffForeverToolStripMenuItem";
         this.stealthModeOffForeverToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
         this.stealthModeOffForeverToolStripMenuItem.Text = "Stealth Mode Off Forever";
         this.stealthModeOffForeverToolStripMenuItem.Click += new System.EventHandler(this.stealthModeOffForeverToolStripMenuItem_Click);
         // 
         // stealthModeOff10SecondsToolStripMenuItem
         // 
         this.stealthModeOff10SecondsToolStripMenuItem.CheckOnClick = true;
         this.stealthModeOff10SecondsToolStripMenuItem.Name = "stealthModeOff10SecondsToolStripMenuItem";
         this.stealthModeOff10SecondsToolStripMenuItem.Size = new System.Drawing.Size(248, 22);
         this.stealthModeOff10SecondsToolStripMenuItem.Text = "Stealth Mode Off 10 Seconds";
         this.stealthModeOff10SecondsToolStripMenuItem.Click += new System.EventHandler(this.stealthModeOff10SecondsToolStripMenuItem_Click);
         // 
         // toolStrip_StealthOff2Seconds
         // 
         this.toolStrip_StealthOff2Seconds.CheckOnClick = true;
         this.toolStrip_StealthOff2Seconds.Name = "toolStrip_StealthOff2Seconds";
         this.toolStrip_StealthOff2Seconds.Size = new System.Drawing.Size(248, 22);
         this.toolStrip_StealthOff2Seconds.Text = "Stealth Mode Off 2 Seconds";
         this.toolStrip_StealthOff2Seconds.Click += new System.EventHandler(this.toolStrip_StealthOff2Seconds_Click);
         // 
         // toolStripSeparator1
         // 
         this.toolStripSeparator1.Name = "toolStripSeparator1";
         this.toolStripSeparator1.Size = new System.Drawing.Size(245, 6);
         // 
         // toolStripcbColor
         // 
         this.toolStripcbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.toolStripcbColor.Items.AddRange(new object[] {
            "Girls",
            "Boys"});
         this.toolStripcbColor.MaxDropDownItems = 2;
         this.toolStripcbColor.Name = "toolStripcbColor";
         this.toolStripcbColor.Size = new System.Drawing.Size(121, 23);
         this.toolStripcbColor.SelectedIndexChanged += new System.EventHandler(this.toolStripcbColor_SelectedIndexChanged);
         // 
         // tmrStealthAutoOn
         // 
         this.tmrStealthAutoOn.Interval = 10000;
         this.tmrStealthAutoOn.Tick += new System.EventHandler(this.tmrStealthAutoOn_Tick);
         // 
         // tmrUpdate
         // 
         this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
         // 
         // frmMain
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(786, 321);
         this.ContextMenuStrip = this.contextMenuStrip1;
         this.Controls.Add(this.splitContainer1);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.KeyPreview = true;
         this.MinimumSize = new System.Drawing.Size(802, 149);
         this.Name = "frmMain";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Checking - v3.0.0.0";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
         this.Load += new System.EventHandler(this.frmMain_Load);
         this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
         this.splitContainer1.Panel1.ResumeLayout(false);
         this.splitContainer1.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
         this.splitContainer1.ResumeLayout(false);
         this.splitContainer2.Panel1.ResumeLayout(false);
         this.splitContainer2.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
         this.splitContainer2.ResumeLayout(false);
         this.splitContainer4.Panel1.ResumeLayout(false);
         this.splitContainer4.Panel2.ResumeLayout(false);
         this.splitContainer4.Panel2.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
         this.splitContainer4.ResumeLayout(false);
         this.splitContainer3.Panel1.ResumeLayout(false);
         this.splitContainer3.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
         this.splitContainer3.ResumeLayout(false);
         this.contextMenuStrip1.ResumeLayout(false);
         this.ResumeLayout(false);

		}

		#endregion

      private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.SplitContainer splitContainer4;
		private System.Windows.Forms.Label lblSummary;
		private System.Windows.Forms.Label lblDiscrepancies;
		private System.Windows.Forms.Label lblBalance;
		private System.Windows.Forms.Label lblBankBalance;
		private System.Windows.Forms.SplitContainer splitContainer3;
      private System.Windows.Forms.Label lblBuckets;
      private System.Windows.Forms.Button btnViewData;
		private System.Windows.Forms.Button btnDebitAuto;
		private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtDiscrepancies;
      private System.Windows.Forms.TextBox txtBankBalance;
      private System.Windows.Forms.TextBox txtBalance;
      private System.Windows.Forms.TextBox txtTotalCredits;
      private System.Windows.Forms.TextBox txtTotalDebits;
      private System.Windows.Forms.Button btnCredit;
      private System.Windows.Forms.OpenFileDialog openFileDialog1;
      private System.Windows.Forms.TextBox txtNumTransactions;
      private System.Windows.Forms.Label label3;
      private Bucket_ListView lvBuckets;
      private System.Windows.Forms.Button btnImportStatement;
      private System.Windows.Forms.Button btnSave;
      private System.Windows.Forms.Button btnDebit;
      private System.Windows.Forms.Button btnBucketAdd;
      private System.Windows.Forms.Button btnBalance;
      private System.Windows.Forms.TextBox txtTotalUncleared;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.ToolTip toolTip1;
      private System.Windows.Forms.Button btnDebitHouse;
      private System.Windows.Forms.Button btnDebitUtility;
      private System.Windows.Forms.Button btnActivity;
      private System.Windows.Forms.Button btnMedical;
      private System.Windows.Forms.Button btnDeleteBankData;
      private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
      private System.Windows.Forms.ToolStripMenuItem toolStrip_StealthOff2Seconds;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
      private System.Windows.Forms.ToolStripComboBox toolStripcbColor;
      private System.Windows.Forms.Timer tmrStealthAutoOn;
      private System.Windows.Forms.ToolStripMenuItem stealthModeOffForeverToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem stealthModeOff10SecondsToolStripMenuItem;
      private System.Windows.Forms.Button btnExport;
      private System.Windows.Forms.Timer tmrUpdate;
   }
}

