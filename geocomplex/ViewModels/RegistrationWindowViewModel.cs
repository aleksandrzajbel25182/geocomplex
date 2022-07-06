using geocomplex.Infrastructure.Commands;
using geocomplex.Service.Utils;
using geocomplex.ViewModels.Base;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace geocomplex.ViewModels
{
    internal class RegistrationWindowViewModel:ViewModel
    {
        private string connstring = @"Server=localhost;Port=5432; User Id=postgres;Password=admin; Database=Geocomplex;"; // Строка подключения
        private NpgsqlConnection connection;

        #region Логин
        /// <summary>
        /// Логин пользователя
        /// </summary>
        private string login;

        public string Login { get => login; set => Set(ref login, value);}
        #endregion

        #region Пароль
        /// <summary>
        /// Пароль пользователя
        /// </summary>
        private string password;

        public string Password { get => password; set => Set(ref password, value);}
        #endregion




        /*-------------------------------------------------------------------------------------------------------------------------------------------*/




        #region Команды


        #region Команда Подключения и проверки логина с паролем пользователя
        /// <summary>
        ///  Команда Подключения и проверки логина с паролем пользователя
        /// </summary>
        public ICommand ConnectionCommand { get; } // Сама команда

        private bool CanConnectionCommandExecute(object p) => true;

        // Действия которые должна выполнить команда
        private void OnConnectionCommandExcuted(object p)
        {
            connection = new NpgsqlConnection(connstring);
            connection.Open();
            string cmd = $"SELECT * FROM user_data WHERE user_login='{login}' AND user_password ='{password}'"; // Создаем запрос для вывода 
            NpgsqlCommand createCommand = new NpgsqlCommand(cmd, connection); // ложим запрос в команду и подключение к бд
            createCommand.ExecuteNonQuery();

            NpgsqlDataAdapter dataAdp = new NpgsqlDataAdapter(createCommand);
            DataTable dt = new DataTable("user_data"); // В скобках указываем название таблицы
            dataAdp.Fill(dt);
           
           
            if (dt.Rows.Count > 0) // если такая запись существует       
            {
                connection.Close();
                              
               var mainWindow = new MainWindow();

               var modules = ReflectionHelper.CreateAllInstancesOf<IModule>();

               var vm = new MainWindowViewModel(modules);
               mainWindow.DataContext = vm;
               mainWindow.Closing += (s, args) => vm.SelectedModule.Deactivate();
               mainWindow.Show();

            }
        }

        #endregion


        #endregion

        

        /*-------------------------------------------------------------------------------------------------------------------------------------------*/
        public RegistrationWindowViewModel()
        {
            ConnectionCommand = new LamdaCommand(OnConnectionCommandExcuted, CanConnectionCommandExecute);

        }



    }
}
