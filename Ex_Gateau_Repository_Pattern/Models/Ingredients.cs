namespace Ex_Gateau_Repository_Pattern.Models
{
    public class Ingredients
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public string? Type { get; set; }

        public float Quantite { get; set; }

        public string? Unite { get; set; }

        public double Prix { get; set; }

        public int GateauID { get; set; }

        public Gateau Gateau { get; set; }

    }
}
