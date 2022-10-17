---
title: SVG Drawing - Basics Tutorial
linktitle: SVG Drawing Basics
type: docs
weight: 30
aliases: /net/drawing-basics/
lastmod: 2022-10-17
description: Learn the basic concepts and drawing elements used in svg images - svg shapes, svg color, svg paths, svg fills, svg strokes, svg filters. 
keywords: svg drawing, svg coordinate system, svg path, svg text, svg transformation, svg fill, svg stroke, svg filter, svg gradient, svg color
---
<link href="./../style.css" rel="stylesheet" type="text/css" />
SVG is an XML language that is used for vector graphics drawing. If you are familiar with basic HTML and XML, you can easily create  SVGs in any text editor! We hope our SVG Drawing Tutorial helps you in your work or study. We try to explain common rules and standard steps for creating SVG from scratch based on simple examples. 

This chapter aims to explain how to draw SVG images and includes articles about SVG Coordinate Systems and Units, SVG Basic Shapes, SVG Path Data, SVG Text, Basic SVG Transformations, SVG Color, Fills and Strokes in SVG, SVG Embedded Content, and SVG Filters and Gradients.

 <br>


- **[SVG Coordinate Systems and Units](/svg/net/drawing-basics/coordinate-systems-and-units/)** In this article, you find the description of the workspace of SVG that is defined by the values of the viewport and viewBox attributes.
- **[SVG Shapes](/svg/net/drawing-basics/svg-shapes/)** In this article, you can learn how to create different simple shapes and apply some style properties to them.
- **[SVG Path Data](/svg/net/drawing-basics/svg-path-data/)** This article shows how the paths can be used to drawing various outlines or shapes by combining lines, arcs and Bezier curves. The group of commands for SVG path making is described here.
- **[SVG Text](/svg/net/drawing-basics/svg-text/)** This article introduces the text content elements and reviews some common attributes that help to display, format and style the text into an SVG image.
- **[Basic SVG Transformations](/svg/net/drawing-basics/svg-transformations/)** You find out how to apply the transform functions for graphic objects rotation, scaling, moving, and skewing through the SVG transform attribute and consider code examples for SVG transformations. 
- **[Fills and Strokes in SVG](/svg/net/drawing-basics/fills-and-strokes/)** In this article, we describe several properties that allow you to set different aspects of fill and stroke, including color, opacity, thickness, use of dashing, etc.
- **[SVG Color](/svg/net/drawing-basics/svg-color/)** This article takes an in-depth look at the different ways SVG text and shapes can be colorized. You’ll find out an overview of how color is defined, including the various ways you can control the transparency of SVG content.
- **[SVG Embedded Content](/svg/net/drawing-basics/embedded-content/)**  is content that imports into the document from another resource. You will see how to include and render bitmap and HTML elements within an SVG object.
- **[SVG Filters and Gradients](/svg/net/drawing-basics/filters-and-gradients/)** Filter primitives that produce blurring, color and lighting effects are reviewed. The chapter demonstrates how linear or radial gradients can decorate any line, shape, or text in SVG graphics.

In the next SVG articles we will create vector images using XML code. The figure illustrates the Aspose logo - SVG image. Only a few lines of code and you can create an icon, logo or any simple image.

![Aspose Logo](aspose.png#center)

The following is shown an example of SVG code for the Aspose logo ([aspose.svg](/svg/net/drawing-basics/aspose.svg)):
```html {linenos=inline,linenostart=1}
<svg height="1000" width="1000" viewBox="-30 0 300 300" xmlns="http://www.w3.org/2000/svg">
    <path d="M 25 78  C -26 28  97 -15  98 91 C 86 34 16 33 25 78" fill="#3993c9"/>
    <path d="M 25 78  C -26 28  97 -15  98 91 C 86 34 16 33 25 78"  fill="#f3622a" transform= "rotate(90 30 64) translate(5 -14)"/>
    <path d="M 25 78  C -26 28  97 -15  98 91 C 86 34 16 33 25 78"  fill="#c1af2c" transform= "rotate(180 25 78) translate(-19 9)"/>
    <path d="M 25 78  C -26 28  97 -15  98 91 C 86 34 16 33 25 78"  fill="#499c43" transform= "rotate(-90 25 78) translate(-5 14)"/>
    <circle cx="34.5" cy="73.5" r="40"   fill="white" fill-opacity="0.3" />
</svg>
```

{{% alert color="primary" %}}
Aspose.SVG offers [**SVG Free Web Applications**](https://products.aspose.app/svg/applications) for converting SVG or image files, merging SVG files, image vectorizing, SVG sprite generating, SVG to base64 data encoding, and text vectorizing. These online Apps work on any operating system with a web browser and don't require additional software installation. It’s a fast and easy way to efficiently and effectively solve your SVG-related tasks!
{{% /alert %}} 