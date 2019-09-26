using System;

using Sudexpert.ViewModels;

using Windows.UI.Xaml.Controls;

namespace Sudexpert.Views
{
    public sealed partial class LogInPage : Page
    {
        public LogInViewModel ViewModel { get; } = new LogInViewModel();

        public LogInPage()
        {
            InitializeComponent();
        }
    }
}
