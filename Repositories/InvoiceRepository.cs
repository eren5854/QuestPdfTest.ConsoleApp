using QuestPDF.Helpers;
using QuestPdfTest.ConsoleApp.Models;

namespace QuestPdfTest.ConsoleApp.Repositories;
public sealed class InvoiceRepository : IInvoiceRepository
{
    private static Random Random = new();

    public Invoice GetInvoice()
    {
        Company company = new()
        {
            Address = "123 Main St",
            Logo = @"F:\Eren\Foto Ve Video\Eren Logo\Eren-Logo.jpg",
            RNC = "123-45678-9",
        };

        var invoiceItems = Enumerable.Range(1, 30)
            .Select(x => new InvoiceItem
            {
                Name = Placeholders.Label(),
                Quantity = Random.Next(1, 10),
                Price = (decimal)Math.Round(Random.NextDouble() * 100, 2)
            }).ToList();

        var invoice = new Invoice
        {
            Id = Guid.NewGuid(),
            TaxReceipt = "E123456789",
            ExpirationSequence = DateTime.Now.AddDays(30),
            Company = company,
            EmissionDate = DateTime.Today,
            ClientName = "Eren Delibaş",
            InvoiceItems = invoiceItems
        };

        return invoice;
    }
}
