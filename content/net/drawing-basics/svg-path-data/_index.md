---
title: SVG Path Data
type: docs
weight: 30
aliases: /net/drawing-basics/svg-path-data
lastmod: 2022-01-10
description: This article shows how the paths can be used to drawing various outlines or shapes by combining SVG lines, SVG arcs and Bezier curves. The group of commands for the SVG path making is described here.
description: svg path data, svg lines, svg paths, svg arc, draw Bézier curves, Bézier curves, cubic Bezier curve, quadratic Bézier curve
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

The `<path>` element allows you to draw the outlines of shapes by combining lines, curves, and arcs. It is a versatile and flexible SVG element for creating both simple and complex open and closed SVG paths. The  `<path>` element determines by one attribute - **d**. Thus, a path definition includes a `<path>` element which contains a `d="(SVG path data)"` attribute.

The following groups of commands inhere to **d** attribute: 

***moveto (M, m)***  

***lineto (L, l, H, h, V, v)***

***closepath (Z, z)*** 

The ***M*** command sets the origin point for SVG path drawing. The commands group that draw straight line segments includes the ***lineto  (L, l, H, h, V and v)***  and the ***closepath (Z and z)*** commands.  
The following three groups of commands draw curves: 

***cubic Bézier curve (C, c, S, s)*** 

***quadratic Bézier curve (Q, q, T, t)*** 

***elliptical Arc (A, a)*** 

All commands can be specified with uppercase and lowercase letters. The uppercase indicates that the subsequent coordinates are absolute, and the lowercase indicates relative ones. 
Coordinates are always written without units specifying and refer to the user's coordinate system. Usually, they are in pixels. 
The path is described by the position of the current point - a "virtual pen". The "pen" moves along the path sections from the starting to the endpoint. These points are the key parameters for all drawing commands. 
Each command has parameters; they are indicated in brackets.


## **Lines and Paths** 

Any SVG path begins with the ***moveto M (x,y)*** command.  ***x*** and ***y*** coordinates indicate the current  point where the path should start. 

Three ***lineto*** commands draw straight lines from the current point to the new one: 

***L (x, y)*** - the command takes two parameters -  ***x*** and ***y*** coordinates of a point,  and draws a line from the current position to this point (***x, y***). 

***H (x)*** - draws a horizontal line from the current position to point with ***x*** coordinate. The y coordinate does not change the value.

***V (y)*** - draws a vertical line from the current position to point with ***y*** coordinate. The x coordinate does not change the value.

The ***H*** and ***V*** commands only use one argument since they only move in one direction. 

After doing any command, the "virtual pen" point will be located at the endpoint of that drawing command. The next drawing command will start from this point. 

***Closepath Z*** ends the current SVG path, returning it to the starting point. The ***Z*** command draws a straight line from the current position back to the first point in the path. The command has no parameters.  

Let's draw a square using the ***lineto*** commands ([lineto.svg](http://docs.aspose.com/svg/net/how-to-work-with-aspose-svg-api/saving-svg-documents/lineto.svg)):

