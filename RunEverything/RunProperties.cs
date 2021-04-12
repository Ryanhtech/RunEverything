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

