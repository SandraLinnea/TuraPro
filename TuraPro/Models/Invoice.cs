using System.ComponentModel.DataAnnotations;

namespace TuraPro.Models
{
    public enum InvoiceStatus
    {
        Draft,
        Sent,
        Paid
    }

    public class Invoice
    {
        public int Id { get; set; }

        public string InvoiceNumber { get; set; } = string.Empty;

        [Required]
        public Customer Customer { get; set; } = new();

        public List<InvoiceItem> Items { get; set; } = new();

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public DateTime DueDate { get; set; } = DateTime.Now.AddDays(30);

        public InvoiceStatus Status { get; set; } = InvoiceStatus.Draft;

        public decimal Subtotal => Items.Sum(i => i.Quantity * i.Price);

        public decimal TotalVat => Items.Sum(i => i.VatAmount);

        public decimal Total => Subtotal + TotalVat;
    }
}