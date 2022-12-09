---
title: SVG Color | How to work with Fill Color and Stroke Color?
linktitle: SVG Color
type: docs
weight: 65
lastmod: 2022-07-27
description:  In this article, we will look at ways to apply colors in SVG files and how to work with fill color, stroke color and opacity.
keywords: svg color, color code, color names, line color, circle color, text color, path color, svg circle color, fill color, stroke color, opacity, color converter, color mixer, convert color, mix colors
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

Scalable Vector Graphics (SVG) is an XML language for creating 2D vector and mixed vector/raster graphics. The use of vector graphics is one of the most popular web design trends in recent years. SVG allows developers and designers to create vector images built using points, lines, paths, and shapes. It is best used to create logos, icons, simple graphics and animations. SVG images are resolution independent and can be created and edited with any text editor.

Using color is an important part of creating SVG. You can colorize SVG shapes, lines, paths, text. SVG graphics can be colorized, textured, shaded, or built from partially-transparent overlapping layers. This article takes an in-depth look at the different ways SVG text and shapes can be colorized. You’ll find out an overview of how color is defined, including the various ways you can control the transparency of SVG content.

{{% alert color="primary" %}} 

How to work with SVG color using the Aspose.SVG library for .NET and how to change the color of SVG elements or the background color in SVG files, we covered in detail with C# examples in the article [**How to change SVG color**](https://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/how-to-change-svg-color/).

{{% /alert %}} 

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

To specify an SVG color, you can take Color Names, RGB or RGBA values, HEX values, HSL or HSLA values. The following examples will use different ways to set fill and stroke characteristics, let's consider them: 

