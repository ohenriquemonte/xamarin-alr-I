﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AluraXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            listViewVeiculos.ItemsSource = new string[]
            {
                "Azera V6",
                "Fiesta 2.0",
                "HB20 S",
            };
        }
    }
}
