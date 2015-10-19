namespace OneBitTask.Data.Repositories
{
    using System.Linq;
    using System.Data.Entity;

    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private IUsersDbContext context;
        private IDbSet<T> set;

        //TODO: Remove and use Ninject/StructureMap
        //Poor man's DI
        public GenericRepository()
            : this(new UsersDbContext())
        {
        }

        public GenericRepository(IUsersDbContext context)
        {
            this.context = context;
            this.set = context.Set<T>();
        }

        public virtual IQueryable<T> All()
        {
            return this.set;
        }

        public virtual T GetById(object id)
        {
            return this.set.Find(id);
        }

        public virtual void Add(T entity)
        {
            this.ChangeEntityState(entity, EntityState.Added);
        }

        public virtual void Update(T entity)
        {
            this.ChangeEntityState(entity, EntityState.Modified);
        }

        public virtual void Delete(T entity)
        {
            this.ChangeEntityState(entity, EntityState.Deleted);
        }

        public virtual void Delete(object id)
        {
            var entity = this.GetById(id);
            this.Delete(entity);
        }

        public virtual void Detach(T entity)
        {
            this.ChangeEntityState(entity, EntityState.Detached);
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }

        private void ChangeEntityState(T entity, EntityState state)
        {
            var entry = this.context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.set.Attach(entity);
            }

            entry.State = state;
        }
    }
}
