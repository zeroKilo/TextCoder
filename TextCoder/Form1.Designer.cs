namespace TextCoder
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitAndSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.addDependecyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDependecyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtb2 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtb3 = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rtb4 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.examplesToolStripMenuItem,
            this.runCodeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(681, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadInputToolStripMenuItem,
            this.loadCodeToolStripMenuItem,
            this.saveCodeToolStripMenuItem,
            this.saveOutputToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadCodeToolStripMenuItem
            // 
            this.loadCodeToolStripMenuItem.Name = "loadCodeToolStripMenuItem";
            this.loadCodeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadCodeToolStripMenuItem.Text = "Load Code";
            this.loadCodeToolStripMenuItem.Click += new System.EventHandler(this.loadCodeToolStripMenuItem_Click);
            // 
            // loadInputToolStripMenuItem
            // 
            this.loadInputToolStripMenuItem.Name = "loadInputToolStripMenuItem";
            this.loadInputToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadInputToolStripMenuItem.Text = "Load Input";
            this.loadInputToolStripMenuItem.Click += new System.EventHandler(this.loadInputToolStripMenuItem_Click);
            // 
            // saveCodeToolStripMenuItem
            // 
            this.saveCodeToolStripMenuItem.Name = "saveCodeToolStripMenuItem";
            this.saveCodeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveCodeToolStripMenuItem.Text = "Save Code";
            this.saveCodeToolStripMenuItem.Click += new System.EventHandler(this.saveCodeToolStripMenuItem_Click);
            // 
            // saveOutputToolStripMenuItem
            // 
            this.saveOutputToolStripMenuItem.Name = "saveOutputToolStripMenuItem";
            this.saveOutputToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveOutputToolStripMenuItem.Text = "Save Output";
            this.saveOutputToolStripMenuItem.Click += new System.EventHandler(this.saveOutputToolStripMenuItem_Click);
            // 
            // runCodeToolStripMenuItem
            // 
            this.runCodeToolStripMenuItem.Name = "runCodeToolStripMenuItem";
            this.runCodeToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.runCodeToolStripMenuItem.Text = "Run Code";
            this.runCodeToolStripMenuItem.Click += new System.EventHandler(this.runCodeToolStripMenuItem_Click);
            // 
            // examplesToolStripMenuItem
            // 
            this.examplesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.splitAndSortToolStripMenuItem});
            this.examplesToolStripMenuItem.Name = "examplesToolStripMenuItem";
            this.examplesToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.examplesToolStripMenuItem.Text = "Examples";
            // 
            // splitAndSortToolStripMenuItem
            // 
            this.splitAndSortToolStripMenuItem.Name = "splitAndSortToolStripMenuItem";
            this.splitAndSortToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.splitAndSortToolStripMenuItem.Text = "Split And Sort";
            this.splitAndSortToolStripMenuItem.Click += new System.EventHandler(this.splitAndSortToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(681, 383);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(673, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Code";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rtb1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(667, 351);
            this.splitContainer1.SplitterDistance = 385;
            this.splitContainer1.TabIndex = 2;
            // 
            // rtb1
            // 
            this.rtb1.AcceptsTab = true;
            this.rtb1.DetectUrls = false;
            this.rtb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb1.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.rtb1.Location = new System.Drawing.Point(0, 0);
            this.rtb1.Name = "rtb1";
            this.rtb1.Size = new System.Drawing.Size(385, 351);
            this.rtb1.TabIndex = 0;
            this.rtb1.Text = "";
            this.rtb1.WordWrap = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.listBox1);
            this.splitContainer2.Panel1.Controls.Add(this.menuStrip2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.rtb2);
            this.splitContainer2.Size = new System.Drawing.Size(278, 351);
            this.splitContainer2.SplitterDistance = 92;
            this.splitContainer2.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(0, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(278, 68);
            this.listBox1.TabIndex = 1;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDependecyToolStripMenuItem,
            this.removeDependecyToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(278, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // addDependecyToolStripMenuItem
            // 
            this.addDependecyToolStripMenuItem.Name = "addDependecyToolStripMenuItem";
            this.addDependecyToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.addDependecyToolStripMenuItem.Text = "Add Dependecy";
            this.addDependecyToolStripMenuItem.Click += new System.EventHandler(this.addDependecyToolStripMenuItem_Click);
            // 
            // removeDependecyToolStripMenuItem
            // 
            this.removeDependecyToolStripMenuItem.Name = "removeDependecyToolStripMenuItem";
            this.removeDependecyToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.removeDependecyToolStripMenuItem.Text = "Remove Dependecy";
            this.removeDependecyToolStripMenuItem.Click += new System.EventHandler(this.removeDependecyToolStripMenuItem_Click);
            // 
            // rtb2
            // 
            this.rtb2.DetectUrls = false;
            this.rtb2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb2.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.rtb2.Location = new System.Drawing.Point(0, 0);
            this.rtb2.Name = "rtb2";
            this.rtb2.Size = new System.Drawing.Size(278, 255);
            this.rtb2.TabIndex = 4;
            this.rtb2.Text = "";
            this.rtb2.WordWrap = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtb3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(673, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Input";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtb3
            // 
            this.rtb3.DetectUrls = false;
            this.rtb3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb3.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.rtb3.Location = new System.Drawing.Point(3, 3);
            this.rtb3.Name = "rtb3";
            this.rtb3.Size = new System.Drawing.Size(667, 351);
            this.rtb3.TabIndex = 2;
            this.rtb3.Text = "";
            this.rtb3.WordWrap = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rtb4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(673, 357);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Output";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rtb4
            // 
            this.rtb4.DetectUrls = false;
            this.rtb4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb4.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.rtb4.Location = new System.Drawing.Point(3, 3);
            this.rtb4.Name = "rtb4";
            this.rtb4.Size = new System.Drawing.Size(667, 351);
            this.rtb4.TabIndex = 3;
            this.rtb4.Text = "";
            this.rtb4.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 407);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Text Coder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadInputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveOutputToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox rtb1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox rtb3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox rtb4;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.RichTextBox rtb2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem addDependecyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeDependecyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem splitAndSortToolStripMenuItem;

    }
}

