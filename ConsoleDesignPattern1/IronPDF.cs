using System;
using System.Collections.Generic;
using System.Text;
using IronPdf;
using javax.swing;

namespace ConsoleDesignPattern1
{
    public class IronPDF
    {
        var Renderer = new IronPdf.HtmlToPdf();
        Renderer.RenderHtmlAsPdf("<h1>Html with CSS and Images</h1>").SaveAs("example.pdf");


        // Advanced:  Load external html assets: images, css and javascript.
        // An optional "base" asset locating path can be set as a url or local directory. 
        var PDF = Renderer.RenderHtmlAsPdf("<img src='icons/iron.png'>", @"C:\site\assets\");
        PDF.SaveAs("html-with-assets.pdf");
    }
}