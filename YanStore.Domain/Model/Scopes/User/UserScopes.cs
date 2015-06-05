using YanStore.SharedKernel.Model;

namespace YanStore.Domain.Model.Scopes
{
    public static class UserScopes
    {
        public static bool RegisterUserScopeIsValid(this User user)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotEmpty(user.Username, "user name is required"),
                AssertionConcern.AssertNotEmpty(user.Password, "password is required")
            );
        }
    }
}
