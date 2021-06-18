using System;
using Xamarin.Essentials;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using InstagramMessages.Model.FileExplore;

namespace InstagramMessages.ViewModel
{
    public class FileExploreViewModel
    {
        public FileExploreModel Model { get; set; }
        public Action Searching;
        public ICommand BrowseFileCommand { protected set; get; }
        public FileExploreViewModel()
        {
            Model = new FileExploreModel();
            BrowseFileCommand = new Command(() => SearchFile());
        }
        private async void SearchFile()
        {
            var File = await FilePicker.PickAsync();
            if(File != null)
            {
                Model.FileName = File.FileName;
            }
        }

    }
}
