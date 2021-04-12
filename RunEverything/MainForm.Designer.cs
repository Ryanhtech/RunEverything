
namespace RunEverything
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ProgramName = new System.Windows.Forms.TextBox();
            this.Args = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.BrowseDialog = new System.Windows.Forms.OpenFileDialog();
            this.Elevate = new System.Windows.Forms.CheckBox();
            this.HideConsole = new System.Windows.Forms.CheckBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.Label();
            this.WorkingDir = new System.Windows.Forms.TextBox();
            this.BrowseDir = new System.Windows.Forms.Button();
            this.FolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.DirectoryDoesntExist = new System.Windows.Forms.Label();
            this.AboutButton = new System.Windows.Forms.Button();
            this.AppName = new System.Windows.Forms.Label();
            this.RunDumpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TitleLabel.Location = new System.Drawing.Point(16, 40);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(579, 15);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Type the name of a program, a resource, a folder, a file, or a batch file and Run" +
    "Everything will open it for you.";
            // 
            // ProgramName
            // 
            this.ProgramName.AcceptsReturn = true;
            this.ProgramName.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProgramName.Location = new System.Drawing.Point(17, 65);
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.PlaceholderText = "Program name/location";
            this.ProgramName.Size = new System.Drawing.Size(706, 23);
            this.ProgramName.TabIndex = 1;
            this.ProgramName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ProgramName_KeyPress);
            this.ProgramName.Validating += new System.ComponentModel.CancelEventHandler(this.ProgramName_Validating);
            // 
            // Args
            // 
            this.Args.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Args.Location = new System.Drawing.Point(17, 124);
            this.Args.Name = "Args";
            this.Args.PlaceholderText = "Arguments";
            this.Args.Size = new System.Drawing.Size(706, 23);
            this.Args.TabIndex = 2;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(16, 94);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 6;
            this.BrowseButton.Text = "Browse...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // BrowseDialog
            // 
            this.BrowseDialog.DefaultExt = "Executable files (*.exe)|*.exe";
            this.BrowseDialog.InitialDirectory = "C:\\Windows\\System32";
            this.BrowseDialog.Title = "Choose a file to run";
            // 
            // Elevate
            // 
            this.Elevate.AutoSize = true;
            this.Elevate.Location = new System.Drawing.Point(17, 211);
            this.Elevate.Name = "Elevate";
            this.Elevate.Size = new System.Drawing.Size(204, 19);
            this.Elevate.TabIndex = 4;
            this.Elevate.Text = "Run the program as administrator";
            this.Elevate.UseVisualStyleBackColor = true;
            // 
            // HideConsole
            // 
            this.HideConsole.AutoSize = true;
            this.HideConsole.Location = new System.Drawing.Point(17, 236);
            this.HideConsole.Name = "HideConsole";
            this.HideConsole.Size = new System.Drawing.Size(360, 19);
            this.HideConsole.TabIndex = 5;
            this.HideConsole.Text = "Hide the console window (not recommended for console apps)";
            this.HideConsole.UseVisualStyleBackColor = true;
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(645, 277);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 4;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(564, 277);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Cancel";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.ForeColor = System.Drawing.Color.OrangeRed;
            this.Error.Location = new System.Drawing.Point(206, 98);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(378, 15);
            this.Error.TabIndex = 9;
            this.Error.Text = "The command wasn\'t found. Please check your spelling, and try again.";
            // 
            // WorkingDir
            // 
            this.WorkingDir.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WorkingDir.Location = new System.Drawing.Point(17, 153);
            this.WorkingDir.Name = "WorkingDir";
            this.WorkingDir.Size = new System.Drawing.Size(706, 23);
            this.WorkingDir.TabIndex = 3;
            // 
            // BrowseDir
            // 
            this.BrowseDir.Location = new System.Drawing.Point(16, 182);
            this.BrowseDir.Name = "BrowseDir";
            this.BrowseDir.Size = new System.Drawing.Size(75, 23);
            this.BrowseDir.TabIndex = 8;
            this.BrowseDir.Text = "Browse...";
            this.BrowseDir.UseVisualStyleBackColor = true;
            this.BrowseDir.Click += new System.EventHandler(this.BrowseDir_Click);
            // 
            // FolderBrowser
            // 
            this.FolderBrowser.Description = "Select working directory";
            this.FolderBrowser.SelectedPath = "C:\\";
            this.FolderBrowser.UseDescriptionForTitle = true;
            // 
            // DirectoryDoesntExist
            // 
            this.DirectoryDoesntExist.AutoSize = true;
            this.DirectoryDoesntExist.ForeColor = System.Drawing.Color.OrangeRed;
            this.DirectoryDoesntExist.Location = new System.Drawing.Point(97, 186);
            this.DirectoryDoesntExist.Name = "DirectoryDoesntExist";
            this.DirectoryDoesntExist.Size = new System.Drawing.Size(294, 15);
            this.DirectoryDoesntExist.TabIndex = 13;
            this.DirectoryDoesntExist.Text = "This directory doesn\'t exist. Please check your spelling.";
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(17, 277);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(139, 23);
            this.AboutButton.TabIndex = 14;
            this.AboutButton.Text = "About RunEverything...";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AppName.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.AppName.Location = new System.Drawing.Point(13, 7);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(147, 30);
            this.AppName.TabIndex = 15;
            this.AppName.Text = "RunEverything";
            // 
            // RunDumpButton
            // 
            this.RunDumpButton.Location = new System.Drawing.Point(97, 94);
            this.RunDumpButton.Name = "RunDumpButton";
            this.RunDumpButton.Size = new System.Drawing.Size(103, 23);
            this.RunDumpButton.TabIndex = 16;
            this.RunDumpButton.Text = "Dump Settings...";
            this.RunDumpButton.UseVisualStyleBackColor = true;
            this.RunDumpButton.Click += new System.EventHandler(this.RunDumpButton_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.RunButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(735, 308);
            this.Controls.Add(this.RunDumpButton);
            this.Controls.Add(this.AppName);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.DirectoryDoesntExist);
            this.Controls.Add(this.BrowseDir);
            this.Controls.Add(this.WorkingDir);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.HideConsole);
            this.Controls.Add(this.Elevate);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.Args);
            this.Controls.Add(this.ProgramName);
            this.Controls.Add(this.TitleLabel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(751, 347);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(751, 347);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RunEverything";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.OpenFileDialog BrowseDialog;
        public System.Windows.Forms.Label Error;
        public System.Windows.Forms.TextBox ProgramName;
        public System.Windows.Forms.TextBox Args;
        public System.Windows.Forms.CheckBox Elevate;
        public System.Windows.Forms.CheckBox HideConsole;
        public System.Windows.Forms.Button RunButton;
        public System.Windows.Forms.Button CloseButton;
        public System.Windows.Forms.TextBox WorkingDir;
        private System.Windows.Forms.Button BrowseDir;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowser;
        public System.Windows.Forms.Label DirectoryDoesntExist;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button RunDumpButton;
    }
}