1. **SVG Color Names**. There are the [147 color names](https://www.w3.org/TR/SVG11/types.html#ColorKeywords) defined by the Scalable Vector Graphics (SVG) Specification. You may set  named colors like this: `stroke="Green"` or `fill="Red"`.

2. **HEX Color Codes**. The code is expressed as follows: #RRGGBB, where each of the two-digit values is a range of each of the three colors (red, green, blue), with which you select the final value representing each color. Each two-digit hex pair can have a value from 00 to FF. For example, #00FF00 is displayed as green, because the green component is set to its maximum value (FF) and the others are set to 00. 

   You can set the green and red HEX colors like this: `stroke="#00FF00"` or `fill="#FF0000"`.

3. **RGB(Red, Blue, Green) Color Codes**. The values R, G and B are the intensity (in the range from 0 to 255), respectively, of the red, green and blue components of the determined color. You can set the green and red RGB colors like this: `stroke="rgb(0,255,0)"` or `fill="rgb(255,0,0)"`.

4. **RGBA(Red, Blue, Green, Alpha) Color Codes**. RGBA color values are an extension of RGB color values with an alpha channel that determines the opacity of the color. The alpha parameter is a number between 0.0 and 1.0 that specifies transparency. You may determine the green and red RGB colors like this: `stroke="rgba(0,255,0,1.0)"` or `fill="rgba(255,0,0,1.0)"`.

5. **HSL Color Codes**. HSL stands for Hue, Saturation and Lightness. Each color has an angle on the RGB color wheel and a percentage value for the saturation and lightness values. HSL codes for green and red colors you can set like this: `stroke="hsl(120, 100%, 50%)"` and `fill="hsl(0, 100%, 50%)"` 

6. **HSLA(Hue, Saturation, Lightness, Alpha) Color Codes**. HSLA color values are an extension of HSL color values with an alpha channel that determines the opacity of the color. HSL codes for green and red colors you can set like this: `stroke="hsla(120, 100%, 50%, 1.0)"` and `fill="hsla(0, 100%, 50%, 1.0)"` 

## **Online Color Converter**

For different tasks, different color codes are preferred. So, sometimes you may need to convert color codes. Click inside the color area to select a color, or enter a color code in the Input text box. You will immediately see other color codes for chosen color in the Output section. Use our free Online Color Converter and get the result at once! 

{{< app/svg/color input="RGB" output="HEX">}}

{{< /app/svg/color>}}

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
<div>
<svg viewBox="-30  0 1000 340" xmlns="http://www.w3.org/2000/svg">
<defs>
    <marker id="arrowhead" markerWidth="10" markerHeight="7" 
    refX="0" refY="3.5" orient="auto">
      <polygon points="0 0, 10 3.5, 0 7" stroke="#111" fill="#eee" />
    </marker>
  </defs>
<text x="25" y="30" font-size="30">SVG Lines</text>
<text x="385" y="30"  font-size="30">SVG Polylines</text>
<g transform="translate(0 40)">
    <line x1="30" y1="30" x2="30" y2="300" style="stroke:#4387be; stroke-width:10" />
    <line x1="55" y1="27" x2="130" y2="300" style="stroke:#c4456d; stroke-width:10" />
    <line x1="80" y1="20" x2="250" y2="300" style="stroke:#77bec1; stroke-width:10" />
    <polyline points="300,100 360,50 420,100 480,50 540,100 600,50 660,100" style="fill:none; stroke:#fb6796; stroke-width:5" />
    <polyline points="300,200 360,150 420,200 480,150 540,200 600,150 660,200" style="fill:#c9d7e1; stroke:#fb6796; stroke-width:5" />  
    <polyline points="300,300 360,250 420,300 480,250 540,300 600,250 660,300" style="stroke:#fb6796; stroke-width:5" />
    <line x1="730" y1="80" x2="620" y2="80" stroke="#aaa" stroke-width="2" marker-end="url(#arrowhead)" />
    <text x="735" y="85" font-size="17px">fill:none</text>
    <line x1="730" y1="180" x2="620" y2="180" stroke="#aaa" stroke-width="2" marker-end="url(#arrowhead)" />
    <text x="735" y="185" font-size="17px">fill:c9d7e1</text>
    <line x1="730" y1="280" x2="620" y2="280" stroke="#aaa" stroke-width="2" marker-end="url(#arrowhead)" />
    <text x="735" y="285" font-size="17px">The fill is not specified</text>
    </g>
</svg>
</div>

### **Color Polyline and Color Polygon**

The following example illustrates the similarities and differences in applying fill color and stroke color to an SVG polyline and an SVG polygon:

```html {linenos=inline,linenostart=1}
<svg viewBox="-100  0 800 340" xmlns="http://www.w3.org/2000/svg">
    <polyline points="60,290 130,20 200,290" style="fill:#86a9b9; stroke-width:5; stroke:#fb6796" />
    <polygon points="260,290 330,20 400,290" style="fill:#86a9b9; stroke-width:5; stroke:#fb6796" />
</svg>
```

As the polyline is an open line, no stroke color will appear on that part of the shape. Because the polygon is a closed line, the stroke color is around the entire perimeter of the shape.

<div>
<svg viewBox="-100  0 800 340" xmlns="http://www.w3.org/2000/svg">
<text x="85" y="20" font-weight="bold">SVG Polyline</text>
<text x="285" y="20" font-weight="bold">SVG Polygon</text>
<g transform="translate(0 30)">
    <polyline points="60,290 130,20 200,290" style="fill:#86a9b9; stroke-width:5; stroke:#fb6796" />
    <text x="-30" y="150">no stroke color</text>
    <line x1="0" y1="152" x2="120" y2="275" stroke="#000" stroke-width="2" marker-end="url(#arrowhead)" />
    <polygon  points="260,290 330,20 400,290" style="fill:#86a9b9; stroke-width:5; stroke:#fb6796" />
    <text x="400" y="150">stroke color is around</text>
    <text x="407" y="170">the entire perimeter</text>
    </g>
</svg>
</div>

## **Path Color**

For an SVG `<path>` element, you can use both a color stroke and a color fill. The **fill** attribute colors the interior of a graphic element. When you fill an SVG path, the **fill** colourizes open paths too as if the last its point was connected to the first, even though the **stroke** color in that part of the path will not appear. If the **fill** attribute value is not specified, the default is black.

So that there is no filling, you need to specify the attribute value `fill= "none"` or `fill= "transparent"`. In the following code example, we will show how fill and stroke can be used with a `<path>` element:

```html {linenos=inline,linenostart=1}
<svg height="350" width="600" xmlns="http://www.w3.org/2000/svg">
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

<div>
<svg height="350" width="600" xmlns="http://www.w3.org/2000/svg">
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
</div>

## **Text Color**

Like other SVG shapes, text can have both a stroke and fill set on it. In this code example, we will look at how you can set the fill color and stroke color of text and use a gradient as a fill. As with all SVG shapes, if the **fill** attribute is not specified, the text will be displayed in black by default:

```html {linenos=inline,linenostart=1}
<svg height="330" width="600" xmlns="http://www.w3.org/2000/svg">
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

<div>
<svg height="330" width="600" xmlns="http://www.w3.org/2000/svg">
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
</div>

You may read more about how to style the text in articles  [**Fills and Strokes in SVG**](https://docs.aspose.com/svg/net/drawing-basics/fills-and-strokes/) and [**SVG Filters and Gradients**](https://docs.aspose.com/svg/net/drawing-basics/filters-and-gradients/).

{{% alert color="primary" %}}
Aspose.SVG offers [**SVG Free Web Applications**](https://products.aspose.app/svg/applications) for converting SVG or image files, image vectorizing, SVG sprite generating, SVG and bitmaps encoding, text vectorizing, and color codes manipulating. These online Apps work on any operating system with a web browser and don't require additional software installation. It's a fast and easy way to efficiently and effectively solve your SVG-related tasks!
{{% /alert %}} 

## **Opacity**

You can specify the opacity of either the fill or stroke separately in SVG. These are controlled by the **fill-opacity** and **stroke-opacity** attributes. Also, you can use RGBA or HSLA values that are allowed in SVG and will give the same effect:

- **RGBA** color values have an alpha channel that determines the opacity of the color. The alpha parameter is a number between 0.0, meaning “fully transparent”, and 1.0, meaning “fully opaque”. For example, rgba(255, 0, 0, 0.5) is displayed as red with 50% opacity. 
- **HSLA** color values are specified with hue, saturation, lightness, and alpha, where an alpha parameter specifies the opacity. As in RGBA color codes, the alpha parameter is between 0.0  and 1.0. For example, hsla(0, 100%, 50%, 1) is displayed as pure red, hsla(0, 100%, 50%, 0.5) is displayed as red with 50% opacity.

Let's look at an example of how to set the opacity of the fill color of the shapes. In the following code snippet, we specify different opacity values to fill the rectangle with rgb(0,50,255) blue using **RGBA** color codes (Figure a); for red hsl(0,100%,50%) - using the **HSLA** color codes (Figure b) and for the color HEX #C1B900 - using the **fill-opacity** attribute (Figure c).

```html {linenos=inline,linenostart=1}
<svg viewBox="0 0 1250 200" xmlns="http://www.w3.org/2000/svg">
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
<div>
<svg viewBox="0 0 1250 225" xmlns="http://www.w3.org/2000/svg">
    <rect x="310" y="30"  width="100" height="100" fill="rgba(0,50,255,0.8)" />
   	<rect x="250" y="50"  width="110" height="100" fill="rgba(0,50,255,0.7)" />
   	<rect x="170" y="90"  width="110" height="100" fill="rgba(0,50,255,0.6)" />   
    <rect x="100" y="50"  width="110" height="100" fill="rgba(0,50,255,0.4)" />
    <rect x="50" y="30"  width="110" height="100" fill="rgba(0,50,255,0.2)" />
    <text  x="220" y="220" style="font-size:25">a)</text>
    <rect x="710" y="30"  width="100" height="100" fill="hsla(0,100%,50%,0.8)" />
   	<rect x="650" y="50"  width="110" height="100" fill="hsla(0,100%,50%,0.7)" />
   	<rect x="570" y="90"  width="110" height="100" fill="hsla(0,100%,50%,0.6)" />   
    <rect x="500" y="50"  width="110" height="100" fill="hsla(0,100%,50%,0.4)" />
    <rect x="450" y="30"  width="110" height="100" fill="hsla(0,100%,50%,0.2)" />
    <text  x="620" y="220" style="font-size:25">b)</text>
    <rect x="1110" y="30" width="100" height="100" fill="#C1B900" fill-opacity="0.8" />
   	<rect x="1050" y="50" width="110" height="100" fill="#C1B900" fill-opacity="0.7" />
   	<rect x="970" y="90" width="110" height="100" fill="#C1B900" fill-opacity="0.6" />   
    <rect x="900" y="50" width="110" height="100" fill="#C1B900" fill-opacity="0.4" />
    <rect x="850" y="30" width="110" height="100" fill="#C1B900" fill-opacity="0.2" /> 
    <text  x="1020" y="220" style="font-size:25">c)</text>   
</svg>
</div>

{{% alert color="primary" %}} 
If you want to find a required color, you can mix two colors using a free online [**Color Mixer**](https://products.aspose.app/svg/color-mixer). The application allows to mix two colors in different quantities and see the result after mixing. Check our Color Mixer to get fun and investigate a color nature! 
{{% /alert %}} 

<a href="https://products.aspose.app/svg/color-mixer" target="_blank">![Text "Banner Color Mixer"](color-mixer.png#center)</a>



