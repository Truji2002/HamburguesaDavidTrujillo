namespace HamburguesaDavidTrujillo;
using HamburguesaDavidTrujillo.Views;
public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(BurgerItemPageDT), typeof(BurgerItemPageDT));
    }
}
