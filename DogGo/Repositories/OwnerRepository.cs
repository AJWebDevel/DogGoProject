using DogGo.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;

namespace DogGo.Repositories
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly IConfiguration _config;

        // The constructor accepts an IConfiguration object as a parameter. This class comes from the ASP.NET framework and is useful for retrieving things out of the appsettings.json file like connection strings.
        public OwnerRepository(IConfiguration config)
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

        public List<Owner> GetAllOwners()
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                     SELECT Id, [Name], Email, Phone, Address, NeighborhoodId
                        FROM Owner
                       
                    ";

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<Owner> owners = new List<Owner>();
                        while (reader.Read())
                        {
                            Owner owner = new Owner
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                Address = reader.GetString(reader.GetOrdinal("Address")),
                                Phone = reader.GetString(reader.GetOrdinal("Phone")),
                                NeighborhoodId = reader.GetInt32(reader.GetOrdinal("NeighborhoodId")),
                                
                            };
                            
                              owners.Add(owner);
                                    
                        } 
                        return owners;
                            };

                            
                        }

                       
                    }
                }
        public Owner GetOwnerById(int id)
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"
                      SELECT  Owner.Id, Owner.Name AS OwnerName, Email, Address, 
                       Phone, NeighborhoodId, Dog.Name AS DogName, Dog.Id AS DogId, Dog.OwnerId AS DogOwnerId
                         from Owner
                         JOIN Dog On Dog.OwnerId = Owner.Id
                    WHERE OwnerId = @Id
                    ";

                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<Owner> ownersOfDogs= new List<Owner>();
                        if (reader.Read())
                        {
                            Owner existingOwner = ownersOfDogs.FirstOrDefault(o => o.Id == id);
                            if (existingOwner != null)
                            {
                                Owner owner = new Owner
                                {

                                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                    Name = reader.GetString(reader.GetOrdinal("Name")),
                                    Email = reader.GetString(reader.GetOrdinal("Email")),
                                    Address = reader.GetString(reader.GetOrdinal("Address")),
                                    Phone = reader.GetString(reader.GetOrdinal("Phone")),
                                    NeighborhoodId = reader.GetInt32(reader.GetOrdinal("NeighborhoodId")),
                                    Dogs = new List<Dog>()
                                };
                                ownersOfDogs.Add(owner);
                            }
                            if (reader.IsDBNull(reader.GetOrdinal("DogId")))
                            {
                                existingOwner.Dogs.Add(new Dog()
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("DogId")),
                                    OwnerId = reader.GetInt32(reader.GetOrdinal("DogOwnerId")),
                                    Name = reader.GetString(reader.GetOrdinal("DogName"))
                                });
                            }
                            return ownersOfDogs.FirstOrDefault();
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
    }
}


        