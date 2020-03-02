using GalaSoft.MvvmLight;

namespace App1
{
    public class ItemViewModel : ViewModelBase
    {
        public static int Index = 0;
        public string Name { get; set; }

        public ItemViewModel()
        {
            Index++;
            Name = $"{Index}";
        }
    }
}
