using System.Runtime.Remoting.Channels;

namespace ProbToExcelRebuild.Forms
{
    partial class ProgramPEX
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CompilerBox = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DebuggerTabPage = new System.Windows.Forms.TabPage();
            this.DebugTextBox = new System.Windows.Forms.RichTextBox();
            this.ErrorTabPage = new System.Windows.Forms.TabPage();
            this.ErrorTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.compileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.DebuggerTabPage.SuspendLayout();
            this.ErrorTabPage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CompilerBox);
            this.groupBox1.Location = new System.Drawing.Point(21, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(933, 369);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Console";
            // 
            // CompilerBox
            // 
            this.CompilerBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.CompilerBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompilerBox.ForeColor = System.Drawing.Color.LawnGreen;
            this.CompilerBox.Location = new System.Drawing.Point(3, 16);
            this.CompilerBox.Name = "CompilerBox";
            this.CompilerBox.Size = new System.Drawing.Size(927, 350);
            this.CompilerBox.TabIndex = 0;
            this.CompilerBox.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.DebuggerTabPage);
            this.tabControl1.Controls.Add(this.ErrorTabPage);
            this.tabControl1.Location = new System.Drawing.Point(25, 426);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(929, 211);
            this.tabControl1.TabIndex = 1;
            // 
            // DebuggerTabPage
            // 
            this.DebuggerTabPage.Controls.Add(this.DebugTextBox);
            this.DebuggerTabPage.Location = new System.Drawing.Point(4, 22);
            this.DebuggerTabPage.Name = "DebuggerTabPage";
            this.DebuggerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DebuggerTabPage.Size = new System.Drawing.Size(921, 185);
            this.DebuggerTabPage.TabIndex = 0;
            this.DebuggerTabPage.Text = "Debugger";
            this.DebuggerTabPage.UseVisualStyleBackColor = true;
            // 
            // DebugTextBox
            // 
            this.DebugTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DebugTextBox.Location = new System.Drawing.Point(3, 3);
            this.DebugTextBox.Name = "DebugTextBox";
            this.DebugTextBox.ReadOnly = true;
            this.DebugTextBox.Size = new System.Drawing.Size(915, 179);
            this.DebugTextBox.TabIndex = 0;
            this.DebugTextBox.Text = "";
            // 
            // ErrorTabPage
            // 
            this.ErrorTabPage.Controls.Add(this.ErrorTextBox);
            this.ErrorTabPage.Location = new System.Drawing.Point(4, 22);
            this.ErrorTabPage.Name = "ErrorTabPage";
            this.ErrorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ErrorTabPage.Size = new System.Drawing.Size(921, 185);
            this.ErrorTabPage.TabIndex = 1;
            this.ErrorTabPage.Text = "Errors";
            this.ErrorTabPage.UseVisualStyleBackColor = true;
            // 
            // ErrorTextBox
            // 
            this.ErrorTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorTextBox.ForeColor = System.Drawing.Color.Red;
            this.ErrorTextBox.Location = new System.Drawing.Point(3, 3);
            this.ErrorTextBox.Name = "ErrorTextBox";
            this.ErrorTextBox.ReadOnly = true;
            this.ErrorTextBox.Size = new System.Drawing.Size(915, 179);
            this.ErrorTextBox.TabIndex = 0;
            this.ErrorTextBox.Text = "";
            this.ErrorTextBox.TextChanged += new System.EventHandler(this.ErrorTextBox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            //this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.runToolStripMenuItem_Click);
            // 
            // compileToolStripMenuItem
            // 
            this.compileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.compileToolStripMenuItem.Name = "compileToolStripMenuItem";
            this.compileToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.compileToolStripMenuItem.Text = "Compile";
            this.compileToolStripMenuItem.Click += new System.EventHandler(this.compileToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // ProgramPEX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 649);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProgramPEX";
            this.Text = "ProgramPEX";
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.DebuggerTabPage.ResumeLayout(false);
            this.ErrorTabPage.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox CompilerBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DebuggerTabPage;
        private System.Windows.Forms.RichTextBox DebugTextBox;
        private System.Windows.Forms.TabPage ErrorTabPage;
        private System.Windows.Forms.RichTextBox ErrorTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem compileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
    }
}