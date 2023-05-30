namespace Ex_Gateau_Repository_Pattern.Models
{
    public class MemGateauxRepository : IGateauRepository//Class qui implémente l'interface IGateauRepository
    {
        //si new List<Gateau>() avait un parametre(int param) il faudrai le mettre a l'initialisation de builder.Services.AddSingleton<IGateauRepository, MemGateauxRepository>();
        //dans program.cs et ca ressemblerait a builder.Services.AddSingleton<IGateauRepository, MemGateauxRepository>(param);
        public List<Gateau> MesGateaux => new List<Gateau>()
        {
            new Gateau
            {
                Id = 1,
                Nom = "Cheesecake new-yorkais au limoncello",
                UrlImage = "Gateau1.jpg",
                Description = "Le cheesecake new-yorkais au limoncello est un gâteau au fromage blanc, citron et limoncello. Un dessert frais et léger, idéal pour terminer un repas copieux.",
                Ingredients = "Biscuits,Beurre fondu,Fromage blanc,Œufs,Sucre,Extrait de vanille,Limoncello,Zeste de citron"
            },

            new Gateau
            {
                Id = 2,
                Nom = "Gâteau au fromage",
                UrlImage = "Gateau2.jpg",
                Description = "Le gâteau au fromage est un dessert à base de fromage frais, d'œufs, de sucre et de crème fraîche, sur une croûte de biscuits émiettés.",
                Ingredients = "Biscuits,Beurre fondu,Fromage frais,Œufs,Sucre,Crème fraîche"
            },

            new Gateau
            {
                Id = 3,
                Nom = "Gâteau à la vanille dans une tasse",
                UrlImage = "Gateau3.jpg",
                Description = "Le gâteau à la vanille dans une tasse est un gâteau cuit au micro-ondes dans une tasse. Un dessert rapide et facile à préparer, idéal pour les petites faims.",
                Ingredients = "Farine,Sucre,Levure chimique,Œuf,Beurre fondu,Lait,Vanille liquide",
            },

            new Gateau
            {
                Id = 4,
                Nom = "Nuage de fruits",
                UrlImage = "Gateau4.jpg",
                Description = "Le nuage de fruits est un gâteau à base de fruits rouges, fruits jaunes, fruits verts, œufs, sucre, beurre fondu et farine.",
                Ingredients = "Fruits rouges,Fruits jaunes,Fruits verts,Œufs,Sucre,Beurre fondu,Farine",
            },

            new Gateau
            {
                Id = 5,
                Nom = "Scones à la courge, à la sauge et au cheddar",
                UrlImage = "Gateau5.jpg",
                Description = "Les scones à la courge, à la sauge et au cheddar sont des petits pains à base de courge, sauge, cheddar, farine, levure, beurre, lait, œuf, sel et poivre.",
                Ingredients = "Courge,Sauge,Cheddar,Farine,Levure,Beurre,Lait,Œuf,Sel,Poivre",
            },

            new Gateau
            {
              Id = 6,
              Nom = "Clafoutis aux petits fruits",
              UrlImage = "Gateau6.jpg",
              Description = "Le clafoutis aux petits fruits est un gâteau à base de fruits rouges, œufs, sucre, farine, lait, beurre, vanille et sel.",
              Ingredients = "Fruits rouges,Œufs,Sucre,Farine,Lait,Beurre,Vanille,Sel",
            }




        };

        /// <summary>
        /// Méthode qui cherche et retourne un gâteau 
        /// ayant l'identifiant gateauId
        /// </summary>
        /// <param name="gateauId">L'identifiant du gâteau</param>
        /// <returns>Le gâteau avec l'identifiant gateauId</returns>
        public Gateau GetGateau(int gateauId)
        {
            return MesGateaux.FirstOrDefault(g => g.Id == gateauId) ?? null;
        }

        /// <summary>
        /// Méthode qui ajoute un gâteau à la liste MesGateaux. La methode Add () est une methode de la classe List<> alors je vais 
        /// devoir changer le type de MesGateaux en List<> pour pouvoir utiliser la methode Add() au lieu de IEnumerable<Gateau>. dans MesGateaux
        /// je vais le changer pour List<Gateau> et je vais changer le return de la methode GetGateau() pour qu'il retourne une List<Gateau> au lieu de IEnumerable<Gateau>
        /// </summary>
        /// <param name="gateau"></param>
        public void AjouterGateau(Gateau gateau)
        {
            MesGateaux.Add(gateau);
        }


        /// <summary>
        /// Dans cet exemple, nous vérifions d'abord si la liste MesGateaux contient déjà des éléments en utilisant la méthode Any().
        /// Si c'est le cas, nous utilisons la méthode Max() pour obtenir le plus grand ID parmi les gâteaux existants. 
        /// Sinon, nous fixons la valeur de lastId à 0.
        /// </summary>
        /// <returns></returns>
        public int GetNewId()
        {
            int lastId = MesGateaux.Any() ? MesGateaux.Max(g => g.Id) : 0;
            return lastId + 1;
        }
    }
}
