using InstagramMessages.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InstagramMessages.Model.FileExplore
{
    public class FileExploreModel : Base
    {
        private String fileName;
        public string FileName
        {
            get
            {
                return fileName;
            }
            set
            {
                fileName = value;
                OnPropertyChanged(nameof(FileName));
            }
        }
    }
}
