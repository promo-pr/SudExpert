using System;

using Sudexpert.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Sudexpert.Views
{
    public sealed partial class OrdersPage : Page
    {
        public OrdersViewModel ViewModel { get; } = new OrdersViewModel();

        // TODO WTS: Change the grid as appropriate to your app, adjust the column definitions on OrdersPage.xaml.
        // For more details see the documentation at https://docs.microsoft.com/windows/communitytoolkit/controls/datagrid
        public OrdersPage()
        {
            InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            await ViewModel.LoadDataAsync();
        }
    }
}
