using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ToDoLearning.Domain.Commands.TaskCommands;
using ToDoLearning.Domain.Services;

namespace ToDoLearning.Api.Controllers
{
    public class TaskController : BaseController
    {
        private ITaskApplicationService _service;

        public TaskController(ITaskApplicationService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("api/task")]
        public Task<HttpResponseMessage> GetById(Guid id)
        {
            var task = _service.GetById(id);
            return CreateResponse(HttpStatusCode.OK, task);
        }

        [HttpPost]
        [Route("api/task")]
        public Task<HttpResponseMessage> Insert([FromBody]dynamic body)
        {
            var command = new CreateTaskCommand(
                (Guid)body.userId,
                (string)body.title
                );

            var task = _service.Create(command);

            return CreateResponse(HttpStatusCode.OK, task);
        }

        [HttpPut]
        [Route("api/task/{id}")]
        public Task<HttpResponseMessage> Update(Guid id, [FromBody]dynamic title)
        {
            var command = new UpdateTaskCommand(id, title);
            var task = _service.Update(command);
            return CreateResponse(HttpStatusCode.OK, task);
        }

        [HttpDelete]
        [Route("api/task/{id}")]
        public Task<HttpResponseMessage> Delete([FromBody]dynamic body)
        {
            var command = new DeleteTaskCommand((Guid)body.id);
            var task = _service.Delete(command);
            return CreateResponse(HttpStatusCode.OK, task);
        }
    }
}