using Xaminals.ViewModels;

namespace Xaminals.Views
{
    public partial class MonkeyDetailPage : ContentPage
    {
        public MonkeyDetailPage(MonkeyDetailPageViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;

        }
    }
}