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

        public List<Ingredients> Ingredients
        {
            get { return _gateauDbContext.Ingredients.Include(i => i.Gateau).OrderByDescending(i => i.Type).ToList(); }
        }

        public Ingredients GetIngredient(int ingredientId)
        {
            return _gateauDbContext.Ingredients.FirstOrDefault(i => i.Id == ingredientId);
        }
    }
}
