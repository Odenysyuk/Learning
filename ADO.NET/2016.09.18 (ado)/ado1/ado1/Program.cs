using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ado1
{
    class Program
    {
        static void Main(string[] args)
        {

            string connectionString = @"Data Source=localhost;Initial Catalog=Itstep;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                connection.Close();
            }


            if (connection.State == System.Data.ConnectionState.Closed)
            {
                Console.WriteLine("Conection {0} is closed", connectionString);
                return;
            }


            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            string choise;
            choise = Console.ReadLine();
            switch (choise)
            {
                case "1": CreateTableWorker(connection); break;
                case "2": AddWorker(connection, new Worker("Smith", "Tom", 25, "self emploe", 2500)); break;
                case "3": RemoveWorker(connection, new Worker("Smith", "Tom", 25, "self emploe", 2500)); break;
                case "4": ShowSalaryWorkers(connection); break;
                default: Console.WriteLine("Uncorrect choise!!!"); break;
            }

            if (connection.State != System.Data.ConnectionState.Closed)
                connection.Close();

            Console.ReadLine();
        }

        //створити таблицю Worker
        static bool CreateTableWorker(SqlConnection connection)
        {
            if (connection.State != System.Data.ConnectionState.Open)
                return false;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            //прізвище, ім’я, кількість років, посада, заробітня плата
            command.CommandText = "CREATE TABLE worker(id INT NOT NULL PRIMARY KEY IDENTITY(1,1), surname CHAR(50), name CHAR(50), age INT, posada CHAR(10), salary INT);";
            try
            {
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("Invalid cast exception. {0}", ex.Message);
                return false;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Invalid operation exception. {0}", ex.Message);
                return false;
            }

            return true;
        }

        // ●	Можливість додати працівника в базу даних(в базі зберігається прізвище, ім’я, кількість років, посада, заробітня плата);
        static bool AddWorker(SqlConnection connection, Worker worker)
        {
            if (connection.State != System.Data.ConnectionState.Open)
                return false;
            SqlTransaction tran = connection.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.Transaction = tran;

            //прізвище, ім’я, кількість років, посада, заробітня плата
            command.CommandText = "INSERT INTO worker (surname, name, age, posada, salary) VALUES ("+ worker + ");";
            try
            {
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                tran.Rollback();
                return false;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("Invalid cast exception. {0}", ex.Message);
                tran.Rollback();
                return false;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Invalid operation exception. {0}", ex.Message);
                tran.Rollback();
                return false;
            }
            tran.Commit();
            return true;
        }

        //●	Можливість видалити працівника з бази по імені;
        static bool RemoveWorker(SqlConnection connection, Worker worker) {
            if (connection.State != System.Data.ConnectionState.Open)
                return false;

            SqlTransaction tran = connection.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.Transaction = tran;

            //прізвище, ім’я, кількість років, посада, заробітня плата
            command.CommandText = @"DELETE FROM worker WHERE "+ worker.FindWorkerOnSQL() + " ;";

            try
            {
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                tran.Rollback();
                return false;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("Invalid cast exception. {0}", ex.Message);
                tran.Rollback();
                return false;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Invalid operation exception. {0}", ex.Message);
                tran.Rollback();
                return false;
            }

            
            tran.Commit();
            return true;
        }

        //●	Можливість отримання інформації по всіх працівниках;
        static bool ShowWorkers(SqlConnection connection) {
            if (connection.State != System.Data.ConnectionState.Open)
                return false;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;

            //прізвище, ім’я, кількість років, посада, заробітня плата
            command.CommandText = @"SELECT * FROM worker;";

            SqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("Invalid cast exception. {0}", ex.Message);
                return false;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Invalid operation exception. {0}", ex.Message);
                return false;
            }


            for (int i = 0; i < reader.FieldCount; ++i)
            {
                Console.Write(reader.GetName(i) + "\t");
            }
            Console.WriteLine();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; ++i)
                {
                    Console.Write(reader[i] + "\t");
                }
                Console.WriteLine();
            }
            reader.Close();

            return true;
        }

        //●	Можливість отримання інформації по іменах, заробітніх плататах та загальній сумі заробітньої плати всіх працівників.
        static bool ShowSalaryWorkers(SqlConnection connection) {
            if (connection.State != System.Data.ConnectionState.Open)
                return false;

            SqlCommand command = new SqlCommand();
            command.Connection = connection;


            command.CommandText = @"SELECT name, salary FROM worker UNION SELECT 'Total', SUM(salary) FROM worker;";

            SqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("Invalid cast exception. {0}", ex.Message);
                return false;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Invalid operation exception. {0}", ex.Message);
                return false;
            }


            for (int i = 0; i < reader.FieldCount; ++i)
            {
                Console.Write(reader.GetName(i) + "\t");
            }
            Console.WriteLine();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; ++i)
                {
                    Console.Write(reader[i] + "\t");
                }
                Console.WriteLine();
            }
            reader.Close();

            return true;
        }

    }
}

class Worker
{

    string name { get; set; }
    string surname { get; set; }
    int age { get; set; }
    string posada { get; set; }
    int salary { get; set; }
    public Worker(string name, string surname, int age, string posada, int salary)
    {
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.posada = posada;
        this.salary = salary;
    }
    public override string ToString()
    {
        return  String.Format("'{0}', '{1}', {2}, '{3}', {4}", surname, name, age, posada, salary);
    }

    public string FindWorkerOnSQL()
    {
        return String.Format("surname = '{0}' AND name = '{1}' AND age ={2} AND posada = '{3}' AND salary = {4}", surname, name, age, posada, salary);
    }




}
