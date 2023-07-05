using Ex_Gateau_Repository_Pattern.Models;

namespace Ex_Gateau_Repository_Pattern.Models
{
    public static class InitialiseurBD
    {
        public static List<Gateau> _gateau = new List<Gateau>
        {
            new Gateau
            {
                Id = 1,
                Nom = "Cheesecake new-yorkais au limoncello",
                UrlImage = "Gateau1.jpg",
                Description = "Le cheesecake new-yorkais au limoncello est un gâteau au fromage blanc, citron et limoncello. Un dessert frais et léger, idéal pour terminer un repas copieux.",
                /*Ingredients = "Biscuits,Beurre fondu,Fromage blanc,Œufs,Sucre,Extrait de vanille,Limoncello,Zeste de citron"*/
                Ingredients = new List<Ingredients>()
            },

            new Gateau
            {
                Id = 2,
                Nom = "Gâteau au fromage",
                UrlImage = "Gateau2.jpg",
                Description = "Le gâteau au fromage est un dessert à base de fromage frais, d'œufs, de sucre et de crème fraîche, sur une croûte de biscuits émiettés.",
                /*Ingredients = "Biscuits,Beurre fondu,Fromage frais,Œufs,Sucre,Crème fraîche"*/
                Ingredients = new List<Ingredients>()
            },


            new Gateau
            {
                Id = 3,
                Nom = "Gâteau à la vanille dans une tasse",
                UrlImage = "Gateau3.jpg",
                Description = "Le gâteau à la vanille dans une tasse est un gâteau cuit au micro-ondes dans une tasse. Un dessert rapide et facile à préparer, idéal pour les petites faims.",
                /*Ingredients = "Farine,Sucre,Levure chimique,Œuf,Beurre fondu,Lait,Vanille liquide",*/
                Ingredients = new List<Ingredients>()
            },


            new Gateau
            {
                Id = 4,
                Nom = "Nuage de fruits",
                UrlImage = "Gateau4.jpg",
                Description = "Le nuage de fruits est un gâteau à base de fruits rouges, fruits jaunes, fruits verts, œufs, sucre, beurre fondu et farine.",
                /*Ingredients = "Fruits rouges,Fruits jaunes,Fruits verts,Œufs,Sucre,Beurre fondu,Farine",*/
                Ingredients = new List<Ingredients>()
            },

            new Gateau
            {
                Id = 5,
                Nom = "Scones à la courge, à la sauge et au cheddar",
                UrlImage = "Gateau5.jpg",
                Description = "Les scones à la courge, à la sauge et au cheddar sont des petits pains à base de courge, sauge, cheddar, farine, levure, beurre, lait, œuf, sel et poivre.",
                /*Ingredients = "Courge,Sauge,Cheddar,Farine,Levure,Beurre,Lait,Œuf,Sel,Poivre",*/
                Ingredients = new List<Ingredients>()
            },
            new Gateau
            {
                Id = 6,
                Nom = "Clafoutis aux petits fruits",
                UrlImage = "Gateau6.jpg",
                Description = "Le clafoutis aux petits fruits est un gâteau à base de fruits rouges, œufs, sucre, farine, lait, beurre, vanille et sel.",
                /*Ingredients = "Fruits rouges,Œufs,Sucre,Farine,Lait,Beurre,Vanille,Sel",*/
                Ingredients = new List<Ingredients>()
            }


        };
        // Dictionnaire dont les clés sont les noms de gâteaux 
        // et dont les valeurs sont les objets Gateau. 
        // Je m'en sert pour faire référence à un gâteau dans un ingrédient.
        private static Dictionary<string, Gateau> _NomGateauDict;

        // Propriété publique pour accéder au dictionnaire des gâteaux par nom
        public static Dictionary<string, Gateau> NomGateauDict
        {
            get
            {
                // Vérifie si le dictionnaire a déjà été initialisé
                if (_NomGateauDict == null)
                {
                    // Si le dictionnaire est null, il n'a pas encore été créé, donc nous le créons maintenant
                    _NomGateauDict = new Dictionary<string, Gateau>();

                    // Parcours de la liste des gâteaux pour ajouter chaque gâteau au dictionnaire
                    foreach (Gateau gateau in _gateau)
                    {
                        // Ajoute le gâteau au dictionnaire en utilisant son nom comme clé
                        _NomGateauDict.Add(gateau.Nom, gateau);
                    }
                }

                // Retourne une copie du dictionnaire pour éviter les modifications accidentelles
                return new Dictionary<string, Gateau>(_NomGateauDict);
            }


        }

