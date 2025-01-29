using Microsoft.Extensions.Logging;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
    public MainPage(ILoggerFactory loggerFactory)
    {
        InitializeComponent();

        BindingContext = new MainBacking();

        Mirror.SizeChanged += (sender, args) =>
        {
            if (sender is Image image && Application.Current.Windows.Count > 0)
            {
                var logger = loggerFactory.CreateLogger<MainPage>();
                logger.LogInformation(
                    $"control width: {image.Width}, control height: {image.Height}, app width: {App.Current.Windows[0].Width}, app height: {App.Current.Windows[0].Height}");
            }
        };
    }
}
