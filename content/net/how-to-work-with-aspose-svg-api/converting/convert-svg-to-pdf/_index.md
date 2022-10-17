---
title: Convert SVG to PDF - C# Examples
linktitle: Convert SVG to PDF
type: docs
weight: 10
url:  /net/how-to-work-with-aspose-svg-api/convert-svg-to-pdf/   
lastmod: 2022-07-27
description: The article provides information on a list of supported SVG to PDF conversion scenarios and how to execute them using the C# API. You will learn how to convert SVG to PDF and find C# examples of SVG to PDF conversions. 
keywords: svg converter, convert svg, convert svg to pdf, svg to pdf, save options
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

Converting  {{%SVG%}} documents to other formats is one of the main features of Aspose.SVG for .NET API. Converting is required for various reasons: to work in a familiar, convenient format or to take advantage of different formats for specific tasks. {{%PDF%}} is a file format supported by all operating systems, used for presenting images, documents and books. Files in PDF can be easily viewed, printed, and shared online. 

You can convert SVG to PDF and other popular formats in any way - online or programmatically. 

## **Online SVG Converter**

You can check the Aspose.SVG API functionality and convert SVG in real-time.  Please load SVG from the local file system, select the output format and run the example.  In the example, the save options are set by default. You will immediately receive the result as a separate  file.

