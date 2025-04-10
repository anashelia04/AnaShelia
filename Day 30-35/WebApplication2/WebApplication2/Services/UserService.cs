using System.Text.Json;
using WebApplication2.Model;

namespace WebApplication2.Services
{
    public class UserService
    {
        private const string FilePath = "users.json";
        public List<User> Users { get; private set; }

        public UserService()
        {
            Users = LoadUsers();
        }

        private List<User> LoadUsers()
        {
            if (!File.Exists(FilePath)) return new List<User>();
            var json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
        }

        private void SaveUsers()
        {
            var json = JsonSerializer.Serialize(Users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }

        public void AddUser(User user)
        {
            user.Id = Users.Any() ? Users.Max(u => u.Id) + 1 : 1;
            Users.Add(user);
            SaveUsers();
        }

        public User? GetUser(int id) => Users.FirstOrDefault(u => u.Id == id);

        public List<User> GetAllUsers() => Users;

        public void UpdateUser(int id, User updatedUser)
        {
            var user = Users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                user.FirstName = updatedUser.FirstName;
                user.LastName = updatedUser.LastName;
                user.Email = updatedUser.Email;
                user.Age = updatedUser.Age;
                SaveUsers();
            }
        }

        public bool DeleteUser(int id)
        {
            var user = Users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                Users.Remove(user);
                SaveUsers();
                return true;
            }
            return false;
        }
    }
}
