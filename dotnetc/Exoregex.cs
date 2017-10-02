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

    }
}