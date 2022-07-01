using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace geocomplex
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {

        private string connstring = @"Server=localhost;Port=5432; User Id=postgres;Password=admin; Database=Geocomplex;";

        private NpgsqlConnection connection;

        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            #region Подлключение к БД

            connection = new NpgsqlConnection(connstring);
            connection.Open();
                //string cmd = $@"SELECT * FROM user_data WHERE {Tex}"; // Создаем запрос для вывода 
                //NpgsqlCommand createCommand = new NpgsqlCommand(cmd, connection); // ложим запрос в команду и подключение к бд
                //createCommand.ExecuteNonQuery();

              
                //connection.Close();

                #endregion

                if (TextBoxLogin.Text.Length > 0) // проверяем введён ли логин     
                {
                    if (TextBoxPassword.Text.Length > 0) // проверяем введён ли пароль         
                    {             // ищем в базе данных пользователя с такими данными     

                        string cmd = $"SELECT * FROM user_data WHERE user_login='{TextBoxLogin.Text}'"; // Создаем запрос для вывода 
                        NpgsqlCommand createCommand = new NpgsqlCommand(cmd, connection); // ложим запрос в команду и подключение к бд
                        createCommand.ExecuteNonQuery();

                        NpgsqlDataAdapter dataAdp = new NpgsqlDataAdapter(createCommand);
                        DataTable dt = new DataTable("user_data"); // В скобках указываем название таблицы
                        dataAdp.Fill(dt);
                        if (dt.Rows.Count > 0) // если такая запись существует       
                        {
                        MainWindow main = new MainWindow();
                        main.Show();
                            connection.Close();
                        }
                        else MessageBox.Show("Пользователя не найден"); // выводим ошибку  
                    }
                    else MessageBox.Show("Введите пароль"); // выводим ошибку    
                }
                else MessageBox.Show("Введите логин"); // выводим ошибку 


            
            

        }

    }
}
