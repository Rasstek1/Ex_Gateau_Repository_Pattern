namespace Ex_Gateau_Repository_Pattern.Models
{
    public interface IIngredientRepository
    {
        IEnumerable<Ingredient> Ingredients { get; }

        void AjouterIngredient(Ingredient ingredient);

        void SupprimerIngredient(int id);

        void ModifierIngredient(Ingredient ingredient);

        Gateau GetIngredient(int id);
    }
}
