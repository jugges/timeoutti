namespace Timeoutti
{
    partial class RowContent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.breakTimeMinutes = new System.Windows.Forms.NumericUpDown();
            this.breakTimeLabel = new System.Windows.Forms.Label();
            this.breakGapLabel = new System.Windows.Forms.Label();
            this.breakGapHours = new System.Windows.Forms.NumericUpDown();
            this.breakGapMinutes = new System.Windows.Forms.NumericUpDown();
            this.enableCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.breakTimeMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakGapHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakGapMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // breakTimeMinutes
            // 
            this.breakTimeMinutes.Location = new System.Drawing.Point(426, 3);
            this.breakTimeMinutes.Name = "breakTimeMinutes";
            this.breakTimeMinutes.Size = new System.Drawing.Size(148, 20);
            this.breakTimeMinutes.TabIndex = 0;
            // 
            // breakTimeLabel
            // 
            this.breakTimeLabel.AutoSize = true;
            this.breakTimeLabel.Location = new System.Drawing.Point(304, 5);
            this.breakTimeLabel.Name = "breakTimeLabel";
            this.breakTimeLabel.Size = new System.Drawing.Size(116, 13);
            this.breakTimeLabel.TabIndex = 1;
            this.breakTimeLabel.Text = "Break time (in minutes):";
            // 
            // breakGapLabel
            // 
            this.breakGapLabel.AutoSize = true;
            this.breakGapLabel.Location = new System.Drawing.Point(68, 5);
            this.breakGapLabel.Name = "breakGapLabel";
            this.breakGapLabel.Size = new System.Drawing.Size(114, 13);
            this.breakGapLabel.TabIndex = 2;
            this.breakGapLabel.Text = "Break gap (every h:m):";
            // 
            // breakGapHours
            // 
            this.breakGapHours.Location = new System.Drawing.Point(188, 3);
            this.breakGapHours.Name = "breakGapHours";
            this.breakGapHours.Size = new System.Drawing.Size(50, 20);
            this.breakGapHours.TabIndex = 3;
            // 
            // breakGapMinutes
            // 
            this.breakGapMinutes.Location = new System.Drawing.Point(244, 3);
            this.breakGapMinutes.Name = "breakGapMinutes";
            this.breakGapMinutes.Size = new System.Drawing.Size(50, 20);
            this.breakGapMinutes.TabIndex = 4;
            // 
            // enableCheck
            // 
            this.enableCheck.AutoSize = true;
            this.enableCheck.Location = new System.Drawing.Point(3, 4);
            this.enableCheck.Name = "enableCheck";
            this.enableCheck.Size = new System.Drawing.Size(59, 17);
            this.enableCheck.TabIndex = 5;
            this.enableCheck.Text = "Enable";
            this.enableCheck.UseVisualStyleBackColor = true;
            // 
            // RowContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.enableCheck);
            this.Controls.Add(this.breakGapMinutes);
            this.Controls.Add(this.breakGapHours);
            this.Controls.Add(this.breakGapLabel);
            this.Controls.Add(this.breakTimeLabel);
            this.Controls.Add(this.breakTimeMinutes);
            this.Name = "RowContent";
            this.Size = new System.Drawing.Size(577, 26);
            ((System.ComponentModel.ISupportInitialize)(this.breakTimeMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakGapHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakGapMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown breakTimeMinutes;
        private System.Windows.Forms.Label breakTimeLabel;
        private System.Windows.Forms.Label breakGapLabel;
        private System.Windows.Forms.NumericUpDown breakGapHours;
        private System.Windows.Forms.NumericUpDown breakGapMinutes;
        private System.Windows.Forms.CheckBox enableCheck;
    }
}
