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

namespace gestionProduit
{
    /// <summary>
    /// Logique d'interaction pour action.xaml
    /// </summary>
    public partial class action : Window
    {
        private MainWindow laWindow;
        private string actionARealiser;
        public Produits produit { get; set; }
        public action(string titreAction,MainWindow window, Produits p)
        {
            InitializeComponent();
            this.produit = p;            
            this.laWindow = window;
            this.actionARealiser = titreAction;
            InitWindow(titreAction);

            
        }

        private void InitWindow(string senderContent)
        {
            labTitre.Content = senderContent;
            btnAction.Content = senderContent;

            switch(senderContent)
            {
                case "Modifier":
                    tbxIdProduit.Text = this.produit.IdProduit;
                    tbxLibelleProduit.Text = this.produit.LibelleProduit;
                    tbxCategorie.Text = this.produit.Categorie;
                    tbxRayon.Text = this.produit.Rayon;
                    break;

                case "Supprimer":
                    tbxIdProduit.Text = this.produit.IdProduit;
                    tbxLibelleProduit.Text = this.produit.LibelleProduit;
                    tbxCategorie.Text = this.produit.Categorie;
                    tbxRayon.Text = this.produit.Rayon;
                    tbxIdProduit.IsEnabled = false;
                    tbxLibelleProduit.IsEnabled = false;
                    tbxCategorie.IsEnabled = false;
                    tbxRayon.IsEnabled = false;
                    break;
                default:
                    break;
            }

        }


        private void btnRetour_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAction_Click(object sender, RoutedEventArgs e)
        {

            switch (actionARealiser)
            {
                case "Ajouter":
                    produit.IdProduit = tbxIdProduit.Text;
                    produit.LibelleProduit = tbxLibelleProduit.Text;
                    produit.Categorie = tbxCategorie.Text;
                    produit.Rayon = tbxRayon.Text;
                    this.laWindow.AjouterProduit(this.produit);
                    break;
                case "Modifier":
                    produit.IdProduit = tbxIdProduit.Text;
                    produit.LibelleProduit = tbxLibelleProduit.Text;
                    produit.Categorie = tbxCategorie.Text;
                    produit.Rayon = tbxRayon.Text;

                    this.laWindow.ModifierProduit(this.produit);
                    this.Close();                    break;
                case "Supprimer":
                    tbxIdProduit.Text = this.produit.IdProduit;
                    tbxLibelleProduit.Text = this.produit.LibelleProduit;
                    tbxCategorie.Text = this.produit.Categorie;
                    tbxRayon.Text = this.produit.Rayon;
                    

                    this.laWindow.SupprimerProduit(this.produit);
                    break;
                default:
                    break;

            }
            this.Close();
        }
    }
}
