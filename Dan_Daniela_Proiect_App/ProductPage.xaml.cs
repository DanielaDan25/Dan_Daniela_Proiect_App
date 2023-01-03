using Dan_Daniela_Proiect_App.Models;
namespace Dan_Daniela_Proiect_App;

public partial class ProductPage : ContentPage
{
	public ProductPage()
	{
		InitializeComponent();
	}
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (ShoePage)BindingContext;
       
        await App.Database.SaveShoePageAsync(slist);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var slist = (ShoePage)BindingContext;
        await App.Database.DeleteShopListAsync(slist);
        await Navigation.PopAsync();
    }

}