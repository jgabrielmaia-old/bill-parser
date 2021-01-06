using Bills.Domain.Entities;
using Bills.Domain.Interfaces.Data.Repository;
using Bills.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace Bills.Service.Services
{
    /// <summary>
    /// Retrieves the available format to a bill type
    /// </summary>
    public class BillFormatService : IBillFormatService
    {
        private readonly ISupplyFormatRepository _supplyFormatRepository;

        public BillFormatService(ISupplyFormatRepository supplyFormatRepository)
        {
            _supplyFormatRepository = supplyFormatRepository;
        }

        public Task<SupplyFormat> GetSupplyFormat(int supplyFormatId)
        {
            throw new System.NotImplementedException();
        }
    }
}
