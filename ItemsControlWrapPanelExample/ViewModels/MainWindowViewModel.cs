
using Avalonia.Media;
using ItemsControlWrapPanelExample.Models;
using ReactiveUI;
using System.Collections.ObjectModel;
using System.Reactive.Linq;

namespace ItemsControlWrapPanelExample.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<Item> items;

        public MainWindowViewModel()
        {
            Items = new ObservableCollection<Item>();
            Items.Add(new Item { Name = "RedName", Color = new SolidColorBrush(Colors.Red) });
            Items.Add(new Item { Name = "GreenName", Color = new SolidColorBrush(Colors.Green) });
            Items.Add(new Item { Name = "PurpleName", Color = new SolidColorBrush(Colors.Purple) });
            Items.Add(new Item { Name = "BlueName", Color = new SolidColorBrush(Colors.Blue) });
            Items.Add(new Item { Name = "OrangeName", Color = new SolidColorBrush(Colors.Orange) });
            Items.Add(new Item { Name = "RedName", Color = new SolidColorBrush(Colors.Red) });
            Items.Add(new Item { Name = "GreenName", Color = new SolidColorBrush(Colors.Green) });
            Items.Add(new Item { Name = "PurpleName", Color = new SolidColorBrush(Colors.Purple) });
            Items.Add(new Item { Name = "BlueName", Color = new SolidColorBrush(Colors.Blue) });
            Items.Add(new Item { Name = "OrangeName", Color = new SolidColorBrush(Colors.Orange) });
            Items.Add(new Item { Name = "RedName", Color = new SolidColorBrush(Colors.Red) });
            Items.Add(new Item { Name = "GreenName", Color = new SolidColorBrush(Colors.Green) });
            Items.Add(new Item { Name = "PurpleName", Color = new SolidColorBrush(Colors.Purple) });
            Items.Add(new Item { Name = "BlueName", Color = new SolidColorBrush(Colors.Blue) });
            Items.Add(new Item { Name = "OrangeName", Color = new SolidColorBrush(Colors.Orange) });
            Items.Add(new Item { Name = "RedName", Color = new SolidColorBrush(Colors.Red) });
            Items.Add(new Item { Name = "GreenName", Color = new SolidColorBrush(Colors.Green) });
            Items.Add(new Item { Name = "PurpleName", Color = new SolidColorBrush(Colors.Purple) });
            Items.Add(new Item { Name = "BlueName", Color = new SolidColorBrush(Colors.Blue) });
            Items.Add(new Item { Name = "OrangeName", Color = new SolidColorBrush(Colors.Orange) });
        }

        public ObservableCollection<Item> Items
        {
            get { return items; }
            set
            {
                this.RaiseAndSetIfChanged(ref items, value);
            }
        }
    }
}