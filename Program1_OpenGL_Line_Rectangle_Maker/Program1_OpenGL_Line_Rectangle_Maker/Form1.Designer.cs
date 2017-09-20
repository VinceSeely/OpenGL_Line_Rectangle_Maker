namespace Program1_OpenGL_Line_Rectangle_Maker
{
   partial class Form1
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
         this.glControl1 = new OpenTK.GLControl();
         this.FigureType = new System.Windows.Forms.ComboBox();
         this.FigureColor = new System.Windows.Forms.ComboBox();
         this.LineWidth = new System.Windows.Forms.NumericUpDown();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.LineWidth)).BeginInit();
         this.SuspendLayout();
         // 
         // glControl1
         // 
         this.glControl1.BackColor = System.Drawing.Color.Black;
         this.glControl1.Location = new System.Drawing.Point(12, 73);
         this.glControl1.Name = "glControl1";
         this.glControl1.Size = new System.Drawing.Size(700, 540);
         this.glControl1.TabIndex = 0;
         this.glControl1.VSync = false;
         this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
         this.glControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseDown);
         this.glControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseMove);
         this.glControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.glControl1_MouseUp);
         // 
         // FigureType
         // 
         this.FigureType.FormattingEnabled = true;
         this.FigureType.Location = new System.Drawing.Point(86, 30);
         this.FigureType.Name = "FigureType";
         this.FigureType.Size = new System.Drawing.Size(121, 21);
         this.FigureType.TabIndex = 1;
         // 
         // FigureColor
         // 
         this.FigureColor.FormattingEnabled = true;
         this.FigureColor.Location = new System.Drawing.Point(235, 29);
         this.FigureColor.Name = "FigureColor";
         this.FigureColor.Size = new System.Drawing.Size(121, 21);
         this.FigureColor.TabIndex = 2;
         // 
         // LineWidth
         // 
         this.LineWidth.Location = new System.Drawing.Point(383, 30);
         this.LineWidth.Name = "LineWidth";
         this.LineWidth.Size = new System.Drawing.Size(120, 20);
         this.LineWidth.TabIndex = 3;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(86, 11);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(63, 13);
         this.label1.TabIndex = 4;
         this.label1.Text = "Figure Type";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(232, 9);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(63, 13);
         this.label2.TabIndex = 5;
         this.label2.Text = "Figure Color";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(380, 9);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(58, 13);
         this.label3.TabIndex = 6;
         this.label3.Text = "Line Width";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(724, 625);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.LineWidth);
         this.Controls.Add(this.FigureColor);
         this.Controls.Add(this.FigureType);
         this.Controls.Add(this.glControl1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.Shown += new System.EventHandler(this.Form1_Shown);
         ((System.ComponentModel.ISupportInitialize)(this.LineWidth)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private OpenTK.GLControl glControl1;
      private System.Windows.Forms.ComboBox FigureType;
      private System.Windows.Forms.ComboBox FigureColor;
      private System.Windows.Forms.NumericUpDown LineWidth;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
   }
}

