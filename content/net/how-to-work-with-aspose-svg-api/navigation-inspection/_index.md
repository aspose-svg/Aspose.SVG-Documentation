---
title: Navigation & Inspection SVG | .NET
linktitle: Navigation & Inspection SVG
type: docs
weight: 50
aliases: 
    - /net/how-to-work-with-aspose-svg-api/navigation-inspection/
    - /net/traverse-svg-dom/
lastmod: 2022-01-10
description: This article teaches how to perform a detailed inspection of the SVG document and its elements using the Aspose.SVG API, custom filters usage for iterating over the document elements, and how to navigate the document using CSS Selector or XPath.
keywords: svg file example, svg element, svg xpath, inspection svg, navigation svg, custom filter, CSS selector, XPath Query
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

Sometimes you need to inspect the content of SVG files, for example,  get information about the file, the elements and the hierarchy.  Aspose.SVG for .NET API is fully compatible with official [SVG specifications](https://www.w3.org/TR/SVG/) and can be used to traverse the SVG Document Object Model (DOM). The API supports a wide range of navigation and inspection functionalities of the SVG contents.

In this section, you find out:
 - how to view an SVG content as a string;

 - how to perform a detailed inspection of the document and its elements using the API;

 - what ways are for information about a particular element from the SVG file;

 - about custom filters usage for iterating over the document elements;

 - how to navigate over the document by using CSS Selector or  XPath Query.

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-svg/Aspose.SVG-Documentation). About downloading from GitHub and running examples, you find out from the [**How to Run the Examples**](https://docs.aspose.com/svg/net/how-to-run-the-tests/) section.
{{% /alert %}} 

## **View SVG Content**

The easiest way to inspect the document content is to look at content as a string. The properties  `InnerHTML` and `OuterHTML` of the [Element](https://reference.aspose.com/svg/net/aspose.svg.dom/element/) class return a fragment of XML (or HTML) that represents the element and its contents. They are developed precisely for viewing SVG content as a string.
The following code example shows how to view the content of [bezier-curves.svg](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/creating-loading-documents/bezier-curves.svg) file in the console.

```c# 
using Aspose.Svg;
using System.IO;
...   
    
    string documentPath = Path.Combine(DataDir, "bezier-curves.svg");    

	// Load an SVG document
	using (var document = new SVGDocument(documentPath))
	{
	     var html = document.DocumentElement.OuterHTML;
	                  
	     Console.WriteLine(html);
	}	
	// View the document content 
	

```

## **Navigation & Inspection SVG using DOM**

### **Extract Information about Specific SVG Element**

The following example shows how to extract information about a particular SVG element from a file [shapes.svg](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/navigation-inspection/shapes.svg):
```c# 
using Aspose.Svg;
using System.IO;
using System.Linq;
...
    
    //Load a document from a file
    string documentPath = Path.Combine(DataDir, "shapes.svg");
    
    using (var document = new SVGDocument(documentPath))
    {
        // Get the root svg element of the document
    	var svg = document.DocumentElement;
    	
    	// Find the first child element with a given tag name
        var g = svg.GetElementsByTagName("g").First() as SVGGElement;
    			
        var rect = g.FirstElementChild as SVGRectElement;
    
        Console.WriteLine("Height: {0}", rect.Height);// 90
        Console.WriteLine("Width: {0}", rect.Width); // 100
    }
```

In the example, the [`DocumentElement`](https://reference.aspose.com/svg/net/aspose.svg.dom/document/documentelement/) property usage allows direct access to the `<svg>` element of the document. Method [GetElementsByTagName()](https://reference.aspose.com/svg/net/aspose.svg.dom/element/getelementsbytagname/) of the [Element](https://reference.aspose.com/svg/net/aspose.svg.dom/element/) class returns a NodeList of all descendant elements with a given tag name; in this case the return element is the first `<g>` element. The [`FirstElementChild`](https://reference.aspose.com/svg/net/aspose.svg.dom/element/firstelementchild/) property  returns the first child element node of this element. In the example, the first child in `<g>` element is the `<rect>` element, for which the Width and Height values are printed.

###  **Inspection of an SVG Document and its Elements**

Aspose.SVG contains a list of methods that are based on the [Element Traversal Specifications](https://www.w3.org/TR/ElementTraversal/). You can perform a detailed inspection of the document and its elements using the API ([shapes.svg](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/navigation-inspection/shapes.svg)). The following code sample shows the generalized usage of Element Traversal features.
```c# 
using Aspose.Svg;
using System.IO;
...    
    
    // Load a document
	string documentPath = Path.Combine(DataDir, "shapes.svg");
    
    using (var document = new SVGDocument(documentPath))
    {
        var element = document.DocumentElement;
        Console.WriteLine(element.TagName); // svg
        
        element = element.LastElementChild;
        Console.WriteLine(element.TagName); // g
    
        element = element.FirstElementChild;
        Console.WriteLine(element.TagName); // rect
    }
```

 The `<svg>` element is a container, and it is used as the outermost element of SVG documents. To point the `<svg>` element, you can apply a few ways:

 - The `DocumentElement` property of the [Document](https://reference.aspose.com/svg/net/aspose.svg.dom/document/) class gives direct access to the `<svg>` element of the document. In the code snippet above, we use this way.

 - The `RootElement` property of the [SVGDocument](https://reference.aspose.com/svg/net/aspose.svg/svgdocument/) class returns the root `<svg>` element in the document hierarchy. To indicate the `<svg>` element, you can apply the following code:

The `LastElementChild` property of the Document class returns the last child element of the `<svg>` element.  It is  the `<g>` element. According to the code snippet above, the variable element is overloaded again, and `FirstElementChild` property returns the first child of the `<g>` element. It is the `<rect>` element.

### **Custom Filter Usage**

Aspose.SVG API gives you to define custom filters and use them for iterating over the document elements as shown in the following code sample:

```c# 
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Dom;
using Aspose.Svg.Dom.Traversal.Filters;
...    
    
    using (var document = new SVGDocument(Path.Combine(DataDir, "shapes.svg")))
    {
        // Create a node iterator
        using (var iterator = document.CreateNodeIterator(document, NodeFilter.SHOW_ALL, new RectFilter()))
        {
            Node node;
            while ((node = iterator.NextNode()) != null)
            {
                Console.WriteLine((node as Element)?.OuterHTML);
            }
        }
    }
```
where the **RectFilter** class is defined as follow:
```c# 
    public class RectFilter : NodeFilter
    {
        public override short AcceptNode(Node n)
        {
            return string.Equals("rect", n.NodeName) ? FILTER_ACCEPT : FILTER_REJECT;
        }
    }
```


The [CreateNodeIterator(`Node, Int64, INodeFilter`) ](https://reference.aspose.com/svg/net/aspose.svg.dom.traversal/idocumenttraversal/createnodeiterator/)method of the [IDocumentTraversal](https://reference.aspose.com/svg/net/aspose.svg.dom.traversal/idocumenttraversal/) interface creates a new iterator rooted at the specified `Node` (in our example, it is the `document`).  As parameters, the method takes `Node`, `Int64` flag that specifies node types for the iterator, and `INodeFilter` to be used (in our example, it is the `RectFilter()`).

The **RectFilter** class inherits from the [NodeFilter](https://reference.aspose.com/svg/net/aspose.svg.dom.traversal.filters/nodefilter/) class the [AcceptNode (`Node n`)](https://reference.aspose.com/svg/net/aspose.svg.dom.traversal.filters/nodefilter/acceptnode/) method. The method takes a `Node` and tests if it passes the filter or not; the method returns a short indicating whether the node is found or not.

In the iterator, we use the [NextNode()](https://reference.aspose.com/svg/net/aspose.svg.dom.traversal/inodeiterator/nextnode/) method of the [INodeIterator](https://reference.aspose.com/svg/net/aspose.svg.dom.traversal/inodeiterator/) Interface to access all the nodes of the document. The first call to the NextNode() returns the first node and moves the position of the iterator in the set. The  `OuterHTML` property of the [Element](https://reference.aspose.com/svg/net/aspose.svg.dom/element/) class returns the element's content that will be printed.

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-svg/Aspose.SVG-Documentation). About downloading from GitHub and running examples, you find out from the [**How to Run the Examples**](https://docs.aspose.com/svg/net/how-to-run-the-tests) section.
{{% /alert %}} 

## **Edit SVG Using CSS Selector**

Aspose.SVG for .NET also implements CSS Selector specification that allows you to navigate over the document by using CSS like style. 

The [QuerySelector(`selector`)](https://reference.aspose.com/svg/net/aspose.svg.dom/element/queryselector/) method of the [Element](https://reference.aspose.com/svg/net/aspose.svg.dom/element/) class allows you to get the first element within the document that matches the specified selector.  The [QuerySelectorAll(`selector`)](https://reference.aspose.com/svg/net/aspose.svg.dom/element/queryselectorall/) method takes as a parameter the query selector and  returns a **NodeList** of all the elements, which match the selector.  With the resulting elements, you can make various manipulations: change its text, attributes, CSS styles, and so on.

In the following examples, we use the QuerySelector()  and QuerySelectorAll() methods for navigation through an SVG document and search the needed elements. 

### **Example 1**

In Example 1, we edit the source [owl.svg](https://docs.aspose.com/svg/net/drawing-basics/svg-path-data/owl.svg) file  - is the owl SVG picture drawn by the path and circle elements.

Using the CSS Selector:
 - we find all circle elements in the SVG document and change their properties - make big blue eyes for the owl;
 - we find the path element for a wing of the owl and decorate it.

```c#
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Dom;
using Aspose.Svg.Collections;
...    
        
    using (var document = new SVGDocument(new Url("https://docs.aspose.com/svg/net/drawing-basics/svg-path-data/owl.svg")))
    {
        // Get root svg element of the document
        var svgElement = document.RootElement;
    
        // Find the first element that matches the specified in selector - g element
        SVGGElement gElement = svgElement.QuerySelector("g") as SVGGElement;
    
        // Find all circle elements in g element
        NodeList circleNodes = gElement.QuerySelectorAll("circle");
    
        // Make big blue eyes
        foreach (Node circleNode in circleNodes)
        {
            SVGCircleElement circleElement = circleNode as SVGCircleElement;
    
            circleElement.R.BaseVal.Value *= 1.5F;
            circleElement.SetAttribute("stroke", "blue");
        }
    
        // Get path for an owl wing
        SVGPathElement wingPath = gElement.QuerySelector("path:nth-child(2)") as SVGPathElement;
    
        // Apply style attributes to the wing
        wingPath.SetAttribute("stroke-width", "16");
        wingPath.SetAttribute("stroke-dasharray", "2 8");
    
        document.Save(OutputDir + "owl-edited1.svg");
    }

```

 You can view and save the edited SVG file by following the link - [owl-edited1.svg](/svg/net/how-to-work-with-aspose-svg-api/navigation-inspection/owl-edited1.svg).

### **Example 2**

In this example, we show how to use the CSS Selector to navigate a document for editing purposes. We continue to edit the source [owl.svg](https://docs.aspose.com/svg/net/drawing-basics/svg-path-data/owl.svg) file:

 - in the first part of Example 2, the round eyes of the owl will be changed to square and recolored.

We create a new `<g>` element, add into it the common attributes for children (they will be new square eyes) and append it as the last child in `<svg>` element (see [**How to Edit SVG Documents**](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/how-to-edit-svg-documents/)); using QuerySelectorAll (`"g:first-child > circle"`) method we find all circles into the first `<g>` element; then we create `<rect>` elements with the size attributes, add rectangles into the second `<g>` element and remove the circle elements.

The following code snippet demonstrates how to realize this task:

```c#
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Dom;
using Aspose.Svg.Collections;
...    
    
    // Create a new g element with style attributes and append it as the last child in svg element
    var gElement = (SVGGElement)document.CreateElementNS(SvgNamespace, "g");
    gElement.SetAttribute("fill", "none");
    gElement.SetAttribute("stroke-width", "2");
    svgElement.AppendChild(gElement);
    
    // Find all circle elements from the first g element
    NodeList circleNodes = svgElement.QuerySelectorAll("g:first-child > circle");
    
    // Make square sky-blue eyes
    foreach (Node circleNode in circleNodes)
    {
        var circleElement = circleNode as SVGCircleElement;
        
        float cx = circleElement.Cx.BaseVal.Value;
        float cy = circleElement.Cy.BaseVal.Value;
        float r = circleElement.R.BaseVal.Value;
    
        var rectElement = (SVGRectElement)document.CreateElementNS(SvgNamespace, "rect");
        rectElement.X.BaseVal.Value = cx - r;
        rectElement.Y.BaseVal.Value = cy - r;
        rectElement.Width.BaseVal.Value = 3 * r;
        rectElement.Height.BaseVal.Value = 3 * r;
        rectElement.SetAttribute("stroke", "SkyBlue");
        
        // Add the rectangle element into the last (new) g element 
        gElement.AppendChild(rectElement);
    	
    	// Remove the circle elements
        circleElement.Remove();
    }
    // Recolor last rectangle in the last (new) g element
    Element lastRect = gElement.LastElementChild;
    lastRect.SetAttribute("stroke", "red");
```

- in the second part of Example 2, the owl wing’s path will be changed from the curve to polyline and recolored.

```c#
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Dom;
using Aspose.Svg.Collections;
...     
    
    // Get path for owl body from the first g element
    Element bodyPath = (svgElement.QuerySelector("g:first-child") as SVGGElement).FirstElementChild;
    bodyPath.SetAttribute("stroke", "Teal");
    
    // Get path for owl wing from the first g element
    SVGPathElement wingPath = svgElement.QuerySelector("g:first-child > path:nth-child(2)") as SVGPathElement;
    
    // Form new wing path data based on the old
    string d = "";
    foreach (SVGPathSeg pathSeg in wingPath.PathSegList)
    {
        if (pathSeg is SVGPathSegMovetoAbs)
        {
            SVGPathSegMovetoAbs pathSegMovetoAbs = pathSeg as SVGPathSegMovetoAbs;
    
            d += string.Format(" M {0} {1}", pathSegMovetoAbs.X, pathSegMovetoAbs.Y);
        }
        if (pathSeg is SVGPathSegCurvetoCubicAbs)
        {
            SVGPathSegCurvetoCubicAbs pathSegCurvetoCubicAbs = pathSeg as SVGPathSegCurvetoCubicAbs;
            
            d += string.Format(
                " L {0} {1} L {2} {3}",
                (pathSegCurvetoCubicAbs.X1 + pathSegCurvetoCubicAbs.X2) / 2F,
                (pathSegCurvetoCubicAbs.Y1 + pathSegCurvetoCubicAbs.Y2) / 2F,
                pathSegCurvetoCubicAbs.X,
                pathSegCurvetoCubicAbs.Y
            );
        }
    }
    // Set d attribute - new path data formation
    wingPath.SetAttribute("d", d.Trim());
    wingPath.SetAttribute("stroke", "Teal");
    
    document.Save(OutputDir + "owl-edited2.svg");
```

 On the figure: the source picture (a), an edited picture according to Example 1 (b),  an edited picture according to Example  2 (c).

![Original and two edited owl images](owl-edited-svg.png#center)

In the examples above, we take the source [owl.svg](https://docs.aspose.com/svg/net/drawing-basics/svg-path-data/owl.svg) file and edit some elements. We tried to decorate the eyes and wing of the owl in various ways using  navigation and inspection Aspose.SVG API functions. You can view and save the edited SVG file by following the link - [owl-edited2.svg](/svg/net/how-to-work-with-aspose-svg-api/navigation-inspection/owl-edited2.svg).

## **Navigating SVG with XPath Query**

XPath Query ( [XML Path Language](https://www.w3.org/TR/xpath20/)), often referred to simply as an XPath, is a query language used to query data from documents. It is based on a DOM representation of the SVG document and selects nodes by various criteria. The syntax of the XPath expressions is quite simple, and what is more important, it is easy to read and support.

Aspose.SVG also has powerful XPath Specifications implementation along with Traversal Specifications. This empowers you to use XPath Query to navigate over the document ([shapes.svg](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/navigation-inspection/shapes.svg)) as shown in the following code sample:

```c#
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Dom;
using Aspose.Svg.Collections;
...     
    
    using (var document = new SVGDocument(Path.Combine(DataDir, "shapes.svg")))
    {
        //  Evaluate XPath expression
        var xpathResult = document.Evaluate("//rect[@x='120']", document, null, (Dom.XPath.XPathResultType)XPathResultType.Any, null);

        //  Get the next evaluated node
        Console.WriteLine((xpathResult.IterateNext() as Element)?.OuterHTML);		  
    }
```

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-svg/Aspose.SVG-Documentation). About downloading from GitHub and running examples, you find out from the [**How to Run the Examples**](https://docs.aspose.com/svg/net/how-to-run-the-tests/) section.
{{% /alert %}} 

