using Domain.Interfaces;

namespace Domain.Models
{
    public abstract class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public User(int id, string name, string usereName)
        {
            Id = id;
            Name = name;
            UserName = usereName;
        }

        public abstract void PrintUser();
        
    }
}
