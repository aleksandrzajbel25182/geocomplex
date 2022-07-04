using geocomplex.ViewModels.Base;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geocomplex.ViewModels
{
    internal class RegistrationWindowViewModel:ViewModel
    {







        private string connstring = @"Server=localhost;Port=5432; User Id=postgres;Password=admin; Database=Geocomplex;";

        private NpgsqlConnection connection;


            #region Подлключение к БД

            //connection = new NpgsqlConnection(connstring);
            //connection.Open();
            

            #endregion

               // ищем в базе данных пользователя с такими данными     

                    //string cmd = $"SELECT * FROM user_data WHERE user_login='{TextBoxLogin.Text}'"; // Создаем запрос для вывода 
                    //NpgsqlCommand createCommand = new NpgsqlCommand(cmd, connection); // ложим запрос в команду и подключение к бд
                    //createCommand.ExecuteNonQuery();

                    //NpgsqlDataAdapter dataAdp = new NpgsqlDataAdapter(createCommand);
                    //DataTable dt = new DataTable("user_data"); // В скобках указываем название таблицы
                    //dataAdp.Fill(dt);
                    //if (dt.Rows.Count > 0) // если такая запись существует       
                    //{
                    //    MainWindow main = new MainWindow();
                    //    main.Show();
                    //    connection.Close();
                    //}



        }
}
