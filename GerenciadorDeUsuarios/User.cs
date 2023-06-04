using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GerenciadorDeUsuarios
{
    internal class User
    {
        //atributos
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string telephone { get; set; }
        public short age { get; set; }
        public DateTime dateOfBirth { get; set; }

        //metodos

        public User Get(int id)
        {
            User result = new User();
            DataBaseAccess dba = new DataBaseAccess();

            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = @"SELECT * FROM users " +
                                      @"WHERE id = @id;";

                    cmd.Parameters.AddWithValue("@id", id);

                    using (cmd.Connection = dba.OpenConnection())
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result.id = Convert.ToInt32(reader["id"]);
                            result.name = reader["name"].ToString();
                            result.email = reader["email"].ToString();
                            result.telephone = reader["telephone"].ToString();
                            result.age = Convert.ToInt16(reader["age"].ToString());
                            result.dateOfBirth = Convert.ToDateTime(reader["date_of_birth"].ToString());
                        }
                    }
                }


            }
            catch (Exception ex)
            { }

            return result;
        }
        public bool add(User user)
        {
            bool result = false;

            DataBaseAccess dba = new DataBaseAccess();
            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = @"INSERT INTO users " +
                                      @"(name, email, telephone, age, date_of_birth) " +
                                      @"VALUES " +
                                      @"(@name, @email, @telephone, @age, @date_of_birth); ";

                    cmd.Parameters.AddWithValue("@name", user.name);
                    cmd.Parameters.AddWithValue("@email", user.email);
                    cmd.Parameters.AddWithValue("@telephone", user.telephone);
                    cmd.Parameters.AddWithValue("@age", user.age);
                    cmd.Parameters.AddWithValue("@date_of_birth", user.dateOfBirth);

                    using (cmd.Connection = dba.OpenConnection())
                    {
                        cmd.ExecuteNonQuery();
                        result = true;

                    }
                }
            }
            catch (Exception Ex)
            {

            }

            return result;
        }

        public List<User> GetAll()
        {
            List<User> result = new List<User>();
            DataBaseAccess dba = new DataBaseAccess();

            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = @"SELECT * FROM users ORDER BY id;";

                    using (cmd.Connection = dba.OpenConnection())
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User();

                            user.id = Convert.ToInt32(reader["id"]);
                            user.name = reader["name"].ToString();
                            user.email = reader["email"].ToString();
                            user.telephone = reader["telephone"].ToString();
                            user.age = Convert.ToInt16(reader["age"].ToString());
                            user.dateOfBirth = Convert.ToDateTime(reader["date_of_birth"].ToString());
                            result.Add(user);
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
            return result;
        }

        public int Count()
        {
            int result = 0;
            DataBaseAccess dba = new DataBaseAccess();

            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = @"SELECT COUNT(id) FROM users;";

                    using (cmd.Connection = dba.OpenConnection())
                    {
                        result = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return result;
        }

        public bool Delete(int id)
        {
            bool result = false;
            DataBaseAccess dba = new DataBaseAccess();

            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = @"DELETE FROM users " +
                                      @"WHERE id = @id;";

                    cmd.Parameters.AddWithValue("@id", id);

                    using (cmd.Connection = dba.OpenConnection())
                    {
                        cmd.ExecuteNonQuery();
                        result = true;
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return result;
        }

        public int CountName()
        {
            int result = 0;
            DataBaseAccess dba = new DataBaseAccess();

            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = @"SELECT COUNT(name) FROM users;";

                    using (cmd.Connection = dba.OpenConnection())
                    {
                        result = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return result;
        }

        public bool Update(User user)
        {
            bool result = false;
            DataBaseAccess dba = new DataBaseAccess();

            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = @"UPDATE users " +
                                      @"SET name = @name, email = @email, telephone = @telephone, age = @age, date_of_birth = @dateOfBirth " +
                                      @"WHERE id = @id;";
                    cmd.Parameters.AddWithValue("@id", user.id);
                    cmd.Parameters.AddWithValue("@name", user.name);
                    cmd.Parameters.AddWithValue("@email", user.email);
                    cmd.Parameters.AddWithValue("@telephone", user.telephone);
                    cmd.Parameters.AddWithValue("@age", user.age);
                    cmd.Parameters.AddWithValue("@dateOfBirth", user.dateOfBirth);

                    using (cmd.Connection = dba.OpenConnection())
                    {
                        cmd.ExecuteNonQuery();
                        result = true;
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return result;
        }
    }
}
