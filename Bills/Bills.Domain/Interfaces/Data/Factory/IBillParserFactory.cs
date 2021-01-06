using Bills.Domain.Entities;
using Bills.Domain.Enums;
using System.Threading.Tasks;

namespace Bills.Domain.Interfaces.Data.Factory
{
    /// <summary>
    /// Creates typed instances of bill parser, given the type
    /// </summary>
    public interface IBillParserFactory<T>
    {
        Task<BillParser<T>> Create(EBillParserType parserType);
    }
}
