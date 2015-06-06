namespace CV_Checking
{
   partial class frmViewer
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewer));
         this.splitContainer1 = new System.Windows.Forms.SplitContainer();
         this.btnFindNext = new System.Windows.Forms.Button();
         this.btnFind = new System.Windows.Forms.Button();
         this.chkShowUncleared = new System.Windows.Forms.CheckBox();
         this.chkShowCleared = new System.Windows.Forms.CheckBox();
         this.dtEnd = new System.Windows.Forms.DateTimePicker();
         this.chkShowFlagged = new System.Windows.Forms.CheckBox();
         this.dtStart = new System.Windows.Forms.DateTimePicker();
         this.chkDateRange = new System.Windows.Forms.CheckBox();
         this.btnToggleFlagged = new System.Windows.Forms.Button();
         this.btnToggleCleared = new System.Windows.Forms.Button();
         this.lvTrans = new System.Windows.Forms.ListView();
         this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
         this.imageList1 = new System.Windows.Forms.ImageList(this.components);
         this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
         this.splitContainer1.Panel1.SuspendLayout();
         this.splitContainer1.Panel2.SuspendLayout();
         this.splitContainer1.SuspendLayout();
         this.SuspendLayout();
         // 
         // splitContainer1
         // 
         this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
         this.splitContainer1.IsSplitterFixed = true;
         this.splitContainer1.Location = new System.Drawing.Point(0, 0);
         this.splitContainer1.Name = "splitContainer1";
         this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
         // 
         // splitContainer1.Panel1
         // 
         this.splitContainer1.Panel1.BackColor = System.Drawing.Color.LightSteelBlue;
         this.splitContainer1.Panel1.Controls.Add(this.btnFindNext);
         this.splitContainer1.Panel1.Controls.Add(this.btnFind);
         this.splitContainer1.Panel1.Controls.Add(this.chkShowUncleared);
         this.splitContainer1.Panel1.Controls.Add(this.chkShowCleared);
         this.splitContainer1.Panel1.Controls.Add(this.dtEnd);
         this.splitContainer1.Panel1.Controls.Add(this.chkShowFlagged);
         this.splitContainer1.Panel1.Controls.Add(this.dtStart);
         this.splitContainer1.Panel1.Controls.Add(this.chkDateRange);
         // 
         // splitContainer1.Panel2
         // 
         this.splitContainer1.Panel2.Controls.Add(this.btnToggleFlagged);
         this.splitContainer1.Panel2.Controls.Add(this.btnToggleCleared);
         this.splitContainer1.Panel2.Controls.Add(this.lvTrans);
         this.splitContainer1.Size = new System.Drawing.Size(878, 462);
         this.splitContainer1.SplitterDistance = 29;
         this.splitContainer1.TabIndex = 0;
         // 
         // btnFindNext
         // 
         this.btnFindNext.Image = global::CV_Checking.Properties.Resources.FindNextHS;
         this.btnFindNext.Location = new System.Drawing.Point(342, 3);
         this.btnFindNext.Name = "btnFindNext";
         this.btnFindNext.Size = new System.Drawing.Size(27, 24);
         this.btnFindNext.TabIndex = 10;
         this.toolTip1.SetToolTip(this.btnFindNext, "Find next Item");
         this.btnFindNext.UseVisualStyleBackColor = true;
         this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
         // 
         // btnFind
         // 
         this.btnFind.Image = global::CV_Checking.Properties.Resources.FindHS;
         this.btnFind.Location = new System.Drawing.Point(309, 3);
         this.btnFind.Name = "btnFind";
         this.btnFind.Size = new System.Drawing.Size(27, 24);
         this.btnFind.TabIndex = 9;
         this.toolTip1.SetToolTip(this.btnFind, "Find an item by searching in description");
         this.btnFind.UseVisualStyleBackColor = true;
         this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
         // 
         // chkShowUncleared
         // 
         this.chkShowUncleared.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.chkShowUncleared.AutoSize = true;
         this.chkShowUncleared.Checked = true;
         this.chkShowUncleared.CheckState = System.Windows.Forms.CheckState.Checked;
         this.chkShowUncleared.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.chkShowUncleared.Location = new System.Drawing.Point(631, 6);
         this.chkShowUncleared.Name = "chkShowUncleared";
         this.chkShowUncleared.Size = new System.Drawing.Size(119, 17);
         this.chkShowUncleared.TabIndex = 1;
         this.chkShowUncleared.Text = "Show Uncleared";
         this.toolTip1.SetToolTip(this.chkShowUncleared, "Check to show Uncleared Transactions");
         this.chkShowUncleared.UseVisualStyleBackColor = true;
         this.chkShowUncleared.CheckedChanged += new System.EventHandler(this.chkDateRange_CheckedChanged);
         // 
         // chkShowCleared
         // 
         this.chkShowCleared.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.chkShowCleared.AutoSize = true;
         this.chkShowCleared.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.chkShowCleared.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.chkShowCleared.Location = new System.Drawing.Point(521, 6);
         this.chkShowCleared.Name = "chkShowCleared";
         this.chkShowCleared.Size = new System.Drawing.Size(104, 17);
         this.chkShowCleared.TabIndex = 0;
         this.chkShowCleared.Text = "Show Cleared";
         this.toolTip1.SetToolTip(this.chkShowCleared, "Check to Show Cleared Transactions");
         this.chkShowCleared.UseVisualStyleBackColor = true;
         this.chkShowCleared.CheckedChanged += new System.EventHandler(this.chkDateRange_CheckedChanged);
         // 
         // dtEnd
         // 
         this.dtEnd.CalendarMonthBackground = System.Drawing.Color.LightSteelBlue;
         this.dtEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
         this.dtEnd.Location = new System.Drawing.Point(207, 5);
         this.dtEnd.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
         this.dtEnd.Name = "dtEnd";
         this.dtEnd.Size = new System.Drawing.Size(96, 20);
         this.dtEnd.TabIndex = 7;
         this.dtEnd.ValueChanged += new System.EventHandler(this.dtStart_ValueChanged);
         // 
         // chkShowFlagged
         // 
         this.chkShowFlagged.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.chkShowFlagged.AutoSize = true;
         this.chkShowFlagged.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.chkShowFlagged.Checked = true;
         this.chkShowFlagged.CheckState = System.Windows.Forms.CheckState.Checked;
         this.chkShowFlagged.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.chkShowFlagged.Location = new System.Drawing.Point(770, 6);
         this.chkShowFlagged.Name = "chkShowFlagged";
         this.chkShowFlagged.Size = new System.Drawing.Size(106, 17);
         this.chkShowFlagged.TabIndex = 2;
         this.chkShowFlagged.Text = "Show Flagged";
         this.chkShowFlagged.UseVisualStyleBackColor = true;
         this.chkShowFlagged.CheckedChanged += new System.EventHandler(this.chkDateRange_CheckedChanged);
         // 
         // dtStart
         // 
         this.dtStart.CalendarMonthBackground = System.Drawing.Color.LightSteelBlue;
         this.dtStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
         this.dtStart.Location = new System.Drawing.Point(107, 5);
         this.dtStart.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
         this.dtStart.Name = "dtStart";
         this.dtStart.Size = new System.Drawing.Size(94, 20);
         this.dtStart.TabIndex = 6;
         this.dtStart.ValueChanged += new System.EventHandler(this.dtStart_ValueChanged);
         // 
         // chkDateRange
         // 
         this.chkDateRange.AutoSize = true;
         this.chkDateRange.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.chkDateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.chkDateRange.Location = new System.Drawing.Point(3, 8);
         this.chkDateRange.Name = "chkDateRange";
         this.chkDateRange.Size = new System.Drawing.Size(98, 17);
         this.chkDateRange.TabIndex = 8;
         this.chkDateRange.Text = "Show Range";
         this.toolTip1.SetToolTip(this.chkDateRange, "Check to Enagle Date Pickers to Right (Filters data by Date)");
         this.chkDateRange.UseVisualStyleBackColor = true;
         this.chkDateRange.CheckedChanged += new System.EventHandler(this.chkDateRange_CheckedChanged);
         // 
         // btnToggleFlagged
         // 
         this.btnToggleFlagged.Image = ((System.Drawing.Image)(resources.GetObject("btnToggleFlagged.Image")));
         this.btnToggleFlagged.Location = new System.Drawing.Point(494, 41);
         this.btnToggleFlagged.Name = "btnToggleFlagged";
         this.btnToggleFlagged.Size = new System.Drawing.Size(26, 26);
         this.btnToggleFlagged.TabIndex = 2;
         this.toolTip1.SetToolTip(this.btnToggleFlagged, "Toggles the current item\'s Cleared Flag");
         this.btnToggleFlagged.UseVisualStyleBackColor = true;
         this.btnToggleFlagged.Visible = false;
         this.btnToggleFlagged.Click += new System.EventHandler(this.btnToggleFlagged_Click);
         // 
         // btnToggleCleared
         // 
         this.btnToggleCleared.Image = ((System.Drawing.Image)(resources.GetObject("btnToggleCleared.Image")));
         this.btnToggleCleared.Location = new System.Drawing.Point(542, 41);
         this.btnToggleCleared.Name = "btnToggleCleared";
         this.btnToggleCleared.Size = new System.Drawing.Size(26, 26);
         this.btnToggleCleared.TabIndex = 1;
         this.toolTip1.SetToolTip(this.btnToggleCleared, "Toggles the Current Item\'s Flagged Flag");
         this.btnToggleCleared.UseVisualStyleBackColor = true;
         this.btnToggleCleared.Visible = false;
         this.btnToggleCleared.Click += new System.EventHandler(this.btnToggleCleared_Click);
         // 
         // lvTrans
         // 
         this.lvTrans.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
         this.lvTrans.Dock = System.Windows.Forms.DockStyle.Fill;
         this.lvTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lvTrans.GridLines = true;
         this.lvTrans.Location = new System.Drawing.Point(0, 0);
         this.lvTrans.MultiSelect = false;
         this.lvTrans.Name = "lvTrans";
         this.lvTrans.Size = new System.Drawing.Size(878, 429);
         this.lvTrans.SmallImageList = this.imageList1;
         this.lvTrans.TabIndex = 0;
         this.lvTrans.UseCompatibleStateImageBehavior = false;
         this.lvTrans.View = System.Windows.Forms.View.Details;
         this.lvTrans.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvTrans_ColumnClick);
         this.lvTrans.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lvTrans_MouseMove);
         this.lvTrans.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvTrans_MouseUp);
         this.lvTrans.Resize += new System.EventHandler(this.lvTrans_Resize);
         // 
         // columnHeader1
         // 
         this.columnHeader1.Text = "Seq";
         this.columnHeader1.Width = 50;
         // 
         // columnHeader2
         // 
         this.columnHeader2.Text = "Date";
         this.columnHeader2.Width = 150;
         // 
         // columnHeader3
         // 
         this.columnHeader3.Text = "Description";
         this.columnHeader3.Width = 195;
         // 
         // columnHeader4
         // 
         this.columnHeader4.Text = "Amount";
         this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         this.columnHeader4.Width = 71;
         // 
         // columnHeader5
         // 
         this.columnHeader5.Text = "Cleared";
         this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         this.columnHeader5.Width = 71;
         // 
         // columnHeader6
         // 
         this.columnHeader6.Text = "Flagged";
         this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         this.columnHeader6.Width = 74;
         // 
         // imageList1
         // 
         this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
         this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
         this.imageList1.Images.SetKeyName(0, "ArrowUp.PNG");
         this.imageList1.Images.SetKeyName(1, "ArrowDown.PNG");
         this.imageList1.Images.SetKeyName(2, "Blank.png");
         // 
         // frmViewer
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(878, 462);
         this.Controls.Add(this.splitContainer1);
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.KeyPreview = true;
         this.Name = "frmViewer";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Transactions";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmViewer_FormClosing);
         this.Load += new System.EventHandler(this.frmTransactions_Load);
         this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmViewer_KeyPress);
         this.splitContainer1.Panel1.ResumeLayout(false);
         this.splitContainer1.Panel1.PerformLayout();
         this.splitContainer1.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
         this.splitContainer1.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.SplitContainer splitContainer1;
      private System.Windows.Forms.ListView lvTrans;
      private System.Windows.Forms.ColumnHeader columnHeader1;
      private System.Windows.Forms.ColumnHeader columnHeader2;
      private System.Windows.Forms.ColumnHeader columnHeader3;
      private System.Windows.Forms.ColumnHeader columnHeader4;
      private System.Windows.Forms.ColumnHeader columnHeader5;
      private System.Windows.Forms.ColumnHeader columnHeader6;
      private System.Windows.Forms.CheckBox chkShowCleared;
      private System.Windows.Forms.CheckBox chkShowUncleared;
      private System.Windows.Forms.CheckBox chkShowFlagged;
      private System.Windows.Forms.DateTimePicker dtStart;
      private System.Windows.Forms.DateTimePicker dtEnd;
      private System.Windows.Forms.CheckBox chkDateRange;
      private System.Windows.Forms.Button btnToggleCleared;
      private System.Windows.Forms.Button btnToggleFlagged;
      private System.Windows.Forms.ImageList imageList1;
      private System.Windows.Forms.ToolTip toolTip1;
      private System.Windows.Forms.Button btnFind;
      private System.Windows.Forms.Button btnFindNext;
   }
}