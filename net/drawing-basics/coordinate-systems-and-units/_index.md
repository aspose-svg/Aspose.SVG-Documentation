---
title: Coordinate Systems and Units
type: docs
weight: 1
url: /net/drawing-basics/coordinate-systems-and-units
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />
The canvas is the space or area where all SVG elements are drawn. This area can be considered infinite, and the SVG image can be any size. The SVG document describes a two-dimensional object that can have endless coordinates, both in the positive and negative directions along the X and Y axes. We are not limited in the space when we are drawing. However, the size of the screen narrows the viewing area of the image on it. This visible area is named the viewport. 

 

## **The initial viewport**

All SVG content must be displayed inside the viewport that defines an area on the canvas, characterized by size and a point of origin. The default origin is (0,0). Scope of the viewport sets using the **width** and **height** attributes on the outermost  `<svg>` element. 
```html {linenos=inline,linenostart=1, hl_lines=[""]}
    <svg width="900" height="500">
    </svg> 
```
The above code shows how to set the **width** and **height** of the viewport. The picture can be seen through the 900×500 pixels "window". Such viewport is named the **initial viewport**. 

 ![The canvas and initial viewport](viewport1_1.png#center)


## **User Coordinate System and Units** 

Let's examine how SVG represents the positions and sizes of objects for drawing. 

The default coordinate system in SVG is much the same as in HTML. It works like a two-dimensional *x-y* plane. The initial coordinate system sets in the initial viewport with the point of origin (0,0) in the top left corner. The positive *x*-direction being to the right, and the positive *y*-direction being to the bottom. For the specifying of coordinate "*x*" and "*y*" etc. you can use *cm, mm, in, em, ex, pt , pc*, and *px*. The default units are pixels. 

We have to differentiate the **initial coordinate system** and the **user coordinate system** of the viewport. The main outermost `<svg>` element has a **viewBox** attribute. If this attribute is not given, then the user coordinate system is the same as the initial coordinate system. 

The **viewBox** attribute sets a user coordinate system, which may not be the same as the initial one. The **viewBox** takes four parameters: 

**min-x, min-y** – are define the top left corner of the **viewBox**, 

**width, height** – are define the width and height of the **viewBox**. 

Attribute values must be placed inside quotes: **viewbox= "min-x min-y width height"**. 

Consider an example: 
```html {linenos=inline,linenostart=1, hl_lines=[""]}
    <svg width="900" height="500" viewbox="220 125 450 250"> 
    </svg> 
```
According to a code snippet, **viewBox** defines a specific area of the canvas, covering a rectangular with origin point (220,125), width 450 and height 250. Then the SVG image is cropped to that area and scaled up to fill the entire viewport. 

![initial viewport and user viewbox](viewport2_1.png#center) 

The  figure on the left shows the infinite SVG document canvas, initial viewport and user viewBox.  The  figure on the right illustrates the result of the **viewBox** attribute applying.

As a result of the **viewBox** attribute using, the user coordinate system unit became equal to two units of the initial viewport. The scaling took place. 
Changing the parameters of the **viewBox** attribute allows you to scale, fragment, and move the original image along the coordinate axes. In addition, the coordinate system can be rotated, skewed, and flipped. More details are in the [**Basic Transformations**](http://localhost:1313/svg/net/drawing-basics/basic-transformations/) section and on [**SVG 2.0 W3C**](https://www.w3.org/TR/2018/CR-SVG2-20181004/coords.html) page.