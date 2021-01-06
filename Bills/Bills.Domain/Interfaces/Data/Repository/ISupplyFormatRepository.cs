using Bills.Domain.Entities;
using System.Threading.Tasks;

namespace Bills.Domain.Interfaces.Data.Repository
{
    public interface ISupplyFormatRepository
    {
        Task<SupplyFormat> RetrieveSupplyFormat(int supplyFormatId);
    }
}
