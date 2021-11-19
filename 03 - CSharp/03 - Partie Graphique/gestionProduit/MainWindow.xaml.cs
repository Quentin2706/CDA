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
                //Console.WriteLine("Indiquer le path :");
                //path = Console.ReadLine();
                Application.Current.Shutdown();
            }
            return chaine;
        }

        private List<Produits> RecupDonnees()
        {
            string chaine = LireFichier();
            List<Produits> produits = JsonConvert.DeserializeObject<List<Produits>>(chaine);
            return produits;
        }

        private void ButtonAction_Click(object sender, RoutedEventArgs e)
        {
            Produits p = new Produits();
            if((string)((Button)sender).Content != "Ajouter")
            {
                p = (Produits) dgProduits.SelectedItem;
            }

            action action = new action((string)((Button)sender).Content, this, p);
            this.Opacity = 0.7;

            action.ShowDialog();
            this.Opacity = 1;

        }

        public void RefreshDataGrid()
        {
            dgProduits.Items.Refresh();
        }

        public void AjouterProduit(Produits p)
        {
            produits.Add(p);
            RefreshDataGrid();
            EcrireFichier(path, JsonConvert.SerializeObject(produits, Formatting.Indented));
        }

        public void ModifierProduit(Produits p)
        {
            int index = produits.FindIndex(x => x.IdProduit == p.IdProduit);
            produits[index] = p;
            RefreshDataGrid();
        }

        public void SupprimerProduit(Produits p)
        {
            int index = produits.FindIndex(x => x.IdProduit == p.IdProduit);
            produits.RemoveAt(index);
            RefreshDataGrid();
        }
        
    }
}
