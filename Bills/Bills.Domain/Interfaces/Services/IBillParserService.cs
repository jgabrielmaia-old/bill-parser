using Bills.Domain.Dtos;
using Bills.Domain.Dtos;
using Bills.Domain.Entities;
using System.Threading.Tasks;

namespace Bills.Domain.Interfaces.Services
{
    public interface IBillParserService
    {
        Task<Bill> Parse(FileDto chunk, SupplyFormat format);
        Task<Bill> Persist(BillDto billDto);
    }
}
