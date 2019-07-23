using System;
using System.Data;
using System.Linq;
using BCrypt.Net;
using triton.Models;
using Dapper;
using Npgsql;

namespace triton.Repositories
{
    public class UserRepository
    {
        NpgsqlConnection _db;

        public User Register(UserRegistration creds)
        {
            string id = Guid.NewGuid().ToString();
            string hash = BCrypt.Net.BCrypt.HashPassword(creds.Password);
            int success = _db.Execute(@"
            INSERT INTO users (id, username, email, hash)
            VALUES (@id, @username, @email, @hash);
            ", new 
                {
                    id,
                    username = creds.Username,
                    email = creds.Email,
                    hash
                });
            
            if (success != 1) { return null; }

            return new User()
            {
                Username = creds.Username,
                Email = creds.Email,
                Hash = null,
                Id = id
            };
        }

        public User Login(UserLogin creds)
        {
            User user = _db.Query<User>(@"
                SELECT * FROM users WHERE email = @Email
                ", creds).FirstOrDefault();
            if (user == null) { return null; }
            bool validPass = BCrypt.Net.BCrypt.Verify(creds.Password, user.Hash);
            if (!validPass) { return null; }
            user.Hash = null;
            return user;
        }  

        internal User GetUserById(string id)
        {
            var user = _db.Query<User>(@"
                SELECT * FROM users WHERE id = @id
                ", new { id }).FirstOrDefault();
                if (user != null) { user.Hash = null; }
                return user;
        }

        public UserRepository(NpgsqlConnection db) {_db = db;}
    }
}