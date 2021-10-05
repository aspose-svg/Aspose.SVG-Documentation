---
title: SVG Coordinate Systems and Units
type: docs
weight: 10
aliases: /net/drawing-basics/coordinate-systems-and-units
lastmod: 2021-10-05
description: SVG Coordinate System, SVG Viewport, User Coordinate System, SVG Units
keywords: SVG Coordinate System, SVG Viewport, User Coordinate System, SVG Units
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

>  All SVG content is drawn inside SVG viewports. Every SVG viewport defines a drawing region characterized by size (width, height), and an origin, measured in abstract user units. ([**W3C**](https://www.w3.org/TR/SVG2/coords.html))

The canvas is the space or area where all SVG elements are drawn. This area can be considered infinite, and the SVG image can be any size. The SVG document describes a two-dimensional object that can have endless coordinates, both in the positive and negative directions along the X and Y axes. We are not limited in the space when we are drawing. However, the size of the screen narrows the viewing area of the image on it. This visible area is named the viewport. 

## **SVG Viewport**

All SVG content must be displayed inside the viewport that defines an area on the canvas, characterized by size and a point of origin. The default origin is (0,0). Scope of the viewport sets using the **width** and **height** attributes on the outermost  `<svg>` element. 
```html {linenos=inline,linenostart=1, hl_lines=[""]}
    <svg width="900" height="500" xmlns="http://www.w3.org/2000/svg">
    </svg>
```
The above code shows how to set the **width** and **height** of the SVG viewport. The picture can be seen through the 900×500 pixels "window". Such a viewport is named the **initial viewport**. 

 ![The canvas and initial viewport](viewport1_1.png#center)


## **User Coordinate System and SVG Units** 

Let's examine how SVG represents the positions and sizes of objects for drawing. 

The default coordinate system in SVG is much the same as in HTML. It works like a two-dimensional *x-y* plane. The initial SVG coordinate system sets in the initial SVG viewport with the point of origin (0,0) in the top left corner. The positive *x*-direction being to the right, and the positive *y*-direction being to the bottom. For specifying (*x*, *y*) coordinates, width and height values, you can use *cm, mm, in, em, ex, pt, pc*, and *px*. The default SVG units are pixels. 

We have to differentiate the **initial SVG coordinate system** and the **user SVG coordinate system** of the viewport. The main outermost `<svg>` element has a **viewBox** attribute. If this attribute is not given, then the user coordinate system is the same as the initial coordinate system. 

The **viewBox** attribute sets a user coordinate system, which may not be the same as the initial one. The **viewBox** takes four parameters: 

**min-x, min-y** – the x and y coordinates of top left corner of the **viewBox**, 

**width, height** – the width and height of the **viewBox**. 

Attribute values must be placed inside quotes: **viewBox= "min-x min-y width height"**. 

The viewport is like a window you look through to see an SVG’s content. The viewBox is also similar to the viewport, and it can be used for zooming. Consider an example: 
```html {linenos=inline,linenostart=1, hl_lines=[""]}
    <svg width="900" height="500" viewBox="220 125 450 250" xmlns="http://www.w3.org/2000/svg">
    </svg>
```
According to a code snippet, viewBox defines a specific canvas area, covering a rectangular with the origin point (220,125), the width=450 and the height=250. Then the SVG image is cropped to that area and scaled up to fill the entire viewport. 

![initial viewport and user viewbox](viewport2_1.png#center) 

The  figure on the left shows the infinite SVG document canvas, initial SVG viewport and user viewBox. The figure on the right illustrates the result of the **viewBox** attribute applying.



As a result of the **viewBox** attribute using, the user coordinate system unit became equal to two units of the initial viewport. The scaling took place. 
Changing the parameters of the **viewBox** attribute allows you to scale, fragment, and move the original image along the coordinate axes. In addition, the SVG coordinate system can be rotated, skewed, and flipped. More details are in the [**Basic SVG Transformations**](/svg/net/drawing-basics/basic-transformations/) section and on [**SVG 2.0 W3C**](https://www.w3.org/TR/2018/CR-SVG2-20181004/coords.html) page.