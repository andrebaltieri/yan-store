using YanStore.Domain.Application.Commands;
using YanStore.Domain.Model;
using YanStore.Domain.Model.Event;
using YanStore.Domain.Model.Repository;
using YanStore.Domain.Model.Scopes;
using YanStore.SharedKernel.Model;

namespace YanStore.Domain.Application
{
    public class UserApplicationService : IUserApplicationService
    {
        private IUserRepository _repository;

        public UserApplicationService(IUserRepository repository)
        {
            this._repository = repository;
        }

        public User Register(RegisterUserCommand command)
        {
            var user = new User(command.UserName, command.Password);

            if (user.RegisterUserScopeIsValid())
            {
                _repository.Register(user);
                DomainEvents.Raise(new UserRegistered(user));
                return user;
            }

            return null;
        }

        public bool Authenticate(string username, string password)
        {
            _repository.Authenticate(username, password);
            return true;
        }
    }
}
