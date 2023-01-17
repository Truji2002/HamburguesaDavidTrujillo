using HamburguesaDavidTrujillo.Models;
using HamburguesaDavidTrujillo.Data;
namespace HamburguesaDavidTrujillo.Views;


public partial class BurgerListPageDT : ContentPage
{
    public BurgerListPageDT()
    {
        InitializeComponent();
        List<BurgerDT> burger = App.BurgerRepoDT.GetAllBurgers();
        burgerList.ItemsSource = burger;
    }
    async void OnItemAdded(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(BurgerItemPageDT));
    }
    public void ActualizarListaDT()
    {
        List<BurgerDT> burger = App.BurgerRepoDT.GetAllBurgers();
        burgerList.ItemsSource = burger;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        {
            ActualizarListaDT();
        }
    }


    private void OnCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }
}