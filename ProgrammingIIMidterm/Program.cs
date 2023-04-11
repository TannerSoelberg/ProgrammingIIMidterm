/*
UNIT TESTING:

A unit test is a program which tests a specific method (or aspect of that method). Such tests should cover
any situation which the method may be put through. By testing methods so rigorously, you can be sure they 
operate correctly. Testing in such a manner allows you to make sure all bases are covered, avoiding unnecessary
error and complications.
*/

namespace ProgrammingIIMidterm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());
        }
    }
}