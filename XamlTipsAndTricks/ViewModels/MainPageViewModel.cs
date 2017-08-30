using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using XamlTipsAndTricks.Models;

namespace XamlTipsAndTricks
{
    public class MainPageViewModel
    {
        public ObservableCollection<Dog> Dogs { get; set; } = new ObservableCollection<Dog>();
        public ICommand DeleteCommand { get; set; }
        public bool IsEnable { get; set; } = true;

        public string Title { get; set; } = "Pupipo";
        public bool IsReadOnly { get; set; } = true;
        public MainPageViewModel()
        {
            Dogs.Add(new Dog(){Name="Mario", Photo="dog.jpg"});
			Dogs.Add(new Dog() { Name = "Carlos", Photo = "dog2.jpg" });

            DeleteCommand = new Command<Dog>((obj) =>
            {
                Dogs.Remove(obj);
            });
		}
    }
}
