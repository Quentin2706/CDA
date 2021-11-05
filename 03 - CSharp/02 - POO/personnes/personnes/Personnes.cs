using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personnes
{
    class Personnes
    {
        // Attributs
        private string nom;
        private string prenom;
        private int age;
        private string adresse;

        //Constructeurs
        public Personnes()
        {

        }

        
        public Personnes(string nom, string prenom, int age, string adresse)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.adresse = adresse;
        }

        // Accesseurs

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public int Age { get; set; }

        public string Adresse { get; set; }



        override public string ToString()
        {
            return this.Nom + " " + this.Prenom + " " + this.Age + " " + this.Adresse;
        }


    }
}
