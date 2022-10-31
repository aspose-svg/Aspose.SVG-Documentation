---
title: Aspose.SVG for .NET 22.10 Release Notes
weight: 41
type: docs
url: /net/aspose-svg-for-net-22-10-release-notes/
---
{{% alert color="primary" %}}

This page contains release notes information for Aspose.SVG for .NET 22.10

{{% /alert %}}

## **Major Features**

As per the regular monthly update process of all APIs being offered by Aspose, we are honored to announce the October release of Aspose.SVG for .NET:

We have added a new SVGOptimizer tool to optimize SVG documents, which provides functionality to remove redundant and useless information and reduce the size of SVG path elements through vector graphics optimization. It also provides the possibility of flexible optimization control through the use of various options.


## **Public API changes:**

### **Added APIs:**

#### SVGOptimizer class

SVGOptimizer is a static class designed to optimize SVG documents. By optimization, we mean removing unused or invisible elements and their attributes, merging groups, and reducing the size of path segments.

```csharp
public static class SVGOptimizer
```

##### Methods

| Name | Description |
| --- | --- |
| static [Optimize](../../aspose.svg.toolkit.optimizers/svgoptimizer/optimize#optimize)(SVGDocument) | Optimizes [`SVGDocument`](../../aspose.svg/svgdocument) by applying a set of default optimization options. |
| static [Optimize](../../aspose.svg.toolkit.optimizers/svgoptimizer/optimize#optimize_1)(SVGDocument, SVGOptimizationOptions) | Optimizes [`SVGDocument`](../../aspose.svg/svgdocument) by applying a set of specified optimization options. |

#### SVGOptimizationOptions class

SVGOptimizationOptions is a class for storing options for optimizing SVG documents.

```csharp
public class SVGOptimizationOptions
```

##### Constructors

| Name | Description |
| --- | --- |
| [SVGOptimizationOptions](svgoptimizationoptions)() | Initializes a new instance of the [`SVGOptimizationOptions`](../svgoptimizationoptions) class. |

##### Properties

| Name | Description |
| --- | --- |
| [CollapseGroups](../../aspose.svg.toolkit.optimizers/svgoptimizationoptions/collapsegroups) { get; set; } | Gets or sets the option to collapse excess groups. It is 'true' by default. |
| [PathOptimizationOptions](../../aspose.svg.toolkit.optimizers/svgoptimizationoptions/pathoptimizationoptions) { get; set; } | Gets or sets the option [`SVGPathOptimizationOptions`](../svgpathoptimizationoptions). If this option is null, then path element optimization will not be performed. |
| [RemoveDescriptions](../../aspose.svg.toolkit.optimizers/svgoptimizationoptions/removedescriptions) { get; set; } | Gets or sets the option to remove only editors content or empty elements. It is 'true' by default. |
| [RemoveEmptyAttributes](../../aspose.svg.toolkit.optimizers/svgoptimizationoptions/removeemptyattributes) { get; set; } | Gets or sets the option to remove attributes with empty values. It is 'true' by default. |
| [RemoveEmptyContainers](../../aspose.svg.toolkit.optimizers/svgoptimizationoptions/removeemptycontainers) { get; set; } | Gets or sets the option to remove empty containers. It is 'true' by default. |
| [RemoveEmptyText](../../aspose.svg.toolkit.optimizers/svgoptimizationoptions/removeemptytext) { get; set; } | Gets or sets the option to remove empty Text elements. It is 'true' by default. |
| [RemoveHiddenElements](../../aspose.svg.toolkit.optimizers/svgoptimizationoptions/removehiddenelements) { get; set; } | Gets or sets the option to remove elements that are not visible during rendering. It is 'true' by default. |
| [RemoveMetadata](../../aspose.svg.toolkit.optimizers/svgoptimizationoptions/removemetadata) { get; set; } | Gets or sets the option to remove metadata. It is 'true' by default. |
| [RemoveUnusedDefs](../../aspose.svg.toolkit.optimizers/svgoptimizationoptions/removeunuseddefs) { get; set; } | Gets of sets the option to remove the content of defs that are not displayed directly without identifiers. It is 'true' by default. |
| [RemoveUnusedNamespaces](../../aspose.svg.toolkit.optimizers/svgoptimizationoptions/removeunusednamespaces) { get; set; } | Gets or sets the option to remove the declaration of unused namespaces from the SVG element that are not used in elements or attributes. It is 'true' by default. |

#### SVGPathOptimizationOptions class

SVGPathOptimizationOptions is a class for storing options for optimizing segments of SVG path elements.

```csharp
public class SVGPathOptimizationOptions
```

##### Constructors

| Name | Description |
| --- | --- |
| [SVGPathOptimizationOptions](svgpathoptimizationoptions)() | Initializes a new instance of the [`SVGPathOptimizationOptions`](../svgpathoptimizationoptions) class. |

##### Properties

| Name | Description |
| --- | --- |
| [ApplyTransforms](../../aspose.svg.toolkit.optimizers/svgpathoptimizationoptions/applytransforms) { get; set; } | Gets or sets the option to apply transformations to the Path segments. It is 'false' by default. |
| [ArcBuildingThreshold](../../aspose.svg.toolkit.optimizers/svgpathoptimizationoptions/arcbuildingthreshold) { get; set; } | Gets or sets the parameter value used as the threshold error for replacing Bezier segments with arc segments. It is '2.5' by default. |
| [ArcBuildingTolerance](../../aspose.svg.toolkit.optimizers/svgpathoptimizationoptions/arcbuildingtolerance) { get; set; } | Gets or sets the parameter value used as the percentage of radius for replacing Bezier segments with arc segments. It is '0.5' by default. |
| [FloatPrecision](../../aspose.svg.toolkit.optimizers/svgpathoptimizationoptions/floatprecision) { get; set; } | Gets or sets the option to round a float-precision floating-point value to a specified number of fractional digits. It is '3' by default. |
| [RemoveSpaceAfterFlags](../../aspose.svg.toolkit.optimizers/svgpathoptimizationoptions/removespaceafterflags) { get; set; } | Gets or sets the option to remove extra space after 'arcto' command flags. It is 'false' by default. |

