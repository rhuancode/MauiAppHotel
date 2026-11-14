namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    App PropriedadesAPP;  //declaração de propriedade
    private async void OnSobreTapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new pagina_sobre());
    }
    public ContratacaoHospedagem()
	{
		InitializeComponent();

        PropriedadesAPP = (App)Application.Current;

        pck_quarto.ItemsSource = PropriedadesAPP.lista_quartos;

        //Data mínima de check-in
        dtpck_checkin.MinimumDate = DateTime.Now;

        //Data máxima de check-in
        dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        //Data mínima de check-out
        dtpck_checkout.MinimumDate = dtpck_checkin.Date.Value.AddDays(1);

        //Data máxima de check-out
        dtpck_checkout.MaximumDate = dtpck_checkin.Date.Value.AddMonths(6);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new HospedagemContratada());
        } catch (Exception ex) 
        {
            DisplayAlertAsync("Ops", ex.Message, "Ok");
        }
    }

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_checkin = elemento.Date.Value;

        dtpck_checkout.MinimumDate = data_selecionada_checkin.AddDays(1);
        dtpck_checkout.MaximumDate = data_selecionada_checkin.AddMonths(6);
    }

}

// private: o método será acessível somente dentro da classe.
// async: permite executar operações assíncronas.
// void: o método não retorna um valor.
// OnSobreTapped: nome do método.
// Navigation: propriedade.
// PushAsync: método que permite trocar de página.
// Navigation.PushAsync(): abre uma nova página na pilha de navegação.
// new pagina_sobre() : cria uma instância da sua página Sobre.