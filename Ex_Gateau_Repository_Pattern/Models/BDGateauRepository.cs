namespace Ex_Gateau_Repository_Pattern.Models
{
    public class BDGateauRepository : IGateauRepository
    {
        private readonly GateauDbContext _gateauDbContext;

        public BDGateauRepository(GateauDbContext gateauDbContext)
        {
            _gateauDbContext = gateauDbContext;
           
        }

        public List<Gateau> MesGateaux
        {
            get
            {
                return _gateauDbContext.Gateaux.OrderBy(g => g.Nom).ToList();

            }
        }

        public Gateau GetGateau(int id)
        {
            return _gateauDbContext.Gateaux.FirstOrDefault(g => g.Id == id);
        }

        public void AjouterGateau(Gateau gateau)
        {
            _gateauDbContext.Gateaux.Add(gateau);
            _gateauDbContext.Ingredients.AddRange(gateau.Ingredients);
            _gateauDbContext.SaveChanges();
        }

        public void SupprimerGateau(int id)
        {
            var gateau = _gateauDbContext.Gateaux.FirstOrDefault(g => g.Id == id);
            if (gateau != null)
            {
                _gateauDbContext.Gateaux.Remove(gateau);
                _gateauDbContext.SaveChanges();
            }
        }

        public void ModifierGateau(Gateau gateau)
        {
            var gateauAModifier = _gateauDbContext.Gateaux.FirstOrDefault(g => g.Id == gateau.Id);
            if (gateauAModifier != null)
            {
                gateauAModifier.Nom = gateau.Nom;
                gateauAModifier.UrlImage = gateau.UrlImage;
                gateauAModifier.Description = gateau.Description;
                gateauAModifier.Ingredients = gateau.Ingredients;
                _gateauDbContext.SaveChanges();
            }
        }
    }
}
