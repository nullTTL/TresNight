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

namespace TresNight.Menager
{
    /// <summary>
    /// Логика взаимодействия для StrMen.xaml
    /// </summary>
    public partial class StrMen : Page
    {
        public StrMen()
        {
            InitializeComponent();
        }

        private void Listacc_Click(object sender, RoutedEventArgs e)
        {
            Transition.frm0bj.Navigate(new ListAcc());
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Transition.frm0bj.Navigate(new AddWorks());
        }

        private void SetterW_Click(object sender, RoutedEventArgs e)
        {
            Transition.frm0bj.Navigate(new ListWk());
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Transition.frm0bj.Navigate(new Log());
        }
    }
}
