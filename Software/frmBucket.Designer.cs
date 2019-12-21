namespace CV_Checking
{
   partial class frmBucket
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBucket));
         this.label1 = new System.Windows.Forms.Label();
         this.txtDescription = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.btnCancel = new System.Windows.Forms.Button();
         this.btnOK = new System.Windows.Forms.Button();
         this.label3 = new System.Windows.Forms.Label();
         this.udAmount = new System.Windows.Forms.NumericUpDown();
         this.udIncrement = new System.Windows.Forms.NumericUpDown();
         this.btnDelete = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.udAmount)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.udIncrement)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(13, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(71, 20);
         this.label1.TabIndex = 17;
         this.label1.Text = "Amount";
         // 
         // txtDescription
         // 
         this.txtDescription.BackColor = System.Drawing.SystemColors.ControlLightLight;
         this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtDescription.Location = new System.Drawing.Point(126, 38);
         this.txtDescription.Name = "txtDescription";
         this.txtDescription.Size = new System.Drawing.Size(324, 26);
         this.txtDescription.TabIndex = 2;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(13, 42);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(100, 20);
         this.label2.TabIndex = 19;
         this.label2.Text = "Description";
         // 
         // btnCancel
         // 
         this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnCancel.Location = new System.Drawing.Point(318, 70);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(74, 34);
         this.btnCancel.TabIndex = 4;
         this.btnCancel.Text = "Cancel";
         this.btnCancel.UseVisualStyleBackColor = true;
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // btnOK
         // 
         this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
         this.btnOK.Location = new System.Drawing.Point(403, 70);
         this.btnOK.Name = "btnOK";
         this.btnOK.Size = new System.Drawing.Size(47, 34);
         this.btnOK.TabIndex = 3;
         this.btnOK.UseVisualStyleBackColor = true;
         this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(257, 9);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(90, 20);
         this.label3.TabIndex = 23;
         this.label3.Text = "Increment";
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
         this.udAmount.Location = new System.Drawing.Point(126, 7);
         this.udAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
         this.udAmount.Name = "udAmount";
         this.udAmount.Size = new System.Drawing.Size(109, 26);
         this.udAmount.TabIndex = 0;
         this.udAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // udIncrement
         // 
         this.udIncrement.DecimalPlaces = 2;
         this.udIncrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.udIncrement.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
         this.udIncrement.Location = new System.Drawing.Point(359, 7);
         this.udIncrement.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
         this.udIncrement.Name = "udIncrement";
         this.udIncrement.Size = new System.Drawing.Size(90, 26);
         this.udIncrement.TabIndex = 1;
         this.udIncrement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // btnDelete
         // 
         this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
         this.btnDelete.Location = new System.Drawing.Point(262, 70);
         this.btnDelete.Name = "btnDelete";
         this.btnDelete.Size = new System.Drawing.Size(47, 34);
         this.btnDelete.TabIndex = 29;
         this.btnDelete.TabStop = false;
         this.btnDelete.UseVisualStyleBackColor = true;
         this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
         // 
         // frmBucket
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(460, 111);
         this.ControlBox = false;
         this.Controls.Add(this.btnDelete);
         this.Controls.Add(this.udIncrement);
         this.Controls.Add(this.udAmount);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.btnOK);
         this.Controls.Add(this.btnCancel);
         this.Controls.Add(this.txtDescription);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.KeyPreview = true;
         this.Name = "frmBucket";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Bucket";
         this.Load += new System.EventHandler(this.frmBucket_Load);
         this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmBucket_KeyPress);
         ((System.ComponentModel.ISupportInitialize)(this.udAmount)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.udIncrement)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtDescription;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button btnCancel;
      private System.Windows.Forms.Button btnOK;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.NumericUpDown udAmount;
      private System.Windows.Forms.NumericUpDown udIncrement;
      private System.Windows.Forms.Button btnDelete;
   }
}