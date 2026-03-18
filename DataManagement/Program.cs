using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOD_Bestiary_Version_2;

namespace DataManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreatureData db = new CreatureData();

            using (db)
            {
                //Lizards "TheSkrunkley"
                Creature C1  = new Creature() { CreatureId =  1, SubjectName = "Green Lizard",      Portrait = "\\images\\Greenlizard_portrait",      Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Watcher",         Species = "Lizard",    Nature = "Hostile", Habitat = "Land",       HP = "", Speed = "", Description = "Green Lizards are a common species of Lizard. They are one of the first Lizards the player may encounter and can be found throughout many regions. They are slow and lack the mobility of most other Lizard species,but they are heavy and resilient, making them a formidable threat. Green Lizards have a 50% or 1/2 bite lethality rate." };
                Creature C2  = new Creature() { CreatureId =  2, SubjectName = "Pink Lizard",       Portrait = "\\images\\Pinklizard_portrait",       Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Watcher",         Species = "Lizard",    Nature = "Hostile", Habitat = "Land",       HP = "", Speed = "", Description = "Pink Lizards are one of the first species of Lizard the player may see in the game, and likely the first variety encountered that can climb poles. They are found mostly throughout the early-game but make a few rare appearances in later areas. Pink Lizards have a 33.3% or 1/3 bite lethality rate." };
                Creature C3  = new Creature() { CreatureId =  3, SubjectName = "Blue Lizard",       Portrait = "\\images\\Bluelizard_portrait",       Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Watcher",         Species = "Lizard",    Nature = "Hostile", Habitat = "Land",       HP = "", Speed = "", Description = "Spider man, Spider man" };
                Creature C4  = new Creature() { CreatureId =  4, SubjectName = "White Lizard",      Portrait = "\\images\\Whitelizard_portrait",      Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher",  Species = "Lizard",    Nature = "Hostile", Habitat = "Land",       HP = "", Speed = "", Description = "HE'S CAMPING BRO!!!" };
                Creature C5  = new Creature() { CreatureId =  5, SubjectName = "Yellow Lizard",     Portrait = "\\images\\Yellowlizard_portrait",     Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher",  Species = "Lizard",    Nature = "Hostile", Habitat = "Land",       HP = "", Speed = "", Description = "Please Connect Bluetooth Device" };
                Creature C6  = new Creature() { CreatureId =  6, SubjectName = "Black Lizard",      Portrait = "\\images\\Blacklizard_portrait",      Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher",  Species = "Lizard",    Nature = "Hostile", Habitat = "Land",       HP = "", Speed = "", Description = "I have NO-EYE dea what to say here, heh, ok I'll see myself out" };
                Creature C7  = new Creature() { CreatureId =  7, SubjectName = "Salamander",        Portrait = "\\images\\Salamander_portrait",       Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher",  Species = "Lizard",    Nature = "Hostile", Habitat = "Amphibious", HP = "", Speed = "", Description = "IS THAT THE AGOL-WOGL FROM MINECRAFT!?" };
                Creature C8  = new Creature() { CreatureId =  8, SubjectName = "Red Lizard",        Portrait = "\\images\\Redlizard_portrait",        Camapigns = "Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher",                  Species = "Lizard",    Nature = "Hostile", Habitat = "Land",       HP = "", Speed = "", Description = "Like, Devil, From Bible" };
                Creature C9  = new Creature() { CreatureId =  9, SubjectName = "Cyan Lizard",       Portrait = "\\images\\Cyanlizard_portrait",       Camapigns = "Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher",                  Species = "Lizard",    Nature = "Hostile", Habitat = "Land",       HP = "", Speed = "", Description = "What if we straped a jet engine to a lizard?" };
                Creature C10 = new Creature() { CreatureId = 10, SubjectName = "Caramel Lizard",    Portrait = "\\images\\Caramellizard_portrait",    Camapigns = "Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher",                  Species = "Lizard",    Nature = "Hostile", Habitat = "Land",       HP = "", Speed = "", Description = "Check out my hops bro" };
                Creature C11 = new Creature() { CreatureId = 11, SubjectName = "Eel Lizard",        Portrait = "\\images\\Eellizard_portrait",        Camapigns = "Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher",                  Species = "Lizard",    Nature = "Hostile", Habitat = "Aquatic",    HP = "", Speed = "", Description = "Litteraly invisible istg" };
                Creature C12 = new Creature() { CreatureId = 12, SubjectName = "Strawberry Lizard", Portrait = "\\images\\Strawberrylizard_portrait", Camapigns = "Saint, Watcher",                                                                     Species = "Lizard",    Nature = "Hostile", Habitat = "Land",       HP = "", Speed = "", Description = "The Skrunkley" };

                //Vultures "Birbs"
                Creature C13 = new Creature() { CreatureId = 13, SubjectName = "Vulture Grub",      Portrait = "\\images\\Greenlizard_portrait",      Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher",  Species = "Vulture",   Nature = "Passive", Habitat = "Land",       HP = "", Speed = "", Description = "Pickil" };
                Creature C14 = new Creature() { CreatureId = 14, SubjectName = "Vulture",           Portrait = "\\images\\Greenlizard_portrait",      Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher",  Species = "Vulture",   Nature = "Hostile", Habitat = "Air",        HP = "", Speed = "", Description = "Bird? Machine? IDK?" };
                Creature C15 = new Creature() { CreatureId = 15, SubjectName = "King Vulture",      Portrait = "\\images\\Greenlizard_portrait",      Camapigns = "Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher",                  Species = "Vulture",   Nature = "Hostile", Habitat = "Air",        HP = "", Speed = "", Description = "Wait what's this red las-" };
                Creature C16 = new Creature() { CreatureId = 16, SubjectName = "Miros Bird",        Portrait = "\\images\\Greenlizard_portrait",      Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher",  Species = "Vulture",   Nature = "Hostile", Habitat = "Land",       HP = "", Speed = "", Description = "just a lil off the top ok? (Absoluely Chopped)" };
                Creature C17 = new Creature() { CreatureId = 17, SubjectName = "Miros Vulture",     Portrait = "\\images\\Greenlizard_portrait",      Camapigns = "Artificer, Rivulet, Spearmaster, Saint, Watcher",                                    Species = "Vulture",   Nature = "Hostile", Habitat = "Air",        HP = "", Speed = "", Description = "Ok this is actualy getting ridiculous now" };

                //Centipedes "Demons"
                Creature C18 = new Creature() { CreatureId = 18, SubjectName = "Baby Centipede",    Portrait = "\\images\\Greenlizard_portrait",      Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher",  Species = "Centipede", Nature = "Neutral", Habitat = "Land",       HP = "", Speed = "", Description = "Yummi" };
                Creature C19 = new Creature() { CreatureId = 19, SubjectName = "Adult Centipede",   Portrait = "\\images\\Greenlizard_portrait",      Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher",  Species = "Centipede", Nature = "Hostile", Habitat = "Land",       HP = "", Speed = "", Description = "The Horrors" };
                Creature C20 = new Creature() { CreatureId = 20, SubjectName = "Winged Centipede",  Portrait = "\\images\\Greenlizard_portrait",      Camapigns = "Survivor, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher",        Species = "Centipede", Nature = "Hostile", Habitat = "Land",       HP = "", Speed = "", Description = "Not even the sky safe cuh" };
                Creature C21 = new Creature() { CreatureId = 21, SubjectName = "Aquapede",          Portrait = "\\images\\Greenlizard_portrait",      Camapigns = "Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher",                          Species = "Centipede", Nature = "Hostile", Habitat = "Amphibious", HP = "", Speed = "", Description = "The Water Scares Me" };
                Creature C22 = new Creature() { CreatureId = 22, SubjectName = "Red Centipede",     Portrait = "\\images\\Greenlizard_portrait",      Camapigns = "Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher",                  Species = "Centipede", Nature = "Hostile", Habitat = "Amphibious", HP = "", Speed = "", Description = "1000YardStare.gif" };



                //Adding Creatures to the database
                db.Creatures.Add(C1);
                db.Creatures.Add(C2);
                db.Creatures.Add(C3);
                db.Creatures.Add(C4);
                db.Creatures.Add(C5);
                db.Creatures.Add(C6);
                db.Creatures.Add(C7);
                db.Creatures.Add(C8);
                db.Creatures.Add(C9);
                db.Creatures.Add(C10);
                db.Creatures.Add(C11);
                db.Creatures.Add(C12);
                db.Creatures.Add(C13);
                db.Creatures.Add(C14);
                db.Creatures.Add(C15);
                db.Creatures.Add(C16);
                db.Creatures.Add(C17);
                db.Creatures.Add(C18);
                db.Creatures.Add(C19);
                db.Creatures.Add(C20);
                db.Creatures.Add(C21);
                db.Creatures.Add(C22);

                //Saving the changes to the database
                db.SaveChanges();

            }
        }
    }
}
