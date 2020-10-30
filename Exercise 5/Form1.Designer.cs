namespace Exercise_5
{
    partial class approximatePiForm
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfTermsTextbox = new System.Windows.Forms.TextBox();
            this.numberOfTermsApproxLabel = new System.Windows.Forms.Label();
            this.approxValueOfPi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(169, 355);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(110, 53);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(458, 355);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(110, 53);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(166, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the number of terms to approximate:";
            // 
            // numberOfTermsTextbox
            // 
            this.numberOfTermsTextbox.Location = new System.Drawing.Point(458, 73);
            this.numberOfTermsTextbox.Name = "numberOfTermsTextbox";
            this.numberOfTermsTextbox.Size = new System.Drawing.Size(100, 20);
            this.numberOfTermsTextbox.TabIndex = 3;
            // 
            // numberOfTermsApproxLabel
            // 
            this.numberOfTermsApproxLabel.AutoSize = true;
            this.numberOfTermsApproxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numberOfTermsApproxLabel.Location = new System.Drawing.Point(166, 173);
            this.numberOfTermsApproxLabel.Name = "numberOfTermsApproxLabel";
            this.numberOfTermsApproxLabel.Size = new System.Drawing.Size(0, 17);
            this.numberOfTermsApproxLabel.TabIndex = 4;
            // 
            // approxValueOfPi
            // 
            this.approxValueOfPi.AutoSize = true;
            this.approxValueOfPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.approxValueOfPi.Location = new System.Drawing.Point(166, 249);
            this.approxValueOfPi.Name = "approxValueOfPi";
            this.approxValueOfPi.Size = new System.Drawing.Size(0, 17);
            this.approxValueOfPi.TabIndex = 5;
            // 
            // approximatePiForm
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.approxValueOfPi);
            this.Controls.Add(this.numberOfTermsApproxLabel);
            this.Controls.Add(this.numberOfTermsTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Name = "approximatePiForm";
            this.Text = "Approximate Pi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberOfTermsTextbox;
        private System.Windows.Forms.Label numberOfTermsApproxLabel;
        private System.Windows.Forms.Label approxValueOfPi;
    }
}

