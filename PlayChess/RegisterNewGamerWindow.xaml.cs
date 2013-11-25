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
using System.Windows.Shapes;

namespace PlayChess
{
    /// <summary>
    /// Interaction logic for RegisterNewGamerWindow.xaml
    /// </summary>
    public partial class RegisterNewGamerWindow : Window
    {
        public RegisterNewGamerWindow()
        {
            InitializeComponent();
        }

        private void RegisterButton(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("вы зарегистрированы");
        }

        private void CanselButton(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
