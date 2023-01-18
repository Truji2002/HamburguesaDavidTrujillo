namespace HamburguesaDavidTrujillo.Views;
using HamburguesaDavidTrujillo.Data;
using HamburguesaDavidTrujillo.Models;
using HamburguesaDavidTrujillo.Views;
using Microsoft.Maui.Dispatching;

[QueryProperty("Item","Item")]
public partial class BurgerItemPageDT : ContentPage
{
        
    public BurgerDT Item
        {
        get => BindingContext as BurgerDT;
        set => BindingContext = value;
        }
    //BurgerDT ItemDT = new BurgerDT();
    //bool _flagDT;
         
    public BurgerItemPageDT()
        {
            InitializeComponent();
            BurgerListPageDT burgerListPageDT= new BurgerListPageDT();
            burgerListPageDT.ActualizarListaDT();
            FechaDT.Text= "Hora creacion:"+"\n"+DateTime.Now.ToString();
       
    }

        private void OnSaveClicked(object sender, EventArgs e)
        {
            //ItemDT.NameDT = nameBDT.Text;
            //ItemDT.DescriptionDT = descBDT.Text;
            //ItemDT.WithExtraCheeseDT = _flagDT;
            Item.DateTimeDT= DateTime.Parse(fuente.Text);
            App.BurgerRepoDT.AddNewBurger(Item);
            Shell.Current.GoToAsync("///BurgerListPageDT");
            
        }
        private void OnCancelClicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("///BurgerListPageDT");
        }
       // private void OnCheckBoxCheckedChanged(object sender,
       //CheckedChangedEventArgs e)
       // {
       //     //_flagDT = e.Value;
       // }

    private void OnBorrarClicked(object sender, EventArgs e)
    {
        App.BurgerRepoDT.DeleteBurger(Item);
        Shell.Current.GoToAsync("///BurgerListPageDT");
    }

}