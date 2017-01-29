using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App18
{
    public partial class UserPage : ContentPage
    {
        //public UserModel _user { get; set; }

        public UserPage()
        {
            InitializeComponent();

            //BindingContext = User;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var intent = Intent.Navigation.Intent;
            var user = intent.GetObject<UserModel>("user");
            var Lol = intent.GetString("xD");
            DisplayAlert("Xamarin", Lol, "Aceptar", "Cancelar");
            BindingContext = user;
        }
    }
}
