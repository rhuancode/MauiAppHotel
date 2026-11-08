using Microsoft.Extensions.DependencyInjection;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400; //definindo a largura
            window.Height = 600; //definindo a altura

            return window;
        }
    }
} // Retorno do método do tipo: Window
  // O método se chama: CreateWindow
  // Parâmetro chamado: IActivationState