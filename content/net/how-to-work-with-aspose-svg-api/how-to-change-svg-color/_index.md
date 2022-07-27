---
title: How to Change SVG Color | C# Examples and Online Converter
linktitle: How to Change SVG Color
type: docs
weight: 35
lastmod: 2022-07-27
description: You learn how to work with SVG color in C# and consider C# examples of how to change color for SVG elements or background color in SVG files.
keywords: svg color, how to change svg color, background color, circle color, change background color, c# example, stroke color, fill color, change svg color, line color, color property, svg background color, svg file
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

Aspose.SVG for .NET lets you edit an SVG document and make changes to its content.  Using color is an essential part of creating SVG. You can colorize SVG shapes, lines, paths, text. Using C# examples, we will look at ways to apply colors in SVG files. In this article, we show how to work with SVG color using Aspose.SVG for .NET library and consider of **how to change color** of SVG elements or background color in SVG files.

{{% alert color="primary" %}} 

How to add new SVG elements and set their color properties, we covered in detail C# examples in the article [**How to Edit SVG Files**](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/how-to-edit-svg-documents/).

The article [**SVG Color**](https://docs.aspose.com/svg/net/drawing-basics/svg-color/) looks at how SVG text and shapes can be colorized. You’ll find out an overview of how color is defined, including the various ways you can control the transparency of SVG content.

{{% /alert %}} 

## **Online Color Converter**

Colors can be specified as common Color Names or defined in popular HEX codes or RGB, HSL, HSV, LAB, HWB, CMYK, LCH, XYZ,  and NCOL values. And for different tasks, different color formats are preferred. So, sometimes you may need to convert color formats. You can convert colors to various most popular formats in any way - online or programmatically! Use our free Online Color Converter and get the result at once!

{{< app/svg/color input="RGB" output="HEX">}}

{{< /app/svg/color>}}

## **Change Color of SVG Element**

Filling and stroking are both operations for SVG elements colorizing. All graphical elements such as shapes, paths and text – are rendered by being filled. The fill is painting the interior of the object, and the stroke is painting along its outline. The SVG **stroke** and SVG **fill** are some of the main CSS properties that can be set for any lines, text and shapes. For more information on style attributes' properties, please see the article [**Fills and Strokes in SVG**](https://docs.aspose.com/svg/net/drawing-basics/fills-and-strokes/).

Aspose.SVG API allows you to change color of various SVG elements in an SVG document.  First, you would load an existing SVG document and then, you can change color of required SVG element:

1. Use one of the [SVGDocument()](https://reference.aspose.com/svg/net/aspose.svg/svgdocument/constructors/10) constructors of the [SVGDocument](https://reference.aspose.com/net/svg/aspose.svg/svgdocument)  class to load an existing SVG document.  

2. Use the [QuerySelector(`selector`)](https://reference.aspose.com/svg/net/aspose.svg.dom/element/methods/queryselector)  to find the desired element in the SVG document. The QuerySelector(`selector`) method of the Element class allows you to get the first element within the document that matches the specified selector. With the resulting elements, you can make various manipulations: change its attributes, CSS styles, and so on.

3. Use the  [SetAttribute `(name, value)`](https://reference.aspose.com/svg/net/aspose.svg.dom/element/methods/setattribute) method of the [Element](https://reference.aspose.com/svg/net/aspose.svg.dom/element) class to specify element attributes "fill" or "stroke".

### **Circle Color**

To change circle color, you should follow a few steps:

- Open a source SVG file.
- Get root svg element of the document.
- Get circle element to change color.
- Set a new **fill** attribute value for the circle element.
- Save the SVG document.

The following code snippet illustrates how you can change circle color for the first SVG circle element in basic-shapes.svg file:

```c#
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Dom;
...

    // Prepare a path to a file loading
    string documentPath = Path.Combine(DataDir, "basic-shapes.svg");

    // Load an SVG document from the file
    var document = new SVGDocument(documentPath);
    
    // Get root svg element of the document
    var svgElement = document.RootElement;    

    // Get circle element to change color
    var circleElement = svgElement.QuerySelector("circle") as SVGCircleElement;

    // Set a new "fill" attribute value for the circle element
    circleElement.SetAttribute("fill", "blue"); 

	// Save the SVG document
    document.Save(Path.Combine(OutputDir, "circle-color.svg"));
```
The **fill** attribute set the color of the SVG circle. In the resulting circle-color.svg file, the circle color changes from red (in the original) to blue. 

### **Line Color**

To change line color, you should follow similar steps. The C# example below shows how to change line color for the first SVG line element in basic-shapes.svg file:

```c#
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Dom;
...

    // Set SVG Namespace Url
    string SvgNamespace = "http://www.w3.org/2000/svg";
	
	// Prepare a path to a file loading
    string documentPath = Path.Combine(DataDir, "basic-shapes.svg");

    // Load an SVG document from the file
    var document = new SVGDocument(documentPath);

    // Get root svg element of the document
    var svgElement = document.RootElement;

    // Get line element to change color
    var lineElement = svgElement.QuerySelector("line") as SVGLineElement;

    // Set a new "stroke" attribute value for the line element
    lineElement.SetAttribute("stroke", "blue");

    // Save the SVG document
    document.Save(Path.Combine(OutputDir, "line-color.svg"));
```

The **stroke** attribute set the color of the SVG line. In the resulting line-color.svg file, the line color changes from grey (in the original) to blue. Similarly, you can change color for **various SVG graphic elements** such as shapes, paths, and text using the **fill** or **stroke** attribute.

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-svg/Aspose.SVG-Documentation).
{{% /alert %}} 

## **Change Background Color**

To set the background color to SVG image, you should add a new SVG element such as circle or rectangle as the first child in an SVG document. Because the rule about the order of SVG elements showing is: later elements in the code are displayed on top of the previous ones.

The following code snippet shows how to create a new SVG rectangle as a background for SVG image and colorize it: 
```c#
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Dom;
...
    
    // Set SVG Namespace Url
    string SvgNamespace = "http://www.w3.org/2000/svg";

    string documentPath = Path.Combine(DataDir, "basic-shapes.svg");

    // Load an SVG document from the file
    var document = new SVGDocument(documentPath);
    
    // Get root svg element of the document
    var svgElement = document.RootElement;                

    // Create a rectangle element and set the "fill" attribute value to change background color
    var rectElement = (SVGRectElement)document.CreateElementNS(SvgNamespace, "rect");
    rectElement.X.BaseVal.Value = 3;
    rectElement.Y.BaseVal.Value = 3;
    rectElement.Width.BaseVal.Value = 400;
    rectElement.Height.BaseVal.Value = 400;
    rectElement.SetAttribute("fill", "Salmon");

    // Add the rectangle element as the first child to svg element
    svgElement.InsertBefore(rectElement, svgElement.FirstChild);

    // Save the SVG document
    document.Save(Path.Combine(OutputDir, "change-background-color.svg"));
```

The figure shows the visualization of the original SVG file  [basic-shapes.svg](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/how-to-edit-svg-documents/basic-shapes.svg) and the same file with the added background color.
![Original svg image and svg image with new background color](background-color.png#center)

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-svg/Aspose.SVG-Documentation). About downloading from GitHub and running examples, you find out from the section [**How to Run the Examples**](http://docs.aspose.com/svg/net/how-to-run-the-tests).
{{% /alert %}} 

## **Recolor SVG**
In the following C# example, we show how to recolor SVG image: change color of SVG path element and change background color:

```c# 
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Dom;
...

    // Set SVG Namespace Url
    string SvgNamespace = "http://www.w3.org/2000/svg";

    string documentPath = Path.Combine(DataDir, "snowflake-blue.svg");

    // Load an SVG document from the file
    var document = new SVGDocument(documentPath);
    
    // Get root svg element of the document
    var svgElement = document.RootElement;

    // Create a circle element and set the "fill" attribute value to change background color
    var circleElement = (SVGCircleElement)document.CreateElementNS(SvgNamespace, "circle");
    circleElement.Cx.BaseVal.Value = 150F;
    circleElement.Cy.BaseVal.Value = 100F;
    circleElement.R.BaseVal.Value = 150F;
    circleElement.SetAttribute("fill", "#03b6fd");

    // Add the circle element (background) as the first child to svg element
    svgElement.InsertBefore(circleElement, svgElement.FirstChild);

    // Get the first path element to change color
    var snowflakePath = svgElement.QuerySelector("path") as SVGPathElement;

    // Set a new "stroke" attribute value for the path element
    snowflakePath.SetAttribute("stroke", "white");

    // Save the SVG document
    document.Save(Path.Combine(OutputDir, "recolor-svg.svg"));
```

The figure shows the visualization of the original SVG file  [snowflake-blue.svg](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/how-to-change-svg-color/snowflake-blue.svg) and the recolored file.
![Original svg image and recolored svg image](change-background-color.png#center)

{{% alert color="primary" %}} 

[**Color Converter**](https://products.aspose.app/svg/color-converter) is a free online application for transforming colors between color formats. Just enter color code and get the result at once! You don't need any additional software. Try our forceful Color Converter just now!

{{% /alert %}} 

<a href="https://products.aspose.app/svg/color-converter" target="_blank">![Text "Banner Color Converter"](../../color-converter.png#center)</a> 

