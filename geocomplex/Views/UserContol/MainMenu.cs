﻿using geocomplex.Service.Utils;
using geocomplex.ViewModels.ViewModelUserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace geocomplex.Views.UserContol
{
    class MainMenu :ModuleBase
    {
        public override string Name
        {
            get { return "MainMenu"; }
        }

        protected override UserControl CreateViewAndViewModel()
        {
            return new MainMenuView() { DataContext = new MainMenuViewModel() };
        }
    }
}