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
using TresNight.Auth;

namespace TresNight
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ControlBsm.ent0bj = new FrsNightEntities();
            Transition.frm0bj = StartPage;
            StartPage.Navigate(new Log());
        }
    }
}
