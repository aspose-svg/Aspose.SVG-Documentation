---
title: Image Vectorization Examples | .NET
linktitle: Image Vectorization Examples
type: docs
weight: 20
url: /net/how-to-work-with-aspose-svg-api/image-vectorization-examples/  
lastmod: 2021-10-30
description: This article explains how to convert bitmap to vector graphic using the Aspose.SVG API. You will learn how to vectorize raster images such as PNG, JPG, BMP, TIFF, GIF, ICO into an SVG document.
keywords: image vectorization, vectorize raster images,  c# example 
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

{{% alert color="primary" %}} 
Aspose.SVG offers a Free Online [**Image Vectorizer**](https://products.aspose.app/svg/en/image-vectorization)  that is browser-based and works on any platform. Using this App, you may apply a set of options for obtaining the perfect result. Save your time and check this free Image Vectorizer to get all the benefits of vector graphics!
{{% /alert %}} 

<a href="https://products.aspose.app/svg/en/image-vectorization" target="_blank">![Text "Banner Image Vectorizer"](image-vectorizer.png#center)</a>

## **How to Convert Raster Image to Vector Graphic**

There are two types of images: vector and bitmap. Which type you use will depend on the situation. A bitmap is a two-dimensional array that maps colors to pixels at a particular location. A raster image is a much larger file than a vector one. Raster formats are suitable for photographs or pictures with color gradients. But one of their main disadvantages is the losing quality when scaling. Vector graphics allow you to scale images without losing quality and can sometimes significantly reduce their size. The best suited for the vector format are logos, icons, page layouts, maps, graphs, line arts, illustrations.

This article considers a few C# examples that demonstrate the  [ImageVectorization](https://apireference.aspose.com/svg/net/aspose.svg.imagevectorization) functionalities and the effect of configuration properties on the vectorization result.

### **Example 1. Use of the TraceSimplifier property**

The [ImageVectorization](https://apireference.aspose.com/svg/net/aspose.svg.imagevectorization) Namespace includes a set of classes and interfaces that allows implementation of the image vectorization process. The provided classes and methods enable you to work with various options for preprocessing images before saving them to vector format. The processing assumes control of the following options.

Aspose.Svg.ImageVectorization Namespace aims to implement image vectorization tasks and 

 Aspose.HTML API provides [ImageVectorization](https://apireference.aspose.com/svg/net/aspose.svg.imagevectorization) Namespace that realizes various classes that allow implementation of the image vectorization process.

The following code snippet demonstrates the use of the [TraceSimplifier](https://apireference.aspose.com/svg/net/aspose.svg.imagevectorization/imagevectorizerconfiguration/properties/tracesimplifier) property for image vectorization.

The following code snippet demonstrates the use of different values of the TraceSimplifier property for image vectorization.

```c#
using System.IO;
using Aspose.Svg.ImageVectorization;
using Aspose.Svg.Saving;
...
	var vectorizer1 = new ImageVectorizer
    {
        Configuration =  {
        TraceSmoother =   new ImageTraceSmoother(2),
        TraceSimplifier = new ImageTraceSimplifier(0.1f),
        PathBuilder = new PathBuilder(0.1f),
        ColorsLimit = 2
        }
    };

    var vectorizer2 = new ImageVectorizer
    {
        Configuration =  {
        TraceSmoother =   new ImageTraceSmoother(2),
        TraceSimplifier = new ImageTraceSimplifier(1),
        PathBuilder = new PathBuilder(0.1f),
        ColorsLimit = 2
        }
    };
    
	
	using var document1 = vectorizer1.Vectorize(Path.Combine(DataDir, "formats.png"));
	using var document2 = vectorizer2.Vectorize(Path.Combine(DataDir, "formats.png"));

    
	document1.Save(Path.Combine(OutputDir, "formats1.svg"));
    document2.Save(Path.Combine(OutputDir, "formats2.svg"));
```

!["Vectorized images with different values of the TraceSimplifier property"](trace-simplifier.png#center)

{{% alert color="primary" %}} 
You can download the complete C# examples and data files from [**GitHub**](https://github.com/aspose-svg/Aspose.SVG-Documentation/tree/main/content/tests-net). About downloading from GitHub and running examples, you find out from the [**How to Run the Examples**](http://docs.aspose.com/svg/net/how-to-run-the-tests) section.
{{% /alert %}}

### **Example 2. Use of the TraceSmoother property**

```c#
using System.IO;
using Aspose.Svg.ImageVectorization;
using Aspose.Svg.Saving;
...
    
    
```

## **Example 3. Photo Vectorization**

```c#
using System.IO;
using Aspose.Svg.ImageVectorization;
using Aspose.Svg.Saving;
...

	// Initialize an instance of the ImageVectorizer class
    var vectorizer = new ImageVectorizer
    {
        Configuration =  {
        TraceSmoother =   new ImageTraceSmoother(1),
        TraceSimplifier = new ImageTraceSimplifier(0.3f),
        PathBuilder = new PathBuilder(0.2f),
        ColorsLimit = 25
        }
    };

    // Vectorize raster image from the specified file
    using var document = vectorizer.Vectorize(Path.Combine(DataDir, "horses.jpg"));

    // Prepare an output path for an SVG document saving
    string savePath = Path.Combine(OutputDir, "horses2.svg");

    // Save vectorized image as SVG file 
	document.Save(savePath);
```

!["Source photo and Vectorized photo"](photo-horses.png#center)

The source photo and resulting SVG file you may find and view in details by following the links - [horses.png](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/vectorization/horses.png), [horses.svg](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/vectorization/horses.svg).

Number of colors can be easily increased or reduced to adjust printing budget

Vector programs best for creating logos, drawings and illustrations, technical drawings. It is not the best format for continuous tone images with blends of color or to edit photographs

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-svg/Aspose.SVG-Documentation). About downloading from GitHub and running examples, you find out from the [**How to Run the Examples**](http://docs.aspose.com/svg/net/how-to-run-the-tests) section.
{{% /alert %}} 



