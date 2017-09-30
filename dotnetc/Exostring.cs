using System;
namespace dotnetc {

    class ExoString {

        // Compteur occurences d'une lettre 
        public int CompteurDeA (string s) {
            string[] t = s.Split ("a");
            int NbA = t.Length - 1;
            return NbA;
        }
        // Sbstr points d'une chaine de caratères
        public void SbstrPoint (string txt) {
            string[] split = txt.Split (".");
            string nvTxt = String.Join ("", split);
            Console.WriteLine (nvTxt);
        }

        // Compteur de voyelles et de consonnes

        public void VowCons (string str) {
            int CountVowels = 0;
            for (int i = 0; i < str.Length; i++) {
                if (str[i] == 'A' || str[i] == 'a' || str[i] == 'E' || str[i] == 'e' || str[i] == 'O' || str[i] == 'o' || str[i] == 'I' || str[i] == 'i' || str[i] == 'U' || str[i] == 'u' || str[i] == 'Y' || str[i] == 'y') {
                    CountVowels++;
                }
            }
            int CountCons = str.Length - CountVowels;
            Console.WriteLine ("Voyelles: " + CountVowels +"\nConsonnes: "+ CountCons);

        }
        // Fonction for string

        public void SomeString (string stmt) {
            string[] asplit =stmt.Split(" ");
            string fchar=stmt[0].ToString().ToUpper();
            string nwstmt = (fchar+stmt.Substring(1)+".").Replace(","," , ");
            Console.WriteLine(nwstmt);
        }

    }

}