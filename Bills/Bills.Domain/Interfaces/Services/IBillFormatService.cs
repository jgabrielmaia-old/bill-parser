using Bills.Domain.Entities;
using System.Threading.Tasks;

namespace Bills.Domain.Interfaces.Services
{
    public interface IBillFormatService
    {
        Task<SupplyFormat> GetSupplyFormat(int supplyFormatId);
    }
}
