namespace JPVN
{
    partial class DetailLession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailLession));
            this.pnlScreen = new System.Windows.Forms.Panel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabNewWord = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrevNewWord = new System.Windows.Forms.Button();
            this.btnNextNewWord = new System.Windows.Forms.Button();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.lblRomanj = new System.Windows.Forms.Label();
            this.tabListening = new System.Windows.Forms.TabPage();
            this.btnCheckListening = new System.Windows.Forms.Button();
            this.pnlAnswer = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.youtube = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.tabReading = new System.Windows.Forms.TabPage();
            this.tabGramma = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnPrevL = new System.Windows.Forms.Button();
            this.btnNextL = new System.Windows.Forms.Button();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabNewWord.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.tabListening.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.youtube)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlScreen
            // 
            this.pnlScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScreen.Location = new System.Drawing.Point(0, 0);
            this.pnlScreen.Name = "pnlScreen";
            this.pnlScreen.Size = new System.Drawing.Size(587, 402);
            this.pnlScreen.TabIndex = 1;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.pnlScreen);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(587, 402);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(587, 427);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabNewWord);
            this.tabControl1.Controls.Add(this.tabListening);
            this.tabControl1.Controls.Add(this.tabReading);
            this.tabControl1.Controls.Add(this.tabGramma);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(587, 402);
            this.tabControl1.TabIndex = 1;
            // 
            // tabNewWord
            // 
            this.tabNewWord.Controls.Add(this.panel1);
            this.tabNewWord.Controls.Add(this.pnlDisplay);
            this.tabNewWord.Location = new System.Drawing.Point(4, 22);
            this.tabNewWord.Name = "tabNewWord";
            this.tabNewWord.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewWord.Size = new System.Drawing.Size(579, 321);
            this.tabNewWord.TabIndex = 0;
            this.tabNewWord.Text = "Từ vựng";
            this.tabNewWord.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrevNewWord);
            this.panel1.Controls.Add(this.btnNextNewWord);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 31);
            this.panel1.TabIndex = 5;
            // 
            // btnPrevNewWord
            // 
            this.btnPrevNewWord.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrevNewWord.Location = new System.Drawing.Point(170, 3);
            this.btnPrevNewWord.Name = "btnPrevNewWord";
            this.btnPrevNewWord.Size = new System.Drawing.Size(75, 23);
            this.btnPrevNewWord.TabIndex = 1;
            this.btnPrevNewWord.Text = "Previous";
            this.btnPrevNewWord.UseVisualStyleBackColor = true;
            this.btnPrevNewWord.Click += new System.EventHandler(this.btnPrevNewWord_Click);
            // 
            // btnNextNewWord
            // 
            this.btnNextNewWord.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNextNewWord.Location = new System.Drawing.Point(305, 3);
            this.btnNextNewWord.Name = "btnNextNewWord";
            this.btnNextNewWord.Size = new System.Drawing.Size(75, 23);
            this.btnNextNewWord.TabIndex = 2;
            this.btnNextNewWord.Text = "Next";
            this.btnNextNewWord.UseVisualStyleBackColor = true;
            this.btnNextNewWord.Click += new System.EventHandler(this.btnNextNewWord_Click);
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Controls.Add(this.txtMeaning);
            this.pnlDisplay.Controls.Add(this.picImage);
            this.pnlDisplay.Controls.Add(this.lblSymbol);
            this.pnlDisplay.Controls.Add(this.lblRomanj);
            this.pnlDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDisplay.Location = new System.Drawing.Point(3, 3);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(573, 283);
            this.pnlDisplay.TabIndex = 3;
            this.pnlDisplay.Click += new System.EventHandler(this.pnlDisplay_Click);
            this.pnlDisplay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlDisplay_MouseClick);
            // 
            // txtMeaning
            // 
            this.txtMeaning.BackColor = System.Drawing.SystemColors.Info;
            this.txtMeaning.Enabled = false;
            this.txtMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeaning.Location = new System.Drawing.Point(160, 50);
            this.txtMeaning.Multiline = true;
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.Size = new System.Drawing.Size(296, 89);
            this.txtMeaning.TabIndex = 3;
            this.txtMeaning.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(193, 159);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(228, 93);
            this.picImage.TabIndex = 2;
            this.picImage.TabStop = false;
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymbol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSymbol.Location = new System.Drawing.Point(211, 39);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(210, 73);
            this.lblSymbol.TabIndex = 1;
            this.lblSymbol.Text = "label2";
            this.lblSymbol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRomanj
            // 
            this.lblRomanj.AutoSize = true;
            this.lblRomanj.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRomanj.Location = new System.Drawing.Point(211, 159);
            this.lblRomanj.Name = "lblRomanj";
            this.lblRomanj.Size = new System.Drawing.Size(210, 73);
            this.lblRomanj.TabIndex = 0;
            this.lblRomanj.Text = "label1";
            this.lblRomanj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabListening
            // 
            this.tabListening.Controls.Add(this.btnNextL);
            this.tabListening.Controls.Add(this.btnPrevL);
            this.tabListening.Controls.Add(this.btnCheckListening);
            this.tabListening.Controls.Add(this.pnlAnswer);
            this.tabListening.Controls.Add(this.richTextBox1);
            this.tabListening.Controls.Add(this.youtube);
            this.tabListening.Location = new System.Drawing.Point(4, 22);
            this.tabListening.Name = "tabListening";
            this.tabListening.Padding = new System.Windows.Forms.Padding(3);
            this.tabListening.Size = new System.Drawing.Size(579, 376);
            this.tabListening.TabIndex = 1;
            this.tabListening.Text = "Nghe Hiểu";
            this.tabListening.UseVisualStyleBackColor = true;
            // 
            // btnCheckListening
            // 
            this.btnCheckListening.Location = new System.Drawing.Point(471, 299);
            this.btnCheckListening.Name = "btnCheckListening";
            this.btnCheckListening.Size = new System.Drawing.Size(75, 23);
            this.btnCheckListening.TabIndex = 3;
            this.btnCheckListening.Text = "Check";
            this.btnCheckListening.UseVisualStyleBackColor = true;
            this.btnCheckListening.Click += new System.EventHandler(this.btnCheckListening_Click);
            // 
            // pnlAnswer
            // 
            this.pnlAnswer.ColumnCount = 2;
            this.pnlAnswer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.4138F));
            this.pnlAnswer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.58621F));
            this.pnlAnswer.Location = new System.Drawing.Point(285, 61);
            this.pnlAnswer.Name = "pnlAnswer";
            this.pnlAnswer.RowCount = 2;
            this.pnlAnswer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlAnswer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlAnswer.Size = new System.Drawing.Size(261, 230);
            this.pnlAnswer.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 61);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(276, 257);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // youtube
            // 
            this.youtube.Dock = System.Windows.Forms.DockStyle.Top;
            this.youtube.Enabled = true;
            this.youtube.Location = new System.Drawing.Point(3, 3);
            this.youtube.Name = "youtube";
            this.youtube.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("youtube.OcxState")));
            this.youtube.Size = new System.Drawing.Size(573, 58);
            this.youtube.TabIndex = 0;
            // 
            // tabReading
            // 
            this.tabReading.Location = new System.Drawing.Point(4, 22);
            this.tabReading.Name = "tabReading";
            this.tabReading.Padding = new System.Windows.Forms.Padding(3);
            this.tabReading.Size = new System.Drawing.Size(579, 321);
            this.tabReading.TabIndex = 2;
            this.tabReading.Text = "Đọc Hiểu";
            this.tabReading.UseVisualStyleBackColor = true;
            // 
            // tabGramma
            // 
            this.tabGramma.Location = new System.Drawing.Point(4, 22);
            this.tabGramma.Name = "tabGramma";
            this.tabGramma.Padding = new System.Windows.Forms.Padding(3);
            this.tabGramma.Size = new System.Drawing.Size(579, 321);
            this.tabGramma.TabIndex = 3;
            this.tabGramma.Text = "Ngữ Pháp";
            this.tabGramma.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(64, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnPrevL
            // 
            this.btnPrevL.Location = new System.Drawing.Point(55, 339);
            this.btnPrevL.Name = "btnPrevL";
            this.btnPrevL.Size = new System.Drawing.Size(75, 23);
            this.btnPrevL.TabIndex = 4;
            this.btnPrevL.Text = "Previous";
            this.btnPrevL.UseVisualStyleBackColor = true;
            this.btnPrevL.Click += new System.EventHandler(this.btnPrevL_Click);
            // 
            // btnNextL
            // 
            this.btnNextL.Location = new System.Drawing.Point(441, 339);
            this.btnNextL.Name = "btnNextL";
            this.btnNextL.Size = new System.Drawing.Size(75, 23);
            this.btnNextL.TabIndex = 5;
            this.btnNextL.Text = "Next";
            this.btnNextL.UseVisualStyleBackColor = true;
            this.btnNextL.Click += new System.EventHandler(this.btnNextL_Click);
            // 
            // DetailLession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 427);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "DetailLession";
            this.Text = "DetailLession";
            this.Load += new System.EventHandler(this.DetailLession_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabNewWord.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlDisplay.ResumeLayout(false);
            this.pnlDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.tabListening.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.youtube)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlScreen;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabNewWord;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrevNewWord;
        private System.Windows.Forms.Button btnNextNewWord;
        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.TabPage tabListening;
        private System.Windows.Forms.TabPage tabReading;
        private System.Windows.Forms.TabPage tabGramma;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.Label lblRomanj;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.TextBox txtMeaning;
        private AxShockwaveFlashObjects.AxShockwaveFlash youtube;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TableLayoutPanel pnlAnswer;
        private System.Windows.Forms.Button btnCheckListening;
        private System.Windows.Forms.Button btnNextL;
        private System.Windows.Forms.Button btnPrevL;

    }
}