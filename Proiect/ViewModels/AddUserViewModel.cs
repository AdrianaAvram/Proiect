using FluentValidation;
using Proiect.Models;
using Proiect.Services;
using Proiect.Validator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Proiect.ViewModels
{
    public class AddUserViewModel : BaseViewModel
    {
        private INavigation _navigation;
        private UserValidator _contactValidator;
        private User _user;
        private ContactUser _contactUser;

        public ICommand AddUserCommand { get; private set; }
        

        public AddUserViewModel(INavigation navigation)
        {
            _navigation = navigation;
            _contactValidator = new UserValidator();
            _user = new User();
            _contactUser= new ContactUser();
            AddUserCommand = new Command(async () => await AddUser());
            

        }
        async Task AddUser()
        {
            var validationResults = _contactValidator.Validate(_user);

            if (validationResults.IsValid)
            {
                bool isUserAccept = await Application.Current.MainPage.DisplayAlert("Inregistrat!", "Do you want to save Contact details?", "OK", "Cancel");
                if (isUserAccept)
                {
                    await _contactUser.AddUser(_user);

                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Add Contact", validationResults.Errors[0].ErrorMessage, "Ok");
            }
        }
            
            
    }
}
