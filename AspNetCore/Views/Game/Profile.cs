namespace AspNetCore.Views.Game
{
    public class Profile : IProfile
    {
        Dictionary<string, string> _profiles = new Dictionary<string, string>
        {
            { "Admin", "Admin"},
            { "User", "User"},
            { "Moder", "Moder"}
        };

        public bool ValidatePassword(string login, string password)
        {
            return _profiles.TryGetValue(login, out var storedPassword) && storedPassword == password;
        }
    }
}
