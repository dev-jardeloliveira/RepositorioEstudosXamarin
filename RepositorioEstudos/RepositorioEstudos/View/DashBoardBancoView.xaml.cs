﻿using RepositorioEstudos.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RepositorioEstudos.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashBoardBancoView : ContentView
    {
        public DashBoardBancoView()
        {
            InitializeComponent();
            this.BindingContext = new DashBoardBancoViewModel();
            
        }

        
    }
}