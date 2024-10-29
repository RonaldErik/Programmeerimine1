using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Description { get; set; }

        public decimal CurrentPrice { get; set; }

        public string ImagePath { get; set; }

    }
}
