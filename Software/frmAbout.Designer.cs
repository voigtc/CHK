﻿namespace CV_Checking
{
   partial class frmAbout
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
         this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
         this.txtPassword = new System.Windows.Forms.TextBox();
         this.logoPictureBox = new System.Windows.Forms.PictureBox();
         this.labelProductName = new System.Windows.Forms.Label();
         this.labelVersion = new System.Windows.Forms.Label();
         this.labelCopyright = new System.Windows.Forms.Label();
         this.labelCompanyName = new System.Windows.Forms.Label();
         this.textBoxDescription = new System.Windows.Forms.TextBox();
         this.okButton = new System.Windows.Forms.Button();
         this.tableLayoutPanel.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
         this.SuspendLayout();
         // 
         // tableLayoutPanel
         // 
         this.tableLayoutPanel.ColumnCount = 2;
         this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
         this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
         this.tableLayoutPanel.Controls.Add(this.txtPassword, 1, 5);
         this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
         this.tableLayoutPanel.Controls.Add(this.labelProductName, 1, 0);
         this.tableLayoutPanel.Controls.Add(this.labelVersion, 1, 1);
         this.tableLayoutPanel.Controls.Add(this.labelCopyright, 1, 2);
         this.tableLayoutPanel.Controls.Add(this.labelCompanyName, 1, 3);
         this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 1, 4);
         this.tableLayoutPanel.Controls.Add(this.okButton, 1, 6);
         this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel.Location = new System.Drawing.Point(12, 11);
         this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.tableLayoutPanel.Name = "tableLayoutPanel";
         this.tableLayoutPanel.RowCount = 7;
         this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.68313F));
         this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.891783F));
         this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.48529F));
         this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.48529F));
         this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.48393F));
         this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.48529F));
         this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.48529F));
         this.tableLayoutPanel.Size = new System.Drawing.Size(556, 273);
         this.tableLayoutPanel.TabIndex = 0;
         // 
         // txtPassword
         // 
         this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
         this.txtPassword.Location = new System.Drawing.Point(187, 218);
         this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.PasswordChar = '#';
         this.txtPassword.Size = new System.Drawing.Size(365, 22);
         this.txtPassword.TabIndex = 0;
         this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // logoPictureBox
         // 
         this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
         this.logoPictureBox.Location = new System.Drawing.Point(4, 4);
         this.logoPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.logoPictureBox.Name = "logoPictureBox";
         this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 7);
         this.logoPictureBox.Size = new System.Drawing.Size(175, 265);
         this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.logoPictureBox.TabIndex = 12;
         this.logoPictureBox.TabStop = false;
         // 
         // labelProductName
         // 
         this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
         this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelProductName.Location = new System.Drawing.Point(191, 0);
         this.labelProductName.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
         this.labelProductName.MaximumSize = new System.Drawing.Size(0, 21);
         this.labelProductName.Name = "labelProductName";
         this.labelProductName.Size = new System.Drawing.Size(361, 21);
         this.labelProductName.TabIndex = 19;
         this.labelProductName.Text = "Product Name";
         this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // labelVersion
         // 
         this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
         this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelVersion.Location = new System.Drawing.Point(191, 29);
         this.labelVersion.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
         this.labelVersion.MaximumSize = new System.Drawing.Size(0, 21);
         this.labelVersion.Name = "labelVersion";
         this.labelVersion.Size = new System.Drawing.Size(361, 21);
         this.labelVersion.TabIndex = 0;
         this.labelVersion.Text = "Version";
         this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // labelCopyright
         // 
         this.labelCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
         this.labelCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelCopyright.Location = new System.Drawing.Point(191, 56);
         this.labelCopyright.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
         this.labelCopyright.MaximumSize = new System.Drawing.Size(0, 21);
         this.labelCopyright.Name = "labelCopyright";
         this.labelCopyright.Size = new System.Drawing.Size(361, 21);
         this.labelCopyright.TabIndex = 21;
         this.labelCopyright.Text = "Copyright";
         this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // labelCompanyName
         // 
         this.labelCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
         this.labelCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelCompanyName.Location = new System.Drawing.Point(191, 84);
         this.labelCompanyName.Margin = new System.Windows.Forms.Padding(8, 0, 4, 0);
         this.labelCompanyName.MaximumSize = new System.Drawing.Size(0, 21);
         this.labelCompanyName.Name = "labelCompanyName";
         this.labelCompanyName.Size = new System.Drawing.Size(361, 21);
         this.labelCompanyName.TabIndex = 22;
         this.labelCompanyName.Text = "Company Name";
         this.labelCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // textBoxDescription
         // 
         this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
         this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.textBoxDescription.Location = new System.Drawing.Point(191, 116);
         this.textBoxDescription.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
         this.textBoxDescription.Multiline = true;
         this.textBoxDescription.Name = "textBoxDescription";
         this.textBoxDescription.ReadOnly = true;
         this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.textBoxDescription.Size = new System.Drawing.Size(361, 94);
         this.textBoxDescription.TabIndex = 23;
         this.textBoxDescription.TabStop = false;
         this.textBoxDescription.Text = "Description";
         // 
         // okButton
         // 
         this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.okButton.Location = new System.Drawing.Point(452, 246);
         this.okButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.okButton.Name = "okButton";
         this.okButton.Size = new System.Drawing.Size(100, 23);
         this.okButton.TabIndex = 1;
         this.okButton.Text = "&OK";
         // 
         // frmAbout
         // 
         this.AcceptButton = this.okButton;
         this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
         this.ClientSize = new System.Drawing.Size(580, 295);
         this.Controls.Add(this.tableLayoutPanel);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "frmAbout";
         this.Padding = new System.Windows.Forms.Padding(12, 11, 12, 11);
         this.ShowIcon = false;
         this.ShowInTaskbar = false;
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "frmAbout";
         this.tableLayoutPanel.ResumeLayout(false);
         this.tableLayoutPanel.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
      private System.Windows.Forms.PictureBox logoPictureBox;
      private System.Windows.Forms.Label labelProductName;
      private System.Windows.Forms.Label labelVersion;
      private System.Windows.Forms.Label labelCopyright;
      private System.Windows.Forms.Label labelCompanyName;
      private System.Windows.Forms.TextBox textBoxDescription;
      private System.Windows.Forms.Button okButton;
      public System.Windows.Forms.TextBox txtPassword;
   }
}
