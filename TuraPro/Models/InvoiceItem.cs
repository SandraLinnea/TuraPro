using System.ComponentModel.DataAnnotations;

namespace TuraPro.Models
{
    public class InvoiceItem
    {
        public int Id { get; set; }

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Antal måste vara minst 1")]
        public int Quantity { get; set; } = 1;

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Pris måste vara större än 0")]
        public decimal Price { get; set; }

        [Range(0, 100, ErrorMessage = "Moms måste vara mellan 0 och 100%")]
        public decimal VatRate { get; set; } = 25;

        public decimal VatAmount => (Quantity * Price) * (VatRate / 100);

        public decimal Total => Quantity * Price + VatAmount;
    }
}