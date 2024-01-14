﻿using SmogIt.Core.Domains;
using SmogIt.Models.DTO;
using SmogIt.Models.Entities;

namespace SmogIt.Services.Contracts
{
    public interface IServiceService
    {
        Task<List<ServiceModel>> GetAllAsync();
    }
}