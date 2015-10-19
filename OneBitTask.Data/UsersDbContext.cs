namespace OneBitTask.Data
{
    using System;
    using System.Data.Entity;

    using Models;
    using Migrations;

    public class UsersDbContext : DbContext, IUsersDbContext
    {
        public UsersDbContext()
            : base("UsersDatabase")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<UsersDbContext, Configuration>());
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
