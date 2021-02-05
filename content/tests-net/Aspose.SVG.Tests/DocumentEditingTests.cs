using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;
using Aspose.Svg.Paths;
using System.IO;
using Aspose.Svg.Dom;
using Aspose.Svg.DataTypes;
using Aspose.Svg.Filters;

namespace Aspose.Svg.Tests
{
    public class DocumentEditingTests : TestsBase
    {
        public DocumentEditingTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("editing");
        }

        [Fact(DisplayName = "SVG Basic Shapes editing")]
        public void SVGBasicShapesTest()
        {
            // Set SVG Namespace Url
            string SvgNamespace = "http://www.w3.org/2000/svg";

            string documentPath = Path.Combine(DataDir, "basic-shapes.svg");

            using (var document = new SVGDocument(documentPath))
            {
                // Get root svg element of the document
                var svgElement = document.RootElement;

                // Create a circle element
                var circleElement = (SVGCircleElement)document.CreateElementNS(SvgNamespace, "circle");
                circleElement.Cx.BaseVal.Value = 100F;
                circleElement.Cy.BaseVal.Value = 100F;
                circleElement.R.BaseVal.Value = 50F;
                circleElement.SetAttribute("fill", "Salmon");

                // Add the circle element as the first child to svg element
                svgElement.InsertBefore(circleElement, svgElement.FirstChild);

                // Create a polyline element
                var polylineElement = (SVGPolylineElement)document.CreateElementNS(SvgNamespace, "polyline");
                polylineElement.SetAttribute("points", "270, 240 290, 220 310, 240");
                polylineElement.SetAttribute("stroke", "grey");
                polylineElement.SetAttribute("stroke-width", "5");
                polylineElement.SetAttribute("fill", "none");

                // Add the polyline element to children of the svg element
                svgElement.AppendChild(polylineElement);

                // Set stroke attributer for all circle and ellipse elements
                foreach (Element element in svgElement.Children)
                {
                    if (element is SVGCircleElement || element is SVGEllipseElement)
                    {
                        element.SetAttribute("stroke-width", "6");
                        element.SetAttribute("stroke", "#C8102E");
                    }
                }
                // Save the document
                document.Save(Path.Combine(OutputDir, "basic-shapes_out.svg"));                
                
                Assert.True(document.QuerySelectorAll("ellipse").Length > 0);
            }
        }

        [Fact(DisplayName = "SVG path data editing")]
        public void SVGPathDataEditingTest()
        {
            // Set SVG Namespace Url
            string SvgNamespace = "http://www.w3.org/2000/svg";

            using (var document = new SVGDocument())
            {
                var svgElement = document.RootElement;

                // Create "path" element
                var pathElement = (SVGPathElement)document.CreateElementNS(SvgNamespace, "path");

                // Set "d" attribute parameters 
                pathElement.SetAttribute("d", "M 10 200 Q 25 110 180 200 T 300 250 T 420 250 T 490 150");

                // SVG path data egiting	
                foreach (SVGPathSeg pathSeg in pathElement.PathSegList)
                {
                    // Editing T commands parameters
                    if (pathSeg is SVGPathSegCurvetoQuadraticSmoothAbs)
                    {
                        SVGPathSegCurvetoQuadraticSmoothAbs pathSegCurvetoQuadraticSmoothAbs = pathSeg as SVGPathSegCurvetoQuadraticSmoothAbs;

                        pathSegCurvetoQuadraticSmoothAbs.X -= 60;
                        pathSegCurvetoQuadraticSmoothAbs.Y -= 65;
                    }

                    //  Editing M command parameters
                    if (pathSeg is SVGPathSegMovetoAbs)
                    {
                        SVGPathSegMovetoAbs pathSegMovetoAbs = pathSeg as SVGPathSegMovetoAbs;

                        pathSegMovetoAbs.X = 200;
                        pathSegMovetoAbs.Y = 100;
                    }
                }
                // Set "fill" and "stroke" attributes
                pathElement.SetAttribute("stroke", "red");
                pathElement.SetAttribute("fill", "none");
                pathElement.SetAttribute("stroke-width", "4");

                // Add the path element as the first child to svgElement
                svgElement.InsertBefore(pathElement, svgElement.FirstChild);

                // Save the document
                document.Save(Path.Combine(OutputDir, "PathData.svg"));
                
                Assert.Equal("svg", document.DocumentElement.TagName);
            }
        }

