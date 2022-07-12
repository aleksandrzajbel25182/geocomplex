using geocomplex.Infrastructure.Commands;
using geocomplex.Service.Utils;
using geocomplex.ViewModels.Base;
using geocomplex.Views.UserContol.polevoi_dnevnik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace geocomplex.ViewModels.ViewModelUserControls
{
    class MainMenuViewModel:ViewModel
    {

       public MainMenuViewModel()
        {
            GoToPolevoiDnevnikCommand = new LamdaCommand(OnGoToPolevoiDnevnikCommandExcuted, CanGoToPolevoiDnevnikCommandExecute);
        }


        public ICommand GoToPolevoiDnevnikCommand { get; } // Сама команда

        private bool CanGoToPolevoiDnevnikCommandExecute(object p) => true;


        private void OnGoToPolevoiDnevnikCommandExcuted(object p)
        {

            Mediator.Notify("GoToPolevoiDnevnik", "");

        }
    }
}
