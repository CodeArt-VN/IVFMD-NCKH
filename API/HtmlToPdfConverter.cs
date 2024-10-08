﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using Syncfusion.HtmlConverter;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Parsing;

namespace API
{
    public static class NckhHtmlToPdfConverter
    {
        private static readonly string QtBinariesPath = @"QtBinaries";
        private static readonly string cssPath = "~/content/style/nckh-form-template.min.css";
        private static readonly string emptyLayoutPath = "~/content/formtemplate/EmptyLayout.html";

        private static float ConvertToViewPort(float height)
        {
            return height / 1.28F;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="bodyHtml"></param>
        /// <param name="headerHtml"></param>
        /// <param name="footerHtml"></param>
        /// <param name="headerHeight"></param>
        /// <param name="footerHeight"></param>
        /// <param name="firstPageHeader"></param>
        /// <returns></returns>
        public static string HtmlToPdf(string filePath, string bodyHtml, string headerHtml, string footerHtml, int headerHeight = 96, int footerHeight = 96, bool firstPageHeader = false)
        {
            string css = "";
            string html = "";
            using (System.IO.StreamReader r = new System.IO.StreamReader(System.Web.Hosting.HostingEnvironment.MapPath(cssPath)))
            {
                css = r.ReadToEnd();
            }
            using (System.IO.StreamReader r = new System.IO.StreamReader(System.Web.Hosting.HostingEnvironment.MapPath(emptyLayoutPath)))
            {
                html = r.ReadToEnd().Replace("[[CSS]]", css);
            }

            PdfDocument document = new PdfDocument();
            document.PageSettings.Size = PdfPageSize.A4;
            document.PageSettings.SetMargins(0);


            //Initialize HTML to PDF converter
            var htmlConverter = new HtmlToPdfConverter(HtmlRenderingEngine.WebKit);
            //Create new settings
            var setting = CreateConverterSetting();
            var pdfHeader = HeaderHTMLtoPDF(html.Replace("[[HTML]]", headerHtml), headerHeight);
            var pdfFooter = FooterHTMLtoPDF(html.Replace("[[HTML]]", footerHtml), footerHeight);
            setting.PdfPageSize = new SizeF(PdfPageSize.A4.Width, PdfPageSize.A4.Height - pdfHeader.Height - pdfFooter.Height);

            htmlConverter.ConverterSettings = setting;
            //Convert to PDF
            var body = html.Replace("[[HTML]]", bodyHtml);
            PdfDocument docBody = htmlConverter.Convert(body, string.Empty);
            Stream stream = new MemoryStream();
            docBody.Save(stream);
            docBody.Close();
            PdfLoadedDocument pdfLoadedDocument = new PdfLoadedDocument(stream);
            for (int i = 0; i < pdfLoadedDocument.Pages.Count; i++)
            {
                PdfLoadedPage loadedPage = pdfLoadedDocument.Pages[i] as PdfLoadedPage;
                PdfTemplate template = loadedPage.CreateTemplate();
                PdfSection section = document.Sections.Add();
                PdfPage page = section.Pages.Add();
                PdfGraphics graphics = page.Graphics;
                if (i == 0)
                {
                    section.Template.Top = pdfHeader;
                    section.Template.Bottom = FooterHTMLtoPDF(html.Replace("[[HTML]]", footerHtml?.Replace("[[Page]]", "1")?.Replace("[[TotalPage]]", pdfLoadedDocument.Pages.Count.ToString())), footerHeight);
                }
                else
                {
                    if (firstPageHeader)
                    {
                        section.Template.Top = HeaderHTMLtoPDF(html.Replace("[[HTML]]", string.Empty), headerHeight);
                    }
                    else
                    {
                        section.Template.Top = HeaderHTMLtoPDF(html.Replace("[[HTML]]", headerHtml), headerHeight);
                    }
                    section.Template.Bottom = FooterHTMLtoPDF(html.Replace("[[HTML]]", footerHtml?.Replace("[[Page]]", (i + 1).ToString())?.Replace("[[TotalPage]]", pdfLoadedDocument.Pages.Count.ToString())), footerHeight);
                }
                graphics.DrawPdfTemplate(template, new PointF(0, pdfHeader.Height), new SizeF(page.Size.Width, page.Size.Height - pdfHeader.Height - pdfFooter.Height));
            }

            //Save the document
            document.Save(filePath);
            document.Close();
            stream.Dispose();
            filePath = filePath.Replace("~", "");
            return filePath;
        }

        private static IHtmlConverterSettings CreateConverterSetting(float height = 0)
        {
            var setting = new WebKitConverterSettings();
            if (height > 0)
            {
                setting.PdfPageSize = new System.Drawing.SizeF(PdfPageSize.A4.Width, height);
                setting.Orientation = PdfPageOrientation.Landscape;
            }
            setting.EnableRepeatTableHeader = true;
            setting.EnableRepeatTableFooter = true;
            setting.EnableHyperLink = true;
            setting.SplitTextLines = false;
            setting.SplitImages = false;
            setting.MediaType = MediaType.Print;
            setting.WebKitPath = HttpContext.Current.Server.MapPath("/" + QtBinariesPath);
            setting.WebKitViewPort = new System.Drawing.Size(800, 0);
            return setting;
        }

        private static PdfPageTemplateElement HeaderHTMLtoPDF(string htmlString, float height)
        {
            var vpHeight = ConvertToViewPort(height);
            var htmlConverter = new HtmlToPdfConverter(HtmlRenderingEngine.WebKit);
            htmlConverter.ConverterSettings = CreateConverterSetting(vpHeight);
            //Convert Html to PDF
            PdfDocument document = htmlConverter.Convert(htmlString, string.Empty);
            System.Drawing.RectangleF bounds = new System.Drawing.RectangleF(0, 0, document.Pages[0].GetClientSize().Width, vpHeight);
            PdfPageTemplateElement header = new PdfPageTemplateElement(bounds);
            header.Graphics.DrawPdfTemplate(document.Pages[0].CreateTemplate(), bounds.Location, bounds.Size);
            return header;
        }

        private static PdfPageTemplateElement FooterHTMLtoPDF(string htmlString, float height)
        {
            var vpHeight = ConvertToViewPort(height);
            HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter(HtmlRenderingEngine.WebKit);
            htmlConverter.ConverterSettings = CreateConverterSetting(vpHeight);
            //Convert Html to PDF
            PdfDocument document = htmlConverter.Convert(htmlString, string.Empty);
            System.Drawing.RectangleF bounds = new System.Drawing.RectangleF(0, 0, document.Pages[0].GetClientSize().Width, vpHeight);
            PdfPageTemplateElement footer = new PdfPageTemplateElement(bounds);
            footer.Graphics.DrawPdfTemplate(document.Pages[0].CreateTemplate(), bounds.Location, bounds.Size);
            return footer;
        }
    }
}