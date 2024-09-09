using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Data.SqlClient;
using System.ComponentModel.Design;

class Program
{
    private static string connectionString;
    private static SqlConnection connection;

    static void Main(string[] args)
    {
        // Load configuration from appsettings.json
        var configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

        connectionString = configuration.GetConnectionString("dados");

        Console.WriteLine("MENU");
        Console.WriteLine("1-Inserir Tarefas");
        Console.WriteLine("2-Ler");
        Console.WriteLine("3-Alterar");
        Console.WriteLine("4-Remover");
        Console.WriteLine("5-Sair");

        var opcao = Console.ReadLine();

        while (opcao != "5")
        {
            if (opcao == "1")
            {
                InserirTex();
            }
            if (opcao == "2")
            {
                LerTex();
            }
            if (opcao == "3")
            {
                AtualizarTex();
            }
            if (opcao == "4")
            {
                RemoverTex();
            }



        }
    
    
    } 
        
    static void InserirTex()
    {
        Console.Write("Digite a tarefa: ");
        var tarefa = Console.ReadLine();
        Console.WriteLine("Digite a data da tarefa (yyyy-mm-dd): ");
        var data = Console.ReadLine();
        Console.WriteLine("Digite como fazer");
        var comoFazer = Console.ReadLine();
        // Connect to MySQL database and insert data
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            var query = "INSERT INTO cad_tarefas(tarefa, data_tarefa,comoFazer) VALUES (@tarefa, @data,@comoFazer)";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@tarefa", tarefa);
                command.Parameters.AddWithValue("@data", data);
                command.Parameters.AddWithValue("@comoFazer", comoFazer);
                command.ExecuteNonQuery();
            }
        }
    }
    static void LerTex()
    {
        Console.Write("Digite o id: ");
        var id = Console.ReadLine();
        
        Console.WriteLine("Digite como fazer");
        var comoFazer = Console.ReadLine();
        // Connect to MySQL database and insert data
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            var query = "INSERT INTO cad_tarefas(tarefa, data_tarefa,comoFazer) VALUES (@tarefa, @data,@comoFazer)";
            using (var command = new MySqlCommand(query, connection))
            
        }
    }
    static void AtualizarTex()
    {
        Console.Write("Digite o id: ");
        var id = Console.ReadLine();
        Console.WriteLine("Digite a data da tarefa (yyyy-mm-dd): ");
        var data = Console.ReadLine();
        Console.WriteLine("Digite como fazer");
        var comoFazer = Console.ReadLine();
        // Connect to MySQL database and insert data
        using (var connection = new MySqlConnection(connectionString))
        {
            connection.Open();
            var query = "INSERT INTO cad_tarefas(tarefa, data_tarefa,comoFazer) VALUES (@tarefa, @data,@comoFazer)";
            using (var command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@tarefa", tarefa);
                command.Parameters.AddWithValue("@data", data);
                command.Parameters.AddWithValue("@comoFazer", comoFazer);
                command.ExecuteNonQuery();
            }
        }
        static void AtualizarTex()
        {
            Console.Write("Digite o id: ");
            var id = Console.ReadLine();
            Console.WriteLine("Digite a data da tarefa (yyyy-mm-dd): ");
            var data = Console.ReadLine();
            Console.WriteLine("Digite como fazer");
            var comoFazer = Console.ReadLine();
            // Connect to MySQL database and insert data
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                var query = "INSERT INTO cad_tarefas(tarefa, data_tarefa,comoFazer) VALUES (@tarefa, @data,@comoFazer)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tarefa", tarefa);
                    command.Parameters.AddWithValue("@data", data);
                    command.Parameters.AddWithValue("@comoFazer", comoFazer);
                    command.ExecuteNonQuery();
                }
            }

        }
