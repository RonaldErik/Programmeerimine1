using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Product_Category
    {
        public int Id { get; set; }
        [Required]
        [StringLength(25)]

        [DisplayName("Category")]
        public string Cat_Name { get; set; }
    }
}
