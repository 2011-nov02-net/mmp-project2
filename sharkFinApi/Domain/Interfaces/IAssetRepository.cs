﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces {
    public interface IAssetRepository {
        Task<IEnumerable<Asset>> GetAllAsync(Portfolio portfolio);
        Task<Asset> GetAsync(Portfolio portfolio, Stock stock);
        Task AddAsync(Asset asset);
        Task UpdateAsync(Asset asset);
        Task DeleteAsync(Asset asset);
    }
}