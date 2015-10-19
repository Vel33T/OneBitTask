namespace OneBitTask.Data
{
    using Models;
    using System.Data.Entity;
    using System;

    public class UsersDbContext : DbContext, IUsersDbContext
    {
        public UsersDbContext()
            : base("UsersDatabase")
        {

        }

        public virtual IDbSet<User> Users { get; set; }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            throw new NotImplementedException();
        }
    }
}
