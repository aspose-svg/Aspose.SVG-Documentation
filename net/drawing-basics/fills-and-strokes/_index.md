---
title: Fills and Strokes
type: docs
weight: 6
url: /net/drawing-basics/fills-and-strokes
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

Filling and stroking are both painting operations. All graphical elements such as shapes, paths and text – are rendered by being filled. The fill is painting the interior of the object, and stroke is painting along its outline. The stroke and fill are ones of the main SVG CSS properties that can be set for any lines, text and shapes. In the SVG text file, they can be specified both in the **style** attribute and using **[presentation attributes](https://www.w3.org/TR/2018/CR-SVG2-20181004/styling.html#TermPresentationAttribute)**. For each property, there exists a corresponding presentation attribute, which is described in the Styling chapter of W3 SVG 2.0 specification.

 

## **Fills and Strokes properties**

Colorization or painting means the operation of adding color, gradients or patterns to graphics using **fill** and **stroke**. A set of attributes define their properties: **fill, fill-opacity, fill-rule, stroke, stroke-dasharray, stroke-dashoffset, stroke-linecap, stroke-linejoin, stroke-miterlimit, stroke-opacity**, and **stroke-width**. They are some of the **[presentation attributes](https://www.w3.org/TR/2018/CR-SVG2-20181004/styling.html#TermPresentationAttribute)**.

Fills and strokes styling features can be set in the **style** attribute. The syntax for properties specifying is: 

`style="stroke:#00ff00; stroke-width:2; fill:#ff0000"`

But the same **style** properties can be given in the presentation attributes with such the syntax:

`stroke="green" stroke-width="2" fill="#ff0000"`

For the color specifying, you can take **[color names](https://en.wikipedia.org/wiki/List_of_colors:_A–F)**, rgb values, hex values, etc. In the following examples will be using different ways of writing fills and strokes characteristics. 





## **Fill** **attribute**

The **fill** attribute colors the interior of a graphic element. When you fill a shape or curve, the **fill** colourizes open paths too as if the last its point was connected to the first, even though the **stroke** color in that part of the path will not appear. If the **fill** attribute property is not specified, the default is black.

So that there is no filling, you need to specify the attribute value `fill= "none"` or `fill= "transparent"`.

The sample below illustrates the presents and lacking `fill= "none"` property:
```html {linenos=inline,linenostart=1}
<svg height="400" width="800" xmlns="http://www.w3.org/2000/svg">
    <path d="M 10 100 Q 25 10 180 100 T 250 100 T 300 100 T 390 130" stroke="red" stroke-width="3" fill="none" />
    <path d="M 10 100 Q 25 10 180 100 T 250 100 T 300 100 T 390 130" stroke="red" stroke-width="3" transform="translate(0 125)" />
</svg>
```
![Two paths: unfilled and filled](two_paths.png#center)

## **Lines and Stroke Caps**

The more often used stroke properties are the following: **stroke, stroke-width, stroke-linecap**, and **stroke-linejoin**. They define the color, thickness, types of line endings to an open path, and kind of join of the two meet lines.

For any line, it is possible to set the shape of its ends. This makes sense if the line has the **stroke-width** property. The sample below shows as the **stroke-width** and **stroke-linecap** properties define the stroke's width and form of its ends.
```html {linenos=inline,linenostart=1}
<svg height="200" width="800" xmlns="http://www.w3.org/2000/svg">
  <g stroke="grey">
    <path stroke-width="3" d="M 5 20 l 215 0" />
    <path stroke-width="15" d="M 5 60 l 215 0" />
    <path stroke-width="30" d="M 5 100 l 215 0" />
  </g>
 <g stroke="grey" stroke-width="30">
    <path stroke-linecap="butt" d="M 300 20 l 215 0" />
    <path stroke-linecap="round" d="M 300 60 l 215 0" />
    <path stroke-linecap="square" d="M 300 100 l 215 0" />
  </g>
  <g stroke="orange" stroke-width="2">
    <line x1="300" y1="20" x2="515" y2="20" />
    <path d="M 300 60 l 215 0" />
    <path d="M 300 100 l 215 0" />
  </g>
</svg>
```
In the sample, we use a `<g>` element to set common properties on objects, such as **stroke** and **stroke-width**. 

![Two sets of lines: with different width values and stroke-linecap properties](lines.png#center)

In the example above, the paths (lines) are shown in orange, and the strokes in grey.

The **stroke-linecap** CSS attribute defines how the ends of a line are rendered, and has three possible values: *butt, square* and *round*.

As a result of *butt* using, the stroke cap is cut off with a straight edge that is normal exactly where the line ends. The value *square* results in a stroke cap that looks like a cut off, but it extends slightly beyond where the line ends. The distance that the stroke goes beyond the path is half of the **stroke-width** value. The value *round* means the stroke cap has the round ends, which radius depends by the **stroke-width**.

One more sample illustrates a **stroke-linejoin** property:
```html {linenos=inline,linenostart=1}
<svg width="300" height="300" xmlns="http://www.w3.org/2000/svg">
    <g stroke-width="20" fill="none">
        <polyline points="40 60 80 20 120 60 160 20 200 60 240 20" stroke="grey" stroke-linecap="butt"  stroke-linejoin="miter" />
        <polyline points="40 140 80 100 120 140 160 100 200 140 240 100" stroke="#CD5C5C" stroke-linecap="round" stroke-linejoin="round" />
        <polyline points="40 220 80 180 120 220 160 180 200 220 240 180" stroke="black"  stroke-linecap="square" stroke-linejoin="bevel" />
    </g>
    <g fill="none" stroke="orange" stroke-width="2">
        <polyline points="40 60 80 20 120 60 160 20 200 60 240 20" />
        <polyline points="40 140 80 100 120 140 160 100 200 140 240 100" />
        <polyline points="40 220 80 180 120 220 160 180 200 220 240 180" />
   </g>
</svg>
```
![Three polylines with different stroke-linejoin properties](linejoin.png#center)

Note, the orange line inside is the object (polyline), around is the stroke.

The **stroke-linejoin** attribute can take a three value: *miter, round*, and *bevel*. The *miter* extends the stroke to create a square corner in the lines join point; *round* builds a rounded stroke in the joining end; *bevel* makes a new angle to aid in the transition between the two lines.

## **Dots and Dashes**

The **stroke-dasharray** attribute converts paths into dashes and makes the stroke of an SVG shape rendered with dashed lines. The values, that **stroke-dasharray** attribute takes, are an array of commas or whitespace-separated numbers. These values define the length of dashes and spaces.

Here is a **stroke-dasharray** example:
```html {linenos=inline,linenostart=1}
<svg width="400" height="300" xmlns="http://www.w3.org/2000/svg">
    <line x1="20" y1="30" x2="400" y2="30" style="stroke:RGB(112, 128, 144); fill:none; stroke-width:10; stroke-dasharray:10 5;" />
    <line x1="20" y1="80" x2="400" y2="80" style="stroke:olive; fill:none; stroke-width: 20; stroke-dasharray: 20 10 5;" />
    <path d="M 10 200 Q 50 100 150 200 T 230 200 T 300 200 T 390 200" stroke="#FF8C00" stroke-width="8" fill="none" stroke-linecap="round" stroke-dasharray="15 10 2 8" />
</svg>
```
For the grey and orange lines, we specify even number of values: each of number couples means “filled-unfilled” areas. The default values are in pixels.

![Three paths with different stroke-dasharray properties](dasharray.png#center)

If an odd number of values is specified, the list is then repeated to produce an even number of values. For example, 20  10  5 becomes 20  10  5  20  10  5, as for olive-color line.

Moreover, you can separately specify the opacity of the fill or stroke that controlled by the **fill-opacity** and **stroke-opacity** attributes.

Amazing things can be achieved with strokes and simple shapes:

```html {linenos=inline,linenostart=1}
<svg height="600" width="600" xmlns="http://www.w3.org/2000/svg">
    <g fill="none">
        <circle cx="100" cy="100" r="40" stroke="red" stroke-width="55" stroke-dasharray="4,2" />
        <circle cx="120" cy="100" r="30" stroke="grey" stroke-width="45" stroke-dasharray="5,2" transform="translate(100,40)" />
        <circle cx="100" cy="130" r="35" stroke="orange" stroke-width="45" stroke-dasharray="9,3" transform="translate(30,100)" />
		<circle cx="450" cy="120" r="20" stroke="pink" stroke-linecap="round" stroke-width="20" stroke-dasharray="10,15" transform="translate(30,100)" />
        <rect x="320" y="100" width="100" height="100" stroke="DarkCyan" stroke-width="55" stroke-dasharray="7 7 3 2" />
        <text x="200" y="300" font-family="arial" font-size="60" stroke="#000080" stroke-width="3" stroke-dasharray="2 1">I love SVG!</text>
    </g>
</svg>
```

![Circle, rectangle and text with different stroke-dasharray properties](dasharray_examles.png#center)