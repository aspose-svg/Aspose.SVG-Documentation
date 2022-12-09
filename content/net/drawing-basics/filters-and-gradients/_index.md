---
title: SVG Filters and Gradients | SVG code, Examples
linktitle: SVG Filters and Gradients
type: docs
weight: 80
aliases: /net/drawing-basics/filters-and-gradients
lastmod: 2022-07-27
description: You'll learn how to write SVG code to create svg filters, gaussian blur, drop shadow effect, light effects or a linear gradient and radial gradient. 
description: svg filters, gaussian blur, drop shadow effect, svg drop shadow, svg light effects, color filters, svg gradients, svg linear gradient, svg radial gradient, svg code
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

{{% alert color="primary" %}}
Aspose.SVG offers <a href="https://products.aspose.app/svg/applications" target="_blank">**Free Online Applications**</a> to convert SVG and bitmap files, merge SVGs to sprite, image vectorizing, and more. Use our collection of applications to perform your SVG-related tasks and make your workflow seamlessly!
{{% /alert %}} 

This article discusses SVG filters that create blur, color and light effects. We consider how to write SVG code to create a linear or radial gradient. You will see how gradients can beautify any line, shape, or text in an SVG graphic.

## **What is an SVG Filter?**

SVG filters are widely used to add special effects to bitmaps or vector graphics. Filter effects are a way of a visual element’s treatment before displaying in the document. In other words, it is a set of operations to apply on an image can produce a wide variety of color and lighting effects, blurring, warping, noise and texture generation, etc. SVG filters are capable of creating complex effects in the browser and have the potential to be using in a variety of projects. They are supported by almost all modern browsers, including mobile ones.

