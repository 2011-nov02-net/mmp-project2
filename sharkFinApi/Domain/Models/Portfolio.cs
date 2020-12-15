﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models {
    public class Portfolio {

        private readonly ICollection<Asset> _assets;
        public IReadOnlyCollection<Asset> Assets => new HashSet<Asset>(_assets);

        private readonly ICollection<Trade> _trades;
        public IReadOnlyCollection<Trade> Trades => new HashSet<Trade>(_trades);

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Funds { get; set; }

        public Portfolio(string name, decimal funds) {
            Name = name;
            Funds = funds;
            _assets = new HashSet<Asset>();
            _trades = new HashSet<Trade>();
        }

        // TODO:
        //  - Implement portfolio-related methods such as adding/deleting assets and trades
    }
}