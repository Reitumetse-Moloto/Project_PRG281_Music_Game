using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_PRG281_Music_Game
{
    public class User
    {
        private string username;
        private string password;
        public static List<User> use = new List<User>();
       
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public User()
        {

        }

        public List<User> GetUser()
        {
            use.Add(new User("Karam-Goat", "1738"));
            use.Add(new User("DobbyLongNose", "2456"));
            use.Add(new User("Reitumetse", "12345"));

            return use;
        }

        public static void Adduser(User user)
        {
            use.Add(user);
        }
    }
}
