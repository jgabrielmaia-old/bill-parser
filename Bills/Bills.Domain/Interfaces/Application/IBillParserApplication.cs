using System.Threading.Tasks;

namespace Bills.Domain.Interfaces.Application
{
    public interface IBillParserApplication
    {
        Task<Bill> Parse(string fileAddress);
    }
}
