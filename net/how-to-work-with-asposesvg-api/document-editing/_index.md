---
title: Document Editing
type: docs
weight: 20
url: /net/how-to-work-with-asposesvg-api/document-editing/
---



## **Adding Basic Shapes to an SVG Document**

Aspose.SVG API allows you to add any (various) elements to the document.  You can use the `CreateElementNS (string namespaceURI, string qualifiedName)` method of the `SVGDocument` class to create an instance (of SVGElement class):  the required element of the given qualified name and namespace URI.

The `namespaceURI` must be "http://www.w3.org/2000/svg". The `qualifiedName` must contain the string name of the tag (element). Remember, you must use an explicit conversion type to get the corresponding element.

For a `<g>` element creating, we can use the following construction:
{{< highlight java >}}
SVGGElement gElement = (SVGGElement)document.CreateElementNS("http://www.w3.org/2000/svg", "g");
{{< /highlight >}}
Applying Filters to Bitmaps



Drawing on Existing Bitmaps