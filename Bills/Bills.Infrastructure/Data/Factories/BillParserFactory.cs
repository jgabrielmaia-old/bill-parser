using Bills.Domain.Entities;
using Bills.Domain.Enums;
using Bills.Domain.Interfaces.Data.Factory;
using System.Threading.Tasks;

namespace Bills.Infrastructure.Data.Factories
{
    /// <summary>
    /// Creates typed instances of bill parser, given the type
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BillParserFactory<T> : IBillParserFactory<T>
    {
        public Task<BillParser<T>> Create(EBillParserType parserType)
        {
            throw new System.NotImplementedException();
        }
    }
}
