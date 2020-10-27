using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HenryRojasexamen.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            Title = "Login";
        }

        void btniniciar_Clicked(System.Object sender, System.EventArgs e)
        {
            string user = txtuser.Text.Trim();
            string clave = txtclave.Text.Trim();

            if(user.Equals("") || user.Equals(""))
            {
                DisplayAlert("Alerta", "Complete todos los campos", "Ok");
            }
            else
            {
                if(user.Equals("estudiante2020") && clave.Equals("uisrael2020"))
                {
                    Navigation.PushAsync(new RegisterPage(user));
                    txtuser.Text = "";
                    txtclave.Text = "";
                }
                else
                {
                    DisplayAlert("Alerta", "Credenciales inválidas", "Ok");
                }
            }
        }
    }
}
