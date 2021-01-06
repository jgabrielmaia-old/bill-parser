﻿using Bills.Domain.Entities;
using System.Threading.Tasks;

namespace Bills.Domain.Interfaces.Services
{
    public interface IBillParserService
    {
        Task<Bill> Parse(File chunk, SupplyFormat format);
    }
}