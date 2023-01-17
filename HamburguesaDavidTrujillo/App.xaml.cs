using HamburguesaDavidTrujillo.Data;

namespace HamburguesaDavidTrujillo;

public partial class App : Application
{
    public static BurgerDatabaseDT BurgerRepoDT { get; private set; }

    public App(BurgerDatabaseDT repo)
    {
        InitializeComponent();

        MainPage = new AppShell();

        BurgerRepoDT = repo;
    }
}
