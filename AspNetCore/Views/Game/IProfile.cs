namespace AspNetCore.Views.Game
{
    public interface IProfile
    {
        bool ValidatePassword(string login, string password);
    }
}
