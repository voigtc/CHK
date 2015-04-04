namespace CV_Checking
{
   partial class Bucket_ListView
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

      #region Component Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bucket_ListView));
         this.btnIncrement = new System.Windows.Forms.Button();
         this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
         this.SuspendLayout();
         // 
         // btnIncrement
         // 
         this.btnIncrement.Image = ((System.Drawing.Image)(resources.GetObject("btnIncrement.Image")));
         this.btnIncrement.Location = new System.Drawing.Point(0, 0);
         this.btnIncrement.Name = "btnIncrement";
         this.btnIncrement.Size = new System.Drawing.Size(75, 23);
         this.btnIncrement.TabIndex = 0;
         this.toolTip1.SetToolTip(this.btnIncrement, "Increment this bucket\'s value by the increment amount");
         this.btnIncrement.UseVisualStyleBackColor = true;
         this.btnIncrement.Visible = false;
         this.btnIncrement.MouseLeave += new System.EventHandler(this.btnIncrement_MouseLeave);
         this.btnIncrement.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnIncrement_MouseMove);
         this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click);
         // 
         // Bucket_ListView
         // 
         this.Controls.Add(this.btnIncrement);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button btnIncrement;
      private System.Windows.Forms.ToolTip toolTip1;
   }
}
