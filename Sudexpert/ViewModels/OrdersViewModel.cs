using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

using Sudexpert.Core.Models;
using Sudexpert.Core.Services;
using Sudexpert.Helpers;

namespace Sudexpert.ViewModels
{
    public class OrdersViewModel : Observable
    {
        public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

        public OrdersViewModel()
        {
        }

        public async Task LoadDataAsync()
        {
            Source.Clear();

            // TODO WTS: Replace this with your actual data
            var data = await SampleDataService.GetGridDataAsync();

            foreach (var item in data)
            {
                Source.Add(item);
            }
        }
    }
}
