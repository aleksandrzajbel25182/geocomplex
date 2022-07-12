using geocomplex.ViewModels.Base;
using geocomplex.Views.UserContol.polevoi_dnevnik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace geocomplex.ViewModels.ViewModelUserControls
{
    class PolevoiDnevnikViewModel:ViewModel

    {
       
        private string _lab;

        public string Lab { get => _lab; set => Set(ref _lab, value); }

        public PolevoiDnevnikViewModel()
        {
            _lab = "ЗДЕСЬ БУДЕТ ПОЛЕВОЙ ДНЕВНИК!";
        }



    }
}
