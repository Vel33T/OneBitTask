namespace OneBitTask.Web.Controllers
{
    using System;
    using System.Web.Http;

    using Data.Repositories;
    using Models;

    public class UsersApiController : ApiController
    {
        private IRepository<User> data;

        public UsersApiController(IRepository<User> data)
        {
            this.data = data;
        }

        //TODO: Validation
        [HttpPut]
        public IHttpActionResult ChangeStatus(string id)
        {
            var idAsGuid = new Guid(id);
            var user = this.data.GetById(idAsGuid);
            if (user == null)
            {
                return BadRequest(String.Format("User with Id: {0} does not exist.", id));
            }

            if (user.Status == StatusType.Active)
            {
                user.Status = StatusType.Inactive;
            }
            else
            {
                user.Status = StatusType.Active;
            }

            this.data.Update(user);
            this.data.SaveChanges();

            return Ok(user.Status.ToString());
        }

        [HttpDelete]
        public IHttpActionResult DeleteUser(string id)
        {
            var idAsGuid = new Guid(id);

            this.data.Delete(idAsGuid);
            this.data.SaveChanges();

            return Ok();
        }
    }
}
