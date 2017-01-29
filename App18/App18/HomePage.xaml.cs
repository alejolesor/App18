using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App18
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void BtnSave_Clicked(object sender, EventArgs e)
        {
            var nombre = boxNombre.Text;
            if (!string.IsNullOrEmpty(nombre))
            {
                var user = new UserModel { Name = nombre };
                //DisplayAlert("Xamarin Forms", nombre, "Aceptar");
                Intent intent = new Intent(this, new UserPage());
                intent.PutObject("user", user);
                intent.PutString("xD", "Lol");
                intent.StartIntent();
                //this.Navigation.PushModalAsync(new UserPage(user)); 
            }

        }
    }
}
