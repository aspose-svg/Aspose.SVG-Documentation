---
title: Convert SVG to Image | .NET
linktitle: Convert SVG to Image
type: docs
weight: 30
url:  /net/how-to-work-with-aspose-svg-api/convert-svg-to-image/   
lastmod: 2022-01-10
description: The article provides information on a list of supported SVG to Image conversion scenarios and how to execute them using the Aspose.SVG API. You will learn how to convert SVG to Image formats and find C# examples of SVG to Image conversions.
keywords: svg converter, convert svg, convert svg to jpg, convert svg to png, svg to jpg, svg to png, svg to bmp, svg to tiff, svg to gif
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

In the article, you will find information on how to convert SVG to Image file formats such as {{%JPG%}}, {{%PNG%}}, {{%BMP%}}, {{%TIFF%}}, and {{%GIF%}}. Image file conversion is required for website developing, graphic designers acting, photography, and other purposes. The choice of the image format depends on whether you print it in polygraphy, send it by e-mail or put an image on a webpage.

The article provides a general description of the conversion features of Aspose.SVG .NET and describes supported scenarios of SVG to Image conversions by using  [Converter](https://apireference.aspose.com/svg/net/aspose.svg.converters/converter) and [SVGDocument](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument) classes.

{{% alert color="primary" %}}
You can try our free online <a href="https://products.aspose.app/svg/conversion/svg-to-jpg" target="_blank">**SVG to JPG Converter**</a> that works with high quality, easy and fast. Just upload, convert your files and get results in a few seconds!
{{% /alert %}}

<a href="https://products.aspose.app/svg/conversion/svg-to-jpg" target="_blank">![Text "Banner SVG to JPG Converter"](svg-to-jpg.png#center)</a>

## **Convert SVG to JPG** 
 JPG is one of the most commonly used image formats. Its uniqueness is the controlled quality loss during compression. So it is widely used for storing and sending over the web graphic digital content (photos, scanned copies, digitized pictures). With Aspose.SVG, you can convert SVG to JPG, SVG to PNG, SVG to BMP, SVG to GIF or SVG to TIFF format programmatically with full control over a wide range of conversion parameters.

### **Using the ConvertSVG() Method**

Using [ConvertSVG()](https://apireference.aspose.com/svg/net/aspose.svg.converters/converter/methods/index) methods is the most common way to convert SVG to various popular formats. The following code snippet shows how to convert SVG to JPG: 

 - Open a source SVG document ([owl-edited.svg](/svg/net/how-to-work-with-aspose-svg-api/navigation-inspection/owl-edited1.svg)).
 - Create an instance of the [ImageSaveOptions](https://apireference.aspose.com/svg/net/aspose.svg.saving/imagesaveoptions) class.
 - Use the [ConvertSVG()](https://apireference.aspose.com/svg/net/aspose.svg.converters.converter/convertsvg/methods/1) method to save SVG as a JPG file.

```c#
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Saving;
using Aspose.Svg.Converters;
...
	// Initialize an SVG document from a file
    using (var document = new SVGDocument(Path.Combine(DataDir, "owl-edited.svg")))
    {
        // Initialize ImageSaveOptions 
        var saveOptions = new ImageSaveOptions(ImageFormat.Jpeg);
        
        // Convert SVG to JPG
        Converter.ConvertSVG(document, saveOptions, Path.Combine(OutputDir, "owl-edited.jpg"));
    }
```
The figure illustrates the owl-edited.jpg file.

![owl-edited.svg file rendered to JPG](owl-edited.png#center)

{{% alert color="primary" %}}
In the article **[Navigation & Inspection SVG](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/navigation-inspection/)**, you can see C# examples of how  the original [owl.svg](https://docs.aspose.com/svg/net/drawing-basics/svg-path-data/owl.svg) file was edited using the CSS Selector.

{{% /alert %}}

### **Using the RenderTo() Method**

Consider how to convert a document from SVG to JPG using RenderTo() method:

- Open a source SVG document ([owl.svg](https://docs.aspose.com/svg/net/drawing-basics/svg-path-data/owl.svg)).
- Use the [ImageRenderingOptions()](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagerenderingoptions/constructors/1) constructor and specify rendering options of the document.
- Create a new instance of the [ImageDevice](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagedevice) class - the output device.
- Convert the document by [RenderTo()](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument/methods/renderto) method.

 The following example shows how to apply the `Format` and `SmoothingMode` properties for SVG to JPG converting: 

```c#
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Rendering;
using Aspose.Svg.Rendering.Image;
using System.Drawing.Drawing2D;
...
    
    // Initialize an SVG document from a file
    using (var document = new SVGDocument(Path.Combine(DataDir, "owl.svg")))
    {
        // Set Format and SmoothingMode for jpgOptions1
        var jpegOptions1 = new ImageRenderingOptions(ImageFormat.Jpeg);
        jpegOptions1.SmoothingMode = SmoothingMode.AntiAlias;

        // Set Format and SmoothingMode for jpgOptions2
        var jpegOptions2 = new ImageRenderingOptions(ImageFormat.Jpeg);
        jpegOptions2.SmoothingMode = SmoothingMode.Default;
    
        // Initialize an instance of the ImageDevice class and specify the output file to render
        using (IDevice device = new ImageDevice(jpegOptions1, Path.Combine(OutputDir, "owl_out1.jpg")))
        {
            // Render SVG to JPG
document.RenderTo(device);
        }
        using (IDevice device = new ImageDevice(jpegOptions2, Path.Combine(OutputDir, "owl_out2.jpg")))
        {
            document.RenderTo(device);
        }
    }
```

The [ImageRenderingOptions()](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagerenderingoptions/constructors/1) constructor initializes an instance of the ImageRenderingOptions class that is passed to the [ImageDevice()](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagedevice/constructors/3) constructor. The [ImageDevice(`options` ,  `file`)](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagedevice/constructors/3) constructor takes the `options` ,  `file`  and creates the instance of the ImageDevice class. The [RenderTo(`device`)](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument/methods/renderto) method takes the instance of the ImageDevice class and renders SVG to JPG.

The [ImageRenderingOptions](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagerenderingoptions) class provides numerous properties that give you full control over a wide range of parameters and improve the process of converting SVG to JPG format. The `Format` property sets the image format. By default, this property is `Png`. To convert SVG to JPG, you have to use `ImageFormat.Jpeg`.

![the resulting images fragments](smoothing-mode.png#center)                                                                            

In the example above, we convert the SVG file [owl.svg](https://docs.aspose.com/svg/net/drawing-basics/svg-path-data/owl.svg) to JPG with different `SmoothingMode` values. The figure illustrates zoomed (250%) JPG images fragments: a) The value of `SmoothingMode`  is `AntiAlias` ; b) The value of  `SmoothingMode` is  `Default`.     

## **Save Options**
Aspose.SVG allows converting SVG to Image file formats using default or custom save options. [ImageSaveOptions](https://apireference.aspose.com/net/svg/aspose.svg.saving/imagesaveoptions) usage enables you to customize the rendering process. For example, you can specify the image format, page size, margins, background color, etc.

| Property                                                     | Description                                                  |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| [Compression](https://apireference.aspose.com/net/svg/aspose.svg.rendering.image/compression) | Sets Tagged Image File Format (TIFF) Compression. By default, this property is LZW. |
| [CSS](https://apireference.aspose.com/svg/net/aspose.svg.rendering/mediatype) | Gets a [CssOptions](https://apireference.aspose.com/svg/net/aspose.svg.rendering/cssoptions) object which is used for configuration of CSS properties processing. |
| [Format](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imageformat) | Sets the ImageFormat (JPG, PNG, BMP, TIFF, or GIF). By default, this property is PNG. |
| [BackgroundColor](https://apireference.aspose.com/svg/net/aspose.svg.rendering/renderingoptions/properties/backgroundcolor) | This property sets the color that will fill the background. By default, this property is Transparent. |
| [PageSetup](https://apireference.aspose.com/svg/net/aspose.svg.rendering/renderingoptions/properties/pagesetup) | This property gets a page setup object and uses it for configuration output page-set. |
| [HorizontalResolution](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagerenderingoptions/properties/horizontalresolution) | Sets horizontal resolution for output images in pixels per inch. The default value is 300 dpi. |
| [VerticalResolution](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagerenderingoptions/properties/verticalresolution) | Sets vertical resolution for output images in pixels per inch. The default value is 300 dpi. |
| [SmoothingMode](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagerenderingoptions/properties/smoothingmode) | This property sets the rendering quality for this image.  Available values are Invalid, Default, HighSpeed, HighQuality, None, and AntiAlias. |
| [Text](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagerenderingoptions/properties/text) | Gets a [TextOptions](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/textoptions) object which is used for configuration of text rendering. |

**Note**: The options that are implementing with the [ImageSaveOptions](https://apireference.aspose.com/svg/net/aspose.svg.saving/imagesaveoptions) class are inheriting from the [ImageRenderingOptions](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagerenderingoptions) class.

## **Convert SVG to PNG**

PNG  format uses a lossless compression algorithm to store raster images. It supports only the RGB color model and does not design for images print. PNG widely takes to transmit pictures over the network and display photos and graphics on web-pages and cloud drive repositories.

### **Using the ConvertSVG() Method**

The following code snippet shows how to prepare an SVG file from scratch and convert it to PNG: 

 - Prepare  SVG code and save it to a file.
 - Create an instance of the [ImageSaveOptions](https://apireference.aspose.com/svg/net/aspose.svg.saving/imagesaveoptions) class.
 - Use the [ConvertSVG()](https://apireference.aspose.com/svg/net/aspose.svg.converters.converter/convertsvg/methods/1) method to save SVG as a PNG file.

The following example shows how to use [ImageSaveOptions](https://apireference.aspose.com/net/svg/aspose.svgsaving/imagesaveoptions) and convert SVG to PNG with custom save options:

```c#
using Aspose.Svg;
using System.IO;
using System.Drawing;
using Aspose.Svg.Saving;
using Aspose.Svg.Converters;
...

    // Prepare SVG code and save it to a file
    var code = "<svg xmlns='http://www.w3.org/2000/svg'>" +
               "<circle cx='100' cy='150' r='50' stroke='#2F4F4F' stroke-width='4' fill='#FF7F50' />" +
               "<circle cx='180' cy='200' r='60' stroke='#2F4F4F' stroke-width='4' fill='#008B8B' />" +
               "</svg>";
    File.WriteAllText("example.svg", code);
    
    // Initialize an SVG document from the file
    using (var document = new SVGDocument("example.svg"))
    {
        // Initialize an instance of the ImageSaveOptions class and set the BackgroundColor property
        var saveOptions = new ImageSaveOptions();
        saveOptions.BackgroundColor = Color.Gainsboro;
    
        // Convert SVG to PNG
        Converter.ConvertSVG(document, saveOptions, Path.Combine(OutputDir, "output.png"));
    }
```

In the example,  the [ImageSaveOptions()](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagerenderingoptions/constructors/main) constructor initializes an instance of ImageSaveOptions class that is passed to ConvertSVG() method. The [ConvertSVG()](https://apireference.aspose.com/svg/net/aspose.svg.converters.converter/convertsvg/methods/1) method takes the `document`, `saveOptions`, and output file path and performs the SVG to PNG conversion.

**Note**: We do not specify the `Format` property for the conversion to PNG. The [ImageSaveOptions()](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagerenderingoptions/constructors/main) constructor takes `Png` as the default image format.

### **Using the RenderTo() Method**

Let's consider how to convert SVG to PNG using RenderTo() method:

 - Initialize a document using one of the  [SVGDocument()](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument/constructors/10) constructors ([snowflake.svg](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/converting/snowflake.svg)).
 - Produce an instance of the [ImageRenderingOptions](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagerenderingoptions) class.
 - Create a new instance of the [ImageDevice](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagedevice) class. 
 - Convert SVG to PNG using the [RenderTo(`device`)](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument/methods/renderto) method. 

```c#
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Rendering;
using Aspose.Svg.Rendering.Image;
...
	
	// Prepare a path to a source SVG file
	string documentPath = Path.Combine(DataDir, "snowflake.svg");

    // Initialize an SVG document from a file
    using (var document = new SVGDocument(documentPath))
    {
        // Create the ImageDevice, set image Format and specify output file to render
        using (IDevice device = new ImageDevice(new ImageRenderingOptions(), Path.Combine(OutputDir, "snowflake_out.png")))
        {
            // Render SVG to PNG
            document.RenderTo(device);
        }
    }
```

The [ImageRenderingOptions()](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagerenderingoptions/constructors/1) constructor initializes an instance of the ImageRenderingOptions class that is passed to the [ImageDevice()](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagedevice/constructors/3) constructor. The [ImageDevice(`options` ,  `file`)](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagedevice/constructors/3) constructor takes the `options` ,  `file`  and creates the instance of the ImageDevice class. The [RenderTo(`device`)](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument/methods/renderto) method takes the instance of the ImageDevice class and renders SVG to PNG.

The figure illustrates the snowflake.png file.

![snowflake.svg file rendered to PNG](snowflake.png#center)

## **Convert SVG to BMP**

BMP image files save their image quality and store color data for each pixel without any compression, but large file sizes make them unsuitable for use on the web. This format is also not suitable for prepress production because it is limited to RGB. 

Aspose.SVG API can convert a document from SVG to BMP save format using several stages:

 - Open the source SVG document ([conclusion.svg](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/converting/conclusion.svg)).
 - Use the [ImageRenderingOptions()](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagerenderingoptions/constructors/1) constructor and specify the `Format` property of the document.
 - Create a new instance of the [ImageDevice](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagedevice) class.
 - Convert the document by [RenderTo()](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument/methods/renderto) method. 

```c#
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Rendering;
using Aspose.Svg.Rendering.Image;
...

    // Open a source SVG document
     using (var document = new SVGDocument(Path.Combine(DataDir, "conclusion.svg")))
    {
       // Create ImageDevice, set image Format and specify the output file to render
       using (IDevice device = new ImageDevice(new ImageRenderingOptions(ImageFormat.Bmp), Path.Combine(OutputDir, "conclusion_out.bmp")))
       {
           // Render SVG to BMP
    	   document.RenderTo(device);
       }
    }
```

The [ImageRenderingOptions()](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagerenderingoptions/constructors/1) constructor initializes an instance of the ImageRenderingOptions class that is passed to the [ImageDevice()](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagedevice/constructors/3) constructor. The [ImageDevice(`options` ,  `file`)](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagedevice/constructors/3) constructor takes the `options` ,  `file`  and creates the instance of the ImageDevice class. The [RenderTo(`device`)](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument/methods/renderto) method takes the instance of the ImageDevice class and renders SVG to BMP.

## **Convert SVG to TIFF**

TIFF is a format for storing raster graphics images with a broad palette of colors. TIFF is supported by scanning, faxing, word processing, optical character recognition, image manipulation, and page-layout applications. It is widely used for polygraphy and magazine offset printing.

Aspose.SVG API can convert a document from SVG to TIFF save format using several stages:

- Open a source SVG document ([conclusion.svg](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/converting/conclusion.svg)).
- Use the [ImageRenderingOptions()](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagerenderingoptions/constructors/1) constructor and specify `Format`  and other properties of the document.
- Create a new instance of the [ImageDevice](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagedevice) class.
- Convert the document by [RenderTo()](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument/methods/renderto) method.

```c#
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Rendering;
using Aspose.Svg.Rendering.Image;
... 
    
    // Open a source SVG document
    using (var document = new SVGDocument(Path.Combine(DataDir, "conclusion.svg")))
    {
        // Initialize an instance of the ImageRenderingOptions class and set Format and Compression properties
        var tiffOptions = new ImageRenderingOptions(ImageFormat.Tiff);
        tiffOptions.Compression = Compression.None;

        // Initialize an instance of the ImageDevice class and specify the output file to render
        using (IDevice device = new ImageDevice(tiffOptions, Path.Combine(OutputDir, "conclusion.tiff")))
        {
            // Render SVG to TIFF
            document.RenderTo(device);                    
        }
    }
```

The [ImageRenderingOptions()](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagerenderingoptions/constructors/1) constructor initializes an instance of the ImageRenderingOptions class that is passed to the [ImageDevice()](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagedevice/constructors/3) constructor. The [ImageDevice(`options` ,  `file`)](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagedevice/constructors/3) constructor takes the `options` ,  `file`  and creates the instance of the ImageDevice class. The [RenderTo(`device`)](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument/methods/renderto) method takes the instance of the ImageDevice class and renders SVG to TIFF.

The [ImageRenderingOptions](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagerenderingoptions) class provides numerous properties that give you full control over a wide range of parameters and improve the process of converting SVG to TIFF format. For example,the  `Compression` property allows setting the compression for the TIFF file format. In the example above, we put `Compression.None`.


## **Convert SVG to GIF**

GIF is a popular image format that supports animated images and is frequently used in web publishing. The following code snippet shows how to convert SVG to GIF using Aspose.SVG for .NET API:
 - Open a source SVG document ([owl.svg](https://docs.aspose.com/svg/net/drawing-basics/svg-path-data/owl.svg)).
 - Create an instance of the [ImageSaveOptions](https://apireference.aspose.com/svg/net/aspose.svg.saving/imagesaveoptions) class  and specify `Format` and other save options.
 - Use the [ConvertSVG()](https://apireference.aspose.com/svg/net/aspose.svg.converters.converter/convertsvg/methods/1) method to save SVG as a GIF file.

The following example shows how to use the ImageSaveOptions and create the output image with custom `PageSetup` characteristics:
```c#
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Drawing;
using Aspose.Svg.Saving;
using Aspose.Svg.Converters;
...
    
    // Initialize an SVG document from a file
    using (var document = new SVGDocument(Path.Combine(DataDir, "owl.svg")))
    {
        // Initialize an instance of the ImageSaveOptions class and set PageSetup property
        var saveOptions = new ImageSaveOptions(ImageFormat.Gif);
        saveOptions.PageSetup.AnyPage = new Page(new Drawing.Size(400, 600), new Margin(20, 20, 20, 20));
        
        // Convert SVG to GIF
        Converter.ConvertSVG(document, saveOptions, Path.Combine(OutputDir, "owl.gif"));             
    }
```

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-svg/Aspose.SVG-Documentation). About downloading from GitHub and running examples, you find out from the [**How to Run the Examples**](http://docs.aspose.com/svg/net/how-to-run-the-tests) section.
{{% /alert %}} 

