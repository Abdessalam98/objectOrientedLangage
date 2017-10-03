using System;

namespace dotnetc {

    class Enums {
        // Cartes
        enum Cartes { As, Valet, Roi, Dix, Dame, Neuf, Huit, Sept };
 enum Couleurs { Noir, Rouge, Bleu, Vert };
 // Jours
 enum Jours { Lundi, Mardi, Mercredi, Jeudi, Vendredi, Samedi, Dimanche };

 // Récupérer la valeur
 Jours L = Jours.Lundi;
 Jours M = Jours.Mardi;

 int x = (int) Jours.Mercredi;
 int y = (int) Jours.Vendredi;

    }
}