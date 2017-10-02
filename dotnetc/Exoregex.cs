using System;

//Directives for regex
using System.Text;
using System.Text.RegularExpressions;
namespace dotnetc {

    class ExoRegex {

        // Vérifier si une chaine contient un nombbre au début
        public void StringNb (string s) {
            Regex test = new Regex ("^[0-9]");
            if (test.Match (s).Success)
                Console.WriteLine ("True");
            else
                Console.WriteLine ("False");

        }
        // Tester si une chaine contient des espaces si oui la renvoyer sans
        public void StringEsc (string str) {
            Regex test1 = new Regex (@"[^\S$]");
            if (test1.Match (str).Success) {
                string nwStr = test1.Replace (str, "");
                Console.WriteLine (nwStr);
            } else
                Console.WriteLine ("False");
        }
        // Tester si un numéro de téléphone est au format français
        public void CheckNbFr (string telephone) {
            Regex tel = new Regex (@"(\+33|0033)[1-9][0-9]{8}");
            if (tel.Match(telephone).Success) {
                Console.WriteLine ("Numéro valide");
            } else
                Console.WriteLine ("Invalide. Réessayez");
        }
        // Test email version simple 
        public void CheckEmail(string email) {
            Regex tEmail = new Regex(@"([\w\-.]+@[\w\-.]+)");
            if (tEmail.Match(email).Success) {
                Console.WriteLine ("Email valide");
            } else
                Console.WriteLine ("Invalide. Réessayez");
        }

    }
}