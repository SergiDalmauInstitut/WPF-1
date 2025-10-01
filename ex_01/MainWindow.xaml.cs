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

namespace ex_01
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            WrapPanel wpanel = new WrapPanel();

            this.Background = Brushes.LightGray;

            this.Content = wpanel;

            Button button1 = new Button();
            button1.Margin = new Thickness(10.0);
            button1.Background = Brushes.AliceBlue;
            button1.BorderThickness = new Thickness(0);

            Button button2 = new Button();
            button2.Margin = new Thickness(10.0);
            button2.Background = Brushes.AliceBlue;
            button2.BorderThickness = new Thickness(0);
            
            Button button3 = new Button();
            button3.Margin = new Thickness(10.0);
            button3.Background = Brushes.AliceBlue;
            button3.BorderThickness = new Thickness(0);

            wpanel.Children.Add(button1);
            wpanel.Children.Add(button2);
            wpanel.Children.Add(button3);

            TextBlock text1 = new TextBlock();
            text1.Text = "Hola";
            text1.FontWeight = FontWeights.Bold;
            text1.FontSize = 30;
            text1.Foreground = Brushes.Cyan;

            TextBlock text2 = new TextBlock();
            text2.Text = "Bon";
            text2.FontWeight = FontWeights.Bold;
            text2.FontSize = 30;
            text2.Foreground = Brushes.Magenta;

            TextBlock text3 = new TextBlock();
            text3.Text = "Dia";
            text3.FontWeight = FontWeights.Bold;
            text3.FontSize = 30;
            text3.Foreground = Brushes.Yellow;

            button1.Content = text1;
            button1.Width = 150;
            button1.Height = 90;

            button2.Content = text2;
            button2.Width = 150;
            button2.Height = 90;

            button3.Content = text3;
            button3.Width = 150;
            button3.Height = 90;

        }
    }
}
