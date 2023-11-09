using TableModels;

namespace Project4_Fall23.Services
{
    public class StoreService : GenericCrudService<Store>
    {
        public StoreService(ApplicationDbContext options) : base(options) { }
    }
}
