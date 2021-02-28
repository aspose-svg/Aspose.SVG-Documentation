---
title: Saving SVG Documents
description: Save SVG to a File, Save SVG to a Url
weight: 15
type: docs
aliases: /net/how-to-work-with-aspose-svg-api/saving-documents/
lastmod: 2020-12-15
---
## **Save an SVG document**

Most of the tasks, you need to perform,  require saving a document. Once you load the existing file or create an SVG document from scratch you are able to save your changes by using the one of **[SVGDocument.Save()](https://apireference.aspose.com/net/svg/aspose.svg/svgdocument/methods/save/index)** methods. There are overloaded methods that allow saving a document to a file, stream, or Url. 

 In this chapter, we review the SVG documents saving to the same format. You find out how to save your SVG file using **Save()** methods of the **[SVGDocument](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument)** class. The scenarios of converting and rendering SVG to other formats are viewed in the **[How to Convert SVG Files](http://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/converting/)** section. 

{{% alert color="primary" %}} 

You can try to convert SVG documents to a variety of other formats with our [Free online SVG converter](https://products.aspose.app/svg/conversion).

{{% /alert %}} 

### **Saving to a File**

The following code snippet demonstrates the use of the **[SVGDocument.Save()](https://apireference.aspose.com/net/svg/aspose.svg/svgdocument/methods/save/index)** method to save an SVG document to a file:
{{< highlight java >}}
using System.IO;
using Aspose.Svg;
...
    // Prepare a path for an SVG document saving
	string documentPath = Path.Combine(OutputDir, "Lineto_out.svg");

```
//  Load the SVG document from a file
using (var document = new SVGDocument(Path.Combine(DataDir, "Lineto.svg")))
{
    // Work with the document

    // Save SVG to a file
    document.Save(documentPath);
}
```

{{< /highlight >}}

### **Saving to a Url**

It is necessary to specify a complete Url path for the document [Lineto.svg](http://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/saving-documents/Lineto.svg) saving and pass `url` object to the **Save()** method. The following code example shows how to save a document to a Url:

{{< highlight java >}}
using System.IO;
using Aspose.Svg;
...
    // Set a full (complete) path for an SVG document saving
	var url = new Url(Path.Combine(OutputDir, "Lineto_out.svg"), Directory.GetCurrentDirectory());

```
//  Load the SVG document from a file
using (var document = new SVGDocument(Path.Combine(DataDir, "Lineto.svg")))
{
    // Work with the document
    
    // Save SVG to the Url
    document.Save(url);
}
```

{{< /highlight >}}

{{% alert color="primary" %}} 
You can download the complete examples and data files from **[GitHub](https://github.com/aspose-svg/Aspose.SVG-Documentation)**. About downloading from GitHub and running examples, you find out from the **[How to Run the Examples](http://docs.aspose.com/svg/net/how-to-run-the-tests)** section.
{{% /alert %}}