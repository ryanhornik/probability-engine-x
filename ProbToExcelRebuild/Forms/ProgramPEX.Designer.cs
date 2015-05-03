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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.DebuggerTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CompilerBox);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
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
            this.tabControl1.Location = new System.Drawing.Point(25, 387);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(545, 226);
            this.tabControl1.TabIndex = 1;
            // 
            // DebuggerTabPage
            // 
            this.DebuggerTabPage.Controls.Add(this.DebugTextBox);
            this.DebuggerTabPage.Location = new System.Drawing.Point(4, 22);
            this.DebuggerTabPage.Name = "DebuggerTabPage";
            this.DebuggerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DebuggerTabPage.Size = new System.Drawing.Size(537, 200);
            this.DebuggerTabPage.TabIndex = 0;
            this.DebuggerTabPage.Text = "Output";
            this.DebuggerTabPage.UseVisualStyleBackColor = true;
            // 
            // DebugTextBox
            // 
            this.DebugTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DebugTextBox.Location = new System.Drawing.Point(3, 3);
            this.DebugTextBox.Name = "DebugTextBox";
            this.DebugTextBox.ReadOnly = true;
            this.DebugTextBox.Size = new System.Drawing.Size(531, 194);
            this.DebugTextBox.TabIndex = 1;
            this.DebugTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 576);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Run";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(802, 576);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProgramPEX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 649);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProgramPEX";
            this.Text = "ProgramPEX";
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.DebuggerTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox CompilerBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DebuggerTabPage;
        private System.Windows.Forms.RichTextBox DebugTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}