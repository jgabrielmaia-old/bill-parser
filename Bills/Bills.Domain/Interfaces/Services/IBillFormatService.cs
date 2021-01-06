using Bills.Domain.Entities;
using System.Threading.Tasks;

namespace Bills.Domain.Interfaces.Services
{
    /// <summary>
    /// Retrieves the available format to a bill type
    /// </summary>
    public interface IBillFormatService
    {
        Task<SupplyFormat> GetSupplyFormat(int supplyFormatId);
    }
}
