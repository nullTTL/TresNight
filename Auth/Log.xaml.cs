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
using TresNight.Bars_Cmt;
using TresNight.Kitchen_Cmt;
using TresNight.Admin;
using TresNight.Menager;


namespace TresNight.Auth
{
   
    public partial class Log : Page
    {
        public Log()
        {
            InitializeComponent();
        }

        private void Entry_Click(object sender, RoutedEventArgs e)
        {
             try
            {
                var Us0bj = ControlBsm.ent0bj.User.FirstOrDefault(
                    x => x.Login == lg.Text && x.Password == pas.Password);
                if (Us0bj  == null)
                {
                    MessageBox.Show("Такой пользователь отстствует в системе",
                        "Уведомление",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                }

                else
                {
                    USH.IdUser = Us0bj.Id;
                    USH.Name = Us0bj.Name;
                    

                    switch (Us0bj.Id_post)
                    {
                        case 4:

                            USH.IdUser = Us0bj.Id;
                            USH.Login = lg.Text;
                            Transition.frm0bj.Navigate(new StrMain());
                            break;
                        case 5:

                            USH.IdUser = Us0bj.Id;
                            USH.Login = lg.Text;
                            Transition.frm0bj.Navigate(new StrAddKitchen());
                            break;
                        case 6:

                            USH.IdUser = Us0bj.Id;
                            USH.Login = lg.Text;
                            Transition.frm0bj.Navigate(new StrMen());
                            break;
                        case 7:

                            USH.IdUser = Us0bj.Id;
                            USH.Login = lg.Text;
                            Transition.frm0bj.Navigate(new Str());
                            break;


                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Критический сбой ПО",
                    "Уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
        }
    }
}
