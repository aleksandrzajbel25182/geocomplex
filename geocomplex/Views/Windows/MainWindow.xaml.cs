using geocomplex.Service.Utils;
using geocomplex.ViewModels;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace geocomplex
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        //private static Npgsql.NpgsqlConnection getConnection()
        //{
        //    return new Npgsql.NpgsqlConnection(@"Server=localhost;Port=5432;User Id=postgres;Password=admin;Database=Geocomplex");
        //}


        //private string connstring = @"Server=localhost;Port=5432; User Id=postgres;Password=admin; Database=Geocomplex;";

        //private NpgsqlConnection connection;
      
        


        public MainWindow()
        {
            InitializeComponent();

           

        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    connection = new NpgsqlConnection(connstring);
        //    Source();
        //}
        //private void Source()
        //{

        //    //try
        //    //{
        //    //    #region Подлключение к БД

                
        //    //    connection.Open();
        //    //    string cmd = "SELECT * FROM test_table"; // Создаем запрос для вывода 
        //    //    NpgsqlCommand createCommand = new NpgsqlCommand(cmd, connection); // ложим запрос в команду и подключение к бд
        //    //    createCommand.ExecuteNonQuery();

        //    //    NpgsqlDataAdapter dataAdp = new NpgsqlDataAdapter(createCommand);
        //    //    DataTable dt = new DataTable("test_table"); // В скобках указываем название таблицы
        //    //    dataAdp.Fill(dt);
        //    //    Personal.ItemsSource = null;
        //    //    Personal.ItemsSource = dt.DefaultView; // Сам вывод 
        //    //    connection.Close();

        //    //    #endregion

        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    MessageBox.Show("Error: " + ex.Message);
        //    //    connection.Close();
        //    //}
                

        //}

        //private void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    //try
        //    //{
        //    //    connection.Open();
        //    //    string cmd = "INSERT INTO test_table(test_string, test_string2)values(@t1,@t2)";
        //    //    NpgsqlCommand createCommand = new NpgsqlCommand(cmd, connection);

        //    //    createCommand.Parameters.AddWithValue("@t1", text1.Text);
        //    //    createCommand.Parameters.AddWithValue("@t2", text2.Text);
        //    //    createCommand.ExecuteNonQuery();
        //    //    connection.Close();
        //    //}
        //    //catch (Exception ex)
        //    //{

        //    //    MessageBox.Show("Error: " + ex.Message);
        //    //    connection.Close();
        //    //}
           

        //}
    }
}
