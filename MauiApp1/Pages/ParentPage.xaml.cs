using ViewModels;

namespace MauiApp1.Pages;

public partial class ParentPage : ContentPage
{


    public ParentPage(ParentViewModel parent)
    {
        InitializeComponent();
        BindingContext = parent;
    }
}