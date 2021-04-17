/* RunEverything
 * 
 * Copyright 2021 Ryanhtech Labs.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

using System;
using System.Windows.Forms;

namespace RunEverything
{
    public partial class DumpForm : Form
    {
        char Letter;

        // ------------------------------------------------------------
        // FORM STATUS
        // When the form closes, save the checked state of check boxes,
        // the text of the text boxes, etc.

        public static bool StatusEnabled      =         false;
        public static string StatusSaveLoc    =         "";
        public static bool StatusOpenFile     =         false;

        // ------------------------------------------------------------


        // ------------------------------------------------------------
        // UI METHODS

        public DumpForm()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            // Show the "Save file..." dialog.

            if (SaveDumpDialog.ShowDialog() == DialogResult.OK)
            {
                // If the user pressed "OK" in the dialog, set the textbox's
                // text to the selected location.

                SaveLocation.Text = SaveDumpDialog.FileName;
            }
        }

        private void Enable_CheckedChanged(object sender, EventArgs e)
        {
            // If the "Enable Dump" check box's checked state is changed...

            if (Enable.Checked)
            {
                // Enable the save location widget and the Browse button.

                SaveLocation.Enabled   =    true;
                Browse.Enabled         =    true;

                // Return, because we do not want to do anything more here.
                return;
            }

            // If the check box is unchecked, disable the widgets and return.

            SaveLocation.Enabled       = false;
            Browse.Enabled             = false;

            // Return
            return;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // When the user clicks on Cancel in the dialog, it saves the information
            // entered by the user to the RunPropertes class, and the status to the
            // status variables.

            // Check user entries

            if (!CheckUserEntry())
            {
                return;
            }

            // Save the settings

            RunProperties.DumpEnabled    =    Enable.Checked;
            RunProperties.DumpLocation   =    SaveLocation.Text;
            RunProperties.OpenDumpFile   =    OpenDumpCheckBox.Checked;

            // Save the stats and close.

            SaveStatus();

            Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            // When the user cancels the settings, save the status, and close the form.

            SaveStatus();

            Close();
        }

        private void DumpForm_Load(object sender, EventArgs e)
        {
            // When the form loads, obviously.

            // Set the widgets in the form from the saved state.

            Enable.Checked             =     StatusEnabled;
            SaveLocation.Text          =     StatusSaveLoc;
            OpenDumpCheckBox.Checked   =     StatusOpenFile;
        }

        // ------------------------------------------------------------
        // CLASS METHODS

        private void SaveStatus()
        {
            // Save the status of the form in the status variables.
            StatusEnabled              =      Enable.Checked;
            StatusOpenFile             =      OpenDumpCheckBox.Checked;
            StatusSaveLoc              =      SaveLocation.Text;

            return;
        }

        private bool CheckUserEntry()
        {
            // Checks if the file that the user typed actually exists to avoid data loss.

            if (System.IO.File.Exists(SaveLocation.Text))
            {
                // Show a warning, and save the answer to a variable.

                DialogResult Result = MessageBox.Show(

                    "This file already exists. Do you want to overwrite it?",  // Text

                    "Warning",  // Title

                    MessageBoxButtons.YesNo,  // Buttons

                    MessageBoxIcon.Question  // Icon
                );

                // If the user clicked on No (or closed the dialog), return false to cancel.

                if (Result != DialogResult.Yes)
                {
                    return false;
                }
            }

            // Checks if the user typed a valid path (not blank)

            if (SaveLocation.Text == "")
            {
                MessageBox.Show(
                    "Please enter a save location, or browse to the directory you want to save it.",
                    "RunEverything",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                // Return false to cancel.
                return false;
            }

            try
            {
                if (!System.IO.File.Exists(SaveLocation.Text))
                {
                    // Try to write to the file to check if we can without errors.
                    System.IO.File.WriteAllText(SaveLocation.Text, "");
                    System.IO.File.Delete(SaveLocation.Text);
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show(
                    "An error occurred. The write operation to the selected dump location encourted a problem. " +
                    "The access to the file might be denied, or the entered path isn't valid. You can try the following:\n\n" +
                    "- Run RunEverything as administrator.\n" +
                    "- Check the spelling of the save location.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }


            /* // Check the user entries (i.e. if directories exists)
            
            // EXPERIMENTAL FEATURE

            // ------------------------------------------------------------------------
            // Check if the directory where the user wants to dump exists.

            // Convert the / to \

            string Final = "";
            string Text = SaveLocation.Text;

            foreach (int Range in Text)
            {
                bool Authorize = true;

                Letter = Text[Range];

                if (Authorize)
                {
                    if (Letter == '/')
                    {
                        Letter = '\\';
                    }

                    Final += Letter;
                }
            } */

            // EXPERIMENTAL FEATURE

            /* SaveLocation.Text = Final;

            // Get a list from the save location directory structure

            List<string> Path       =     SaveLocation.Text.Split('\\', '/').ToList();

            // Remove the last element of Path which is the file name + extension
            Path.RemoveAt(Path.Count - 1);

            // Convert the list to a string
            string FinalString = "";

            foreach (string Element in Path)
            {
                FinalString += Element + "\\";
            }

            if (!System.IO.Directory.Exists(FinalString))
            {
                System.Windows.Forms.MessageBox.Show(
                    "The directory where you want to dump doesn't exist.",
                    "Error - RunEverything",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            } */
            return true;
        }
    }
}
