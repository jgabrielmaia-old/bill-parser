using System.Threading.Tasks;

namespace Bills.Domain.Interfaces.Application
{
    /// <summary>
    /// Application for parsing files based on format and file extension into bills
    /// </summary>
    public interface IBillParserApplication
    {
        Task<Bill> Parse(string fileAddress);
    }
}
