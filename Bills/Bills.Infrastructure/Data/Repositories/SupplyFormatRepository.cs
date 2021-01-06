using Bills.Domain.Entities;
using Bills.Domain.Interfaces.Data.Repository;
using System.Threading.Tasks;

namespace Bills.Infrastructure.Data.Repositories
{
    public class SupplyFormatRepository : ISupplyFormatRepository
    {
        public Task<SupplyFormat> RetrieveSupplyFormat(int supplyFormatId)
        {
            throw new System.NotImplementedException();
        }
    }
}