        public static List<Ingredients> _ingredients = new List<Ingredients>
        {
                 new Ingredients
                    {
                        Nom = "Biscuit",
                        Type = "Type d'ingredient",
                        Quantite = 10,
                        Unite = "g",
                        Prix = 2.99,
                        Gateau = NomGateauDict["Cheesecake new-yorkais au limoncello"]
                    },

                     new Ingredients
                    {
                        Nom = "Beurre Fondu",
                        Type = "Type d'ingredient",
                        Quantite = 100,
                        Unite = "g",
                        Prix = 1.50,
                        Gateau = NomGateauDict["Cheesecake new-yorkais au limoncello"]
                    },

                    new Ingredients
                    {
                        Nom = "Fromage blanc",
                        Type = "Type d'ingredient",
                        Quantite = 50,
                        Unite = "g",
                        Prix = 2.00,
                        Gateau = NomGateauDict["Cheesecake new-yorkais au limoncello"]
                    },

                    new Ingredients
                    {
                        Nom = "Oeufs",
                        Type = "Type d'ingredient",
                        Quantite = 2,
                        Unite = "Quantite",
                        Prix = 0.50,
                        Gateau = NomGateauDict["Cheesecake new-yorkais au limoncello"]
                    },

                    new Ingredients
                    {
                        Nom = "sucre",
                        Type = "Type d'ingredient",
                        Quantite = 150,
                        Unite = "g",
                        Prix = 2.00,
                        Gateau = NomGateauDict["Cheesecake new-yorkais au limoncello"]
                    },

                    new Ingredients
                    {
                        Nom = "Extrait de vanille",
                        Type = "Type d'ingredient",
                        Quantite = 1,
                        Unite = "Cuillere a table",
                        Prix = 0.25,
                        Gateau = NomGateauDict["Cheesecake new-yorkais au limoncello"]
                    },

                    new Ingredients
                    {
                        Nom = "Limoncello",
                        Type = "Type d'ingredient",
                        Quantite = 50,
                        Unite = "g",
                        Prix = 0.35,
                        Gateau  = NomGateauDict["Cheesecake new-yorkais au limoncello"]
                    },

                    new Ingredients
                    {
                        Nom = "Zeste de citron",
                        Type = "Type d'ingredient",
                        Quantite = 1,
                        Unite = "Au gout",
                        Prix = 0.50,
                        Gateau = NomGateauDict["Cheesecake new-yorkais au limoncello"]
                    },

                    new Ingredients
                    {
                        Nom = "Biscuit",
                        Type = "Type d'ingredient",
                        Quantite = 6,
                        Unite = "Unite",
                        Prix = 1.00,
                        Gateau = NomGateauDict["Gâteau au fromage"]
                    },

                    new Ingredients
                    {
                        Nom = "Beurre fondu",
                        Type = "Type d'ingredient",
                        Quantite = 1,
                        Unite = "Cuillere a the",
                        Prix = 0.60,
                        Gateau = NomGateauDict["Gâteau au fromage"]
                    },

                    new Ingredients
                    {
                        Nom = "Fromage frais",
                        Type = "Type d'ingredient",
                        Quantite = 200,
                        Unite = "g",
                        Prix = 2.00,
                        Gateau = NomGateauDict["Gâteau au fromage"]
                    },

                    new Ingredients
                    {
                        Nom = "Oeufs",
                        Type = "Type d'ingredient",
                        Quantite = 2,
                        Unite = "Quantite",
                        Prix = 0.50,
                        Gateau = NomGateauDict["Gâteau au fromage"]
                    },

                    new Ingredients
                    {
                        Nom = "sucre",
                        Type = "Type d'ingredient",
                        Quantite = 150,
                        Unite = "g",
                        Prix = 2.00,
                        Gateau = NomGateauDict["Gâteau au fromage"]
                    },

                    new Ingredients
                    {
                        Nom = "Creme fraiche",
                        Type = "Type d'ingredient",
                        Quantite = 3,
                        Unite = "Cuillere a soupe",
                        Prix = 1.25,
                        Gateau = NomGateauDict["Gâteau au fromage"]
                    },

               
                    new Ingredients
                    {
                        Nom = "Farine",
                        Type = "Type d'ingredient",
                        Quantite = 150,
                        Unite = "g",
                        Prix = 2.00,
                        Gateau = NomGateauDict["Gâteau à la vanille dans une tasse"]
                    },

                    new Ingredients
                    {
                        Nom = "Sucre",
                        Type = "Type d'ingredient",
                        Quantite = 50,
                        Unite = "g",
                        Prix = 1.00,
                        Gateau = NomGateauDict["Gâteau à la vanille dans une tasse"]
                    },

                    new Ingredients
                    {
                        Nom = "Levure chimique",
                        Type = "Type d'ingredient",
                        Quantite = 1,
                        Unite = "Cuillere a the",
                        Prix = 0.50,
                        Gateau = NomGateauDict["Gâteau à la vanille dans une tasse"]
                    },

                    new Ingredients
                    {
                        Nom = "Oeufs",
                        Type = "Type d'ingredient",
                        Quantite = 1,
                        Unite = "Quantite",
                        Prix = 0.25,
                        Gateau = NomGateauDict["Gâteau à la vanille dans une tasse"]
                    },

                    new Ingredients
                    {
                        Nom = "Beurre fondu",
                        Type = "Type d'ingredient",
                        Quantite = 50,
                        Unite = "g",
                        Prix = 1.00,
                        Gateau = NomGateauDict["Gâteau à la vanille dans une tasse"]
                    },

                    new Ingredients
                    {
                        Nom = "Lait",
                        Type = "Type d'ingredient",
                        Quantite = 50,
                        Unite = "g",
                        Prix = 0.50,
                        Gateau = NomGateauDict["Gâteau à la vanille dans une tasse"]
                    },

                    new Ingredients
                    {
                        Nom = "Vanille liquide",
                        Type = "Type d'ingredient",
                        Quantite = 1,
                        Unite = "Cuillere a the",
                        Prix = 0.25,
                        Gateau = NomGateauDict["Gâteau à la vanille dans une tasse"]
                    }, 

                    new Ingredients
                    {
                        Nom = "Fruits rouges",
                        Type = "Type d'ingredient",
                        Quantite = 100,
                        Unite = "g",
                        Prix = 1.00,
                        Gateau = NomGateauDict["Nuage de fruits"]
                    },

                    new Ingredients
                    {
                        Nom = "Fruits jaunes",
                        Type = "Type d'ingredient",
                        Quantite = 100,
                        Unite = "g",
                        Prix = 1.00,
                        Gateau = NomGateauDict["Nuage de fruits"]
                    },

                    new Ingredients
                    {
                        Nom = "Fruits verts",
                        Type = "Type d'ingredient",
                        Quantite = 100,
                        Unite = "g",
                        Prix = 1.00,
                        Gateau = NomGateauDict["Nuage de fruits"]
                    },

                    new Ingredients
                    {
                        Nom = "Oeufs",
                        Type = "Type d'ingredient",
                        Quantite = 2,
                        Unite = "Quantite",
                        Prix = 0.50,
                        Gateau = NomGateauDict["Nuage de fruits"]
                    },

                    new Ingredients
                    {
                        Nom = "Sucre",
                        Type = "Type d'ingredient",
                        Quantite = 100,
                        Unite = "g",
                        Prix = 2.00,
                        Gateau = NomGateauDict["Nuage de fruits"]
                    },

                    new Ingredients
                    {
                        Nom = "Beurre fondu",
                        Type = "Type d'ingredient",
                        Quantite = 50,
                        Unite = "g",
                        Prix = 1.00,
                        Gateau = NomGateauDict["Nuage de fruits"]
                    },

                    new Ingredients
                    {
                        Nom = "Farine",
                        Type = "Type d'ingredient",
                        Quantite = 100,
                        Unite = "g",
                        Prix = 2.00,
                        Gateau = NomGateauDict["Nuage de fruits"]
                    },

                    new Ingredients
                    {
                        Nom = "Courge",
                        Type = "Type d'ingredient",
                        Quantite = 100,
                        Unite = "g",
                        Prix = 1.00,
                        Gateau = NomGateauDict["Scones à la courge, à la sauge et au cheddar"]
                    },

                    new Ingredients
                    {
                        Nom = "Sauge",
                        Type = "Type d'ingredient",
                        Quantite = 1,
                        Unite = "Cuillere a soupe",
                        Prix = 0.50,
                        Gateau = NomGateauDict["Scones à la courge, à la sauge et au cheddar"]
                    },

                    new Ingredients
                    {
                        Nom = "Cheddar",
                        Type = "Type d'ingredient",
                        Quantite = 100,
                        Unite = "g",
                        Prix = 2.00,
                        Gateau = NomGateauDict["Scones à la courge, à la sauge et au cheddar"]
                    },

                    new Ingredients
                    {
                        Nom = "Farine",
                        Type = "Type d'ingredient",
                        Quantite = 150,
                        Unite = "g",
                        Prix = 2.00,
                        Gateau = NomGateauDict["Scones à la courge, à la sauge et au cheddar"]
                    },

                    new Ingredients
                    {
                        Nom = "Levure",
                        Type = "Type d'ingredient",
                        Quantite = 1,
                        Unite = "Cuillere a soupe",
                        Prix = 0.50,
                        Gateau = NomGateauDict["Scones à la courge, à la sauge et au cheddar"]
                    },
                    new Ingredients
                    {
                        Nom = "Beurre",
                        Type = "Type d'ingredient",
                        Quantite = 50,
                        Unite = "g",
                        Prix = 1.00,
                        Gateau = NomGateauDict["Scones à la courge, à la sauge et au cheddar"]
                    },

                    new Ingredients
                    {
                        Nom = "Lait",
                        Type = "Type d'ingredient",
                        Quantite = 50,
                        Unite = "g",
                        Prix = 0.50,
                        Gateau = NomGateauDict["Scones à la courge, à la sauge et au cheddar"]
                    },

                    new Ingredients
                    {
                        Nom = "Oeufs",
                        Type = "Type d'ingredient",
                        Quantite = 1,
                        Unite = "Quantite",
                        Prix = 0.25,
                        Gateau = NomGateauDict["Scones à la courge, à la sauge et au cheddar"]
                    },

                    new Ingredients
                    {
                        Nom = "Sel",
                        Type = "Type d'ingredient",
                        Quantite = 1,
                        Unite = "Cuillere a soupe",
                        Prix = 0.25,
                        Gateau = NomGateauDict["Scones à la courge, à la sauge et au cheddar"]
                    },

                    new Ingredients
                    {
                        Nom = "Poivre",
                        Type = "Type d'ingredient",
                        Quantite = 1,
                        Unite = "Cuillere a soupe",
                        Prix = 0.25,
                        Gateau = NomGateauDict["Scones à la courge, à la sauge et au cheddar"]
                    },

                    new Ingredients
                    {
                        Nom = "Fruits rouges",
                        Type = "Type d'ingredient",
                        Quantite = 100,
                        Unite = "g",
                        Prix = 1.00,
                        Gateau = NomGateauDict["Clafoutis aux petits fruits"]
                    },

                    new Ingredients
                    {
                        Nom = "Oeufs",
                        Type = "Type d'ingredient",
                        Quantite = 2,
                        Unite = "Quantite",
                        Prix = 0.50,
                        Gateau = NomGateauDict["Clafoutis aux petits fruits"]
                    },

                    new Ingredients
                    {
                        Nom = "Sucre",
                        Type = "Type d'ingredient",
                        Quantite = 100,
                        Unite = "g",
                        Prix = 2.00,
                        Gateau = NomGateauDict["Clafoutis aux petits fruits"]
                    },

                    new Ingredients
                    {
                        Nom = "Farine",
                        Type = "Type d'ingredient",
                        Quantite = 100,
                        Unite = "g",
                        Prix = 2.00,
                        Gateau = NomGateauDict["Clafoutis aux petits fruits"]
                    },

                    new Ingredients
                    {
                        Nom = "Lait",
                        Type = "Type d'ingredient",
                        Quantite = 50,
                        Unite = "g",
                        Prix = 0.50,
                        Gateau = NomGateauDict["Clafoutis aux petits fruits"]
                    },

                    new Ingredients
                    {
                        Nom = "Beurre",
                        Type = "Type d'ingredient",
                        Quantite = 50,
                        Unite = "g",
                        Prix = 1.00,
                        Gateau = NomGateauDict["Clafoutis aux petits fruits"]
                    },

                    new Ingredients
                    {
                        Nom = "Vanille",
                        Type = "Type d'ingredient",
                        Quantite = 1,
                        Unite = "Cuillere a soupe",
                        Prix = 0.50,
                        Gateau = NomGateauDict["Clafoutis aux petits fruits"]
                    },

                    new Ingredients
                    {
                        Nom = "Sel",
                        Type = "Type d'ingredient",
                        Quantite = 1,
                        Unite = "Cuillere a soupe",
                        Prix = 0.25,
                        Gateau = NomGateauDict["Clafoutis aux petits fruits"]
                    }
                    //


        };
    }
}





