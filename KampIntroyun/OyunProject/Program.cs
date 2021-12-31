using OyunProject.Concrete;
using OyunProject.Entities;
using System;

namespace OyunProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Campaign kampanya1 = new Campaign();
            Campaign kampanya2 = new Campaign();
            kampanya2.Name = "kış ";
            kampanya1.Name = "yaz ";
            kampanya1.Id = 1;
            kampanya1.EndingDate = new  DateTime(1995, 9, 9);
            CampaignManager campaign = new CampaignManager();
            campaign.Delete(kampanya1);
            campaign.Register(kampanya2);

            


        }
    }
}
