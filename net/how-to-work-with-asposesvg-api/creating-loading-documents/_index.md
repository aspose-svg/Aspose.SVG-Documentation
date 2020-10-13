---
title: Creating and Loading Documents
type: docs
weight: 10
url: /net/how-to-work-with-asposesvg-api/creating-loading-documents/
---



To perform any task, you must create or load a document. Aspose.SVG for .NET API lets you build (construct) an SVG document from scratch as well as load an existing SVG from different sources. The API provides the `SVGDocument` class that has several constructors allowing you to produce new class instances.
SVG files can be created & loaded:

 - from scratch as an empty document with SVG structure
 - from user-provided string
 - from memory stream
 - from web (a URL referring to the XML file).

This section provides some examples of creation & loading SVG files using the Aspose.SVG API.

## **Create an Empty SVG Document**

Aspose.SVG for .NET API provides the [`SVGDocument`](https://apireference.aspose.com/net/svg/aspose.svg/svgdocument) class that can be used to create an empty document using its default constructor. Once the document object is created, it can be filled later with SVG elements. The following code snippet shows the usage of the default constructor of [**SVGDocument**](https://apireference.aspose.com/net/svg/aspose.svg/svgdocument) class to create an SVG Document.

{{< highlight java >}}
    // For complete examples and data files, please go to https://github.com/aspose-svg/Aspose.SVG-for-.NET
    using (SVGDocument document = new SVGDocument())
    {
        // Work with SVG document here...
    }
{{< /highlight >}}

## **Create from** Memory Stream & **String**

You can create a document from a string context using the `SVGDocument (string, string)` constructor. If your case is to create a document from a user string directly in your code, the following example could help you:  we produce the SVG file containing a circle with a radius of 50 pixels.

{{< highlight java >}}
    // For complete examples and data files, please go to https://github.com/aspose-svg/Aspose.SVG-for-.NET
    using (SVGDocument document = new SVGDocument("<svg xmlns=\"http://www.w3.org/2000/svg\"><circle cx=\"50\" cy=\"50\" r=\"40\" /></svg>", "."))
    {
        // Work with SVG document here...
    }
{{< /highlight >}}

## **Create from Local File**

To load an SVG document from a file, use the default constructor of the `SVGDocument` class and pass the file path as the input parameter to it.

{{< highlight java >}}
 string pathToSvgFile = Path.Combine(dataDir, "example.svg");
    using (SVGDocument document = new SVGDocument(pathToSvgFile))
    {
        // Work with SVG document here...
    }
{{< /highlight >}}


## **Create from Web**

The following example could help you to create a document from a URL referring to the XML file:

{{< highlight java >}}
 Url urlOfSvgFile = new Url("https://docs.aspose.com/svg/net/drawing-basics/svg-path-data/owl.svg");
    using (SVGDocument document = new SVGDocument(urlOfSvgFile))
    {
        // Work with SVG document here...
    }
{{< /highlight >}}

{{% alert color="primary" %}} 

If you set a wrong URL that can’t be reached right at this moment, the library throws the DOMException with specialized code ‘NetworkError’ to inform that selected resource can not be found.

{{% /alert %}} 

### Reading SVG with Resources Async

If the SVG to load contains external resources, it may take time to load all resources completely and, hence, resulting in blocking of the main application thread. In an Async model, the Load and ReadyStateChange events can be subscribed to notify the loading application for complete loading of the SVG file as shown in the following code sample.

{{< gist "aspose-com-gists" "0420a5530f73658aebea7f98ea4d705f" "Examples-CSharp-LoadSaveConvert-LoadSVGDocumentAsync-LoadSVGDocumentAsync.cs" >}}