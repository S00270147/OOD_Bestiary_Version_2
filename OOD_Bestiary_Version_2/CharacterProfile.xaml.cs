using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OOD_Bestiary_Version_2
{
    /// <summary>
    /// Interaction logic for CharacterProfile.xaml
    /// </summary>
    public partial class CharacterProfile : Window
    {
        public CharacterProfile()
        {
            InitializeComponent();
        }

        public CharacterProfile(string character) : this()
        {
            CreatureData db = new CreatureData();

            var query = from c in db.Camapigns
                        where c.CharacterName == character
                        select c;

            Campaign selectedCampaign = query.FirstOrDefault();

            string path = "\\..\\.." + selectedCampaign.Portrait;
            BitmapImage bitmap = new BitmapImage(new Uri(path, UriKind.Relative));

            tblkCharacterName.Text = selectedCampaign.CharacterName;
            tblkDescription.Text = selectedCampaign.Description;
            imgChar.Source = bitmap;
        }
    }
}
