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

namespace gestionProduit
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitGrid();
        }

        public void  InitGrid()
        {
            dgProduits.ItemsSource = CreerListe();
        }


        private List<Produits> CreerListe()
        {
            List<Produits> produits = new List<Produits>();

            for (int i = 0; i < 10; i++)
            {
                Produits prod = new Produits(i, "Libelle" + i, "Catégorie " + i % 2, "rayon");
                produits.Add(prod);
            }

            return produits;
        }


        //private void Resize()
        //{
        //                foreach (DataGridColumn colonne in dgProduits.Columns)
        //    {
        //        colonne.Width = 1;
        //    }
        //}
    }
}
