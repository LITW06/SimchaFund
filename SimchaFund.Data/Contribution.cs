using System;

namespace SimchaFund.Data
{
    public class Contribution
    {
        public string SimchaName { get; set; }
        public DateTime Date { get; set; }
        public int SimchaId { get; set; }
        public int ContributorId { get; set; }
        public decimal Amount { get; set; }
    }
}