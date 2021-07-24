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
        #region
        private String fileName;
        private string directoryName;
        private bool isCreateDirectory;
        private bool isButtonNeeded;
        private string testLabelValue;
        private ObservableCollection<string> testContentList = new ObservableCollection<string>();
        #endregion

        #region
        public string TestLabelValue
        {
            get
            {
                return testLabelValue;
            }
            set
            {
                testLabelValue = value;
                OnPropertyChanged(nameof(TestLabelValue));
            }
        }
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
        public string DirectoryName
        {
            get { return directoryName; }
            set 
            { 
                directoryName = value;
                OnPropertyChanged(nameof(DirectoryName));
            }
        }

        public bool IsCreateDirectory
        {
            get
            {
                return isCreateDirectory;
            }
            set
            {
                isCreateDirectory = value;
                OnPropertyChanged(nameof(IsCreateDirectory));
            }
        }

        public bool IsButtonNeeded
        {
            get
            {
                return isButtonNeeded;
            }
            set
            {
                isButtonNeeded = value;
                OnPropertyChanged(nameof(IsButtonNeeded));
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
        #endregion
    }
}
