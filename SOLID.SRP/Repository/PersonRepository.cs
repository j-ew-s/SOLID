using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace SOLID.SRP.Repository
{
    public class PersonRepository
    {
        public static void InsertPerson(Person person)
        {
            using (var connection = new SqlConnection())
            {
                var command = new SqlCommand();

                connection.ConnectionString = "";
                command.Connection = connection;

                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO PERSON (NAME, LASTNAME, BIRTH, EMAIL, PHONE) VALUES (@NAME, @LASTNAME, @BIRTH, @EMAIL, @PHONE))";

                command.Parameters.AddWithValue("NAME", person.Name);
                command.Parameters.AddWithValue("LASTNAME",person.LastName );
                command.Parameters.AddWithValue("BIRTH", person.Birth);
                command.Parameters.AddWithValue("EMAIL", person.Email);
                command.Parameters.AddWithValue("PHONE", person.Phone);


                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
