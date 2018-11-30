namespace Assessment12
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultWLabel = new System.Windows.Forms.Label();
            this.resultColorLabel = new System.Windows.Forms.Label();
            this.resultVolLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.stuNameBox = new System.Windows.Forms.TextBox();
            this.exNumBox = new System.Windows.Forms.TextBox();
            this.expDescriptionBox = new System.Windows.Forms.TextBox();
            this.exResWeight = new System.Windows.Forms.TextBox();
            this.exVolume = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.expListBox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.exResColor = new System.Windows.Forms.TextBox();
            this.setButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Experiment Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Experiment Description:";
            // 
            // resultWLabel
            // 
            this.resultWLabel.AutoSize = true;
            this.resultWLabel.Enabled = false;
            this.resultWLabel.Location = new System.Drawing.Point(23, 129);
            this.resultWLabel.Name = "resultWLabel";
            this.resultWLabel.Size = new System.Drawing.Size(77, 13);
            this.resultWLabel.TabIndex = 3;
            this.resultWLabel.Text = "Result Weight:";
            // 
            // resultColorLabel
            // 
            this.resultColorLabel.AutoSize = true;
            this.resultColorLabel.Enabled = false;
            this.resultColorLabel.Location = new System.Drawing.Point(277, 128);
            this.resultColorLabel.Name = "resultColorLabel";
            this.resultColorLabel.Size = new System.Drawing.Size(67, 13);
            this.resultColorLabel.TabIndex = 4;
            this.resultColorLabel.Text = "Result Color:";
            // 
            // resultVolLabel
            // 
            this.resultVolLabel.AutoSize = true;
            this.resultVolLabel.Enabled = false;
            this.resultVolLabel.Location = new System.Drawing.Point(22, 168);
            this.resultVolLabel.Name = "resultVolLabel";
            this.resultVolLabel.Size = new System.Drawing.Size(78, 13);
            this.resultVolLabel.TabIndex = 5;
            this.resultVolLabel.Text = "Result Volume:";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(280, 462);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(145, 462);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // stuNameBox
            // 
            this.stuNameBox.Location = new System.Drawing.Point(108, 28);
            this.stuNameBox.Name = "stuNameBox";
            this.stuNameBox.Size = new System.Drawing.Size(121, 20);
            this.stuNameBox.TabIndex = 8;
            // 
            // exNumBox
            // 
            this.exNumBox.Location = new System.Drawing.Point(363, 28);
            this.exNumBox.Name = "exNumBox";
            this.exNumBox.Size = new System.Drawing.Size(121, 20);
            this.exNumBox.TabIndex = 9;
            // 
            // expDescriptionBox
            // 
            this.expDescriptionBox.Location = new System.Drawing.Point(24, 71);
            this.expDescriptionBox.MaxLength = 500;
            this.expDescriptionBox.Multiline = true;
            this.expDescriptionBox.Name = "expDescriptionBox";
            this.expDescriptionBox.Size = new System.Drawing.Size(460, 35);
            this.expDescriptionBox.TabIndex = 10;
            // 
            // exResWeight
            // 
            this.exResWeight.Enabled = false;
            this.exResWeight.Location = new System.Drawing.Point(108, 125);
            this.exResWeight.Name = "exResWeight";
            this.exResWeight.Size = new System.Drawing.Size(121, 20);
            this.exResWeight.TabIndex = 11;
            // 
            // exVolume
            // 
            this.exVolume.Enabled = false;
            this.exVolume.Location = new System.Drawing.Point(108, 165);
            this.exVolume.Name = "exVolume";
            this.exVolume.Size = new System.Drawing.Size(121, 20);
            this.exVolume.TabIndex = 12;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(411, 163);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // expListBox
            // 
            this.expListBox.FormattingEnabled = true;
            this.expListBox.Location = new System.Drawing.Point(24, 220);
            this.expListBox.Name = "expListBox";
            this.expListBox.Size = new System.Drawing.Size(391, 173);
            this.expListBox.TabIndex = 15;
           
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Experiments";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(249, 163);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 17;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // exResColor
            // 
            this.exResColor.Enabled = false;
            this.exResColor.Location = new System.Drawing.Point(363, 124);
            this.exResColor.Name = "exResColor";
            this.exResColor.Size = new System.Drawing.Size(121, 20);
            this.exResColor.TabIndex = 18;
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(330, 163);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 23);
            this.setButton.TabIndex = 19;
            this.setButton.Text = "Set";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 518);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.exResColor);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.expListBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.exVolume);
            this.Controls.Add(this.exResWeight);
            this.Controls.Add(this.expDescriptionBox);
            this.Controls.Add(this.exNumBox);
            this.Controls.Add(this.stuNameBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.resultVolLabel);
            this.Controls.Add(this.resultColorLabel);
            this.Controls.Add(this.resultWLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultWLabel;
        private System.Windows.Forms.Label resultColorLabel;
        private System.Windows.Forms.Label resultVolLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox stuNameBox;
        private System.Windows.Forms.TextBox exNumBox;
        private System.Windows.Forms.TextBox expDescriptionBox;
        private System.Windows.Forms.TextBox exResWeight;
        private System.Windows.Forms.TextBox exVolume;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ListBox expListBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox exResColor;
        private System.Windows.Forms.Button setButton;
    }
}

