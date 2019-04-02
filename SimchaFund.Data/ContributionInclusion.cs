namespace SimchaFund.Data
{
    public class ContributionInclusion
    {
        public bool Include { get; set; }
        public decimal Amount { get; set; }
        public int ContributorId { get; set; }
    }
}