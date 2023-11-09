using Project4_Fall23.Interfaces;

namespace Project4_Fall23.Services
{
    /// <summary>
    /// A generic service that inherits from the generic interface
    /// </summary>
    /// <typeparam name="T">The class/data model we are manipulating</typeparam>
    public class GenericCrudService<T> : IGenericCrud<T> where T : class
    {
        //creates an instance of the DbContext
        readonly ApplicationDbContext context;
        /// <summary>
        /// sets the name of the generic to entities and retrieves the instance of the DbContext
        /// </summary>
        protected IQueryable<T> Entities { get => context.Set<T>(); }

        /// <summary>
        /// a constructor that sets the db context when its instantiated
        /// </summary>
        /// <param name="context">the instance of the db context we are pulling in</param>
        public GenericCrudService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public ApplicationDbContext GetContext()
        {
            return context;
        }

        public bool Add(T entity)
        {
            try
            {
                context.Set<T>().Add(entity);
                return context.SaveChanges() != 0;
            }
            catch { return false; }
        }

        public bool Delete(T entity)
        {
            try
            {
                context.Set<T>().Remove(entity);
                return context.SaveChanges() != 0;
            }
            catch { return false; }
        }

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public bool Update(T entity)
        {
            try
            {
                context.Set<T>().Update(entity);
                return context.SaveChanges() != 0;
            }
            catch { return false; }
        }
    }
}
