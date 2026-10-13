using Microsoft.Extensions.DependencyInjection;

namespace MauiAppMeuCombustivel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var w = new Window(new AppShell());
            w.Height = 750;
            w.Width = 400;

            return w;
        }
    }
}