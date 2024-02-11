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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameStrategy.Pages
{
    /// <summary>
    /// Логика взаимодействия для ChoiceHero.xaml
    /// </summary>
    public partial class ChoiceHero : Page
    {
        public static string type;
        public ChoiceHero()
        {
            InitializeComponent();
        }

        private void warriorBt_Click(object sender, RoutedEventArgs e)
        {
            type = "Warrior";
            NavigationService.Navigate(new ListOfMyHero(type));
        }

        private void rogueBt_Click(object sender, RoutedEventArgs e)
        {
            type = "Rogue";
            NavigationService.Navigate(new ListOfMyHero(type));
        }

        private void wizardBt_Click(object sender, RoutedEventArgs e)
        {
            type = "Wizard";
            NavigationService.Navigate(new ListOfMyHero(type));
        }
    }
}
