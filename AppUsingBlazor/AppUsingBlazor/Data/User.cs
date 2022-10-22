using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AppUsingBlazor.Data
{
    public class User
    {
        [BsonIgnoreIfDefault]
        public ObjectId _id;
        [BsonIgnoreIfNull]
        public string? Name { get; set; }
        [BsonIgnoreIfNull]
        public string? Email { get; set; }
        [BsonIgnoreIfNull]
        public string? Surname { get; set; }
        [BsonIgnoreIfNull]
        public string Login { get; set; }
        [BsonIgnoreIfNull]
        public string Password { get; set; }
        public string RepPassword { get; set; }

        public User() { }

        public User(string name, string surname, string email, string login, string password)
        {
            Name = name;
            Email = email;
            Login = login;
            Password = password;
            Surname = surname;
        }
    }
}
