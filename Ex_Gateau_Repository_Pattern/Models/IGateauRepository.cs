using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Collections.Generic;
using Ex_Gateau_Repository_Pattern.Models;

namespace Ex_Gateau_Repository_Pattern.Models
{
    public interface IGateauRepository
    {
        IEnumerable<Gateau> MesGateaux { get; }// propriété qui retourne une liste de gateaux
        //IEnumerable est une interface qui permet de parcourir une collection, Une Liste, un tableau, un dictionnaire, etc.
        Gateau GetGateau(int id);
    }
    /// <summary>
    /// Pourquoi utilisons-nous une interface? Cette interface nous donne la possibilité
    /// d'avoir plusieurs classes qui implémentent les méthodes différemment 
    /// (voir prochain point). Ceci nous donne plus de flexibilité dans notre application
    /// </summary>
    // 
    //  Implémentation de l'interface : Nous devons avoir au moins une classe qui implémente
    //  les méthodes de l'interface créée à l'étape précédente. La première classe est souvent
    //  une classe contenant des données codées en dure (hard coded) servant de données de tests,
    //  avant de créer une classe qui exploite la base de données (ce que nous verrons dans les prochaines semaines).
    //  Ces données sont des données stockées en mémoire lors de l'exécution du programme. Par convention,
    //  nous utiliserons le format suivant pour nommer une telle classe :

    //  MemNomModeleRepository

    //  NomModele étant le nom du modèle de données(défini à l'étape précédente(IGateauRepository)).
    //  Mem est pour Mémoire, pour dire que les données sont en mémoire.
    //  Créer une classe (--> MemGateauxRepository) qui implémente l’interface IGateauRepository, y mettre quelques données et implémenter la méthode GetGateau:

}
