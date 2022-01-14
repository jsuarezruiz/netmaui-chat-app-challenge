namespace ChatApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Metropolis-Black.otf", "Metropolis Black");
				fonts.AddFont("Metropolis-Light.otf", "Metropolis Light");
				fonts.AddFont("Metropolis-Medium.otf", "Metropolis Medium");
				fonts.AddFont("Metropolis-Regular.otf", "Metropolis Regular");
				fonts.AddFont("Metropolis-Regular.otf", "Metropolis Regular");
				fonts.AddFont("MaterialIcons-Regular.ttf", "Material Icons");
			});

		return builder.Build();
	}
}
