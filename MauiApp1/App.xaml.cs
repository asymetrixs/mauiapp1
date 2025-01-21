namespace MauiApp1;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        var window = new Window(new AppShell());

        window.SizeChanged += (sender, args) =>
        {
            if (sender is AppShell shell)
            {
                Console.WriteLine($"X Y W H: {shell.X} {shell.Y} {shell.Width} {shell.Height}");
            }
        };

        return window;
    }
}
