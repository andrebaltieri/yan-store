namespace YanStore.Domain.Model.Repository
{
    public interface IUserRepository
    {
        void Register(User user);
        User Authenticate(string username, string password);
    }
}
