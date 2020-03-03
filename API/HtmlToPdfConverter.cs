using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using Syncfusion.HtmlConverter;
using Syncfusion.Pdf;

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
        public static string HtmlToPdf(string filePath, string bodyHtml, string headerHtml, string footerHtml)
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

            //Initialize HTML to PDF converter
            var htmlConverter = new HtmlToPdfConverter(HtmlRenderingEngine.WebKit);
            //Create new settings
            var setting = CreateConverterSetting();
            setting.PdfHeader = HeaderHTMLtoPDF(html.Replace("[[HTML]]", headerHtml));
            setting.PdfFooter = FooterHTMLtoPDF(html.Replace("[[HTML]]", footerHtml));
            htmlConverter.ConverterSettings = setting;
            //Convert to PDF
            PdfDocument document = htmlConverter.Convert(html.Replace("[[HTML]]", bodyHtml), string.Empty);
            //Save the document
            document.Save(filePath);
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