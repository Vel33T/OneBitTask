namespace OneBitTask.Data.Repositories
{
    using System.Linq;
    using Models;

    public class UsersRepository : GenericRepository<User>
    {
        public UsersRepository()
            : base()
        {
        }

        public override IQueryable<User> All()
        {
            return base.All().Where(user => user.Status != StatusType.Deleted);
        }

        public override void Delete(User user)
        {
            user.Status = StatusType.Deleted;
            base.Update(user);
        }

        public override void Delete(object id)
        {
            var user = base.GetById(id);
            this.Delete(user);
        }
    }
}
