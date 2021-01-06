using Bills.Domain.Dto;
using System.Threading.Tasks;

namespace Bills.Domain.Interfaces.Data.Repository
{
    public interface IFileRepository
    {
        Task<FileDto> GetFile(string address);
    }
}
