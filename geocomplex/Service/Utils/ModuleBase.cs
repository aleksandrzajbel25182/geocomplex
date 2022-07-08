﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace geocomplex.Service.Utils
{
    abstract class ModuleBase : IModule
    {
        private UserControl view;

        protected abstract UserControl CreateViewAndViewModel();

        public abstract string Name { get; }
        public abstract string ImagePath { get; }
        public UserControl UserInterface
        {
            get
            {
                if (view == null)
                {
                    view = CreateViewAndViewModel();
                }
                return view;
            }
        }

        public void Deactivate()
        {
            if (view != null)
            {
                var d = view.DataContext as IDisposable;
                if (d != null) d.Dispose();
                view = null;
            }
        }
    }
}
