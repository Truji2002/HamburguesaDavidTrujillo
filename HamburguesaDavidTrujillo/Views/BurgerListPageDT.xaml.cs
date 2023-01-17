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
        BindingContext = this;
    }
    public void OnItemAdded(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(BurgerItemPageDT), true, new Dictionary<string, object>
        {
            ["Item"]=new BurgerDT()
        });
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


    private void OnCollectionView_SelectionChangedDT(object sender, SelectionChangedEventArgs e)
    {
        BurgerDT burger = e.CurrentSelection.FirstOrDefault() as BurgerDT;
        if (burger == null)
        {
            return;
        }
        Shell.Current.GoToAsync(nameof(BurgerItemPageDT), true, new Dictionary<string, object>
        {
            { "Item", burger}
        });
        ((CollectionView)sender).SelectedItem = null;

    }
}