using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels;


public partial class HomeViewModel: BaseViewModel
{

    public ObservableCollection<CounterModel> Values { get; } = new();

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(Title))]
    int count;

    [ObservableProperty]
    string addNumber = "12";

    public string Title { get => $"You have clicked {Count} Times"; }


    [RelayCommand]
    void Add()
    {
        int.TryParse(AddNumber, out var number);
        Count+=number;
    }

    [RelayCommand]
    private void Reset()
    {
        Count = 0;
        Values.Clear();
    }

    [RelayCommand]
    private void Save()
    {
        Values.Add(new()
        {
            Created = DateTime.Now,
            Count = Count,
        });
    }

    [RelayCommand]
    private void Delete(CounterModel counter)
    {
        var val = Values.FirstOrDefault(x => x.Id == counter.Id);
        if (val is null) return;
        Values.Remove(val);
    }
}