        [Fact(DisplayName = "Gaussian Blur Effect")]
        public void GaussianBlurTest()
        {
            // Set SVG Namespace Url
            string SvgNamespace = "http://www.w3.org/2000/svg";

            using (var document = new SVGDocument())
            {
                var svgElement = document.RootElement;

                // Create an image element and add to the svgElement
                var imageElement = (SVGImageElement)document.CreateElementNS(SvgNamespace, "image");
                imageElement.Href.BaseVal = "http://docs.aspose.com/svg/net/how-to-work-with-asposesvg-api/document-editing/Lighthouse.jpg";
                imageElement.Height.BaseVal.ConvertToSpecifiedUnits(SVGLength.SVG_LENGTHTYPE_PX);
                imageElement.Width.BaseVal.ConvertToSpecifiedUnits(SVGLength.SVG_LENGTHTYPE_PX);
                imageElement.Height.BaseVal.Value = 640;
                imageElement.Width.BaseVal.Value = 480;
                imageElement.X.BaseVal.Value = 20;
                imageElement.Y.BaseVal.Value = 20;
                imageElement.SetAttribute("filter", "url(#F1)");
                svgElement.AppendChild(imageElement);

                // Create a defs element and add to the svgElement
                var defsElement = (SVGDefsElement)document.CreateElementNS(SvgNamespace, "defs");
                svgElement.AppendChild(defsElement);

                // Create a filter element and add to the defsElement
                var filterElement = (SVGFilterElement)document.CreateElementNS(SvgNamespace, "filter");
                defsElement.AppendChild(filterElement);

                // Create a feGaussianBlur element and add to the filterElement
                var feGaussianBlurElement = (SVGFEGaussianBlurElement)document.CreateElementNS(SvgNamespace, "feGaussianBlur");
                feGaussianBlurElement.In1.BaseVal = "SourceGraphic";
                feGaussianBlurElement.StdDeviationX.BaseVal = 3;
                feGaussianBlurElement.StdDeviationY.BaseVal = 3;
                feGaussianBlurElement.SetAttribute("x", "-20px");
                feGaussianBlurElement.SetAttribute("y", "-20px");
                feGaussianBlurElement.SetAttribute("height", "720px");
                feGaussianBlurElement.SetAttribute("width", "560px");
                filterElement.Id = "F1";                
                filterElement.AppendChild(feGaussianBlurElement);

                // Save the document
                document.Save(Path.Combine(OutputDir, "GaussianBlur.svg"));
            }
            Assert.True(File.Exists(Path.Combine(OutputDir, "GaussianBlur.svg")));
        }

        [Fact(DisplayName = "Saturation Effect")]
        public void SaturationEffectTest()
        {
            // Set SVG Namespace Url
            string SvgNamespace = "http://www.w3.org/2000/svg";

            using (var document = new SVGDocument())
            {
                var svgElement = document.RootElement;

                // Create an image element and add to the svgElement
                var imageElement = (SVGImageElement)document.CreateElementNS(SvgNamespace, "image");
                imageElement.Href.BaseVal = "http://docs.aspose.com/svg/net/how-to-work-with-asposesvg-api/document-editing/Lighthouse.jpg";
                imageElement.Height.BaseVal.ConvertToSpecifiedUnits(SVGLength.SVG_LENGTHTYPE_PX);
                imageElement.Width.BaseVal.ConvertToSpecifiedUnits(SVGLength.SVG_LENGTHTYPE_PX);
                imageElement.Height.BaseVal.Value = 640;
                imageElement.Width.BaseVal.Value = 480;
                imageElement.X.BaseVal.Value = 20;
                imageElement.Y.BaseVal.Value = 20;
                imageElement.SetAttribute("filter", "url(#CM)");                
                svgElement.AppendChild(imageElement);

                // Create a defs element and add to the svgElement
                var defsElement = (SVGDefsElement)document.CreateElementNS(SvgNamespace, "defs");
                svgElement.AppendChild(defsElement);

                // Creating a filter element and add to the defsElement	
                var filterElement = (SVGFilterElement)document.CreateElementNS(SvgNamespace, "filter");
                defsElement.AppendChild(filterElement);

                // Creating a feColorMatrix element and add to the filter element
                var feColorMatrixElement = (SVGFEColorMatrixElement)document.CreateElementNS(SvgNamespace, "feColorMatrix");
                feColorMatrixElement.In1.BaseVal = "SourceGraphic";
                feColorMatrixElement.SetAttribute("type", "saturate");
                feColorMatrixElement.SetAttribute("values", "2");
                filterElement.Id = "CM";                               
                filterElement.AppendChild(feColorMatrixElement);                         

                // Save the document
                document.Save(Path.Combine(OutputDir, "Saturation.svg"));
            }
            Assert.True(File.Exists(Path.Combine(OutputDir, "Saturation.svg")));
        }

