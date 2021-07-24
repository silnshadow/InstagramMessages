using InstagramMessages.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InstagramMessages.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FileExplorePage : ContentPage
    {
        public FileExplorePage()
        {
            var vm = new FileExploreViewModel();
            this.BindingContext = vm;
            vm.Searching += () => DisplayAlert("Created", "I created your file", "OK");
            InitializeComponent();
        }
    }
}