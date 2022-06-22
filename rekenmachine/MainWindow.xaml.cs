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
using NCalc;

namespace rekenmachine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cleare.Click += Cleare_Click;
            clear.Click += Clear_Click;
            verwijder.Click += Verwijder_Click;
            delen.Click += Delen_Click;
            zeven.Click += Zeven_Click;
            acht.Click += Acht_Click;
            negen.Click += Negen_Click;
            keer.Click += Keer_Click;
            vier.Click += Vier_Click;
            vijf.Click += Vijf_Click;
            zes.Click += Zes_Click;
            min.Click += Min_Click;
            een.Click += Een_Click;
            twee.Click += Twee_Click;
            drie.Click += Drie_Click;
            plus.Click += Plus_Click;
            plus_min.Click += Plus_min_Click;
            nul.Click += Nul_Click;
            komma.Click += Komma_Click;
            slis.Click += Slis_Click;
        }

        private void Slis_Click(object sender, RoutedEventArgs e)
        {
            string som = (string)antwoorden.Content;
            string results = som.Remove(som.Length - 1);
            if (results == "-" || results == "+" || results == "*" || results == "/" || results == ".")
            {
                MessageBox.Show("Syntax Error");
                antwoorden.Content = "0";
            }
            else
            {
                string expression = string.Format(som);
                NCalc.Expression evaluator = new NCalc.Expression(expression);
                string Berekend = evaluator.Evaluate().ToString();
                antwoorden.Content = Berekend;
            }
        }

        private void Komma_Click(object sender, RoutedEventArgs e)
        {
            antwoorden.Content += ".";
        }

        private void Nul_Click(object sender, RoutedEventArgs e)
        {
            function("0");
        }

        private void Plus_min_Click(object sender, RoutedEventArgs e)
        {
            string zom = (string)antwoorden.Content;
            string firstCharacter = zom.Substring(0, 1);
            if (firstCharacter == "-")
            {
                string result = zom.Remove(0, 1);
                antwoorden.Content = result;
            }
            else
            {
                antwoorden.Content = "-" + zom;
            }
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            antwoorden.Content += "+";
        }

        private void Drie_Click(object sender, RoutedEventArgs e)
        {
            function("3");
        }

        private void Twee_Click(object sender, RoutedEventArgs e)
        {
            function("2");
        }

        private void Een_Click(object sender, RoutedEventArgs e)
        {
            function("1");
        }

        private void Min_Click(object sender, RoutedEventArgs e)
        {
            antwoorden.Content += "-";
        }

        private void Zes_Click(object sender, RoutedEventArgs e)
        {
            function("6");
        }

        private void Vijf_Click(object sender, RoutedEventArgs e)
        {
            function("5");
        }

        private void Vier_Click(object sender, RoutedEventArgs e)
        {
            function("4");
        }

        private void Keer_Click(object sender, RoutedEventArgs e)
        {
            antwoorden.Content += "*";
        }

        private void Negen_Click(object sender, RoutedEventArgs e)
        {
            function("9");
        }

        private void Acht_Click(object sender, RoutedEventArgs e)
        {
            function("8");
        }

        private void Zeven_Click(object sender, RoutedEventArgs e)
        {
            function("7");
        }

        private void Delen_Click(object sender, RoutedEventArgs e)
        {
            antwoorden.Content += "/";
        }

        private void Verwijder_Click(object sender, RoutedEventArgs e)
        {
            string som = (string)antwoorden.Content;
            string results = som.Remove(som.Length - 1);

            if (results == "")
            {
                antwoorden.Content = "0";
            }
            else
            {
                antwoorden.Content = results;
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            antwoorden.Content = '0';
        }

        private void Cleare_Click(object sender, RoutedEventArgs e)
        {
            antwoorden.Content = '0';
        }
        private void function(string antwoord)
        {
            if (antwoorden.Content.ToString() == "0")
            {
                antwoorden.Content = antwoord;
            }
            else
            {
                antwoorden.Content += antwoord;
            }
        }
    }
}

