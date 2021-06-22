using System;
using Xamarin.Essentials;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using InstagramMessages.Model.FileExplore;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
                var path = File.FullPath;
                ConvertToJsonObject(path);
            }
        }

        private void ConvertToJsonObject(string filePath)
        {

        }
    }
}
