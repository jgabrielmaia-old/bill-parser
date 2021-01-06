using Bills.Domain;
using Bills.Domain.Dtos;
using Bills.Domain.Interfaces.Data.Repository;
using System.Threading.Tasks;

namespace Bills.Infrastructure.Data.Repositories
{
    /// <summary>
    /// Access the MongoDB bill database
    /// </summary>
    public class BillRepository : IBillRepository
    {
        public Task<Bill> Save(BillDto billDto)
        {
            throw new System.NotImplementedException();
        }
    }
}
