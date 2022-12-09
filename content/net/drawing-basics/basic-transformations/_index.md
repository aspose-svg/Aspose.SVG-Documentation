---
title: SVG Transformations | Basics
linktitle: Basic SVG Transformations
type: docs
weight: 50
url: /net/drawing-basics/svg-transformations/
aliases: /net/drawing-basics/basic-transformations/
lastmod: 2022-12-09
description: Learn how to rotate, scale, move, and skew SVG graphics using the SVG transform attribute and consider code examples for SVG transformations.
keywords: SVG Transformations, SVG Translation, SVG Scaling, SVG Rotation, SVG Skewing
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

{{% alert color="primary" %}}
Aspose.SVG offers [**SVG Free Web Applications**](https://products.aspose.app/svg/applications) for converting SVG or image files, merging SVG files, image vectorizing, SVG sprite generating, SVG to base64 data encoding, and text vectorizing. These online Apps work on any operating system with a web browser and don't require additional software installation. It's a fast and easy way to efficiently and effectively solve your SVG-related tasks!
{{% /alert %}} 

SVG allows modifying graphic elements using translation, rotation, scaling, and skewing.  All these SVG transformations refer to the geometric kind. SVG objects can be altering using the **transform** attribute's properties: ***translate, scale, rotate, skewX, skewY***, and ***matrix***.   

## **Translation**

The ***translation*** moves all the object points at the same distance along parallel lines. This can be interpreted as shifting the origin of the element’s system of coordinates. There are three transform functions: ***translateX (tx)***, ***translateY (ty)*** and ***translate (tx, ty)***. The ***translate (tx, ty)*** function moves an element by a ***tx*** value along the x-axis and by ***ty*** along the y-axis. If one of the values is not specified, it defaults to zero.

The action of attribute `transform="translate(tx, ty)"` means the changing of object coordinates according to the formula:

x(new) = x(old) + ***tx***

y(new) = y(old) + ***ty***

Here is a simple example:

```html {linenos=inline,linenostart=1}
<svg viewBox="0 0 100 100" xmlns="https://www.w3.org/2000/svg"> 
    <g fill="none">
        <!-- no translation -->
        <circle cx="15" cy="15" r="10" stroke="blue" />
        <!-- horizontal translation -->
        <circle cx="15" cy="15" r="10" stroke="black" transform="translate(22)" />
        <circle cx="15" cy="15" r="10" stroke="red" transform="translate(44)" />
        <!-- Both horizontal and vertical translation -->
        <circle cx="15" cy="15" r="10" stroke="green" transform="translate(33,13)" />
        <circle cx="15" cy="15" r="10" stroke="yellow" transform="translate(11,13)" />
	</g>
</svg>
```
In the code example,  `<g>` element is used to group circles together. The **fill** attribute  applies inside `<g>` to all shapes once. Here is the resulting image ([translation.svg](/svg/net/drawing-basics/svg-transformations/translation.svg)):

![Five Olympic rings as an illustration of a translation transformation](translate.png#center)

## **Scaling**

Scaling is an SVG transformation that enlarges or reduces an object using a scaling factor. You have to distinguish the uniform and directional scaling.
The ***scale (sx [sy])*** transform function allows scaling image along the x- and y-axis. This function takes one or two values which specify horizontal and vertical scaling:  `transform="scale(<sx> [<sy>])"`. The ***sy*** scaling factor value is optional and if omitted it is assumed to be equal to ***sx***.

```html {linenos=inline,linenostart=1}
<svg viewBox="-50 -50 200 200" xmlns="https://www.w3.org/2000/svg">
    <!-- uniform scale -->
    <circle cx="0" cy="0" r="10" fill="#B0C4DE" transform="scale(4)" />
    <circle cx="0" cy="0" r="10" fill="#DDA0DD" transform="scale(3)" />
    <circle cx="0" cy="0" r="10" fill="#FFB6C1" transform="scale(2)" />
    <!-- no scale -->
    <circle cx="0" cy="0" r="10" fill="#5F9EA0" />
    <g transform="translate(100)">
        <!-- uniform scale -->
        <circle cx="0" cy="0" r="10" fill="#B0C4DE" transform="scale(4)" />
        <!-- vertical scale -->
        <circle cx="0" cy="0" r="10" fill="#DDA0DD" transform="scale(1,4)" />
        <!-- horizontal scale -->
        <circle cx="0" cy="0" r="10" fill="#FFB6C1" transform="scale(4,1)" />
        <!-- no scale -->
        <circle cx="0" cy="0" r="10" fill="#5F9EA0" />
    </g>
</svg>
```

 Here is the resulting image ([scaling.svg](/svg/net/drawing-basics/svg-transformations/scaling.svg)):

![Four filled circles that illustrate scaling](scale.png#center)

The code above uses the ***scale*** and ***translate*** functions. The first group of circles on the figure displays an example of uniform scaling, and the second group illustrates the circle scaling along the y-axis  (line 12) and the x-axis (line 14). A scale value of "4"  renders graphic four times its original size, while a value of "4,1"  increases four times its source width, and saves its height. 

## **SVG Rotation**

The ***rotate(angle, cx, cy)*** function rotates the element by ***angle*** around the point with coordinates (***cx, cy***). If coordinates are not specified, then the rotation will be performed around the point (0, 0) of the initial coordinate system. 
All rotate or skew angle values should be specified in degrees, you cannot use the other units we have available in CSS. If we use a positive angle value, then the rotation will be clockwise, and conversely, a negative angle value gives us counterclockwise spin.

**Note:** Specifying just the ***angle*** and the ***cx*** parameter makes the value invalid, and no SVG rotation is applied.

Like ***translation***, ***SVG rotation*** does not distort the element and saves parallelism, angles, and distances.

```html {linenos=inline,linenostart=1}
<svg width="450" height="450" xmlns="https://www.w3.org/2000/svg">
    <rect x="100" y="250" width="200" height="30" fill="CadetBlue" />
    <rect x="100" y="250" width="200" height="30" fill="#DDA0DD" transform ="rotate(-45 200 265)" />
    <rect x="100" y="250" width="200" height="30" fill="Pink" transform ="rotate(-90 200 265)" />
    <rect x="100" y="250" width="200" height="30" fill="#B0C4DE" transform ="rotate(45 200 265)" />
    <rect x="100" y="250" width="200" height="30" fill="CadetBlue" transform ="rotate(-35)" />
</svg>
```
The function `transform="rotate (-90 200 265)"` used in line 4 means that the pink rectangle should be rotated 90 degrees counterclockwise with the center of rotation at (200,265). For rectangle in line 6, coordinates (***cx, cy***) are not specified, and the rotation on -35 degrees is performed around the point (0, 0) of the initial coordinate system. The result of SVG rotation can be seen on the figure:

![Five filled rectangles that illustrat SVG rotation](svg-rotation.png#center)

You can view and then save the file that illustrates SVG rotation by clicking on the link [rotation.svg](/svg/net/drawing-basics/svg-transformations/rotation.svg).

## **Skewing**

Skewing is a transformation that rotates one of the axes of the element's coordinate system by a certain angle clockwise or counterclockwise. SVG elements can be skewed through the use of the ***skewX(angle)*** and ***skewY(angle)*** functions. The ***angle*** value included within these functions represents a skew SVG transformation in degrees along the appropriate axis.
The using ***skewX(angle)***, only the x coordinate of the points of the shape changes, but the y coordinate remains unchanged. The ***skewX(angle)*** function makes the vertical lines look like they have been rotated by a given angle. The x coordinate of each point changes on a value proportional to the specified angle and distance to the origin.

Here is shown an example of the circle with skewX(55) value ([sqew-x.svg](/svg/net/drawing-basics/svg-transformations/sqew-x.svg)):

```html {linenos=inline,linenostart=1}
<svg viewBox="0 0 100 100" xmlns="https://www.w3.org/2000/svg">
    <circle cx="20" cy="20" r="15" stroke="blue" fill="none" />
    <circle cx="20" cy="20" r="15" stroke="grey" stroke-opacity="0.7" fill="none" transform="skewX(55)" />
</svg>
```
A simple example of the rectangle skewed by skewY(35) function ([sqew-y.svg](/svg/net/drawing-basics/svg-transformations/sqew-y.svg)):

```html {linenos=inline,linenostart=1}
<svg  width="800" height="800" viewBox="0 0 200 200" xmlns="https://www.w3.org/2000/svg">
   <rect x="20" y="20" width="30" height="30" stroke="blue" stroke-opacity="1" fill="none" />
   <rect x="20" y="20" width="30" height="30" stroke="grey" stroke-opacity="0.5" fill="none" transform="skewY(35)" />
 </svg>
```
 The rendered examples look like:

 ![Circle and skewed circle](skew_xy1.png#center)





