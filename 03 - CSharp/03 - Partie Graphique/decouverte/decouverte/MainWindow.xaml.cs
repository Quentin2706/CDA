using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace decouverte
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        char[] op = new char[4] { '+', '-', '/', '*' };

        List<char> calcul = new List<char>(); 

        private void BtnNum_Click(object sender, RoutedEventArgs e)
        {
            tbx_aff.Text += ((Button)sender).Content;
            calcul.Add((char)((Button)sender).Content)
        }

        private void BtnOP_Click(object sender, RoutedEventArgs e)
        {
            bool autorisation = true;

            foreach (char unchar in tbx_aff.Text)
            {
                if (Array.Exists(op, x => x == unchar))
                {
                    autorisation = false;
                }
            }

            if (tbx_aff.Text != "" && autorisation)
            {
                tbx_aff.Text += ((Button)sender).Content;
            }

            //if(tbx_aff.Text == "")
            //{
            //    if ((char) ((Button)sender).Content == '-')
            //    {
            //        tbx_aff.Text += ((Button)sender).Content;
            //    }
            //} else if (tbx_aff.Text[tbx_aff.Text.Length-1] == '+' || tbx_aff.Text[tbx_aff.Text.Length - 1] == '-')
            //{

            //}
        }


        private void BtnResult_Click(object sender, RoutedEventArgs e)
        {
            char operateur = ' ';
            string[] nombres = { "x", "x" };
            double resultat = 0;

            foreach (char unchar in tbx_aff.Text)
            {
                if (Array.Exists(op, x => x == unchar))
                {
                    operateur = tbx_aff.Text[tbx_aff.Text.IndexOf(unchar)];
                    nombres = tbx_aff.Text.Split(operateur);
                }
            }
            if (nombres[0] != "" && nombres[1] != "")
            {
                switch (operateur)
                {
                    case '+':
                        resultat = double.Parse(nombres[0]) + double.Parse(nombres[1]);
                        break;
                    case '-':
                        resultat = double.Parse(nombres[0]) - double.Parse(nombres[1]);
                        break;
                    case '/':
                        if (double.Parse(nombres[0]) != 0 && double.Parse(nombres[1]) != 0)
                        {
                            resultat = double.Parse(nombres[0]) / double.Parse(nombres[1]);
                        }
                        break;
                    case '*':
                        resultat = double.Parse(nombres[0]) * double.Parse(nombres[1]);
                        break;
                    default:
                        resultat = double.Parse(tbx_aff.Text);
                        break;
                }
                tbx_aff.Text = resultat + "";
            }
        }

        private void BtnCE_Click(object sender, RoutedEventArgs e)
        {
            tbx_aff.Text = "";
        }

        private void BtnC_Click(object sender, RoutedEventArgs e)
        {
            tbx_aff.Text = tbx_aff.Text.Substring(1,tbx_aff.Text.Length-1);
        }



        private void BtnVir_Click(object sender, RoutedEventArgs e)
        {
            int operateur = -1;
            foreach (char unchar in tbx_aff.Text)
            {
                if (Array.Exists(op, x => x == unchar))
                {
                    operateur = tbx_aff.Text.IndexOf(unchar);
                }
            }

            if (operateur == -1)
            {
                if (tbx_aff.Text.IndexOf(',') == -1)
                { 
                BtnNum_Click(sender, e);
                }
            } else
            {
                if (tbx_aff.Text != "")
                { 
                if (tbx_aff.Text[tbx_aff.Text.Length-1] != '+' && tbx_aff.Text[tbx_aff.Text.Length - 1] != '-' && tbx_aff.Text[tbx_aff.Text.Length - 1] != '*' && tbx_aff.Text[tbx_aff.Text.Length - 1] != '/')
                {
                }
                    string reste = tbx_aff.Text.Substring(operateur);
                if (reste.IndexOf(',') == -1)
                {
                    BtnNum_Click(sender, e);
                }
                }
            }
        }

    }
}
