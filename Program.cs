using System.Text;

namespace WinFormsApp1
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
            Application.Run(new Form1());

            String file = @"F:\Projects\C#\WinFormsApp1\WinFormsApp1.csproj\output.csv";
            String separator = ",";
            StringBuilder output = new StringBuilder();
            String[] headings = { "Name", "Email", "Contact" };
            output.AppendLine(string.Join(separator, headings));

        }
    }
}