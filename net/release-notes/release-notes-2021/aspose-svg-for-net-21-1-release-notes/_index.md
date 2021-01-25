---
title: Aspose.SVG for .NET 21.1 Release Notes
type: docs
weight: 50
url: /net/aspose-svg-for-net-21-1-release-notes/
---

{{% alert color="primary" %}}

This page contains release notes information for Aspose.SVG for .NET 21.1

{{% /alert %}}

## **Major Features**

As per the regular monthly update process of all APIs being offered by Aspose, we are honored to announce the January release of Aspose.SVG for .NET.
We have added support for saving SVGDocument with new IOutputStorage interface. This interface allows save SVG document content and resources to streams and manage them.   

## **Public API changes:**

### **Added APIs:**

Next interface and classes were added to namespace [Aspose.Svg.IO Namespace](https://apireference.aspose.com/svg/net/aspose.svg.io):

- A base interface that supports the creation and management of output streams OutputStream [IOutputStorage](https://apireference.aspose.com/svg/net/aspose.svg.io/ioutputstorage).
- A surrogate stream wraps the real output stream and controls access to it. OutputStream conatins URI data that describes location of the output stream [OutputStream](https://apireference.aspose.com/svg/net/aspose.svg.io/outputstream).
- A context for initialization of the output stream [OutputStreamContext](https://apireference.aspose.com/svg/net/aspose.svg.io/outputstreamcontext).
- A file system storage [LocalFileSystemStorage ](https://apireference.aspose.com/svg/net/aspose.svg.io/localfilesystemstorage).

Three new methods for saving the document content and resources to the output storage were added to SVGDocument:
- [Save&#x00028;IOutputStorage&#x00029;] (https://apireference.aspose.com/svg/net/aspose.svg/svgdocument/methods/save) 
- [Save(IOutputStorage, SVGSaveFormat)](https://apireference.aspose.com/svg/net/aspose.svg.svgdocument/save/methods/1)
- [Save(IOutputStorage, SVGSaveOptions)](https://apireference.aspose.com/svg/net/aspose.svg.svgdocument/save/methods/2)


### **Changed APIs:**

No Changes

### **Removed APIs:**

No Changes
