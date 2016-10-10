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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LetterForm));
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.hiragana = new System.Windows.Forms.TabPage();
            this.btnPrevH = new System.Windows.Forms.Button();
            this.btnNextH = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSymbolH = new System.Windows.Forms.Label();
            this.txtRomanjH = new System.Windows.Forms.Label();
            this.picImageH = new System.Windows.Forms.PictureBox();
            this.pictureSpeaker = new System.Windows.Forms.PictureBox();
            this.katakana = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtSymbolK = new System.Windows.Forms.Label();
            this.txtRomanjK = new System.Windows.Forms.Label();
            this.pictureImageK = new System.Windows.Forms.PictureBox();
            this.pictureSpeakerK = new System.Windows.Forms.PictureBox();
            this.btnPrevK = new System.Windows.Forms.Button();
            this.btnNextK = new System.Windows.Forms.Button();
            this.fullLetterH = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.panelcontrol = new System.Windows.Forms.Panel();
            this.panelShow = new System.Windows.Forms.Panel();
            this.fullLetterK = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picFullK = new System.Windows.Forms.PictureBox();
            this.picFullH = new System.Windows.Forms.PictureBox();
            this.tabcontrol.SuspendLayout();
            this.hiragana.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpeaker)).BeginInit();
            this.katakana.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImageK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpeakerK)).BeginInit();
            this.fullLetterH.SuspendLayout();
            this.panelcontrol.SuspendLayout();
            this.panelShow.SuspendLayout();
            this.fullLetterK.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFullK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFullH)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.hiragana);
            this.tabcontrol.Controls.Add(this.katakana);
            this.tabcontrol.Controls.Add(this.fullLetterH);
            this.tabcontrol.Controls.Add(this.fullLetterK);
            this.tabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol.Location = new System.Drawing.Point(0, 0);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(615, 309);
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
            this.hiragana.Size = new System.Drawing.Size(607, 283);
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
            this.btnNextH.Location = new System.Drawing.Point(520, 252);
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
            this.tableLayoutPanel1.Controls.Add(this.pictureSpeaker, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(601, 240);
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
            this.txtSymbolH.Size = new System.Drawing.Size(293, 180);
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
            this.txtRomanjH.Size = new System.Drawing.Size(293, 57);
            this.txtRomanjH.TabIndex = 1;
            this.txtRomanjH.Text = "A";
            this.txtRomanjH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picImageH
            // 
            this.picImageH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImageH.Location = new System.Drawing.Point(304, 4);
            this.picImageH.Name = "picImageH";
            this.picImageH.Size = new System.Drawing.Size(293, 174);
            this.picImageH.TabIndex = 2;
            this.picImageH.TabStop = false;
            // 
            // pictureSpeaker
            // 
            this.pictureSpeaker.Image = ((System.Drawing.Image)(resources.GetObject("pictureSpeaker.Image")));
            this.pictureSpeaker.Location = new System.Drawing.Point(421, 185);
            this.pictureSpeaker.Margin = new System.Windows.Forms.Padding(120, 3, 3, 3);
            this.pictureSpeaker.Name = "pictureSpeaker";
            this.pictureSpeaker.Size = new System.Drawing.Size(72, 46);
            this.pictureSpeaker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSpeaker.TabIndex = 3;
            this.pictureSpeaker.TabStop = false;
            this.pictureSpeaker.Click += new System.EventHandler(this.pictureSpeaker_Click);
            // 
            // katakana
            // 
            this.katakana.Controls.Add(this.tableLayoutPanel2);
            this.katakana.Controls.Add(this.btnPrevK);
            this.katakana.Controls.Add(this.btnNextK);
            this.katakana.Location = new System.Drawing.Point(4, 22);
            this.katakana.Name = "katakana";
            this.katakana.Padding = new System.Windows.Forms.Padding(3);
            this.katakana.Size = new System.Drawing.Size(607, 283);
            this.katakana.TabIndex = 1;
            this.katakana.Text = "katakana";
            this.katakana.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.txtSymbolK, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtRomanjK, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pictureImageK, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureSpeakerK, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(601, 240);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // txtSymbolK
            // 
            this.txtSymbolK.AutoSize = true;
            this.txtSymbolK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSymbolK.Font = new System.Drawing.Font("Microsoft Sans Serif", 129.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSymbolK.ForeColor = System.Drawing.Color.Coral;
            this.txtSymbolK.Location = new System.Drawing.Point(4, 1);
            this.txtSymbolK.Name = "txtSymbolK";
            this.txtSymbolK.Size = new System.Drawing.Size(293, 180);
            this.txtSymbolK.TabIndex = 0;
            this.txtSymbolK.Text = "あ";
            this.txtSymbolK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRomanjK
            // 
            this.txtRomanjK.AutoEllipsis = true;
            this.txtRomanjK.AutoSize = true;
            this.txtRomanjK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRomanjK.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRomanjK.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtRomanjK.Location = new System.Drawing.Point(4, 182);
            this.txtRomanjK.Name = "txtRomanjK";
            this.txtRomanjK.Size = new System.Drawing.Size(293, 57);
            this.txtRomanjK.TabIndex = 1;
            this.txtRomanjK.Text = "A";
            this.txtRomanjK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureImageK
            // 
            this.pictureImageK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureImageK.Location = new System.Drawing.Point(304, 4);
            this.pictureImageK.Name = "pictureImageK";
            this.pictureImageK.Size = new System.Drawing.Size(293, 174);
            this.pictureImageK.TabIndex = 2;
            this.pictureImageK.TabStop = false;
            // 
            // pictureSpeakerK
            // 
            this.pictureSpeakerK.Image = ((System.Drawing.Image)(resources.GetObject("pictureSpeakerK.Image")));
            this.pictureSpeakerK.Location = new System.Drawing.Point(421, 185);
            this.pictureSpeakerK.Margin = new System.Windows.Forms.Padding(120, 3, 3, 3);
            this.pictureSpeakerK.Name = "pictureSpeakerK";
            this.pictureSpeakerK.Size = new System.Drawing.Size(72, 46);
            this.pictureSpeakerK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSpeakerK.TabIndex = 3;
            this.pictureSpeakerK.TabStop = false;
            this.pictureSpeakerK.Click += new System.EventHandler(this.pictureSpeakerK_Click);
            // 
            // btnPrevK
            // 
            this.btnPrevK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrevK.Location = new System.Drawing.Point(6, 252);
            this.btnPrevK.Name = "btnPrevK";
            this.btnPrevK.Size = new System.Drawing.Size(75, 23);
            this.btnPrevK.TabIndex = 6;
            this.btnPrevK.Text = "Previous";
            this.btnPrevK.UseVisualStyleBackColor = true;
            this.btnPrevK.Click += new System.EventHandler(this.btnPrevK_Click);
            // 
            // btnNextK
            // 
            this.btnNextK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextK.Location = new System.Drawing.Point(524, 254);
            this.btnNextK.Name = "btnNextK";
            this.btnNextK.Size = new System.Drawing.Size(75, 23);
            this.btnNextK.TabIndex = 5;
            this.btnNextK.Text = "Next";
            this.btnNextK.UseVisualStyleBackColor = true;
            this.btnNextK.Click += new System.EventHandler(this.btnNextK_Click);
            // 
            // fullLetterH
            // 
            this.fullLetterH.Controls.Add(this.panel1);
            this.fullLetterH.Location = new System.Drawing.Point(4, 22);
            this.fullLetterH.Name = "fullLetterH";
            this.fullLetterH.Padding = new System.Windows.Forms.Padding(3);
            this.fullLetterH.Size = new System.Drawing.Size(607, 283);
            this.fullLetterH.TabIndex = 2;
            this.fullLetterH.Text = "Full Hiraganna";
            this.fullLetterH.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelcontrol
            // 
            this.panelcontrol.Controls.Add(this.button1);
            this.panelcontrol.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelcontrol.Location = new System.Drawing.Point(0, 0);
            this.panelcontrol.Name = "panelcontrol";
            this.panelcontrol.Size = new System.Drawing.Size(615, 39);
            this.panelcontrol.TabIndex = 2;
            // 
            // panelShow
            // 
            this.panelShow.Controls.Add(this.tabcontrol);
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Location = new System.Drawing.Point(0, 39);
            this.panelShow.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(615, 309);
            this.panelShow.TabIndex = 3;
            // 
            // fullLetterK
            // 
            this.fullLetterK.Controls.Add(this.panel2);
            this.fullLetterK.Location = new System.Drawing.Point(4, 22);
            this.fullLetterK.Name = "fullLetterK";
            this.fullLetterK.Padding = new System.Windows.Forms.Padding(3);
            this.fullLetterK.Size = new System.Drawing.Size(607, 283);
            this.fullLetterK.TabIndex = 3;
            this.fullLetterK.Text = "Full Katakana";
            this.fullLetterK.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picFullH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 277);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picFullK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 277);
            this.panel2.TabIndex = 0;
            // 
            // picFullK
            // 
            this.picFullK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFullK.Image = ((System.Drawing.Image)(resources.GetObject("picFullK.Image")));
            this.picFullK.Location = new System.Drawing.Point(0, 0);
            this.picFullK.Name = "picFullK";
            this.picFullK.Size = new System.Drawing.Size(601, 277);
            this.picFullK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFullK.TabIndex = 0;
            this.picFullK.TabStop = false;
            // 
            // picFullH
            // 
            this.picFullH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFullH.Image = ((System.Drawing.Image)(resources.GetObject("picFullH.Image")));
            this.picFullH.Location = new System.Drawing.Point(0, 0);
            this.picFullH.Name = "picFullH";
            this.picFullH.Size = new System.Drawing.Size(601, 277);
            this.picFullH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFullH.TabIndex = 0;
            this.picFullH.TabStop = false;
            // 
            // LetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 348);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panelcontrol);
            this.Name = "LetterForm";
            this.Text = "LetterForm";
            this.Load += new System.EventHandler(this.LetterForm_Load);
            this.tabcontrol.ResumeLayout(false);
            this.hiragana.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpeaker)).EndInit();
            this.katakana.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImageK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpeakerK)).EndInit();
            this.fullLetterH.ResumeLayout(false);
            this.panelcontrol.ResumeLayout(false);
            this.panelShow.ResumeLayout(false);
            this.fullLetterK.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFullK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFullH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage hiragana;
        private System.Windows.Forms.TabPage katakana;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage fullLetterH;
        private System.Windows.Forms.Button btnPrevH;
        private System.Windows.Forms.Button btnNextH;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnPrevK;
        private System.Windows.Forms.Button btnNextK;
        private System.Windows.Forms.Label txtSymbolH;
        private System.Windows.Forms.Label txtRomanjH;
        private System.Windows.Forms.PictureBox picImageH;
        private System.Windows.Forms.PictureBox pictureSpeaker;
        private System.Windows.Forms.Panel panelcontrol;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label txtSymbolK;
        private System.Windows.Forms.Label txtRomanjK;
        private System.Windows.Forms.PictureBox pictureImageK;
        private System.Windows.Forms.PictureBox pictureSpeakerK;
        private System.Windows.Forms.TabPage fullLetterK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picFullH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picFullK;
    }
}