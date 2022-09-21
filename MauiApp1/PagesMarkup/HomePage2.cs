using CommunityToolkit.Maui.Markup;
using MauiApp1.PagesMarkup;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace MauiApp1.Pages;
public class HomePage2 : BaseContentPage<HomeViewModel>
{
    public HomePage2(HomeViewModel home) : base(home, "hdhgfd")
    {
        try
        {
            Content = new VerticalStackLayout
            {
                Children = {
                new Label().Bind(Label.TextProperty, nameof(HomeViewModel.Count)).CenterHorizontal(),
                new Label().Bind(Label.TextProperty, nameof(HomeViewModel.Title)).CenterHorizontal(),
                new Entry(){
                    Keyboard = Keyboard.Numeric,
                    HorizontalOptions = LayoutOptions.Center,
                    WidthRequest = 200
                }
                .Bind(Entry.TextProperty, nameof(HomeViewModel.AddNumber)),
                new Button{
                    Text = "Add Value",
                    WidthRequest = 200
                }
                .Bind(Button.CommandProperty, nameof(HomeViewModel.AddCommand)),
                new Button{
                    Text = "Save",
                    WidthRequest = 200
                }
                .Bind(Button.CommandProperty, nameof(HomeViewModel.SaveCommand)),
                new Button{
                    Text = "Reset",
                    WidthRequest = 200
                }
                .Bind(Button.CommandProperty, nameof(HomeViewModel.ResetCommand)),
                new CollectionView()
                {
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    ItemTemplate = new DataTemplate(() =>
                    {
                        return new HorizontalStackLayout
                        {
                            Children =
                            {
                                new Label().Bind(Label.TextProperty, nameof(CounterModel.Count)),
                                new Label().Bind(Label.TextProperty, nameof(CounterModel.CreatedString), stringFormat: " Date: {0}"),
                                new Button
                                {
                                    Text = "Remove Item",
                                    HeightRequest = 40
                                }.Bind(Button.CommandProperty, nameof(HomeViewModel.AddCommand),source: this)
                            }
                        };
                    })
                }.Bind(CollectionView.ItemsSourceProperty, nameof(HomeViewModel.Values))

            }
            };
        }
        catch (Exception e)
        {
            throw;
        }
    }
}
