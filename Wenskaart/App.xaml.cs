﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Wenskaart
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Model.Wenskaart wenskaart = new Model.Wenskaart();
            ViewModel.WenskaartVM vm = new ViewModel.WenskaartVM(wenskaart);
            View.WenskaartWindowView wenskaartview = new View.WenskaartWindowView();
            wenskaartview.DataContext = vm;
            wenskaartview.Show();
        }
    }
}
