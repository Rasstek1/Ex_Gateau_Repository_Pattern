using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Ex_Gateau_Repository_Pattern.Models
{
    public class BDIngredientRepository : IIngredientRepository
    {
        private readonly GateauDbContext _gateauDbContext;

        public BDIngredientRepository(GateauDbContext gateauDbContext)
        {
            _gateauDbContext = gateauDbContext;
        }

        public IEnumerable<Ingredient> Ingredients
        {
            get { return _gateauDbContext.Ingredients.Include(i => i.Gateau).OrderByDescending(i => i.Type).ToList(); }
        }



        public Ingredient GetIngredient(int ingredientId)
        {
            return _gateauDbContext.Ingredients.FirstOrDefault(i => i.Id == ingredientId);
        }

        void IIngredientRepository.AjouterIngredient(Ingredient ingredient)
        {
            _gateauDbContext.Ingredients.Add(ingredient);
            _gateauDbContext.SaveChanges();
        }

        void IIngredientRepository.SupprimerIngredient(int id)
        {
            var ingredient = _gateauDbContext.Ingredients.FirstOrDefault(i => i.Id == id);
            if (ingredient != null)
            {
                _gateauDbContext.Ingredients.Remove(ingredient);
                _gateauDbContext.SaveChanges();
            }
        }

        void IIngredientRepository.ModifierIngredient(Ingredient ingredient)
        {
            _gateauDbContext.Ingredients.Update(ingredient);
            _gateauDbContext.SaveChanges();
        }

        Gateau IIngredientRepository.GetIngredient(int id)
        {
            throw new NotImplementedException();
        }
    }
}
