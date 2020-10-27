using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HenryRojasexamen.Pages
{
    public partial class ResumePage : ContentPage
    {
        public ResumePage(string nombre, string useractual, double cuota)
        {
            InitializeComponent();
            txtuseractual.Text += useractual;

            double total = Convert.ToDouble(cuota) * 3;

            txtunombre.Text = nombre;
            txttotal.Text = "$ " + Math.Round(total,2);

            Title = "Resumen";
        }
    }
}
