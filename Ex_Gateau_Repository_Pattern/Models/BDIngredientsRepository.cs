using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Ex_Gateau_Repository_Pattern.Models
{
    public class BDIngredientsRepository : IIngredientsRepository
    {
        private readonly GateauDbContext _gateauDbContext;

        public BDIngredientsRepository(GateauDbContext gateauDbContext)
        {
            _gateauDbContext = gateauDbContext;
        }

        public IEnumerable<Ingredients> Ingredients
        {
            get { return _gateauDbContext.Ingredients.Include(i => i.Gateau).OrderByDescending(i => i.Type).ToList(); }
        }



        public Ingredients GetIngredient(int ingredientId)
        {
            return _gateauDbContext.Ingredients.FirstOrDefault(i => i.Id == ingredientId);
        }

        void IIngredientsRepository.AjouterIngredient(Ingredients ingredient)
        {
            _gateauDbContext.Ingredients.Add(ingredient);
            _gateauDbContext.SaveChanges();
        }

        void IIngredientsRepository.SupprimerIngredient(int id)
        {
            var ingredient = _gateauDbContext.Ingredients.FirstOrDefault(i => i.Id == id);
            if (ingredient != null)
            {
                _gateauDbContext.Ingredients.Remove(ingredient);
                _gateauDbContext.SaveChanges();
            }
        }

        void IIngredientsRepository.ModifierIngredient(Ingredients ingredient)
        {
            _gateauDbContext.Ingredients.Update(ingredient);
            _gateauDbContext.SaveChanges();
        }

        Gateau IIngredientsRepository.GetIngredient(int id)
        {
            throw new NotImplementedException();
        }
    }
}
