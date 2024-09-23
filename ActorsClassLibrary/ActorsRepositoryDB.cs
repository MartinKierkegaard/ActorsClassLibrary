using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ActorsClassLibrary
{
    public class ActorsRepositoryDB : IActorsRepository
    {
        string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ActorsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public Actor Add(Actor actor)
        {
            throw new NotImplementedException();
        }

        public Actor DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Actor> GetAll()
        {

            var list = new List<Actor>();

            string sql = "Select Id, BirtDate, Name from Actor";

            using (var databaseConnection = new SqlConnection(conn))
            {
                databaseConnection.Open();
                using (var selectCommand = new SqlCommand(sql, databaseConnection))
                {
                    using (var reader = selectCommand.ExecuteReader())
                    {

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                int birthYear = reader.GetInt32(1);
                                string name = reader.GetString(2);

                                list.Add(new Actor(name, id, birthYear));
                            }
                        }

                    }
                }
            }
            return list;
        }

       

        public Actor GetById(int id)
        {

            Actor actor = null;
            string sql = "Select Id, BirtDate, Name from Actor where id = @id";
            using (var databaseConnection = new SqlConnection(conn))
            {
                databaseConnection.Open();
                using (var selectCommand = new SqlCommand(sql, databaseConnection))
                {
                    selectCommand.Parameters.AddWithValue("Id", id);
                    using (var reader = selectCommand.ExecuteReader())
                    {

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int id_ = reader.GetInt32(0);
                                int birthYear = reader.GetInt32(1);
                                string name = reader.GetString(2);

                                actor = new Actor(name, id_, birthYear);
                            }

                        }

                    }
                }
            }
            return actor;
        }
    
    }
}
