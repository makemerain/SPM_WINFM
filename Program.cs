using System.Globalization;

namespace SPM_WINFM
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Set the culture for the application
            CultureInfo customCulture = (CultureInfo)CultureInfo.InvariantCulture.Clone();
            customCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";   // Custom date format
            customCulture.DateTimeFormat.LongTimePattern = "HH:mm:ss";     // Custom time format
            customCulture.DateTimeFormat.FullDateTimePattern = "dd/MM/yyyy HH:mm:ss"; // Full format

            // Apply custom culture to the current thread
            Thread.CurrentThread.CurrentCulture = customCulture;
            Thread.CurrentThread.CurrentUICulture = customCulture;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmMain());
        }
    }
}