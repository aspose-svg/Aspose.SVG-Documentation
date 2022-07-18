---
title: Vectorization - Basic Overview | .NET
linktitle: Vectorization - Basic Overview 
type: docs
weight: 80
lastmod: 2022-01-10
changefreq: weekly
priority: 0.7
description: The articles in this section explain how to convert SVG text to vector and how to convert raster image to vector graphic using the Aspose.SVG API.
keywords: text vectorization, image vectorization, svg text, bitmap to vector, image to vector, text to vector, vectorize raster images, vector image, text security, vectorize text, raster and vector, c# example 
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

{{% alert color="primary" %}} 

In this section, under vectorization, we mean the process of replacing bitmaps or SVG text with mathematic curves, geometric shapes made up from path elements and stored as SVG. The articles in this section explain how to convert **SVG text to vector** and how to convert **raster image to vector** graphic using the Aspose.SVG API. Convert your raster documents to vector graphic!

[Image Vectorization Workflow](/svg/net/how-to-work-with-aspose-svg-api/image-vectorization-workflow/) - You will find image vectorization info, a description of the image vectorization process and vectorization options, learn how to vectorize raster images such as PNG, JPG, BMP, TIFF, GIF, ICO into an SVG document.

[Image Vectorization Examples](/svg/net/how-to-work-with-aspose-svg-api/image-vectorization-examples/) - You will consider a few C# examples that demonstrate the [ImageVectorization](https://reference.aspose.com/svg/net/aspose.svg.imagevectorization) functionalities and the effect of configuration properties on the vectorization result.

[Text Vectorization](/svg/net/how-to-work-with-aspose-svg-api/text-vectorization/) - This article explains how to convert SVG text to vector using the [VectorizeText](https://reference.aspose.com/svg/net/aspose.svg.saving/svgsaveoptions/properties/vectorizetext) property of the SVGSaveOptions class.

 {{% /alert %}} 

**What does Image Vectorization mean?**

There are two ways to represent a two-dimensional image, raster and vector graphics. In raster formats image represents a two-dimensional grid of pixels. This is great for storing pictures and photos, but scaling such images usually leads to quality loss - it becomes blurry and pixelated. In vector graphics, an image is constructed from elements described by mathematical curves, splines, paths and lines. Vector images are constructed and stored as a set of commands, numbers, formulas, not in a pixel grid as in bitmaps. As a result, it is possible to transform such images without quality loss.  The process of image conversion from raster to vector is called image vectorization.

Converting an image to vector is very easy using Aspose.SVG API. The [ImageVectorization](https://reference.aspose.com/svg/net/aspose.svg.imagevectorization) Namespace includes classes and  interfaces for implementing the image vectorization process. The following code snippet demonstrates the use of the [ImageVectorizer](https://reference.aspose.com/svg/net/aspose.svg.imagevectorization/imagevectorizer) class for image vectorization:

```c#
using System.IO;
using Aspose.Svg.ImageVectorization;
using Aspose.Svg.Saving;
...
    
	// Initialize an instance of the ImageVectorizer class
    var vectorizer = new ImageVectorizer
    {
        Configuration = 
		{
			TraceSmoother =   new ImageTraceSmoother(1),
			TraceSimplifier = new ImageTraceSimplifier(0.5f),
			ColorsLimit = 3
		}
    };

    // Vectorize raster image from the specified file
	using var document = vectorizer.Vectorize(Path.Combine(DataDir, "owl.png"));

    // Save vectorized image as SVG file 
	document.Save(Path.Combine(OutputDir, "olw.svg"));
```

**What is meant by Text Vectorization?**

Text Vectorization is the process of converting text into digital graphics. In the vectorized SVG text, all font glyphs are replaced with the combination of **path**, **use**, **mask**, **g** elements, etc. Thus, vectorization promotes text protection from simple copying, unwanted using, borrowing, and modification.


 Aspose.SVG proposes you convert text to vector in a short time and with professional quality and resolution! In the vectorized SVG text, all font glyphs are replaced with a combination of graphics elements. Convert your SVG text with our <a href="https://products.aspose.app/svg/text-to-vector" target="_blank">**Text to Vector** </a> app and get all the advantages of vectorized text!

<a href="https://products.aspose.app/svg/text-to-vector" target="_blank">![Text "Banner Text to Vector application"](svg-text-vectorizer.png#center)</a>



