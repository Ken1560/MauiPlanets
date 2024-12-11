using Microsoft.Extensions.Logging;

namespace MauiPlanets
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
                    //otsida Internetist need fontid ülesse ja panna enda projekti
                    fonts.AddFont("Montserrat-Medium.ttf", "RegularFont");
                    fonts.AddFont("Montserrat-SemiBold.ttf", "MediumFont");
                    fonts.AddFont("Montserrat-Bold.ttf", "BoldFont");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
