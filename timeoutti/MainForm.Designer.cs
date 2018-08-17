namespace Timeoutti
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timeLabel = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIconContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.update = new System.Windows.Forms.Timer(this.components);
            this.progressBarValueChanger = new System.Windows.Forms.Timer(this.components);
            this.breakPanel = new System.Windows.Forms.Panel();
            this.breakTimeLbl = new System.Windows.Forms.Label();
            this.currentTimeLbl = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.finishBreakBtn = new System.Windows.Forms.Button();
            this.aFKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startBreakBtn = new System.Windows.Forms.Button();
            this.notifyIconContextMenuStrip.SuspendLayout();
            this.breakPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.timeLabel.Location = new System.Drawing.Point(706, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(284, 108);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "00:00";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.notifyIconContextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Timeoutti";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseDoubleClick);
            // 
            // notifyIconContextMenuStrip
            // 
            this.notifyIconContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aFKToolStripMenuItem,
            this.testToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.notifyIconContextMenuStrip.Name = "notifyIconContextMenuStrip";
            this.notifyIconContextMenuStrip.Size = new System.Drawing.Size(117, 70);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.testToolStripMenuItem.Text = "Settings";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // update
            // 
            this.update.Interval = 60000;
            this.update.Tick += new System.EventHandler(this.update_Tick);
            // 
            // progressBarValueChanger
            // 
            this.progressBarValueChanger.Interval = 1000;
            this.progressBarValueChanger.Tick += new System.EventHandler(this.progressBarValueChanger_Tick);
            // 
            // breakPanel
            // 
            this.breakPanel.Controls.Add(this.breakTimeLbl);
            this.breakPanel.Controls.Add(this.currentTimeLbl);
            this.breakPanel.Controls.Add(this.finishBreakBtn);
            this.breakPanel.Controls.Add(this.startBreakBtn);
            this.breakPanel.Controls.Add(this.progressBar);
            this.breakPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.breakPanel.Location = new System.Drawing.Point(0, 0);
            this.breakPanel.Name = "breakPanel";
            this.breakPanel.Size = new System.Drawing.Size(706, 373);
            this.breakPanel.TabIndex = 1;
            this.breakPanel.Visible = false;
            // 
            // breakTimeLbl
            // 
            this.breakTimeLbl.AutoSize = true;
            this.breakTimeLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.breakTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.breakTimeLbl.Location = new System.Drawing.Point(0, 0);
            this.breakTimeLbl.Name = "breakTimeLbl";
            this.breakTimeLbl.Size = new System.Drawing.Size(106, 24);
            this.breakTimeLbl.TabIndex = 11;
            this.breakTimeLbl.Text = "Break Time";
            // 
            // currentTimeLbl
            // 
            this.currentTimeLbl.AutoSize = true;
            this.currentTimeLbl.Dock = System.Windows.Forms.DockStyle.Right;
            this.currentTimeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.currentTimeLbl.Location = new System.Drawing.Point(653, 0);
            this.currentTimeLbl.Name = "currentTimeLbl";
            this.currentTimeLbl.Size = new System.Drawing.Size(53, 24);
            this.currentTimeLbl.TabIndex = 10;
            this.currentTimeLbl.Text = "Time";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(706, 373);
            this.progressBar.TabIndex = 9;
            // 
            // finishBreakBtn
            // 
            this.finishBreakBtn.BackColor = System.Drawing.Color.Gray;
            this.finishBreakBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.finishBreakBtn.Location = new System.Drawing.Point(0, 302);
            this.finishBreakBtn.Name = "finishBreakBtn";
            this.finishBreakBtn.Size = new System.Drawing.Size(706, 71);
            this.finishBreakBtn.TabIndex = 12;
            this.finishBreakBtn.Text = "Skip Break";
            this.finishBreakBtn.UseVisualStyleBackColor = false;
            this.finishBreakBtn.Click += new System.EventHandler(this.finishBreakBtn_Click);
            // 
            // aFKToolStripMenuItem
            // 
            this.aFKToolStripMenuItem.CheckOnClick = true;
            this.aFKToolStripMenuItem.Name = "aFKToolStripMenuItem";
            this.aFKToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aFKToolStripMenuItem.Text = "AFK";
            this.aFKToolStripMenuItem.Click += new System.EventHandler(this.aFKToolStripMenuItem_Click);
            // 
            // startBreakBtn
            // 
            this.startBreakBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startBreakBtn.Location = new System.Drawing.Point(0, 0);
            this.startBreakBtn.Name = "startBreakBtn";
            this.startBreakBtn.Size = new System.Drawing.Size(706, 373);
            this.startBreakBtn.TabIndex = 13;
            this.startBreakBtn.Text = "Start Break";
            this.startBreakBtn.UseVisualStyleBackColor = true;
            this.startBreakBtn.Click += new System.EventHandler(this.startBreakBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 373);
            this.Controls.Add(this.breakPanel);
            this.Controls.Add(this.timeLabel);
            this.Name = "MainForm";
            this.Text = "Timeoutti";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.notifyIconContextMenuStrip.ResumeLayout(false);
            this.breakPanel.ResumeLayout(false);
            this.breakPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyIconContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.Timer update;
        private System.Windows.Forms.Timer progressBarValueChanger;
        private System.Windows.Forms.Panel breakPanel;
        private System.Windows.Forms.Label breakTimeLbl;
        private System.Windows.Forms.Label currentTimeLbl;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button finishBreakBtn;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aFKToolStripMenuItem;
        private System.Windows.Forms.Button startBreakBtn;
    }
}