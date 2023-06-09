using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarouselViewNotDetectingSwipe
{
    
    public partial class MainPageViewModel : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Monkey> monkeys;
        
        public MainPageViewModel()
        {
            Monkeys = new ObservableCollection<Monkey>();
            CreateMonkeyData();
        }

        private void CreateMonkeyData()
        { 
            var count = 1;
            while (count < 5)
            {
                var newMonkey = new Monkey() { Details = $"details {count}", Location = $"Location {count}", Name = $"Name {count}" };
                Monkeys.Add(newMonkey);
                count++;
            }

        }
    }
}
