using Bills.Domain.Dtos;
using System.Threading.Tasks;

namespace Bills.Domain.Interfaces.Data.Repository
{
    public interface IFileRepository
    {
        Task<FileDto> GetFile(string address);
    }
}
