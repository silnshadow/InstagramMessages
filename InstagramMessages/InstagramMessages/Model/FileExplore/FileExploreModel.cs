using InstagramMessages.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace InstagramMessages.Model.FileExplore
{
    public class FileExploreModel : Base
    {
        private String fileName;
        private ObservableCollection<string> testContentList = new ObservableCollection<string>();
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

        public ObservableCollection<string> TestContentList
        {
            get
            {
                return testContentList;
            }
            set
            {
                testContentList = value;
                OnPropertyChanged(nameof(TestContentList));
            }
        }

    }
}
