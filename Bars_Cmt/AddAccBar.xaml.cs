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

namespace TresNight.Bars_Cmt
{
    /// <summary>
    /// Логика взаимодействия для AddAccBar.xaml
    /// </summary>
    public partial class AddAccBar : Page
    {
        public AddAccBar()
        {
            InitializeComponent();
            ItemCmd.SelectedValuePath = "Id_Product";
            ItemCmd.DisplayMemberPath = "Name";
            ItemCmd.ItemsSource = ControlBsm.ent0bj.Product_Bar.ToList();
            

        }
        private void ItemCmd_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            
        }
        private void AddW_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Bar b0j = new Bar();
                {
                    b0j.Id_User = USH.IdUser ; 
                    b0j.Date_recorde = DateTime.Now;
                    b0j.Id_zone = 1;

                }
                
                if (int.TryParse(ItemCmd.SelectedValue?.ToString(), out int productValue))
                {
                    b0j.Products = productValue;
                }
                else
                {
                    MessageBox.Show("Не удалось преобразовать значение ComboBox в число.",
                        "Ошибка",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                    return; 
                }

                
                if (int.TryParse(Pci.Text, out int pcsValue))
                {
                    b0j.Pcs = pcsValue;
                }
                else
                {
                    MessageBox.Show("Не удалось преобразовать текст из TextBox в число.",
                        "Ошибка",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                    return; 
                }

                ControlBsm.ent0bj.Bar.Add(b0j);
                ControlBsm.ent0bj.SaveChanges();
                MessageBox.Show("Отчет добавлен",
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

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Transition.frm0bj.GoBack();
        }

        private void Pci_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789".IndexOf(e.Text) < 0;
        }
    }
}