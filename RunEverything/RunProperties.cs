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


namespace RunEverything
{
    class RunProperties
    {
        /* This class provides information about the program to execute,
         * his arguments, the dump info, and more.
         */

        // ------------------------------------------------------------
        // BASIC INFO

        public static string Command         =     "";
        public static string Arguments       =     "";
        public static string WorkingDir      =     System.Environment.GetEnvironmentVariable("SystemDrive") + "\\";
        public static bool RunAsAdmin        =     false;
        public static bool HideWindow        =     false;

        // ------------------------------------------------------------
        // DUMP INFO

        public static bool DumpEnabled       =     false;
        public static string DumpLocation    =     "";
        public static bool OpenDumpFile      =     false;

        // ------------------------------------------------------------
    }
}

