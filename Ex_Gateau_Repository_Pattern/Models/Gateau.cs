using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;


namespace Ex_Gateau_Repository_Pattern.Models
{
    /// <summary>
    /// Ajoutez les annotations de validation appropriées dans la classe Gateau pour définir les règles
    /// de validation pour chaque propriété. Par exemple, vous pouvez utiliser les attributs Required pour spécifier
    /// que certaines propriétés sont obligatoires.
    /// </summary>
    public class Gateau
    {
        
        
            public int Id { get; set; }

            [Required(ErrorMessage = "Le nom du gâteau est requis.")]
            public string Nom { get; set; }

            [Required(ErrorMessage = "L'URL de l'image est requise.")]
            public string UrlImage { get; set; }

            [Required(ErrorMessage = "La description du gâteau est requise.")]
            public string Description { get; set; }

            [Required(ErrorMessage = "La liste des ingrédients est requise.")]
            public List<Ingredients> Ingredients { get; set; }

            public Gateau()
            {
                Ingredients = new List<Ingredients>();
            }
        
    }
}
