﻿namespace JPVN
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
            this.btnLearnLetter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLearnLetter
            // 
            this.btnLearnLetter.Location = new System.Drawing.Point(175, 124);
            this.btnLearnLetter.Name = "btnLearnLetter";
            this.btnLearnLetter.Size = new System.Drawing.Size(75, 23);
            this.btnLearnLetter.TabIndex = 0;
            this.btnLearnLetter.Text = "Learn Letter";
            this.btnLearnLetter.UseVisualStyleBackColor = true;
            this.btnLearnLetter.Click += new System.EventHandler(this.btnLearnLetter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 396);
            this.Controls.Add(this.btnLearnLetter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLearnLetter;



    }
}

