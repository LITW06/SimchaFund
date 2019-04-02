using System.Collections.Generic;
using SimchaFund.Data;

namespace SimchaFund.Web.Models
{
    public class ContributionsViewModel
    {
        public Simcha Simcha { get; set; }
        public IEnumerable<SimchaContributor> Contributors { get; set; }
    }
}