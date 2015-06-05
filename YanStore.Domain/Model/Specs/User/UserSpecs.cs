using System;

namespace YanStore.Domain.Model.Specs
{
    public static class UserSpecs
    {
        public static Func<User, bool> AuthenticateUser(string username, string password)
        {
            return x => x.Username.ToLower() == username.ToLower() && x.Password == password;
        }

        public static Func<User, bool> IsActive()
        {
            return x => x.IsActive;
        }
    }
}
