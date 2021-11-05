﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SigmaApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabelasPage : ContentPage
    {
        public TabelasPage()
        {
            InitializeComponent();
        }

        private async void btnTab1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tabela1());
        }

        private async void btnTab2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tabela2());

        }

        private async void btnTab3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tabela3());

        }

        private async void btnTab4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Tabela4());

        }
    }
}