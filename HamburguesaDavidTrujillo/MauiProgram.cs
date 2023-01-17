using HamburguesaDavidTrujillo.Data;

namespace HamburguesaDavidTrujillo;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		string dbPath = FileAccessHelperDT.GetLocalFilePath("burger.dbDT");
		builder.Services.AddSingleton<BurgerDatabaseDT>(s=> ActivatorUtilities.CreateInstance<BurgerDatabaseDT>(s, dbPath));

		return builder.Build();
	}
}
