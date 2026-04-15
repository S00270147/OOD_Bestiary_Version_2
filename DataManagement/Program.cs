using OOD_Bestiary_Version_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreatureData db = new CreatureData();

            using (db)
            {
                //Creatures / Enemys
                //Lizards "TheSkrunkley"
                Creature C1  = new Creature() { CreatureId =  1, SubjectName = "Green Lizard",      Portrait = "\\images\\Greenlizard_portrait",      Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Watcher",         Species = "Lizard",    Nature = "Hostile", Habitat = "Land",       DangerLevel = "2/10",   HP = "5", Speed = "1 - 3", Description = "Green Lizards are a common species of Lizard. They are one of the first Lizards the player may encounter and can be found throughout many regions. They are slow and lack the mobility of most other Lizard species,but they are heavy and resilient, making them a formidable threat. Green Lizards have a 50% or 1/2 bite lethality rate." };
                Creature C2  = new Creature() { CreatureId =  2, SubjectName = "Pink Lizard",       Portrait = "\\images\\Pinklizard_portrait",       Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Watcher",         Species = "Lizard",    Nature = "Hostile", Habitat = "Land",       DangerLevel = "3/10",   HP = "2", Speed = "3", Description = "Pink Lizards are one of the first species of Lizard the player may see in the game, and likely the first variety encountered that can climb poles. They are found mostly throughout the early-game but make a few rare appearances in later areas. Pink Lizards have a 33.3% or 1/3 bite lethality rate." };
                Creature C3  = new Creature() { CreatureId =  3, SubjectName = "Blue Lizard",       Portrait = "\\images\\Bluelizard_portrait",       Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Watcher",         Species = "Lizard",    Nature = "Hostile", Habitat = "Land",       DangerLevel = "3/10",   HP = "1", Speed = "4", Description = "Blue Lizards are a small species of Lizard, capable of climbing on walls and using their tongues to grab on to prey. They appear predominantly in the early-game, with some rare appearances in the mid- and late-game. They are the second weakest Lizards after Peach Lizards and are preyed upon by some other Lizard species. Blue Lizards have a 20.0% or 1/5 bite lethality rate." };
                //Creature C4  = new Creature() { CreatureId =  4, SubjectName = "White Lizard", Portrait = "\\images\\Whitelizard_portrait", Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Lizard", Nature = "Hostile", Habitat = "Land", DangerLevel = "4/10", HP = "1.8", Speed = "3", Description = "HE'S CAMPING BRO!!!" };
                //Creature C5  = new Creature() { CreatureId =  5, SubjectName = "Yellow Lizard", Portrait = "\\images\\Yellowlizard_portrait", Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Lizard", Nature = "Hostile", Habitat = "Land", DangerLevel = "4/10", HP = "	1.6", Speed = "3", Description = "Please Connect Bluetooth Device" };
                //Creature C6  = new Creature() { CreatureId =  6, SubjectName = "Black Lizard", Portrait = "\\images\\Blacklizard_portrait", Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Lizard", Nature = "Hostile", Habitat = "Land", DangerLevel = "2/10", HP = "2", Speed = "3", Description = "I have NO-EYE dea what to say here, heh, ok I'll see myself out" };
                //Creature C7  = new Creature() { CreatureId =  7, SubjectName = "Salamander", Portrait = "\\images\\Salamander_portrait", Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Lizard", Nature = "Hostile", Habitat = "Amphibious", DangerLevel = "3/10", HP = "2", Speed = "2 - 6", Description = "IS THAT THE AGOL-WOGL FROM MINECRAFT!?" };
                //Creature C8  = new Creature() { CreatureId =  8, SubjectName = "Red Lizard", Portrait = "\\images\\Redlizard_portrait", Camapigns = "Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Lizard", Nature = "Hostile", Habitat = "Land", DangerLevel = "10/10", HP = "6 + Explosive Resist 5", Speed = "12", Description = "Like, Devil, From Bible" };
                //Creature C9  = new Creature() { CreatureId =  9, SubjectName = "Cyan Lizard", Portrait = "\\images\\Cyanlizard_portrait", Camapigns = "Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Lizard", Nature = "Hostile", Habitat = "Land", DangerLevel = "7/10", HP = "1.8", Speed = "10", Description = "What if we straped a jet engine to a lizard?" };
                //Creature C10 = new Creature() { CreatureId = 10, SubjectName = "Caramel Lizard", Portrait = "\\images\\Caramellizard_portrait", Camapigns = "Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Lizard", Nature = "Hostile", Habitat = "Land", DangerLevel = "4/10", HP = "5", Speed = "2 - 8", Description = "Check out my hops bro" };
                //Creature C11 = new Creature() { CreatureId = 11, SubjectName = "Eel Lizard", Portrait = "\\images\\Eellizard_portrait", Camapigns = "Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Lizard", Nature = "Hostile", Habitat = "Aquatic", DangerLevel = "5/10", HP = "1.6", Speed = "1 - 8", Description = "Litteraly invisible istg" };
                //Creature C12 = new Creature() { CreatureId = 12, SubjectName = "Strawberry Lizard", Portrait = "\\images\\Strawberrylizard_portrait", Camapigns = "Saint, Watcher", Species = "Lizard", Nature = "Hostile", Habitat = "Land", DangerLevel = "3/10", HP = "1.4", Speed = "6", Description = "The Skrunkley" };

                ////Vultures "Birbs"
                //Creature C13 = new Creature() { CreatureId = 13, SubjectName = "Vulture Grub", Portrait = "\\images\\Greenlizard_portrait", Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Vulture", Nature = "Passive", Habitat = "Land", DangerLevel = "1/10", HP = "0.1", Speed = "0.1", Description = "Pickil" };
                //Creature C14 = new Creature() { CreatureId = 14, SubjectName = "Vulture", Portrait = "\\images\\Greenlizard_portrait", Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Vulture", Nature = "Hostile", Habitat = "Air", DangerLevel = "4/10", HP = "8.5", Speed = "10", Description = "Bird? Machine? IDK?" };
                //Creature C15 = new Creature() { CreatureId = 15, SubjectName = "King Vulture", Portrait = "\\images\\Greenlizard_portrait", Camapigns = "Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Vulture", Nature = "Hostile", Habitat = "Air", DangerLevel = "7/10", HP = "12.5", Speed = "10", Description = "Wait what's this red las-" };
                //Creature C16 = new Creature() { CreatureId = 16, SubjectName = "Miros Bird", Portrait = "\\images\\Greenlizard_portrait", Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Vulture", Nature = "Hostile", Habitat = "Land", DangerLevel = "8/10", HP = "7", Speed = "15", Description = "just a lil off the top ok? (Absoluely Chopped)" };
                //Creature C17 = new Creature() { CreatureId = 17, SubjectName = "Miros Vulture", Portrait = "\\images\\Greenlizard_portrait", Camapigns = "Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Vulture", Nature = "Hostile", Habitat = "Air", DangerLevel = "10/10", HP = "20", Speed = "12", Description = "Ok this is actualy getting ridiculous now" };

                ////Centipedes "Demons"
                //Creature C18 = new Creature() { CreatureId = 18, SubjectName = "Baby Centipede", Portrait = "\\images\\Greenlizard_portrait", Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Centipede", Nature = "Neutral", Habitat = "Land", DangerLevel = "1/10", HP = "0.5 + Elec Resist 999", Speed = "1", Description = "Yummi" };
                //Creature C19 = new Creature() { CreatureId = 19, SubjectName = "Adult Centipede", Portrait = "\\images\\Greenlizard_portrait", Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Centipede", Nature = "Hostile", Habitat = "Land", DangerLevel = "3-6/10", HP = "0.75 - 12 + Elec Resist 999", Speed = "1.5 - 8", Description = "The Horrors" };
                //Creature C20 = new Creature() { CreatureId = 20, SubjectName = "Winged Centipede", Portrait = "\\images\\Greenlizard_portrait", Camapigns = "Survivor, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Centipede", Nature = "Hostile", Habitat = "Land", DangerLevel = "4/10", HP = "2.3 - 3.2 + Elec Resist 999", Speed = "7 - 8", Description = "Not even the sky safe cuh" };
                //Creature C21 = new Creature() { CreatureId = 21, SubjectName = "Aquapede", Portrait = "\\images\\Greenlizard_portrait", Camapigns = "Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Centipede", Nature = "Hostile", Habitat = "Amphibious", DangerLevel = "9/10", HP = "1.8 - 6.5 + Elec Resist 999", Speed = "10 - 12", Description = "The Water Scares Me" };
                //Creature C22 = new Creature() { CreatureId = 22, SubjectName = "Red Centipede", Portrait = "\\images\\Greenlizard_portrait", Camapigns = "Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Centipede", Nature = "Hostile", Habitat = "Land", DangerLevel = "10/10", HP = "15 + Elec Resist 999 + Dmg Resist 1", Speed = "12", Description = "1000YardStare.gif" };
                Console.WriteLine("Created Creatures");


                //Adding Creatures to the database
                db.Creatures.Add(C1);
                db.Creatures.Add(C2);
                db.Creatures.Add(C3);
                //db.Creatures.Add(C4);
                //db.Creatures.Add(C5);
                //db.Creatures.Add(C6);
                //db.Creatures.Add(C7);
                //db.Creatures.Add(C8);
                //db.Creatures.Add(C9);
                //db.Creatures.Add(C10);
                //db.Creatures.Add(C11);
                //db.Creatures.Add(C12);
                //db.Creatures.Add(C13);
                //db.Creatures.Add(C14);
                //db.Creatures.Add(C15);
                //db.Creatures.Add(C16);
                //db.Creatures.Add(C17);
                //db.Creatures.Add(C18);
                //db.Creatures.Add(C19);
                //db.Creatures.Add(C20);
                //db.Creatures.Add(C21);
                //db.Creatures.Add(C22);
                Console.WriteLine("Creatures added to database");



                //Characters / Campaigns
                Campaign Camp1 = new Campaign() { CampaignId = 1, CharacterName = "Survivor",    Portrait = "\\images\\Survivor_portrait", Speed = "3",     Diet = "Small Size Food, Omnivore",   FoodPips = "4/3", Description = "\"A nimble omnivore, both predator and prey. Lost in a harsh and indifferent land you must make your own way, with wit and caution as your greatest assets.\" The classic Rain World experience, The Survivor must deal with the ever-present threat of predators while trying to find their way through this hostile world. Survivor has standard Slugcat stats and abilities." };
                Campaign Camp2 = new Campaign() { CampaignId = 2, CharacterName = "Monk",        Portrait = "\\images\\Monk_portrait", Speed = "3",     Diet = "Small Size Food, Omnivore",   FoodPips = "4/3", Description = "\"Weak of body but strong in spirit. In tune with the mysteries of the world and empathetic to its creatures, your journey will be a significantly more peaceful one.\" The Monk serves as Rain World's easy mode. They are physically weaker than Survivor, but predators are less frequent and less aggressive, making the world comparatively easier to traverse." };
                Campaign Camp3 = new Campaign() { CampaignId = 3, CharacterName = "Hunter",      Portrait = "\\images\\Hunter_portrait", Speed = "5",     Diet = "Large Size Food, Carnivore",  FoodPips = "6/3", Description = "\"Strong and quick, with a fierce metabolism requiring a steady diet of meat. But the stomach won't be your only concern, as the path of the hunter is one of extreme peril.\" The Hunter serves as the base game's hard mode. Though they are faster and stronger than Survivor, their campaign features a multitude of changes to make the game much more challenging. Hunter's campaign is only accessible after completing the game as either Survivor or Monk." };
                Campaign Camp4 = new Campaign() { CampaignId = 4, CharacterName = "Gourmand", Portrait = "\\images\\Gourmand_portrait", Speed = "1 - 3", Diet = "Any Size Food, Omnivore", FoodPips = "6/3", Description = "\"An indulger of the simpler pleasures in life. Carrying the world in your stomach gives many tactical advantages, but comes at an increased cost of sustainability.\" The Gourmand is one of five playable Slugcats in the More Slugcats Expansion. They are rotund, slow and heavy, though they are capable of using their mass to their advantage by slamming into other creatures. They can also use objects to craft and can procure random objects from their stomach. Gourmand is unlocked as a playable character after completing the campaign of either Monk or Survivor." };
                Campaign Camp5 = new Campaign() { CampaignId = 5, CharacterName = "Artificer", Portrait = "\\images\\Artificer_portrait", Speed = "5", Diet = "Large Size Food, Carnivore", FoodPips = "7/4", Description = "\"A fierce combatant, master of pyrotechnics and explosives. Keen to move up in the foodchain, your journey will surely be one lined with constant bloodshed and warfare.\" The Artificer is one of five playable Slugcats in the More Slugcats Expansion. They are agile and strong, capable of producing explosions to propel themself through the air and able to craft explosives using certain objects. Artificer is unlocked as a playable character after completing the campaign of either Monk or Survivor." };
                Campaign Camp6 = new Campaign() { CampaignId = 6, CharacterName = "Rivulet", Portrait = "\\images\\Rivulet_portrait", Speed = "8", Diet = "Small Size Food, Omnivore", FoodPips = "5/1", Description = "\"Breathes underwater, and moves through the world with ease. These adaptations are essential, as you'll be pitted against a world of increasingly frequent floods, where time is of the essence.\" The Rivulet is one of five playable Slugcats in the More Slugcats Expansion. They are incredibly agile, having the highest movement speed, swim speed, and jump height of any Slugcat, as well as greatly increased lung capacity underwater. Cycles are much shorter and shelter failures are more frequent in Rivulet's campaign. Rivulet is unlocked as a playable character after completing the campaign of Hunter, Gourmand, or Artificer." };
                Campaign Camp7 = new Campaign() { CampaignId = 7, CharacterName = "SpearMaster", Portrait = "\\images\\Spearmaster_portrait", Speed = "5", Diet = "Any Size Food, Carnivore", FoodPips = "5/5", Description = "\"An abnormality who feeds using needles pulled from its body. A traveller from a far away land; A feeling in your depths sets you out once again, messenger...\" Spearmaster is one of 5 playable Slugcats in the More Slugcats Expansion. They have increased agility and the ability to hold Spears in both hands at once. They are unable to eat normally; they must instead rely on the Needles they produce from their tail to drain nutrients from other creatures. Spearmaster is unlocked as a playable character after completing the campaign of Hunter, Gourmand, or Artificer." };
                Campaign Camp8 = new Campaign() { CampaignId = 8, CharacterName = "Saint", Portrait = "\\images\\Saint_portrait", Speed = "3", Diet = "Small Size Food, Vegeterian", FoodPips = "4/1", Description = "\"Frail and armed with a long tongue. Your journey will be one of perfect enlightenment, but walking this path requires patience, caution, and complete attunement with the world.\" Saint is one of five playable Slugcats in the More Slugcats Expansion. They are able to grapple and swing from walls and ceilings with their long tongue, but they are otherwise weak and incapable of throwing Spears, making their agility essential to their survival. Saint is unlocked as a playable character after completing both Rivulet's and Spearmaster's campaigns." };
                Campaign Camp9 = new Campaign() { CampaignId = 9, CharacterName = "Watcher", Portrait = "\\images\\Watcher_portrait", Speed = "3", Diet = "Small Size Food, Omnivore", FoodPips = "4/3", Description = "\"An outsider, alone and aloof. Observing but not engaging. From this distance comes new perspectives, and new connections. A journey like no other.\" The Watcher is the sole playable Slugcat added by the Rain World: The Watcher expansion.They begin their campaign with basic Survivor stats and abilities. Watcher is unlocked after completing the game as either  Survivor or  Monk." };
                Console.WriteLine("Created Characters");

                db.Camapigns.Add(Camp1);
                db.Camapigns.Add(Camp2);
                db.Camapigns.Add(Camp3);
                //db.Camapigns.Add(Camp4);
                //db.Camapigns.Add(Camp5);
                //db.Camapigns.Add(Camp6);
                //db.Camapigns.Add(Camp7);
                //db.Camapigns.Add(Camp8);
                //db.Camapigns.Add(Camp9);
                Console.WriteLine("Characters added to database");


                //Saving the changes to the database
                db.SaveChanges();
                Console.WriteLine("Saved to database");
            }
        }
    }
}
