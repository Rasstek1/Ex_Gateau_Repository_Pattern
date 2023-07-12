namespace Ex_Gateau_Repository_Pattern.Models
{
    public interface IIngredientsRepository
    {
        IEnumerable<Ingredient> Ingredients { get; }

        void AjouterIngredient(Ingredient ingredients);

        void SupprimerIngredient(int id);

        void ModifierIngredient(Ingredient ingredients);

        Gateau GetIngredient(int id);
    }
}
