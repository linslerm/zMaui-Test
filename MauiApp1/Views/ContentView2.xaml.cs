
namespace MauiApp1.Pages.Views;

public partial class ContentView2 : ContentView
{
    public static readonly BindableProperty CardTitleProperty = BindableProperty.Create(nameof(CardTitle), typeof(string), typeof(ContentView2), string.Empty, BindingMode.TwoWay);

    public string CardTitle
    {
        get => (string)GetValue(CardTitleProperty);
        set => SetValue(CardTitleProperty, value);
    }



    public ContentView2()
	{
		InitializeComponent();
	}
}