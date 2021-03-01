---
title: Saving SVG Documents
keywords: SVG, save SVG, SVG file, SVG to URL, zip, zip archive, SVG to zip, SVG
  to stream, memory stream
description: In this article, you find out how to save your SVG document to a
  file, a memory stream, or a Url using Aspose.SVG for .NET library.
weight: 15
type: docs
aliases: /net/how-to-work-with-aspose-svg-api/saving-documents/
lastmod: 2020-12-15
---
## **Save an SVG document**

Most of the tasks, you need to perform,  require saving a document. Once you load the existing file or create an SVG document from scratch you are able to save your changes by using the one of **[SVGDocument.Save()](https://apireference.aspose.com/net/svg/aspose.svg/svgdocument/methods/save/index)** methods. There are overloaded methods that allow saving a document to a file, stream, or Url. 

 In this chapter, we review the SVG documents saving to the same format. You find out how to save your SVG file using **Save()** methods of the **[SVGDocument](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument)** class. Moreover, Aspose.SVG for .NET provides the **[IOutputStorage](https://apireference.aspose.com/svg/net/aspose.svg.io/ioutputstorage)** interface that allows save SVG document content and resources to streams and manage them.

The scenarios of converting and rendering SVG to other formats are viewed in the **[How to Convert SVG Files](http://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/converting/)** section. 

{{% alert color="primary" %}} 

You can try to convert SVG documents to a variety of other formats with our [Free online SVG converter](https://products.aspose.app/svg/conversion).

{{% /alert %}} 

### **Saving SVG to a File**

The following code snippet demonstrates the use of the **[SVGDocument.Save()](https://apireference.aspose.com/net/svg/aspose.svg/svgdocument/methods/save/index)** method to save an SVG document to a file:

```c#
using System.IO;
using Aspose.Svg;
...
    
    // Prepare a path for an SVG document saving
	string documentPath = Path.Combine(OutputDir, "Lineto_out.svg");

    //  Load the SVG document from a file
    using (var document = new SVGDocument(Path.Combine(DataDir, "Lineto.svg")))
    {
        // Work with the document
    
        // Save SVG to a file
        document.Save(documentPath);
    }
```

### **Saving SVG to a Url**

It is necessary to specify a complete Url path for the document [Lineto.svg](http://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/saving-documents/Lineto.svg) saving and pass `url` object to the **Save()** method. The following code example shows how to save a document to a Url:

```c#
using System.IO;
using Aspose.Svg;
...
    
    // Set a full path for an SVG document saving
	var url = new Url(Path.Combine(OutputDir, "Lineto_out.svg"), Directory.GetCurrentDirectory());

    //  Load the SVG document from a file
    using (var document = new SVGDocument(Path.Combine(DataDir, "Lineto.svg")))
    {
        // Work with the document
        
        // Save SVG to the Url
        document.Save(url);
    }
```

### **Saving SVG to a Local File System Storage**

The SVG document can contain different resources like CSS, external images and files. Aspose.SVG provides a way to save SVG with all linked files. 

Let's consider an example of saving SVG with linked file to user-specified local file storage. The source [WithExternalHTML.svg]((http://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/saving-documents/WithExternalHTML.svg)) document with the linked [simpleHTML.html](http://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/saving-documents/simpleHTML.html) file are in the same directory. The **LocalFileSystemStorage**(`customOutDir`) method creates an object that is a file system storage. The **Save**(`IOutputStorage`) method takes this object and saves the document content and resources to the output storage.

```c#
using System.IO;
using Aspose.Svg.IO;
...
    
	// Prepare a path to a source SVG file loading  
    string inputPath = Path.Combine(DataDir, "WithExternalHTML.svg");

    // Prepare a full path to an output directory 
    string customOutDir = Path.Combine(Directory.GetCurrentDirectory(), "./../../../../tests-out/custom-dir");

    // Load the SVG document from a file
    using (var doc = new SVGDocument(inputPath))
    {
        // Save SVG with resources
        doc.Save(new LocalFileSystemStorage(customOutDir));
    }
```

### **Saving SVG to a Zip Archive**

The **ZipStorage** class is designed to save an SVG document to a ZIP archive.  Examine the example of saving SVG with resources (two files from the previous case) to a ZIP archive. 

```c#
using System.IO;
using Aspose.Svg.IO;
using System.IO.Compression;
...
    
	// Prepare a path to a source SVG file loading 
    string inputPath = Path.Combine(DataDir, "WithExternalHTML.svg");
    
    var dir = Directory.GetCurrentDirectory();

    // Prepare a full path to an output ZipStorage
    string customArchivePath = Path.Combine(dir, "./../../../../tests-out/custom-dir/archive.zip");

    // Load the SVG document 
    using (var doc = new SVGDocument(inputPath))
    {
        // Initialize an instance of the ZipStorage class
        using (var zipSrorage = new ZipStorage(customArchivePath))
        {
            // Save SVG with resources to a ZIP archive
            doc.Save(zipSrorage);                    
        }                
    }
```

The  **[IOutputStorage](https://apireference.aspose.com/svg/net/aspose.svg.io/ioutputstorage)** interface is a base interface that supports the creation and management of output streams **[OutputStream](https://apireference.aspose.com/svg/net/aspose.svg.io/outputstream)**.

### **Saving SVG to Memory Streams**

{{% alert color="primary" %}} 
You can download the complete examples and data files from **[GitHub](https://github.com/aspose-svg/Aspose.SVG-Documentation)**. About downloading from GitHub and running examples, you find out from the **[How to Run the Examples](http://docs.aspose.com/svg/net/how-to-run-the-tests)** section.
{{% /alert %}}