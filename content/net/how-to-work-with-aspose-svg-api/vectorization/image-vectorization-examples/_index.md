---
title: Image Vectorization Examples | .NET
linktitle: Image Vectorization Examples
type: docs
weight: 20
url: /net/how-to-work-with-aspose-svg-api/image-vectorization-examples/  
lastmod: 2022-01-10
changefreq: weekly
priority: 0.7
description: This article explains how to convert bitmap to vector graphic using the Aspose.SVG API. You will consider a few C# examples that demonstrate the Image Vectorization functionalities and the effect of configuration properties on the vectorization result.
keywords: image vectorization, vector graphic, raster image, image to vector, photo to vector, vectorize raster image, c# example 
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

{{% alert color="primary" %}} 
Aspose.SVG offers a Free Online [**Image Vectorizer**](https://products.aspose.app/svg/image-vectorization)  that is browser-based and works on any platform. Using this App, you may apply a set of options for obtaining the perfect result. Save your time and check this free Image Vectorizer to get all the benefits of vector graphics!
{{% /alert %}} 

<a href="https://products.aspose.app/svg/image-vectorization" target="_blank">![Text "Banner Image Vectorizer"](./../vectorization/image-vectorizer.png#center)</a>

## **How to Convert Raster Image to Vector Graphic**

There are two types of images: vector and bitmap. Which type you use will depend on the situation. A bitmap is a two-dimensional array that maps colors to pixels at a particular location. A raster image is a much larger file than a vector one. Raster formats are suitable for photographs or pictures with color gradients. But one of their main disadvantages is the losing quality when scaling. Vector graphics allow you to scale images without losing quality and can sometimes significantly reduce their size. The best suited for the vector format are logos, icons, page layouts, maps, graphs, line arts, illustrations. Image Vectorization is the process of converting a raster image to vector graphics - the Bezier curves, splines and lines. 

This article considers a few C# examples that demonstrate the  [ImageVectorization](https://apireference.aspose.com/svg/net/aspose.svg.imagevectorization) functionalities and the effect of configuration properties such as TraceSimplifier, TraceSmoother and PathBuilder, on the vectorization result.

For the [ColorLimit](https://apireference.aspose.com/svg/net/aspose.svg.imagevectorization/imagevectorizerconfiguration/properties/colorslimit) property,  25 colours are available. You can choose the required number of colors depending on the situation. The default value is 25. The [ImageSizeLimit](https://apireference.aspose.com/svg/net/aspose.svg.imagevectorization/imagevectorizerconfiguration/properties/imagesizelimit) property sets the maximal dimension of an image determined by multiplication image width and height. The size of the image will be scaled based on this property. The default value is 1800000.  

**Note:** Aspose.Svg.ImageVectorization Namespace aims to implement image vectorization tasks, so the source image to the raster-to-vector conversion may accept bitmap formats such as {{%JPG%}}, {{%PNG%}}, {{%BMP%}}, {{%TIFF%}},  {{%GIF%}}, etc. The output image is a vector {{%SVG%}} file format. 

### **Example 1. Use of the TraceSimplifier property**

The [ImageVectorization](https://apireference.aspose.com/svg/net/aspose.svg.imagevectorization) Namespace includes a set of classes and interfaces that allows implementation of the image vectorization process. The provided classes and methods enable you to work with various options for preprocessing images before saving them to vector format. The processing assumes control of the following vectorization options: TraceSimplifier, TraceSmoother, PathBuilder, ColorLimit and  ImageSizeLimit.

Let's look at how the TraceSimplifier property affects image vectorization. First of all, need to know that:
 -  the [ImageTraceSimplifier](https://apireference.aspose.com/svg/net/aspose.svg.imagevectorization/imagetracesimplifier) class is responsible for reducing the number of points in a curve that is approximated by a series of trace points;
 - the [ImageTraceSimplifier(`tolerance`)](https://apireference.aspose.com/svg/net/aspose.svg.imagevectorization/imagetracesimplifier/constructors/1)  constructor takes as a parameter the `tolerance` and initializes an instance of the ImageTraceSimplifier class;
 - the `tolerance` value determines the maximum error tolerance allowed for a point to be eliminated from the trace. It must be in the range of 0 to 4. The default value is 0.3.  

The following code snippet demonstrates the use of different values of the [TraceSimplifier](https://apireference.aspose.com/svg/net/aspose.svg.imagevectorization/imagevectorizerconfiguration/properties/tracesimplifier) property for image to vector conversion.

```c#
using System.IO;
using Aspose.Svg.ImageVectorization;
using Aspose.Svg.Saving;
...
	// Initialize an instance of the ImageVectorizer class and specify configuration properties
    var vectorizer1 = new ImageVectorizer
    {
        Configuration = 
		{
			TraceSimplifier = new ImageTraceSimplifier(0.1f),
			TraceSmoother =   new ImageTraceSmoother(2),                
			ColorsLimit = 2
        }
    };

    var vectorizer2 = new ImageVectorizer
    {
        Configuration =
		{
			TraceSimplifier = new ImageTraceSimplifier(1),
			TraceSmoother =   new ImageTraceSmoother(2),                
			ColorsLimit = 2
        }
    };

    var vectorizer3 = new ImageVectorizer
    {
        Configuration =
		{
			TraceSimplifier = new ImageTraceSimplifier(2),
			TraceSmoother =   new ImageTraceSmoother(2),                
			ColorsLimit = 2
        }
    };

    // Prepare path for source image file
    string sourcePath = Path.Combine(DataDir, "formats.png");

    // Vectorize raster image from the specified file
    using var document1 = vectorizer1.Vectorize(sourcePath);
    using var document2 = vectorizer2.Vectorize(sourcePath);
    using var document3 = vectorizer3.Vectorize(sourcePath);

    // Save vectorized image as SVG file
    document1.Save(Path.Combine(OutputDir, "formats1.svg"));
    document2.Save(Path.Combine(OutputDir, "formats2.svg"));
    document3.Save(Path.Combine(OutputDir, "formats3.svg"));
```

!["Vectorized images with different values of the TraceSimplifier property"](trace-simplifier.png#center)

{{% alert color="primary" %}} 
You can download the complete C# examples and data files from [**GitHub**](https://github.com/aspose-svg/Aspose.SVG-Documentation/tree/main/content/tests-net). About downloading from GitHub and running examples, you find out from the [**How to Run the Examples**](http://docs.aspose.com/svg/net/how-to-run-the-tests) section.
{{% /alert %}}

### **Example 2. Use of the TraceSmoother property**

Sometimes fragments of contours look like sawtooth waves. Let's look at how the TraceSmoother property affects contours' smoothing. Before you start, know that:

- the [ImageTraceSmoother](https://apireference.aspose.com/svg/net/aspose.svg.imagevectorization/imagetracesmoother) class is responsible for smoothing the number of points in a curve that is approximated by a series of trace points. This class implements the Nearest Neighbor approach;
 - the [ImageTraceSmoother(`severity`)](https://apireference.aspose.com/svg/net/aspose.svg.imagevectorization/imagetracesmoother/constructors/1) constructor takes as a parameter the `severity` and initializes an instance of the ImageTraceSmoother class;
 - the value of the `severity` determines the extent of the region considered by query point. It must be in the range of 0 to 20.   

Let's look at how the [TraceSmoother](https://apireference.aspose.com/svg/net/aspose.svg.imagevectorization/imagevectorizerconfiguration/properties/tracesmoother) property affects image vectorization:

```c#
using System.IO;
using Aspose.Svg.ImageVectorization;
using Aspose.Svg.Saving;
...
    
	// Initialize an instance of the ImageVectorizer class and specify configuration properties
    var vectorizer1 = new ImageVectorizer
    {
        Configuration =
		{
			TraceSmoother =   new ImageTraceSmoother(0),
			TraceSimplifier = new ImageTraceSimplifier(0.1f),                
			ColorsLimit = 2
        }
    };

    var vectorizer2 = new ImageVectorizer
    {
        Configuration =
		{
			TraceSmoother =   new ImageTraceSmoother(4),
			TraceSimplifier = new ImageTraceSimplifier(0.1f),                
			ColorsLimit = 2
        }
    };

    var vectorizer3 = new ImageVectorizer
    {
        Configuration =
		{
			TraceSmoother =   new ImageTraceSmoother(8),
			TraceSimplifier = new ImageTraceSimplifier(0.1f),
			ColorsLimit = 2
        }
    };

    // Prepare path for source image file
    string sourcePath = Path.Combine(DataDir, "flower.png");

    // Vectorize raster image from the specified file
    using var document1 = vectorizer1.Vectorize(sourcePath);
    using var document2 = vectorizer2.Vectorize(sourcePath);
    using var document3 = vectorizer3.Vectorize(sourcePath);

    // Save vectorized image as SVG file
    document1.Save(Path.Combine(OutputDir, "flower1.svg"));
    document2.Save(Path.Combine(OutputDir, "flower2.svg"));
    document3.Save(Path.Combine(OutputDir, "flower3.svg"));    
```

!["Vectorized images with different values of the TraceSmoother property"](trace-smoother.png#center)

### **Example 3. Use of the PathBuilder property**

The final step of image vectorization is to convert the tracing points to SVG path lines and Bezier curves and add them to the SVG document. To fit the curves going through each tracing point, in the PathBuilder class implementation, we use a Catmull-Roma spline, which is converted to Bezier curves. 

- The [PathBuilder](https://apireference.aspose.com/svg/net/aspose.svg.imagevectorization/pathbuilder) class is responsible for building path segments SVGPathSeg from the list of the trace points.
 - The [PathBuilder(`tension`)](https://apireference.aspose.com/svg/net/aspose.svg.imagevectorization/pathbuilder/constructors/1) constructor takes as a parameter the `tension` and initializes an instance of the PathBuilder class.
 - The `tension` value determines how sharply the curve bends at the (interpolated) control points. It must be in the range of 0 to 1. Any higher or lower values will be aligned with the minimum and maximum values of this range accordingly.

```c#
using System.IO;
using Aspose.Svg.ImageVectorization;
using Aspose.Svg.Saving;
...
    
	// Initialize an instance of the ImageVectorizer class
    var vectorizer1 = new ImageVectorizer
    {
        Configuration =
		{
			PathBuilder = new PathBuilder(0),
            TraceSmoother =   new ImageTraceSmoother(1),
			TraceSimplifier = new ImageTraceSimplifier(1),			
			ColorsLimit = 2
        }
    };
    
    var vectorizer2 = new ImageVectorizer
    {
        Configuration =
		{
			PathBuilder = new PathBuilder(1),
            TraceSmoother =   new ImageTraceSmoother(1),
			TraceSimplifier = new ImageTraceSimplifier(1),			
			ColorsLimit = 2
        }
    };

    // Prepare path for source image file
    string sourcePath = Path.Combine(DataDir, "cheese.png");

    // Vectorize raster image from the specified file
    using var document1 = vectorizer1.Vectorize(sourcePath);            
    using var document2 = vectorizer2.Vectorize(sourcePath);

    // Save vectorized image as SVG file
    document1.Save(Path.Combine(OutputDir, "cheese1.svg"));            
    document2.Save(Path.Combine(OutputDir, "cheese2.svg"));   
```

!["Vectorized images with different values of the PathBuilder property"](path-builder.png#center)



{{% alert color="primary" %}} 
You can download the complete C# examples and data files from [**GitHub**](https://github.com/aspose-svg/Aspose.SVG-Documentation/tree/main/content/tests-net). About downloading from GitHub and running examples, you find out from the [**How to Run the Examples**](http://docs.aspose.com/svg/net/how-to-run-the-tests) section.
{{% /alert %}}

### **Example 4. Photo Vectorization**

Is it possible to convert a photo in vector format to look identical to the photo?

SVG is not well suited for drawing photorealistic images. Vector pictures do not allow for natural color transitions yet. Vector graphics are the best for creating logos, illustrations, technical drawings. It is not the most suitable format for continuous-tone images with blends of color or to edit photographs. However, vectorizing photos can result in impressive artistic effects that can be interesting and useful.

In this section, we convert a photo to vector format and try to choose vectorization options so that the result looks identical to the photo:

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
			TraceSimplifier = new ImageTraceSimplifier(0.3f),
			PathBuilder = new PathBuilder(0.2f),
			ColorsLimit = 25
        }
    };

    // Vectorize raster image from the specified file
    using var document = vectorizer.Vectorize(Path.Combine(DataDir, "horses.jpg"));

    // Prepare an output path for an SVG document saving
    string savePath = Path.Combine(OutputDir, "horses.svg");

    // Save vectorized image as SVG file 
	document.Save(savePath);
```

The figure demonstrates the source photo (a), the vectorized image using the code snippet (b) and the manually improved vectorized image (c).

!["Source photo and Vectorized photo"](photo-horses.png#center)

As mentioned above, SVG is not the most suitable format for continuous-tone images with blends of color, etc. The vectorization process uses color image quantization. All small same colored spots or pixels, we replace by geometric shapes or curves. As a result, the borders of such graphic elements do not fit snugly together; gaps appear between them. This is the reason for the form of white spots and dots in the vectorized image.

To fix this problem, you can manually edit the resulting SVG file. We suggest changing the stroke-width="100" value to "150" or another, as you like. Try to get the best result!

!["The fragment of SVG file"](svg-fragment.png#center)

The source photo (a) and resulting SVG file (c) you may find and view in details by following the links - [horses.jpg](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/vectorization/horses.jpg), [horses.svg](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/vectorization/horses.svg).

## **License Limitations**

A free evaluation version of Aspose.SVG for .NET  provides all the features for image vectorization except the following:

- Only 4 dominant color will be used to quantize an image.
- Only 50% of SVG Document's nodes will be saved during serialization.


If you want to try Aspose.SVG without evaluation limitations request a 30-day temporary license. For more information, please refer to [**How to get a Temporary License?**](https://purchase.aspose.com/temporary-license) 

The figure shows the result of the photo to vector conversion without applying a license.

!["Photo vectorization result without using a license" ](horses-license.png#center)

The resulting SVG file you may find and view in details by following the links - [horses-license.svg](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/vectorization/horses-license.svg).

{{% alert color="primary" %}} 
You can download the complete C# examples and data files from [**GitHub**](https://github.com/aspose-svg/Aspose.SVG-Documentation). About downloading from GitHub and running examples, you find out from the [**How to Run the Examples**](http://docs.aspose.com/svg/net/how-to-run-the-tests) section.
{{% /alert %}} 



