---
title: How to Optimize SVG - C# Examples
linktitle: How to Optimize SVG Documents
type: docs
weight: 70
aliases: /net/how-to-work-with-aspose-svg-api/how-to-optimize-svg/
lastmod: 2022-12-09
description: You will learn how to optimize SVG and reduce the size of SVG files.
keywords: optimize svg, svg optimizer, svg optimization options, clean svg
---

<link href="./../../style.css" rel="stylesheet" type="text/css" />

## **Why Optimize SVG?**

The SVG format is very flexible, but it also has some drawbacks. One of them is that the format is not very efficient. This means that SVG images can be slow to load, and they can also be slow to render.
This is a problem for web developers because it can affect the user experience. It can also affect the SEO of a website because search engines can penalize slow websites.
Optimizing SVGs for performance reasons is a very common task. Aspose.SVG for .NET API provides the [SVGOptimizer](https://reference.aspose.com/svg/net/aspose.svg.toolkit.optimizers/svgoptimizer/) class to help with that task. This tool compresses the SVG document by applying various heuristics to optimize paths and remove unused or useless elements and attributes.

{{% alert color="primary" %}} 
Aspose.SVG offers Free Online [**SVG Optimizer.**](https://products.aspose.app/svg/svg-optimizer) Optimize SVG files to make your website faster and better! You can use a set of options that allow you to flexibly control the compression and simplification level and achieve the desired result. With the SVG Optimizer, you will optimize SVG easily within minutes. Try our forceful application for free now!
{{% /alert %}} 

<!-- <a href="(https://products.aspose.app/svg/svg-optimizer" target="_blank">![Text "Banner SVG optimizer"](svg-sprite-creator.png#center)</a> -->

## **Optimize SVG in C#**

To optimize SVG documents, use the following code snippet:

```c#
using Aspose.Svg;
using System.IO;
using Aspose.Svg.Toolkit.Optimizers;
...   
	
	// Initialize an SVG document from a file
    using (var document = new SVGDocument(Path.Combine(DataDir, "source.svg")))
    {
        var options = new SVGOptimizationOptions();
        // Set float precision
        options.PathOptimizationOptions.FloatPrecision = 2;
        // Optimize document
        SVGOptimizer.Optimize(document, options);
        // Save document to a file
        document.Save(Path.Combine(DataDir, "optimized.svg"));
    }

```
The current section describes supported scenarios of SVG file optimization. Let's look at the steps to optimize SVG.

1. Initialize an SVG document from a file using one of the [SVGDocument()](https://reference.aspose.com/svg/net/aspose.svg/svgdocument/svgdocument/) constructors.
2. Create a new SVGOptimizationOptions object. Use the [SVGOptimizationOptions()](https://reference.aspose.com/svg/net/aspose.svg.toolkit.optimizers/svgoptimizationoptions/svgoptimizationoptions/) constructor.
3. Use the [PathOptimizationOptions](https://reference.aspose.com/svg/net/aspose.svg.toolkit.optimizers/svgoptimizationoptions/pathoptimizationoptions/) property of the SVGOptimizationOptions class to optimize SVG paths.
4. Call the [Optimize()](https://reference.aspose.com/svg/net/aspose.svg.toolkit.optimizers/svgoptimizer/optimize/#optimize) method to optimize SVG document.
5. Save the optimized SVG document to a file.

## **SVG Optimization Options**

Aspose.SVG for .NET API offers a set of optimization options that allow to reduce SVG code by removing empty elements, attributes with empty values, unused stroke and fill attributes, elements that are not visible during rendering, empty containers, empty 'Text' elements, line indents and breaks, and more. <br>
Aspose.SVG C# library supports the following SVG elements optimization options [SVGOptimizationOptions](https://reference.aspose.com/svg/net/aspose.svg.toolkit.optimizers/svgoptimizationoptions/):
<div class="row">
	<div class="col-md-3">
		<h3>Name</h3>				
	</div>
	<div class="col-md-2">
		<h3>Description</h3>	
	</div>	
	<div class="col-md-4">
		<h3>Original SVG</h3>
	</div>
	<div class="col-md-3">
		<h3>Optimized SVG</h3>
	</div>	
</div>
<div class="row">
    <div class="col-md-3">
	   <a href="https://reference.aspose.com/svg/net/aspose.svg.toolkit.optimizers/svgoptimizationoptions/collapsegroups/">CollapseGroups</a>
    </div>
    <div class="col-md-2">Collapses excess groups</div>
    <div class="col-md-4"><pre><span>{{< highlight svg "hl_inline=true" >}}
<svg xmlns="http://www.w3.org/2000/svg">
    <g>
        <g attr1="val1">
           <path d="..."/>
        </g>    
    </g>
</svg>
{{< /highlight >}}</span></pre>
    </div>	
    <div class="col-md-3"><pre><span>{{< highlight svg "hl_inline=true" >}}
<svg xmlns="http://www.w3.org/2000/svg">
    <path attr1="val1" d="..."/>
</svg>
{{< /highlight >}}</span></pre>
     </div>	
</div>	
<div class="row">
    <div class="col-md-3">
	   <a href="https://reference.aspose.com/svg/net/aspose.svg.toolkit.optimizers/svgoptimizationoptions/removedescriptions/">RemoveDescriptions</a>
    </div>
    <div class="col-md-2">Removes only editors content or empty elements</div>
    <div class="col-md-4"><pre><span>{{< highlight svg "hl_inline=true" >}}
<svg xmlns="http://www.w3.org/2000/svg">
    <desc>Created with ...</desc>
    <desc>Custom description</desc>
    <path d="...">
</svg>
{{< /highlight >}}</span></pre>
    </div>	
    <div class="col-md-3"><pre><span>{{< highlight svg "hl_inline=true" >}}
<svg xmlns="http://www.w3.org/2000/svg">
    <desc>Custom description</desc>
    <path d="...">
</svg>
{{< /highlight >}}</span></pre>
     </div>	
</div>
<div class="row">
    <div class="col-md-3">
	    <a href="https://reference.aspose.com/svg/net/aspose.svg.toolkit.optimizers/svgoptimizationoptions/removeemptyattributes/">RemoveEmptyAttributes</a>
    </div>	
    <div class="col-md-2">Removes attributes with empty values</div>	
    <div class="col-md-4"><pre><span>{{< highlight svg "hl_inline=true" >}}
<svg xmlns="http://www.w3.org/2000/svg">
    <path attr1=" attr2 =" d="M..."/>
</svg>"
{{< /highlight >}}</span></pre>
    </div>	
    <div class="col-md-3"><pre><span>{{< highlight svg "hl_inline=true" >}}
<svg xmlns="http://www.w3.org/2000/svg">
    <path d="M..."/>
</svg>"
{{< /highlight >}}</span></pre>
    </div>	
</div>
<div class="row">
    <div class="col-md-3">
	    <a href="https://reference.aspose.com/svg/net/aspose.svg.toolkit.optimizers/svgoptimizationoptions/removeemptycontainers/">RemoveEmptyContainers</a>
    </div>	
    <div class="col-md-2">Removes empty containers</div>	
    <div class="col-md-4"><pre><span>{{< highlight svg "hl_inline=true" >}}
<svg xmlns="http://www.w3.org/2000/svg">
    <pattern/>
    <g>
        <marker>
            <a/>
        </marker>
    </g>
    <path d="M..."/>
</svg>
{{< /highlight >}}</span></pre>
    </div>	
    <div class="col-md-3"><pre><span>{{< highlight svg "hl_inline=true" >}}
<svg xmlns="http://www.w3.org/2000/svg">
    <path d="M..."/>
</svg>
{{< /highlight >}}</span></pre>
    </div>	
</div>
<div class="row">
    <div class="col-md-3">
	    <a href="https://reference.aspose.com/svg/net/aspose.svg.toolkit.optimizers/svgoptimizationoptions/removeemptytext/">RemoveEmptyText</a>
    </div>	
    <div class="col-md-2">Removes empty 'Text' elements</div>	
    <div class="col-md-4"><pre><span>{{< highlight svg "hl_inline=true" >}}
<svg xmlns="http://www.w3.org/2000/svg">
    <g>
        <text></text>
        <tspan></tspan>
        <tref>...</tref>
    </g>
</svg>
{{< /highlight >}}</span></pre>
    </div>	
    <div class="col-md-3"><pre><span>{{< highlight svg "hl_inline=true" >}}
<svg xmlns="http://www.w3.org/2000/svg">
    <g></g>
</svg>
{{< /highlight >}}</span></pre>
    </div>	
</div>
<div class="row">
    <div class="col-md-3">
	    <a href="https://reference.aspose.com/svg/net/aspose.svg.toolkit.optimizers/svgoptimizationoptions/removehiddenelements/">RemoveHiddenElements</a>
    </div>	
    <div class="col-md-2">Removes elements that are not visible during rendering</div>	
    <div class="col-md-4"><pre><span>{{< highlight svg "hl_inline=true" >}}
<svg xmlns="http://www.w3.org/2000/svg">
    <style>
      .a { display: block; opacity: 0.5; }
    </style>
    <g>
        <rect display="none"  width="1" height="1" />
        <rect display="none" class="a" width="1" height="1" />
        <rect opacity="0"  width="1" height="1" />
        <rect opacity="0" class="a" width="1" height="1" />
        <rect x="1" y="1" width="0" height="1" fill="blue" />
        <g visibility="hidden">
             <rect x="1" y="1" width="1" height="1" fill="red" />
        </g>
        <circle cx="10" cy="10" r="0">
        </circle>
        <ellipse rx="0"/>
        <image width="0"/>
        <path d="M 10 10 L 0"/>
    </g>
</svg>
{{< /highlight >}}</span></pre>
    </div>	
    <div class="col-md-3"><pre><span>{{< highlight svg "hl_inline=true" >}}
<svg xmlns="http://www.w3.org/2000/svg">
    <style>.a { display: block; opacity: 0.5; }</style>
    <g>
        <rect display="none" class="a" width="1" height="1"/>
        <rect opacity="0" class="a" width="1" height="1"/>
    </g>
</svg>
{{< /highlight >}}</span></pre>
    </div>	
</div>
<div class="row">
    <div class="col-md-3">
	    <a href="https://reference.aspose.com/svg/net/aspose.svg.toolkit.optimizers/svgoptimizationoptions/removemetadata/">RemoveMetadata</a>
    </div>	
    <div class="col-md-2">Removes metadata</div>	
    <div class="col-md-4"><pre><span>{{< highlight svg "hl_inline=true" >}}
<svg xmlns="http://www.w3.org/2000/svg">
    <metadata>...</metadata>
    <path d="..."/>
</svg>
{{< /highlight >}}</span></pre>
    </div>	
    <div class="col-md-3"><pre><span>{{< highlight svg "hl_inline=true" >}}
<svg xmlns="http://www.w3.org/2000/svg">
    <path d="..."/>
</svg>
{{< /highlight >}}</span></pre>
    </div>	
</div>
<div class="row">
    <div class="col-md-3">
	    <a href="https://reference.aspose.com/svg/net/aspose.svg.toolkit.optimizers/svgoptimizationoptions/removeunusednamespaces/">RemoveUnusedNamespaces</a>
    </div>	
    <div class="col-md-2">Removes the declaration of unused namespaces from the SVG element that are not used in elements or attributes</div>	
    <div class="col-md-4"><pre><span>{{< highlight svg "hl_inline=true" >}}
<svg xmlns="http://www.w3.org/2000/svg" xmlns:test="http://test1.com/" xmlns:test2="http://test2.com/">
    <g test:attr="val">
        <g>
            test
        </g>
    </g>
</svg>
{{< /highlight >}}</span></pre>
    </div>	
    <div class="col-md-3"><pre><span>{{< highlight svg "hl_inline=true" >}}
<svg xmlns="http://www.w3.org/2000/svg" xmlns:test="http://test1.com/">
    <g test:attr="val">
        <g>
            test
        </g>
    </g>
</svg>
{{< /highlight >}}</span></pre>
    </div>	
</div>
<div class="row">
    <div class="col-md-3">
	    <a href="https://reference.aspose.com/svg/net/aspose.svg.toolkit.optimizers/svgoptimizationoptions/removeunuseddefs/">RemoveUnusedDefs</a>
    </div>	
    <div class="col-md-2">Removes the content of defs that are not displayed directly without identifiers</div>	
    <div class="col-md-4"><pre><span>{{< highlight svg "hl_inline=true" >}}
<svg xmlns="http://www.w3.org/2000/svg">
    <defs>
        <path d="M..."/>
        <g>
            <path d="M..." id="test"/>
        </g>
    </defs>
</svg>
{{< /highlight >}}</span></pre>
    </div>	
    <div class="col-md-3"><pre><span>{{< highlight svg "hl_inline=true" >}}
<svg xmlns="http://www.w3.org/2000/svg">
    <defs>
        <path d="M..." id="test"/>
    </defs>
</svg>
{{< /highlight >}}</span></pre>
    </div>	
</div>
<div class="row">
    <div class="col-md-3">
	    <a href="https://reference.aspose.com/svg/net/aspose.svg.toolkit.optimizers/svgoptimizationoptions/removeuselessstrokeandfill/">RemoveUselessStrokeAndFill</a>
    </div>	
    <div class="col-md-2">Removes unused stroke and fill attributes</div>	
    <div class="col-md-4"><pre><span>{{< highlight svg "hl_inline=true" >}}
<svg xmlns="http://www.w3.org/2000/svg">
    <defs>
        <g id="test">
            <rect stroke-dashoffset="5" width="10" height="10"/>
        </g>
    </defs>
    <circle fill="red" stroke-width="6" stroke-dashoffset="5" cx="6" cy="6" r="5"/>
    <circle fill="red" stroke="#000" stroke-width="6" stroke-dashoffset="5" stroke-opacity="0" cx="6" cy="6" r="5"/>
    <circle fill="red" stroke="#000" stroke-width="0" stroke-dashoffset="5" cx="6" cy="6" r="5"/>
    <circle fill="red" stroke="#000" stroke-width="6" stroke-dashoffset="5" cx="6" cy="6" r="5"/>
    <g stroke="#000" stroke-width="6">
        <circle fill="red" stroke="red" stroke-width="0" stroke-dashoffset="5" cx="6" cy="6" r="5"/>
        <circle fill="red" stroke-dashoffset="5" cx="6" cy="6" r="5"/>
    </g>
    <g stroke="#000">
        <circle fill="red" stroke-width="0" stroke-dashoffset="5" cx="6" cy="6" r="5"/>
        <circle fill="red" stroke="none" stroke-dashoffset="5" cx="6" cy="6" r="5"/>
    </g>
</svg>
{{< /highlight >}}</span></pre>
    </div>	
    <div class="col-md-3"><pre><span>{{< highlight svg "hl_inline=true" >}}
<svg xmlns="http://www.w3.org/2000/svg">
    <defs>
        <g id="test">
            <rect stroke-dashoffset="5" width="10" height="10"/>
        </g>
    </defs>
    <circle fill="red" cx="6" cy="6" r="5"/>
    <circle fill="red" cx="6" cy="6" r="5"/>
    <circle fill="red" cx="6" cy="6" r="5"/>
    <circle fill="red" stroke="#000" stroke-width="6" stroke-dashoffset="5" cx="6" cy="6" r="5"/>
    <g stroke="#000" stroke-width="6">
        <circle fill="red" cx="6" cy="6" r="5" stroke="none"/>
        <circle fill="red" stroke-dashoffset="5" cx="6" cy="6" r="5"/>
    </g>
    <g stroke="#000">
        <circle fill="red" cx="6" cy="6" r="5" stroke="none"/>
        <circle fill="red" cx="6" cy="6" r="5" stroke="none"/>
    </g>
</svg>
{{< /highlight >}}</span></pre>
    </div>	
</div>
<div class="row">
    <div class="col-md-3">
	    <a href="https://reference.aspose.com/svg/net/aspose.svg.toolkit.optimizers/svgoptimizationoptions/cleanlistofvalues/">CleanListOfValues</a>
    </div>	
    <div class="col-md-2">Rounds to 3 decimal places of list numeric values in attributes</div>	
    <div class="col-md-4"><pre><span>{{< highlight svg "hl_inline=true" >}}
<svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 500.2132 500.213823642" enable-background="new 0 0 500.224551535 500.213262">
    test
</svg>
{{< /highlight >}}</span></pre>
    </div>	
    <div class="col-md-3"><pre><span>{{< highlight svg "hl_inline=true" >}}
<svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 500.213 500.214" enable-background="new 0 0 500.225 500.213">
    test
</svg>
{{< /highlight >}}</span></pre>
    </div>	
</div>
<div class="row">
    <div class="col-md-3">
	    <a href="https://reference.aspose.com/svg/net/aspose.svg.toolkit.optimizers/svgoptimizationoptions/removeindentsandlinebreaks/">RemoveIndentsAndLineBreaks</a>
    </div>	
    <div class="col-md-2">Removes line indents and breaks</div>	
    <div class="col-md-4"><pre><span>{{< highlight svg "hl_inline=true" >}}
<svg xmlns="http://www.w3.org/2000/svg">
    <g>
        <ellipse rx="1"/>
        <ellipse ry="1"/>
    </g>
</svg>
{{< /highlight >}}</span></pre>
    </div>	
    <div class="col-md-3"><pre><span>{{< highlight svg "hl_inline=true" >}}
<svg xmlns="http://www.w3.org/2000/svg"><g><ellipse rx="1"/><ellipse ry="1"/></g></svg>
{{< /highlight >}}</span></pre>
    </div>	
</div>

## **Path Optimization Options**

[SVGOptimizationOptions](https://reference.aspose.com/svg/net/aspose.svg.toolkit.optimizers/svgoptimizationoptions/) contains [PathOptimizationOptions](https://reference.aspose.com/svg/net/aspose.svg.toolkit.optimizers/svgpathoptimizationoptions/) which supports next optimization options:
<div class="row">
	<div class="col-md-3">
		<h3>Name</h3>				
	</div>
	<div class="col-md-2">
		<h3>Description</h3>	
	</div>		
	<div class="col-md-4">
		<h3>Original path</h3>	
	</div>
	<div class="col-md-3">
		<h3>Optimized path</h3>
	</div>	
</div>
<div class="row">
    <div class="col-md-3">
	   <a href="https://reference.aspose.com/svg/net/aspose.svg.toolkit.optimizers/svgpathoptimizationoptions/applytransforms/">ApplyTransforms</a>
    </div>
    <div class="col-md-2">Apples transformations to the Path segments</div>   	
    <div class="col-md-4">{{< highlight svg "hl_inline=true" >}}
<path d="M32 4a4 4 0 0 0-4-4H8a4 4 0 0 1-4 4v28a4 4 0 0 1 4 4h20a4 4 0 0 0 4-4V4z" fill="#888" transform="matrix(1 0 0 -1 0 36)"/>
{{< /highlight >}}
    </div>	
    <div class="col-md-3">{{< highlight svg "hl_inline=true" >}}
<path d="M32 32a4 4 0 0 1-4 4H8a4 4 0 0 0-4-4V4a4 4 0 0 0 4-4h20a4 4 0 0 1 4 4v28z" fill="#888"/>
{{< /highlight >}}
     </div>	
</div>	
<div class="row">
    <div class="col-md-3">
	   <a href="https://reference.aspose.com/svg/net/aspose.svg.toolkit.optimizers/svgpathoptimizationoptions/arcbuildingthreshold/">ArcBuildingThreshold</a>
    </div>	
    <div class="col-md-2">Sets the threshold error for replacing Bezier segments with arc segments</div>	
    <div class="col-md-4">{{< highlight svg "hl_inline=true" >}}
    <path d="M.49 8.8c-.3-.75-.44-1.55-.44-2.35 0-3.54 2.88-6.43 6.43-6.43 3.53 0 6.42 2.88 6.42 6.43 0 .8-.15 1.6-.43 2.35"/>
{{< /highlight >}}
    </div>	
    <div class="col-md-3"><div>ArcBuildingThreshold = 1</div>{{< highlight svg "hl_inline=true" >}}
<path d="M.49 8.8C.19 8.05.05 7.25.05 6.45.05 2.91 2.93.02 6.48.02c3.53 0 6.42 2.88 6.42 6.43 0 .8-.15 1.6-.43 2.35"/>
{{< /highlight >}}
<div>ArcBuildingThreshold = 4</div>{{< highlight svg "hl_inline=true" >}}
<path d="M.49 8.8A6.438 6.438 0 0 1 6.48.02c3.53 0 6.42 2.88 6.42 6.43 0 .8-.15 1.6-.43 2.35"/>
{{< /highlight >}}
     </div>	
</div>	
<div class="row">
    <div class="col-md-3">
	   <a href="https://reference.aspose.com/svg/net/aspose.svg.toolkit.optimizers/svgpathoptimizationoptions/arcbuildingtolerance/">ArcBuildingTolerance</a>
    </div>	
    <div class="col-md-2">Sets the percentage of radius for replacing Bezier segments with arc segments</div>	
    <div class="col-md-4">{{< highlight svg "hl_inline=true" >}}
<path d="M41.008 0.102c1.891 0.387 3.393 1.841 3.849 3.705"/>
{{< /highlight >}}
    </div>	
    <div class="col-md-3"><div>ArcBuildingTolerance = 0</div>{{< highlight svg "hl_inline=true" >}}
<path d="M41.008.102c1.89.387 3.393 1.84 3.85 3.705"/>
{{< /highlight >}}
<div>ArcBuildingTolerance = 0.5f</div>{{< highlight svg "hl_inline=true" >}}
<path d="M41.008.102a5.006 5.006 0 0 1 3.85 3.705"/>
{{< /highlight >}}
     </div>	
</div>	
<div class="row">
    <div class="col-md-3">
	   <a href="https://reference.aspose.com/svg/net/aspose.svg.toolkit.optimizers/svgpathoptimizationoptions/floatprecision/">FloatPrecision</a>
    </div>	
    <div class="col-md-2">Sets the float-precision floating-point value to a specified number of fractional digits</div>	
    <div class="col-md-4">{{< highlight svg "hl_inline=true" >}}
<path d="M33.02783,1.965459 C33.097408,2.035034 38.04136,6.978988 38.04136,6.978988 C38.04136,6.978988 38.00943,4.03467 38.00943,4.03467 L34,0.02523956 L34,0 L13,0 L13,2 L33.06237,2 Z"></path>
{{< /highlight >}}
    </div>	
    <div class="col-md-3"><div>FloatPrecision = 2</div>{{< highlight svg "hl_inline=true" >}}
<path d="m33.03 1.97 5.01 5-.03-2.94-4.01-4V0H13v2h20.06z"/>
{{< /highlight >}}
<div>FloatPrecision = 3</div>{{< highlight svg "hl_inline=true" >}}
<path d="M33.028 1.965 38.04 6.98l-.03-2.945L34 .025V0H13v2h20.062z"/>
{{< /highlight >}}
     </div>	
</div>	
<div class="row">
    <div class="col-md-3">
	   <a href="https://reference.aspose.com/svg/net/aspose.svg.toolkit.optimizers/svgpathoptimizationoptions/removespaceafterflags/">RemoveSpaceAfterFlags</a>
    </div>	
    <div class="col-md-2">Removes extra space after ‘arcto’ command flags</div>	
    <div class="col-md-4">{{< highlight svg "hl_inline=true" >}}
<path d="m100 200 200 200H100V300c0-200 150-200 150-100s150 100 150 0q0-150 200 100t400 0a150 150 0 1 0 150-150z"/>
{{< /highlight >}}
    </div>	
    <div class="col-md-3">{{< highlight svg "hl_inline=true" >}}
<path d="m100 200 200 200H100V300c0-200 150-200 150-100s150 100 150 0q0-150 200 100t400 0a150 150 0 10150-150z"/>
{{< /highlight >}}
     </div>	
</div>	

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub.**](https://github.com/aspose-svg/Aspose.SVG-Documentation) About downloading from GitHub and running examples, you find out from the [**How to Run the Examples**](https://docs.aspose.com/svg/net/how-to-run-the-tests/) section.
{{% /alert %}} 
