---
title: How to Merge SVG Documents
type: docs
weight: 70
aliases: /net/how-to-work-with-aspose-svg-api/how-to-merge-svg-documents/
lastmod: "2020-12-15"
description: Rendering SVG documents, Render SVG, Merging SVG documents, Merge SVG
---

Aspose.SVG for .NET API provides the [**Renderer**](https://apireference.aspose.com/svg/net/aspose.svg.rendering/renderer) class for rendering and merging SVG documents.

{{% alert color="primary" %}} 

You can try to convert SVG documents to a variety of other formats with our [Free online SVG converter](https://products.aspose.app/svg/conversion).

{{% /alert %}} 

## **Rendering SVG documents**

Rendering of SVG files is the process of generating an images from a 2D model by means of the API. Converting from SVG to other formats can perform by using  **Render (`IDevice, TDocument`)** method of the [**Renderer**](https://apireference.aspose.com/svg/net/aspose.svg.rendering/renderer) class.

In the [**How to convert SVG files**](http://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/converting/) section, we consider two conversion scenarios: using **ConverterSVG()** methods and **RenderTo()** method. In this chapter we consider the **Render ()** method applying for SVG conversion to other formats - PDF, XPS, JPEG, JPG, BMP, PNG, TIFF and GIF.

To convert SVG to another format, for example, PNG, use the following code snippet:
```c#
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Rendering;
using Aspose.Svg.Rendering.Image;
...   
	
	// Initialize an SVG document from a file
    using (var document = new SVGDocument(Path.Combine(DataDir, "owl.svg")))
    {
        // Create an instance of SvgRenderer
        using (var renderer = new SvgRenderer())
        {
            // Create an instance of ImageDevice
            using (var device = new ImageDevice(Path.Combine(OutputDir, "owl.png");))
            {
                // Render SVG to PNG
                renderer.Render(device, document);
            }
        }
    }

```

{{% alert color="primary" %}} 

You can try to merge SVG documents to a variety of other formats with our [Free Online SVG Merger](https://products.aspose.app/svg/merger).

{{% /alert %}}

## **Merging SVG documents**

The **Renderer()** method gives you the ability to send multiple documents at ones to the output rendering device and merge them. Documents merging ([owl.svg](https://docs.aspose.com/svg/net/drawing-basics/svg-path-data/owl.svg), [conclusion.svg](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/converting/conclusion.svg), [Lineto.svg](http://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/saving-svg-documents/Lineto.svg)) can be done with a few lines of code:

```c#
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Rendering;
using Aspose.Svg.Rendering.Pdf;
...   
	
	// Initialize SVG documents from files to merge later
    using (var document1 = new SVGDocument(Path.Combine(DataDir, "owl.svg")))
    using (var document2 = new SVGDocument(Path.Combine(DataDir, "conclusion.svg")))
    using (var document3 = new SVGDocument(Path.Combine(DataDir, "Lineto.svg")))
    {
        // Create an instance of SvgRenderer
        using (var renderer = new SvgRenderer())
        {
            // Create an instance of PdfDevice
            using (var device = new PdfDevice(Path.Combine(OutputDir, "result.pdf")))
            {
                // Merge all SVG documents to PDF
                renderer.Render(device, document1, document2, document3);
            }
        }
    }

```

You can merge SVG files to PDF, XPS, JPEG, JPG, BMP, PNG, TIFF and GIF formats.

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-svg/Aspose.SVG-Documentation). About downloading from GitHub and running examples, you find out from [**How to Run the Examples**](http://docs.aspose.com/svg/net/how-to-run-the-tests) section.
{{% /alert %}} 

