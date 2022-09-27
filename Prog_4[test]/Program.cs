// Aodhan Shaw / Alex Ryan
// CMPS 4143
// 09/26/2022
// Program 4: Find Island Game

namespace Prog_4_test_
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new StartScreen());
        }
    }
}