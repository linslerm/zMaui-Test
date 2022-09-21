
using CommunityToolkit.Maui.Markup;
using ViewModels;

namespace MauiApp1.PagesMarkup;

public abstract class BaseContentPage<T> : ContentPage where T : BaseViewModel
{
	protected BaseContentPage(T viewModel, string pageTitle)
	{
		base.BindingContext = viewModel;

		Title = pageTitle;
		//this.DynamicResource(ContentPage.BackgroundColorProperty, nameof(BaseTheme.PageBackgroundColor));
	}

	protected new T BindingContext => (T)base.BindingContext;
}