namespace QuestPdfTest.ConsoleApp.Models;
public sealed class InvoiceItem
{
    public string Name { get; set; } = default!;
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public decimal Total => Price * Quantity;
}
