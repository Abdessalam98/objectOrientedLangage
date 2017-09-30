using System;

// directive
using System.Collections.Generic;
namespace dotnetc {

    class ExoTabs {
        // Créer un tableau de 10 cases avec la valeur de 0
        public void CreateArray (int nbVal) {
            int[] tab = new int[nbVal];
            for (int i = 0; i < tab.Length; i++) {
                tab[i] = 0;

            }
        }

        // Créer un tableau de 10 cases rempli avec les valeurs de ses indices 

        public void CreateArray1 (int nbVal1) {
            int[] tab1 = new int[nbVal1];
            for (int i = 0; i < tab1.Length; i++) {
                tab1[i] = i;
                Console.WriteLine (tab1[i]);
            }
        }

        // Créer un tableau de 10 cases rempli avec des valeurs aléatoires 
        public void CreateArray2 (int nbVal2, int min, int max) {
            int temp;
            int[] tab2 = new int[nbVal2];
            Random random = new Random ();
            for (int i = 0; i < tab2.Length; i++) {
                tab2[i] = random.Next (min, max); //valeur comprise entre 0  et 10 (min,max)
            }

            // Déplacer le tableau dans une liste et Sort()
            /*var tst = new List<int> ();
            tst.AddRange (tab2);
            tst.Sort ();
            foreach (var val in tst) {
                Console.WriteLine ("   {0}", val);
            }*/

            //Tri
            for (int k = 0; k < tab2.Length; ++k) {
                for (int j = 1; j < tab2.Length - k; ++j) {
                    if (tab2[j - 1] > tab2[j]) {
                        temp = tab2[j - 1];
                        tab2[j - 1] = tab2[j];
                        tab2[j] = temp;
                    }
                }
            }
            // Vérification
            for (int y = 0; y < tab2.Length; y++) {
                Console.WriteLine (tab2[y]);
            }

        }
    }

}