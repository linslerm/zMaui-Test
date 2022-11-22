namespace MauiApp1;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

    protected override Window CreateWindow(IActivationState activationState)
    {
        // Get display size
        var displayInfo = DeviceDisplay.Current.MainDisplayInfo; // Center the window
        var window =  base.CreateWindow(activationState);
        window.X = (displayInfo.Width / displayInfo.Density - window.Width) / 2; window.Y = (displayInfo.Height / displayInfo.Density - window.Height) / 2;
        return window;
    }
}
