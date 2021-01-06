using Bills.Domain.Dtos;
using System.Threading.Tasks;

namespace Bills.Domain.Interfaces.Services
{
    /// <summary>
    /// Summarizes all file related operations
    /// Glue file pieces together and retrieves files
    /// </summary>
    public interface IFileService
    {
        Task<FileDto> AggregateFileChunks(string billId);

        Task<FileDto> GetFile(string billId);
    }
}
