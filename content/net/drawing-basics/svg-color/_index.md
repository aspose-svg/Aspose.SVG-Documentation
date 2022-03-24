---
title: SVG Color | How to work with Fill Color and Stroke Color?
linktitle: SVG Color
type: docs
weight: 65
lastmod: 2022-03-24
description:  In this article, we will look at ways to apply colors in SVG files and how to work with fill color, stroke color and opacity.
keywords: svg color, color code, color names, line color, circle color, text color, path color, svg circle color, fill color, stroke color, opacity
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

So you can set color for SVG elements in two ways: using fill and stroke properties of the **style** attribute and using **fill** and **stroke** attributes. For more information, please see the [W3C page](https://www.w3.org/TR/2018/CR-SVG2-20181004/painting.html#FillProperties).

### **Fill and Stroke Properties of the Style Attribute**

SVG fill and SVG stroke features can be set in the **style** attribute. The syntax for properties specifying is: 

`style="stroke-width:2; stroke:green; fill:#ff0000"`

### **Fill and Stroke attributes**

SVG fills and SVG strokes can be given in the presentation **fill** and **stroke** attributes with such the syntax:

`stroke-width="2" stroke="green" fill="#ff0000`

### **SVG Color Codes**

To specify an SVG color, you can take color names, RGB or RGBA values, HEX values, HSL or HSLA values. The following examples will use different ways to set fill and stroke characteristics, let's consider them: 

1. **SVG Color Names**. There are the [147 color names](https://www.w3.org/TR/SVG11/types.html#ColorKeywords) defined by the Scalable Vector Graphics (SVG) Specification. You may set  named colors like this: `stroke="Green"` or `fill="Red"`.

2. **HEX Color Codes**. The code is expressed as follows: #RRGGBB, where each of the two-digit values is a range of each of the three colors (red, green, blue), with which you select the final value representing each color. Each two-digit hex pair can have a value from 00 to FF. For example, #00FF00 is displayed as green, because the green component is set to its maximum value (FF) and the others are set to 00. 

   You can set the green and red HEX colors like this: `stroke="#00FF00"` or `fill="#FF0000"`.

3.  **RGB(Red, Blue, Green) Color Codes**. The values R, G and B are the intensity (in the range from 0 to 255), respectively, of the red, green and blue components of the determined color. You can set the green and red RGB colors like this: `stroke="rgb(0,255,0)"` or `fill="rgb(255,0,0)"`.

4. **RGBA(Red, Blue, Green, Alpha) Color Codes**. RGBA color values are an extension of RGB color values with an alpha channel that determines the opacity of the color. The alpha parameter is a number between 0.0 and 1.0 that specifies transparency. You may determine the green and red RGB colors like this: `stroke="rgba(0,255,0,1.0)"` or `fill="rgba(255,0,0,1.0)"`.

5. **HSL Color Codes**. HSL stands for Hue, Saturation and Lightness. Each color has an angle on the RGB color wheel and a percentage value for the saturation and lightness values. HSL codes for green and red colors you can set like this: `stroke="hsl(120, 100%, 50%)"` and `fill="hsl(0, 100%, 50%)"` 

6. **HSLA(Hue, Saturation, Lightness, Alpha) Color Codes**. HSLA color values are an extension of HSL color values with an alpha channel that determines the opacity of the color. HSL codes for green and red colors you can set like this: `stroke="hsl(120, 100%, 50%, 1.0)"` and `fill="hsl(0, 100%, 50%, 1.0)"` 

### **Color Specifying Rules**

Some of the rules of color specifying are: 

- If the **fill** attribute (or `fill` property of the **style** attribute) is not specified, the default is black.

- If the **fill** attribute (or `fill` property of the **style** attribute) has `none` or `transparent` value, the shapes filling is transparent.

- If the **stroke** attribute (or `stroke` property of the **style** attribute) is not specified, the stroke is invisible, is absent. This remains true even if the **stroke-width** attribute is specified.

- To specify fill color or stroke color, you can use color names, RGB or RGBA values, HEX values, HSL or HSLA values. Also, you can take gradients and patterns (see the [Text Color](/svg/net/drawing-basics/svg-color/#text-color) section or the [SVG Filters and Gradients](/svg/net/drawing-basics/filters-and-gradients/#linear-gradient-in-svg) article).

## **Color  Shapes**

The fill is the color inside a shape, and the stroke is the visible outline of an object. You can fill a shape with one color and stroke it with another. If you create an SVG shape but don't set the fill color, the shape will be colored in black. If you set a stroke-width attribute but don't set stroke color, the stroke will not be visible.

**Note**: Fill and stroke are available for such SVG shapes like circle, ellipse, rectangle, polyline, and polygon. For an SVG line, only stroke is allowed.

### **Circle Color**

 In the following example, we consider the fill color and stroke color applying for SVG circle. **Note**: The code snippet can be used similarly for SVG ellipse, rectangle, polyline, and polygon.

```html {linenos=inline,linenostart=1}
<svg height="200" width="600" xmlns="http://www.w3.org/2000/svg">
    <circle cx="70" cy="70" r="50" />
    <circle cx="200" cy="70" r="50" fill="#79C99E" />
    <circle cx="330" cy="70" r="50" fill="#79C99E" stroke-width="10" stroke="#508484" />
    <circle cx="460" cy="70" r="50" fill="#79C99E" stroke-width="10" /> 
    <circle cx="590" cy="70" r="50" fill="none" stroke-width="10" stroke="#508484" />
</svg>
```

The figure illustrates the code snippet above:

![Four colored circles](color-circle.png#center)

### **Color Line and Color Polyline**

In the following example, we consider the fill and stroke applying for SVG line and SVG polyline. **Note**: The code snippet uses setting color fill and color stroke with `fill` and `stroke` properties of the **style** attribute:

```html {linenos=inline,linenostart=1}
<svg height="400" width="700" xmlns="http://www.w3.org/2000/svg">
    <line x1="30" y1="30" x2="30" y2="300" style="stroke:#4387be; stroke-width:10" />
    <line x1="55" y1="27" x2="130" y2="300" style="stroke:#c4456d; stroke-width:10" />
    <line x1="80" y1="20" x2="250" y2="300" style="stroke:#77bec1; stroke-width:10" />
    <polyline points="300,100 360,50 420,100 480,50 540,100 600,50 660,100" style="fill:none; stroke:#fb6796; stroke-width:5" />
    <polyline points="300,200 360,150 420,200 480,150 540,200 600,150 660,200" style="fill:#c9d7e1; stroke:#fb6796; stroke-width:5" />  
    <polyline points="300,300 360,250 420,300 480,250 540,300 600,250 660,300" style="stroke:#fb6796; stroke-width:5" />
</svg>
```

![Three SVG lines and three SVG polylines (unfilled and filled)](color-line.png#center)

### **Color Polyline and Color Polygon**

The following example illustrates the similarities and differences in applying fill color and stroke color to an SVG polyline and an SVG polygon:

```html {linenos=inline,linenostart=1}
<svg height="400" width="500" xmlns="http://www.w3.org/2000/svg">
    <polyline points="60,290 130,20 200,290" style="fill:#86a9b9; stroke-width:5; stroke:#fb6796" />
    <polygon points="260,290 330,20 400,290" style="fill:#86a9b9; stroke-width:5; stroke:#fb6796" />
</svg>
```

As the polyline is an open line, no stroke color will appear on that part of the shape. Because the polygon is a closed line, the stroke color is around the entire perimeter of the shape.

![SVG polyline and SVG polygon with fill and stroke](color-shapes.png#center)

## **Path Color**

For an SVG `<path>` element, you can use both a color stroke and a color fill. The **fill** attribute colors the interior of a graphic element. When you fill an SVG path, the **fill** colourizes open paths too as if the last its point was connected to the first, even though the **stroke** color in that part of the path will not appear. If the **fill** attribute value is not specified, the default is black.

So that there is no filling, you need to specify the attribute value `fill= "none"` or `fill= "transparent"`. In the following code example, we will show how fill and stroke can be used with a `<path>` element:

```html {linenos=inline,linenostart=1}
<svg height="400" width="600" xmlns="http://www.w3.org/2000/svg">
    <path stroke="#a06e84" stroke-width="3" fill="none" d="  
	M 150,50 L 150, 300
	M 120,100 L 150,50 L 180, 100
    M 110,150 L 150,90 L 190, 150
	M 90,220 L 150,130 L 210, 220
	M 70,300 L 150,190 L 230, 300
    M 110,310 L 150,240 L 190, 310
	" />
    <path stroke="#a06e84" stroke-width="3" fill="#74aeaf" transform="translate(200)" d="  
	M 150,50 L 150, 300
	M 120,100 L 150,50 L 180, 100
    M 110,150 L 150,90 L 190, 150
	M 90,220 L 150,130 L 210, 220
	M 70,300 L 150,190 L 230, 300
    M 110,310 L 150,240 L 190, 310
	" /> 
</svg>
```

The figure below illustrates how the values `fill = "none"` and `fill = "#74aeaf"` are displayed:

![Two SVG paths: unfilled and filled](color-paths.png#center)

## **Text Color**

Like other SVG shapes, text can have both a stroke and fill set on it. In this code example, we will look at how you can set the fill color and stroke color of text and use a gradient as a fill. As with all SVG shapes, if the **fill** attribute is not specified, the text will be displayed in black by default:

```html {linenos=inline,linenostart=1}
<svg height="300" width="600" xmlns="http://www.w3.org/2000/svg">
    <defs>
		<linearGradient id="grad1" x1="0%" y1="0%" x2="100%" y2="0%">
			<stop offset="10%" style="stop-color:lightsalmon" />
			<stop offset="50%" style="stop-color:teal" />
			<stop offset="90%" style="stop-color:lightpink" />
		</linearGradient>
    </defs>
    <text x="50" y="50" font-family="arial" font-size="40" >How to add SVG text color?</text>
    <text x="50" y="130" font-family="arial" font-size="40" fill="lightpink" stroke="teal" stroke-width="1" >How to add SVG text color?</text>
    <text x="50" y="210" font-family="arial" font-size="40" fill="none" stroke="teal" stroke-width="1" >How to add SVG text color?</text>
    <text x="50" y="290" font-family="arial" font-size="40" fill="url(#grad1)" stroke="teal" stroke-width="1" >How to add SVG text color?</text>
</svg>
```

The figure shows the different cases of fill and stroke applying to add text color:

![Two SVG paths: unfilled and filled](color-text.png#center)

You may read more about how to style the text in articles  [**Fills and Strokes in SVG**](https://docs.aspose.com/svg/net/drawing-basics/fills-and-strokes/) and [**SVG Filters and Gradients**](https://docs.aspose.com/svg/net/drawing-basics/filters-and-gradients/).

## **Opacity**

You can specify the opacity of either the fill or stroke separately in SVG. These are controlled by the **fill-opacity** and **stroke-opacity** attributes. Also, you can use RGBA or HSLA values that are allowed in SVG and will give the same effect:

- **RGBA** color values have an alpha channel that determines the opacity of the color. The alpha parameter is a number between 0.0, meaning “fully transparent”, and 1.0, meaning “fully opaque”. For example, rgba(255, 0, 0, 0.5) is displayed as red with 50% opacity. 
- **HSLA** color values are specified with hue, saturation, lightness, and alpha, where an alpha parameter specifies the opacity. As in RGBA color codes, the alpha parameter is between 0.0  and 1.0. For example, hsla(0, 100%, 50%, 1) is displayed as pure red, hsla(0, 100%, 50%, 0.5) is displayed as red with 50% opacity.

Let's look at an example of how to set the opacity of the fill color of the shapes. In the following code snippet, we specify different opacity values to fill the rectangle with rgb(0,50,255) blue using **RGBA** color codes (Figure a); for red hsl(0,100%,50%)- using the **HSLA** color codes (Figure b) and for the color HEX #C1B900 - using the **fill-opacity** attribute (Figure c).

```html {linenos=inline,linenostart=1}
<svg height="200" width="1250" xmlns="http://www.w3.org/2000/svg">
    <rect x="310" y="30"  width="100" height="100" fill="rgba(0,50,255,0.8)" />
   	<rect x="250" y="50"  width="110" height="100" fill="rgba(0,50,255,0.7)" />
   	<rect x="170" y="90"  width="110" height="100" fill="rgba(0,50,255,0.6)" />   
    <rect x="100" y="50"  width="110" height="100" fill="rgba(0,50,255,0.4)" />
    <rect x="50" y="30"  width="110" height="100" fill="rgba(0,50,255,0.2)" />
    
    <rect x="710" y="30"  width="100" height="100" fill="hsla(0,100%,50%,0.8)" />
   	<rect x="650" y="50"  width="110" height="100" fill="hsla(0,100%,50%,0.7)" />
   	<rect x="570" y="90"  width="110" height="100" fill="hsla(0,100%,50%,0.6)" />   
    <rect x="500" y="50"  width="110" height="100" fill="hsla(0,100%,50%,0.4)" />
    <rect x="450" y="30"  width="110" height="100" fill="hsla(0,100%,50%,0.2)" />
    
    <rect x="1110" y="30" width="100" height="100" fill="#C1B900" fill-opacity="0.8" />
   	<rect x="1050" y="50" width="110" height="100" fill="#C1B900" fill-opacity="0.7" />
   	<rect x="970" y="90" width="110" height="100" fill="#C1B900" fill-opacity="0.6" />   
    <rect x="900" y="50" width="110" height="100" fill="#C1B900" fill-opacity="0.4" />
    <rect x="850" y="30" width="110" height="100" fill="#C1B900" fill-opacity="0.2" />    
</svg>
```

![Three sets of colored rectangles with different values of opacity](opacity.png#center)

{{% alert color="primary" %}}
Aspose.SVG offers [**SVG Free Web Applications**](https://products.aspose.app/svg/applications) for converting SVG or image files, image vectorizing, SVG sprite generating, SVG and bitmaps encoding, and text vectorizing. These online Apps work on any operating system with a web browser and don't require additional software installation. It's a fast and easy way to efficiently and effectively solve your SVG-related tasks!
{{% /alert %}} 

