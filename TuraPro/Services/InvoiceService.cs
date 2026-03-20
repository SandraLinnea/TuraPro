using TuraPro.Models;

namespace TuraPro.Services;

public sealed class InvoiceService
{
    public Invoice CreateDraft()
    {
        return new Invoice
        {
            InvoiceNumber = $"UTK-{DateTime.Now:yyyyMMdd}",
            Customer = new Customer(),
            Items =
            {
                new InvoiceItem
                {
                    Description = "Konsulttjanst",
                    Quantity = 1,
                    Price = 1250,
                    VatRate = 25
                }
            }
        };
    }
}
