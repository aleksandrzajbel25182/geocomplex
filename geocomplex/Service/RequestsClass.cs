using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace geocomplex
{
    class RequestsClass
    {
        private string connstring = @"Server=localhost;Port=5432; User Id=postgres;Password=admin; Database=Geocomplex;"; // Строка подключения

        private NpgsqlConnection connection;
        DataTable _datatable;
        

        public void Connection()
        {
            try
            {
                #region Подлключение к БД
                connection = new NpgsqlConnection(connstring);
                connection.Open();
              
                connection.Close();

                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                connection.Close();
            }

        }

        public DataTable SELECT(string _table)
        {
            string table = _table;

            string cmd = $"SELECT * FROM {table}"; // Создаем запрос для вывода 
            NpgsqlCommand createCommand = new NpgsqlCommand(cmd, connection); // ложим запрос в команду и подключение к бд
            createCommand.ExecuteNonQuery();

            NpgsqlDataAdapter dataAdp = new NpgsqlDataAdapter(createCommand);
            DataTable _datatable = new DataTable(_table); // В скобках указываем название таблицы

            dataAdp.Fill(_datatable);
            return _datatable;
        }

        public void INSERT()
        {

            try
            {
                connection.Open();
                string cmd = "INSERT INTO test_table(test_string, test_string2)values(@t1,@t2)";
                NpgsqlCommand createCommand = new NpgsqlCommand(cmd, connection);

                //createCommand.Parameters.AddWithValue("@t1", text1.Text);
                //createCommand.Parameters.AddWithValue("@t2", text2.Text);
                createCommand.ExecuteNonQuery();
                connection.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
                connection.Close();
            }
        }
          
           

    }
}
