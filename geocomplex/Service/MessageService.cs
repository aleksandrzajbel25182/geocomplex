using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace geocomplex.Service
{
    public static class MessageService
    {
        /// <summary>
        /// Сообщение пользователю
        /// </summary>
        /// <param name="message">текст сообщения</param>
        public static void ShowMessage(string message)
        {
            MessageBox.Show(message, "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
