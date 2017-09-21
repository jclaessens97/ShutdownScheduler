namespace ShutdownScheduler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnShutdownOrCancel = new System.Windows.Forms.Button();
            this.numTime = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rblShutdownTypes = new ShutdownScheduler.custom.RadioButtonList();
            this.cbTimeType = new System.Windows.Forms.ComboBox();
            this.cbCustomMessagebox = new System.Windows.Forms.CheckBox();
            this.pbHelpIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTime)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelpIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShutdownOrCancel
            // 
            this.btnShutdownOrCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShutdownOrCancel.Location = new System.Drawing.Point(11, 138);
            this.btnShutdownOrCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnShutdownOrCancel.Name = "btnShutdownOrCancel";
            this.btnShutdownOrCancel.Size = new System.Drawing.Size(275, 28);
            this.btnShutdownOrCancel.TabIndex = 0;
            this.btnShutdownOrCancel.Text = "Schedule shutdown";
            this.btnShutdownOrCancel.UseVisualStyleBackColor = true;
            this.btnShutdownOrCancel.Click += new System.EventHandler(this.btnShutdownOrCancel_Click);
            // 
            // numTime
            // 
            this.numTime.Location = new System.Drawing.Point(7, 25);
            this.numTime.Margin = new System.Windows.Forms.Padding(2);
            this.numTime.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numTime.Name = "numTime";
            this.numTime.Size = new System.Drawing.Size(80, 20);
            this.numTime.TabIndex = 1;
            this.numTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTime.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rblShutdownTypes);
            this.groupBox1.Controls.Add(this.cbTimeType);
            this.groupBox1.Controls.Add(this.numTime);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(275, 104);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shutdown options";
            // 
            // rblShutdownTypes
            // 
            this.rblShutdownTypes.BackColor = System.Drawing.SystemColors.Control;
            this.rblShutdownTypes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rblShutdownTypes.FormattingEnabled = true;
            this.rblShutdownTypes.Location = new System.Drawing.Point(5, 50);
            this.rblShutdownTypes.Name = "rblShutdownTypes";
            this.rblShutdownTypes.Size = new System.Drawing.Size(149, 45);
            this.rblShutdownTypes.TabIndex = 9;
            // 
            // cbTimeType
            // 
            this.cbTimeType.FormattingEnabled = true;
            this.cbTimeType.Location = new System.Drawing.Point(91, 25);
            this.cbTimeType.Margin = new System.Windows.Forms.Padding(2);
            this.cbTimeType.Name = "cbTimeType";
            this.cbTimeType.Size = new System.Drawing.Size(92, 21);
            this.cbTimeType.TabIndex = 8;
            this.cbTimeType.SelectedIndexChanged += new System.EventHandler(this.cbTimeType_SelectedIndexChanged);
            // 
            // cbCustomMessagebox
            // 
            this.cbCustomMessagebox.AutoSize = true;
            this.cbCustomMessagebox.Location = new System.Drawing.Point(11, 118);
            this.cbCustomMessagebox.Margin = new System.Windows.Forms.Padding(2);
            this.cbCustomMessagebox.Name = "cbCustomMessagebox";
            this.cbCustomMessagebox.Size = new System.Drawing.Size(152, 17);
            this.cbCustomMessagebox.TabIndex = 6;
            this.cbCustomMessagebox.Text = "Show custom messagebox";
            this.cbCustomMessagebox.UseVisualStyleBackColor = true;
            this.cbCustomMessagebox.CheckedChanged += new System.EventHandler(this.cbCustomMessagebox_CheckedChanged);
            // 
            // pbHelpIcon
            // 
            this.pbHelpIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbHelpIcon.Image")));
            this.pbHelpIcon.Location = new System.Drawing.Point(161, 113);
            this.pbHelpIcon.Margin = new System.Windows.Forms.Padding(2);
            this.pbHelpIcon.Name = "pbHelpIcon";
            this.pbHelpIcon.Size = new System.Drawing.Size(14, 24);
            this.pbHelpIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHelpIcon.TabIndex = 7;
            this.pbHelpIcon.TabStop = false;
            this.pbHelpIcon.Click += new System.EventHandler(this.pbHelpIcon_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 173);
            this.Controls.Add(this.pbHelpIcon);
            this.Controls.Add(this.cbCustomMessagebox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnShutdownOrCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numTime)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHelpIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShutdownOrCancel;
        private System.Windows.Forms.NumericUpDown numTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbTimeType;
        private System.Windows.Forms.CheckBox cbCustomMessagebox;
        private System.Windows.Forms.PictureBox pbHelpIcon;
        private custom.RadioButtonList rblShutdownTypes;
    }
}

