namespace MauiAppMinhasCompras.Views;
using MauiAppMinhasCompras.Models;
public partial class NovoProduto : ContentPage
{
	public NovoProduto()
	{
		InitializeComponent();
	}

	private async void ToolbarItem_Clicled(object sender, EventArgs e)
	{
		try
		{
			Produto p = new Produto()
			{
				Descricao = txt_descricao.Text,
				Quantidade = Convert.ToDouble(txt_quantidade.Text),
				Preco = Convert.ToDouble(txt_preco.Text)
			};

			await App.Db.Insert(p);
			await DisplayAlert("Sucesso!", "Registro Inserido", "Ok");
			await Navigation.PopAsync();

		}
		catch (Exception ex)
		{
            await DisplayAlert("Ops", ex.Message, "Ok");
        }
	}
}