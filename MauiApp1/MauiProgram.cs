using CommunityToolkit.Maui.Markup;
using ViewModels;

namespace MauiApp1;

public static class MauiProgram
{
	public static IServiceProvider Services;
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkitMarkup()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddTransient<HomeViewModel>();
        builder.Services.AddTransient<ParentViewModel>();

        builder.Services.AddTransient<Pages.HomePage>();
        builder.Services.AddTransient<Pages.ParentPage>();


        builder.Services.AddTransient<Pages.ParentPage2>();
        builder.Services.AddTransient<Pages.HomePage2>();

        var app = builder.Build();
		Services = app.Services;
		return app;
	}
}
