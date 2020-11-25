---
title: Embedded Content
type: docs
weight: 7
url: /net/drawing-basics/embedded-content
description: Embedded Content, Loading and Displaying Bitmaps, HTML Elements in an SVG Document
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />


Embedded content is content that imports into the document from another resource. SVG `<image>` and `<foreignObject>` elements are used for embedded content support.

 
## **Loading and Displaying Bitmaps**

The SVG `<image>` element allows to include and render bitmaps within an SVG object. It can display image formats JPEG, PNG and the SVG pictures too. Attributes of the `<image>` element indicate that the contents of a file (a bitmap) should be displayed into a given rectangle ("window") within the current user coordinate system. 
The  main attributes are:

**x** and **y** - the coordinates of the top-left image corner.

**width** and **height** - the width and the height of the "window" for image render.  These attributes are required.

**href** and **xlink:href** - points at a URL for the image file.

**preserveAspectRatio** - controls how the image is scaled.

How to use the SVG `<image>` element?  The following code snippet shows as a .png and .svg images can embed inside the SVG document:
```html {linenos=inline,linenostart=1}
<svg width="500" height="400" xlink="http://www.w3.org/2000/svg">
    <image href="https://www.aspose.cloud/templates/aspose/App_Themes/V3/images/svg/272x272/aspose_svg-for-net.png" x="20" y="20" height="180" width="180" />
    <image href="http://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/navigation-inspection/shapes.svg" x="250" y="10" height="350" width="350" />
    <text x="40" y="250">Embedded PNG image</text>
    <text x="300" y="250">Embedded SVG image</text>
</svg>
```
The above code snippet is displayed like this:
![Two images](embedded-images.png#center)

## **HTML Elements in an SVG Document** 

 

SVG is designed to be consistent with other XML languages for describing and rendering of embedded content. The `<foreignObject>` element allows to include in SVG file the elements in a non-SVG namespace. In the context of a browser, it is most likely HTML. The foreign graphical content can be processed with transformations, filters, clipping, masking and compositing.

As attributes, you must to set the **x**, **y** coordinates, **width** and **height** of the `<foreignObject>` container. Otherwise, the child elements will not display at all.

Let's see an example:
```html {linenos=inline,linenostart=1 hl_lines=["12"]}
<svg viewBox="0 0 300 300" xmlns="http://www.w3.org/2000/svg">
    <style>
        div {
            color: grey;
            font: 14px serif;
            }
    </style>
    <circle cx="65" cy="60" r="60" fill="red" fill-opacity="0.1" />
    <!-- example of  HTML text embedding in SVG -->
    <foreignObject x="20" y="20" width="200" height="180">
    <!--In the context of HTML embedded in the SVG document, the XHTML namespace is mandatory-->
        <div xmlns="http://www.w3.org/1999/xhtml">
        Convert SVG to PNG. Aspose.SVG for .NET can read and convert SVG files to PNG, PDF, XPS, and major image formats. 
        </div>
    </foreignObject>
</svg>
```

![Text](embedded_HTML.png#center)

Using the `<foreignObject>` inside SVG, you need to specify the namespace from which the foreign object originates. In this example, it sets in line 12:

 `<div xmlns="http://www.w3.org/1999/xhtml">`

