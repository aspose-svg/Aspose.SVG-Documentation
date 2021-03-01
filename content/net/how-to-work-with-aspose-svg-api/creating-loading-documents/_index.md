---
title: Creating and Loading SVG Documents
type: docs
weight: 10
aliases: /net/how-to-work-with-aspose-svg-api/creating-loading-documents/
lastmod: "2020-12-15"
keywords: SVG, create SVG, SVG file, load SVG, SVG document
description: In this article, you find out how to create an Empty SVG Document, create SVG from a memory string, create SVG from a stream, load SVG from a file, load SVG from the Web, and reading SVG with Resources Async
---


To perform any task, you must create or load a document. Aspose.SVG for .NET API lets you construct an SVG document from scratch as well as load an existing SVG from different sources. The API provides [**SVGDocument**](https://apireference.aspose.com/net/svg/aspose.svg/svgdocument) class that has several constructors allowing you to produce new class instances. The **SVGDocument** is the root of the SVG DOM hierarchy, holds the entire content and entirely based on  [W3C SVG 2.0 ](https://www.w3.org/TR/SVG2/)  and [WHATWG DOM](https://dom.spec.whatwg.org/) specifications.

SVG files can be created & loaded:

 - from scratch as an empty document with SVG structure,
 - from user-provided string,
 - from a memory stream or a file,
 - from the web.

This section provides some examples of creation & loading SVG files using Aspose.SVG for .NET API. The **SVGDocument** has a wide set of overloaded constructors allowing you to create a blank document or load it from a file, URL, stream, etc.

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-svg/Aspose.SVG-Documentation). About downloading from GitHub and running examples, you find out from the [**How to Run the Examples**](http://docs.aspose.com/svg/net/how-to-run-the-tests) section.
{{% /alert %}} 

## **Create an Empty SVG Document**

Aspose.SVG for .NET API provides the [**SVGDocument**](https://apireference.aspose.com/net/svg/aspose.svg/svgdocument "Aspose.Svg.SVGDocument API Reference") class that can be used to create an empty document using its default constructor. Once the document object is created, it can be filled later with SVG elements. The following code snippet shows the usage of the default **SVGDocument()** constructor to create an SVG document.

```c#
using Aspose.Svg;
...
    
    // Initialize an empty SVG document
    using (var document = new SVGDocument())
    {
        // Work with the SVG document here...
    }
```

If you want to save created empty SVG document to a file, use the following code snippet: 

```c#
using Aspose.Svg;
using System.IO;
...
    
    // Prepare output path for a document saving
    string documentPath = Path.Combine(OutputDir, "empty.svg");
    
	// Initialize an empty SVG document
	using (var document = new SVGDocument())
	{
	    // Work with the SVG document here...
	   
	    // Save the document to a file
	    document.Save(documentPath);
	}
```

More details about SVG files saving are in the [**Saving Documents**](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/saving-documents/) section.

## **Create SVG from a Memory String**

You can create a document from a string content using **SVGDocument (`string, string`)** constructor. If your case is to create a document from a user string directly in your code and you don’t need to save it to a file, the following example could help you: we produce an SVG document that contains a circle with a radius of 50 pixels.

```c#
using Aspose.Svg;
...
    
    // Prepare an SVG code
    var documentContent = "<svg xmlns=\"http://www.w3.org/2000/svg\"><circle cx=\"50\" cy=\"50\" r=\"40\" /></svg>";	

	// Initialize an SVG document from a string content
	using (var document = new SVGDocument(documentContent, "."))
	{
	    // Work with the document here...
	}
```

## **Create SVG from a Stream**

To create an SVG document from a stream, use one of SVGDocument() constructors:

```c#
using Aspose.Svg;
using System.IO;
...
    
    //Prepare a path to a file required for a FileStream object creating
    string documentPath = Path.Combine(DataDir, "QBezier.svg");
    
	// Create a FileStream object
	using (var stream = new FileStream(documentPath, FileMode.Open, FileAccess.Read))
	{
	    // Initialize an SVG document from the stream
		using (var document = new SVGDocument(stream, "."))
	    {
	        // Work with the document
	    }
	}
```

## **Load SVG from a File**

To load an SVG document from a file [QBezier.svg](http://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/creating-loading-documents/QBezier.svg), use the default constructor of the [**SVGDocument**](https://apireference.aspose.com/net/svg/aspose.svg/svgdocument) class and pass the file path as the input parameter to it.

```c#
using Aspose.Svg;
using System.IO;
...
    
    // Prepare a path to a file loading
    string documentPath = Path.Combine(DataDir, "QBezier.svg"); 
	
	// Load an SVG document from a file
	using (var document = new SVGDocument(documentPath))
	{
	    // Work with the document 
	}
```

## **Load SVG from the Web**

The following examples could help you to create a document from URL referring to the XML file:

```c#
using Aspose.Svg;
...
    
    var documentUrl = new Url("https://docs.aspose.com/svg/net/drawing-basics/svg-path-data/owl.svg");
    using (var document = new SVGDocument(documentUrl))
    {
        // Work with the SVG document here...
    }
```

```c#
using Aspose.Svg;
...
    
    using (var document = new SVGDocument(new Url("https://docs.aspose.com/svg/net/drawing-basics/basic-shapes/basic-shapes.svg")))
    {
        // Work with the SVG document here...
    }
```

{{% alert color="primary" %}} 

If you set a wrong URL that can’t be reached right at this moment, the library throws the DOMException with specialized code ‘NetworkError’ to inform that selected resource can not be found.

{{% /alert %}} 

## **Reading SVG with Resources Async**

If SVG to load contains external resources, it may take time to load all resources completely and, hence, resulting in blocking of the main application thread. In an Async model, the Load and ReadyStateChange events can be subscribed to notify the loading application for complete loading of the SVG file as shown in the following code sample. The **Navigate(`Url`)** method of the **[SVGDocument](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument)** class is used for the document loading at the specified URL into the current instance.

```c#
using Aspose.Svg;
using System.Threading;
...
    
    var documentUrl = new Url("https://docs.aspose.com/svg/net/drawing-basics/svg-path-data/owl.svg");
	var document = new SVGDocument();
	var documentEvent = new ManualResetEvent(false);
	
	// Subscribe to the event 'OnReadyStateChange' that will be fired once the document is completely loaded    
	document.OnReadyStateChange += (sender, ev) =>
	{
	    if (document.ReadyState == "complete")
	    {
	        // Sets the state of the event to signaled to unblock the main thread
	        documentEvent.Set();
	    }
	};
	// Load the SVG document Async
	document.Navigate(documentUrl);
	
	// Blocks the current thread while the document is loading
	documentEvent.WaitOne();
	
	// Work with the document
	

```
