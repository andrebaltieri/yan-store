﻿using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using YanStore.Domain.Application;
using YanStore.Domain.Application.Commands;
using YanStore.Domain.Model.Event;
using YanStore.SharedKernel.Model;
using YanStore.SharedKernel.Model.Event;

namespace YanStore.Api.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IUserApplicationService _service;
        private readonly IHandle<DomainNotification> _notification;

        public ValuesController(IUserApplicationService service)
        {
            this._service = service;
            this._notification = DomainEvents.Container.GetService<IHandle<DomainNotification>>();
        }

        [HttpPost]
        [Route("api/users")]
        public Task<HttpResponseMessage> Post([FromBody]dynamic body)
        {
            HttpResponseMessage response = new HttpResponseMessage();

            var command = new RegisterUserCommand(
                fullName: (string)body.fullName,
                username: (string)body.username,
                email: (string)body.email,
                password: (string)body.password,
                confirmpass: (string)body.confirmPass
            );

            _service.Register(command);
            _service.Authenticate("andrebaltieri", "123456");

            if (_notification.HasNotifications())
            {
                foreach (var item in _notification.Notify())
                    ModelState.AddModelError("", item.Value);

                response = Request.CreateResponse(HttpStatusCode.BadRequest, _notification.Notify());
            }
            else
            {
                response = Request.CreateResponse(HttpStatusCode.OK, command);
            }

            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(response);
            return tsc.Task;
        }
    }
}
