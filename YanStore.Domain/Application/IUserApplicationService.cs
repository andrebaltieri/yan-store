using YanStore.Domain.Application.Commands;
using YanStore.Domain.Model;

namespace YanStore.Domain.Application
{
    public interface IUserApplicationService
    {
        User Register(RegisterUserCommand command);
    }
}
