using System.Collections.ObjectModel;

namespace CarouselViewBugs;

public partial class CarouselContentView : ContentView
{
    public static readonly BindableProperty ItemsProperty = BindableProperty.Create(nameof(Items), typeof(ObservableCollection<int>), typeof(CarouselContentView));
    public static readonly BindableProperty SelectedItemProperty = BindableProperty.Create(nameof(SelectedItem), typeof(int), typeof(CarouselContentView));

    public ObservableCollection<int> Items
    {
        get => (ObservableCollection<int>)GetValue(ItemsProperty);
        set => SetValue(ItemsProperty, value);
    }

    public object SelectedItem
    {
        get => (object)GetValue(SelectedItemProperty);
        set => SetValue(SelectedItemProperty, value);
    }


    public CarouselContentView()
    {
        InitializeComponent();

        Items = new ObservableCollection<int>(Enumerable.Range(1, 30));
    }
}