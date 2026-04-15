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
    /// Interaction logic for CreatureProfile.xaml
    /// </summary>
    public partial class CreatureProfile : Window
    {
        public CreatureProfile()
        {
            InitializeComponent();
        }

        public CreatureProfile(string creature) : this()
        {
            CreatureData db = new CreatureData();

            var query = from c in db.Creatures
                        where c.SubjectName == creature
                        select c;

            Creature selectedCreature = query.FirstOrDefault();

            string path = "\\..\\.." + selectedCreature.Portrait;
            BitmapImage bitmap = new BitmapImage(new Uri(path, UriKind.Relative));

            tblkCreatureName.Text = selectedCreature.SubjectName;
            tblkDescription.Text = selectedCreature.Description;
            imgCreature.Source = bitmap;
        }
    }
}
