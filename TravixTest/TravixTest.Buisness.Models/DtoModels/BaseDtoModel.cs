using System.ComponentModel.DataAnnotations;

namespace Epam.TravixTest.Buisness.Models.DtoModels
{
    public class BaseDtoModel
    {
        [Required]
        public int Id { get; set; }
    }
}
