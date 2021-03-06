﻿namespace CV_Checking
{
   partial class frmTransaction
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransaction));
         this.label1 = new System.Windows.Forms.Label();
         this.txtDescription = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.btnCancel = new System.Windows.Forms.Button();
         this.btnOK = new System.Windows.Forms.Button();
         this.udAmount = new System.Windows.Forms.NumericUpDown();
         this.label3 = new System.Windows.Forms.Label();
         this.chkCleared = new System.Windows.Forms.CheckBox();
         this.chkFlagged = new System.Windows.Forms.CheckBox();
         this.btnDelete = new System.Windows.Forms.Button();
         this.cbCategory = new System.Windows.Forms.ComboBox();
         ((System.ComponentModel.ISupportInitialize)(this.udAmount)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(18, 48);
         this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(86, 25);
         this.label1.TabIndex = 17;
         this.label1.Text = "Amount";
         // 
         // txtDescription
         // 
         this.txtDescription.BackColor = System.Drawing.SystemColors.ControlLightLight;
         this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtDescription.Location = new System.Drawing.Point(159, 13);
         this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
         this.txtDescription.Name = "txtDescription";
         this.txtDescription.Size = new System.Drawing.Size(519, 23);
         this.txtDescription.TabIndex = 0;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(18, 11);
         this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(120, 25);
         this.label2.TabIndex = 19;
         this.label2.Text = "Description";
         // 
         // btnCancel
         // 
         this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnCancel.Location = new System.Drawing.Point(512, 85);
         this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(92, 42);
         this.btnCancel.TabIndex = 6;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // btnOK
         // 
         this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
         this.btnOK.Location = new System.Drawing.Point(619, 85);
         this.btnOK.Margin = new System.Windows.Forms.Padding(4);
         this.btnOK.Name = "btnOK";
         this.btnOK.Size = new System.Drawing.Size(59, 42);
         this.btnOK.TabIndex = 3;
         this.btnOK.UseVisualStyleBackColor = true;
         this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
         // 
         // udAmount
         // 
         this.udAmount.DecimalPlaces = 2;
         this.udAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.udAmount.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
         this.udAmount.Location = new System.Drawing.Point(159, 46);
         this.udAmount.Margin = new System.Windows.Forms.Padding(4);
         this.udAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
         this.udAmount.Name = "udAmount";
         this.udAmount.Size = new System.Drawing.Size(175, 30);
         this.udAmount.TabIndex = 1;
         this.udAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(371, 48);
         this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(100, 25);
         this.label3.TabIndex = 30;
         this.label3.Text = "Category";
         // 
         // chkCleared
         // 
         this.chkCleared.AutoSize = true;
         this.chkCleared.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.chkCleared.Location = new System.Drawing.Point(157, 98);
         this.chkCleared.Margin = new System.Windows.Forms.Padding(4);
         this.chkCleared.Name = "chkCleared";
         this.chkCleared.Size = new System.Drawing.Size(79, 21);
         this.chkCleared.TabIndex = 3;
         this.chkCleared.Text = "Cleared";
         this.chkCleared.UseVisualStyleBackColor = true;
         // 
         // chkFlagged
         // 
         this.chkFlagged.AutoSize = true;
         this.chkFlagged.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
         this.chkFlagged.Location = new System.Drawing.Point(271, 98);
         this.chkFlagged.Margin = new System.Windows.Forms.Padding(4);
         this.chkFlagged.Name = "chkFlagged";
         this.chkFlagged.Size = new System.Drawing.Size(81, 21);
         this.chkFlagged.TabIndex = 4;
         this.chkFlagged.Text = "Flagged";
         this.chkFlagged.UseVisualStyleBackColor = true;
         // 
         // btnDelete
         // 
         this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
         this.btnDelete.Location = new System.Drawing.Point(445, 85);
         this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
         this.btnDelete.Name = "btnDelete";
         this.btnDelete.Size = new System.Drawing.Size(59, 42);
         this.btnDelete.TabIndex = 7;
         this.btnDelete.TabStop = false;
         this.btnDelete.UseVisualStyleBackColor = true;
         this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
         // 
         // cbCategory
         // 
         this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.cbCategory.FormattingEnabled = true;
         this.cbCategory.Location = new System.Drawing.Point(487, 44);
         this.cbCategory.Margin = new System.Windows.Forms.Padding(4);
         this.cbCategory.Name = "cbCategory";
         this.cbCategory.Size = new System.Drawing.Size(191, 33);
         this.cbCategory.TabIndex = 2;
         // 
         // frmTransaction
         // 
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
         this.ClientSize = new System.Drawing.Size(688, 135);
         this.ControlBox = false;
         this.Controls.Add(this.cbCategory);
         this.Controls.Add(this.btnDelete);
         this.Controls.Add(this.chkFlagged);
         this.Controls.Add(this.chkCleared);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.udAmount);
         this.Controls.Add(this.btnOK);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.txtDescription);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.KeyPreview = true;
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "frmTransaction";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Debit";
         this.Load += new System.EventHandler(this.frmTransaction_Load);
         this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmDebit_KeyPress);
         ((System.ComponentModel.ISupportInitialize)(this.udAmount)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtDescription;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.Button btnOK;
      private System.Windows.Forms.NumericUpDown udAmount;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.CheckBox chkCleared;
      private System.Windows.Forms.CheckBox chkFlagged;
      private System.Windows.Forms.Button btnDelete;
      private System.Windows.Forms.ComboBox cbCategory;
   }
}