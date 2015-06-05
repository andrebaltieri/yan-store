using System.Linq;
using YanStore.Domain.Model;
using YanStore.Domain.Model.Repository;
using YanStore.Domain.Model.Specs;
using YanStore.Infra.Context;

namespace YanStore.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private StoreDataContext _db;

        public UserRepository(StoreDataContext db)
        {
            this._db = db;
        }

        public void Register(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
        }

        public User Authenticate(string username, string password)
        {
            var query = UserSpecs.AuthenticateUser(username, password);
            query += UserSpecs.IsActive();

            var user = _db.Users.Where(query).FirstOrDefault();

            return user;
        }
    }
}
