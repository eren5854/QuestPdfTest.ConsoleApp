using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Data.Common;

namespace QuestPdfTest.ConsoleApp
{
    public class ResumeDocument : IDocument
    {
        public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Margin(10);

                page.Content()
                    .Row(row =>
                    {
                        // Sol sütun (1/3)
                        row.RelativeColumn(1) // Sol sütun (1/3)
                             .Background("#f8f9fa")
                             .Padding(15)
                             .Column(column =>
                             {
                                 // Fotoğraf
                                 column.Item().AlignCenter().AlignMiddle().Width(100).Image("F:\\Eren\\Foto Ve Video\\Eren Logo\\Eren-Logo.jpg");

                                 column.Item().PaddingTop(20).AlignCenter().AlignMiddle().Text("Hakkımda").FontSize(24).Bold().FontColor("#2563eb");
                                 column.Item().PaddingVertical(10).LineHorizontal(2).LineColor("#e2e8f0");
                                 column.Item().PaddingTop(10).Text("Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.").AlignCenter().FontSize(12);


                                 column.Item().PaddingTop(20).AlignCenter().AlignMiddle().Text("Bağlantılar").FontSize(24).Bold().FontColor("#2563eb");
                                 column.Item().PaddingVertical(10).LineHorizontal(2).LineColor("#e2e8f0");
                                 column.Item()
                                 .PaddingTop(10)
                                 .Hyperlink("https://www.linkedin.com/in/ihsan-eren-deliba%C5%9F-208581159/")
                                 .Row(colrow =>
                                 {
                                     colrow.ConstantItem(20)
                                         .Width(16)
                                         .Height(16)
                                         .Svg("<svg xmlns=\"http://www.w3.org/2000/svg\" width=\"16\" height=\"16\" fill=\"#2563eb\" class=\"bi bi-linkedin\" viewBox=\"0 0 16 16\">\r\n  <path d=\"M0 1.146C0 .513.526 0 1.175 0h13.65C15.474 0 16 .513 16 1.146v13.708c0 .633-.526 1.146-1.175 1.146H1.175C.526 16 0 15.487 0 14.854zm4.943 12.248V6.169H2.542v7.225zm-1.2-8.212c.837 0 1.358-.554 1.358-1.248-.015-.709-.52-1.248-1.342-1.248S2.4 3.226 2.4 3.934c0 .694.521 1.248 1.327 1.248zm4.908 8.212V9.359c0-.216.016-.432.08-.586.173-.431.568-.878 1.232-.878.869 0 1.216.662 1.216 1.634v3.865h2.401V9.25c0-2.22-1.184-3.252-2.764-3.252-1.274 0-1.845.7-2.165 1.193v.025h-.016l.016-.025V6.169h-2.4c.03.678 0 7.225 0 7.225z\"/>\r\n</svg>");

                                     colrow.RelativeItem()
                                         .PaddingLeft(5)
                                         .AlignMiddle()
                                         .Text("Linkedin")
                                         .FontSize(12);
                                 });
                                 column.Item()
                                 .PaddingTop(10)
                                 .Hyperlink("https://github.com/eren5854")
                                 .Row(colrow =>
                                 {
                                     colrow.ConstantItem(20)
                                         .Width(16)
                                         .Height(16)
                                         .Svg("<svg xmlns=\"http://www.w3.org/2000/svg\" width=\"16\" height=\"16\" fill=\"#2563eb\" class=\"bi bi-github\" viewBox=\"0 0 16 16\">\r\n  <path d=\"M8 0C3.58 0 0 3.58 0 8c0 3.54 2.29 6.53 5.47 7.59.4.07.55-.17.55-.38 0-.19-.01-.82-.01-1.49-2.01.37-2.53-.49-2.69-.94-.09-.23-.48-.94-.82-1.13-.28-.15-.68-.52-.01-.53.63-.01 1.08.58 1.23.82.72 1.21 1.87.87 2.33.66.07-.52.28-.87.51-1.07-1.78-.2-3.64-.89-3.64-3.95 0-.87.31-1.59.82-2.15-.08-.2-.36-1.02.08-2.12 0 0 .67-.21 2.2.82.64-.18 1.32-.27 2-.27s1.36.09 2 .27c1.53-1.04 2.2-.82 2.2-.82.44 1.1.16 1.92.08 2.12.51.56.82 1.27.82 2.15 0 3.07-1.87 3.75-3.65 3.95.29.25.54.73.54 1.48 0 1.07-.01 1.93-.01 2.2 0 .21.15.46.55.38A8.01 8.01 0 0 0 16 8c0-4.42-3.58-8-8-8\"/>\r\n</svg>");

                                     colrow.RelativeItem()
                                         .PaddingLeft(5)
                                         .AlignMiddle()
                                         .Text("Github")
                                         .FontSize(12);
                                 });
                                 column.Item()
                                 .PaddingTop(10)
                                 .Hyperlink("https://linkstack.erendelibas.xyz/@eren")
                                 .Row(colrow =>
                                 {
                                     colrow.ConstantItem(20)
                                         .Width(16)
                                         .Height(16)
                                         .Svg("<svg xmlns=\"http://www.w3.org/2000/svg\" width=\"16\" height=\"16\" fill=\"#2563eb\" class=\"bi bi-link-45deg\" viewBox=\"0 0 16 16\">\r\n  <path d=\"M4.715 6.542 3.343 7.914a3 3 0 1 0 4.243 4.243l1.828-1.829A3 3 0 0 0 8.586 5.5L8 6.086a1 1 0 0 0-.154.199 2 2 0 0 1 .861 3.337L6.88 11.45a2 2 0 1 1-2.83-2.83l.793-.792a4 4 0 0 1-.128-1.287z\"/>\r\n  <path d=\"M6.586 4.672A3 3 0 0 0 7.414 9.5l.775-.776a2 2 0 0 1-.896-3.346L9.12 3.55a2 2 0 1 1 2.83 2.83l-.793.792c.112.42.155.855.128 1.287l1.372-1.372a3 3 0 1 0-4.243-4.243z\"/>\r\n</svg>");

                                     colrow.RelativeItem()
                                         .PaddingLeft(5)
                                         .AlignMiddle()
                                         .Text("Website")
                                         .FontSize(12);
                                 });


                                 column.Item().PaddingTop(20).AlignCenter().AlignMiddle().Text("Diller").FontSize(24).Bold().FontColor("#2563eb");
                                 column.Item().PaddingVertical(10).LineHorizontal(2).LineColor("#e2e8f0");
                                 column.Item().Text("İngilizce - İyi");
                                 column.Item().Text("Almanca - Orta");
                             });

                        // Sağ sütun (2/3)
                        row.RelativeColumn(2).Padding(20).Column(col =>
                        {
                            col.Item().PaddingTop(10).Text("İhsan Eren Delibaş").FontSize(30).Bold().FontFamily("Times New Roman");
                            col.Item().PaddingTop(10).Text("Full Stack Developer").FontSize(14).Italic();

                            col.Item().PaddingTop(10).Row(row =>
                            {
                                row.ConstantItem(20)
                                    .Width(16)
                                    .Height(16)
                                    .Svg("<svg viewBox='0 0 24 24' stroke='#2563eb' stroke-width='2' fill='none' stroke-linecap='round' stroke-linejoin='round' xmlns='http://www.w3.org/2000/svg'><path d='M21 10c0 7-9 13-9 13s-9-6-9-13a9 9 0 0 1 18 0z'></path><circle cx='12' cy='10' r='3'></circle></svg>");

                                row.RelativeItem()
                                    .PaddingLeft(5)
                                    .AlignMiddle()
                                    .Text("Adapazarı - Sakarya/Türkiye")
                                    .FontSize(12);
                            });

                            col.Item().PaddingTop(10).Row(row =>
                            {
                                row.ConstantItem(20)
                                    .Width(16)
                                    .Height(16)
                                    .Svg("<svg _ngcontent-ng-c1535313310=\"\" viewBox=\"0 0 24 24\" width=\"16\" height=\"16\" stroke=\"#2563eb\" stroke-width=\"2\" fill=\"none\" stroke-linecap=\"round\" stroke-linejoin=\"round\"><path _ngcontent-ng-c1535313310=\"\" d=\"M22 16.92v3a2 2 0 0 1-2.18 2 19.79 19.79 0 0 1-8.63-3.07 19.5 19.5 0 0 1-6-6 19.79 19.79 0 0 1-3.07-8.67A2 2 0 0 1 4.11 2h3a2 2 0 0 1 2 1.72 12.84 12.84 0 0 0 .7 2.81 2 2 0 0 1-.45 2.11L8.09 9.91a16 16 0 0 0 6 6l1.27-1.27a2 2 0 0 1 2.11-.45 12.84 12.84 0 0 0 2.81.7A2 2 0 0 1 22 16.92z\"></path></svg>");

                                row.RelativeItem()
                                    .PaddingLeft(5)
                                    .AlignMiddle()
                                    .Text("05347170568")
                                    .FontSize(12);
                            });

                            col.Item().PaddingTop(10).Row(row =>
                            {
                                row.ConstantItem(20)
                                    .Width(16)
                                    .Height(16)
                                    .Svg("<svg _ngcontent-ng-c1535313310=\"\" viewBox=\"0 0 24 24\" width=\"16\" height=\"16\" stroke=\"#2563eb\" stroke-width=\"2\" fill=\"none\" stroke-linecap=\"round\" stroke-linejoin=\"round\"><path _ngcontent-ng-c1535313310=\"\" d=\"M4 4h16c1.1 0 2 .9 2 2v12c0 1.1-.9 2-2 2H4c-1.1 0-2-.9-2-2V6c0-1.1.9-2 2-2z\"></path><polyline _ngcontent-ng-c1535313310=\"\" points=\"22,6 12,13 2,6\"></polyline></svg>");

                                row.RelativeItem()
                                    .PaddingLeft(5)
                                    .AlignMiddle()
                                    .Text("ihsanerendelibas@gmail.com")
                                    .FontSize(12);
                            });

                            col.Item().PaddingTop(20).Text("İş Deneyimi").FontSize(24).Bold().FontColor("#2563eb");
                            col.Item().PaddingVertical(10).LineHorizontal(2).LineColor("#e2e8f0");
                            JobExperience(col.Item(), "Şirket A", "Yazılım Geliştirici", "01.2020", "12.2022", "Projelerde görev aldı.");
                            JobExperience(col.Item(), "Şirket B", "Analist", "02.2018", "12.2019", "Analiz çalışmaları yaptı.");

                            col.Item().PaddingTop(20).Text("Eğitim").FontSize(24).Bold().FontColor("#2563eb");
                            col.Item().PaddingVertical(10).LineHorizontal(2).LineColor("#e2e8f0");
                            Education(col.Item(), "Üniversite X", "Bilgisayar Mühendisliği", "2014", "2018", "Lisans eğitimi.");

                            col.Item().PaddingTop(20).Text("Beceriler").FontSize(24).Bold().FontColor("#2563eb");
                            col.Item().PaddingVertical(10).LineHorizontal(2).LineColor("#e2e8f0");
                            Skill(col.Item(), "C#", 200);
                            Skill(col.Item(), "ASP.NET Core", 343);
                            Skill(col.Item(), "SQL", 200);
                        });
                    });
            });
        }

        private void JobExperience(QuestPDF.Infrastructure.IContainer container, string company, string position, string start, string end, string description)
        {
            container.PaddingBottom(10).Column(column =>
            {
                column.Item().Text($"{position} - {company}").Bold();
                column.Item().PaddingTop(4).Text($"{start} - {end}").FontSize(10).FontColor(Colors.Grey.Medium);
                column.Item().PaddingTop(4).Text(description).FontSize(11);
            });
        }

        private void Education(QuestPDF.Infrastructure.IContainer container, string school, string field, string start, string end, string description)
        {
            container.PaddingBottom(10).Column(column =>
            {
                column.Item().Text($"{school} - {field}").Bold();
                column.Item().PaddingTop(4).Text($"{start} - {end}").FontSize(10).FontColor(Colors.Grey.Medium);
                column.Item().PaddingTop(4).Text(description).FontSize(11);
            });
        }

        private void Skill(QuestPDF.Infrastructure.IContainer container, string skill, int level)
        {
            container.PaddingBottom(10).Column(column =>
            {
                column.Item().PaddingTop(4).Text(skill).FontSize(11).Bold();
                column.Item().PaddingTop(3).Height(5)
                    .Background(Colors.Grey.Lighten2)
                    .AlignLeft().Width(level)
                    .Background(Colors.Blue.Medium);
            });
        }
    }
}
