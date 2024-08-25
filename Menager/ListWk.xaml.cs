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
using TresNight.Base;

namespace TresNight.Menager
{
    /// <summary>
    /// Логика взаимодействия для ListWk.xaml
    /// </summary>
    public partial class ListWk : Page
    {
        public ListWk()
        {
            InitializeComponent();
            var filtereUs = ControlBsm.ent0bj.User
       .Where(p => p.Id_post == 4 || p.Id_post == 5)
       .ToList();
            grdinf.ItemsSource = filtereUs;
        }

       

        

        private void save_Click(object sender, RoutedEventArgs e)
        {
            ControlBsm.ent0bj.SaveChanges();

            MessageBox.Show("Сохранено",
                "Уведомление",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Transition.frm0bj.GoBack();
        }
    }
}
