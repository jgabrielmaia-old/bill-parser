using Bills.Domain.Entities;
using Bills.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace Bills.Service.Services
{
    public class BillFormatService : IBillFormatService
    {
        public Task<SupplyFormat> GetSupplyFormat(int supplyFormatId)
        {
            throw new System.NotImplementedException();
        }
    }
}
