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
using TresNight.Auth;
using TresNight.Base;
using TresNight.Menager;

namespace TresNight.Admin
{
    /// <summary>
    /// Логика взаимодействия для Str.xaml
    /// </summary>
    public partial class Str : Page
    {
        public Str()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Transition.frm0bj.Navigate(new Log());
        }

        private void SetterW_Click(object sender, RoutedEventArgs e)
        {
            Transition.frm0bj.Navigate(new Listms());
        }

        private void Listacc_Click(object sender, RoutedEventArgs e)
        {
            Transition.frm0bj.Navigate(new ListAcc());
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Transition.frm0bj.Navigate(new AddMen());
        }
    }
}
