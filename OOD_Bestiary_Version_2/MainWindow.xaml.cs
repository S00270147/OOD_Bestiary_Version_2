using OOD_Bestiary_Version_2;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOD_Bestiary_Version_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Creature> allCreatures = new List<Creature>();
        List<Creature> activeList = new List<Creature>();


        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Add items to their respective cbx
            string[] campaigns = { "All", "Survivor", "Monk", "Hunter", "Gourmond", "Artificer", "Rivulet", "Spearmaster", "Saint", "Watcher" };
            cbxCampaign.ItemsSource = campaigns;

            string[] species = { "All", "Lizard", "Vulture", "Centipede", "Rot" };
            cbxSpecies.ItemsSource = species;

            string[] nature = { "All", "Hostile", "Neutral", "Passive" };
            cbxNature.ItemsSource = nature;
            //CreateCreatures();

            //GetCreatures From DB
            using (CreatureData db = new CreatureData())
            {
                allCreatures = db.Creatures.ToList();
            }

            //Dsiplay Portraits in CreatureListBox
            lbxCreatures.ItemsSource = allCreatures;


            //set indent

            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            //create json string
            //string jsonString = JsonSerializer.Serialize(creature, options);

            // ../../

            //write to file
            //File.WriteAllText(@"c:\temp\subject-info.json", jsonString);
            //File.WriteAllText(@"../../all-subject-info.json", jsonString);
        }

        private void CreateCreatures()
        {
            List<Creature> filteredList = new List<Creature>();

            //Lizards "TheSkrunkley"
            Creature creature = new Creature() { SubjectName = "Green Lizard", Portrait = "C:\\Users\\AidenMassey-STUDENT\\OneDrive - Atlantic TU\\Documents\\RWW2\\images\\Greenlizard_portrait", Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Watcher", Species = "Lizard", Nature = "Hostile", Habitat = "Land", HP = "", Speed = "", Description = "I am very Mean and I'm Green." };
            Creature creature2 = new Creature() { SubjectName = "Pink Lizard", Portrait = "C:\\Users\\AidenMassey-STUDENT\\OneDrive - Atlantic TU\\Documents\\RWW2\\images\\Pinklizard_portrait", Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Watcher", Species = "Lizard", Nature = "Hostile", Habitat = "Land", HP = "", Speed = "", Description = "I'm just kinda here bro" };
            Creature creature3 = new Creature() { SubjectName = "Blue Lizard", Portrait = "C:\\Users\\AidenMassey-STUDENT\\OneDrive - Atlantic TU\\Documents\\RWW2\\images\\Bluelizard_portrait", Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Watcher", Species = "Lizard", Nature = "Hostile", Habitat = "Land", HP = "", Speed = "", Description = "Spider man, Spider man" };
            Creature creature4 = new Creature() { SubjectName = "White Lizard", Portrait = "C:\\Users\\AidenMassey-STUDENT\\OneDrive - Atlantic TU\\Documents\\RWW2\\images\\Whitelizard_portrait", Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Lizard", Nature = "Hostile", Habitat = "Land", HP = "", Speed = "", Description = "HE'S CAMPING BRO!!!" };
            Creature creature5 = new Creature() { SubjectName = "Yellow Lizard", Portrait = "C:\\Users\\AidenMassey-STUDENT\\OneDrive - Atlantic TU\\Documents\\RWW2\\images\\Yellowlizard_portrait", Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Lizard", Nature = "Hostile", Habitat = "Land", HP = "", Speed = "", Description = "Please Connect Bluetooth Device" };
            Creature creature6 = new Creature() { SubjectName = "Black Lizard", Portrait = "C:\\Users\\AidenMassey-STUDENT\\OneDrive - Atlantic TU\\Documents\\RWW2\\images\\Blacklizard_portrait", Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Lizard", Nature = "Hostile", Habitat = "Land", HP = "", Speed = "", Description = "I have NO-EYE dea what to say here, heh, ok I'll see myself out" };
            Creature creature7 = new Creature() { SubjectName = "Salamander", Portrait = "C:\\Users\\AidenMassey-STUDENT\\OneDrive - Atlantic TU\\Documents\\RWW2\\images\\Salamander_portrait", Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Lizard", Nature = "Hostile", Habitat = "Amphibious", HP = "", Speed = "", Description = "IS THAT THE AGOL-WOGL FROM MINECRAFT!?" };
            Creature creature8 = new Creature() { SubjectName = "Red Lizard", Portrait = "C:\\Users\\AidenMassey-STUDENT\\OneDrive - Atlantic TU\\Documents\\RWW2\\images\\Redlizard_portrait", Camapigns = "Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Lizard", Nature = "Hostile", Habitat = "Land", HP = "", Speed = "", Description = "Like, Devil, From Bible" };
            Creature creature9 = new Creature() { SubjectName = "Cyan Lizard", Portrait = "C:\\Users\\AidenMassey-STUDENT\\OneDrive - Atlantic TU\\Documents\\RWW2\\images\\Cyanlizard_portrait", Camapigns = "Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Lizard", Nature = "Hostile", Habitat = "Land", HP = "", Speed = "", Description = "What if we straped a jet engine to a lizard?" };
            Creature creature10 = new Creature() { SubjectName = "Caramel Lizard", Portrait = "C:\\Users\\AidenMassey-STUDENT\\OneDrive - Atlantic TU\\Documents\\RWW2\\images\\Caramellizard_portrait", Camapigns = "Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Lizard", Nature = "Hostile", Habitat = "Land", HP = "", Speed = "", Description = "Check out my hops bro" };
            Creature creature11 = new Creature() { SubjectName = "Eel Lizard", Portrait = "C:\\Users\\AidenMassey-STUDENT\\OneDrive - Atlantic TU\\Documents\\RWW2\\images\\Eellizard_portrait", Camapigns = "Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Lizard", Nature = "Hostile", Habitat = "Aquatic", HP = "", Speed = "", Description = "Litteraly invisible istg" };
            Creature creature12 = new Creature() { SubjectName = "Strawberry Lizard", Portrait = "C:\\Users\\AidenMassey-STUDENT\\OneDrive - Atlantic TU\\Documents\\RWW2\\images\\Strawberrylizard_portrait", Camapigns = "Saint, Watcher", Species = "Lizard", Nature = "Hostile", Habitat = "Land", HP = "", Speed = "", Description = "The Skrunkley" };

            //Vultures "Birbs"
            Creature creature13 = new Creature() { SubjectName = "Vulture Grub", Portrait = "C:\\Users\\AidenMassey-STUDENT\\OneDrive - Atlantic TU\\Documents\\RWW2\\images\\Greenlizard_portrait", Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Vulture", Nature = "Passive", Habitat = "Land", HP = "", Speed = "", Description = "Pickil" };
            Creature creature14 = new Creature() { SubjectName = "Vulture", Portrait = "C:\\Users\\AidenMassey-STUDENT\\OneDrive - Atlantic TU\\Documents\\RWW2\\images\\Greenlizard_portrait", Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Vulture", Nature = "Hostile", Habitat = "Air", HP = "", Speed = "", Description = "Bird? Machine? IDK?" };
            Creature creature15 = new Creature() { SubjectName = "King Vulture", Portrait = "C:\\Users\\AidenMassey-STUDENT\\OneDrive - Atlantic TU\\Documents\\RWW2\\images\\Greenlizard_portrait", Camapigns = "Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Vulture", Nature = "Hostile", Habitat = "Air", HP = "", Speed = "", Description = "Wait what's this red las-" };
            Creature creature16 = new Creature() { SubjectName = "Miros Bird", Portrait = "C:\\Users\\AidenMassey-STUDENT\\OneDrive - Atlantic TU\\Documents\\RWW2\\images\\Greenlizard_portrait", Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Vulture", Nature = "Hostile", Habitat = "Land", HP = "", Speed = "", Description = "just a lil off the top ok? (Absoluely Chopped)" };
            Creature creature17 = new Creature() { SubjectName = "Miros Vulture", Portrait = "C:\\Users\\AidenMassey-STUDENT\\OneDrive - Atlantic TU\\Documents\\RWW2\\images\\Greenlizard_portrait", Camapigns = "Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Vulture", Nature = "Hostile", Habitat = "Air", HP = "", Speed = "", Description = "Ok this is actualy getting ridiculous now" };

            //Centipedes "Demons"
            Creature creature18 = new Creature() { SubjectName = "Baby Centipede", Portrait = "C:\\Users\\AidenMassey-STUDENT\\OneDrive - Atlantic TU\\Documents\\RWW2\\images\\Greenlizard_portrait", Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Centipede", Nature = "Neutral", Habitat = "Land", HP = "", Speed = "", Description = "Yummi" };
            Creature creature19 = new Creature() { SubjectName = "Adult Centipede", Portrait = "C:\\Users\\AidenMassey-STUDENT\\OneDrive - Atlantic TU\\Documents\\RWW2\\images\\Greenlizard_portrait", Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Centipede", Nature = "Hostile", Habitat = "Land", HP = "", Speed = "", Description = "The Horrors" };
            Creature creature20 = new Creature() { SubjectName = "Winged Centipede", Portrait = "C:\\Users\\AidenMassey-STUDENT\\OneDrive - Atlantic TU\\Documents\\RWW2\\images\\Greenlizard_portrait", Camapigns = "Survivor, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Centipede", Nature = "Hostile", Habitat = "Land", HP = "", Speed = "", Description = "Not even the sky safe cuh" };
            Creature creature21 = new Creature() { SubjectName = "Aquapede", Portrait = "C:\\Users\\AidenMassey-STUDENT\\OneDrive - Atlantic TU\\Documents\\RWW2\\images\\Greenlizard_portrait", Camapigns = "Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Centipede", Nature = "Hostile", Habitat = "Amphibious", HP = "", Speed = "", Description = "The Water Scares Me" };
            Creature creature22 = new Creature() { SubjectName = "Red Centipede", Portrait = "C:\\Users\\AidenMassey-STUDENT\\OneDrive - Atlantic TU\\Documents\\RWW2\\images\\Greenlizard_portrait", Camapigns = "Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Centipede", Nature = "Hostile", Habitat = "Amphibious", HP = "", Speed = "", Description = "1000YardStare.gif" };

            //Add the Items to our Shoping Cart
            allCreatures.Add(creature);
            allCreatures.Add(creature2);
            allCreatures.Add(creature3);
            allCreatures.Add(creature4);
            allCreatures.Add(creature5);
            allCreatures.Add(creature6);
            allCreatures.Add(creature7);
            allCreatures.Add(creature8);
            allCreatures.Add(creature9);
            allCreatures.Add(creature10);
            allCreatures.Add(creature11);
            allCreatures.Add(creature12);
            allCreatures.Add(creature13);
            allCreatures.Add(creature14);
            allCreatures.Add(creature15);
            allCreatures.Add(creature16);
            allCreatures.Add(creature17);
            allCreatures.Add(creature18);
            allCreatures.Add(creature19);
            allCreatures.Add(creature20);
            allCreatures.Add(creature21);
            allCreatures.Add(creature22);
        }

        private List<Creature> CampaignsFilter(string searchTerm, List<Creature> creatures)
        {
            return creatures.Where(c => c.Camapigns.Contains(searchTerm)).OrderBy(c => c.SubjectName).ToList();
        }
        private List<Creature> SpeciesFilter(string searchTerm, List<Creature> creatures)
        {
            return creatures.Where(c => c.Species.Contains(searchTerm)).OrderBy(c => c.SubjectName).ToList();
        }
        private List<Creature> NatureFilter(string searchTerm, List<Creature> creatures)
        {
            return creatures.Where(c => c.Nature.Contains(searchTerm)).OrderBy(c => c.SubjectName).ToList();
        }


        private void cbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //Setup a filtered list
            List<Creature> filteredList = new List<Creature>();


            //determine what is selected in 3 dropdowns and filter list based on that - can be one two or three filters at a time

            // Get selected nature
            string selectedNature = cbxNature.SelectedItem as string;


            if (selectedNature == null || selectedNature == "All")  //this means it has not been selected, so we want to show all creatures
            {
                filteredList = allCreatures;
            }
            else
            {
                filteredList = NatureFilter(selectedNature, allCreatures);
            }


            // Get selected Species
            string selectedSpecies = cbxSpecies.SelectedItem as string;

            if (selectedSpecies == null || selectedSpecies == "All")  //this means it has not been selected, so we want to show all creatures
            {
                filteredList = allCreatures;
            }
            else
            {
                filteredList = SpeciesFilter(selectedSpecies, filteredList);
            }

            // Get selected campaign
            string selectedCampaign = cbxCampaign.SelectedItem as string;

            if (selectedCampaign == null || selectedCampaign == "All")  //this means it has not been selected, so we want to show all creatures
            {
                filteredList = allCreatures;
            }
            else
            {
                filteredList = CampaignsFilter(selectedCampaign, filteredList);
            }

            activeList = filteredList;

            lbxCreatures.ItemsSource = null;

            lbxCreatures.ItemsSource = activeList;
        }





        private void lbxCreature_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        //private void Filters(object sender, SelectionChangedEventArgs e)
        //{

        //    //Determine which filters are selected - can be one two or three
        //    string selectedCampaign = "Saint";
        //    string selectedNature = "Hostile";
        //    string selectedSpecies = "Lizard";
        //  var query1 = allCreatures.Where(c => c.Camapigns.Contains(selectedCampaign));

        //    var query2 = query1.Where(c => c.Nature.Contains(selectedNature));

        //    var query3 = query2.Where(c => c.Species.Contains(selectedSpecies));

        //}

        //Searching for Creatures: (When Key Is Lifted)
        private void tbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            //Setup a filtered list
            List<Creature> filteredList = new List<Creature>();

            string search = tbxSearch.Text;

            if (string.IsNullOrEmpty(search))
            {
                lbxCreatures.ItemsSource = null;
                lbxCreatures.ItemsSource = allCreatures;
            }
            else
            {
                filteredList.Clear();

                foreach (Creature c in allCreatures)
                {
                    if (c.SubjectName.ToLower().Contains(search.ToLower()))
                    {
                        filteredList.Add(c);
                    }

                    lbxCreatures.ItemsSource = null;
                    lbxCreatures.ItemsSource = filteredList;
                }
            }
        }

        public void lbxCreatures_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Creature selectedCreature = lbxCreatures.SelectedItem as Creature;

            CreatureProfile creatureProfile = new CreatureProfile();

            creatureProfile.ShowDialog(); //Second Window is Modal
        }
    }
}