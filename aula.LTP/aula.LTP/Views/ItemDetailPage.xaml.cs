using aula.LTP.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace aula.LTP.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}