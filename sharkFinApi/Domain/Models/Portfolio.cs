﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models {
    public class Portfolio {

        //private readonly ICollection<Asset> _assets;
        //public IReadOnlyCollection<Asset> Assets => new HashSet<Asset>(_assets);
        public ICollection<Asset> Assets { get; set; }

        //private readonly ICollection<Trade> _trades;
        //public IReadOnlyCollection<Trade> Trades => new HashSet<Trade>(_trades);
        public ICollection<Trade> Trades { get; set; }


        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Funds { get; set; }

        public Portfolio(string name, decimal funds, ICollection<Asset> assets, ICollection<Trade> trades) {
            Name = name;
            Funds = funds;
            //_assets = assets ?? new HashSet<Asset>();
            //_trades = trades ?? new HashSet<Trade>();

            Assets = assets ?? new HashSet<Asset>();
            Trades = trades ?? new HashSet<Trade>();
        }

        // TODO:
        //  - Implement portfolio-related methods such as adding/deleting assets and trades
    }
}