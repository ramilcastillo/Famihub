using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FamiHubAPI.ViewModels
{
    public class LoyaltyCardTransaction
    {
        public Guid PartnerId { get; set; }
        public long Points { get; set; }
        public string Comments { get; set; }
    }
    public class LoyaltyValidCard
    {
        public string CardNumber { get; set; }
        public bool Valid { get; set; }
    }
    public class LoyaltyCardBalance
    {
        public string CardNumber { get; set; }
        public long Balance { get; set; }
    }
}