        [Fact(DisplayName = "Drop Shadow Effect")]
        public void DropShadowTest()
        {
            // Set SVG Namespace Url
            string SvgNamespace = "http://www.w3.org/2000/svg";

            using (var document = new SVGDocument())
            {
                var svgElement = document.RootElement;

                // Create a defs element and add to the svgElement
                var defsElement = (SVGDefsElement)document.CreateElementNS(SvgNamespace, "defs");
                svgElement.AppendChild(defsElement);

                // Creating a filter element and add to the defsElement
                var filterElement = (SVGFilterElement)document.CreateElementNS(SvgNamespace, "filter");
                filterElement.Id = "shadow";
                filterElement.SetAttribute("x", "-20px");
                filterElement.SetAttribute("y", "-20px");
                filterElement.SetAttribute("height", "150px");
                filterElement.SetAttribute("width", "150px");
                defsElement.AppendChild(filterElement);

                // Create a feOffset filter primitive and add it to the filterElement
                var feOffsetElement = (SVGFEOffsetElement)document.CreateElementNS(SvgNamespace, "feOffset");
                feOffsetElement.In1.BaseVal = "SourceAlpha";
                feOffsetElement.SetAttribute("result", "offset");
                feOffsetElement.SetAttribute("dx", "3");
                feOffsetElement.SetAttribute("dy", "3");
                filterElement.AppendChild(feOffsetElement);

                // Create a feGaussianBlur filter primitive and add it to the filterElement
                var feGaussianBlurElement = (SVGFEGaussianBlurElement)document.CreateElementNS(SvgNamespace, "feGaussianBlur");
                feGaussianBlurElement.In1.BaseVal = "offset";
                feGaussianBlurElement.StdDeviationX.BaseVal = 3;
                feGaussianBlurElement.StdDeviationY.BaseVal = 3;
                feGaussianBlurElement.SetAttribute("result", "blur");
                filterElement.AppendChild(feGaussianBlurElement);

                // Create a feBlend filter primitive and add it to the filterElement
                var feBlendElement = (SVGFEBlendElement)document.CreateElementNS(SvgNamespace, "feBlend");
                feBlendElement.In1.BaseVal = "SourceGraphic";
                feBlendElement.In2.BaseVal = "blur";
                feBlendElement.SetAttribute("mode", "normal");
                filterElement.AppendChild(feBlendElement);                              

                // Create a text element and add it to the svgElement
                var textElement = (SVGTextElement)document.CreateElementNS(SvgNamespace, "text");
                textElement.Style.FontSize = "5em";
                textElement.SetAttribute("x", "20px");
                textElement.SetAttribute("fill", "#C0C0C0");
                textElement.SetAttribute("y", "100px");
                textElement.TextContent = "Aspose.SVG API";
                textElement.SetAttribute("filter", "url(#shadow)");
                svgElement.InsertBefore(textElement, svgElement.FirstChild);

                // Save the document
                document.Save(Path.Combine(OutputDir, "Shadow.svg"));                
               
                Assert.True(document.QuerySelectorAll("filter").Length > 0);
            }
        }

        [Fact(DisplayName = "Drawing on Existing Bitmaps")]
        public void DrawingOnExistingBitmapsTest()
        {
            // Set SVG Namespace Url
            string SvgNamespace = "http://www.w3.org/2000/svg";

            using (var document = new SVGDocument())
            {
                var svgElement = document.RootElement;

                // Create an image element and add it into svgElement
                var imageElement = (SVGImageElement)document.CreateElementNS(SvgNamespace, "image");
                imageElement.Href.BaseVal = "http://docs.aspose.com/svg/net/how-to-work-with-asposesvg-api/document-editing/seaside.jpg";
                imageElement.Height.BaseVal.ConvertToSpecifiedUnits(SVGLength.SVG_LENGTHTYPE_PX);
                imageElement.Width.BaseVal.ConvertToSpecifiedUnits(SVGLength.SVG_LENGTHTYPE_PX);
                imageElement.Height.BaseVal.Value = 480;
                imageElement.Width.BaseVal.Value = 640;
                imageElement.X.BaseVal.Value = 20;
                imageElement.Y.BaseVal.Value = 20;
                svgElement.AppendChild(imageElement);

                // Create a text element and set its attributes
                var textElement = (SVGTextElement)document.CreateElementNS(SvgNamespace, "text");
                textElement.Style.FontSize = "1.4em";
                textElement.SetAttribute("x", "420px");
                textElement.SetAttribute("fill", "gold");
                textElement.SetAttribute("y", "280px");
                textElement.TextContent = "The beach is beautiful...";

                // Add the text element into svgElement 
                svgElement.AppendChild(textElement);

                // Create a circle element and set its attributes
                var circleElement = (SVGCircleElement)document.CreateElementNS(SvgNamespace, "circle");
                circleElement.Cx.BaseVal.Value = 520;
                circleElement.Cy.BaseVal.Value = 120;
                circleElement.R.BaseVal.Value = 60;
                circleElement.SetAttribute("stroke", "gold");
                circleElement.SetAttribute("stroke-width", "70");
                circleElement.SetAttribute("fill", "none");
                circleElement.SetAttribute("stroke-dasharray", "2,14");

                // Add the circle element into svgElement 
                svgElement.AppendChild(circleElement);

                // Save the document
                document.Save(Path.Combine(OutputDir, "Drawing.svg"));

                Assert.True(document.QuerySelectorAll("circle").Length > 0);
            }
        }
    }
}

