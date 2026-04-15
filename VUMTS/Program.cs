namespace VUMTS
{
    public static class Program
    {
        private static IModel model;
        private static IView view;
        private static IController controller;

        /// <summary>
        ///  The main entry point for the application. 
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            view = new View();
            controller = new ControllerUltibotMaintenanceSuite();
            model = new ModelVirtualUltibot();

            view.Controller = controller;
            view.Model = model;
            controller.Model = model;
            controller.View = view;
            model.View = view;
            model.Controller = controller;

            Application.Run((View)view);
        }
    }
}