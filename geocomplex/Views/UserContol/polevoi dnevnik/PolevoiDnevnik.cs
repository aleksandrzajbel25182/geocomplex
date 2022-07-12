using geocomplex.Service.Utils;
using geocomplex.ViewModels.ViewModelUserControls;
using System.Windows.Controls;

namespace geocomplex.Views.UserContol.polevoi_dnevnik
{
    class PolevoiDnevnik: ModuleBase
    {
      

        public override string Name => "Полевой дневник";

        public override string ImagePath => "/Icons/Полевой-дневник.ico";

        protected override UserControl CreateViewAndViewModel()
        {
            return new PolevoiDnevnikView() { DataContext = new PolevoiDnevnikViewModel() };
        }




    }
}
