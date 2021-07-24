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
using System.Linq;
using InstagramMessages.Model.InstagramMessages;

namespace InstagramMessages.ViewModel
{
    public class FileExploreViewModel
    {
        #region
        public FileExploreModel Model { get; set; }
        private string filePath { get; set; }

        public StringBuilder RadableMessage;

        public Action Searching;
        public ICommand BrowseFileCommand { protected set; get; }
        public ICommand CreateReadableFileCommand { protected set; get; }

        #endregion

        #region
        public string FilePath
        {
            get
            {
                return filePath;
            }
            set
            {
                filePath = value;
            }
        }
        #endregion
        public FileExploreViewModel()
        {
            Model = new FileExploreModel();
            RadableMessage = new StringBuilder();
            BrowseFileCommand = new Command(() => SearchFile());
            CreateReadableFileCommand = new Command(() => CreateReadableFile());
        }
        private async void SearchFile()
        {
            var File = await FilePicker.PickAsync();
            if(File != null)
            {
                FilePath = File.FullPath;
                Model.FileName = File.FileName;
                Model.IsButtonNeeded = true;
                Model.IsCreateDirectory = true;
                ConvertToJsonObject(FilePath);
            }
        }

        public void ConvertToJsonObject(string filePath)
        {
            try
            {
                string jsonFromFile;
                using (var reader = new StreamReader(filePath))
                {
                    jsonFromFile = reader.ReadToEnd();
                }
                var CustomFromJson = JsonConvert.DeserializeObject<List<DirectMessage>>(jsonFromFile);
                if (CustomFromJson.Any())
                {
                    for (int j = 0; j < CustomFromJson.Count; j++)
                    {
                        int convoCount = j;
                        var a = CustomFromJson[j];
                        var numberOfParticipants = a.Participants.Count;
                        if (numberOfParticipants >= 1)
                        {
                            string user1 = a.Participants[0];
                            if (a.Participants[1].Any())
                            {
                                string user2 = a.Participants[1].Any() ? a.Participants[1] : null;
                                RadableMessage.AppendLine($"Convo No {convoCount} : Conversation between {user1} and {user2}" + ":");

                                var userMessages = CustomFromJson.Select(s => new
                                {
                                    Name = s.Participants.ToList(),
                                    Convo = s.Conversation.OrderBy(r => r.CreatedAt)
                                }).Where(p => p.Name.Contains(user1) && p.Name.Contains(user2)).ToList();

                                foreach(var message in userMessages)
                                {
                                    foreach (var z in message.Convo)
                                    {
                                        RadableMessage.AppendLine(z.CreatedAt + " " + z.Sender + " " + z.Text);
                                    }
                                }
                            }
                        }
                        else if (numberOfParticipants > 2)
                        {
                            RadableMessage.AppendLine("Sorry ! Nothing to show");
                        }
                        else
                        {
                            RadableMessage.AppendLine("Sorry ! Nothing to show");
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        private void CreateReadableFile()
        {
            try
            {
                //var filename = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), Model.DirectoryName + ".txt");
                //System.IO.File.WriteAllText(filename, RadableMessage.ToString());
                Model.TestLabelValue = RadableMessage.ToString();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

    }
}
