using TableModels;

namespace Project4_Fall23.Services
{
    public class PointOfContactService : GenericCrudService<PointOfContact>
    {
        public PointOfContactService(ApplicationDbContext options) : base(options) { }
    }
}
