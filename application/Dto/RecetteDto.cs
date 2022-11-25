using Data.Model;

namespace Application.DTO
{
    public class RecetteDto
    {
        public RecetteDto()
        {
        }

        public int RecetteId { get; set; }
        public string TitreRecette { get; set; }
        public string? DescriptionRecette { get; set; }
        public DateOnly DateRecette { get; set; }

        public int CategorieId { get; set; }
        public Categorie categorie { get; set; }
    }
}