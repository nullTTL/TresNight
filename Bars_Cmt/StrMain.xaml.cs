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

namespace TresNight.Bars_Cmt
{
    /// <summary>
    /// Логика взаимодействия для StrMain.xaml
    /// </summary>
    public partial class StrMain : Page
    {
        public StrMain()
        {
            InitializeComponent();

            grdinf.ItemsSource = ControlBsm.ent0bj.Bar.ToList();
        }

        private void AddAccounting_Click(object sender, RoutedEventArgs e)
        {
            Transition.frm0bj.Navigate(new AddAccBar());
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            ControlBsm.ent0bj.SaveChanges();
            Transition.frm0bj.Refresh();

            MessageBox.Show("Сохранено",
                "Уведомление",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Transition.frm0bj.Navigate(new Log());
        }
    }
}
