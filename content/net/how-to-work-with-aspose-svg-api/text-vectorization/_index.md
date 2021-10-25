---
title: Text Vectorization & Text Security | .NET
linktitle: Text Vectorization & Text Security
type: docs
weight: 80
aliases: 
 - /net/vectorize-text/ 
lastmod: 2021-10-12
description: This article explains how to convert SVG text to vector using the VectorizeText property of the SVGSaveOptions class.
keywords: SVG Text, Text to Vector, Text Vectorization, Text Security, Vectorize Text 
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

{{% alert color="primary" %}} 
 Aspose.SVG proposes you convert text to vector in a short time and with professional quality and resolution! In the vectorized SVG text, all font glyphs are replaced with a combination of graphics elements. Convert your SVG text to vector with our <a href="https://products.aspose.app/svg/en/text-vectorization" target="_blank">**SVG Text Vectorization** </a> app and get all the advantages of vectorized text!
{{% /alert %}} 

<a href="https://products.aspose.app/svg/en/text-vectorization" target="_blank">![Text "Banner SVG Text Vectorization"](svg-text-vectorizer.png#center)</a>

The text elements are closely related to the concept of font, glyph and symbol. When a computer renders characters, it maps those characters to glyphs in a font.

In the vectorized SVG text, all font glyphs are replaced with the combination of `<path>`, `<use>`, `<mask>`, `<g>` elements, and etc.  The text is converted to digital graphics and cannot be edited. Thus, text vectorization serves as some text security from unwanted using, borrowing,  and editing.

Text vectorization can be useful in cases where unique fonts are applied to the text, which are not installed on the user's configuration. Vectorized SVG text retains its style (font) when getting in any computer environment, whether this font is installed or not.

The vectorized text, being a digital graphic, can be scaled with saving quality. The “filter”, “mask”, “opacity”, and other effects can be applied to the vectorized SVG text. Vectorization also results in the reduction of the generated SVG Document.

Aspose.SVG for .NET API provides the feature of vectorizing text elements in SVG documents. To vectorize text, set the [`VectorizeText`](https://apireference.aspose.com/svg/net/aspose.svg.saving/svgsaveoptions/properties/vectorizetext) property of the [SVGSaveOptions](https://apireference.aspose.com/svg/net/aspose.svg.saving/svgsaveoptions) class to `true`.

The following code snippet demonstrates the use of the `VectorizeText` property for text vectorization in [Text.svg](http://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/text-vectorization/Text.svg) file:
```c#
using System.IO;
using Aspose.Svg;
using Aspose.Svg.Saving;
...
    
    // Load an SVG document from a file
    var document = new SVGDocument(Path.Combine(DataDir, "Text.svg"));

    // Set text elements vectorization 
    var saveOptions = new SVGSaveOptions
    {
        VectorizeText = true
    };
    
    // Save the SVG document with specified saveOptions
    document.Save(Path.Combine(OutputDir, "Text_vectorized.svg"), saveOptions);
```

The vectorized text, being a digital graphic, has some advantages:
 - can be scaled with saving quality;

 - results in the reduction of the generated SVG document;

 - retains its style when used in any computer environment;

 - serves the text security from unwanted using, borrowing,  and editing.

   

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-svg/Aspose.SVG-Documentation). About downloading from GitHub and running examples, you find out from the [**How to Run the Examples**](http://docs.aspose.com/svg/net/how-to-run-the-tests) section.
{{% /alert %}} 



