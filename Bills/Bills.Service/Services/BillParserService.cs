using Bills.Domain;
using Bills.Domain.Dtos;
using Bills.Domain.Entities;
using Bills.Domain.Interfaces.Data.Repository;
using Bills.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace Bills.Service.Services
{
    /// <summary>
    /// Handles file to bill conversions
    /// </summary>
    public class BillParserService : IBillParserService
    {
        private readonly IBillRepository _billRepository;

        public BillParserService(IBillRepository billRepository)
        {
            _billRepository = billRepository;
        }

        public Task<Bill> Parse(FileDto chunk, SupplyFormat format)
        {
            throw new System.NotImplementedException();
        }

        public Task<Bill> Persist(BillDto billDto) {
            throw new System.NotImplementedException();
        }
    }
}
