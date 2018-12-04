namespace Assessment12
{
    partial class Review
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
            this.ReviewVolLabel = new System.Windows.Forms.Label();
            this.reviewColorLabel = new System.Windows.Forms.Label();
            this.reviewWLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.stuNameLabel = new System.Windows.Forms.Label();
            this.exNumLabel = new System.Windows.Forms.Label();
            this.exDescLabel = new System.Windows.Forms.Label();
            this.rWeightLabel = new System.Windows.Forms.Label();
            this.rColorLabel = new System.Windows.Forms.Label();
            this.rVolumeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReviewVolLabel
            // 
            this.ReviewVolLabel.AutoSize = true;
            this.ReviewVolLabel.Location = new System.Drawing.Point(43, 177);
            this.ReviewVolLabel.Name = "ReviewVolLabel";
            this.ReviewVolLabel.Size = new System.Drawing.Size(78, 13);
            this.ReviewVolLabel.TabIndex = 25;
            this.ReviewVolLabel.Text = "Result Volume:";
            // 
            // reviewColorLabel
            // 
            this.reviewColorLabel.AutoSize = true;
            this.reviewColorLabel.Location = new System.Drawing.Point(54, 142);
            this.reviewColorLabel.Name = "reviewColorLabel";
            this.reviewColorLabel.Size = new System.Drawing.Size(67, 13);
            this.reviewColorLabel.TabIndex = 24;
            this.reviewColorLabel.Text = "Result Color:";
            // 
            // reviewWLabel
            // 
            this.reviewWLabel.AutoSize = true;
            this.reviewWLabel.Location = new System.Drawing.Point(44, 107);
            this.reviewWLabel.Name = "reviewWLabel";
            this.reviewWLabel.Size = new System.Drawing.Size(77, 13);
            this.reviewWLabel.TabIndex = 23;
            this.reviewWLabel.Text = "Result Weight:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Experiment Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Experiment Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Student Name:";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(138, 347);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 26;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // stuNameLabel
            // 
            this.stuNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stuNameLabel.Location = new System.Drawing.Point(127, 32);
            this.stuNameLabel.Name = "stuNameLabel";
            this.stuNameLabel.Size = new System.Drawing.Size(100, 23);
            this.stuNameLabel.TabIndex = 27;
            // 
            // exNumLabel
            // 
            this.exNumLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exNumLabel.Location = new System.Drawing.Point(127, 67);
            this.exNumLabel.Name = "exNumLabel";
            this.exNumLabel.Size = new System.Drawing.Size(100, 23);
            this.exNumLabel.TabIndex = 28;
            // 
            // exDescLabel
            // 
            this.exDescLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exDescLabel.Location = new System.Drawing.Point(57, 223);
            this.exDescLabel.Name = "exDescLabel";
            this.exDescLabel.Size = new System.Drawing.Size(336, 116);
            this.exDescLabel.TabIndex = 29;
            // 
            // rWeightLabel
            // 
            this.rWeightLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rWeightLabel.Location = new System.Drawing.Point(127, 107);
            this.rWeightLabel.Name = "rWeightLabel";
            this.rWeightLabel.Size = new System.Drawing.Size(100, 23);
            this.rWeightLabel.TabIndex = 30;
            // 
            // rColorLabel
            // 
            this.rColorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rColorLabel.Location = new System.Drawing.Point(127, 142);
            this.rColorLabel.Name = "rColorLabel";
            this.rColorLabel.Size = new System.Drawing.Size(100, 23);
            this.rColorLabel.TabIndex = 31;
            // 
            // rVolumeLabel
            // 
            this.rVolumeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rVolumeLabel.Location = new System.Drawing.Point(127, 177);
            this.rVolumeLabel.Name = "rVolumeLabel";
            this.rVolumeLabel.Size = new System.Drawing.Size(100, 23);
            this.rVolumeLabel.TabIndex = 32;
            // 
            // Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 382);
            this.Controls.Add(this.rVolumeLabel);
            this.Controls.Add(this.rColorLabel);
            this.Controls.Add(this.rWeightLabel);
            this.Controls.Add(this.exDescLabel);
            this.Controls.Add(this.exNumLabel);
            this.Controls.Add(this.stuNameLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.ReviewVolLabel);
            this.Controls.Add(this.reviewColorLabel);
            this.Controls.Add(this.reviewWLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Review";
            this.Text = "Review";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ReviewVolLabel;
        private System.Windows.Forms.Label reviewColorLabel;
        private System.Windows.Forms.Label reviewWLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeButton;
        public System.Windows.Forms.Label stuNameLabel;
        public System.Windows.Forms.Label exNumLabel;
        public System.Windows.Forms.Label exDescLabel;
        public System.Windows.Forms.Label rWeightLabel;
        public System.Windows.Forms.Label rColorLabel;
        public System.Windows.Forms.Label rVolumeLabel;
    }
}