// See https://aka.ms/new-console-template for more information
using System.Data.SqlClient;

string connectionstring = @"Data Source=DANPIER2022; Initial Catalog=TaskyApp;
                            User id=sa; Password=th16g0;";
string query = "SELECT * FROM Areas";

using (SqlConnection conection = new SqlConnection(connectionstring)){
    SqlCommand command = new SqlCommand(query,conection);
    try
    {
        conection.Open();
        SqlDataReader reader = command.ExecuteReader();
        while(reader.Read()){       /*reader[0] = Primera Columna ; reader[1] = Segunda Columna*/
            Console.WriteLine("{0} -- {1}",reader[0],reader[1]);
        }
        conection.Close();
    }
    catch (Exception error)
    {
        Console.WriteLine(error.Message);
    }
}