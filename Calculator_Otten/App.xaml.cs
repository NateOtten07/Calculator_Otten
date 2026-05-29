using Microsoft.Extensions.DependencyInjection;

namespace Calculator_Otten
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new CalculatorPage());
        }
    }
}