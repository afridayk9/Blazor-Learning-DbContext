using TableModels;

namespace Project4_Fall23.Services
{
    /// <summary>
    /// a service that inherits its functionality from the Generic service
    /// where the generic service takes in the table model we wish to manipulate
    /// </summary>
    public class LeadsService : GenericCrudService<Leads>
    {
        public LeadsService(ApplicationDbContext options) : base(options) { }
    }
}
