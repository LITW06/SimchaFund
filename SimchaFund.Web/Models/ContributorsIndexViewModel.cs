using System.Collections.Generic;
using SimchaFund.Data;

namespace SimchaFund.Web.Models
{
    public class ContributorsIndexViewModel
    {
        public IEnumerable<Contributor> Contributors { get; set; }
    }
}