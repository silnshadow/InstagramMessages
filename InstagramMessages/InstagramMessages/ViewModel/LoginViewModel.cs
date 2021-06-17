using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace InstagramMessages.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public Action DisplayInvalidLoginPrompt;
        public Action DisplaySuccesfullLoginPrompt;
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private string email;
        public Command LogInCommand { get; }
        public Command RegistrationCommand { get; }
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }

        public INavigation Navigation { get; set; }
        public ICommand SubmitCommand { protected set; get; }
        public LoginViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            SubmitCommand = new Command(async () => await GotoPage2());
        }
        public async Task GotoPage2()
        {
            if(Email == "Silnshadow" && Password == "123")
            {
                await Navigation.PushAsync(new Pages.RegistrationPage());
            }
            else
            {
                DisplayInvalidLoginPrompt();
            }
            
        }

    }
}
