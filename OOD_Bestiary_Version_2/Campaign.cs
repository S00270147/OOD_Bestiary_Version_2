using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Bestiary_Version_2
{
    //Campaign is the same as character, a campaign is based on a character
    public class Campaign
    {
        public int CampaignId { get; set; }
        public string CharacterName { get; set; }
        public string Portrait { get; set; }
        public string Speed { get; set; }
        //public string Creatures { get; set; }
        public string Diet { get; set; }
        public string FoodPips { get; set; }
        public string Description { get; set; }

        public List<Creature> Creatures { get; set; }


        public override string ToString()
        {
            return CharacterName;
        }

    }

    //public class CampaignData : DbContext
    //{
    //    public CampaignData() : base("CampaignData") { }

    //    public DbSet<Camapigns> Camapigns { get; set; }
    //}
}
