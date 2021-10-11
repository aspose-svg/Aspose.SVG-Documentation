---
title: How to Convert SVG Files
type: docs
weight: 60
aliases: 
   - /net/how-to-work-with-aspose-svg-api/converting/
   - /net/how-to-convert-svg-files/
   - /net/converting/
lastmod: 2021-10-11
description: The articles in this section provide information on a list of supported SVG conversion scenarios and how to execute them using the Aspose.SVG API. You will learn how to convert SVG to PDF, XPS or Image formats and find C# examples of SVG conversion.
keywords: svg converter, convert svg, convert svg to pdf, convert svg to png, svg to pdf, svg to png, svg to bmp, svg to jpg, svg to tiff, svg to gif, svg to xps
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

Converting SVG documents to other formats is one of the main features of Aspose.SVG for .NET API. Converting is required for various reasons: to work in a familiar, convenient format or to take advantage of different formats for specific tasks.

Aspose.SVG for .NET API can convert {{%SVG%}} files to {{%PDF%}}, {{%XPS%}}, {{%JPG%}}, {{%PNG%}}, {{%BMP%}}, {{%TIFF%}}, and {{%GIF%}} file formats. You can use API in your C# or any other .NET application (such as VB.NET) to develop converter applications without getting into the details of underlying file formats. 

{{% alert color="primary" %}} 

