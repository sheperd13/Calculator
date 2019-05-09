﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calculator
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculatorView : ContentPage
    {
        public CalculatorView()
        {
            InitializeComponent();
            BindingContext = new CalculatorViewModel();
        }
    }
}