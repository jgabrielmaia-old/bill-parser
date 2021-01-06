using Bills.Domain;
using Bills.Domain.Enums;
using Bills.Domain.Interfaces.Data.Factory;
using System.Threading.Tasks;

namespace Bills.Infrastructure.Data.Factories
{
    /// <summary>
    /// Creates typed instances of bill
    /// </summary>
    public class BillFactory : IBillFactory
    {
        public Task<Bill> Create(EBillType billType)
        {
            throw new System.NotImplementedException();
        }
    }
}
