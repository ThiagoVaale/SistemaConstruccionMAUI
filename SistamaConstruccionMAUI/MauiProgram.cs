using Application.SupplierModule.CreateSupplier;
using Application.SupplierModule.DeleteSupplier;
using Application.SupplierModule.GetAll;
using Application.SupplierModule.UpdateSupplier;
using Microsoft.Extensions.Logging;

namespace SistamaConstruccionMAUI
{
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
                });

            builder.Services.AddMauiBlazorWebView();

            builder.Services.AddScoped<Services.ToastService>();

            builder.Services.AddScoped<GetAllSupplierHandler>();
            builder.Services.AddScoped<CreateSupplierHandler>();
            builder.Services.AddScoped<UpdateSupplierHandler>();
            builder.Services.AddScoped<DeleteSupplierHandler>();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
