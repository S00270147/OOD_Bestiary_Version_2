using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace OOD_Bestiary_Version_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Creature> allCreatures = new List<Creature>();
        List<Creature> activeList = new List<Creature>();
        List<string> selectedCampaigns = new List<string>();
        List<Creature> CampaignCreature = new List<Creature>();
        string character = "";

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

            //Dsiplay Creatures in CreatureListBox
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

        //private void CreateCampaigns()
        //{
        //    List<Campaign> filteredList = new List<Campaign>();
            
        //    //Lizards "TheSkrunkley"
        //    Campaign campaign = new Campaign() { CharacterName = "Green Lizard", Portrait = "C:\\Users\\AidenMassey-STUDENT\\OneDrive - Atlantic TU\\Documents\\RWW2\\images\\Greenlizard_portrait", Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Watcher", Species = "Lizard", Nature = "Hostile", Habitat = "Land", HP = "", Speed = "", Description = "I am very Mean and I'm Green." };
        //    Campaign campaign2 = new Campaign() { CharacterName = "Pink Lizard", Portrait = "C:\\Users\\AidenMassey-STUDENT\\OneDrive - Atlantic TU\\Documents\\RWW2\\images\\Pinklizard_portrait", Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Watcher", Species = "Lizard", Nature = "Hostile", Habitat = "Land", HP = "", Speed = "", Description = "I'm just kinda here bro" };
        //    Campaign campaign3 = new Campaign() { CharacterName = "Blue Lizard", Portrait = "C:\\Users\\AidenMassey-STUDENT\\OneDrive - Atlantic TU\\Documents\\RWW2\\images\\Bluelizard_portrait", Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Watcher", Species = "Lizard", Nature = "Hostile", Habitat = "Land", HP = "", Speed = "", Description = "Spider man, Spider man" };
        //    Campaign campaign4 = new Campaign() { CharacterName = "White Lizard", Portrait = "C:\\Users\\AidenMassey-STUDENT\\OneDrive - Atlantic TU\\Documents\\RWW2\\images\\Whitelizard_portrait", Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Lizard", Nature = "Hostile", Habitat = "Land", HP = "", Speed = "", Description = "HE'S CAMPING BRO!!!" };
        //    Campaign campaign5 = new Campaign() { CharacterName = "Yellow Lizard", Portrait = "C:\\Users\\AidenMassey-STUDENT\\OneDrive - Atlantic TU\\Documents\\RWW2\\images\\Yellowlizard_portrait", Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Lizard", Nature = "Hostile", Habitat = "Land", HP = "", Speed = "", Description = "Please Connect Bluetooth Device" };
        //    Campaign campaign6 = new Campaign() { CharacterName = "Black Lizard", Portrait = "C:\\Users\\AidenMassey-STUDENT\\OneDrive - Atlantic TU\\Documents\\RWW2\\images\\Blacklizard_portrait", Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Lizard", Nature = "Hostile", Habitat = "Land", HP = "", Speed = "", Description = "I have NO-EYE dea what to say here, heh, ok I'll see myself out" };
        //    Campaign campaign7 = new Campaign() { CharacterName = "Salamander", Portrait = "C:\\Users\\AidenMassey-STUDENT\\OneDrive - Atlantic TU\\Documents\\RWW2\\images\\Salamander_portrait", Camapigns = "Survivor, Monk, Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Lizard", Nature = "Hostile", Habitat = "Amphibious", HP = "", Speed = "", Description = "IS THAT THE AGOL-WOGL FROM MINECRAFT!?" };
        //    Campaign campaign8 = new Campaign() { CharacterName = "Red Lizard", Portrait = "C:\\Users\\AidenMassey-STUDENT\\OneDrive - Atlantic TU\\Documents\\RWW2\\images\\Redlizard_portrait", Camapigns = "Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Lizard", Nature = "Hostile", Habitat = "Land", HP = "", Speed = "", Description = "Like, Devil, From Bible" };
        //    Campaign campaign9 = new Campaign() { CharacterName = "Cyan Lizard", Portrait = "C:\\Users\\AidenMassey-STUDENT\\OneDrive - Atlantic TU\\Documents\\RWW2\\images\\Cyanlizard_portrait", Camapigns = "Hunter, Gourmond, Artificer, Rivulet, Spearmaster, Saint, Watcher", Species = "Lizard", Nature = "Hostile", Habitat = "Land", HP = "", Speed = "", Description = "What if we straped a jet engine to a lizard?" };
            

        //    //Add the Items to our Shoping Cart
        //    allCreatures.Add(campaign);
        //    allCreatures.Add(campaign2);
        //    allCreatures.Add(campaign3);
        //    allCreatures.Add(campaign4);
        //    allCreatures.Add(campaign5);
        //    allCreatures.Add(campaign6);
        //    allCreatures.Add(campaign7);
        //    allCreatures.Add(campaign8);
        //    allCreatures.Add(campaign9);
        //}

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
            filteredList.Clear();

            foreach (Creature c in allCreatures)
            {
                if (c.Camapigns.Contains(selectedCampaigns.ToString()))
                    filteredList.Add(c);

                lbxCreatures.ItemsSource = null;
                lbxCreatures.ItemsSource = filteredList;
            }

            //determine what is selected in 3 dropdowns and filter list based on that

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

        ///-----------------------------------------------------------------------------------------------------\
        //|Logic for all the Campaigns Buttons, all buttons on the Played Campaigns Screen will call this method.|
        //\-----------------------------------------------------------------------------------------------------/
        public void PlayedCampaignsButton(object sender, RoutedEventArgs e)
        {
            //get name of charcter from button name
            Button button = sender as Button;
            string buttonName = button.Name; //btnSelectCampaignName
            string campaignName = buttonName.Replace("btnSelect", "");//CampaignName
            //True False Button, if true, Show at default opacity, if false, fade the portrait
            if (button.Opacity == 1)
            {
                button.Opacity = 0.5;
                if (selectedCampaigns.Contains(campaignName))
                    selectedCampaigns.Remove(campaignName);
            }
            else
            {
                button.Opacity = 1;
                //when have name add to list of selected campaigns
                if (!selectedCampaigns.Contains(campaignName))
                    selectedCampaigns.Add(campaignName);
            }
        }

        //private List<Creature> SelectedCampaignsToCreatureSearch(List<string> searchTerm, List<Creature> creatures)
        //{
        //    return creatures.Where(c => c.Camapigns.Contains(c.Camapigns)).OrderBy(c => c.SubjectName).ToList();
        //}

        //private void CaampaignCreature(object sender, RoutedEventArgs e)
        //{
        //    CampaignCreature = CampaignsFilter(selectedCampaigns, allCreatures);
        //}
        //|----------------------------|
        //      Played Campaigns
        //|----------------------------|
        private void btnSelectSurvivor_Click(object sender, RoutedEventArgs e)
        {
            PlayedCampaignsButton(sender, e);
        }

        private void btnSelectMonk_Click(object sender, RoutedEventArgs e)
        {
            PlayedCampaignsButton(sender, e);
        }

        private void btnSelectHunter_Click(object sender, RoutedEventArgs e)
        {
            PlayedCampaignsButton(sender, e);
        }

        private void btnSelectGourmand_Click(object sender, RoutedEventArgs e)
        {
            PlayedCampaignsButton(sender, e);
        }

        private void btnSelectArtificer_Click(object sender, RoutedEventArgs e)
        {
            PlayedCampaignsButton(sender, e);
        }

        private void btnSelectRivulet_Click(object sender, RoutedEventArgs e)
        {
            PlayedCampaignsButton(sender, e);
        }

        private void btnSelectSpearMaster_Click(object sender, RoutedEventArgs e)
        {
            PlayedCampaignsButton(sender, e);
        }

        private void btnSelectSaint_Click(object sender, RoutedEventArgs e)
        {
            PlayedCampaignsButton(sender, e);
        }

        private void btnSelectWatcher_Click(object sender, RoutedEventArgs e)
        {
            PlayedCampaignsButton(sender, e);
        }

        private void tbitmCreatureSearch_Loaded(object sender, RoutedEventArgs e)
        {
            lbxCreatures.ClearValue(ItemsControl.ItemsSourceProperty);
            lbxCreatures.ItemsSource = CampaignCreature;
        }

        ///---------------------------------------------------------------------------------------------------------\
        //|Logic for all the Character Info Buttons, all buttons on the Character Info Screen will call this method.|
        //\---------------------------------------------------------------------------------------------------------/
        public void CharacterInfoButton(object sender, RoutedEventArgs e)
        {
            //get name of charcter from button name
            Button infoButton = sender as Button;
            string infoButtonName = infoButton.Name; //btnInfoCampaignName
            string infoCampaignName = infoButtonName.Replace("btnInfo", "");//CampaignName
            //If true, on click open page, if false, do nothing
            if (infoButton.Opacity == 1)
            {
                character = infoCampaignName;
                CharacterProfile campWindow = new CharacterProfile(character);
                campWindow.ShowDialog();
            }
        }


        //|----------------------------|
        //|   Character Info Buttons   |
        //|----------------------------|
        private void btnInfoSurvivor_Click(object sender, RoutedEventArgs e)
        {
            CharacterInfoButton(sender, e);
        }

        private void btnInfoMonk_Click(object sender, RoutedEventArgs e)
        {
            CharacterInfoButton(sender, e);
        }

        private void btnInfoHunter_Click(object sender, RoutedEventArgs e)
        {
            CharacterInfoButton(sender, e);
        }

        private void btnInfoGourmand_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnInfoArtificer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnInfoRivulet_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnInfoSpearMaster_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnInfoWatcher_Click(object sender, RoutedEventArgs e)
        {

        }

        

        private void TabItem_GotFocus(object sender, RoutedEventArgs e)
        {
            //Display selected list names

            //string display = "";
            //foreach (var item in selectedCampaigns)
            //{
            //    display += item;
            //    display += ", ";
            //}

            //MessageBox.Show(display);

            //get names of buttons
            //string character = selectedCampaigns[0];

            //change opacity
            if (selectedCampaigns.Contains("Survivor"))
                btnInfoSurvivor.Opacity = 1;
            else //(character != "Survivor")
                btnInfoSurvivor.Opacity = 0.5;



            if (selectedCampaigns.Contains("Monk"))
                btnInfoMonk.Opacity = 1;
            else //(character != "Monk")
                btnInfoMonk.Opacity = 0.5;



            if (selectedCampaigns.Contains("Hunter"))
                btnInfoHunter.Opacity = 1;
            else //(character != "Hunter")
                btnInfoHunter.Opacity = 0.5;

            //add else for deselection - or other solution

            //code for 1st three
        }

        private void btnInfoSaint_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}