{{< app/svg/converter SVG   PDF  XPS "JPG|JPEG" PNG GIF TIFF BMP >}}
using Aspose.Svg;
using Aspose.Svg.Saving;
using Aspose.Svg.Converters;

    using var document = new SVGDocument("image.svg");
{{#if_output 'PDF'}}
    var options = new PdfSaveOptions();
{{/if_output}}
{{#if_output 'XPS'}}
    var options = new XpsSaveOptions();
{{/if_output}}
{{#if_output 'BMP' 'JPG' 'GIF' 'PNG' 'TIFF'}}
    var options = new ImageSaveOptions(ImageFormat.{{output param2 camel}});
{{/if_output}}
    Converter.ConvertSVG(document, options, "output.{{output lower}}");   
{{< /app/svg/converter>}} 

If you want to convert SVG to PDF programmatically, please see the following C# code examples.

## **Convert SVG to PDF Using ConvertSVG() Method**

The static methods of the [Converter](https://reference.aspose.com/svg/net/aspose.svg.converters/converter/) class can convert SVG to PDF  with a single line of code. It is the easiest way for conversion. Converting a file to another format using [ConvertSVG()](https://reference.aspose.com/svg/net/aspose.svg.converters/converter/) methods is a sequence of operations among which document loading and saving: 

 - Load an SVG document using one of the [SVGDocument()](https://reference.aspose.com/svg/net/aspose.svg/svgdocument/svgdocument/) constructors ( [lineto.svg](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/saving-svg-documents/lineto.svg)).
 - Create an instance of the [PdfSaveOptions](https://reference.aspose.com/svg/net/aspose.svg.saving/pdfsaveoptions/) class.
 - Use the [ConvertSVG()](https://reference.aspose.com/svg/net/aspose.svg.converters/converter/convertsvg/) method to save SVG as a PDF file. 

 The following code snippet can be used to convert an SVG file to PDF format:

```c#
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Converters;
using System.Drawing;
using Aspose.Svg.Saving;
...

    // Initialize an SVG document from a file
    using (var document = new SVGDocument(Path.Combine(DataDir, "lineto.svg")))
    {
        // Initialize an instance of the PdfSaveOptions class
        var saveOptions = new PdfSaveOptions();
        saveOptions.BackgroundColor = Color.Gray;
    
        // Convert SVG to PDF
        Converter.ConvertSVG(document, saveOptions, Path.Combine(OutputDir, "lineto_out.pdf"));
    }
```

The [PdfSaveOptions()](https://reference.aspose.com/svg/net/aspose.svg.saving/pdfsaveoptions/pdfsaveoptions/) constructor initializes an instance of the PdfSaveOptions class that is passed to ConvertSVG() method. The [ConvertSVG()](https://reference.aspose.com/svg/net/aspose.svg.converters/converter/convertsvg/) method  takes the  `document`, `saveOptions`, output file path and performs the conversion operation. In the example above, we add the `BackgroundColor` property that sets `Color`, which will fill the background of every page. 

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-svg/Aspose.SVG-Documentation). You find out about downloading from GitHub and running examples from the  [**How to Run the Examples**](https://docs.aspose.com/svg/net/how-to-run-the-tests/) section.
{{% /alert %}} 

## **Save Options**

You can convert SVG to PDF using default or custom save options. [PdfSaveOptions](https://reference.aspose.com/svg/net/aspose.svg.saving/pdfsaveoptions/) or  [PdfRenderingOptions](https://reference.aspose.com/svg/net/aspose.svg.rendering.pdf/pdfrenderingoptions/) usage enables you to customize the rendering process; you may specify the page size, margins, background color, file permissions, Css, etc. 

| Property                                                     | Description                                                  |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| [JpegQuality](https://reference.aspose.com/svg/net/aspose.svg.rendering.pdf/pdfrenderingoptions/jpegquality/) | Specifies the quality of JPEG compression for images. The default value is 95. |
| [Css](https://reference.aspose.com/svg/net/aspose.svg.rendering/renderingoptions/css/) | Gets a [CssOptions](https://reference.aspose.com/svg/net/aspose.svg.rendering/cssoptions/) object which is used for configuration of CSS properties processing. |
| [DocumentInfo](https://reference.aspose.com/svg/net/aspose.svg.rendering.pdf/pdfrenderingoptions/documentinfo/) | This property contains information about the output PDF document. |
| [BackgroundColor](https://reference.aspose.com/svg/net/aspose.svg.rendering/renderingoptions/backgroundcolor/) | This property sets the color that will fill the background of every page. By default, this property is Transparent. |
| [PageSetup](https://reference.aspose.com/svg/net/aspose.svg.rendering/renderingoptions/pagesetup/) | This property gets a page setup object and uses it for configuration output page-set. |
| [HorizontalResolution](https://reference.aspose.com/svg/net/aspose.svg.rendering/renderingoptions/horizontalresolution/) | Sets the horizontal resolution for output images in pixels per inch. The default value is 300 dpi. |
| [VerticalResolution](https://reference.aspose.com/svg/net/aspose.svg.rendering/renderingoptions/verticalresolution/) | Sets the vertical resolution for output images in pixels per inch. The default value is 300 dpi. |
| [Encryption](https://reference.aspose.com/svg/net/aspose.svg.rendering.pdf/pdfrenderingoptions/encryption/) | This property gets or sets encryption details. If it is not set, then no encryption will be performed. |

**Note**: The options that are implementing with the [PdfSaveOptions](https://reference.aspose.com/svg/net/aspose.svg.saving/pdfsaveoptions/) class are inheriting from the [PdfRenderingOptions](https://reference.aspose.com/svg/net/aspose.svg.rendering.pdf/pdfrenderingoptions/) class.

## **Convert SVG to PDF Using RenderTo() Method**

Consider SVG to PDF conversion scenario using RenderTo() method:

 - Initialize a document using  [SVGDocument()](https://reference.aspose.com/svg/net/aspose.svg/svgdocument/svgdocument/) constructor ([light.svg](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/converting/light.svg)).
 - Initialize an instance of the [PdfRenderingOptions](https://reference.aspose.com/svg/net/aspose.svg.rendering.pdf/pdfrenderingoptions/) class and specify the document's properties.
 - Create a new instance of the [PdfDevice](https://reference.aspose.com/svg/net/aspose.svg.rendering.pdf/pdfdevice/) class.
 - Convert the document by [RenderTo()](https://reference.aspose.com/svg/net/aspose.svg/svgdocument/renderto/) method. 

The following code snippet can be used to convert an SVG file to PDF format:

```c#
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Drawing;
using Aspose.Svg.Rendering;
using Aspose.Svg.Rendering.Pdf;
...
	
	// Initialize an SVG document from a file
	using (var document = new SVGDocument(Path.Combine(DataDir, "light.svg")))
	{
	     // Initialize an instance of the PdfRenderingOptions class and set custom PageSetup and JpegQuality properties
		 var pdfRenderingOptions = new PdfRenderingOptions();
	     pdfRenderingOptions.PageSetup.AnyPage = new Page(new Drawing.Size(500, 500), new Margin(10, 10, 10, 10));
	     pdfRenderingOptions.JpegQuality = 10;
	     
		 // Initialize an instance of the PdfDevice class
	     using (IDevice device = new PdfDevice(pdfRenderingOptions, Path.Combine(OutputDir, "light_out.pdf")))
	     {
	         // Render SVG to PDF and send the document to the rendering device
			 document.RenderTo(device);
	     }
	 }
```

The [PdfRenderingOptions()](https://reference.aspose.com/svg/net/aspose.svg.rendering.pdf/pdfrenderingoptions/pdfrenderingoptions/) constructor initializes a new object of the [PdfRenderingOptions](https://reference.aspose.com/svg/net/aspose.svg.rendering.pdf/pdfrenderingoptions/) class that is passed as an argument to the [PdfDevice(`options, file`)](https://reference.aspose.com/svg/net/aspose.svg.rendering.pdf/pdfdevice/pdfdevice/) constructor. The last initializes a new instance of the [PdfDevice](https://reference.aspose.com/svg/net/aspose.svg.rendering.pdf/pdfdevice/) class by rendering options and output file name.  The [RenderTo(` device`)](https://reference.aspose.com/svg/net/aspose.svg/svgdocument/renderto/)  method converts SVG to PDF and sends the current document to the output rendering device.

The `JpegQuality` specifies the quality of JPEG compression for images. The default is 95. In the example above, the used `JpegQuality` value is 10. The figure illustrates conversion SVG to PDF for two files [light.svg](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/converting/light.svg) and [lineto.svg](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/saving-svg-documents/lineto.svg): a) The `JpegQuality` value is default; b) The  `JpegQuality` value is 10.

![Images rendered to PDF with various JpegQuality values](jpeg-quality.png#center)

{{% alert color="primary" %}}
You can convert SVG to PDF with our free online <a href="https://products.aspose.app/svg/conversion/svg-to-pdf" target="_blank">**SVG to PDF Converter**</a> that works with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/svg/en/conversion/svg-to-pdf" target="_blank">![Text "Banner SVG to PDF Converter"](svg-to-pdf.png#center)</a>



