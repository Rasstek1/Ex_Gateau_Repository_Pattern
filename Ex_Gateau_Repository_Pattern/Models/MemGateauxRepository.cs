namespace Ex_Gateau_Repository_Pattern.Models
{
    public class MemGateauxRepository : IGateauRepository//Class qui implémente l'interface IGateauRepository
    {
        public IEnumerable<Gateau> MesGateaux => new List<Gateau>()
        {
            new Gateau
            {
                Id = 1,
                Nom = "Cheesecake new-yorkais au limoncello",
                UrlImage = "img/Cheesecake-new-yorkais-au-limoncello.jpg",
                Description = "Le cheesecake new-yorkais au limoncello est un gâteau au fromage blanc, citron et limoncello. Un dessert frais et léger, idéal pour terminer un repas copieux.",
                Ingredients = "Biscuits,Beurre fondu,Fromage blanc,Œufs,Sucre,Extrait de vanille,Limoncello,Zeste de citron"
            },

            new Gateau
            {
                Id = 2,
                Nom = "Gâteau au fromage",
                UrlImage = "img/gateau-au-fromage.jpg",
                Description = "Le gâteau au fromage est un dessert à base de fromage frais, d'œufs, de sucre et de crème fraîche, sur une croûte de biscuits émiettés.",
                Ingredients = "Biscuits,Beurre fondu,Fromage frais,Œufs,Sucre,Crème fraîche"
            },

            new Gateau
            {
                Id = 3,
                Nom = "Gâteau à la vanille dans une tasse",
                UrlImage = "img/gateau-a-la-vanille-dans-une-tasse.webp",
                Description = "Le gâteau à la vanille dans une tasse est un gâteau cuit au micro-ondes dans une tasse. Un dessert rapide et facile à préparer, idéal pour les petites faims.",
                Ingredients = "Farine,Sucre,Levure chimique,Œuf,Beurre fondu,Lait,Vanille liquide",
            },

            new Gateau
            {
                Id = 4,
                Nom = "Nuage de fruits",
                UrlImage = "img/nuage-de-fruits.webp",
                Description = "Le nuage de fruits est un gâteau à base de fruits rouges, fruits jaunes, fruits verts, œufs, sucre, beurre fondu et farine.",
                Ingredients = "Fruits rouges,Fruits jaunes,Fruits verts,Œufs,Sucre,Beurre fondu,Farine",
            },

            new Gateau
            {
                Id = 5,
                Nom = "Scones à la courge, à la sauge et au cheddar",
                UrlImage = "img/scones-a-la-courge-a-la-sauge-et-au-cheddar.jpg",
                Description = "Les scones à la courge, à la sauge et au cheddar sont des petits pains à base de courge, sauge, cheddar, farine, levure, beurre, lait, œuf, sel et poivre.",
                Ingredients = "Courge,Sauge,Cheddar,Farine,Levure,Beurre,Lait,Œuf,Sel,Poivre",
            },

            new Gateau
            { Id = 6,
              Nom = "Clafoutis aux petits fruits",
              UrlImage = "img/clafoutis-aux-petits-fruits.jpg",
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
            return MesGateaux.FirstOrDefault(g => g.Id == gateauId);
        }


    }
}
