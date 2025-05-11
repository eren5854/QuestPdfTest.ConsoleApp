namespace QuestPdfTest.ConsoleApp.Models;
public sealed class Invoice
{
    public Guid Id { get; set; }
    public string TaxReceipt { get; set; } = default!;
    public DateTime ExpirationSequence { get; set; }
    public Company Company { get; set; } = default!;
    public DateTime EmissionDate { get; set; }
    public string ClientName { get; set; } = default!;

    public IEnumerable<InvoiceItem> InvoiceItems { get; set; } = default!;
    public decimal Total => InvoiceItems.Sum(x => x.Total);

}
