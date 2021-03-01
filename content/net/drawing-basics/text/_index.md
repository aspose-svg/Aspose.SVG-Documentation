---
title: SVG Text
type: docs
weight: 40
aliases: /net/drawing-basics/text
lastmod: "2020-12-15"
description: SVG Text, Fonts and Glyphs, SVG Text Content Elements, Paths and Text,
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

SVG allows making for three types of graphic objects: vector graphic shapes, images and text. For the SVG text elements, in the same way as for the shapes, can be applied coordinate system transformations, clipping and styling. In this chapter, we consider how to bring text into an SVG image. 

 

## **Fonts and Glyphs** 

When talking about text in SVG, good to know what are glyphs, characters and fonts? 

A **glyph** is an elemental graphic unit within an agreed set of units, destined for a font character writing. Referring to the official specification at [**W3.org**](https://dev.w3.org/SVG/profiles/2.0/publish/intro.html):

> "A glyph represents a unit of rendered content within a font. Typically, a glyph is defined by one or more shapes such as a path, possibly with additional information such as rendering hints that help a font engine to produce legible text in small sizes". 

In other words, the glyphs are used as a set of graphic paths (curves) for letters or symbols making. 

A **font** is a block of data (or a file) consisting of descriptions of individual characters in the set used by a program when displaying text. On the other hand, the font represents an organized collection of graphically related glyphs in which the various glyph representations will share a particular appearance or styling that is characterized for a given font. 

Vector fonts use paths, Bézier curves, drawing instructions, and mathematical formulae for each glyph describing, due to which the character outlines can be scaled to any size. 

**Character**  is a digital representation of a letter or symbol. A character may be a control instruction, a renderable mark, or a modifier, i.e. it is an atomic or basic unit of the text. According to the UTF-8 universal character encoding standard, it can take 1 to 4 bytes to represent one character. 

When a computer renders characters, it maps those characters to glyphs in a font. 

In a string, text characters are aligned along an imaginary straight line. This line is called the **baseline**. In general, the baseline can be oriented in different ways. It depends on the language and the displayed characters. In most languages, characters are aligned on an “alphabetical” baseline that runs along the bottom of the characters. 



## **SVG Text Content Elements** 

A text content element is an SVG element that causes text to be rendered on the canvas. The SVG text content elements are: `<text>`, `<tspan>`  and `<textPath>`. 

 

### `<text>` element

The `<text>` element is used to define a text. **x** and **y**  are the main attributes responsible for the text position. The baseline for the text begins from the bottom-left corner of the first text symbol. It is essential to set **y** value larger than the font size. Otherwise, the text does not get into the viewport. 

The following example illustrates how to specify a start of baseline correctly. The  **x** and **y** set the coordinates of the baseline beginning.

```html {linenos=inline,linenostart=1}
<svg height="100" width="200" xmlns="http://www.w3.org/2000/svg">
    <text x="10" y="6" fill="red">The text is not fully visible </text>
    <text x="10" y="30" fill="green">The text is fully visible </text>
</svg>
```
![Text position](text1_1.png#center)


The attributes of the `<text>` and `<tspan>` elements indicate writing direction, alignment, font, and other specifying properties and features that precisely describe how to render characters. The main attributes are: 

**x**, **y**  − the absolute x and y coordinates of characters 

**dx**,  **dy** − shift along the x-axis or y-axis (relative coordinates) 

**rotate** − rotation applied to all characters 

**textlength** − rendering length of the text 

**lengthAdjust** − type of adjustment with the rendered length of the text 

 

The **x**, **y**, **dx**, **dy**, and **rotate** attributes in the `<text>` and `<tspan>` elements are often used for individual characters that require minor position adjustments to achieve a visual effect. In the example, the **x** and **y** set the start coordinates of the baseline.

Using the **textLength** attribute you can set the length of the text. Herewith the text length is then adjusted to match the specified length by adjusting the spacing and the size of the glyphs. With the **lengthAdjust** attribute, you can specify whether to adjust both the letter spacing and the glyph size. 

Let's see how you can arrange the text: 
```html {linenos=inline,linenostart=1}
 <svg height="200" width="800" xmlns="http://www.w3.org/2000/svg">
    <text x="180" y="30" fill="red">Aspose.SVG</text>
    <text x="180" y="60" fill="blue" textLength="140" >Aspose.SVG</text>
    <text x="180" y="90" fill="grey" textLength="160" lengthAdjust="spacingAndGlyphs" style="direction: rtl; unicode-bidi: bidi-override">Aspose.SVG</text>
    <text x="180" y="120" fill="green" style="text-anchor: middle" >Aspose.SVG</text>
    <text x="260" y="90" style="writing-mode: tb">Aspose.SVG</text>
</svg>
```

![Text Aspose](text3.png#center)

"Red" and "green" text differ only in the position of the **text-anchor** property, that can take three values: ***start***, ***middle*** and ***end***. In the first case, the default **text-anchor** is the left edge of the text, the value is ***start***. In the second - `text-anchor: middle` - is the middle of the text. 

The property `direction: rtl` means "right to left", as a result, the "grey" text changes the writing direction. For "blue" and "grey" text setting are used the attributes **textLength** and **lengthAdjust** gives a visual text/character stretching effect.   For the text orientation from top to bottom the `writing-mode: tb` construction is applied, where tb is “top-to-bottom”.

### `<tspan>` element

The `<tspan>` element is within the `<text>` element or other `<tspan>` element. Being a child element, `<tspan>` serves several important functions in text displaying and formatting: 

1. In SVG the text is rendered as a single line inside a viewport; it does not automatically wrap to another string. You may break it into multiple lines using the `<tspan>` element. Each `<tspan>` element can contain different formatting and position. 

2. For styles (or other attributes) setting and applying only to a specific part of the text, you need to use the `<tspan>` element. It allows you to switch the style or position of the displayed text within the `<tspan>` element relative to the parent element. 

Consider a simple `<tspan>`> example: 

```html {linenos=inline,linenostart=1}
 <svg height="300" width="600" xmlns="http://www.w3.org/2000/svg">
    <text x="20" y="60" style="font-family:arial">
        <tspan style="font-weight:bold; font-size:55px">ASPOSE</tspan>
        <tspan x="50" y="90" style="font-size:20px; fill:grey">Your File Format APIs </tspan>
    </text>
</svg>
```
![Text Aspose Your File Format APIs](text2.png#center)
The  `<text>` element with one or more `<tspan>` child elements set new  positions for characters which start new lines. For SVG text formatting, we use **x** and **y** attributes, that specified the text beginning point. The dashed lines in the above figure indicate the starting position of the text in the viewport. For text styling, **style** attribute's properties are required, such as ***font-family***, ***font-size***, ***font-weight*** end other. 



## **Paths and Text** 

In SVG text can be displayed not only horizontally or vertically but along any vector curve. 

### `<textPath>` element

SVG can place text along a path defined by a `<path>` element. This is making by a `<textPath>` element in a few ways:
 - Attribute  **href** (**xlink:href**) references to an URL pointing to the `<path>` element. 
 - Attribute **path** specifies the SVG path data directly. 

Both the **path** attribute and the **href** attribute specify a path along which the characters will be rendered. For the text displaying along the curve, mostly take attribute **href** with reference to the `<path>`element.  Here an example: 

```html {linenos=inline,linenostart=1}
<svg height="300" width="800" xmlns="http://www.w3.org/2000/svg">
    <path id="my_path1" d="M 50 100 Q 25 10 180 100 T 350 100 T 520 100 T 690 100"  fill="transparent" />
    <path id="my_path2" d="M 50 100 Q 25 10 180 100 T 350 100" transform="translate(0,75)" fill="transparent" />
    <text>
        <textPath href ="#my_path1">  Aspose.SVG for .NET is flexible library for SVG files processing and fully compatible with its specifications. 
        </textPath>
        <textPath href ="#my_path2">  Aspose.SVG for .NET is flexible library for SVG files processing and fully compatible with its specifications. 
        </textPath>
    </text>
</svg>
```
![SVG text in path](text_path.png#center)


If the length of the path is shorter than the text size, then only text part that is within the extent of the path is drawn. In the figure, the second curve is shorter than the text length, so text breaks off at the path end.

The text can be styled using [**CSS properties**](https://www.w3.org/TR/2018/CR-SVG2-20181004/text.html#TextDecorationProperties) like ***font-weight***, ***font-style***, ***text-decoration***, ***text-transform***, etc. It can be decorated with an underline, overline, and strike-through. Like other SVG shapes, text can have both a stroke and fill set on it. You may read more about how to style the text in the section [**SVG Filters and Gradients**](/svg/net/drawing-basics/filters-and-gradients/). 

