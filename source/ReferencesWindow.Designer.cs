namespace AirSpeciesProperties
{
    partial class ReferencesWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReferencesWindow));
            this.ReferencesTextBox = new System.Windows.Forms.RichTextBox();
            this.ReferencesLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReferencesTextBox
            // 
            this.ReferencesTextBox.Location = new System.Drawing.Point(12, 25);
            this.ReferencesTextBox.Name = "ReferencesTextBox";
            this.ReferencesTextBox.ReadOnly = true;
            this.ReferencesTextBox.Size = new System.Drawing.Size(590, 229);
            this.ReferencesTextBox.TabIndex = 0;
            this.ReferencesTextBox.Text = resources.GetString("ReferencesTextBox.Text");
            // 
            // ReferencesLabel
            // 
            this.ReferencesLabel.AutoSize = true;
            this.ReferencesLabel.Location = new System.Drawing.Point(9, 9);
            this.ReferencesLabel.Name = "ReferencesLabel";
            this.ReferencesLabel.Size = new System.Drawing.Size(62, 13);
            this.ReferencesLabel.TabIndex = 1;
            this.ReferencesLabel.Text = "References";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(527, 260);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ReferencesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 295);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ReferencesLabel);
            this.Controls.Add(this.ReferencesTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(630, 333);
            this.Name = "ReferencesWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ReferencesWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ReferencesTextBox;
        private System.Windows.Forms.Label ReferencesLabel;
        private System.Windows.Forms.Button CloseButton;
    }
}