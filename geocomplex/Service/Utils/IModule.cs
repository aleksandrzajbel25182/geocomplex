using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace geocomplex.Service.Utils
{
    interface IModule
    {
        /// <summary>
        /// Название выводимое в меню
        /// </summary>
        string Name { get; }
        /// <summary>
        /// Ссылка на вьюшку
        /// </summary>
        UserControl UserInterface { get; }
        /// <summary>
        /// Отключение текущей вьюшки, для вьюмоделей с реализацией IDisposable
        /// </summary>
        void Deactivate();
    }
}
