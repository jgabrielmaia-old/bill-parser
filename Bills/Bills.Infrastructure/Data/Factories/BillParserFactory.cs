using Bills.Domain.Entities;
using Bills.Domain.Enums;
using Bills.Domain.Interfaces.Data.Factory;
using System.Threading.Tasks;

namespace Bills.Infrastructure.Data.Factories
{
    public class BillParserFactory<T> : IBillParserFactory<T>
    {
        public Task<BillParser<T>> Create(EBillParserType parserType)
        {
            throw new System.NotImplementedException();
        }
    }
}
