﻿namespace CV_Checking
{
   partial class frmTextEntry
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTextEntry));
         this.label1 = new System.Windows.Forms.Label();
         this.btnOK = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         this.txtBox1 = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(16, 11);
         this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(360, 33);
         this.label1.TabIndex = 0;
         this.label1.Text = "label1";
         // 
         // btnOK
         // 
         this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
         this.btnOK.Location = new System.Drawing.Point(284, 78);
         this.btnOK.Margin = new System.Windows.Forms.Padding(4);
         this.btnOK.Name = "btnOK";
         this.btnOK.Size = new System.Drawing.Size(92, 42);
         this.btnOK.TabIndex = 1;
         this.btnOK.UseVisualStyleBackColor = true;
         this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
         // 
         // btnCancel
         // 
         this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnCancel.Location = new System.Drawing.Point(184, 78);
         this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(92, 42);
         this.btnCancel.TabIndex = 2;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // txtBox1
         // 
         this.txtBox1.Location = new System.Drawing.Point(16, 48);
         this.txtBox1.Margin = new System.Windows.Forms.Padding(4);
         this.txtBox1.Name = "txtBox1";
         this.txtBox1.Size = new System.Drawing.Size(360, 22);
         this.txtBox1.TabIndex = 0;
         // 
         // frmTextEntry
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
         this.ClientSize = new System.Drawing.Size(389, 136);
         this.ControlBox = false;
         this.Controls.Add(this.txtBox1);
         this.Controls.Add(this.btnOK);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.label1);
         this.KeyPreview = true;
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "frmTextEntry";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Text Input";
         this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmTextEntry_KeyPress);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      internal System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button btnOK;
      private System.Windows.Forms.Button btnCancel;
      public System.Windows.Forms.TextBox txtBox1;

   }
}