---
title: Saving SVG Documents
keywords: save SVG, SVG document, SVG file, SVG to URL, SVG to zip, SVG to stream, memory stream, svg example, c# code snippet
description: In the article, you will learn how to save an SVG document to a file, memory stream, or Url using Aspose.SVG for .NET library.
weight: 20
type: docs
url: /net/how-to-work-with-aspose-svg-api/saving-svg-documents/
aliases: 
  - /net/how-to-work-with-aspose-svg-api/saving-svg-documents/
  - /net/save-svg-files/
lastmod: 2021-10-11
---
## **Save an SVG document**


<link href="./../../style.css" rel="stylesheet" type="text/css" />


Most of the tasks, you need to perform,  require saving a document. Once you load the existing file or create an SVG document from scratch, you can save your changes using one of [SVGDocument.Save()](https://apireference.aspose.com/net/svg/aspose.svg/svgdocument/methods/save/index) methods. There are overloaded methods that allow saving SVG to a file, stream, or Url. 

In this chapter, we review the SVG documents saving to the same format. You find out how to save your SVG file using Save() methods of the [SVGDocument](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument) class. Moreover, Aspose.SVG for .NET provides the [IOutputStorage](https://apireference.aspose.com/svg/net/aspose.svg.io/ioutputstorage) interface that allows save SVG documents with resources to streams and manage them.

The scenarios of converting and rendering SVG to other formats are viewed in the **[How to Convert SVG Files](http://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/converting/)** section. 

{{% alert color="primary" %}} 
You can try to convert SVG documents to various other formats with our [**Free Online SVG Converter**](https://products.aspose.app/svg/conversion).
{{% /alert %}} 

<a href="https://products.aspose.app/svg/conversion" target="_blank">![Text "Banner SVG Converter"](svg-converter.png#center)</a>


### **Save SVG to a File**

The following code snippet demonstrates the use of the [SVGDocument.Save()](https://apireference.aspose.com/net/svg/aspose.svg/svgdocument/methods/save/index) method to save an SVG document to a file:

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
    
        // Save SVG to file
        document.Save(documentPath);
    }
```

### **Save SVG to a Url**

It is necessary to specify a full Url path for the document [Lineto.svg](http://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/saving-svg-documents/Lineto.svg) saving and pass the `url` object to the **Save()** method. The following code example shows how to save a document to a Url:

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
        
        // Save SVG to Url
        document.Save(url);
    }
```

### **Save SVG to a Local File System Storage**

The SVG document can contain different resources like CSS, external images and files. Aspose.SVG provides a way to save SVG with all linked files - the [IOutputStorage](https://apireference.aspose.com/svg/net/aspose.svg.io/ioutputstorage) interface is developed for saving SVG content and resources to streams. 

Let's consider an example of saving SVG with linked file to user-specified local file storage. The source [WithExternalHTML.svg](http://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/saving-svg-documents/WithExternalHTML.svg) document with the joined [simpleHTML.htm](http://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/saving-svg-documents/simpleHTML.htm) file are in the same directory. The [LocalFileSystemStorage(`customOutDir`)](https://apireference.aspose.com/svg/net/aspose.svg.io/localfilesystemstorage/constructors/1) constructor creates an object that is a file system storage. The [Save(`IOutputStorage`)](https://apireference.aspose.com/svg/net/aspose.svg/svgdocument/methods/save) method takes this object and saves SVG to the output storage.

```c#
using System.IO;
using Aspose.Svg.IO;
...
    
	// Prepare a path to a source SVG file  
    string inputPath = Path.Combine(DataDir, "WithExternalHTML.svg");

    // Prepare a full path to an output directory 
    string customOutDir = Path.Combine(Directory.GetCurrentDirectory(), "./../../../../tests-out/saving");

    // Load the SVG document from a file
    using (var doc = new SVGDocument(inputPath))
    {
        // Save SVG with resources
        doc.Save(new LocalFileSystemStorage(customOutDir));
    }
```

### **Save SVG to a Zip Archive**

The  [IOutputStorage](https://apireference.aspose.com/svg/net/aspose.svg.io/ioutputstorage) interface is a base interface that supports the creation and management of output streams.  It contains two methods to manage streams: [CreateStream()](https://apireference.aspose.com/svg/net/aspose.svg.io/ioutputstorage/methods/createstream) and [ReleaseStream()](https://apireference.aspose.com/svg/net/aspose.svg.io/ioutputstorage/methods/releasestream).  The [OutputStream](https://apireference.aspose.com/svg/net/aspose.svg.io/outputstream) Class is a surrogate stream that wraps the real output stream and controls access to it. OutputStream contains URI data that describes the location of the output stream.

You can implement the IOutputStorage interface by creating **ZipStorage** class. View the example of saving SVG with resources (two files from the previous example) to a ZIP archive using ZipStorage class.

```c#
using System.IO;
using Aspose.Svg.IO;
using System.IO.Compression;
...
    
	// Prepare a path to a source SVG file 
    string inputPath = Path.Combine(DataDir, "WithExternalHTML.svg");
    
    var dir = Directory.GetCurrentDirectory();

    // Prepare a full path to an output zip storage
    string customArchivePath = Path.Combine(dir, "./../../../../tests-out/saving/archive.zip");

    // Load the SVG document 
    using (var doc = new SVGDocument(inputPath))
    {
        // Initialize an instance of the ZipStorage class
        using (var zipSrorage = new ZipStorage(customArchivePath))
        {
            // Save SVG with resources to a Zip archive
            doc.Save(zipSrorage);                    
        }                
    }
```

The IOutputStorage interface is intended for customers implementation. The following code snippet shows the realization of the IOutputStorage in the **ZipStorage** class to demonstrate saving an SVG document to a Zip archive.

```c#
internal class ZipStorage : IOutputStorage, IDisposable
{
    private FileStream zipStream;
    private ZipArchive archive;
    private int streamsCounter;
    private bool initialized;

    public ZipStorage(string name)
    {
        DisposeArchive();
        zipStream = new FileStream(name, FileMode.Create);
        archive = new ZipArchive(zipStream, ZipArchiveMode.Update);
        initialized = false;
    }
	
    public OutputStream CreateStream(OutputStreamContext context)
    {
        var zipUri = (streamsCounter++ == 0 ? Path.GetFileName(context.Uri) :
            Path.Combine(Path.GetFileName(Path.GetDirectoryName(context.Uri)), Path.GetFileName(context.Uri)));
        var samplePrefix = String.Empty;
        if (initialized)
            samplePrefix = "my_";
        else
            initialized = true;

        var newStream = archive.CreateEntry(samplePrefix + zipUri).Open();
        var outputStream = new OutputStream(newStream, "file:///" + samplePrefix + zipUri);
        return outputStream;
    }
	
    public void ReleaseStream(OutputStream stream)
    {
        stream.Flush();
        stream.Close();
    }

    private void DisposeArchive()
    {
        if (archive != null)
        {
            archive.Dispose();
            archive = null;
        }
        if (zipStream != null)
        {
            zipStream.Dispose();
            zipStream = null;
        }
        streamsCounter = 0;
    }

    public void Dispose()
    {
        DisposeArchive();
    }
}
```

### **Save SVG to Memory Streams**

The **IOutputStorage** interface implementation allows saving SVG to memory streams:

```c#
using System.IO;
using Aspose.Svg.IO;
using System.Collections.Generic;
...
    // Prepare a path to a source SVG file
    string inputPath = Path.Combine(DataDir, "WithExternalHTML.svg");

    using (var doc = new SVGDocument(inputPath))
    {
        // Create an instance of the MemoryOutputStorage class and save SVG to memory
        var memoryStorage = new MemoryOutputStorage();
        doc.Save(memoryStorage);
	    memoryStorage.PrintInfo();       
    } 
```

After the example run, the message about memory storage will be printed:
`uri:memory:///WithExternalHTML.svg, length:570`
`uri:memory:///simpleHTML.htm, length:369`

The following code snippet shows the realization of the IOutputStorage in the **MemoryOutputStorage** class to demonstrate saving an SVG document to memory streams.

```c#
internal class MemoryOutputStorage : IOutputStorage
{
    public List<Tuple<OutputStream, string>> Streams;

    public MemoryOutputStorage()
    {
        Streams = new List<Tuple<OutputStream, string>>();
    }

    public OutputStream CreateStream(OutputStreamContext context)
    {
        var normalizedPath = new Url(context.Uri).Pathname;
        var uri = new Url(Path.GetFileName(normalizedPath), "memory:///").Href;
        var outputStream = new OutputStream(new MemoryStream(), uri);
        Streams.Add(Tuple.Create(outputStream, uri));
        return outputStream;
    }

    public void ReleaseStream(OutputStream stream)
    {
        stream.Flush();
    }

    public void PrintInfo()
    {
        foreach (var stream in Streams)
            Console.WriteLine($"uri:{stream.Item2}, length:{stream.Item1.Length}");
    }   
}
```

{{% alert color="primary" %}} 
You can download the complete examples and data files from **[GitHub](https://github.com/aspose-svg/Aspose.SVG-Documentation)**. About downloading from GitHub and running examples, you find out from the **[How to Run the Examples](http://docs.aspose.com/svg/net/how-to-run-the-tests)** section.
{{% /alert %}}