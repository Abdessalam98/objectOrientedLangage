using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace dotnetSys {

    class Stream {
        public int x;
        public int count = 0;
        public string[] letters = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
        public string[] texts = new string[] { "avion", "dictionnaire", "train", "ordinateur", "souris", "cable", "clavier", "feuille", "stylo" };
        public void GetValue () {
            Console.WriteLine ("Donnez la valeur de X");
            x = int.Parse (Console.ReadLine ());

        }
        #region Lecture et ecriture de fichiers

        // Ecrire dans un fichier texte
        public void Write () {
            while (count < x) {
                Console.WriteLine ("Ecrivez");
                count++;
                string entered = Console.ReadLine ();
                using (StreamWriter outputFile = File.AppendText ("/home/abdessalam/Bureau/today.txt")) {
                    outputFile.WriteLine (entered, true);
                }
            }

        }

        // compter le nombre d'un caractere dans un texte
        public void CountChar (string c) {
            try {
                StreamReader reader = new StreamReader ("/home/abdessalam/Bureau/test.txt");
                string text;
                while ((text = reader.ReadLine ()) != null) {
                    Console.WriteLine (text);
                    // string[] t = text.Split (c);
                    // int NbLetter = t.Length - 1;
                    // Console.WriteLine (NbLetter);
                    int Nbletter = text.Split (c).Length - 1;
                    Console.WriteLine (Nbletter);

                }
            } catch (Exception e) {
                Console.WriteLine ("Le fichier ne peut pas etre lu :");
                Console.WriteLine (e.Message);
            }

        }
        #endregion

        #region Manipulation de fichiers et dossiers

        public void CreerDossierAvecFichiers () {

            Random rnd = new Random ();
            //Regex test si ça commence par un a
            Regex rgx = new Regex ("^[A-a].*txt$");
            DirectoryInfo dossier = new DirectoryInfo ("/home/abdessalam/Bureau/DossierInitial");

            // je teste si le dossier existe

            if (dossier.Exists) {
                Console.WriteLine ("Le dossier existe");
                return;
            } else {
                dossier.Create ();
                Console.WriteLine ("Le dossier a été crée avec succes");
            }

            for (int i = 0; i < 10; i++) {
                foreach (string letter in letters) {
                    using (StreamWriter outputFile = new StreamWriter ("/home/abdessalam/Bureau/DossierInitial/" + letter + ".txt")) {
                        outputFile.WriteLine (texts[rnd.Next (texts.Length)], true);
                    }
                }

            }
            Console.WriteLine ("Les fichiers aléatoires ont été crées avec succes");
            // Remettere le contenu à zero des fichiers commençant par a
            FileInfo[] files = dossier.GetFiles ();
            foreach (FileInfo f in files) {
                if (rgx.Match (f.Name).Success) {
                    Console.WriteLine (f.Name);
                    using (StreamWriter strWrite = new StreamWriter (f.DirectoryName + "/" + f.Name)) {
                        strWrite.WriteLine ("");
                    }
                }
            }

        }
        #endregion
    }
}