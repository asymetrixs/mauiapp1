using CoreGraphics;
using UIKit;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        Console.WriteLine(
            $"UIApplication.SharedApplication.ConnectedScenes.OfType<UIWindowScene>().FirstOrDefault().Windows[0].Frame.X:" +
            $"{UIApplication.SharedApplication.ConnectedScenes.OfType<UIWindowScene>().FirstOrDefault().Windows[0].Frame.X}");

        Console.WriteLine(
            $"UIApplication.SharedApplication.ConnectedScenes.OfType<UIWindowScene>().FirstOrDefault().Windows[0].Screen.FixedCoordinateSpace.Bounds.Width:" +
            $"{UIApplication.SharedApplication.ConnectedScenes.OfType<UIWindowScene>().FirstOrDefault().Windows[0].Screen.FixedCoordinateSpace.Bounds.X}");

        Console.WriteLine(
            $"UIApplication.SharedApplication.ConnectedScenes.OfType<UIWindowScene>().FirstOrDefault().Windows[0].Screen.Bounds.X:" +
            $"{UIApplication.SharedApplication.ConnectedScenes.OfType<UIWindowScene>().FirstOrDefault().Windows[0].Screen.Bounds.X}");

        Console.WriteLine(
            $"UIApplication.SharedApplication.Windows[0].Frame.Height: {UIApplication.SharedApplication.Windows[0].Frame.Height}");

        Console.WriteLine(
            $"UIApplication.SharedApplication.Windows[0].Frame.X: {UIApplication.SharedApplication.Windows[0].Frame.X}");

        Console.WriteLine(
            $"UIApplication.SharedApplication.Windows[0].Frame.GetMaxX(): {UIApplication.SharedApplication.Windows[0].Frame.GetMaxX()}");

        Console.WriteLine(
            $"UIApplication.SharedApplication.Windows[0].WindowLevel: {UIApplication.SharedApplication.Windows[0].WindowLevel}");


        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}
