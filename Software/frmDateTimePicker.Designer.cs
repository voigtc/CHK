namespace CV_Checking
{
   partial class frmDateTimePicker
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
         this.dtPicker = new System.Windows.Forms.DateTimePicker();
         this.btnExport = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         this.txtFilename = new System.Windows.Forms.TextBox();
         this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
         this.SuspendLayout();
         // 
         // dtPicker
         // 
         this.dtPicker.Location = new System.Drawing.Point(16, 47);
         this.dtPicker.Margin = new System.Windows.Forms.Padding(4);
         this.dtPicker.Name = "dtPicker";
         this.dtPicker.Size = new System.Drawing.Size(345, 22);
         this.dtPicker.TabIndex = 0;
         this.dtPicker.Value = new System.DateTime(2012, 1, 1, 0, 0, 0, 0);
         // 
         // btnExport
         // 
         this.btnExport.BackColor = System.Drawing.SystemColors.Control;
         this.btnExport.DialogResult = System.Windows.Forms.DialogResult.OK;
         this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnExport.Location = new System.Drawing.Point(204, 79);
         this.btnExport.Margin = new System.Windows.Forms.Padding(4);
         this.btnExport.Name = "btnExport";
         this.btnExport.Size = new System.Drawing.Size(159, 42);
         this.btnExport.TabIndex = 2;
         this.btnExport.Text = "E&xport";
         this.btnExport.UseVisualStyleBackColor = false;
         // 
         // btnCancel
         // 
         this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
         this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
         this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnCancel.Location = new System.Drawing.Point(16, 79);
         this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(159, 42);
         this.btnCancel.TabIndex = 1;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = false;
         // 
         // txtFilename
         // 
         this.txtFilename.Location = new System.Drawing.Point(16, 15);
         this.txtFilename.Margin = new System.Windows.Forms.Padding(4);
         this.txtFilename.Name = "txtFilename";
         this.txtFilename.Size = new System.Drawing.Size(345, 22);
         this.txtFilename.TabIndex = 3;
         this.txtFilename.Text = "CHK_Archive";
         this.txtFilename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         this.toolTip1.SetToolTip(this.txtFilename, "Enter Archive File Name (or use default)");
         // 
         // frmDateTimePicker
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
         this.ClientSize = new System.Drawing.Size(379, 134);
         this.ControlBox = false;
         this.Controls.Add(this.txtFilename);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.btnExport);
         this.Controls.Add(this.dtPicker);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "frmDateTimePicker";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Select Date to Export up to";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnExport;
      private System.Windows.Forms.Button btnCancel;
      public System.Windows.Forms.TextBox txtFilename;
      public System.Windows.Forms.DateTimePicker dtPicker;
      private System.Windows.Forms.ToolTip toolTip1;
   }
}