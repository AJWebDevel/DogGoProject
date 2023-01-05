
using DogGo.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace DogGo.Repositories
{
    public class DogRepository : IDogRepository
    {
        private readonly IConfiguration _config;

        public DogRepository(IConfiguration config)
        {
            _config = config;
        }

       
        public SqlConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            }
        }

        //get all dogs in a list
        public List<Dog> GetAllDogs()
        {
            using(SqlConnection conn = Connection)
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT Id, [Name], OwnerId
                        FROM Dog";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<Dog> dogs = new List<Dog>();
                        while (reader.Read())
                        {
                            Dog dog = new Dog
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                OwnerId = reader.GetInt32(reader.GetOrdinal("OwnerId"))
                            };
                            dogs.Add(dog);
                        }
                        return dogs;
                    }
                }
            }
        }

        //get dog by Id
        public Dog GetDogById(int id)
        {
            using(SqlConnection conn = Connection)
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        SELECT Id, [Name], OwnerId
                        FROM Dog
                        WHERE Id = @id";

                    cmd.Parameters.AddWithValue("id", id);

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            Dog dog = new Dog()
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                OwnerId = reader.GetInt32(reader.GetOrdinal("OwnerId"))
                            };
                            return dog;
                        }
                        return null;
                    }
                }
            }
        }
        //create new dog
        public void AddDog(Dog dog)
        {
            using(SqlConnection conn = Connection) 
            { 
            conn.Open();
            using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @" 
                    INSERT INTO Dog ([Name], OwnerId)
                    OUTPUT INSERTED.ID
                    VALUES (@name, @ownerId);
                    ";

                    cmd.Parameters.AddWithValue("@ownerId", dog.OwnerId);
                    cmd.Parameters.AddWithValue("@name", dog.Name);
                    dog.Id = id;
                    int id = (int)cmd.ExecuteScalar();

                 
                }
            }
        }
        //edit dog
        public void UpdateDog (Dog dog)
        {
            using(SqlConnection conn = Connection)
            {
                conn.Open();
                using(SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        UPDATE Dog
                        SET
                            [Name] = @name,
                            OwnerId = @ownerId
                         WHERE Id = @id";

                    cmd.Parameters.AddWithValue("Id", dog.Id);
                    cmd.Parameters.AddWithValue("Name", dog.Name);
                    cmd.Parameters.AddWithValue("OwnerId", dog.OwnerId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        //delete dog
        public void DeleteDog(int id)
        { 
            using(SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                        DELETE FROM Dog
                        WHERE Id = @id";

                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
