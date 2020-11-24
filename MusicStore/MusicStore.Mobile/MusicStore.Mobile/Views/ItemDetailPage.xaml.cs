using MusicStore.Mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MusicStore.Mobile.Views
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