using Bills.Domain.Entities;
using System.Threading.Tasks;

namespace Bills.Domain.Interfaces.Data.Repository
{
    /// <summary>
    /// Retrieves sypply format as documents from MongoDB
    /// </summary>
    public interface ISupplyFormatRepository
    {
        Task<SupplyFormat> RetrieveSupplyFormat(int supplyFormatId);
    }
}
