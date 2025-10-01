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

            StackPanel spanel1 = new StackPanel();
            StackPanel spanel2 = new StackPanel();
            StackPanel spanel3 = new StackPanel();

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

            Button button4 = new Button();
            button4.Margin = new Thickness(10.0);
            button4.Background = Brushes.AliceBlue;
            button4.BorderThickness = new Thickness(0);

            Button button5 = new Button();
            button5.Margin = new Thickness(10.0);
            button5.Background = Brushes.AliceBlue;
            button5.BorderThickness = new Thickness(0);
            
            Button button6 = new Button();
            button6.Margin = new Thickness(10.0);
            button6.Background = Brushes.AliceBlue;
            button6.BorderThickness = new Thickness(0);

            Button button7 = new Button();
            button7.Margin = new Thickness(10.0);
            button7.Background = Brushes.AliceBlue;
            button7.BorderThickness = new Thickness(0);

            Button button8 = new Button();
            button8.Margin = new Thickness(10.0);
            button8.Background = Brushes.AliceBlue;
            button8.BorderThickness = new Thickness(0);
            
            Button button9 = new Button();
            button9.Margin = new Thickness(10.0);
            button9.Background = Brushes.AliceBlue;
            button9.BorderThickness = new Thickness(0);

            wpanel.Children.Add(spanel1);
            wpanel.Children.Add(spanel2);
            wpanel.Children.Add(spanel3);

            spanel1.Children.Add(button1);
            spanel1.Children.Add(button4);
            spanel1.Children.Add(button7);
            spanel2.Children.Add(button2);
            spanel2.Children.Add(button5);
            spanel2.Children.Add(button8);
            spanel3.Children.Add(button3);
            spanel3.Children.Add(button6);
            spanel3.Children.Add(button9);

            TextBlock text1 = new TextBlock();
            text1.Text = "X";

            button1.Width = 150;
            button1.Height = 150;
            button1.Click += (s, e) => button1.Content = text1;

            button2.Width = 150;
            button2.Height = 150;
            button2.Click += (s, e) => button2.Content = text1;

            button3.Width = 150;
            button3.Height = 150;

            button4.Width = 150;
            button4.Height = 150;

            button5.Width = 150;
            button5.Height = 150;

            button6.Width = 150;
            button6.Height = 150;

            button7.Width = 150;
            button7.Height = 150;

            button8.Width = 150;
            button8.Height = 150;

            button9.Width = 150;
            button9.Height = 150;


        }
    }
}
