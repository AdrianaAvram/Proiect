using Proiect.Services;
using Proiect.View;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proiect
{
    
    public partial class App : Application
    {
        static ContactUser database;
        public static ContactUser Database
        {
            get
            {
                if (database == null)
                {
                    database = new ContactUser(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Proiect.db3"));
                }
                return database;

            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
