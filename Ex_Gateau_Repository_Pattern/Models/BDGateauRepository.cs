namespace Ex_Gateau_Repository_Pattern.Models
{
    public class BDGateauRepository : IGateauRepository
    {
        // Ajoutez un constructeur qui accepte un GateauDbContext
        private readonly GateauDbContext _gateauDbContext;

        public BDGateauRepository(GateauDbContext gateauDbContext)
        {
            _gateauDbContext = gateauDbContext;
           
        }

        // Ajoutez une propriété MesGateaux qui retourne la liste des gâteaux
        public IEnumerable<Gateau> MesGateaux
        {
            get
            {
                return _gateauDbContext.Gateaux.OrderBy(g => g.Nom).ToList();

            }
        }

        // Ajoutez une méthode GetGateau qui retourne un gâteau
        public Gateau GetGateau(int id)
        {
            return _gateauDbContext.Gateaux.FirstOrDefault(g => g.Id == id);
        }

        // Ajoutez une méthode AjouterGateau qui ajoute un gâteau
        public void AjouterGateau(Gateau gateau)
        {
            _gateauDbContext.Gateaux.Add(gateau);
            _gateauDbContext.Ingredients.AddRange(gateau.Ingredients);
            _gateauDbContext.SaveChanges();
        }

        // Ajoutez une méthode SupprimerGateau qui supprime un gâteau
        public void SupprimerGateau(int id)
        {
            var gateau = _gateauDbContext.Gateaux.FirstOrDefault(g => g.Id == id);
            if (gateau != null)
            {
                _gateauDbContext.Gateaux.Remove(gateau);
                _gateauDbContext.SaveChanges();
            }
        }

        // Ajoutez une méthode ModifierGateau qui modifie un gâteau
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
