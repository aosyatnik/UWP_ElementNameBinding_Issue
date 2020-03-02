using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;

namespace App1
{
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<ItemViewModel> Items { get; set; } = new ObservableCollection<ItemViewModel>();

        public bool IsStaggeringEnabled { get; set; } = true;

        public MainViewModel()
        {
            for (var i = 0; i < 10; i++)
            {
                Items.Add(new ItemViewModel());
            }
        }
    }
}
