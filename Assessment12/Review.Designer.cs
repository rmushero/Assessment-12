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
            this.resultVolLabel = new System.Windows.Forms.Label();
            this.resultColorLabel = new System.Windows.Forms.Label();
            this.resultWLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultVolLabel
            // 
            this.resultVolLabel.AutoSize = true;
            this.resultVolLabel.Enabled = false;
            this.resultVolLabel.Location = new System.Drawing.Point(43, 207);
            this.resultVolLabel.Name = "resultVolLabel";
            this.resultVolLabel.Size = new System.Drawing.Size(78, 13);
            this.resultVolLabel.TabIndex = 25;
            this.resultVolLabel.Text = "Result Volume:";
            // 
            // resultColorLabel
            // 
            this.resultColorLabel.AutoSize = true;
            this.resultColorLabel.Enabled = false;
            this.resultColorLabel.Location = new System.Drawing.Point(54, 172);
            this.resultColorLabel.Name = "resultColorLabel";
            this.resultColorLabel.Size = new System.Drawing.Size(67, 13);
            this.resultColorLabel.TabIndex = 24;
            this.resultColorLabel.Text = "Result Color:";
            // 
            // resultWLabel
            // 
            this.resultWLabel.AutoSize = true;
            this.resultWLabel.Enabled = false;
            this.resultWLabel.Location = new System.Drawing.Point(44, 137);
            this.resultWLabel.Name = "resultWLabel";
            this.resultWLabel.Size = new System.Drawing.Size(77, 13);
            this.resultWLabel.TabIndex = 23;
            this.resultWLabel.Text = "Result Weight:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 102);
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
            this.closeButton.Location = new System.Drawing.Point(137, 250);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 26;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 285);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.resultVolLabel);
            this.Controls.Add(this.resultColorLabel);
            this.Controls.Add(this.resultWLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Review";
            this.Text = "Review";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label resultVolLabel;
        private System.Windows.Forms.Label resultColorLabel;
        private System.Windows.Forms.Label resultWLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeButton;
    }
}