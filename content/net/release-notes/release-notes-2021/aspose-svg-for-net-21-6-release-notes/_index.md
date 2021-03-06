---
title: Aspose.SVG for .NET 21.6 Release Notes
type: docs
weight: 45
url: /net/aspose-svg-for-net-21-6-release-notes/
---

{{% alert color="primary" %}}

This page contains release notes information for Aspose.SVG for .NET 21.6

{{% /alert %}}

## **Major Features**

As per the regular monthly update process of all APIs being offered by Aspose, we are honored to announce the June release of Aspose.SVG for .NET:

- fixed an issue with calculating bounding boxes for rotated objects;
- added support for applaing restrictions to URLs of handled pages and resources such as css, js, images etc...;
- removed absolete properties.

## **Public API changes:**

### **Added APIs:**

Two new options were added to [ResourceHandlingOptions](https://apireference.aspose.com/svg/net/aspose.svg.saving/resourcehandlingoptions) class:

- [PageUrlRestriction](https://apireference.aspose.com/svg/net/aspose.svg.saving/resourcehandlingoptions/properties/pageurlrestriction);
- [ResourceUrlRestriction](https://apireference.aspose.com/svg/net/aspose.svg.saving/resourcehandlingoptions/properties/resourceurlrestriction).

A new method [Dispose](https://apireference.aspose.com/svg/net/aspose.svg.dom/eventtarget/methods/dispose) was added to class [SVGGeometryElement](https://apireference.aspose.com/svg/net/aspose.svg/svggeometryelement).

### **Changed APIs:**

No Changes

### **Removed APIs:**
- the obsolete property AdjustToWidestPage was removed from [PageSetup](https://apireference.aspose.com/svg/net/aspose.svg.rendering/pagesetup) class;
- the property UrlRestriction was removed from [ResourceHandlingOptions](https://apireference.aspose.com/svg/net/aspose.svg.saving/resourcehandlingoptions) class.
    