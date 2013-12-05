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

namespace PlayChess
{
    /// <summary>
    /// Interaction logic for BoardControl.xaml
    /// </summary>
    public partial class BoardControl : UserControl
    {

        private Border[] arrBorder;
        private Color DarkCellColor = Color.FromRgb(0, 0, 0);
        private Color LiteCellColor = Color.FromRgb(255, 247, 205);

        public BoardControl()
        {
            InitializeComponent();
            InitCells();
        }

        public void InitCells()
        {
            int iPos;
            Border border;
            Brush brushDark;
            Brush brushLite;

            arrBorder = new Border[64];
            iPos = 63;
            brushDark = new SolidColorBrush(DarkCellColor);
            brushLite = new SolidColorBrush(LiteCellColor);
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 8; x++)
                {
                    border = new Border();
                    border.Name = "Cell" + (iPos.ToString());
                    border.BorderThickness = new Thickness(20);
                    border.Background = (((x + y) & 1) == 0) ? brushLite : brushDark;
                    border.BorderBrush = border.Background;
                    border.SetValue(Grid.ColumnProperty, x);
                    border.SetValue(Grid.RowProperty, y);
                    arrBorder[iPos] = border;
                    CellContainer.Children.Add(border);
                    iPos--;
                }
            }
        }
    }
}
