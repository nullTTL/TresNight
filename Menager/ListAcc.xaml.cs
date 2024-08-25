﻿using System;
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
    /// Логика взаимодействия для ListAcc.xaml
    /// </summary>
    public partial class ListAcc : Page
    {
        public ListAcc()
        {
            InitializeComponent();
            grdinf.ItemsSource = ControlBsm.ent0bj.Kitchen.ToList();
            grdBar.ItemsSource = ControlBsm.ent0bj.Bar.ToList();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Transition.frm0bj.GoBack();
        }
    }
}
