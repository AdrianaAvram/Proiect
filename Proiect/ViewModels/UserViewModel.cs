using FluentValidation;
using Proiect.Models;
using Proiect.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Proiect.ViewModels
{
   public  class UserViewModel : BaseViewModel
    {
      
        public int Id { get; set; }
       
        public UserViewModel(User user)
        {
            Id = user.Id;
            UserName = user.UserName;
            Name = user.Name;
            Password = user.Password;
            ConfirmPassword = user.ConfirmPassword;
            Age = user.Age;

        }
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set
            {
                SetValue(ref _userName, value);
                OnPropertyChanged(nameof(UserName));
            }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                SetValue(ref _name, value);
                OnPropertyChanged(nameof(Name));
            }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                SetValue(ref _password, value);
                OnPropertyChanged(nameof(Password));
            }
        }


        private string _confirmPassword;
        public string ConfirmPassword
        {
            get { return _confirmPassword; }
            set
            {
                SetValue(ref _name, value);
                OnPropertyChanged(nameof(Name));
            }
    
}

        private string _age;
        public string Age
        {
            get { return _age; }
            set
            {
                SetValue(ref _age, value);
                OnPropertyChanged(nameof(Age));
            }

        }
        List<User> _contactList;
        public List<User> ContactList
        {
            get => _contactList;
            set
            {
                _contactList = value;
                OnPropertyChanged(nameof(ContactList));
            }
        }


    }
}
