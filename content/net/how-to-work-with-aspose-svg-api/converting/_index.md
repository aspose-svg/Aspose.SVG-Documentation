---
title: How to Convert SVG Files
description: SVG Converters, Convert SVG to PDF, SVG to XPS, SVG to PNG, SVG to
  BMP, SVG to JPG, SVG to TIFF, SVG to GIF, Convert SVG to Image
weight: 25
type: docs
aliases: /net/how-to-work-with-aspose-svg-api/converting/
lastmod: 2020-12-15
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

Converting SVG documents to other formats is one of the main features of Aspose.SVG for .NET API. Converting is required for various reasons: to work in a familiar, convenient format or to take advantage of different formats for specific tasks.

Aspose.SVG for .NET API can convert [SVG](https://docs.aspose.com/svg/net/what-is-an-svg-document/) Image files to [XPS](https://docs.fileformat.com/page-description-language/xps/), [PDF](https://docs.fileformat.com/pdf/), [PNG](https://docs.fileformat.com/image/png/), [JPEG](https://docs.fileformat.com/image/jpeg/), [BMP](https://docs.fileformat.com/image/bmp/), [GIF](https://docs.fileformat.com/image/gif/), and [TIFF](https://docs.fileformat.com/image/tiff/) file formats. You can use API in your C# or any other .NET application (such as VB.NET) to develop converter applications without getting into the details of underlying file formats. 

{{% alert color="primary" %}} 

You can try to convert SVG documents to a variety of other formats with our [Free online converter](https://products.aspose.app/svg/conversion).

{{% /alert %}} 

## **SVG Converters**

Converting from SVG  to other formats can perform by using **ConvertSVG()** methods of the **[Converter](https://apireference.aspose.com/svg/net/aspose.svg.converters/converter)** class,  the **RenderTo(`IDevice device`)**  method of the **[SVGDocument](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument)** class or the **Render (`IDevice, TDocument`)** method of the **[Renderer](https://apireference.aspose.com/svg/net/aspose.svg.rendering/renderer)** class (see **[How to Merge SVG Documents](http://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/how-to-merge-svg-documents/)** section).

The current section describes supported scenarios of SVG files conversions to other popular formats by using **Converter** and **SVGDocument** classes:

1. The static **Converter** class is a shared facade that provides SVG files conversions to the popular formats and allows to make these operations convenient and easy. 
   There is a wide range of the **ConvertSVG()**  methods that take as an argument the source document, save options, output file path and convert SVG to PDF, XPS or image files.
2. The **RenderTo()** method of the **SVGDocument** class is used to render SVG to other format and send a document to the output device. Aspose.SVG API provides the following output devices implementation:  the **PdfDevice**, **XpsDevice** and **ImageDevice** classes, which perform rendering to PDF, XPS and Image file formats respectively. 

Let's consider both scenarios of conversion SVG document to another file format, for example, to PNG:

{{% alert color="primary" %}} 
You can download the complete examples and data files from **[GitHub](https://github.com/aspose-svg/Aspose.SVG-Documentation)**. About downloading from GitHub and running examples, you find out from the[ **How to Run the Examples**](http://docs.aspose.com/svg/net/how-to-run-the-tests) section.
{{% /alert %}}  

### **Using  ConverterSVG() method**

Converting a file to other format using the **ConvertSVG()** method is a sequence of operations among which document loading and saving:

* Load an SVG document using one of the **SVGDocument()** constructors ([light.svg](http://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/converting/light.svg)).
* Create an instance of the **[ImageSaveOptions](https://apireference.aspose.com/svg/net/aspose.svg.saving/imagesaveoptions)** class.
* Use one of the **[ConvertSVG()](https://apireference.aspose.com/svg/net/aspose.svg.converters/converter/methods/index)** methods to save SVG as a PNG file.

{{< highlight java >}}
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Drawing;
using Aspose.Svg.Rendering;
using Aspose.Svg.Rendering.Pdf;
...
	
	// Initialize an SVG document from a file
	using (var document = new SVGDocument(Path.Combine(DataDir, "light.svg")))
	{
	     // Initialize an instance of PdfRenderingOptions class and set a custom PageSetup and JpegQuality properties
		 var pdfRenderingOptions = new PdfRenderingOptions();
	     pdfRenderingOptions.PageSetup.AnyPage = new Page(new Size(500, 500), new Margin(10, 10, 10, 10));
	     pdfRenderingOptions.JpegQuality = 10;
	     
		 // Initialize an instance of PdfDevice class
	     using (IDevice device = new PdfDevice(pdfRenderingOptions, Path.Combine(OutputDir, "light_out.pdf")))
	     {
	         // Render SVG to PDF, send the document to the rendering device
			 document.RenderTo(device);
	     }
	 }
 {{< /highlight >}}	

In the example, the **ImageSaveOptions()** constructer initialize an instance of **ImageSaveOptions** class that is passed to **ConvertSVG()** method. The **ConvertSVG(`SVGDocument source, ImageSaveOptions options, string outputPath`)** method takes the required attributes and performs the conversion operation.

### **Using  RenderTo() method**

To convert SVG to PNG using the **RenderTo()** method takes the following stages:

* Initialize a document using one of the **SVGDocument()** constructors ([light.svg](http://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/converting/light.svg)).
* Produce an instance of the **[ImageRenderingOptions](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagerenderingoptions)** class.
* Create a new instance of the **[ImageDevice](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagedevice)** class, pass an instance of the **ImageRenderingOptions** class and output file path to the **ImageDevice()** method.
* Convert the document by **[RenderTo()](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument/methods/renderto)** method. 

{{< highlight java >}}
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Rendering.Image;
...
	// Open the source SVG document 
	using (var document = new SVGDocument(Path.Combine(DataDir, "light.svg")))
	{
	    // Initialize an instance of ImageRenderingOptions class 
		var pngOptions = new ImageRenderingOptions();	    


	// Initialize an instance of ImageDevice class and specify the output file to render
    using (var device = new ImageDevice(pngOptions, Path.Combine(OutputDir, "light_out.png")))
    {
        // Render SVG to PNG
		document.RenderTo(device);
	}
}

{{< /highlight >}}

In order to convert SVG to PNG format, the **RenderTo(`IDevice device`)** method converts and sends the current document to the output rendering device. The **ImageDevice(`PdfRenderingOptions, string`)** constructor takes as arguments an instance of **ImagrRenderingOptions** class and output file name and initializes a new instance  (device) of the **ImageDevice** class. 

### **General Options**

You can customize the rendering process by specifying the page size, margins, background color, etc.  For converting SVG to all mentioned above formats, from the **RenderingOptions** class the following properties are inherited: **`BackgroundColor`**, **`Css`**, **`HorizontalResolution`**, **`PageSetup`**, and **`VerticalResolution`**.

Every output device **PdfDevice**, **XpsDevice** and **ImageDevice** has his own unique set of options implemented with classes **PdfRenderingOptions**, **XpsRenderingOptions** and **ImageRenderingOptions** respectively.

The options that are implementing with classes **PdfSaveOptions**, **XpsSaveOptions** and **ImageSaveOptions**  are inheriting from **PdfRenderingOptions**, **XpsRenderingOptions** and **ImageRenderingOptions**  classes respectively.

## **Convert SVG to PDF**

PDF is a file format supported by all operating systems,  used for presenting images, documents and books. Files in PDF can be easily viewed, printed, and shared online. 

Consider SVG to PDF conversion scenario using **RenderTo()** method:

* Initialize a document using  **SVGDocument()** constructer ([light.svg](http://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/converting/light.svg)).
* Initialize an instance of the **[PdfRenderingOptions](https://apireference.aspose.com/svg/net/aspose.svg.rendering.pdf/pdfrenderingoptions)** class and specify the document's properties.
* Create a new instance of the **[PdfDevice](https://apireference.aspose.com/svg/net/aspose.svg.rendering.pdf/pdfdevice)** class, pass the **PdfRenderingOptions** and output file path to **PdfDevice()** method.
* Convert the document by **[RenderTo()](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument/methods/renderto)** method. 

To convert SVG to PDF, you can use **`JpegQuality`** and **`Encryption`** properties available only for the **PdfRenderingOptions** class.

The following code snippet can be used to convert an SVG file to PDF format:

{{< highlight java >}}
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Drawing;
using Aspose.Svg.Rendering;
using Aspose.Svg.Rendering.Pdf;
...
	
	// Initialize an SVG document from a file
	using (var document = new SVGDocument(Path.Combine(DataDir, "light.svg")))
	{
	     // Initialize an instance of PdfRenderingOptions class and set a custom PageSetup and JpegQuality properties
		 var pdfRenderingOptions = new PdfRenderingOptions();
	     pdfRenderingOptions.PageSetup.AnyPage = new Page(new Size(500, 500), new Margin(10, 10, 10, 10));
	     pdfRenderingOptions.JpegQuality = 10;
	\
		 // Initialize an instance of PdfDevice class
	     using (IDevice device = new PdfDevice(pdfRenderingOptions, Path.Combine(OutputDir, "light_out.pdf")))
	     {
	         // Render SVG to PDF, send the document to the rendering device
			 document.RenderTo(device);
	     }
	 }
 {{< /highlight >}}	

In order to convert SVG to PDF format, Aspose.SVG for .NET API offers **PdfRenderingOptions** class which initializes a new object, with rendering options, that is passed as an argument to the **PdfDevice(`PdfRenderingOptions, string`)** constructor. The last initializes a new instance of **PdfDevice** class by rendering options and output file name.  The **RenderTo(`IDevice device`)**  method converts and sends the current document to the output rendering device.

The **`JpegQuality`** specifies the quality of JPEG compression for images. The default is 95.  In the example above, the used **`JpegQuality`** value is 10.  The figure illustrates conversion SVG to PDF for two files [light.svg](http://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/converting/light.svg) and [Lineto2.svg](https://docs.aspose.com/svg/net/drawing-basics/svg-path-data/Lineto2.svg): a) **`JpegQuality`** value is the default; b) **`JpegQuality`** value is 10.

![Images rendered to PDF with various JpegQuality values](JpegQualityPDF.png#center)

## **Convert SVG to XPS**

The static methods of the **Converter** class can convert SVG to XPS  with a single line of code. It is the easiest way to conversion. Converting a file to other format using the **ConvertSVG()** method is a sequence of operations among which document loading and saving: 

* Load an SVG document using one of the **SVGDocument()** constructors ([light.svg](http://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/converting/light.svg)).
* Create an instance of the **[XpsSaveOptions](https://apireference.aspose.com/svg/net/aspose.svg.saving/xpssaveoptions)** class.
* Use the **[ConvertSVG()](https://apireference.aspose.com/svg/net/aspose.svg.converters/converter/methods/index)** method to save SVG as an XPS file. 

The following code snippet can be used to convert an SVG file to XPS format:

{{< highlight java >}}
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Converters;
using System.Drawing;
using Aspose.Svg.Saving;
...

```
// Initialize an SVG document from a file
using (var document = new SVGDocument(Path.Combine(DataDir, "light.svg")))
{
    // Initialize an instance of XpsSaveOptions class
    var saveOptions = new XpsSaveOptions();
    saveOptions.BackgroundColor = Color.Gray;

    // Convert SVG to XPS
    Converter.ConvertSVG(document, saveOptions, Path.Combine(OutputDir, "light.xps"));
}
```

{{< /highlight >}}

The **XpsSaveOptions()** constructer initialize an instance of the **XpsSaveOptions** class that is passed to **ConvertSVG()** method.
The **ConvertSVG()** method  takes the `SVGDocument`, `XpsSaveOptions`, and output file path and performs the conversion operation. 

In the example above, we add the **`BackgroundColor`** property that sets `Color` which will fill the background of every page. The default value is `Transparent`.

## **Convert SVG to Image**

Image file conversion is required for website developing, graphic designers acting, photography, and other purposes. The choice of the image format depends on whether you print it in polygraphy, send by e-mail or put an image on a webpage.

 In this chapter, you will find information on how to convert an SVG to image file formats such as  BMP, JPEG, PNG, TIFF, and GIF. You can use the properties inherited from the **RenderingOptions**  class to control image options, as well as  the **`Compression`**, **`Format`**, **`SmoothingMode`**, and **`Text`** properties that are available for the **ImageRenderingOptions** and **ImageSaveOptions** classes only.

{{% alert color="primary" %}} 

You can check the quality of SVG to image files conversion at this link: https://products.aspose.app/svg/conversion

{{% /alert %}} 

### **Convert SVG to BMP**

BMP image files save their image quality and store color data for each pixel without any compression, but large file sizes make them unsuitable for use on the web. This format is also not suitable for prepress production because it is limited to RGB. 

Aspose.SVG API can convert a document from SVG to BMP save format using several stages:

* Open the source SVG document ([conclusion.svg](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/converting/conclusion.svg)).
* Use the **[ImageRenderingOptions()](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagerenderingoptions/constructors/1)** constructor and specify `Format` property of the document.
* Create a new instance of the **[ImageDevice](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagedevice)** class.
* Convert the document by **[RenderTo()](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument/methods/renderto)** method. 

{{< highlight java >}}
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Rendering.Image;
...

```
// Open a source SVG document
 using (var document = new SVGDocument(Path.Combine(DataDir, "conclusion.svg")))
{
   // Create the ImageDevice, set image Format and specify output file to render
   using (IDevice device = new ImageDevice(new ImageRenderingOptions(ImageFormat.Bmp), Path.Combine(OutputDir, "conclusion_out.bmp")))
   {
       // Render SVG to BMP
	   document.RenderTo(device);
   }
}
```

{{< /highlight >}}

To convert an SVG file to BMP format, Aspose.PDF for .NET offers the **RenderTo()** method that takes the instance of **ImageDevice** class which is created by **ImageDevice**() constructor that takes as an argument the **ImageRenderingOptions** class object.

### **Convert SVG to JPEG**

JPEG is one of the most commonly used image formats. Its uniqueness is the controlled quality loss during compression. So it is widely used to storing and sending over the web graphic digital content (photos, scanned copies, digitized pictures).

Consider how to convert a document from SVG to JPEG using **RenderTo()** method:

* Open the source SVG document ([owl.svg](https://docs.aspose.com/svg/net/drawing-basics/svg-path-data/owl.svg)).
* Use the **[ImageRenderingOptions()](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagerenderingoptions/constructors/1)** constructor and specify properties of the document.
* Create a new instance of the **[ImageDevice](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagedevice)** class - the output device.
* Convert the document by **[RenderTo()](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument/methods/renderto)** method.

 The following example shows how to apply the **`Format`** and **`SmoothingMode`** properties in SVG to JPEG converting: 

{{< highlight java >}}
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Rendering.Image;
using System.Drawing.Drawing2D;
...
    // Initialize an SVG document from a file
    using (var document = new SVGDocument(Path.Combine(DataDir, "owl.svg")))
    {
        // Set Format and SmoothingMode for jpgOptions1
        var jpegOptions1 = new ImageRenderingOptions(ImageFormat.Jpeg);
        jpegOptions1.SmoothingMode = SmoothingMode.AntiAlias;

```
    // Set Format and SmoothingMode for jpgOptions2
    var jpegOptions2 = new ImageRenderingOptions(ImageFormat.Jpeg);
    jpegOptions2.SmoothingMode = SmoothingMode.Default;

    // Initialize an instance of ImageDevice class and specify the output file to render
    using (IDevice device = new ImageDevice(jpegOptions1, Path.Combine(OutputDir, "owl_out1.jpg")))
    {
        // Render SVG to JPEG
        document.RenderTo(device);
    }
    using (IDevice device = new ImageDevice(jpegOptions2, Path.Combine(OutputDir, "owl_out2.jpg")))
    {
        document.RenderTo(device);
    }
}
```

{{< /highlight >}}

The **RenderTo()** method takes the instance of **ImageDevice** class which is created by the **ImageDevice()** constructor that accepts as an argument the **ImageRenderingOptions** class object.

The **`Format`** property sets image format. By default this property is `Png`. To convert SVG to JPEG you have to use `ImageFormat.Jpeg`.

![the resulting images fragments](SmoothingMode.png#center)

​                                                                      

In the example above we convert the SVG file [owl.svg](https://docs.aspose.com/svg/net/drawing-basics/svg-path-data/owl.svg) to JPEG with different **`SmoothingMode`** values. The figure illustrates zoomed (250%) JPEG images fragments: a) **`SmoothingMode`** property  is `AntiAlias` ; b) **`SmoothingMode`** property is  `Default`.

### **Convert SVG to PNG**

PNG  format uses a lossless compression algorithm to store raster images. It supports only the RGB color model and does not design for images print. PNG widely takes to transmit pictures over the network and display photos and graphics on web-pages and cloud drive repositories.

The following code snippet shows how to prepare an SVG file from scratch and convert it to PNG: 

* Prepare an SVG code and save it to a file.
* Create an instance of the **[ImageSaveOptions](https://apireference.aspose.com/svg/net/aspose.svg.saving/imagesaveoptions)** class.
* Use the **[ConvertSVG()](https://apireference.aspose.com/svg/net/aspose.svg.converters/converter/methods/index)** method to save SVG as a PNG file.

{{< highlight java >}}
using Aspose.Svg;
using System.IO;
using System.Drawing;
using Aspose.Svg.Saving;
using Aspose.Svg.Converters;
...

```
// Prepare an SVG code and save it to a file
var code = "<svg xmlns='http://www.w3.org/2000/svg'>" +
           "<circle cx='100' cy='150' r='50' stroke='#2F4F4F' stroke-width='4' fill='#FF7F50' />" +
           "<circle cx='180' cy='200' r='60' stroke='#2F4F4F' stroke-width='4' fill='#008B8B' />" +
           "</svg>";
File.WriteAllText("example.svg", code);

// Initialize an SVG document from the file
using (var document = new SVGDocument("example.svg"))
{
    // Initialize an instance of ImageSaveOptions class and set BackgroundColor property
    var saveOptions = new ImageSaveOptions();
    saveOptions.BackgroundColor = Color.Gainsboro;

    // Convert SVG to PNG
    Converter.ConvertSVG(document, saveOptions, Path.Combine(OutputDir, "output.png"));
}
```

{{< /highlight >}}

In the example,  the **ImageSaveOptions()** constructer initialize an instance of **ImageSaveOptions** class that is passed to **ConvertSVG()** method. The **ConvertSVG()** method takes the `document`, `saveOptions`, and output file path and performs the conversion operation.

Note, we do not specify the **`Format`** property for the conversion to PNG. The **ImageSaveOptions()** constructor takes `Png` as the default image format.

### **Convert SVG to TIFF**

TIFF is a format for storing raster graphics images with a broad palette of colors. TIFF is supported by scanning, faxing, word processing, optical character recognition, image manipulation, and page-layout applications. It is widely used for polygraphy and magazine offset printing.

Aspose.SVG API can convert a document from SVG to TIFF save format using several stages:

* Open a source SVG document ([conclusion.svg](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/converting/conclusion.svg)).
* Use the **[ImageRenderingOptions()](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagerenderingoptions/constructors/1)** constructor and specify `Format`  and other properties of the document.
* Create a new instance of the **[ImageDevice](https://apireference.aspose.com/svg/net/aspose.svg.rendering.image/imagedevice)** class.
* Convert the document by **[RenderTo()](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument/methods/renderto)** method.

{{< highlight java >}}
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Rendering;
using Aspose.Svg.Rendering.Image;
... 
    // Open source SVG document
    using (var document = new SVGDocument(Path.Combine(DataDir, "conclusion.svg")))
    {
        // Initialize an instance of ImageRenderingOptions class and set Format and Compression properties
        var tiffOptions = new ImageRenderingOptions(ImageFormat.Tiff);
        tiffOptions.Compression = Compression.None;

```
    // Initialize an instance of ImageDevice class and specify the output file to render
    using (IDevice device = new ImageDevice(tiffOptions, Path.Combine(OutputDir, "conclusion.tiff")))
    {
        // Render SVG to TIFF
        document.RenderTo(device);                    
    }
}
```

{{< /highlight >}}

The **RenderTo()** method takes the instance of the **ImageDevice** class which is created by **ImageDevice()** constructor that takes as an argument the **ImageRenderingOptions** class object.

The **`Compression`** property allows set compression for TIFF file format. By default this property is `LZW`. In the example above, we put `Compression.None`.

### **Convert SVG to GIF**

GIF is a popular image format that supports animated images and frequently used in web publishing. The following code snippet shows how to convert SVG to GIF using Aspose.SVG for .NET API:

* Open a source SVG document ([owl.svg](https://docs.aspose.com/svg/net/drawing-basics/svg-path-data/owl.svg)).
* Create an instance of the **[ImageSaveOptions](https://apireference.aspose.com/svg/net/aspose.svg.saving/imagesaveoptions)** class.
* Use the **[ConvertSVG()](https://apireference.aspose.com/svg/net/aspose.svg.converters/converter/methods/index)** method to save SVG as a GIF file.

The following example shows how to use the**ImageSaveOptions** and create the output image with custom **`PageSetup`** characteristics:
{{< highlight java >}}
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Drawing;
using Aspose.Svg.Saving;
using Aspose.Svg.Converters;
...
    // Initialize an SVG document from a file
    using (var document = new SVGDocument(Path.Combine(DataDir, "owl.svg")))
    {
        // Initialize an instance of ImageSaveOptions class and set PageSetup property
        var saveOptions = new ImageSaveOptions(ImageFormat.Gif);
        saveOptions.PageSetup.AnyPage = new Page(new Size(400, 600), new Margin(20, 20, 20, 20));

```
    // Convert SVG to GIF
    Converter.ConvertSVG(document, saveOptions, Path.Combine(OutputDir, "owl.gif"));             
}
```

{{< /highlight >}}

{{% alert color="primary" %}} 
You can download the complete examples and data files from **[GitHub](https://github.com/aspose-svg/Aspose.SVG-Documentation)**. About downloading from GitHub and running examples, you find out from the **[How to Run the Examples](http://docs.aspose.com/svg/net/how-to-run-the-tests)** section.
{{% /alert %}}