using QuestPDF.Fluent;
using QuestPDF.Helpers;
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
            page.Content().Element(ComposeContent);
            page.Footer().Element(ComposeFooter);
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
                column.Item().Padding(padding).Text($"Invoice ID: {Invoice.Id}");
                column.Item().Text(" ");
                column.Item().Padding(padding).Text($"Tax Receipt");
                column.Item().Padding(padding).Text(Invoice.TaxReceipt);
                column.Item().Text(" ");
                column.Item().Padding(padding).Text($"Expiration Sequence:");
                column.Item().Padding(padding).Text(Invoice.ExpirationSequence.ToString("dd/MM/yyyy"));


            });
        });
    }

    private void ComposeContent(IContainer container)
    {
        container.PaddingVertical(40).Column(column =>
        {
            column.Spacing(5);
            column.Item().Element(ComposeTable);

            column.Item().AlignRight().Text($"Grand Total: {Invoice.Total}");
        });
    }

    private void ComposeTable(IContainer container)
    {
        container.Table(table =>
        {
            table.ColumnsDefinition(columns =>
            {
                columns.RelativeColumn(2);
                columns.RelativeColumn();
                columns.RelativeColumn();
                columns.RelativeColumn();

            });

            table.Header(header =>
            {
                header.Cell().Element(CellStyling).Text("Description");
                header.Cell().Element(CellStyling).AlignRight().Text("Quantity");
                header.Cell().Element(CellStyling).AlignRight().Text("Price");
                header.Cell().Element(CellStyling).AlignRight().Text("Total");

                static IContainer CellStyling(IContainer container)
                {
                    return container
                        .DefaultTextStyle(x => x.SemiBold()).PaddingVertical(5).BorderBottom(1).BorderColor(Colors.Black);
                }
            });

            foreach (var item in Invoice.InvoiceItems)
            {
                table.Cell().Element(CellStyling).Text(item.Name);
                table.Cell().Element(CellStyling).AlignRight().Text(item.Quantity.ToString());
                table.Cell().Element(CellStyling).AlignRight().Text($"{item.Price:N}");
                table.Cell().Element(CellStyling).AlignRight().Text($"{item.Total:N}");


                static IContainer CellStyling(IContainer container)
                {
                    return container.BorderBottom(1).PaddingVertical(5).BorderColor(Colors.Grey.Lighten2);
                }
            }
        });
    }

    private void ComposeFooter(IContainer container)
    {
        container.AlignCenter().Text(x =>
        {
            x.CurrentPageNumber();
            x.Span(" / ");
            x.TotalPages();
        });

        //container.Row(row =>
        //{
        //    row.RelativeItem().AlignCenter().Text("Eren Delibaş").FontSize(10).Italic();
        //    row.RelativeItem().AlignRight().Text("Page 1 of 1").FontSize(10).Italic();
        //});
    }
}
