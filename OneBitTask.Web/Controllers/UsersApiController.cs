namespace OneBitTask.Web.Controllers
{
    using System;
    using System.Web.Http;

    using Data.Repositories;
    using Models;

    public class UsersApiController : ApiController
    {
        private UsersRepository data = new UsersRepository();

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

            return Ok(user.Status);
        }

        [HttpDelete]
        public IHttpActionResult Delete(string id)
        {
            var idAsGuid = new Guid(id);
            this.data.Delete(idAsGuid);
            this.data.SaveChanges();

            return Ok();
        }
    }
}