Aspose.SVG offers a free online [**SVG Converter**](https://products.aspose.app/svg/conversion) for converting SVG files to a variety of popular formats. You can easily convert SVG to PDF, SVG to XPS, SVG to JPG, SVG to PNG, SVG to BMP, SVG to TIFF, SVG to GIF. Just select the file, choose the format to convert, and you’re done. It’s fast and completely free!

{{% /alert %}} 

## **A Few Ways to Convert SVG**

Converting from SVG  to other formats can perform by using [ConvertSVG()](https://apireference.aspose.com/svg/net/aspose.svg.converters/converter/methods/index) methods of the [Converter](https://apireference.aspose.com/svg/net/aspose.svg.converters/converter) class,  the [RenderTo(`device`)](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument/methods/renderto)  method of the [SVGDocument](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument) class, or the Render (`IDevice, TDocument`) method of the [Renderer](https://apireference.aspose.com/svg/net/aspose.svg.rendering/renderer) class.

The current section describes supported scenarios of SVG files conversions to other popular formats by using  [Converter](https://apireference.aspose.com/svg/net/aspose.svg.converters/converter) and [SVGDocument](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument) classes:

1. The static Converter class is a shared facade that provides SVG files conversions to the popular formats and allows to make these operations convenient and easy. 
   There is a wide range of the ConvertSVG()  methods that take as an argument the source document, save options, output file path and convert SVG to PDF, XPS or image files.
2. The RenderTo() method of the SVGDocument class is used to render SVG to other format and send a document to the output device. Aspose.SVG API provides the following output devices implementation:  the [PdfDevice](https://apireference.aspose.com/svg/net/aspose.svg.rendering.pdf/pdfdevice), [XpsDevice](https://apireference.aspose.com/svg/net/aspose.svg.rendering.xps/xpsdevice) and  [ImageDevice](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagedevice) classes, which perform rendering to PDF, XPS and Image file formats respectively. 
3. The Render (`IDevice, TDocument`) method of the [Renderer](https://apireference.aspose.com/svg/net/aspose.svg.rendering/renderer) class gives you the ability to send multiple documents at ones to the output rendering device and merge them. For more information, please see the article [**How to Merge SVG Documents**](http://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/how-to-merge-svg-documents/).

Let's consider both scenarios of conversion SVG document to another file format, for example, SVG to PNG:

{{% alert color="primary" %}} 
You can download the complete examples and data files from **[GitHub](https://github.com/aspose-svg/Aspose.SVG-Documentation)**. About downloading from GitHub and running examples, you find out from the[ **How to Run the Examples**](http://docs.aspose.com/svg/net/how-to-run-the-tests) section.
{{% /alert %}}  

### **Convert SVG to PNG Using the ConvertSVG() Method**
Converting a file to other format using the ConvertSVG() method is a sequence of operations among which document loading and saving:

 - Load an SVG document using one of the [SVGDocument()](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument/constructors/10) constructors ([svg-to-png.svg](http://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/converting/svg-to-png.svg)).
 - Create an instance of the [ImageSaveOptions](https://apireference.aspose.com/svg/net/aspose.svg.saving/imagesaveoptions) class.
 - Use one of the [ConvertSVG()](https://apireference.aspose.com/svg/net/aspose.svg.converters/converter/methods/index) methods to save SVG as a PNG file.

```c#
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Saving;
using Aspose.Svg.Converters;
...
    
    // Initialize an SVG document from a file
    using (var document = new SVGDocument(Path.Combine(DataDir, "svg-to-png.svg")))
    {
        // Create an instance of the ImageSaveOptions class
    	var pngSaveOptions = new ImageSaveOptions();    

        // Convert SVG to PNG
    	Converter.ConvertSVG(document, pngSaveOptions, Path.Combine(OutputDir, "svg-to-png.png"));
    }
```

In the example, the [ImageSaveOptions()](https://apireference.aspose.com/svg/net/aspose.svg.saving/imagesaveoptions/constructors/main) constructor initializes an instance of the ImageSaveOptions  class that is passed to ConvertSVG() method. The [ConvertSVG(`source, options, outputPath`)](https://apireference.aspose.com/svg/net/aspose.svg.converters.converter/convertsvg/methods/1) method takes the required attributes and performs the conversion operation.

The figure illustrates the svg-to-png.png file.

![svg-to-png.svg file rendered to PNG](svg-to-png.png#center)

### **Convert SVG to PNG Using the RenderTo() Method**

To convert SVG to PNG using the RenderTo() method take the following stages:

 - Initialize a document using one of the  [SVGDocument()](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument/constructors/10) constructors ([light.svg](http://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/converting/light.svg)).
 - Produce an instance of the [ImageRenderingOptions](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagerenderingoptions) class.
 - Create a new instance of the [ImageDevice](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagedevice) class. Use the [ImageDevice()](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagedevice/constructors/3) constructor, and pass it an instance of the ImageRenderingOptions class and output file path.
 - Convert the document by [RenderTo(`device`)](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument/methods/renderto) method. 

```c#
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Rendering.Image;
...
	
	// Open a source SVG document 
	using (var document = new SVGDocument(Path.Combine(DataDir, "light.svg")))
	{
	    // Initialize an instance of the ImageRenderingOptions class 
		var pngOptions = new ImageRenderingOptions();
	    	    

		// Initialize an instance of ImageDevice and specify the output file to render
	    using (var device = new ImageDevice(pngOptions, Path.Combine(OutputDir, "light_out.png")))
	    {
	        // Render SVG to PNG
			document.RenderTo(device);
		}
	}
```

The [ImageDevice(`options, file`)](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagedevice/constructors/3) constructor takes as arguments an instance of ImageRenderingOptions class, output file name and initializes a new instance of the  [ImageDevice](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagedevice) class. The [RenderTo(`device`)](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument/methods/renderto)  method converts and sends the current document to the output rendering device. 

The figure illustrates the result of SVG to PNG conversion - light.png file.

![light.svg file rendered to PNG using RenderTo() method ](light.png#center)

## **General Options**

You can customize the rendering process by specifying the page size, margins, background color, etc.  For converting SVG to all mentioned above formats, from the [RenderingOptions](https://apireference.aspose.com/svg/net/aspose.svg.rendering/renderingoptions) class the following properties are inherited: `BackgroundColor`, `Css`, `HorizontalResolution`, `PageSetup`, and `VerticalResolution`.

Every output device PdfDevice, XpsDevice and ImageDevice has his own unique set of options implemented with classes [PdfRenderingOptions](https://apireference.aspose.com/svg/net/aspose.svg.rendering.pdf/pdfrenderingoptions), [XpsRenderingOptions](https://apireference.aspose.com/svg/net/aspose.svg.rendering.xps/xpsrenderingoptions) and [ImageRenderingOptions](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagerenderingoptions) respectively.

The options that are implementing with the [PdfSaveOptions](https://apireference.aspose.com/svg/net/aspose.svg.saving/pdfsaveoptions), [XpsSaveOptions](https://apireference.aspose.com/svg/net/aspose.svg.saving/xpssaveoptions) and [ImageSaveOptions](https://apireference.aspose.com/svg/net/aspose.svg.saving/imagesaveoptions) classes are inheriting from the PdfRenderingOptions, XpsRenderingOptions and ImageRenderingOptions classes respectively.

{{% alert color="primary" %}} 
Aspose.SVG offers a free online [**SVG Converter**](https://products.aspose.app/svg/conversion) for converting SVG files to a variety of popular formats. You can easily convert SVG to PDF, SVG to XPS, SVG to JPG, SVG to PNG, SVG to BMP, SVG to TIFF, SVG to GIF. Just select the file, choose the format to convert, and you’re done. It’s fast and completely free!

{{% /alert %}} 

