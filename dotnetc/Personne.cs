using System;
namespace dotnetc {
    class Personne {
        public static int NbPersonnes;
        private static int compteur;
        private string nom, prenom;
        private int age;

        // Accesseur mutateur Nom
        public string Nom {
            get {
                return nom;
            }
            set {
                nom = value;
            }
        }
        // Accesseur mutateur Prenom
        public string Prenom {
            get {
                return prenom;
            }
            set {
                prenom = value;
            }
        }
        // Accesseur mutateur Age
        public int Age {
            get {
                return age;
            }
            set {
                age = value;
            }
        }
        // Methode pour recuperer le nombre de personnes
        public static int Compteur {
            get {
                return compteur;
            }
        }

        public Personne () {
            compteur = ++compteur + NbPersonnes;
        }
    }

}