using Bills.Domain;
using Bills.Domain.Interfaces.Application;
using Bills.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace Bills.Application
{
    public class BillParserApplication : IBillParserApplication
    {
        private readonly IFileSyncService _fileSyncService;
        private readonly IBillFormatService _billFormatService;
        private readonly IBillParserService _billParserService;

        public BillParserApplication(IFileSyncService fileSyncService,
                                     IBillFormatService billFormatService,
                                     IBillParserService billParserService)
        {
            _fileSyncService = fileSyncService;
            _billFormatService = billFormatService;
            _billParserService = billParserService;
        }

        public Task<Bill> Parse(string fileAddress)
        {
            throw new System.NotImplementedException();
        }
    }
}
