---
title: How to Merge SVG Documents - C# Examples
linktitle: How to Merge SVG Documents
type: docs
weight: 70
aliases: /net/how-to-work-with-aspose-svg-api/how-to-merge-svg-documents/
lastmod: 2022-10-17
description: You will learn how to merge multiple SVG to PDF, XPS or Image formats using Render() method and find C# examples of SVG merging.
keywords: svg merger, merge svg, svg document, svg file example, C# example, svg to png, Render () method
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

Aspose.SVG for .NET API provides the [Renderer](https://reference.aspose.com/svg/net/aspose.svg.rendering/renderer/) class for rendering and merging SVG documents. The article provides information about the Render() method used to convert SVG documents to another format and merge them into a single file. You will learn how to merge multiple SVG documents to PDF, XPS or Image formats and find C# examples of SVG merging.

{{% alert color="primary" %}} 
Aspose.SVG offers Free Online **[SVG Sprite Generator](https://products.aspose.app/svg/svg-sprite-generator)**. Merge multiple SVG files to sprite and make your website faster and better!
{{% /alert %}} 

<a href="https://products.aspose.app/svg/svg-sprite-generator" target="_blank">![Text "Banner SVG Sprite Generator"](svg-sprite-creator.png#center)</a>

## **Rendering SVG documents**

Rendering of SVG files is the process of generating images from a 2D model by means of the API. Converting from SVG to other formats can perform by using  **Render (`IDevice, TDocument`)** method of the [Renderer](https://reference.aspose.com/svg/net/aspose.svg.rendering/renderer/) class.

In the [**How to Convert SVG Files**](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/converting/) section, we consider two conversion scenarios: using [ConvertSVG()](https://reference.aspose.com/svg/net/aspose.svg.converters/converter/) methods and  [RenderTo()](https://reference.aspose.com/svg/net/aspose.svg/svgdocument/renderto/)  method. This article considers the **Render()** method applying for SVG conversion to other formats - PDF, XPS, JPG, JPG, BMP, PNG, TIFF and GIF.

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
You can try to merge SVG files to a variety of other image formats with our free online [**Image Merger**](https://products.aspose.app/svg/merger). The application allows you to freely add any images, rotate, scale, add backgrounds, filters and move each element. You can use a set of intuitive combining options that allow you to flexibly control the creation of an image collage and achieve the desired result. With the Image Merger app, you will make image collages easily within minutes. Try our forceful application for free now!
{{% /alert %}}

<a href="https://products.aspose.app/svg/merger" target="_blank">![Text "Banner SVG Converter"](image-merger.png#center)</a>

## **Merging SVG documents**

The **Render()** method gives you the ability to send multiple documents at once to the output rendering device and merge them. Documents merging ([owl.svg](https://docs.aspose.com/svg/net/drawing-basics/svg-path-data/owl.svg), [conclusion.svg](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/converting/conclusion.svg), [lineto.svg](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/saving-svg-documents/lineto.svg)) can be done with a few lines of code:

```c#
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Rendering;
using Aspose.Svg.Rendering.Pdf;
...   
	
	// Initialize SVG documents from files to merge later
    using (var document1 = new SVGDocument(Path.Combine(DataDir, "owl.svg")))
    using (var document2 = new SVGDocument(Path.Combine(DataDir, "conclusion.svg")))
    using (var document3 = new SVGDocument(Path.Combine(DataDir, "lineto.svg")))
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
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-svg/Aspose.SVG-Documentation). About downloading from GitHub and running examples, you find out from the [**How to Run the Examples**](https://docs.aspose.com/svg/net/how-to-run-the-tests/) section.
{{% /alert %}} 

