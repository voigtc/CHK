namespace CV_Checking
{
   partial class frmNumericEntry
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNumericEntry));
         this.label1 = new System.Windows.Forms.Label();
         this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
         this.btnOK = new System.Windows.Forms.Button();
         this.btnCancel = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(16, 11);
         this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(343, 33);
         this.label1.TabIndex = 0;
         this.label1.Text = "label1";
         // 
         // numericUpDown1
         // 
         this.numericUpDown1.DecimalPlaces = 2;
         this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.numericUpDown1.Location = new System.Drawing.Point(92, 48);
         this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.numericUpDown1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
         this.numericUpDown1.Name = "numericUpDown1";
         this.numericUpDown1.Size = new System.Drawing.Size(199, 30);
         this.numericUpDown1.TabIndex = 1;
         this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // btnOK
         // 
         this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
         this.btnOK.Location = new System.Drawing.Point(315, 103);
         this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.btnOK.Name = "btnOK";
         this.btnOK.Size = new System.Drawing.Size(59, 42);
         this.btnOK.TabIndex = 7;
         this.btnOK.UseVisualStyleBackColor = true;
         this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
         // 
         // btnCancel
         // 
         this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnCancel.Location = new System.Drawing.Point(208, 103);
         this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(92, 42);
         this.btnCancel.TabIndex = 8;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // frmNumericEntry
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(389, 160);
         this.ControlBox = false;
         this.Controls.Add(this.btnOK);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.numericUpDown1);
         this.Controls.Add(this.label1);
         this.KeyPreview = true;
         this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
         this.Name = "frmNumericEntry";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Numeric Input";
         this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmNumericEntry_KeyPress);
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      internal System.Windows.Forms.Label label1;
      internal System.Windows.Forms.NumericUpDown numericUpDown1;
      private System.Windows.Forms.Button btnOK;
      private System.Windows.Forms.Button btnCancel;

   }
}