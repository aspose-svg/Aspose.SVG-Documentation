---
title: How to Edit SVG
type: docs
weight: 18
url: /net/how-to-work-with-aspose-svg-api/document-editing/
lastmod: "2020-12-15"
description: How to Add Element to SVG, How to add Basic Shapes to SVG, Applying SVG Filters to Bitmaps, Drawing on Bitmaps
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

Aspose.SVG for .NET lets you edit an SVG document and make changes to its content. The API’s Document Object Model (DOM) is fully compatible with the official [SVG specifications](https://www.w3.org/TR/2018/CR-SVG2-20181004/) and means full control over SVG nodes and their fields for editing. You can modify the document by appending new nodes, removing, or editing the content of existing nodes. 

In this article, we show how you can edit SVG using Aspose.SVG for .NET library.

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-svg/Aspose.SVG-Documentation). About downloading from GitHub and running examples, you find out from [**How to Run the Examples**](http://docs.aspose.com/svg/net/how-to-run-the-tests) section.
{{% /alert %}} 

## **Adding a new Element to an SVG Document**

Aspose.SVG API allows you to add various elements to a document.  First, you would create a new element or node; then you can add it to the document.

1. You can use the **[CreateElementNS](https://apireference.aspose.com/svg/net/aspose.svg.dom/document/methods/createelementns)`(string namespaceURI, string qualifiedName)`** method of the [**SVGDocument**](https://apireference.aspose.com/net/svg/aspose.svg/svgdocument)  class to create an instance of the [**Element**](https://apireference.aspose.com/svg/net/aspose.svg.dom/element) class - the required element of the given qualified name and namespace URI. The `namespaceURI` is set the reference to [W3C SVG](http://www.w3.org/2000/svg) specification. The `qualifiedName` must contain the string tag name of the element. Remember, you must use casting the type (explicit conversion) to get the corresponding element.

2. To add an SVG element to the document, API provides the **[InsertBefore](https://apireference.aspose.com/svg/net/aspose.svg.dom/node/methods/insertbefore)`(Node node, Node child)`** method of the [**Node**](https://apireference.aspose.com/svg/net/aspose.svg.dom/node) class, which inserts the `node` before the existing child node or at the end of the list of children if the`child` is null.  

The  **`RootElement`**  property of the  [**SVGDocument**](https://apireference.aspose.com/net/svg/aspose.svg/svgdocument)  class points to the root `<svg>` element of the document.  The following code snippet illustrates how you can create and add  `<g>` element as the first child in the SVG document.

{{< highlight java >}}
    var svgElement = document.RootElement;
    var gElement = (SVGGElement)document.CreateElementNS("http://www.w3.org/2000/svg", "g");
    svgElement.InsertBefore(gElement, svgElement.FirstChild);
{{< /highlight >}}

We can specify element attributes and their values using the **SetAttribute `(string name, string value)`**, **GetAttribute `(string name)`, HasAttribute `(string name)`**, **RemoveAttribute `(string name)`** methods of the [**Element**](https://apireference.aspose.com/svg/net/aspose.svg.dom/element) class.

For example, if you create a group of graphic elements and put them into the `<g>` element, you can set common parameters:
{{< highlight java >}}
    gElement.SetAttribute("fill", "#8A8D8F");
    gElement.SetAttribute("stroke", "magenta");
    gElement.SetAttribute("stroke-width", "4");
{{< /highlight >}}

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-svg/Aspose.SVG-Documentation).
{{% /alert %}} 

## **How to add Basic Shapes to an SVG Document**

The basic shapes can be created using the **CreateElementNS `(string namespaceURI, string qualifiedName)`** method. The `qualifiedName` must contain the string tag name of the SVG graphic element.

This way you can create circles (SVGCircleElement class, qualifiedName = "circle"), ellipses (SVGEllipseElement class, qualifiedName = "ellipse"), rectangles (SVGRectElement class, qualifiedName = "rect"), lines (SVGLineElement class, qualifiedName = "line"),  polylines (SVGPolylineElement class, qualifiedName = "polyline"),  polygons (SVGPolygonElement class, qualifiedName = "polygon") and Bezier curves (SVGPathElement class, qualifiedName = "path").

### **Circle**

Each graphic element has its own specific attributes (properties), through which you can control its parameters and characteristics.
**Cx, Cy, R**  are circle properties of the [**SVGAnimatedLength**](https://apireference.aspose.com/svg/net/aspose.svg.datatypes/svganimatedlength) type, the static data for which can be set or read through the construction: `element.X.BaseVal.Value`.

The following code snippet shows how to create a circle and add it into the `<svg>` element of existing SVG file:
{{< highlight java >}}
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Dom;
using Aspose.Svg.Paths;
...
    // Set SVG Namespace Url
    string SvgNamespace = "http://www.w3.org/2000/svg";

    string documentPath = Path.Combine(DataDir, "basic-shapes.svg");
    
    using (var document = new SVGDocument(documentPath))
    {
        // Get root svg element of the document
        var svgElement = document.RootElement;
    
        // Create a circle element and set attributes values
        var circleElement = (SVGCircleElement)document.CreateElementNS(SvgNamespace, "circle");
        circleElement.Cx.BaseVal.Value = 100F;
        circleElement.Cy.BaseVal.Value = 100F;
        circleElement.R.BaseVal.Value = 50F;
        circleElement.SetAttribute("fill", "Salmon");
    
        // Add the circle element as the first child to svg element
        svgElement.InsertBefore(circleElement, svgElement.FirstChild);
    	
    	// Work with the document here...
    	// Add a polyline and change stroke attributes for all circle and ellipse elements (see later)
    }
    // Save the document
    document.Save(Path.Combine(OutputDir, "basic-shapes_out.svg"));
{{< /highlight >}}

The ellipse (**Cx, Cy, Rx, Ry**), the rectangle (**X, Y, Width, Height, Rx, Ry**) and the line (**X1, Y1, X2, Y2**) have own attributes that may be set similarly. 

### **Polyline**
The **[SVGPolygonElement](https://apireference.aspose.com/svg/net/aspose.svg/svgpolygonelement)** and **[SVGPolylineElement](https://apireference.aspose.com/svg/net/aspose.svg/svgpolylineelement)** have the **`Points`** property of the  [**SVGPointList**](https://apireference.aspose.com/svg/net/aspose.svg.datatypes/svgpointlist) type, which provides access to the basic content of **points** attribute,  which uniquely matches the SVG syntax.

A simple example of polyline creating is illustrated in the following code snippet:
{{< highlight java >}} 
    // Set SVG Namespace Url
    string SvgNamespace = "http://www.w3.org/2000/svg";

​    // Create a polyline element and set attributes values:
​	var polylineElement = (SVGPolylineElement)document.CreateElementNS(SvgNamespace, "polyline");
​    SVGPoint point1 = svgElement.CreateSVGPoint();
​    point1.X = 270;
​    point1.Y = 240;
​    SVGPoint point2 = svgElement.CreateSVGPoint();
​    point2.X = 290;
​    point2.Y = 220;
​    SVGPoint point3 = svgElement.CreateSVGPoint();
​    point3.X = 310;
​    point3.Y = 240;
​    polylineElement.Points.AppendItem(point1);
​    polylineElement.Points.AppendItem(point2);
​    polylineElement.Points.AppendItem(point3);
​    polylineElement.SetAttribute("stroke", "grey");
​    polylineElement.SetAttribute("stroke-width", "5");
​    polylineElement.SetAttribute("fill", "none");
​	
​	// Add the polyline element to children of the svg element
​	svgElement.AppendChild(polylineElement);
{{< /highlight >}}

The **[CreateSVGPoint ](https://apireference.aspose.com/svg/net/aspose.svg/svgsvgelement/methods/createsvgpoint)()** method produces an instance of the [**SVGPoint**](https://apireference.aspose.com/svg/net/aspose.svg.datatypes/svgpoint) class, in which you can set the `X` and` Y` values through the same name properties. The default object is initialized to point (0,0) in the custom coordinate system.

The **[AppendItem ](https://apireference.aspose.com/svg/net/aspose.svg.collections.svglistbase/1/methods/appenditem)(`T newItem`)** method inserts a new point at the end of the list.  Straight lines connect these points in the list and make a polyline, or a polygon - a plane geometric shape formed by a closed polyline.

The **[AppendChild ](https://apireference.aspose.com/svg/net/aspose.svg.dom/node/methods/appendchild)(`Node node`)** method adds the  new child to the end of the list of children of this node.  The code snippet shows that the `stroke`, `stroke-width` and `fill` attributes are specified, and the `polylineElement` is inserted in the `<svg>` element as the last child.

Consider an example of editing an existing SVG file [basic-shapes.svg](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/document-editing/basic-shapes.svg): we will add the circle and polyline, described above, and change the stroke properties for all circles and ellipses. The following code snippet shows how to find all circles and ellipses in an `<svg>` element and replace their stroke properties:

{{< highlight java >}}
    // Set stroke attributes for all circle and ellipse elements
    foreach (Element element in svgElement.Children)
    {
        if (element is SVGCircleElement || element is SVGEllipseElement)
        {
            element.SetAttribute("stroke-width", "6");
            element.SetAttribute("stroke", "#C8102E");
        }
    }
{{< /highlight >}}
The figure shows the visualization of the original SVG file  [basic-shapes.svg](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/document-editing/basic-shapes.svg) and the file that was edited (modified).
![Original svg image and edited svg image](Basic_Shapes.png#center)


### **Path**

To create a path using the Aspose.SVG API, you need to create an instance of the **[SVGPathElement](https://apireference.aspose.com/svg/net/aspose.svg/svgpathelement)** class using the **CreateElementNS(`string namespaceURI, string qualifiedName`)** method.

The methods **CreateSVGPathSegMovetoAbs ( `x,  y`)**, **CreateSVGPathSegCurvetoQuadraticAbs (`x,  y,  x1,  y1`)** and **CreateSVGPathSegCurvetoQuadraticSmoothAbs (`x,  y`)** take parameters of path data commands **M, C**, and **T** as their own parameters. The [**`PathSegList`**](https://apireference.aspose.com/svg/net/aspose.svg.paths/isvganimatedpathdata/properties/pathseglist) property of  the **SVGPathSegList** type provides access to the content of **d** attribute, in the form of path segments list, that matches the SVG syntax  (details are in the [**SVG Path Data**](https://docs.aspose.com/svg/net/drawing-basics/svg-path-data/)).

The following code snippet shows how to create the path and add into `<svg>` element:

{{< highlight java >}}
    // Create a path element      
    var pathElement = (SVGPathElement)document.CreateElementNS(SvgNamespace, "path");    

	// Set d attribute parameters - SVG path data
	SVGPathSeg pathSeg1 = pathElement.CreateSVGPathSegMovetoAbs(10, 200);
	SVGPathSeg pathSeg2 = pathElement.CreateSVGPathSegCurvetoQuadraticAbs(180, 200, 25, 210);
	SVGPathSeg pathSeg3 = pathElement.CreateSVGPathSegCurvetoQuadraticSmoothAbs(300, 250);
	SVGPathSeg pathSeg4 = pathElement.CreateSVGPathSegCurvetoQuadraticSmoothAbs(420, 250);
	SVGPathSeg pathSeg5 = pathElement.CreateSVGPathSegCurvetoQuadraticSmoothAbs(490, 150);
	pathElement.PathSegList.AppendItem(pathSeg1);
	pathElement.PathSegList.AppendItem(pathSeg2);
	pathElement.PathSegList.AppendItem(pathSeg3);
	pathElement.PathSegList.AppendItem(pathSeg4);
	pathElement.PathSegList.AppendItem(pathSeg5);
	
	// Set fill and stroke attributes
	pathElement.SetAttribute("stroke", "magenta");
	pathElement.SetAttribute("fill", "none");
	pathElement.SetAttribute("stroke-width", "4");
	
	// Add the path as the first child in the svg element
	svgElement.InsertBefore(pathElement, svgElement.FirstChild);
{{< /highlight >}}

In terms of the DOM, programming, working with the document, and navigating the file,  you can use such itemized and thorough code. Using the **SetAttribute()** method, you can write the code, for SVG path data **"d"** setting, on a single line.

In the following example,  we use  the one-line code to create the same path (original path). Moreover, we will edit the parameters of the moveto(x,y) **M** and **T**(x,y)  commands in the original path to receiving a new one.

{{< highlight java >}}
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Paths;
...
    // Set SVG Namespace Url
    string SvgNamespace = "http://www.w3.org/2000/svg";    

    using (var document = new SVGDocument())
    {
        var svgElement = document.RootElement;
     
        // Create path element and set SVG path data 
        var pathElement = (SVGPathElement)document.CreateElementNS(SvgNamespace, "path");
​        pathElement.SetAttribute("d", "M 10 200 Q 25 110 180 200 T 300 250 T 420 250 T 490 150");
​        
​        // SVG path data egiting	
​        foreach (SVGPathSeg pathSeg in pathElement.PathSegList)
​        {
​            // Editing T commands parameters
​            if (pathSeg is SVGPathSegCurvetoQuadraticSmoothAbs)
​            {
​                SVGPathSegCurvetoQuadraticSmoothAbs pathSegCurvetoQuadraticSmoothAbs = pathSeg as SVGPathSegCurvetoQuadraticSmoothAbs;​    
​                pathSegCurvetoQuadraticSmoothAbs.X -= 60;
​                pathSegCurvetoQuadraticSmoothAbs.Y -= 65;
​            }
​            //  Editing M command parameters
​            if (pathSeg is SVGPathSegMovetoAbs)
​            {
​                SVGPathSegMovetoAbs pathSegMovetoAbs = pathSeg as SVGPathSegMovetoAbs;​    
​                pathSegMovetoAbs.X = 200;
​                pathSegMovetoAbs.Y = 100;
​            }
​        }		
​        // Set fill and stroke attributes
​        pathElement.SetAttribute("stroke", "red");
​        pathElement.SetAttribute("fill", "none");
​        pathElement.SetAttribute("stroke-width", "4");

        // Add the path element as the first child to svg element
​    	svgElement.InsertBefore(pathElement, svgElement.FirstChild);

​    	// Save the document
​        document.Save(Path.Combine(OutputDir, "PathData.svg"));
​    }
{{< /highlight >}}

The figure illustrates the original (black) and modified (red) paths "PathData.svg".

![Original and edited paths](paths.png#center)

##  **Applying SVG Filters to Bitmaps**
Consider examples of SVG filters applying to bitmaps. Aspose.SVG API gives you to create an instance of the [**SvgImageElement**](https://apireference.aspose.com/svg/net/aspose.svg/svgimageelement) class and set attributes specifying its position. To add an `imageElement` to  `svgElement`, you can use the **[AppendChild](https://apireference.aspose.com/svg/net/aspose.svg.dom/node/methods/appendchild) (`Node node`)** method.  Using a `"filter"` attribute of `imageElement` referring to the url name of `filterElement` allows applying SVG filter effect to the image. For more information about filter primitives, see the [W3 SVG](https://drafts.fxtf.org/filter-effects/) page and the **[Filters and Gradients](https://docs.aspose.com/svg/net/drawing-basics/filters-and-gradients/)** section.

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-svg/Aspose.SVG-Documentation).
{{% /alert %}} 

### **Gaussian Blur**

The `<feGaussianBlur>` filter creates a soft blur effect. The **"StdDeviation"** attribute specifies the number that characterizes the standard deviation for the blur operation. 

According to SVG syntax, the `<filter>` element should be located into a `<defs>` element and the `<feGaussianBlur>` filter primitive is only inside the `<filter>` element. Therefore, for filter programming, you should first to create the `<defs>` and `<filter>` elements.

One option for setting the values of the attribute is to use the **SetAttribute (`string name, string value`)** method.  Another way is to take SVG DOM dot-accessor methods using properties of the [**SVGAnimatedLength**](https://apireference.aspose.com/svg/net/aspose.svg.datatypes/svganimatedlength/properties/index) type, the static data for which can be set or read through the construction: `element.X.BaseVal.Value`. To specify the units, you need to use the **ConvertToSpecifiedUnits (`ushort unitType`)** method of the [**SVGLength**](https://apireference.aspose.com/svg/net/aspose.svg.datatypes/svglength) class.

 After you make a filter and set a `filterElement.Id`, you can apply it to the image. Here is an example that illustrates GaussianBlur effect implementation:

{{< highlight java >}}
using Aspose.Svg;
using System.IO;
using Aspose.Svg.DataTypes;
using Aspose.Svg.Filters;
...
    // Create an image element and add it to the svgElement
    var imageElement = (SVGImageElement)document.CreateElementNS(SvgNamespace, "image");
    imageElement.Href.BaseVal = "http://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/document-editing/Lighthouse.jpg";
	imageElement.Height.BaseVal.ConvertToSpecifiedUnits(SVGLength.SVG_LENGTHTYPE_PX);
    imageElement.Width.BaseVal.ConvertToSpecifiedUnits(SVGLength.SVG_LENGTHTYPE_PX);
	imageElement.Height.BaseVal.Value = 640;
    imageElement.Width.BaseVal.Value = 480;
    imageElement.X.BaseVal.Value = 20;
    imageElement.Y.BaseVal.Value = 20;
    imageElement.SetAttribute("filter", "url(#F1)");
	svgElement.AppendChild(imageElement);
	
    // Create a defs element and add to the svgElement
    var defsElement = (SVGDefsElement)document.CreateElementNS(SvgNamespace, "defs");
    svgElement.AppendChild(defsElement);
    
    // Create a filter element and add to the defsElement
    var filterElement = (SVGFilterElement)document.CreateElementNS(SvgNamespace, "filter");
    defsElement.AppendChild(filterElement);
    
    // Create a feGaussianBlur element and add to the filterElement	
    var feGaussianBlurElement = (SVGFEGaussianBlurElement)document.CreateElementNS(SvgNamespace, "feGaussianBlur");
    feGaussianBlurElement.In1.BaseVal = "SourceGraphic";
    feGaussianBlurElement.StdDeviationX.BaseVal = 3;
    feGaussianBlurElement.StdDeviationY.BaseVal = 3;
    feGaussianBlurElement.SetAttribute("x", "-20px");
    feGaussianBlurElement.SetAttribute("y", "-20px");
    feGaussianBlurElement.SetAttribute("height", "720px");
    feGaussianBlurElement.SetAttribute("width", "560px");
    filterElement.Id = "F1";
    filterElement.AppendChild(feGaussianBlurElement);

{{< /highlight >}}

### **Saturation Effect**

The saturation effect is a special case of using the color matrix.  The `<feColorMatrix>` is one of the main color filters. The following code snippet shows how to use the saturation operation of the `<feColorMatrix>` filter primitive.

{{< highlight java >}}
    // Create a feColorMatrix element
	var feColorMatrixElement = (SVGFEColorMatrixElement)document.CreateElementNS(SvgNamespace, "feColorMatrix");
    feColorMatrixElement.In1.BaseVal = "SourceGraphic";
    feColorMatrixElement.SetAttribute("type", "saturate");
    feColorMatrixElement.SetAttribute("values", "2");
    filterElement.Id = "CM";
{{< /highlight >}}

Suppose you add created `feColorMatrixElement` to the `filterElement` and set for the image `"filter"` attribute referring to the `filterElement.Id = "CM";` you get a result illustrated on figure (c).

The figure demonstrates the source image (a), the image processed by the feGaussianBlur filter (b) and the resulting image after the saturate operation applying (c).
![The result of the feGaussianBlur  and  feColorMatrix filters applying](Filter_Effects.png#center)



### **Drop Shadow Effect**

The following code snippet shows how to create a drop shadow effect using the Aspose.SVG API:

{{< highlight java >}}
using Aspose.Svg;
using Aspose.Svg.Filters;
...
    // Create a filter element and add to the defsElement
    var filterElement = (SVGFilterElement)document.CreateElementNS(SvgNamespace, "filter");
    filterElement.Id = "shadow";
    filterElement.SetAttribute("x", "-20px");
    filterElement.SetAttribute("y", "-20px");
    filterElement.SetAttribute("height", "150px");
    filterElement.SetAttribute("width", "150px");
	defsElement.AppendChild(filterElement);
    
    // Create a feOffset filter primitive and add to the filterElement
    var feOffsetElement = (SVGFEOffsetElement)document.CreateElementNS(SvgNamespace, "feOffset");
    feOffsetElement.In1.BaseVal = "SourceAlpha";
    feOffsetElement.SetAttribute("result", "offset");
    feOffsetElement.SetAttribute("dx", "3");
    feOffsetElement.SetAttribute("dy", "3");
    filterElement.AppendChild(feOffsetElement);
    
    // Create a feGaussianBlur filter primitive and add to the filterElement
    var feGaussianBlurElement = (SVGFEGaussianBlurElement)document.CreateElementNS(SvgNamespace, "feGaussianBlur");
    feGaussianBlurElement.In1.BaseVal = "offset";
    feGaussianBlurElement.StdDeviationX.BaseVal = 3;
    feGaussianBlurElement.StdDeviationY.BaseVal = 3;
    feGaussianBlurElement.SetAttribute("result", "blur");
    filterElement.AppendChild(feGaussianBlurElement);
    
    // Create a feBlend filter primitive and add to the filterElement
    var feBlendElement = (SVGFEBlendElement)document.CreateElementNS(SvgNamespace, "feBlend");
    feBlendElement.In1.BaseVal = "SourceGraphic";
    feBlendElement.In2.BaseVal = "blur";
    feBlendElement.SetAttribute("mode", "normal");
    filterElement.AppendChild(feBlendElement);    
                
    // Create a text element and add to the svgElement
    var textElement = (SVGTextElement)document.CreateElementNS(SvgNamespace, "text");
    textElement.Style.FontSize = "5em";
    textElement.SetAttribute("x", "20px");
    textElement.SetAttribute("fill", "#C0C0C0");
    textElement.SetAttribute("y", "100px");
    textElement.TextContent = "Aspose.SVG API";
    textElement.SetAttribute("filter", "url(#shadow)");
    svgElement.InsertBefore(textElement, svgElement.FirstChild);
{{< /highlight >}}

The resulting image looks like this:

![Text  ](shadow.png#center)

 Aspose.SVG API lets you create various filter effects using the classes and interfaces related to the [**Aspose.Svg.Dom.Svg.Filters**](https://apireference.aspose.com/svg/net/aspose.svg.filters) namespace.

## **Drawing on Existing Bitmaps**

The bitmap can be used as a background for drawing. You can apply an SVG filter effect to the raster image, append the shapes, paths, or text. The figure below made with the help of adding circle and text to the bitmap acting as the background.

We painted the circle with a big value of **`stroke-width`**. The **`stroke-dasharray`** attribute applying converts the circle's stroke into a dashed line. By selecting values of the filled-unfilled areas, you can achieve the desired visual effect (see [**Fills and Strokes**](https://docs.aspose.com/svg/net/drawing-basics/fills-and-strokes/)). 


![Image with added text and circle](seaside.png#center)

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-svg/Aspose.SVG-Documentation). About downloading from GitHub and running examples, you find out from [**How to Run the Examples**](http://docs.aspose.com/svg/net/how-to-run-the-tests) section.
{{% /alert %}} 