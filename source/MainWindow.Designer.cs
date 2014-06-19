namespace AirSpeciesProperties
{
    partial class GasPropsMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GasPropsMainWindow));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.PressureLabel = new System.Windows.Forms.Label();
            this.TemperatureInput = new System.Windows.Forms.TextBox();
            this.PressureInput = new System.Windows.Forms.TextBox();
            this.TemperatureUnitLabel = new System.Windows.Forms.Label();
            this.PressureUnitLabel = new System.Windows.Forms.Label();
            this.SpeciesSelector = new System.Windows.Forms.ComboBox();
            this.SpeciesLabel = new System.Windows.Forms.Label();
            this.PropertiesOutputTextBox = new System.Windows.Forms.RichTextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ImageBox = new System.Windows.Forms.PictureBox();
            this.referencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainMenu.Size = new System.Drawing.Size(614, 24);
            this.MainMenu.TabIndex = 4;
            this.MainMenu.Text = "Main Menu";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem1.Image")));
            this.saveToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.saveToolStripMenuItem1.Text = "&Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.referencesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.DefaultExt = "txt";
            this.SaveFileDialog.Filter = "Text Files|*.txt|All files|*.*";
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Location = new System.Drawing.Point(13, 43);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(67, 13);
            this.TemperatureLabel.TabIndex = 1;
            this.TemperatureLabel.Text = "Temperature";
            // 
            // PressureLabel
            // 
            this.PressureLabel.AutoSize = true;
            this.PressureLabel.Location = new System.Drawing.Point(13, 74);
            this.PressureLabel.Name = "PressureLabel";
            this.PressureLabel.Size = new System.Drawing.Size(48, 13);
            this.PressureLabel.TabIndex = 2;
            this.PressureLabel.Text = "Pressure";
            // 
            // TemperatureInput
            // 
            this.TemperatureInput.Location = new System.Drawing.Point(86, 40);
            this.TemperatureInput.Name = "TemperatureInput";
            this.TemperatureInput.Size = new System.Drawing.Size(100, 20);
            this.TemperatureInput.TabIndex = 0;
            this.TemperatureInput.TextChanged += new System.EventHandler(this.TemperatureInput_TextChanged);
            this.TemperatureInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TemperatureInput_KeyDown);
            // 
            // PressureInput
            // 
            this.PressureInput.Location = new System.Drawing.Point(86, 71);
            this.PressureInput.Name = "PressureInput";
            this.PressureInput.Size = new System.Drawing.Size(100, 20);
            this.PressureInput.TabIndex = 1;
            this.PressureInput.TextChanged += new System.EventHandler(this.PressureInput_TextChanged);
            this.PressureInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PressureInput_KeyDown);
            // 
            // TemperatureUnitLabel
            // 
            this.TemperatureUnitLabel.AutoSize = true;
            this.TemperatureUnitLabel.Location = new System.Drawing.Point(192, 43);
            this.TemperatureUnitLabel.Name = "TemperatureUnitLabel";
            this.TemperatureUnitLabel.Size = new System.Drawing.Size(14, 13);
            this.TemperatureUnitLabel.TabIndex = 5;
            this.TemperatureUnitLabel.Text = "K";
            // 
            // PressureUnitLabel
            // 
            this.PressureUnitLabel.AutoSize = true;
            this.PressureUnitLabel.Location = new System.Drawing.Point(192, 70);
            this.PressureUnitLabel.Name = "PressureUnitLabel";
            this.PressureUnitLabel.Size = new System.Drawing.Size(29, 13);
            this.PressureUnitLabel.TabIndex = 6;
            this.PressureUnitLabel.Text = "MPa";
            // 
            // SpeciesSelector
            // 
            this.SpeciesSelector.FormattingEnabled = true;
            this.SpeciesSelector.Items.AddRange(new object[] {
            "Nitrogen, Diatomic (N2)",
            "Nitrogen, Monatomic (N)",
            "Nitrogen Ion, (N+)",
            "Oxygen, Diatomic (O2)",
            "Oxygen, Monatomic (O)",
            "Oxygen Ion (O+)",
            "Nitrogen Oxide (NO)",
            "Nitrogen Oxide Ion (NO+)",
            "Electron Gas (e-)"});
            this.SpeciesSelector.Location = new System.Drawing.Point(86, 102);
            this.SpeciesSelector.Name = "SpeciesSelector";
            this.SpeciesSelector.Size = new System.Drawing.Size(135, 21);
            this.SpeciesSelector.TabIndex = 2;
            this.SpeciesSelector.SelectedIndexChanged += new System.EventHandler(this.SpeciesSelector_SelectedIndexChanged);
            // 
            // SpeciesLabel
            // 
            this.SpeciesLabel.AutoSize = true;
            this.SpeciesLabel.Location = new System.Drawing.Point(13, 105);
            this.SpeciesLabel.Name = "SpeciesLabel";
            this.SpeciesLabel.Size = new System.Drawing.Size(45, 13);
            this.SpeciesLabel.TabIndex = 8;
            this.SpeciesLabel.Text = "Species";
            // 
            // PropertiesOutputTextBox
            // 
            this.PropertiesOutputTextBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropertiesOutputTextBox.Location = new System.Drawing.Point(239, 43);
            this.PropertiesOutputTextBox.MinimumSize = new System.Drawing.Size(363, 283);
            this.PropertiesOutputTextBox.Name = "PropertiesOutputTextBox";
            this.PropertiesOutputTextBox.ReadOnly = true;
            this.PropertiesOutputTextBox.Size = new System.Drawing.Size(363, 310);
            this.PropertiesOutputTextBox.TabIndex = 9;
            this.PropertiesOutputTextBox.Text = "";
            // 
            // OutputLabel
            // 
            this.OutputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(438, 24);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(164, 13);
            this.OutputLabel.TabIndex = 10;
            this.OutputLabel.Text = "Thermal and Transport Properties";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Enabled = false;
            this.CalculateButton.Location = new System.Drawing.Point(16, 138);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 3;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ImageBox
            // 
            this.ImageBox.Image = ((System.Drawing.Image)(resources.GetObject("ImageBox.Image")));
            this.ImageBox.Location = new System.Drawing.Point(16, 222);
            this.ImageBox.MinimumSize = new System.Drawing.Size(128, 128);
            this.ImageBox.Name = "ImageBox";
            this.ImageBox.Size = new System.Drawing.Size(128, 128);
            this.ImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageBox.TabIndex = 11;
            this.ImageBox.TabStop = false;
            this.ImageBox.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // referencesToolStripMenuItem
            // 
            this.referencesToolStripMenuItem.Name = "referencesToolStripMenuItem";
            this.referencesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.referencesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.referencesToolStripMenuItem.Text = "References";
            this.referencesToolStripMenuItem.Click += new System.EventHandler(this.referencesToolStripMenuItem_Click);
            // 
            // GasPropsMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 362);
            this.Controls.Add(this.ImageBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.PropertiesOutputTextBox);
            this.Controls.Add(this.SpeciesLabel);
            this.Controls.Add(this.SpeciesSelector);
            this.Controls.Add(this.PressureUnitLabel);
            this.Controls.Add(this.TemperatureUnitLabel);
            this.Controls.Add(this.PressureInput);
            this.Controls.Add(this.TemperatureInput);
            this.Controls.Add(this.PressureLabel);
            this.Controls.Add(this.TemperatureLabel);
            this.Controls.Add(this.MainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(630, 400);
            this.MinimumSize = new System.Drawing.Size(630, 400);
            this.Name = "GasPropsMainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Air Species Properties Calculator";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Label TemperatureLabel;
        private System.Windows.Forms.Label PressureLabel;
        private System.Windows.Forms.TextBox TemperatureInput;
        private System.Windows.Forms.TextBox PressureInput;
        private System.Windows.Forms.Label TemperatureUnitLabel;
        private System.Windows.Forms.Label PressureUnitLabel;
        private System.Windows.Forms.ComboBox SpeciesSelector;
        private System.Windows.Forms.Label SpeciesLabel;
        private System.Windows.Forms.RichTextBox PropertiesOutputTextBox;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.PictureBox ImageBox;
        private System.Windows.Forms.ToolStripMenuItem referencesToolStripMenuItem;
    }
}

