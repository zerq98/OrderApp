using OrderApp.App;
using OrderApp.Infrastructure;
using SimpleInjector;
using System;
using System.Windows.Forms;

namespace OrderApp
{
    public static class Program
    {
        public static Container Container { get; set; }

        /// <summary>
        /// New container builder invoked on app start.
        /// Creates simple injector container with all dependencies.
        /// </summary>
        private static void SetContainer()
        {
            Container = new Container();
            AppRegistration.Register(Container);
            InfrastructureRegistration.Register(Container);
        }

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SetContainer();
            Application.Run(new MainForm());
        }
    }
}