---
title: Image Vectorization Workflow | .NET
linktitle: Image Vectorization Workflow
type: docs
weight: 10
url: /net/how-to-work-with-aspose-svg-api/image-vectorization-workflow/  
lastmod: 2022-01-10
changefreq: weekly
priority: 0.7
description: This article explains how to convert bitmaps to vector graphics using the Aspose.SVG API. You will find a description of the image vectorization process; usage of vectorization algorithms and options, learn how to vectorize raster images such as PNG, JPG, BMP, TIFF, GIF, ICO into an SVG document.
keywords: image vectorization, bitmap to vector, image to vector, raster image, vector image, vectorization options 
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

{{% alert color="primary" %}} 
Aspose.SVG offers a Free Online [**Image Vectorizer**](https://products.aspose.app/svg/image-vectorization)  that is browser-based and works on any platform. Using this App, you may apply a set of options for obtaining the perfect result. Save your time and check this free Image Vectorizer to get all the benefits of vector graphics!
{{% /alert %}} 

<a href="https://products.aspose.app/svg/image-vectorization" target="_blank">![Text "Banner Image Vectorizer"](./../vectorization/image-vectorizer.png#center)</a>

## **What is Image Vectorization?**
The task in vectorization is to convert a 2D image to a 2D vector representation of the image. The two-dimensional vector graphics are computer graphics images represented as mathematical curves. Such vector images are defined as Cartesian points connected by lines and curves to form required shapes. A raster image is a set of pixels. If it is an RGB image, it can be represented as a table of color pixels. Each pixel is a triplet of 8-bit integer values, where each value represents an amount of red, green, and blue color.

Image Vectorization is the process of converting raster images into vector graphics - the Bezier curves, splines and lines. 

The source image to the raster-to-vector conversion may accept bitmap formats such as JPG, TIFF, BMP, GIF and PNG. The output image is a vector file format, for example, SVG file format. Images such as maps, icons, logos, technical drawings and clip art are suitable for vectorization. These images are based on geometric shapes and drawn with simple curves.

## **What is the Image Vectorization for?**

**Scaling and size**. Raster images are pixel-based, so they are resolution-dependent. The image quality depends on the number of pixels that make up the image and the value of resolution that determines how many pixels are displayed per inch. Therefore, the more pixels in the image and the higher the resolution, the higher the image quality. For example, scaling a bitmap to enlarge it without changing the resolution will lose quality and appear blurry or pixelated. This is because pixels are stretched over a larger area, making them less sharp.
Unlike bitmap graphics, vector images are resizable and scalable without losing any quality, and they will still display out just as clearly. In other words, vector graphics have a unique advantage over raster graphics in that points, lines, and curves can be scaled up or down to any resolution without aliasing.

**Security and privacy**. Sometimes it is necessary to protect images from image recognition techniques like face recognition. Vectorized images are more resistant to such attacks because image recognizers are usually pixel-oriented.

**Images recovery**. Vectorization can be used to update or recover images.

## **Image Vectorization process**

The image vectorization process includes the next steps:

**Color quantization and resizing**. Color quantization or color image quantization is quantization applied to color spaces. It is a process that reduces the number of different colors used in an image, with the intention that the new image should be as visually similar as possible to the original image. In our image vectorization process, color quantization plays a significant role because it reduces the number of used colors that significantly affect the size and quality of vectorized SVG. 
When the image is huge or contains a lot of small same colored spots or pixels, we resize it to prevent the SVG document from being too large.

**Contour tracing**. Contour tracing or boundary tracing is a technique that is applied to digital images to extract their boundary or boundaries for non-monochrome images. There are several such techniques like Suzuki-Abe, Moore-neighbor, Square Tracing Algorithm, Theo Pavlidis' Algorithm, etc... Unfortunately, those algorithms work with monochrome images and do in a non-optimal way with multi-color images. So we have developed a new contour tracking algorithm that works quickly and accurately with multi-color images and significantly reduces the number of contours.

**Trace smoothing** (this step is optional). Sometimes fragments of contours look like sawtooth waves because the resolution of the vectorized images is not high enough, or there is noise in the image. For smoothing, these curves can be used many approaches like Local linear regression, Local polynomial regression, Gaussian kernel, etc... We found that perfect results can be achieved with the help of the Nearest Neighbor approach, which was implemented in the [ImageTraceSmoother](https://reference.aspose.com/svg/net/aspose.svg.imagevectorization/imagetracesmoother) class. 

**Trace simplification** (optional). At this step is needed to decimate the trace curve composed of line segments to a similar curve with fewer points. There are different algorithms like Ramer–Douglas–Peucker, Visvalingam–Whyatt, Reumann–Witkam, etc.. that can be used to solve this task. We implemented the Ramer–Douglas–Peucker approach in the class ImageTraceSimplifier because it showed a better result than others in our experiments, but we declared the [IImageTraceSimplifier](https://reference.aspose.com/svg/net/aspose.svg.imagevectorization/iimagetracesimplifier) interface for implementing any other approaches.

**Building SVG path elements from the traces**. The final step is to convert the tracing points to SVG path lines and Bezier curves and add them to the SVG document. To fit the curves going through each tracing point, we use a Catmull-Roma spline, which is converted to Bezier curves.

## **Vectorization Options**

You can convert a raster image to vector graphic using default or custom configuration options. You will be able to apply custom settings for getting the best result of the image to vector conversion and save the output SVG file to your computer.  The processing assumes control of the following properties:

| Property                                                     | Description                                                  |
| :----------------------------------------------------------- | :----------------------------------------------------------- |
| [ColorsLimit](https://reference.aspose.com/svg/net/aspose.svg.imagevectorization/imagevectorizerconfiguration/properties/colorslimit) | This property gets or sets the maximum number of colors used to quantize an image. The default value is 25. |
| [ ImageSizeLimit](https://reference.aspose.com/svg/net/aspose.svg.imagevectorization/imagevectorizerconfiguration/properties/imagesizelimit) | Gets or sets maximal dimension of an image determined by multiplication image width and height. The size of the image will be scaled based on this property. The default value is 1800000. |
| [ PathBuilder](https://reference.aspose.com/svg/net/aspose.svg.imagevectorization/imagevectorizerconfiguration/properties/pathbuilder) | This property sets the SVG path segments builder and affects how sharply the curve bends at the control points. |
| [TraceSimplifier](https://reference.aspose.com/svg/net/aspose.svg.imagevectorization/imagevectorizerconfiguration/properties/tracesimplifier) | The property sets the trace simplified. As a result, the trace curve will be built composed of line segments with fewer (or bigger) points. |
| [TraceSmoother](https://reference.aspose.com/svg/net/aspose.svg.imagevectorization/imagevectorizerconfiguration/properties/tracesmoother) | This property sets the trace smoother. It is used to smooth out fragments of contours. |

## **C# Example**

 Aspose.HTML API provides [ImageVectorization](https://reference.aspose.com/svg/net/aspose.svg.imagevectorization) Namespace that realizes various classes that allow implementing a set of algorithms for the image vectorization process. The provided classes and methods enable you to work with multiple vectorization options for preprocessing images before saving them to vector format. 

**Note:** Aspose.SVG API aims to implement image vectorization tasks, so the source image to the raster-to-vector conversion may accept bitmap formats such as {{%JPG%}}, {{%PNG%}}, {{%BMP%}}, {{%TIFF%}},  {{%GIF%}}, etc. The output image is a vector {{%SVG%}} file format. 

To vectorized an image with Aspose.SVG, you should follow a few steps:

1. Initialize an instance of the [ImageVectorizer](https://reference.aspose.com/svg/net/aspose.svg.imagevectorization/imagevectorizer) class. Use one of ImageVectorizer() constructors and specify configuration properties.
2. Vectorize raster image from the specified file. Use the [Vectorize()](https://reference.aspose.com/svg/net/aspose.svg.imagevectorization.imagevectorizer/vectorize/methods/2) method that returnes an [SVGDocument](https://reference.aspose.com/svg/net/aspose.svg/svgdocument).
3. Save the SVGDocument (vectorized image) as SVG file.

Here is a C# example of how to vectorize PNG image using the Aspose.SVG API.
```c#
using System.IO;
using Aspose.Svg.ImageVectorization;
using Aspose.Svg.Saving;
...

	var vectorizer = new ImageVectorizer
    {
        Configuration =
		{
			TraceSmoother =   new ImageTraceSmoother(2),
			TraceSimplifier = new ImageTraceSimplifier(0.1f),
			ColorsLimit = 2
        }
    };

    using var document = vectorizer.Vectorize(Path.Combine(DataDir, "png-to-svg.png"));
    document.Save(Path.Combine(OutputDir, "png-to-svg.svg"));
```
You can view the source file and final result by following the links - [png-to-svg.png](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/vectorization/png-to-svg.png), [png-to-svg.svg](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/vectorization/png-to-svg.svg).

You find the description and C# examples of vectorization options applying in the [**Image Vectorization Examples**](/svg/net/how-to-work-with-aspose-svg-api/image-vectorization-examples/) article.

## **Example of IImageTraceSimplifier Implementation**

The [ImageVectorization](https://reference.aspose.com/svg/net/aspose.svg.imagevectorization) Namespace includes the [IImageTraceSimplifier](https://reference.aspose.com/svg/net/aspose.svg.imagevectorization/iimagetracesimplifier), [IImageTraceSmoother](https://reference.aspose.com/svg/net/aspose.svg.imagevectorization/iimagetracesmoother) and [IPathBuilder](https://reference.aspose.com/svg/net/aspose.svg.imagevectorization/pathbuilder) interfaces for realizing any of your approaches and algorithms. Let's consider the implementation IImageTraceSimplifier based on the Viswalingam algorithm:

```c#
	struct Point3
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float? Z { get; set; }
        public Point3(float x, float y, float? z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }

    internal class Visvalingam: IImageTraceSimplifier
    {
        Point3[] line;
        List<int> indizes;
        bool enriched;
        float tolerance;

        public Visvalingam(float tolerance)
        {
            this.tolerance = tolerance;
        }

        // Calculate the area of one triangle       	
        private float GetTriangleArea(Point3 a, Point3 b, Point3 c)
		{
            return Math.Abs((a.X * (b.Y - c.Y) + b.X * (c.Y - a.Y) + c.X * (a.Y - b.Y)) / 2f);
        }

        // Add the area of the triangle to each point
        private float EnrichPoints()
		{
            var minArea = float.PositiveInfinity;

            for (var i = 1; i < indizes.Count() - 1; i++)
            {
                var @this = indizes[i];
                var prev = indizes[i - 1];
                var next = indizes[i + 1];
				
                var area = GetTriangleArea(line[prev], line[@this], line[next]);

                // Reset minim value for area, if current is smaller than all previous
                if (area < minArea)

                    minArea = area;

                // Save the area of the triangle as 3rd coordinate
                // Replace if it does exist already
                line[@this].Z = area;
            }
            return minArea;
        }

        // Check for the smallest triangles and remove corresponding points from the index
        private void RemoveSmallestAreaIndex(float minArea)
        {
            var newIndizes = new List<int>();
            newIndizes.Add(indizes[0]);
			
            for (var i = 1; i < indizes.Count - 1; i++)
            {
                var index = indizes[i];

                if (line[index].Z > minArea)

                    newIndizes.Add(index);
            }

            newIndizes.Add(indizes[indizes.Count - 1]);
            indizes = newIndizes;

            // Return newIndizes
        }

        // Do Visvalingam-Calculations until only start-& endpoint are left
        private void EnrichLineString()
        {
            while (indizes.Count > 2)

                RemoveSmallestAreaIndex(EnrichPoints());

            enriched = true;
        }

        // Simplify a linestring corresponding to a given tolerance (depends on projection of data)

        public IEnumerable<PointF> Simplify(IEnumerable<PointF> trace)
        {
            line = trace.Select(pt => new Point3(pt.X, pt.Y, null)).ToArray();
            indizes = line.Select((v, i) => i).ToList();
            enriched = false;

            // It is enough to enrich the line once
            if (enriched == false)
			
                EnrichLineString();

            // Build the new line
            return line.Where(p => p.Z != null && (p.Z > tolerance) || p.Z == null)

                .Select(p => new PointF(p.X, p.Y));
        }
    }
```

{{% alert color="primary" %}} 
You can download the complete C# examples and data files from [**GitHub**](https://github.com/aspose-svg/Aspose.SVG-Documentation/tree/main/content/tests-net). About downloading from GitHub and running examples, you find out from the [**How to Run the Examples**](http://docs.aspose.com/svg/net/how-to-run-the-tests) section.
{{% /alert %}} 



