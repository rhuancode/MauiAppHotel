using MauiAppHotel.Models; // avisando o C# que será dado o include no arquivo model.
using Microsoft.Extensions.DependencyInjection;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        { 
            //Declarando objetos da lista
            new Quarto()  //objeto da posição 0 da lista
            {
                //Atributos
                Descricao = "Suíte Super Luxo",
                ValorDiariaAdulto = 110.0,
                ValorDiariaCrianca = 55.0
            }, //a vírgula é para a separação de objetos

            new Quarto()  //objeto da posição 1 da lista
            {
                Descricao = "Suíte Luxo",
                ValorDiariaAdulto = 80.0,
                ValorDiariaCrianca = 40.0
            },

            new Quarto() //objeto da posição 2 da lista
            {
                Descricao = "Suíte Single",
                ValorDiariaAdulto = 50.0,
                ValorDiariaCrianca = 25.0
            },

            new Quarto() //objeto da posição 3 da lista
            {
                Descricao = "Suíte Crise",
                ValorDiariaAdulto = 25.0,
                ValorDiariaCrianca = 12.5
            }
        };
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