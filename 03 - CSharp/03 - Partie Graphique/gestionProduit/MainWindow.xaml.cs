using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
        private string path = "../../bdd.json";

        private List<Produits> produits;

        public MainWindow()
        {
            InitializeComponent();
            produits = RecupDonnees();
            InitGrid();
        }


            
        public void InitGrid()
        {
            dgProduits.ItemsSource = produits;
        }


        // SI LISTE VIDE
        //private List<Produits> CreerListe(string path)
        //{
        //    List<Produits> produits = new List<Produits>();

        //    for (int i = 0; i < 10; i++)
        //    {
        //        Produits prod = new Produits(i, "Libelle" + i, "Catégorie " + i % 2, "rayon");
        //        produits.Add(prod);
        //    }
        //    EcrireFichier(path, JsonConvert.SerializeObject(produits, Formatting.Indented)); 
        //    return produits;
        //}


        private void EcrireFichier(string path, string tab)
        {
            File.WriteAllText(path, tab);
        }

        private string LireFichier()
        // Renvoi un tableau de chaine contenant les informations stockées dans le fichier 
        {
            string chaine = "";
            try
            {
                // Lecture et stockage dans chaine
                chaine = File.ReadAllText(path);
            }
            catch (Exception e)
            {
                Console.WriteLine("Une exception s'est produite : " + e.Message);
                Console.WriteLine("Indiquer le path :");
                path = Console.ReadLine();
            }
            return chaine;
        }

        private List<Produits> RecupDonnees()
        {
            string chaine = LireFichier();
            List<Produits> produits = JsonConvert.DeserializeObject<List<Produits>>(chaine);
            return produits;
        }




    }
}
