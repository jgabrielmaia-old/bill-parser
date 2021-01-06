using Bills.Domain.Entities;
using Bills.Domain.Interfaces.Data.Repository;
using System.Threading.Tasks;

namespace Bills.Infrastructure.Data.Repositories
{
    /// <summary>
    /// Retrieves sypply format as documents from MongoDB
    /// </summary>
    public class SupplyFormatRepository : ISupplyFormatRepository
    {
        public Task<SupplyFormat> RetrieveSupplyFormat(int supplyFormatId)
        {
            throw new System.NotImplementedException();
        }
    }
}
