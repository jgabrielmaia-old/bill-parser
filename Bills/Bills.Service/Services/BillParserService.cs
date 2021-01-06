using Bills.Domain;
using Bills.Domain.Entities;
using Bills.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace Bills.Service.Services
{
    public class BillParserService : IBillParserService
    {
        public Task<Bill> Parse(File chunk, SupplyFormat format)
        {
            throw new System.NotImplementedException();
        }
    }
}
