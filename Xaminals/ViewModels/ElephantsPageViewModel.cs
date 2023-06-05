using System.Collections.ObjectModel;
using System.Windows.Input;
using Xaminals.Data;
using Xaminals.Models;

namespace Xaminals.ViewModels
{
    public class ElephantsPageViewModel : ViewModel
    {
        
        private DataSource _dataSource;

        public ObservableCollection<Animal> Elephants { get; set; }

        private Animal selectedElephant;
        public Animal SelectedElephant { get => selectedElephant; set { selectedElephant = value; OnPropertyChanged(); } }
        public ICommand SelectCommand { get; private set; }

        public ElephantsPageViewModel(DataSource dataSource)
        {
            _dataSource = dataSource;
            Elephants = new ObservableCollection<Animal>(_dataSource.GetElephants());

            SelectCommand = new Command(async (x) => {
                var naviP = new Dictionary<string, object> { { "Elephant", SelectedElephant } };
                await Shell.Current.GoToAsync($"elephantdetails", naviP);
                await Shell.Current.GoToAsync($"elephantdetails?name={SelectedElephant.Name}");
            
            });

        }

       


    }
}
