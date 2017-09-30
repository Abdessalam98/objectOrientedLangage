using System;
namespace dotnetc {

    class ExoString {

        public int CompteurDeA (string s) {
            string[] t = s.Split ("a");
            int NbA = t.Length - 1;
            return NbA;
        }
    }

}