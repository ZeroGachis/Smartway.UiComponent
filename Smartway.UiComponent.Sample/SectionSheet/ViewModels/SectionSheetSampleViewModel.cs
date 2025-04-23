using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Smartway.UiComponent.Sample.SectionSheet.ViewModels
{
    public class SectionSheetSampleViewModel: ViewModel
    {
        public ObservableCollection<object> Articles => new ObservableCollection<object>
        {
            new DummyArticle
            {
                Label = "Article 1",
                Price = "0,3€",
                Gencode = "1234567891234",
                NavigationParameter = "Article 1",
                IsMultilocation = false,
                IsOnShortage = false
            },
            new DummyArticle
            {
                Label = "Article 2",
                Price = "0,3€",
                Gencode = "1234567891234",
                NavigationParameter = "Article 2",
                IsMultilocation = true,
                IsOnShortage = false
            },
            new DummyArticle
            {
                Label = "Article 3",
                Price = "0,3€",
                Gencode = "1234567891234",
                NavigationParameter = "Article 3",
                IsOnShortage = false,
                IsMultilocation = false
            },
            new DummyArticle
            {
                Label = "Article 4",
                Price = "0,3€",
                Gencode = "1234567891234",
                NavigationParameter = "Article 4",
                Status = "Monitored",
                IsOnShortage = false,
                IsMultilocation = false
            },
            new DummyArticle
            {
                Label = "Article 5",
                Price = "0,3€",
                Gencode = "1234567891234",
                NavigationParameter = "Article 5",
                Status = "Unmonitored",
                IsMultilocation = true,
                IsOnShortage = false
            },
        };

        public ICommand DisplayToastCommand => new Command((param) =>
        {
            var message = "Product Card is tapped";
            DependencyService.Get<INotifyMessage>().ShortAlert(message);
        });
    }
}
