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

namespace PolePodFunkcją
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<string> elemele = new List<string>()
        {
            "trapezy",
            "prostokąty"

        };
            for (int i = 0; i < elemele.Count; i++)
            {
                funkcje.Items.Add(elemele[i]);
            }

            
        }

        public double f(double x)
        {
            return x * x + x + 2;
        }

        public void Oblicz(object sender, RoutedEventArgs e)
        {
            string metoda = funkcje.Text;

            int a = Int32.Parse(pierwszaZmienna.Text) ;
            int b = Int32.Parse(drugaZmienna.Text) ;
            int n = Int32.Parse(liczbaTrapezów.Text) ;

            double h = (b - a)/(double)n;
            double S = 0.0;
            double podstawa_a = f(a);
            double podstawa_b;
            double srodek = a + (b - a) / (2.0 * n);

            if (a < b)
                {
                    MessageBox.Show("pzdział jest błędny");
                }
            else { 

                if (metoda == "trapezy") { 

                for(int i = 1; i <= n; i++)
                {
                    podstawa_b = f(a + h * i);
                    S += (podstawa_a + podstawa_b);
                    podstawa_a = podstawa_b;
                }

                MessageBox.Show((S * 0.5 * h).ToString());
                    }
                else if (metoda == "prostokąty")
                {
                    for (int i = 0; i < n; i++)
                    {
                        S += f(srodek); //obliczenie wysokości prostokąta
                        srodek += h; //przejście do następnego środka    
                    }
                    MessageBox.Show( (S * h).ToString());
                }
                }       
            }
    }



}

  

    
   

