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

namespace TresNight.Admin
{
    /// <summary>
    /// Логика взаимодействия для AddMen.xaml
    /// </summary>
    public partial class AddMen : Page
    {
        public AddMen()
        {
            InitializeComponent();
            postcmb.SelectedValuePath = "Id_User";
            postcmb.DisplayMemberPath = "Name";
            postcmb.ItemsSource = ControlBsm.ent0bj.Post.ToList();




        }

        private void AddW_Click(object sender, RoutedEventArgs e)
        {
            if (ControlBsm.ent0bj.User.Count(x => x.Login == log.Text) > 0)
            {
                MessageBox.Show("Такой пользователь уже есть в системе",
                    "Уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                return;
            }
            try
            {
                User u0j = new User();
                {
                    u0j.Name = Name.Text;
                    u0j.Last_Name = Last.Text;
                    u0j.Login = log.Text;
                    u0j.Password = pas.Text;


                }




                if (int.TryParse(zonecmb.Text, out int pcsValue))
                {
                    u0j.Activity_zone = pcsValue;
                }
                else
                {
                    MessageBox.Show("Не удалось преобразовать текст из TextBox в число.",
                        "Ошибка",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                    return;
                }
                if (int.TryParse(postcmb.SelectedValue?.ToString(), out int productValue))
                {
                    u0j.Id_post = productValue;
                }
                else
                {
                    MessageBox.Show("Не удалось преобразовать значение ComboBox в число.",
                        "Ошибка",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                    return;
                }

                ControlBsm.ent0bj.User.Add(u0j);
                ControlBsm.ent0bj.SaveChanges();
                Transition.frm0bj.GoBack();
                MessageBox.Show("Сотрудник добавлен",
                    "Уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Критический сбой ПО",
                    "Уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
        }

        private void zonecmb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "012".IndexOf(e.Text) < 0;
        }

        private void postcmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }


}