using Bills.Domain.Dtos;
using System.Threading.Tasks;

namespace Bills.Domain.Interfaces.Data.Repository
{
    /// <summary>
    /// Access the MongoDB bill database
    /// </summary>
    public interface IBillRepository
    {
        Task<Bill> Save(BillDto billDto);
    }
}
