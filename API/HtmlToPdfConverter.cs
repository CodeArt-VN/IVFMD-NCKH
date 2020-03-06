using System;
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
        private static readonly string QtBinariesPath = @"../../QtBinaries";
        private static readonly string cssPath = "~/content/style/nckh-form-template.min.css";
        private static readonly string emptyLayoutPath = "~/content/formtemplate/EmptyLayout.html";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="bodyHtml"></param>
        /// <param name="headerHtml"></param>
        /// <param name="footerHtml"></param>
        /// <returns></returns>
        public static string HtmlToPdf(string filePath, string bodyHtml, string headerHtml, string footerHtml, bool firstPageHeader = false)
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
            var pdfHeader = HeaderHTMLtoPDF(html.Replace("[[HTML]]", headerHtml));
            var pdfFooter = FooterHTMLtoPDF(html.Replace("[[HTML]]", footerHtml));
            setting.PdfPageSize = new SizeF(PdfPageSize.A4.Width, PdfPageSize.A4.Height - pdfHeader.Height - pdfFooter.Height);

            htmlConverter.ConverterSettings = setting;
            //Convert to PDF
            PdfDocument docBody = htmlConverter.Convert(html.Replace("[[HTML]]", bodyHtml), string.Empty);
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
                    section.Template.Bottom = FooterHTMLtoPDF(html.Replace("[[HTML]]", footerHtml.Replace("[[Page]]", "1").Replace("[[TotalPage]]", pdfLoadedDocument.Pages.Count.ToString())));
                }
                else
                {
                    if (firstPageHeader)
                    {
                        section.Template.Top = HeaderHTMLtoPDF(html.Replace("[[HTML]]", string.Empty));
                    }
                    else
                    {
                        section.Template.Top = HeaderHTMLtoPDF(html.Replace("[[HTML]]", headerHtml));
                    }
                    section.Template.Bottom = FooterHTMLtoPDF(html.Replace("[[HTML]]", footerHtml.Replace("[[Page]]", (i + 1).ToString()).Replace("[[TotalPage]]", pdfLoadedDocument.Pages.Count.ToString())));
                }
                graphics.DrawPdfTemplate(template, new PointF(0, pdfHeader.Height), new SizeF(page.Size.Width, page.Size.Height - pdfHeader.Height - pdfFooter.Height));
            }

            //Save the document
            document.Save(filePath);
            document.Close();
            stream.Dispose();
            return filePath;
        }

        private static IHtmlConverterSettings CreateConverterSetting(bool setPageSize = false, float height = 0)
        {
            var settings = new WebKitConverterSettings();
            if (setPageSize)
            {
                settings.PdfPageSize = new System.Drawing.SizeF(PdfPageSize.A4.Width, height);
                settings.Orientation = PdfPageOrientation.Landscape;
            }
            settings.WebKitPath = QtBinariesPath;
            settings.WebKitViewPort = new System.Drawing.Size(1024, 0);
            return settings;
        }

        //Convert header HTML to PDF and get pdf page template element of the result
        private static PdfPageTemplateElement HeaderHTMLtoPDF(string htmlString)
        {
            HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter(HtmlRenderingEngine.WebKit);
            WebKitConverterSettings webKitSettings = new WebKitConverterSettings();
            webKitSettings.PdfPageSize = new System.Drawing.SizeF(PdfPageSize.A4.Width, 50);
            webKitSettings.Orientation = PdfPageOrientation.Landscape;
            //Set webkitpath
            webKitSettings.WebKitPath = QtBinariesPath;
            webKitSettings.WebKitViewPort = new System.Drawing.Size(1024, 0);
            htmlConverter.ConverterSettings = webKitSettings;
            //Convert URL to PDF
            PdfDocument document = htmlConverter.Convert(htmlString, string.Empty);
            System.Drawing.RectangleF bounds = new System.Drawing.RectangleF(0, 0, document.Pages[0].GetClientSize().Width, 50);
            PdfPageTemplateElement header = new PdfPageTemplateElement(bounds);
            header.Graphics.DrawPdfTemplate(document.Pages[0].CreateTemplate(), bounds.Location, bounds.Size);
            return header;
            //var htmlConverter = new HtmlToPdfConverter(HtmlRenderingEngine.WebKit);
            //htmlConverter.ConverterSettings = CreateConverterSetting(true, 50);
            ////Convert Html to PDF
            //PdfDocument document = htmlConverter.Convert(htmlString, string.Empty);
            //System.Drawing.RectangleF bounds = new System.Drawing.RectangleF(0, 0, document.Pages[0].GetClientSize().Width, 50);
            //PdfPageTemplateElement header = new PdfPageTemplateElement(bounds);
            //header.Graphics.DrawPdfTemplate(document.Pages[0].CreateTemplate(), bounds.Location, bounds.Size);
            //return header;
        }

        private static PdfPageTemplateElement FooterHTMLtoPDF(string htmlString)
        {
            HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter(HtmlRenderingEngine.WebKit);
            WebKitConverterSettings webKitSettings = new WebKitConverterSettings();
            webKitSettings.PdfPageSize = new SizeF(PdfPageSize.A4.Width, 50);
            webKitSettings.Orientation = PdfPageOrientation.Landscape;
            //Set webkitpath
            webKitSettings.WebKitPath = QtBinariesPath;
            webKitSettings.WebKitViewPort = new Size(1024, 0);
            htmlConverter.ConverterSettings = webKitSettings;
            //Convert URL to PDF
            PdfDocument document = htmlConverter.Convert(htmlString, string.Empty);
            RectangleF bounds = new RectangleF(0, 0, document.Pages[0].GetClientSize().Width, 50);
            PdfPageTemplateElement footer = new PdfPageTemplateElement(bounds);
            footer.Graphics.DrawPdfTemplate(document.Pages[0].CreateTemplate(), bounds.Location, bounds.Size);
            return footer;
            //HtmlToPdfConverter htmlConverter = new HtmlToPdfConverter(HtmlRenderingEngine.WebKit);
            //htmlConverter.ConverterSettings = CreateConverterSetting(true, 25);
            ////Convert Html to PDF
            //PdfDocument document = htmlConverter.Convert(htmlString, string.Empty);
            //System.Drawing.RectangleF bounds = new System.Drawing.RectangleF(0, 0, document.Pages[0].GetClientSize().Width, 50);
            //PdfPageTemplateElement footer = new PdfPageTemplateElement(bounds);
            //footer.Graphics.DrawPdfTemplate(document.Pages[0].CreateTemplate(), bounds.Location, bounds.Size);
            //return footer;
        }




    }
}