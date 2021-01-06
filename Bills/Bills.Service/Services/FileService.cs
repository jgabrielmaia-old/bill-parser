using Bills.Domain.Dtos;
using Bills.Domain.Interfaces.Data.Repository;
using Bills.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace Bills.Service.Services
{
    /// <summary>
    /// Summarizes all file related operations
    /// Glue file pieces together and retrieves files
    /// </summary>
    public class FileService : IFileService
    {
        private readonly IFileRepository _fileChunkRepository;

        public FileService(IFileRepository fileChunkRepository)
        {
            _fileChunkRepository = fileChunkRepository;
        }

        public Task<FileDto> AggregateFileChunks(string billId)
        {
            throw new System.NotImplementedException();
        }

        public Task<FileDto> GetFile(string billId)
        {
            throw new System.NotImplementedException();
        }
    }
}
