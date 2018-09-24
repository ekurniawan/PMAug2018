﻿using SampleMobileApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleMobileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SampleListTextPage : ContentPage
    {
        public SampleListTextPage()
        {
            InitializeComponent();
            this.BindingContext = new ViewModelBerita();
        }
    }
}