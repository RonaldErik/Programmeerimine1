using System.ComponentModel.DataAnnotations;

namespace KooliProjekt.Data
{
    public class InvoiceLine
    {
        public int Id {  get; set; }

        [Required]
        [StringLength(50)]
        public string LineItem { get; set; }

        [Required]
        [StringLength(7)]
        public string Unit {  get; set; }

        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }
        public decimal Total { get; set; }

    }
}
