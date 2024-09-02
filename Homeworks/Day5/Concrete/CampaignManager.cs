using Day5.Abstract;
using Day5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5.Concrete
{
    internal class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("New campaign is added to the system! - " + campaign.name);
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine("Selected campaign is deleted from to the system! - " + campaign.name);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("The campaign has been updated in the system.! - " + campaign.name);
        }
    }
}
