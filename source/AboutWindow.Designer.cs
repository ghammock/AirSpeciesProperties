namespace AirSpeciesProperties
{
    partial class AboutWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutWindow));
            this.CopyRightLicenseLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.AboutWindowImageBox = new System.Windows.Forms.PictureBox();
            this.ReferencesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AboutWindowImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CopyRightLicenseLabel
            // 
            this.CopyRightLicenseLabel.AutoSize = true;
            this.CopyRightLicenseLabel.Location = new System.Drawing.Point(139, 13);
            this.CopyRightLicenseLabel.Name = "CopyRightLicenseLabel";
            this.CopyRightLicenseLabel.Size = new System.Drawing.Size(458, 247);
            this.CopyRightLicenseLabel.TabIndex = 0;
            this.CopyRightLicenseLabel.Text = resources.GetString("CopyRightLicenseLabel.Text");
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(527, 263);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // AboutWindowImageBox
            // 
            this.AboutWindowImageBox.Image = ((System.Drawing.Image)(resources.GetObject("AboutWindowImageBox.Image")));
            this.AboutWindowImageBox.Location = new System.Drawing.Point(5, 12);
            this.AboutWindowImageBox.MinimumSize = new System.Drawing.Size(128, 128);
            this.AboutWindowImageBox.Name = "AboutWindowImageBox";
            this.AboutWindowImageBox.Size = new System.Drawing.Size(128, 128);
            this.AboutWindowImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AboutWindowImageBox.TabIndex = 2;
            this.AboutWindowImageBox.TabStop = false;
            // 
            // ReferencesButton
            // 
            this.ReferencesButton.Location = new System.Drawing.Point(142, 263);
            this.ReferencesButton.Name = "ReferencesButton";
            this.ReferencesButton.Size = new System.Drawing.Size(75, 23);
            this.ReferencesButton.TabIndex = 3;
            this.ReferencesButton.Text = "References";
            this.ReferencesButton.UseVisualStyleBackColor = true;
            this.ReferencesButton.Click += new System.EventHandler(this.ReferencesButton_Click);
            // 
            // AboutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 295);
            this.Controls.Add(this.ReferencesButton);
            this.Controls.Add(this.AboutWindowImageBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.CopyRightLicenseLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(630, 400);
            this.Name = "AboutWindow";
            this.Text = "Air Species Properties Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.AboutWindowImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CopyRightLicenseLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.PictureBox AboutWindowImageBox;
        private System.Windows.Forms.Button ReferencesButton;
    }
}