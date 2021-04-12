/* RunEverything
 * Copyright (c) 2021 Ryanhtech Labs.
 * This program is protected by legal rights. You can't view the source code without permission.
 */


using System;
using System.Windows.Forms;

namespace RunEverything
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static int Main()
        {
            // --------------------------------------------------------------------------------
            // Program.Main() [static, returns int]
            // Function that is called at startup.
            // --------------------------------------------------------------------------------

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool FileMissing        =    false;  // If an error must be shown after restarting
            bool DirMissing         =    false;


            string SaveProgram      =    "";
            string SaveArguments    =    "";    // Variables used to save the dialog's state while restarting it
            string SaveWorkingDir   =    "";


            while (true)
            {
                Container Data = new Container();


                if (!FileMissing)
                {
                    // If the file exists, or if the application started for the first time, clear
                    // the error text on the form, else the user will think that there is an error.
                    Data.Form1Data.Error.Text = "";
                }


                if (!DirMissing)
                {
                    Data.Form1Data.DirectoryDoesntExist.Text = "";
                }


                Data.Form1Data.ProgramName.Text   =   SaveProgram;
                Data.Form1Data.Args.Text          =   SaveArguments;
                Data.Form1Data.WorkingDir.Text    =   SaveWorkingDir;


                // Run the app

                Data.Form1Data.ShowDialog();


                // Put the errors variables back to false, because no error happened obviously,
                // we haven't run anything yet...
                FileMissing  =   false;
                DirMissing   =   false;


                if (Data.Form1Data.CanContinue)
                {
                    string Result = Util.RunCommand(RunProperties.Command,
                                                    RunProperties.Arguments,
                                                    RunProperties.RunAsAdmin,
                                                    RunProperties.HideWindow,
                                                    RunProperties.WorkingDir,
                                                    RunProperties.DumpEnabled,
                                                    RunProperties.DumpLocation,
                                                    RunProperties.OpenDumpFile
                    );


                    if (Result == "")
                    {
                        // If the program ran without any errors, quit RunEverything
                        return 0;
                    }

                    else if (Result == "FileMissing")
                    {
                        // Else, set the variable to FileMissing to true.
                        FileMissing = true;
                    }

                    else if (Result == "NoProgramEntered")
                    {
                        // Same
                        FileMissing = true;
                    }

                    else if (Result == "DirMissing")
                    {
                        DirMissing = true;
                    }

                    else if (Result == "NoPrivileges")
                    {
                        System.Windows.Forms.MessageBox.Show(
                            "The program has not enough privileges to start. The requested operation failed. Try to give it elevation.",
                            "Catastrophic Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }


                    SaveProgram    =    Data.Form1Data.ProgramName.Text;
                    SaveArguments  =    Data.Form1Data.Args.Text;
                    SaveWorkingDir =    Data.Form1Data.WorkingDir.Text;


                    // Destroy the form

                    Data.Form1Data = null;
                }
                else
                {
                    // If the user clicked on Cancel

                    return 0;
                }
            }
        }
    }
}