Filter defines by `<filter>` element which sets within a `<defs>` element. It is never rendered itself and is conceptually described as the element that includes its children - filter primitives. The `<filter>` element has a set of attributes, here are some of them: **x, y, width, height, filterUnits, primitiveUnits**, [**core attributes, presentation attributes**](https://drafts.fxtf.org/filter-effects/#FilterProperty).


## **SVG Filters**

Each filter primitive makes a single graphical operation producing a visible result. The advantage of SVG filters is the ability to combine multiple types. The results obtained after applying one filter can be the source of the image for another filter.

Required attributes for filter primitive are **x, y, width,** and **height**. They set the area of the picture to which the filter will be applied. Each filter primitive can take one or two inputs and output only one result. The input data of the filter primitive is specified in the **in**  attribute. The default is **in**="SourceGraphic". The output of the operation is defined in the **result** attribute.

Each filter requires a source image to processes. Otherwise, the filter will have nothing to render and so not work. All the filter primitives define in the **[SVG Filter specification](https://drafts.fxtf.org/filter-effects/#FilterPrimitivesOverview)**.

## **Gaussian Blur**

The Gaussian blur function is obtained by blurring & smoothing an image using the Gaussian function. It can be considered as a filter that reduces image noise and minor details. Designers and photographers often apply Gaussian blur functions for different purposes: Gaussian blur can soften the image, it is useful for reducing chromatic aberration, it can hide a license plate or brand logo you don’t have permission to use, etc.

The `<feGaussianBlur>` filter creates a soft blur effect. It is a frequently used effect. The **stdDeviation** attribute specifies the *number* that characterizes the standard deviation for the blur operation. If two numbers are provided, the first *number* represents a standard deviation value along the x-axis of the coordinate system, the second one - on the y-axis.

Here is an example illustrates the various values of **stdDeviation** attribute ([gaussian-blur.svg](/svg/net/drawing-basics/filters-and-gradients/gaussian-blur.svg)):
```html {linenos=inline,linenostart=1}
<svg height="400" width="600" xmlns="https://www.w3.org/2000/svg">
    <defs>
        <filter id="f1" x="-20" y="-20" height="100" width="100">
            <feGaussianBlur in="SourceGraphic" stdDeviation="10" />
        </filter>
        <filter id="f2" x="-20" y="-20" height="100" width="100">
            <feGaussianBlur in="SourceGraphic" stdDeviation="10, 0" />
        </filter>
        <filter id="f3" x="-20" y="-20" height="100" width="100">
            <feGaussianBlur in="SourceGraphic" stdDeviation="0,10" />
        </filter>
    </defs>
    <g stroke="none" fill="#20B2AA">
        <ellipse cx="60" cy="80" rx="55" ry="35" />
        <ellipse cx="200" cy="80" rx="55" ry="35" filter="url(#f1)" />
        <ellipse cx="340" cy="80" rx="55" ry="35" filter="url(#f2)" />
        <ellipse cx="500" cy="80" rx="55" ry="35" filter="url(#f3)" />
    </g>
</svg>
```
![Four ellipses illustrate the Gaussian blur effect with the different stdDeviation values](gaussian-blur.png#center)

The blur, added around a shape, often makes output picture larger than source one. Need to use negative numbers for **x** and **y** to avoid clipping the graphics added by the filter. In the example above, we made this in lines 3, 6 and 9.

## **Drop Shadow Effect**

A typical example of the drop shadow effect is to add a 3D look to a shape or text. Also, a drop shadow effect can be used to make an image stand out.

The `<feOffset>` filter primitive is used to offset a layer in SVG. In addition to the **in** and **result** attributes, this primitive accepts two main attributes - **dx** and **dy**, which define the distance the layer is offset along the x and y axes, respectively.
The `<feBlend>` filter blends two objects; its **mode** attribute defines the blending mode.

Let's see how to create a drop shadow effect ([drop-shadow-effect.svg](/svg/net/drawing-basics/filters-and-gradients/drop-shadow-effect.svg)):

```html {linenos=inline,linenostart=1}
<svg height="200" width="200" xmlns="https://www.w3.org/2000/svg">
    <defs>
        <filter id="shadow" x="-20" y="-20" height="150" width="150">
            <feOffset result="offset" in="SourceAlpha" dx="10" dy="10" />
            <feGaussianBlur result="blur" in="offset" stdDeviation="10" />
            <feBlend in="SourceGraphic" in2="blur" mode="normal" />
        </filter>
    </defs>
    <ellipse cx="95" cy="90" rx="75" ry="55" fill="#20B2AA" filter="url(#shadow)" />
</svg>
```
![Drop Shadow Effect of the ellipse](drop-shadow-effect.png#center)

Thee filters are used to create drop shadow effect:

1.   `<feOffset>` takes `in="SourceAlpha"`, and shifts the result 10 px to the right and 10px to the bottom, and stores the result in the buffer as `"offset"`. Note, the alpha channel of the shape is used as input. The value `SourceAlpha` leads to a black-color result.

2.   `<feGaussianBlur>` takes `in="offset"`, applies a blur of 10, and stores the result in a temporary buffer named `"blur"`.

3. `<feBlend>` takes two inputs `in="SourceGraphic"` and `in2="blur"` then blends the `SourceGraphic` on top of the offset black blurred image.


![Drop shadow effect of the ellipse: step by step Illustration](steps-dse.png#center)

## **SVG Light Effects**

The lighting effect is making in SVG using a set of filters. Consider some of them: `<feDiffuseLighting>`, `<feSpecularLighting>`, and `<fePointLight>`. You can combine several filters, create and control the details for a lighting effect.

The `<fePointLight>` filter defines a light source which sets a point light effect. It can be used within the `<feDiffuseLighting>` or `<feSpecularLighting>` primitive as a child. Specific attributes **x**, **y**, and **z** indicate the position of the point light source. Both `<feDiffuseLighting>` and the `<feSpecularLighting>` filter light an image using its alpha channel as a bump map. The difference between them is the various calculations of the lighting model components.

Consider an example of a light effect ([light-effect.svg](/svg/net/drawing-basics/filters-and-gradients/light-effect.svg)):

```html {linenos=inline,linenostart=1}
<svg height="300" width="300" xmlns="https://www.w3.org/2000/svg">
    <defs>
        <filter id = "F1">
            <feGaussianBlur in = "SourceAlpha" stdDeviation = "4" result = "blur" />
            <feSpecularLighting result = "light" in = "blur" specularExponent = "25" lighting-color = "#bbbbbb">
                <fePointLight x = "80" y = "60" z = "200" />
            </feSpecularLighting>
            <feComposite in = "SourceGraphic" in2 = "light" operator = "arithmetic" k1 ="0" k2 ="1" k3 ="1" k4 ="0" />
        </filter>
    </defs>
    <g  fill = "INDIANRED" filter = "url(#F1)">
        <circle cx="100" cy="100" r="60" />
        <circle cx="100" cy="230" r="60" />
        <circle cx="230" cy="100" r="60" />
        <circle cx="230" cy="230" r="60" />
    </g>
</svg>
```
![The result of the lighting effect applying to four red circles](light_effect.png#center)

In this example, four SVG filters are applied to create the light effect:
1. `<feGaussianBlur>` takes input `SourceAlpha`, which is the alpha channel of the source image. The result is stored in a temporary buffer named `"blur"`.

2. Lighting is done with the `<feSpecularLighting>` and `<fePointLighting>`  filter effects. 
    `<feSpecularLighting>` uses buffer `"blur"` as a model of a surface elevation and generates a lighting effect from a point source that sets in the `<fePointLighting>`filter. The result is stored in buffer `"light"`.

3. The `<feComposite>` filter takes two inputs `in = "SourceGraphic" in2 = "light"` and performs they combination using the arithmetic compositing operation.   The output from the arithmetic operator for each result pixel is computed as:   result = k1*in1*in2 + k2*in1 + k3*in2 + k4

The following is shown one more example of SVG filter effects combining ([button.svg](/svg/net/drawing-basics/filters-and-gradients/button.svg)):
```html {linenos=inline,linenostart=1}
<svg height="200" width="200" xmlns="https://www.w3.org/2000/svg">
    <defs>
        <filter id="myF" x="-5" y="-5" height="100" width="150">
            <feGaussianBlur in="SourceAlpha" stdDeviation="5" result="blur" />
            <feOffset in="blur" dx="5" dy="5" result="offsetBlur" />
            <feSpecularLighting in="offsetBlur" surfaceScale="8" specularConstant="0.7" specularExponent="2" lighting-color="#bbbbbb" result="specOut">
                <fePointLight x="-100" y="-100" z="100" />
            </feSpecularLighting>
            <feComposite in="specOut" in2="SourceAlpha" operator="in" result="specOut" />
            <feComposite in="SourceGraphic" in2="specOut" operator="arithmetic" k1="1.5" k2="0.5" k3="1" k4="0" result="litPaint" />
            <feMerge>
                <feMergeNode in="offsetBlur" />
                <feMergeNode in="litPaint" />
            </feMerge>
        </filter>
    </defs>
    <ellipse cx="85" cy="70" rx="65" ry="45" fill="#20B2AA" filter="url(#myF)" />
    <g fill="#696969" font-size="25" font-family="arial">
        <text x="55" y="80">PUSH</text>
    </g>
</svg>
```
![The result of the lighting effect applying: the blue button with text "PUSH"](push.png#center)

## **Color Filters**

In SVG, you can create a wide variety of color effects that are supported in almost all modern browsers.  When it comes to color handling, `<feColorMatrix>` is the best option. It is a type of color filter that uses a matrix to affect the color values for each RGBA channel. The `<feComponentTransfer>` is one of the most powerful SVG filter primitives. It gives control over the individual RGBA channels of the image, allowing you to create Photoshop-like SVG effects; for example, it can be used to posterize images.

Consider the main color filters - `<feColorMatrix>` and `<feComponentTransfer>`. 

### **`<feColorMatrix>` filter primitive**

The `<feColorMatrix>` filter applies a matrix transformation to the RGBA channels of each pixel in the input image. As a result, a new set of color and alpha values is produced. In the common case, the ***matrix*** is written as an operation of the **type** attribute of the `<feColorMatrix>` filter. In the special cases of color matrices, the auxiliary operations of the **type** are used: ***saturate, hueRotate, luminanceToAlpha***. 

Let's see examples of the ***saturate*** operation use ([saturation.svg](/svg/net/drawing-basics/filters-and-gradients/saturation.svg)):
```html {linenos=inline,linenostart=1}
<svg width="640" height="480" viewbox="0 0 640 480" xmlns="https://www.w3.org/2000/svg">
    <defs>
        <filter id="myFilter">
            <feColorMatrix in="SourceGraphic" type="saturate" values="0"></feColorMatrix>
        </filter>
    </defs>
    <image filter="url(#myFilter)" href="https://docs.aspose.com/svg/net/drawing-basics/filters-and-gradients/park.jpg" width="100%" height="100%" />
</svg>
```
The following figure is a series of images with the various ***saturate*** values:

![A series of images with the various saturatе values](saturation.png#center)

The specific case of color matrices is image rotation along the **[color wheel](https://en.wikipedia.org/wiki/Color_wheel)**. The following example illustrates using the ***hueRotate*** operation.
```html {linenos=inline,linenostart=1}
<svg width="640" height="480" viewbox="0 0 640 480" xmlns="https://www.w3.org/2000/svg">
    <defs>
        <filter id="hueR">
            <feColorMatrix in="SourceGraphic" type="hueRotate" values="40"></feColorMatrix>
        </filter>
    </defs>
    <image filter="url(#hueR)" href="https://docs.aspose.com/svg/net/drawing-basics/filters-and-gradients/park.jpg" width="100%" height="100%" />
</svg>
```
The following figure is a series of images with the various ***hueRotate*** values:

![A series of images with the various hueRotate values](hue-rotate.png#center)

### **`<feComponentTransfer>` filter primitive**

The `<feComponentTransfer>` filter allows you to perform linear, tabular, discrete operations with image channels, as well as change the gamma of each channel (RGBA). It lets operations like brightness adjustment, contrast adjustment, and color balance.

Let's  look at an example:
```html {linenos=inline,linenostart=1}
<svg width="640" height="480" viewbox="0 0 640 480" xmlns="https://www.w3.org/2000/svg">
    <defs>
        <filter id="RGBA">
            <fecomponenttransfer>
                <feFuncR type="linear" slope="2.0" />
                <feFuncG type="linear" slope="1.7" />
                <feFuncB type="linear" slope="0.1" />
                <feFuncA type="identity" />
            </fecomponenttransfer>
        </filter>
    </defs>
    <image filter="url(#RGBA)" href="https://docs.aspose.com/svg/net/drawing-basics/filters-and-gradients/park.jpg" width="100%" height="100%" />
</svg>
```
![A photo that treated by filter id="hueR"](rgba.png#center)

The `<feComponentTransfer>` element allows modifying each of the R, G, B and A components present in a pixel. The RGBA components are also called transfer function elements: `<feFuncR>`, `<feFuncG>`, `<feFuncB>`, and `<feFuncA>`. 
In the **type** attribute, the type of function that allows modifying this component is determined. There are five function types: ***identity, table, discrete, linear***, and ***gamma***. More detailed information you find on the **[SVG Filter Effects](https://drafts.fxtf.org/filter-effects/)** page.

## **SVG Gradients**

 A gradient is a smooth color transition between points on a drawing surface. There are two types of gradients defined by the following elements: `<linearGradient>` and `<radialGradient>`.

The `<linearGradient>` or `<radialGradient>` element must be embedded within a `<defs>` tag to promote reusability. The **id** attribute specifies a unique name for the SVG gradient. Other elements inside the file can reference it. The gradient can be applied for the **fill** or **stroke** properties for shapes, text, etc.

### **Linear Gradient in SVG**

When talking about the SVG gradient, we have to define what a gradient vector is? The linear gradient vector connects starting and ending points onto which the gradient stops are mapped. The attributes **x1**, **y1, x2** and **y2** set the linear gradient vector. Their values can be either numbers or percentages.

The `<linearGradient>` has nested children `<stop>` elements that control the colors used in the gradient. Each color is specified with the  `<stop>` tag. An **offset** attribute of the `<stop>` element indicates where the gradient stop is placed. For linear gradients, it represents a location along the gradient vector ([linear-gradient.svg](/svg/net/drawing-basics/filters-and-gradients/linear-gradient.svg)).


```html {linenos=inline,linenostart=1}
<svg height="250" width="700" xmlns="https://www.w3.org/2000/svg">
	<defs>
		<linearGradient id="grad1" x1="0%" y1="0%" x2="100%" y2="0%">
			<stop offset="10%" style="stop-color:LIGHTSALMON" />
			<stop offset="50%" style="stop-color:TEAL" />
			<stop offset="90%" style="stop-color:LIGHTPINK" />
		</linearGradient>
	</defs>
    <ellipse cx="300" cy="170" rx="165" ry="55" fill="url(#grad1)" />
    <text x="10" y="85" font-family="Arial" stroke="grey" stroke-width="1" font-size="90" fill="url(#grad1)" >Linear Gradient</text>
</svg>
```
  ![Text and ellipse are filled by linear gradient](linear-gradient.png#center)

In the example above, the linear gradient `id="grad1"` is referenced by the `<text>` and `<ellipse>` elements in the **fill** attribute.  There are three `<stop>` nodes inside the linear gradient. In each of them, an **offset** attribute sets the position the SVG gradient gets a ***stop-color*** value.

### **Radial Gradient in SVG**

 A radial gradient is more difficult than a linear one. The colors change circularly rather than linearly in it. The attributes **cx, cy** and **r** define the outermost circle for the radial gradient: **cx** and **cy** mark the center of this circle. Their values specify as percentages of width and height of shape to fill. Both defaults to 50% if omitted. The **fx** and **fy** attributes define the innermost circle for the radial gradient. This is the point at which the SVG gradient «radiates».

In this example, the centers of the innermost and outermost border of the SVG gradient are the same ([radial-gradient.svg](/svg/net/drawing-basics/filters-and-gradients/radial-gradient.svg)).
```html {linenos=inline,linenostart=1}
<svg height="300" width="600" xmlns="https://www.w3.org/2000/svg">
    <defs>
        <radialGradient id="myRG" cx="0.5" cy="0.5" r="0.9" fx="0.5" fy="0.5" spreadMethod="pad">
            <stop offset="0%"   stop-color="BISQUE" />
            <stop offset="60%" stop-color="CADETBLUE" />
        </radialGradient>
    </defs>
    <ellipse cx="300" cy="170" rx="165" ry="55" fill="url(#myRG)" />
    <text x="10" y="85" font-family="Arial" stroke="grey" stroke-width="1" font-size="85" fill="url(#myRG)" >Radial Gradient</text>
</svg>
```

 ![Text and ellipse are filled by radial gradient](radial-gradient.png#center)

Let's see an example of the radial gradient, where the focal point (**fx**, **fy**) moved from the center of the object to position **fx**=25% and **fy**=25% ([radial-gradient1.svg](/svg/net/drawing-basics/filters-and-gradients/radial-gradient1.svg)):
```html {linenos=inline,linenostart=1}
<svg height="300" width="600" xmlns="https://www.w3.org/2000/svg">
    <defs>
        <radialGradient id="myRG" cx="0.5" cy="0.5" r="0.8" fx="25%" fy="25%" spreadMethod="pad">
            <stop offset="0%" stop-color="BISQUE" />
            <stop offset="30%" stop-color="SILVER" />
            <stop offset="60%" stop-color="BISQUE" />
            <stop offset="90%" stop-color="GREY" />
        </radialGradient>
    </defs>
    <ellipse cx="300" cy="170" rx="185" ry="65" fill="url(#myRG)" fill-opacity="1" />
    <text x="10" y="85" font-family="Arial" stroke="grey" stroke-width="1" font-size="85" fill="url(#myRG)">Radial Gradient</text>
</svg>
```
![Text and ellipse are filled by radial gradient](radial-gradient1.png#center)

Here we applied several color transitions and received an interesting effect that is well-expressed on the ellipse.

 