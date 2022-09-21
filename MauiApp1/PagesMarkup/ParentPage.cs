using CommunityToolkit.Maui.Markup;
using MauiApp1.Pages.Views;
using MauiApp1.PagesMarkup;
using ViewModels;

namespace MauiApp1.Pages;

public class ParentPage2 : BaseContentPage<ParentViewModel>
{
	public ParentPage2(ParentViewModel parent): base(parent, "sdlfk")
	{
		Content = new VerticalStackLayout
		{
			Children = {
                new ContentView2{ CardTitle = "skdjfhksjfh"},
                new ContentView2{ CardTitle = "skdjbvcbnfhksjfh"},
                new ContentView2{ CardTitle = "sfhksjfh"},
				new Entry()
				.Bind(Entry.TextProperty, nameof( ParentViewModel.Text), BindingMode.TwoWay),
                new ContentView2().Bind(ContentView2.CardTitleProperty, nameof(ParentViewModel.Text),BindingMode.OneWay)
            }
		};
	}
}