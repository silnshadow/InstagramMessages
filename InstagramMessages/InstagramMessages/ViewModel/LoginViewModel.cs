using InstagramMessages.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace InstagramMessages.ViewModel
{
    public class LoginViewModel : Base
    {
        public Action DisplayInvalidLoginPrompt;
        public Action DisplaySuccesfullLoginPrompt;
        private string email;
        public Command LogInCommand { get; }
        public Command RegistrationCommand { get; }
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged(Email);
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged(Password);
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
            if(Email == "S" && Password == "1")
            {
                await Navigation.PushAsync(new Pages.FileExplorePage());
            }
            else
            {
                DisplayInvalidLoginPrompt();
                await Navigation.PushAsync(new Pages.RegistrationPage());
            }
           
        }

    }
}
