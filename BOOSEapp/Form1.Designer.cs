using System;
using System.Windows.Forms;

namespace BOOSEapp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtProgram;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRun;

        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="Form1"/> 
        /// and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing">
        /// True to release both managed and unmanaged resources; false to release only unmanaged resources.
        /// </param>
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
        /// Required method for Designer support — do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();

            // 
            // txtProgram
            // 
            this.txtProgram.Location = new System.Drawing.Point(12, 12);
            this.txtProgram.Multiline = true;
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.ScrollBars = ScrollBars.Vertical;
            this.txtProgram.Size = new System.Drawing.Size(300, 400);
            this.txtProgram.TabIndex = 0;

            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(330, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 500);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.BorderStyle = BorderStyle.FixedSingle;

            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(12, 430);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(100, 30);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 550);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtProgram);
            this.Name = "Form1";
            this.Text = "BOOSE Drawing App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
