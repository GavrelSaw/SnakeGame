namespace Snake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.boardPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.snakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.levelLBL = new System.Windows.Forms.Label();
            this.timerLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scoreLBL = new System.Windows.Forms.Label();
            this.lblDebug = new System.Windows.Forms.Label();
            this.pauseLBL = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // boardPanel
            // 
            this.boardPanel.Location = new System.Drawing.Point(3, 32);
            this.boardPanel.Name = "boardPanel";
            this.boardPanel.Size = new System.Drawing.Size(200, 100);
            this.boardPanel.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.snakeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(609, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // snakeToolStripMenuItem
            // 
            this.snakeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.snakeToolStripMenuItem.Name = "snakeToolStripMenuItem";
            this.snakeToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.snakeToolStripMenuItem.Text = "snake";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.settingsToolStripMenuItem.Text = "settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.BackgroundImage = global::Snake.Resource1.bground_07;
            this.controlPanel.Controls.Add(this.panel1);
            this.controlPanel.Controls.Add(this.lblDebug);
            this.controlPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.controlPanel.Location = new System.Drawing.Point(0, 137);
            this.controlPanel.Margin = new System.Windows.Forms.Padding(2);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(605, 100);
            this.controlPanel.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.levelLBL);
            this.panel1.Controls.Add(this.timerLBL);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.scoreLBL);
            this.panel1.Location = new System.Drawing.Point(12, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 100);
            this.panel1.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(115, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 73);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 52);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter - Start\r\nSpacebar - Pause\r\nArrow keys - Move\r\nEsc - Quit\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(14, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Level";
            // 
            // levelLBL
            // 
            this.levelLBL.AutoSize = true;
            this.levelLBL.BackColor = System.Drawing.SystemColors.Control;
            this.levelLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.levelLBL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLBL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.levelLBL.Location = new System.Drawing.Point(79, 18);
            this.levelLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.levelLBL.Name = "levelLBL";
            this.levelLBL.Size = new System.Drawing.Size(17, 18);
            this.levelLBL.TabIndex = 26;
            this.levelLBL.Text = "0";
            // 
            // timerLBL
            // 
            this.timerLBL.AutoSize = true;
            this.timerLBL.BackColor = System.Drawing.SystemColors.Control;
            this.timerLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timerLBL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLBL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.timerLBL.Location = new System.Drawing.Point(79, 64);
            this.timerLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.timerLBL.Name = "timerLBL";
            this.timerLBL.Size = new System.Drawing.Size(17, 18);
            this.timerLBL.TabIndex = 20;
            this.timerLBL.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Score";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(14, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Timer";
            // 
            // scoreLBL
            // 
            this.scoreLBL.AutoSize = true;
            this.scoreLBL.BackColor = System.Drawing.SystemColors.Control;
            this.scoreLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scoreLBL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLBL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.scoreLBL.Location = new System.Drawing.Point(79, 41);
            this.scoreLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoreLBL.Name = "scoreLBL";
            this.scoreLBL.Size = new System.Drawing.Size(17, 18);
            this.scoreLBL.TabIndex = 24;
            this.scoreLBL.Text = "0";
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.Location = new System.Drawing.Point(523, 0);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(35, 13);
            this.lblDebug.TabIndex = 29;
            this.lblDebug.Text = "label4";
            // 
            // pauseLBL
            // 
            this.pauseLBL.AutoSize = true;
            this.pauseLBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pauseLBL.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseLBL.Location = new System.Drawing.Point(250, 95);
            this.pauseLBL.Name = "pauseLBL";
            this.pauseLBL.Size = new System.Drawing.Size(97, 28);
            this.pauseLBL.TabIndex = 0;
            this.pauseLBL.Text = "Paused";
            this.pauseLBL.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 263);
            this.Controls.Add(this.pauseLBL);
            this.Controls.Add(this.boardPanel);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Snake Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Panel boardPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timerLBL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label scoreLBL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label levelLBL;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem snakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label lblDebug;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pauseLBL;
    }
}

