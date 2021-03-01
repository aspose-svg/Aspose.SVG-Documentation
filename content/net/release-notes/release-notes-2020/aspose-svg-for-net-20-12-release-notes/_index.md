---
title: Aspose.SVG for .NET 20.12 Release Notes
type: docs
weight: 20
url: /net/aspose-svg-for-net-20-12-release-notes/
---

{{% alert color="primary" %}}

This page contains release notes information for Aspose.SVG for .NET 20.12

{{% /alert %}}

## **Major Features**

As per the regular monthly update process of all APIs being offered by Aspose, we are honored to announce the November release of Aspose.SVG for NET.
* We have added support for rendering SVG text with **stroke-dasharray**, **stroke-linecap** parameters. 
* The CSS serialization algorithm has been updated according to the latest SVG specification.

## **Public API changes:**
No Changes

### **Added APIs:**
```c#
namespace Aspose.Svg.Dom.Css
{
    public abstract class CSSPrimitiveValue : CSSValue
    {
        /// <summary>
        /// The value is a percentage of the full viewport width.
        /// </summary>
        public const ushort CSS_VW = 31;
        /// <summary>
        /// The value is a percentage of the full viewport height.
        /// </summary>
        public const ushort CSS_VH = 32;
        /// <summary>
        /// The value is a percentage of the viewport width or height, whichever is smaller.
        /// </summary>
        public const ushort CSS_VMIN = 33;
        /// <summary>
        /// The value is a percentage of the viewport width or height, whichever is larger.
        /// </summary>
        public const ushort CSS_VMAX = 34;
    }
}
```

### **Changed APIs:**
No Changes

### **Removed APIs:**
No Changes
