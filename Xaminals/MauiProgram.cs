using System.Runtime.CompilerServices;
using Xaminals.Data;
using Xaminals.ViewModels;
using Xaminals.Views;

namespace Xaminals;

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
			}).RegisterPages().RegisterViewModels().RegisterDataServices();
	        
		return builder.Build();
	}

	public static MauiAppBuilder RegisterPages(this MauiAppBuilder builder)
	{
		//--------singleton Pages
		builder.Services.AddSingleton<MonkeysPage>();
        builder.Services.AddSingleton<ElephantsPage>();
        builder.Services.AddSingleton<DogsPage>();
        builder.Services.AddSingleton<CatsPage>();
        builder.Services.AddSingleton<BearsPage>();

		//--------Transient pages

        builder.Services.AddTransient<MonkeyDetailPage>();
        builder.Services.AddTransient<ElephantDetailPage>();
        builder.Services.AddTransient<DogDetailPage>();
        builder.Services.AddTransient<CatDetailPage>();
        builder.Services.AddTransient<BearDetailsPage>();
        builder.Services.AddTransient<BearDetailsPageViewModel>();

        return builder;
	}

    public static MauiAppBuilder RegisterDataServices(this MauiAppBuilder builder)
    {
        builder.Services.AddSingleton<DataSource>();
        return builder;
    }
    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
	{
        builder.Services.AddSingleton<MonkeysPageViewModel>();
        builder.Services.AddSingleton<ElephantsPageViewModel>();
        builder.Services.AddSingleton<DogsPageViewModel>();
        builder.Services.AddSingleton<CatsPageViewModel>();
        builder.Services.AddSingleton<BearsPageViewModel>();
      




        //--------Transient ViewModels

        builder.Services.AddTransient<MonkeyDetailPageViewModel>();
        builder.Services.AddTransient<BearDetailsPageViewModel>();
        builder.Services.AddTransient<ElephantDetailPageViewModel>();
        builder.Services.AddTransient<DogDetailPageViewModel>();
        builder.Services.AddTransient<CatDetailPageViewModel>();
     
        
        return builder;
    }
}
