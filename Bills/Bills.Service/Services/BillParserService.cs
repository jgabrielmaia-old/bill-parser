using Bills.Domain;
using Bills.Domain.Dtos;
using Bills.Domain.Entities;
using Bills.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace Bills.Service.Services
{
    public class BillParserService : IBillParserService
    {
        public Task<Bill> Parse(FileDto chunk, SupplyFormat format)
        {
            throw new System.NotImplementedException();
        }

        public Task<Bill> Persist(BillDto billDto) {
            throw new System.NotImplementedException();
        }
    }
}
