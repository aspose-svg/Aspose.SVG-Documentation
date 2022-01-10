---
title: Convert SVG to XPS | .NET
linktitle: Convert SVG to XPS
type: docs
weight: 20
url:  /net/how-to-work-with-aspose-svg-api/convert-svg-to-xps/   
lastmod: 2022-01-10
description: The article provides information on a list of supported SVG to XPS conversion scenarios and how to execute them using the Aspose.SVG API. You will learn how to convert SVG to XPS and find C# examples of SVG conversions.
keywords: svg converter, convert svg, convert SVG to XPS, SVG to XPS, save options
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

Converting  {{%SVG%}} documents to other formats is one of the main features of Aspose.SVG for .NET API. Converting is required for various reasons: to work in a familiar, convenient format or to take advantage of different formats for specific tasks. In this article, you find information on how to convert SVG to {{%XPS%}} by using [ConvertSVG()](https://apireference.aspose.com/svg/net/aspose.svg.converters/converter/methods/index) methods of the Converter class, [RenderTo()](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument/methods/renderto) method  of the [SVGDocument](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument) class and applying [XpsSaveOptions](https://apireference.aspose.com/net/html/aspose.html.saving/xpssaveoptions) or [XpsRenderingOptions](https://apireference.aspose.com/svg/net/aspose.svg.rendering.xps/xpsrenderingoptions).

{{% alert color="primary" %}}
You can try our free online <a href="https://products.aspose.app/svg/conversion/svg-to-xps" target="_blank">**SVG to XPS Converter**</a> that converts SVG to XPS file with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/svg/conversion/svg-to-xps" target="_blank">![Text "Banner SVG to XPS Converter"](svg-to-xps.png#center)</a>

## **Convert SVG to XPS Using ConvertSVG() Method**

The static methods of the [Converter](https://apireference.aspose.com/svg/net/aspose.svg.converters/converter) class can convert SVG to XPS  with a single line of code. It is the easiest way for conversion. Converting a file to another format using [ConvertSVG()](https://apireference.aspose.com/svg/net/aspose.svg.converters/converter/methods/index) methods is a sequence of operations among which document loading and saving: 

 - Load an SVG document using one of the [SVGDocument()](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument/constructors/10) constructors ([owl.svg](http://docs.aspose.com/svg/net/drawing-basics/svg-path-data/owl.svg)).
 - Create an instance of the [XpsSaveOptions](https://apireference.aspose.com/svg/net/aspose.svg.saving/xpssaveoptions) class.
 - Use the [ConvertSVG()](https://apireference.aspose.com/svg/net/aspose.svg.converters.converter/convertsvg/methods/5) method to save SVG as an XPS file. 

 The following code snippet can be used to convert an SVG file to XPS format:

```c#
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Converters;
using System.Drawing;
using Aspose.Svg.Saving;
...

    // Initialize an SVG document from a file
    using (var document = new SVGDocument(Path.Combine(DataDir, "owl.svg")))
    {
        // Initialize an instance of the XpsSaveOptions class
        var saveOptions = new XpsSaveOptions();
        saveOptions.BackgroundColor = Color.Gray;
    
        // Convert SVG to XPS
        Converter.ConvertSVG(document, saveOptions, Path.Combine(OutputDir, "owl_out.xps"));
    }
```

The [XpsSaveOptions()](https://apireference.aspose.com/svg/net/aspose.svg.saving/xpssaveoptions/constructors/main) constructor initializes an instance of the XpsSaveOptions class that is passed to ConvertSVG() method. The [ConvertSVG()](https://apireference.aspose.com/svg/net/aspose.svg.converters.converter/convertsvg/methods/5) method  takes the  `document`, `saveOptions`, output file path and performs the conversion operation. 

In the example above, we add the `BackgroundColor` property that sets `Color`, which will fill the background of every page. 

## **Save Options**

Aspose.SVG allows converting SVG to XPS with default or custom save options. [XpsSaveOptions](https://apireference.aspose.com/svg/net/aspose.svg.saving/xpssaveoptions) usage enables you to customize the rendering process; you can specify the page size, margins, background color, file permissions, Css, etc. 

| Property                                                     | Description                                                  |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| [BackgroundColor](https://apireference.aspose.com/svg/net/aspose.svg.rendering/renderingoptions/properties/backgroundcolor) | This property sets the color that will fill the background of every page. By default, this property is Transparent. |
| [Css](https://apireference.aspose.com/svg/net/aspose.svg.rendering/renderingoptions/properties/css) | Gets a [CssOptions](https://apireference.aspose.com/svg/net/aspose.svg.rendering/cssoptions) object which is used for configuration of CSS properties processing. |
| [HorizontalResolution](https://apireference.aspose.com/svg/net/aspose.svg.rendering/renderingoptions/properties/horizontalresolution) | Sets the horizontal resolution for output images in pixels per inch. The default value is 300 dpi. |
| [VerticalResolution](https://apireference.aspose.com/svg/net/aspose.svg.rendering/renderingoptions/properties/verticalresolution) | Sets the vertical resolution for output images in pixels per inch. The default value is 300 dpi. |
| [PageSetup](https://apireference.aspose.com/svg/net/aspose.svg.rendering/renderingoptions/properties/pagesetup) | This property gets a page setup object and uses it for configuration output page-set. |

**Note**: The options that are implementing with the [XpsSaveOptions](https://apireference.aspose.com/svg/net/aspose.svg.saving/xpssaveoptions) class are inheriting from the [XpsRenderingOptions](https://apireference.aspose.com/svg/net/aspose.svg.rendering.xps/xpsrenderingoptions) class.

## **Convert SVG to XPS Using RenderTo() Method**

Consider SVG to XPS conversion scenario using RenderTo() method:

 - Initialize a document using  [SVGDocument()](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument/constructors/10) constructor ([light.svg](http://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/converting/light.svg)).
 - Initialize an instance of the [XpsRenderingOptions](https://apireference.aspose.com/svg/net/aspose.svg.rendering.xps/xpsrenderingoptions) class and specify the document's properties.
 - Create a new instance of the [XpsDevice](https://apireference.aspose.com/svg/net/aspose.svg.rendering.xps/xpsdevice) class.
 - Convert the document by [RenderTo()](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument/methods/renderto) method. 

The following code snippet can be used to convert SVG to XPS:

```c#
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Drawing;
using Aspose.Svg.Rendering;
using Aspose.Svg.Rendering.Xps;
...
	
	// Initialize an SVG document from a file
	using (var document = new SVGDocument(Path.Combine(DataDir, "light.svg")))
	{
	     // Initialize an instance of the XpsRenderingOptions class and set a custom PageSetup properties
		 var xpsRenderingOptions = new XpsRenderingOptions();
	     xpsRenderingOptions.PageSetup.AnyPage = new Page(new Drawing.Size(500, 500), new Margin(10, 10, 10, 10));	     
	     
		 // Initialize an instance of XpsDevice class
	     using (IDevice device = new XpsDevice(xpsRenderingOptions, Path.Combine(OutputDir, "light_out.xps")))
	     {
	         // Render SVG to XPS, send the document to the rendering device
			 document.RenderTo(device);
	     }
	 }
```

The [XpsRenderingOptions()](https://apireference.aspose.com/svg/net/aspose.svg.rendering.xps/xpsrenderingoptions) constructor creates a new object that is passed as an argument to the [XpsDevice(`options, file`)](https://apireference.aspose.com/svg/net/aspose.svg.rendering.xps/xpsdevice/constructors/3) constructor. The last initializes a new instance of [XpsDevice](https://apireference.aspose.com/svg/net/aspose.svg.rendering.xps/xpsdevice) class by rendering options and output file name.  The [RenderTo(` device`)](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument/methods/renderto)  method converts and sends the current document to the output rendering device.

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-svg/Aspose.SVG-Documentation). You find out about downloading from GitHub and running examples from the [**How to Run the Examples**](http://docs.aspose.com/svg/net/how-to-run-the-tests) section.
{{% /alert %}} 



