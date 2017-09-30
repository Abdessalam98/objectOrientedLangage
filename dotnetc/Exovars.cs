using System;

namespace dotnetc {

    class ExoVars {
        //Permutation de deux valeurs
        public void ChangeVars (int a, int b) {
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine ("Nouvelle valeur de a:" + a + "\nNouvelle valeur de b:" + b);
        }

        // Perimetre d'un cercle 
        public void Perim (double r) {
            double pr = 2 * Math.PI * r;
            Console.WriteLine ("Le perimetre est: " + pr);
        }

        // Calcul somme des 10 premiers entiers

        public void SommeDix (int count) {
            int somme = 0;
            for (int i = 0; i < count; i++) {
                somme += 1;
            }
            Console.WriteLine (somme);
        }

        // Calcul de Factorielle 

        public void Fact (int nb) {
            int facto = 1;
            for (int i = 1; i <= nb; i++) {
                facto *= i;
            }

            Console.WriteLine (facto);
        }

        // Calcul Fibonacci 

        public int Fibo (int indice) {
            int a = 0;
            int b = 1;
            int somme = 0;
            if (indice == 0) return 0;
            if (indice == 1) return 1;
            for (int i = 2; i <= indice; i++) {
                somme = a + b;
                a = b;
                b = somme;
            }
            return somme;

        }

        //Calcul Armstrong 

        public void Armstrong1 (int nbArm) {

            int remainder, sum = 0;

            for (int i = nbArm; i > 0; i = i / 10) {
                remainder = i % 10;
                sum = sum + remainder * remainder * remainder;
            }
            if (sum == nbArm) {
                Console.WriteLine ("C'est bon");
            } else {
                Console.WriteLine ("C'est pas bon");
            }

        }
        public void Armstrong2 (int nbArm2) {

            int somme = 0, tst, temp;
            temp = nbArm2;
            while (nbArm2 > 0) {
                tst = nbArm2 % 10;
                nbArm2 = nbArm2 / 10;
                somme = somme + (tst * tst * tst);
            }
            if (temp == somme)
                Console.WriteLine ("C'est bon");
            else
                Console.WriteLine ("C'est pas bon");
        }
    }
}