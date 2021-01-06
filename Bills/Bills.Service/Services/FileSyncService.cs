using Bills.Domain.Dtos;
using Bills.Domain.Interfaces.Data.Repository;
using Bills.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace Bills.Service.Services
{
    public class FileSyncService : IFileSyncService
    {
        private readonly IFileRepository _fileChunkRepository;

        public FileSyncService(IFileRepository fileChunkRepository)
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
