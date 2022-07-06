using geocomplex.Service.Utils;
using geocomplex.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace geocomplex.ViewModels
{
    internal class MainWindowViewModel:ViewModel

    {
        /// <summary>
        /// Список всех возможных загрузчиков пар View и ViewModel
        /// </summary>
        public List<IModule> Modules { get; private set; }

        /// <summary>
        /// Выбранная и загруженная парочка View и ViewModel
        /// </summary>
        private IModule _SelectedModule;
        public IModule SelectedModule
        {
            get { return _SelectedModule; }
            set
            {
                if (value == _SelectedModule) return;
                if (_SelectedModule != null) _SelectedModule.Deactivate();
                _SelectedModule = value;
                OnPropertyChanged();
                OnPropertyChanged("UserInterface");
            }
        }

        /// <summary>
        /// То, что отображает View через ContentPresenter 
        /// </summary>
        public UserControl UserInterface
        {
            get
            {
                if (SelectedModule == null) return null;
                return SelectedModule.UserInterface;
            }
        }

        /*----------------------------------------------------------------------------------*/
        /// <summary>
        /// Конструктор  MainWindowViewModel
        /// </summary>
        public MainWindowViewModel(IEnumerable<IModule> modules)
        {
            Modules = modules.OrderBy(m => m.Name).ToList();
            if (this.Modules.Count > 0)
            {
                SelectedModule = this.Modules[0];
            }
        }



    }
}
