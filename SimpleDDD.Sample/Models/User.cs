using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleDDD.Sample.Models
{
    public class User
    {
        private static List<User> _db;

        static User()
        {
            _db = new List<User>();

            _db.Add(new User("admin", "123456"));
            _db.Add(new User("1", "1"));
            _db.Add(new User("2", "1"));
            _db.Add(new User("3", "1"));
            _db.Add(new User("4", "1"));
        }

        public static List<User> All()
        {
            return _db;
        }

        public User(string name, string password)
        {
            ID = Guid.NewGuid();
            Name = name;
            Password = password;
            CreateTime = DateTime.Now;
        }

        public Guid ID { get; private set; }
        public string Name { get; private set; }
        public string Password { get; private set; }
        public DateTime CreateTime { get; private set; }
    }
}