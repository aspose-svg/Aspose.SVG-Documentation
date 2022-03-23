---
title: SVG Color | How to work with Fill Color and Stroke Color?
linktitle: SVG Color
type: docs
weight: 65
lastmod: 2022-03-24
description:  In this article, we will look at ways to apply colors in SVG files and how to work with fill and stroke color.
keywords: svg color, color code, color names, line color, circle color, svg circle color, fill color, stroke color
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

Scalable Vector Graphics (SVG) is an XML language for creating 2D vector and mixed vector/raster graphics. The use of vector graphics is one of the most popular web design trends in recent years. SVG allows developers and designers to create vector images built using points, lines, paths, and shapes. It is best used to create logos, icons, simple graphics and animations. SVG images are resolution independent and can be created and edited with any text editor.

Using color is an important part of creating SVG. You can colorize SVG shapes, lines, paths, text. SVG graphics can be colorized, textured, shaded, or built from partially-transparent overlapping layers. This article takes an in-depth look at the different ways SVG text and shapes can be colorized. You’ll find out an overview of how color is defined, including the various ways you can control the transparency of SVG content.

{{% alert color="primary" %}} 
If you have an image that is not an SVG like a JPG or PNG file, you can convert the file into a vector and save it as an SVG using a free online [**Image Vectorizer**](https://products.aspose.app/svg/image-vectorization). The App is browser-based and works on any platform. Check our Image Vectorizer to get all the benefits of vector graphics!
{{% /alert %}} 

<a href="https://products.aspose.app/svg/image-vectorization" target="_blank">![Text "Banner Image Vectorizer"](image-vectorizer.png#center)</a>



## **SVG Color Specifying**

Colorization or painting means the operation of adding color, gradients or patterns to SVG graphics using **fill** and **stroke**.  Filling and stroking are both painting operations. The SVG stroke and SVG fill are some of the main CSS properties that can be set for any lines, text and shapes. In an SVG file, they can be specified both in the **style** attribute (`fill` and `stroke` properties) and using **fill** and **stroke** attributes as [presentation attributes](https://www.w3.org/TR/2018/CR-SVG2-20181004/styling.html#TermPresentationAttribute).

So you can set color for SVG elements in two ways: using fill and stroke properties of the **style** attribute and using **fill** and **stroke** attributes

### **Fill and Stroke Properties of the Style Attribute**

SVG fill and SVG stroke features can be set in the **style** attribute. The syntax for properties specifying is: 

`style="stroke-width:2; stroke:green; fill:#ff0000"`

### **Fill and Stroke attributes**

SVG fills and SVG strokes can be given in the presentation **fill** and **stroke** attributes with such the syntax:

`stroke-width="2" stroke="green" fill="#ff0000`

### **SVG Color Codes**

To specify an SVG color, you can take color names, RGB or RGBA values, HEX values, HSL or HSLA values, and opacity. The following examples will use different ways to set fill and stroke characteristics, let's consider them: 

1. **SVG Color Names**. There are the [147 color names](https://www.w3.org/TR/SVG11/types.html#ColorKeywords) defined by the Scalable Vector Graphics (SVG) Specification. You may set  named colors like this: `stroke="Green"` or `fill="Red"`.

2. **HEX Color Codes**. The code is expressed as follows: #RRGGBB, where each of the two-digit values is a range of each of the three colors (red, green, blue), with which you select the final value representing each color. Each two-digit hex pair can have a value from 00 to FF. For example, #00FF00 is displayed as green, because the green component is set to its maximum value (FF) and the others are set to 00. 

   You can set the green and red HEX colors like this: `stroke="#00FF00"` or `fill="#FF0000"`.

3.  **RGB(Red, Blue, Green) Color Codes**. The values R, G and B are the intensity (in the range from 0 to 255), respectively, of the red, green and blue components of the determined color. You can set the green and red RGB colors like this: `stroke="rgb(0,255,0)"` or `fill="rgb(255,0,0)"`.

4. **RGBA(Red, Blue, Green, Alpha) Color Codes**. RGBA color values are an extension of RGB color values with an alpha channel that determines the opacity of the color. The alpha parameter is a number between 0.0 and 1.0 that specifies transparency. You may determine the green and red RGB colors like this: `stroke="rgba(0,255,0,1.0)"` or `fill="rgba(255,0,0,1.0)"`.

5. **HSL Color Codes**. HSL stands for Hue, Saturation and Lightness. Each color has an angle on the RGB color wheel and a percentage value for the saturation and lightness values. HSL codes for green and red colors you can set like this: `stroke="hsl(120, 100%, 50%)"` and `fill="hsl(0, 100%, 50%)"` 

6. **HSLA(Hue, Saturation, Lightness, Alpha) Color Codes**. HSLA color values are an extension of HSL color values with an alpha channel that determines the opacity of the color. HSL codes for green and red colors you can set like this: `stroke="hsl(120, 100%, 50%, 1.0)"` and `fill="hsl(0, 100%, 50%, 1.0)"` 

## **Color  Shapes**

The fill is the color inside a shape, and the stroke is the visible outline of an object. You can fill a shape with one color and stroke it with another. If you create an SVG shape but don't set the fill color, the shape will be colored in black. If you set a stroke-width attribute but don't set stroke color, the stroke will not be visible.

### **Color Circle**

   The sample below illustrates the presents and lacking `fill= "none"` property ([two-paths.svg](/svg/net/drawing-basics/fills-and-strokes/two-paths.svg)):

```html {linenos=inline,linenostart=1}
<svg height="200" width="600" xmlns="http://www.w3.org/2000/svg">
    <circle cx="70" cy="70" r="50" />
    <circle cx="200" cy="70" r="50" fill="red" />
    <circle cx="330" cy="70" r="50" fill="red" stroke="green" stroke-width="3" />
    <circle cx="460" cy="70" r="50" fill="red" stroke-width="3" /> 
</svg>
```

![Four colored circles](color-circle.png#center)

### **Color Line**

The sample below illustrates the presents and lacking `fill= "none"` property ([two-paths.svg](/svg/net/drawing-basics/fills-and-strokes/two-paths.svg)):

```html {linenos=inline,linenostart=1}
<svg height="400" width="700" xmlns="http://www.w3.org/2000/svg">
    <line x1="30" y1="30" x2="30" y2="300" style="stroke:#4387be;stroke-width:10" />
    <line x1="55" y1="27" x2="130" y2="300" style="stroke:#c4456d;stroke-width:10" />
    <line x1="80" y1="20" x2="250" y2="300" style="stroke:#77bec1;stroke-width:10" />
    <polyline points="300,100 360,50 420,100 480,50 540,100 600,50 660,100" style="fill:none; stroke:#fb6796; stroke-width:5" />
    <polyline points="300,200 360,150 420,200 480,150 540,200 600,150 660,200" style="fill:#c9d7e1; stroke:#fb6796; stroke-width:5" />  
    <polyline points="300,300 360,250 420,300 480,250 540,300 600,250 660,300" style="stroke:#fb6796; stroke-width:5" />
</svg>
```

![Two SVG paths: unfilled and filled](color-line.png#center)

### **Color Circle**

The sample below illustrates the presents and lacking `fill= "none"` property ([two-paths.svg](/svg/net/drawing-basics/fills-and-strokes/two-paths.svg)):

```html {linenos=inline,linenostart=1}
<svg height="400" width="800" xmlns="http://www.w3.org/2000/svg">
    <path d="M 10 100 Q 25 10 180 100 T 250 100 T 300 100 T 390 130" stroke="red" stroke-width="3" fill="none" />
    <path d="M 10 100 Q 25 10 180 100 T 250 100 T 300 100 T 390 130" stroke="red" stroke-width="3" transform="translate(0 125)" />
</svg>
```

![Two SVG paths: unfilled and filled](two_paths.png#center)

## Color Paths

The **fill** attribute colors the interior of a graphic element. When you fill an SVG shape or curve, the **fill** colourizes open paths too as if the last its point was connected to the first, even though the **stroke** color in that part of the path will not appear. If the **fill** attribute property is not specified, the default is black.

So that there is no filling, you need to specify the attribute value `fill= "none"` or `fill= "transparent"`.

The sample below illustrates the presents and lacking `fill= "none"` property ([two-paths.svg](/svg/net/drawing-basics/fills-and-strokes/two-paths.svg)):

```html {linenos=inline,linenostart=1}
<svg height="400" width="800" xmlns="http://www.w3.org/2000/svg">
    <path d="M 10 100 Q 25 10 180 100 T 250 100 T 300 100 T 390 130" stroke="red" stroke-width="3" fill="none" />
    <path d="M 10 100 Q 25 10 180 100 T 250 100 T 300 100 T 390 130" stroke="red" stroke-width="3" transform="translate(0 125)" />
</svg>
```

![Two SVG paths: unfilled and filled](two_paths.png#center)

## Color Text

Like other SVG shapes, text can have both a stroke and fill set on it. You may read more about how to style the text in the section [**SVG Filters and Gradients**](https://docs.aspose.com/svg/net/drawing-basics/filters-and-gradients/).

```html {linenos=inline,linenostart=1}
<svg height="400" width="800" xmlns="http://www.w3.org/2000/svg">
    <path d="M 10 100 Q 25 10 180 100 T 250 100 T 300 100 T 390 130" stroke="red" stroke-width="3" fill="none" />
    <path d="M 10 100 Q 25 10 180 100 T 250 100 T 300 100 T 390 130" stroke="red" stroke-width="3" transform="translate(0 125)" />
</svg>
```

![Two SVG paths: unfilled and filled](two_paths.png#center)

## **Opacity**

You can specify the opacity of either the fill or stroke separately in SVG. These are controlled by the fill-opacity and stroke-opacity attributes. Also, you can use RGBA values that are allowed in SVG and will give the same effect. 

For more information on **style** attributes' properties, please see the article [**Fills and Strokes in SVG**](https://docs.aspose.com/svg/net/drawing-basics/fills-and-strokes/). Full information is on the **[W3C page](https://www.w3.org/TR/2018/CR-SVG2-20181004/painting.html#FillProperties)**.



{{% alert color="primary" %}}
Aspose.SVG offers [**SVG Free Web Applications**](https://products.aspose.app/svg/applications) for converting SVG or image files, image vectorizing, SVG sprite generating, SVG and bitmaps encoding, and text vectorizing. These online Apps work on any operating system with a web browser and don't require additional software installation. It's a fast and easy way to efficiently and effectively solve your SVG-related tasks!
{{% /alert %}} 

