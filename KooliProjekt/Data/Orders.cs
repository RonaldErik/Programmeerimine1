using KooliProjekt.Data;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class Orders
    {
        public int Id { get; set; }
        public decimal Product_Current_Prices { get; set; }

        [Required]
        public List<int> ProductId { get; set; } = new List<int>(); 
    }
}
