using Dan_Daniela_Proiect_App.Data;
namespace Dan_Daniela_Proiect_App
{
    public partial class App : Application
    {
        public static ShoeProductDatabase Database { get; private set; }
        public App()
        {
            Database = new ShoeProductDatabase(new RestApi());
            MainPage = new NavigationPage(new ShoeStartPage());
        }
    }
}