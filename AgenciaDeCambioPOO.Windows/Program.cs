using AgenciaDeCambioPOO.Ioc;
using System.Globalization;

namespace AgenciaDeCambioPOO.Windows
{
    
    internal static class Program
    {
        private static IServiceProvider? _serviceProvider;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Establecer la cultura para el hilo actual
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("es-AR");
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CreateSpecificCulture("es-AR");

            _serviceProvider = DI.ConfigurarDI();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmAgencia(_serviceProvider));
        }
    }
}