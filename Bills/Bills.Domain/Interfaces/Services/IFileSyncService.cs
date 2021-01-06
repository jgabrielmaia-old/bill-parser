using Bills.Domain.Dtos;
using System.Threading.Tasks;

namespace Bills.Domain.Interfaces.Services
{
    public interface IFileSyncService
    {
        Task<FileDto> AggregateFileChunks(string billId);

        Task<FileDto> GetFile(string billId);
    }
}
