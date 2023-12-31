﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTrader.Domain.Model
{
    public class Account : DomainObject
    {
        public int Id { get; set; }
        public User AccountHolder { get; set; }
        public double Balance { get; set; } 
        public IEnumerable<AssetTransaction> AssetTransaction { get; set; }
    }
}
