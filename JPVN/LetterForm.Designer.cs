namespace JPVN
{
    partial class LetterForm
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
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.hiragana = new System.Windows.Forms.TabPage();
            this.btnPrevH = new System.Windows.Forms.Button();
            this.btnNextH = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSymbolH = new System.Windows.Forms.Label();
            this.txtRomanjH = new System.Windows.Forms.Label();
            this.picImageH = new System.Windows.Forms.PictureBox();
            this.katakana = new System.Windows.Forms.TabPage();
            this.btnPrev2 = new System.Windows.Forms.Button();
            this.btnNext2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.fullLetter = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabcontrol.SuspendLayout();
            this.hiragana.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageH)).BeginInit();
            this.katakana.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.hiragana);
            this.tabcontrol.Controls.Add(this.katakana);
            this.tabcontrol.Controls.Add(this.fullLetter);
            this.tabcontrol.Location = new System.Drawing.Point(12, 39);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(607, 309);
            this.tabcontrol.TabIndex = 0;
            this.tabcontrol.SelectedIndexChanged += new System.EventHandler(this.tabcontrol_SelectedIndexChanged);
            // 
            // hiragana
            // 
            this.hiragana.Controls.Add(this.btnPrevH);
            this.hiragana.Controls.Add(this.btnNextH);
            this.hiragana.Controls.Add(this.tableLayoutPanel1);
            this.hiragana.Location = new System.Drawing.Point(4, 22);
            this.hiragana.Name = "hiragana";
            this.hiragana.Padding = new System.Windows.Forms.Padding(3);
            this.hiragana.Size = new System.Drawing.Size(599, 283);
            this.hiragana.TabIndex = 0;
            this.hiragana.Text = "hiragana";
            this.hiragana.UseVisualStyleBackColor = true;
            // 
            // btnPrevH
            // 
            this.btnPrevH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevH.Location = new System.Drawing.Point(6, 252);
            this.btnPrevH.Name = "btnPrevH";
            this.btnPrevH.Size = new System.Drawing.Size(75, 23);
            this.btnPrevH.TabIndex = 3;
            this.btnPrevH.Text = "Previous";
            this.btnPrevH.UseVisualStyleBackColor = true;
            this.btnPrevH.Click += new System.EventHandler(this.btnPrevH_Click);
            // 
            // btnNextH
            // 
            this.btnNextH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextH.Location = new System.Drawing.Point(512, 252);
            this.btnNextH.Name = "btnNextH";
            this.btnNextH.Size = new System.Drawing.Size(75, 23);
            this.btnNextH.TabIndex = 2;
            this.btnNextH.Text = "Next";
            this.btnNextH.UseVisualStyleBackColor = true;
            this.btnNextH.Click += new System.EventHandler(this.btnNextH_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtSymbolH, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtRomanjH, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.picImageH, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(581, 240);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtSymbolH
            // 
            this.txtSymbolH.AutoSize = true;
            this.txtSymbolH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSymbolH.Font = new System.Drawing.Font("Microsoft Sans Serif", 129.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSymbolH.ForeColor = System.Drawing.Color.Coral;
            this.txtSymbolH.Location = new System.Drawing.Point(4, 1);
            this.txtSymbolH.Name = "txtSymbolH";
            this.txtSymbolH.Size = new System.Drawing.Size(283, 180);
            this.txtSymbolH.TabIndex = 0;
            this.txtSymbolH.Text = "あ";
            this.txtSymbolH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRomanjH
            // 
            this.txtRomanjH.AutoEllipsis = true;
            this.txtRomanjH.AutoSize = true;
            this.txtRomanjH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRomanjH.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRomanjH.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtRomanjH.Location = new System.Drawing.Point(4, 182);
            this.txtRomanjH.Name = "txtRomanjH";
            this.txtRomanjH.Size = new System.Drawing.Size(283, 57);
            this.txtRomanjH.TabIndex = 1;
            this.txtRomanjH.Text = "A";
            this.txtRomanjH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picImageH
            // 
            this.picImageH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImageH.Location = new System.Drawing.Point(294, 4);
            this.picImageH.Name = "picImageH";
            this.picImageH.Size = new System.Drawing.Size(283, 174);
            this.picImageH.TabIndex = 2;
            this.picImageH.TabStop = false;
            // 
            // katakana
            // 
            this.katakana.Controls.Add(this.btnPrev2);
            this.katakana.Controls.Add(this.btnNext2);
            this.katakana.Controls.Add(this.tableLayoutPanel2);
            this.katakana.Location = new System.Drawing.Point(4, 22);
            this.katakana.Name = "katakana";
            this.katakana.Padding = new System.Windows.Forms.Padding(3);
            this.katakana.Size = new System.Drawing.Size(599, 283);
            this.katakana.TabIndex = 1;
            this.katakana.Text = "katakana";
            this.katakana.UseVisualStyleBackColor = true;
            // 
            // btnPrev2
            // 
            this.btnPrev2.Location = new System.Drawing.Point(6, 252);
            this.btnPrev2.Name = "btnPrev2";
            this.btnPrev2.Size = new System.Drawing.Size(75, 23);
            this.btnPrev2.TabIndex = 6;
            this.btnPrev2.Text = "Previous";
            this.btnPrev2.UseVisualStyleBackColor = true;
            // 
            // btnNext2
            // 
            this.btnNext2.Location = new System.Drawing.Point(512, 254);
            this.btnNext2.Name = "btnNext2";
            this.btnNext2.Size = new System.Drawing.Size(75, 23);
            this.btnNext2.TabIndex = 5;
            this.btnNext2.Text = "Next";
            this.btnNext2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 7);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(581, 241);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // fullLetter
            // 
            this.fullLetter.Location = new System.Drawing.Point(4, 22);
            this.fullLetter.Name = "fullLetter";
            this.fullLetter.Padding = new System.Windows.Forms.Padding(3);
            this.fullLetter.Size = new System.Drawing.Size(599, 283);
            this.fullLetter.TabIndex = 2;
            this.fullLetter.Text = "Full Letter";
            this.fullLetter.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 348);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabcontrol);
            this.Name = "LetterForm";
            this.Text = "LetterForm";
            this.Load += new System.EventHandler(this.LetterForm_Load);
            this.tabcontrol.ResumeLayout(false);
            this.hiragana.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageH)).EndInit();
            this.katakana.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage hiragana;
        private System.Windows.Forms.TabPage katakana;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage fullLetter;
        private System.Windows.Forms.Button btnPrevH;
        private System.Windows.Forms.Button btnNextH;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPrev2;
        private System.Windows.Forms.Button btnNext2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label txtSymbolH;
        private System.Windows.Forms.Label txtRomanjH;
        private System.Windows.Forms.PictureBox picImageH;
    }
}