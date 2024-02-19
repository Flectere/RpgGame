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
    /// Логика взаимодействия для ChoiceWeaponPage.xaml
    /// </summary>
    public partial class ChoiceWeaponPage : Page
    {
        public ChoiceWeaponPage()
        {
            InitializeComponent();
            ListWeapon.ItemsSource = CRUD.GetWeapon();
            if (ListWeapon.Items.Count == 0)
            {
                CRUD.CreateWeapon();
            }
            ListWeapon.ItemsSource = CRUD.GetWeapon();
            DataContext = this;
        }
    }
}
