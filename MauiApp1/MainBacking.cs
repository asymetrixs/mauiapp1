using System.Diagnostics.CodeAnalysis;
using System.Windows.Input;

namespace MauiApp1;

public sealed class MainBacking
{
    public ICommand ExitCommand { get; }

    public MainBacking()
    {
        ExitCommand = new Command(async () => await Exit());
    }

    private ImageSource _currentImage;

    public ImageSource CurrentImage
    {
        get => _currentImage;
        private set { _currentImage = value; }
    }


    [DoesNotReturn]
    public async Task Exit()
    {
        Application.Current!.Quit();
    }
}
