using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Web;
using Xaminals.Models;


namespace Xaminals.ViewModels
{
    [QueryProperty(nameof(Elephant), "Elephant")]
    [QueryProperty(nameof(Name), "name")]

    public class ElephantDetailPageViewModel : ViewModel
    {
        private string name;
        public string Name { get => name; set { name = value; OnPropertyChanged(); } }

        Animal elephant;
        public Animal Elephant
        {
            get => elephant;
            set
            {
                elephant = value;
                OnPropertyChanged();
            }
        }




    }
}