```html {linenos=inline,linenostart=1}
<svg height="400" width="400" viewBox="0 0 200 200" xmlns="http://www.w3.org/2000/svg">
    <path d="M 30 30 L 110 30 L 110 110 L 30 110 L 30 30" fill="transparent" stroke-width="2" stroke="black" />  
    <path d="M 50 50 H 130 V 130 H 50 Z" fill="transparent" stroke-width="2" stroke="blue" />
    <path d="M 70 70 h 80 v 80 h -80 Z" fill="transparent" stroke-width="2" stroke="red" />
</svg>
```
![Three squares: black blue and red grey rectangles](lineto.png#center)

A black square is created by sequentially using the ***L*** command, which draws a line to the specified point (***x, y***). This is the most common way of making a wide variety of straight-line paths. 

However, in the rectangle case or the other shapes with 90 angles, you can use the ***H*** and ***V*** commands. For drawing the blue square, the code is shorter.  ***Z*** command doesn't require the endpoint specifying for the shape closing that also reduces the path code writing.  For the red square constructing, the commands ***h*** and ***v*** were applied, using relative coordinates. 

The figure on the left shows all the extra notes. The view of the **rendered  SVG graphics** is on the right.

## **Draw an SVG Arc** 

Arcs are used for sections of circles and ellipses drawing. For SVG arcs creating, it is not enough to specify only ellipse radii. You should take into account different possible paths along the arc between two points: the "pen's" moving in a "positive-angle" direction or the opposite; the "pen's" moving along the "large-arc" or the "small-arc".

Thus, two ellipses can connect any two points, and the four different arcs can be drawn between these points. The **A** command's parameters indicate which one of the four arcs will be chosen. 

The **A** command allows to make a path with arcs by hand: **A (rx ry x-axis-rotation large-arc-flag sweep-flag x y)**. 

**rx, ry** - ellipse radii (the center is calculated automatically). 

**x, y** - coordinates of the endpoint of the SVG arc. 

**x-axis-rotation** - the angle of the x-axis rotation relative to the coordinate system, specified in degrees. 

**large-arc-flag** - can be 0 or 1. A value of "0" means that the "small-arc" will be drawn, a value of "1" - the "large-arc" will be chosen. 

**sweep-flag** - can be 0 or 1. If a value is "1", then the arc will be drawn in a "positive-angle" direction. A value of "0" indicates about the "pen's" moving in a "negative-angle" direction. 

The **a** command is the same as **A** but interprets the coordinates relative to current "pen" point. 

```html {linenos=inline,linenostart=1 hl_lines=["2"]}
<svg height="500" width="700" viewBox="0 0 100 100" xmlns="http://www.w3.org/2000/svg">
    <path d="M10,20 A 30,30 0 0,0 40,70" style="stroke:#FFA500; stroke-width:1; fill:none" />
    <path d="M10,20 A 30,30 0 1 0 40,70" style="stroke: #FF0000; stroke-width:1; fill:none" />
    <path d="M10,20 A 30,30 0 0 0 40,70 A 30,30 0 1 1 10,20" style="stroke: #FFA500; stroke-width:1; fill:#FFD700" transform="translate(70,0)" />
</svg>  
```
![Three paths with arcs](arc1.png#center)

Consider the path written in line 2 of code sample: `d="M10,20 A 30,30 0 0,0 40,70"`.
The ***M*** command set a current (start)  point (10, 20). The endpoint of the arc is in ***A*** command (40,70). Between points 1 (10, 20) and 2 (40,70), you can draw two circles with a radius 30 (see figure above). The **x-axis-rotation** value is 0; ***large-arc-flag = 0*** - this means that the "small arc" will be drawn, ***sweep-flag = 0*** - which means that arc 1-2 will be selected, the "pen" movement in the direction of the "negative angle", i.e. counter clock-wise. This is a gold-color SVG arc ([svg-arc.svg](/svg/net/drawing-basics/svg-path-data/svg-arc.svg)).


## **Draw Bézier Curves** 

Bezier curves are an important tool for computer graphics programs. There are two types of the Bezier curves are available in SVG `<path>` elements: a cubic one (***C***) and a quadratic one (***Q***).  The curve has a start point, an endpoint, and control points. A quadratic curve has one control point, and a cubic one has two. The position of the control points determines the form of the curve. 

### **Quadratic Bézier Curves**

Any Bezier curve as the current (starting) point takes the pen's location after the executing of the previous command. The ***Q*** command of the quadratic curve is specified by only two points: the control point (***x1, y1***) and the endpoint of the curve (***x, y***). The ***q*** command is also given by two points, the coordinates of which are relative to the current point. 

Let's consider an example: 

```html {linenos=inline,linenostart=1}
<svg width="600" height="600" viewBox="0 0 200 200" xmlns="http://www.w3.org/2000/svg">
    <path d="M 10 100 Q 25 10 180 100" stroke="black" stroke-width="1" fill="transparent" />
</svg>
```
![Quadratic Bézier Curve](qbq1.png#center)

If you connect the control point to the start and endpoints of the curve with segments, the line connecting the centers of the segments will be tangent to the curve vertex. 

How does the position of the control point affect the curve view? Let us show this with examples. Let's change the value of ***y1*** at the control point for the previous curve ([bezier-curve2.svg](/svg/net/drawing-basics/svg-path-data/bezier-curve2.svg)): 

```html {linenos=inline,linenostart=1}
<svg width="600" height="600" viewBox="0 0 200 200" xmlns="http://www.w3.org/2000/svg">
    <g stroke-width="1" fill="none">
        <path d="M 10 100 Q 25 10 180 100" stroke="black" />
        <path d="M 10 100 Q 25 -60 180 100" stroke="blue" />
        <path d="M 10 100 Q 25 100 180 100" stroke="red" />
        <path d="M 10 100 Q 25 190 180 100" stroke="green" />
    </g>
</svg>
```

![Four Quadratic Bézier Curves with different y1 values for the control point](qbq2.png#center)

Let's take the black curve as a basis and change the control point **x1** value ([bezier-curve3.svg](/svg/net/drawing-basics/svg-path-data/bezier-curve3.svg)):

```html {linenos=inline,linenostart=1}
<svg width="600" height="600" viewBox="0 0 200 200" xmlns="http://www.w3.org/2000/svg">
    <g stroke-width="1" fill="none">
        <path d="M 10 100 Q 25 10 180 100" stroke="black" />
        <path d="M 10 100 Q -40 10 180 100" stroke="red" />
        <path d="M 10 100 Q 165 10 180 100" stroke="green" />
        <path d="M 10 100 Q 245 10 180 100" stroke="blue" />
    </g>
</svg>
```

![Four Quadratic Bézier Curves with different x1 values for the control point](qbq3.png#center)

```html {linenos=inline,linenostart=1}
<svg width="700" height="600" xmlns="http://www.w3.org/2000/svg">
   <path d="M 10 100 Q 25 10 180 100 T 250 100 T 320 100 T 390 100" stroke="orange" stroke-width="3" fill="none" />
   <path d="M 10 200 Q 25 110 180 200 T 300 250 T 420 250 T 490 150" stroke="grey" stroke-width="3" fill="none" />
</svg>
```
Several  ***Q*** commands can be used sequentially for extended curves stringing, but the resulting curve may not be smooth.  You can combine multiple quadratic Béziers without losing smoothness with the help of ***T*** command.

The ***T*** command draws the quadratic Bézier curve from the current point to endpoint (***x,y***).  The command's parameters are only the endpoint coordinates  (***x,y***).  The ***T*** command outputs the new control point using the coordinates of the previous one. This works if the last command was a ***Q*** or a ***T***. At the end of the ***T*** command, the final (***x,y***) coordinate pair becomes the new current point used in the polybézier.
Below is an example of a curve created using the ***T*** command. Here, the ***x*** coordinates of the curve segments are equidistant,  ***y*** coordinate does not change.

```html {linenos=inline,linenostart=1}
<svg width="700" height="600" xmlns="http://www.w3.org/2000/svg">
    <path d="M 10 100 Q 25 10 180 100 T 350 100 T 520 100 T 690 100" stroke="black" stroke-width="3" fill="none" />
</svg>
```
![Quadratic Bézier Curve created using the T command](qbq4.png#center)
If you try to vary the endpoint (***x,y***) coordinates of ***T*** command, you can obtain a wide variety of curves ([bezier-curve5.svg](/svg/net/drawing-basics/svg-path-data/bezier-curve5.svg)).


```html {linenos=inline,linenostart=1}
<svg height="700" width="750" xmlns="http://www.w3.org/2000/svg">
    <path d="M 10 100 Q 25 10 180 100 T 250 100 T 320 100 T 390 100" stroke="#FFA500" stroke-width="3" fill="none" />
    <path d="M 10 200 Q 25 110 180 200 T 300 250 T 420 250 T 490 150" stroke="grey" stroke-width="3" fill="none" />
</svg>
```

![Two Quadratic Bézier Curves created using the T command](qbq5.png#center)

### **Cubic Bezier Curve**

Cubic Bézier curve is more complex than a quadratic one. Two control points describe the appearance of the curve at its beginning and the end. To create a cubic Bezier curve, you need to specify three sets of coordinates in the **C** command: the coordinates of two control points (**x1 y1, x2 y2**) and the endpoint of the curve (**x y**): **C x1 y1, x2 y2, x y**.

The control points position determines the slope of the tangent line at the start and endpoint. The Bézier function creates a smooth curve that paths from the slope set at the beginning of the line to the slope at the curve end. You can specify several **C** commands in the one `<path>` element; they will be realized sequentially. The endpoint of the first **C** command becomes the starting point for the new **C** command. 

The following code example makes a shape using two paths ([cubic-bezier-curves.svg](/svg/net/drawing-basics/svg-path-data/cubic-bezier-curves.svg)):

```html {linenos=inline,linenostart=1}
<svg height="700" width="750" xmlns="http://www.w3.org/2000/svg">
    <!--shape two paths-->
    <path d="M 100 250 C 150 60  355 140  328 260 " stroke="black" stroke-width="3" fill="none" />
    <path d="M 100 250 C 40 500 240 510 328 260" stroke="red" stroke-width="3" fill="none" />
</svg>
```
On the figure, different paths are shown in black and red.

![Cubic Bezier Curve](cbc1.png#center)

The following code example makes the same shape using one path:

```html {linenos=inline,linenostart=1}
<svg height="700" width="750" xmlns="http://www.w3.org/2000/svg">
   <!--shape 1 path-->
   <path d="M 100 250 C 150 60  355 140  328 260 C 240 510 40 500 100 250" stroke="black" stroke-width="3" fill="none" />
</svg>
```
In the sample above we have connected in the one path two curves with the help of C commands. The curves binding in this way may result in a loss of smoothness at the connection points. 

For smooth long curves creating you may use a shortcut version of the cubic Bézier, designated by the **S x2 y2, x y** command. What does **S** command do? It allows to string together multiple cubic Béziers similar to the **T** command for the quadratic Béziers.
For the **S** command, the first control point is considered a reflection of the previous one, that is necessary for a constant slope and smooth connection of the curves. The second control point  (**x2 y2**) and the endpoint  ( **x y**) coordinates must be specified.

Using Bezier curves, you can make a simple drawing in the primitivism style. We have drawn the picture similar “Owl” Picasso ([owl.svg](/svg/net/drawing-basics/svg-path-data/owl.svg)):

```html {linenos=inline,linenostart=1}
<svg height="700" width="750" xmlns="http://www.w3.org/2000/svg">
    <g stroke="black" stroke-width="3" fill="none">
        <!--body 1 path-->
        <path d="M 100 250 C 150 60  355 140  328 260 C 240 510 40 500 100 250" />
        <!--wing-->
        <path d="M 110 260 C 220 200, 250 280, 120 410" />
        <!--1 eyebrow-->
        <path d="M 110 240 C 130 220, 220 130, 231 230" />
        <!--2 eyebrow-->
        <path d="M 231 231 C 230 220, 280 130, 329 258" />
        <!--line-->
        <path d="M 30 380 l 63 0" />
        <path d="M 266 380 c 33 8 63 -8 90 5" />
        <!--eyes-->
        <circle cx="204" cy="209" r="3" />
        <circle cx="205" cy="210" r="9" />
        <circle cx="265" cy="209" r="3" />
        <circle cx="265" cy="210" r="8" />
    </g>
</svg>
```

![Two owl](two_owl.png#center)

{{% alert color="primary" %}}
Aspose.SVG offers [**SVG Free Web Applications**](https://products.aspose.app/svg/en/applications) for converting SVG or image files, merging SVG files, Image Vectorizing, SVG sprite generating, SVG to Base64 data encoding, and text vectorizing. These online Apps work on any operating system with a web browser and don't require additional software installation. It's a fast and easy way to efficiently and effectively solve your SVG-related tasks!
{{% /alert %}} 