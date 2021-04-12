using System;
using System.Windows.Forms;

namespace RunEverything
{
    public partial class MainForm : Form
    {
        public bool CanContinue = false;             // Info that will be read by Program.cs.
        public bool ErrorWorkingDir = false;         // It tells it what to execute.

        public MainForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            // Close the form.

            Close();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            // When the Run button is clicked, execute the command by closing the form
            // and giving the hand back to the main thread.

            Execute();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            // When the Browse button is clicked (the first one), open a dialog box to
            // allow the user to choose a file.

            if (BrowseDialog.ShowDialog() == DialogResult.OK)
            {
                // If the user selected a file, set its path to the text of the command
                // to execute.

                ProgramName.Text = BrowseDialog.FileName;
            }
        }

        private void ProgramName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void BrowseDir_Click(object sender, EventArgs e)
        {
            // Set the selected path in the dialog to System32 ;)

            FolderBrowser.SelectedPath = Environment.GetEnvironmentVariable("WinDir") + "\\system32\\";

            // Show the dialog on the screen

            if (FolderBrowser.ShowDialog() == DialogResult.OK)
            {
                // If the user clicked on OK, set the choice of the user to the selected
                // folder in the TextBox.
                WorkingDir.Text = FolderBrowser.SelectedPath;
            }
        }

        private void ProgramName_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Execute()
        {
            // Execute the command, by giving the control back to the main thread.

            // Set the info variables to the choices made by the user.

            RunProperties.Command         =      ProgramName.Text;
            RunProperties.Arguments       =      Args.Text;
            RunProperties.RunAsAdmin      =      Elevate.Checked;
            RunProperties.HideWindow      =      HideConsole.Checked;

            CanContinue = true;  // If CanContinue == false, the main thread will think that the user
            //                      clicked on Cancel!

            // Set the working dir to the user's choice if it is not blank. (default is the system drive)
            if (WorkingDir.Text != "")
            {
                RunProperties.WorkingDir = WorkingDir.Text;
            }

            // Close the form to stop this thread and to resume the main thread.
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Check if the program has admin rights. If so, disable the
            // "Run as administrator" option because it will be run as
            // admin since the admin rights inherit.

            if (Util.HasPrivileges())
            {
                Elevate.Checked = true;
                Elevate.Enabled = false;
            }

            // Set the default directory in the placeholder to the root of the system drive.

            WorkingDir.PlaceholderText = "Working Directory (Default: " + Environment.GetEnvironmentVariable("SystemDrive") + "\\)";
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            // When the user clicks on the About button, show the About dialog.

            // Create a new instance of the dialog
            Container Data = new Container();

            // Show the dialog
            Data.AboutFormData.ShowDialog();
        }

        private void RunDumpButton_Click(object sender, EventArgs e)
        {
            // When the user clicks on "Dump Settings...", the DumpForm will pop up.

            Container DataContainer = new Container();
            DataContainer.DumpFormData.ShowDialog();
        }
    }
}
