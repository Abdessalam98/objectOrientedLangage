using System;

namespace dotnetSys {
    class Program {
        static void Main (string[] args) {
            Stream test = new Stream ();
            test.GetValue ();
            test.Write ();
            // test.CountChar ("a");
            //test.CreerDossierAvecFichiers ();
        }
    }
}