using OyunProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OyunProject.Abstract
{
    public abstract class CampaignBaseManager : ICampaignService
    {
        public void Delete(Campaign campaign)
        {
            Console.WriteLine($"{campaign.Name} kampanyası silindi. ");
        }

        public void Register(Campaign campaign)
        {
            Console.WriteLine($"{campaign.Name} kampanyası kaydedildi. ");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine($"{campaign.Name} kampanyası güncellenci.");
        }
    }
}
