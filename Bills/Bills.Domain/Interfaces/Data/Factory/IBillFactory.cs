using Bills.Domain.Enums;
using System.Threading.Tasks;

namespace Bills.Domain.Interfaces.Data.Factory
{
    /// <summary>
    /// Creates typed instances of bill
    /// </summary>
    public interface IBillFactory
    {
        Task<Bill> Create(EBillType billType);
    }
}
