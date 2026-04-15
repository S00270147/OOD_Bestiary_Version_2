using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Bestiary_Version_2
{
    //Creatue is the same as enemy
    public class Creature
    {
        public int CreatureId { get; set; }
        public string SubjectName { get; set; }
        public string Portrait { get; set; }
        public string WalkGif { get; set; }
        public string Camapigns { get; set; }
        public string Species { get; set; }
        public string Nature { get; set; }
        public string Habitat { get; set; }
        public string Description { get; set; }
        public string DangerLevel { get; set; }
        public string Speed { get; set; }
        public string HP { get; set; }


        public override string ToString()
        {
            return SubjectName;
        }

    }

    public class  CreatureData : DbContext
    {
        public CreatureData() : base("CreatureData_260415") { }

        public DbSet<Creature> Creatures { get; set; }
        public DbSet<Campaign> Camapigns { get; set; }
    }
}
