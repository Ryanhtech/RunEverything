
namespace RunEverything
{
    partial class DumpForm
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
            this.Title = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SaveLocation = new System.Windows.Forms.TextBox();
            this.Browse = new System.Windows.Forms.Button();
            this.OpenFileLabel = new System.Windows.Forms.Label();
            this.AdditionalSettings = new System.Windows.Forms.Label();
            this.OpenDumpCheckBox = new System.Windows.Forms.CheckBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SaveDumpDialog = new System.Windows.Forms.SaveFileDialog();
            this.FileSaveInfo = new System.Windows.Forms.Label();
            this.Enable = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(142, 30);
            this.Title.TabIndex = 16;
            this.Title.Text = "Dump Output";
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TitleLabel.Location = new System.Drawing.Point(15, 43);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(504, 38);
            this.TitleLabel.TabIndex = 17;
            this.TitleLabel.Text = "Dumps the output of your command to a text file. You can\'t view the output in the" +
    " console window, and you cannot input to it.";
            // 
            // SaveLocation
            // 
            this.SaveLocation.Enabled = false;
            this.SaveLocation.Location = new System.Drawing.Point(19, 106);
            this.SaveLocation.Name = "SaveLocation";
            this.SaveLocation.PlaceholderText = "Save Location";
            this.SaveLocation.Size = new System.Drawing.Size(459, 23);
            this.SaveLocation.TabIndex = 18;
            // 
            // Browse
            // 
            this.Browse.Enabled = false;
            this.Browse.Location = new System.Drawing.Point(484, 106);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(24, 24);
            this.Browse.TabIndex = 19;
            this.Browse.Text = "...";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // OpenFileLabel
            // 
            this.OpenFileLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OpenFileLabel.Location = new System.Drawing.Point(19, 166);
            this.OpenFileLabel.Name = "OpenFileLabel";
            this.OpenFileLabel.Size = new System.Drawing.Size(489, 16);
            this.OpenFileLabel.TabIndex = 20;
            this.OpenFileLabel.Text = "Do you want to open the saved file after the operation?";
            // 
            // AdditionalSettings
            // 
            this.AdditionalSettings.AutoSize = true;
            this.AdditionalSettings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdditionalSettings.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.AdditionalSettings.Location = new System.Drawing.Point(18, 137);
            this.AdditionalSettings.Name = "AdditionalSettings";
            this.AdditionalSettings.Size = new System.Drawing.Size(136, 20);
            this.AdditionalSettings.TabIndex = 21;
            this.AdditionalSettings.Text = "Additional Settings";
            // 
            // OpenDumpCheckBox
            // 
            this.OpenDumpCheckBox.AutoSize = true;
            this.OpenDumpCheckBox.Location = new System.Drawing.Point(19, 185);
            this.OpenDumpCheckBox.Name = "OpenDumpCheckBox";
            this.OpenDumpCheckBox.Size = new System.Drawing.Size(316, 19);
            this.OpenDumpCheckBox.TabIndex = 22;
            this.OpenDumpCheckBox.Text = "Open dump result after the execution of the command";
            this.OpenDumpCheckBox.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(408, 227);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(100, 23);
            this.SaveButton.TabIndex = 23;
            this.SaveButton.Text = "Save and close";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(327, 227);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 24;
            this.CloseButton.Text = "Cancel";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SaveDumpDialog
            // 
            this.SaveDumpDialog.DefaultExt = "txt";
            this.SaveDumpDialog.Filter = "Text Files|*.txt|All files|*.*";
            this.SaveDumpDialog.Title = "Select dump location";
            // 
            // FileSaveInfo
            // 
            this.FileSaveInfo.AutoSize = true;
            this.FileSaveInfo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FileSaveInfo.Location = new System.Drawing.Point(19, 231);
            this.FileSaveInfo.Name = "FileSaveInfo";
            this.FileSaveInfo.Size = new System.Drawing.Size(291, 15);
            this.FileSaveInfo.TabIndex = 25;
            this.FileSaveInfo.Text = "The file will be saved once the command has finished.";
            // 
            // Enable
            // 
            this.Enable.AutoSize = true;
            this.Enable.Location = new System.Drawing.Point(19, 81);
            this.Enable.Name = "Enable";
            this.Enable.Size = new System.Drawing.Size(97, 19);
            this.Enable.TabIndex = 26;
            this.Enable.Text = "Enable Dump";
            this.Enable.UseVisualStyleBackColor = true;
            this.Enable.CheckedChanged += new System.EventHandler(this.Enable_CheckedChanged);
            // 
            // DumpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(520, 259);
            this.Controls.Add(this.Enable);
            this.Controls.Add(this.FileSaveInfo);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OpenDumpCheckBox);
            this.Controls.Add(this.AdditionalSettings);
            this.Controls.Add(this.OpenFileLabel);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.SaveLocation);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.Title);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DumpForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Run and Dump Output - RunEverything";
            this.Load += new System.EventHandler(this.DumpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Label OpenFileLabel;
        private System.Windows.Forms.Label AdditionalSettings;
        private System.Windows.Forms.CheckBox OpenDumpCheckBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.SaveFileDialog SaveDumpDialog;
        private System.Windows.Forms.Label FileSaveInfo;
        private System.Windows.Forms.CheckBox Enable;
        public System.Windows.Forms.TextBox SaveLocation;
    }
}