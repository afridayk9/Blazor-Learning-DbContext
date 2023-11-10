using TableModels;

namespace Project4_Fall23.Services
{
    public class LeadsService : GenericCrudService<Leads>
    {
        public LeadsService(ApplicationDbContext options) : base(options) { }
    }
}
