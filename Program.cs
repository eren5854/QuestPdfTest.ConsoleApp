﻿
using QuestPDF.Companion;
using QuestPdfTest.ConsoleApp;
using QuestPdfTest.ConsoleApp.Repositories;

QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;

var invoiceRepository = new InvoiceRepository();
var invoice = invoiceRepository.GetInvoice();

//var document = new InvoiceDocument(invoice);

var document = new ResumeDocument();

document.ShowInCompanion();

Console.WriteLine("Hello, World!");
