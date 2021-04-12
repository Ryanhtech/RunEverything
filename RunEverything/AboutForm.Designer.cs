
namespace RunEverything
{
    partial class AboutForm
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
            this.AppName = new System.Windows.Forms.Label();
            this.Copyright = new System.Windows.Forms.Label();
            this.Slogan = new System.Windows.Forms.Label();
            this.VersionText = new System.Windows.Forms.Label();
            this.VersionName = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AppName.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.AppName.Location = new System.Drawing.Point(12, 9);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(147, 30);
            this.AppName.TabIndex = 0;
            this.AppName.Text = "RunEverything";
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.Location = new System.Drawing.Point(437, 9);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(173, 15);
            this.Copyright.TabIndex = 1;
            this.Copyright.Text = "Copyright 2021 Ryanhtech Labs";
            this.Copyright.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Slogan
            // 
            this.Slogan.AutoSize = true;
            this.Slogan.Location = new System.Drawing.Point(15, 39);
            this.Slogan.Name = "Slogan";
            this.Slogan.Size = new System.Drawing.Size(193, 15);
            this.Slogan.TabIndex = 3;
            this.Slogan.Text = "Run everything, anytime, anywhere";
            // 
            // VersionText
            // 
            this.VersionText.AutoSize = true;
            this.VersionText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VersionText.Location = new System.Drawing.Point(88, 120);
            this.VersionText.Name = "VersionText";
            this.VersionText.Size = new System.Drawing.Size(62, 19);
            this.VersionText.TabIndex = 4;
            this.VersionText.Text = "Version";
            // 
            // VersionName
            // 
            this.VersionName.AutoSize = true;
            this.VersionName.Font = new System.Drawing.Font("Candara", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VersionName.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.VersionName.Location = new System.Drawing.Point(77, 120);
            this.VersionName.Name = "VersionName";
            this.VersionName.Size = new System.Drawing.Size(466, 78);
            this.VersionName.TabIndex = 5;
            this.VersionName.Text = "1.2 Final Release";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(534, 317);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "This software is licensed under the Apache License.";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(622, 346);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.VersionText);
            this.Controls.Add(this.Slogan);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.AppName);
            this.Controls.Add(this.VersionName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(638, 385);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(638, 385);
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About RunEverything";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.Label Slogan;
        private System.Windows.Forms.Label VersionText;
        private System.Windows.Forms.Label VersionName;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label label1;
    }
}