---
title: Text Vectorization & Text Security | .NET
linktitle: Text Vectorization & Text Security
type: docs
weight: 30
url: /net/how-to-work-with-aspose-svg-api/text-vectorization/
aliases: 
 - /net/vectorize-text/ 
lastmod: 2022-01-10
changefreq: weekly
priority: 0.7
description: This article explains how to convert SVG text to vector using the VectorizeText property of the SVGSaveOptions class.
keywords: SVG Text, Text to Vector, Text Vectorization, Text Security, Vectorize Text, c# example 
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

{{% alert color="primary" %}} 
 Aspose.SVG proposes you convert text to vector in a short time and with professional quality and resolution! In the vectorized SVG text, all font glyphs are replaced with a combination of graphics elements. Convert your SVG text with our <a href="https://products.aspose.app/svg/text-to-vector" target="_blank">**Text to Vector** </a> app and get all the advantages of vectorized text!
{{% /alert %}} 

<a href="https://products.aspose.app/svg/text-to-vector" target="_blank">![Text "Banner Text to Vector"](./../vectorization/svg-text-vectorizer.png#center)</a>

The text elements are closely related to the concept of font, glyph and symbol. When a computer renders characters, it maps those characters to glyphs in a font.

In the vectorized SVG text, all font glyphs are replaced with the combination of `<path>`, `<use>`, `<mask>`, `<g>` elements, and etc.  When you convert text to a vector path, you will no longer be able to edit the text in a text editor. Thus, text vectorization serves as some text security from unwanted using, borrowing,  and editing.
 But, you will be able to edit the vector paths. Keep in mind that the text is no longer saved as a font, it became a vector object. This will allow you to create logos or wordmarks, combine multiple paths into a single, reduce the file size, etc.

Text vectorization can be useful in cases where unique fonts are applied to the text, which are not installed on the user's configuration. Vectorized SVG text retains its style (font) when getting in any computer environment, whether this font is installed or not. This is why that fonts within most vector logos containing text are converted to outlines.

The vectorized text, being a digital graphic, can be scaled with saving quality. The “filter”, “mask”, “opacity”, and other effects can be applied to the vectorized SVG text. Vectorization also results in the reduction of the generated SVG Document.

Aspose.SVG for .NET API provides the feature of vectorizing text elements in SVG documents. To vectorize text, set the [`VectorizeText`](https://reference.aspose.com/svg/net/aspose.svg.saving/svgsaveoptions/vectorizetext/) property of the [SVGSaveOptions](https://reference.aspose.com/svg/net/aspose.svg.saving/svgsaveoptions/) class to `true`.

The following code snippet demonstrates the use of the `VectorizeText` property for text vectorization in [text.svg](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/text-vectorization/text.svg) file:
```c#
using System.IO;
using Aspose.Svg;
using Aspose.Svg.Saving;
...
    
    // Load an SVG document from a file
    var document = new SVGDocument(Path.Combine(DataDir, "text.svg"));

    // Set text elements vectorization 
    var saveOptions = new SVGSaveOptions
    {
        VectorizeText = true
    };
    
    // Save the SVG document with specified saveOptions
    document.Save(Path.Combine(OutputDir, "text_vectorized.svg"), saveOptions);
```

The vectorized text, being a digital graphic, has some advantages:
 - can be scaled with saving quality;

 - results in the reduction of the generated SVG document;

 - retains its style when used in any computer environment;

 - serves the text security from unwanted using, borrowing,  and editing.

{{% alert color="primary" %}} 
You can download the complete C# examples and data files from [**GitHub**](https://github.com/aspose-svg/Aspose.SVG-Documentation/tree/main/content/tests-net). About downloading from GitHub and running examples, you find out from the [**How to Run the Examples**](https://docs.aspose.com/svg/net/how-to-run-the-tests/) section.
{{% /alert %}} 



