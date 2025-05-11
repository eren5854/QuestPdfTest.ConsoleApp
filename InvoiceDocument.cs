using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using QuestPdfTest.ConsoleApp.Models;

namespace QuestPdfTest.ConsoleApp;
internal class InvoiceDocument : IDocument
{
    public InvoiceDocument(Invoice invoice)
    {
        Invoice = invoice;
    }

    public Invoice Invoice { get; }

    public void Compose(IDocumentContainer container)
    {
        container.Page(page =>
        {
            page.Margin(50);
            page.Header()
                .Element(ComposeHeader);
        });
    }

    private void ComposeHeader(IContainer container)
    {
        container.Row(row =>
        {
            row.RelativeItem().Column(column =>
            {
                column.Item().Height(2, Unit.Centimetre).Image(Invoice.Company.Logo);
                var scale = 0.8f;
                column.Item().Scale(scale).Text(Invoice.Company.Address);
                column.Item().Scale(scale).Text($"RNC: {Invoice.Company.RNC}");
                column.Item().Text(" ");
                column.Item().Scale(scale).Text($"Date: {Invoice.EmissionDate.ToString("dd/MM/yyyy")}");
                column.Item().Text(" ");
                column.Item().Scale(scale).Text($"Client name: {Invoice.ClientName.ToUpper()}");

            });

            row.RelativeItem().Border(1).Column(column =>
            {
                var padding = 5;
                column.Item().BorderBottom(1).Padding(padding).Text("Elektrik Faturası").FontSize(20).SemiBold();
            });
        });
    }
}
