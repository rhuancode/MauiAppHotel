namespace MauiAppHotel.Views;

public partial class pagina_sobre : ContentPage
{
	public pagina_sobre()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PopAsync();
		} catch (Exception ex)
		{
			DisplayAlertAsync("Ops", ex.Message, "Ok");
		}
    }
}