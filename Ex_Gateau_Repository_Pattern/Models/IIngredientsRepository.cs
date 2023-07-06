namespace Ex_Gateau_Repository_Pattern.Models
{
    public interface IIngredientsRepository
    {
        IEnumerable<Ingredients> Ingredients { get; }

        void AjouterIngredient(Ingredients ingredients);

        void SupprimerIngredient(int id);

        void ModifierIngredient(Ingredients ingredients);

        Gateau GetIngredient(int id);
    }
}
