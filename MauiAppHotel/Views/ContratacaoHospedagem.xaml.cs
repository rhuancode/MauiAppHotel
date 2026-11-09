namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    private async void OnSobreTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new pagina_sobre());
    }
    public ContratacaoHospedagem()
	{
		InitializeComponent();
	}
}

// private: o método será acessível somente dentro da classe.
// async: permite executar operações assíncronas.
// void: o método não retorna um valor.
// OnSobreTapped: nome do método.
// Navigation.PushAsync(): abre uma nova página na pilha de navegação.
// new pagina_sobre() : cria uma instância da sua página Sobre.