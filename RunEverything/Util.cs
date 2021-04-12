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


using System.Collections.Generic;

namespace RunEverything
{
    class Util
    {
        public static bool HasPrivileges()
        {
            // ----------------------------------------------------------------
            // Check if the app has admin privileges.
            //
            // Return value:
            //          bool
            //
            //-----------------------------------------------------------------

            using (System.Security.Principal.WindowsIdentity AppStatus = System.Security.Principal.WindowsIdentity.GetCurrent())
            {
                System.Security.Principal.WindowsPrincipal AppPrincipal = new System.Security.Principal.WindowsPrincipal(AppStatus);

                // Returns the boolean result: if RunEverything has been run as admin, return true.

                return AppPrincipal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator);
            }
        }

        public static string RunCommand(string Command,
                                        string Arguments,
                                        bool IsElevated,
                                        bool HideCMD,
                                        string WorkingDir,
                                        bool DumpEnabled,
                                        string DumpLocation,
                                        bool OpenDumpAfterOperation
        )
        {
            // Create process info + process class

            System.Diagnostics.Process CommandProcess              =        new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo CommandProcessInfo =        new System.Diagnostics.ProcessStartInfo();

            if (HideCMD)
            {
                // If the CMD window must be hidden
                CommandProcessInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            }


            if (!System.IO.Directory.Exists(WorkingDir))
            {
                // If the directory that the user typed in doesn't exist, return "DirMissing"
                return "DirMissing";
            }


            CommandProcessInfo.FileName              =       Command;            //
            CommandProcessInfo.Arguments             =       Arguments;          // Set the Process Info to the info that the user typed in
            CommandProcessInfo.WorkingDirectory      =       WorkingDir;         //
            if (IsElevated)
            {
                CommandProcessInfo.UseShellExecute   =       true;               //
                CommandProcessInfo.Verb              =       "runas";            // If the program must be run as admin
            }
            if (DumpEnabled)
            {
                CommandProcessInfo.RedirectStandardOutput = true;                // If the program output must be dumped
            }


            // Copy the start info to the Process class

            CommandProcess.StartInfo                 =       CommandProcessInfo;


            try
            {
                // Start the process under a try/catch
                CommandProcess.Start();
                
                // If the dump is enabled
                if (DumpEnabled)
                {
                    string       PrevLine        = "";
                    string       Line            = "";
                    List<string> Events          = new List<string>();
                    string       FinalString     = "";


                    // While the process runs

                    while (!CommandProcess.StandardOutput.EndOfStream)
                    {
                        // Read the line
                        Line = CommandProcess.StandardOutput.ReadLine();


                        if (Line != PrevLine)
                        {
                            // Set the previous line to this line
                            PrevLine = Line;

                            // Add the line to the list
                            Events.Add(Line);
                        }

                        // Sleep 30 milliseconds.

                        System.Threading.Thread.Sleep(30);
                    }

                    foreach (string ListLine in Events)
                    {
                        FinalString += ListLine + "\n";
                    }

                    System.IO.File.WriteAllText(DumpLocation, FinalString);

                    System.Windows.Forms.MessageBox.Show(
                                                         "Dump finished.",
                                                         "RunEverything",
                                                         System.Windows.Forms.MessageBoxButtons.OK,
                                                         System.Windows.Forms.MessageBoxIcon.Information
                    );
                }
            }


            catch (System.ComponentModel.Win32Exception Exception)
            {
                // If the file doesn't exist, or if the user clicked on "No" in the UAC prompt

                if (Exception.ErrorCode == -2147467259)
                {
                    // If the user denied the elevation of the program
                    return "NoPrivileges";
                }

                // If the file doesn't exist
                return "FileMissing";
            }

            catch (System.InvalidOperationException)
            {
                // If the user typed ""
                return "NoProgramEntered";
            }

            // Return nothing: the operation completed successfully
            return "";
        }
    }
}
