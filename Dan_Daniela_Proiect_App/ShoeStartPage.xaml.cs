using Dan_Daniela_Proiect_App.Models;

namespace Dan_Daniela_Proiect_App;


public partial class ShoeStartPage : ContentPage
{
    public ShoeStartPage()
    {
        InitializeComponent();
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetShoePageAsync();
    }
    async void OnShoePageAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProductPage
        {
            BindingContext = new ShoePage()
        });
    }
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new ProductPage
            {
                BindingContext = e.SelectedItem as ShoePage
            });
        }
    }
}