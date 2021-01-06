using System;
using System.Collections.Generic;
using Bills.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Bills.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BillParsingController : ControllerBase
    {
        private readonly ILogger<BillParsingController> _logger;

        public BillParsingController(ILogger<BillParsingController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Bill> Parse(string fileAddress)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public IEnumerable<Bill> Parse(List<string> fileAddress)
        {
            throw new NotImplementedException();
        }
    }
}
