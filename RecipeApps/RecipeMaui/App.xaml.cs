namespace RecipeMaui
{
    public partial class App : Application
    {
        public static bool LoggedIn = false;
        public static string ConnStringSetting = "";
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}