using TableModels;

namespace Project4_Fall23.Services
{
    public class MarketService : GenericCrudService<Market>
    {
        public MarketService(ApplicationDbContext context) : base(context) { }
    }
}
