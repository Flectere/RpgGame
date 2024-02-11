using GameStrategy.Classes;
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
    /// Логика взаимодействия для CreateHero.xaml
    /// </summary>
    public partial class CreateHero : Page
    {
        public CreateHero()
        {
            InitializeComponent();
        }

        private void AddHeroBt_Click(object sender, RoutedEventArgs e)
        {
            Hero hero = new Hero(NameTb.Text);
            CRUD.CreateHero(hero, ListOfMyHero.type_class);
            NavigationService.Navigate(new ListOfMyHero(ChoiceHero.type));
        }
    }
}
