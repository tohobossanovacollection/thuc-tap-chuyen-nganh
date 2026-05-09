using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsAppTest
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
            // Start the application with the login form
            //Application.Run(new DangNhap());
            Application.Run(new Dashboard("levents", "admin", "NV001", "Ban quan ly"));
        }
    }
}