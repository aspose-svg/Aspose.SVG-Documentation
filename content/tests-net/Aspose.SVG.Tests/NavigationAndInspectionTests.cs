using Aspose.Svg.Rendering.Image;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;
using Xunit.Abstractions;
using Aspose.Svg.Dom;
using Aspose.Svg.Dom.Traversal.Filters;
using Aspose.Svg.Paths;
using Aspose.Svg.Collections;
using System.Xml.XPath;

namespace Aspose.Svg.Tests
{
    public class NavigationAndInspectionTests : TestsBase
    {
        public NavigationAndInspectionTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("navigation-and-inspection");
        }
        public class RectFilter : NodeFilter
        {
            public override short AcceptNode(Node n)
            {
                return string.Equals("rect", n.NodeName) ? FILTER_ACCEPT : FILTER_REJECT;
            }
        }

        [Fact(DisplayName = "View SVG Content")]
        public void ViewSVGContent()
        {
            string documentPath = Path.Combine(DataDir, "QBezier.svg");

            using (var document = new SVGDocument(documentPath))
            {               
                var html = document.DocumentElement.OuterHTML;

                System.Diagnostics.Debug.WriteLine(html);
           
                Assert.StartsWith("<svg", html.Trim());
                Assert.Contains("</svg>", html);
            }

        }

        [Fact(DisplayName = "Extract Information about Specific Element")]
        public void ExtractInformationAboutSpecificElement()
        {
            string documentPath = Path.Combine(DataDir, "shapes.svg");

            using (var document = new SVGDocument(documentPath))
            {
                var svg = document.DocumentElement;
                var g = svg.GetElementsByTagName("g").First() as SVGGElement;
                var rect = g.FirstElementChild as SVGRectElement;
                                
				Assert.True(document.QuerySelectorAll("rect").Length > 0);
                Assert.Equal(90, rect.Height.BaseVal.Value, 0);
                Assert.Equal(100, rect.Width.BaseVal.Value, 0);
            }
        }
        [Fact(DisplayName = "Inspection of the Document and its Elements")]
        public void InspectionOfDocumentAndElements()
        {
            string documentPath = Path.Combine(DataDir, "shapes.svg");

            using (var document = new SVGDocument(documentPath))
            {
                var element = document.DocumentElement;
                Assert.Equal("svg", element.TagName);

                element = element.LastElementChild;
                Assert.Equal("g", element.TagName);

                element = element.FirstElementChild;
                Assert.Equal("rect", element.TagName);
            }
        }
        [Fact(DisplayName = "Iterating Over Document Elements using Custom Filterss")]
        public void IteratingOverDocumentElementsUsingCustomFilters()
        {
            using (var document = new SVGDocument(Path.Combine(DataDir, "shapes.svg")))
            {
                // Create a node iterator
                using (var iterator = document.CreateNodeIterator(document, NodeFilter.SHOW_ALL, new RectFilter()))
                {
                    Node node;
                    while ((node = iterator.NextNode()) != null)
                    {
                        Assert.StartsWith("<rect", (node as Element)?.OuterHTML.Trim());
                        Assert.DoesNotContain("<circle", (node as Element)?.OuterHTML);
                    }
                }
            }
        }
        [Fact(DisplayName = "Picture Editing Using CSS Selector")]
        public void UsingQuerySelectorAndQuerySelectorAllTest()
        {
            using (var document = new SVGDocument(new Url("https://docs.aspose.com/svg/net/drawing-basics/svg-path-data/owl.svg")))
            {
                // Get root svg element of the document
                var svgElement = document.RootElement;

                // Find the first element that matches the specified in selector
                var gElement = svgElement.QuerySelector("g") as SVGGElement;

                // Find all circle elements in g element
                NodeList circleNodes = gElement.QuerySelectorAll("circle");

                // Make big blue eyes
                foreach (Node circleNode in circleNodes)
                {
                    var circleElement = circleNode as SVGCircleElement;
                    circleElement.R.BaseVal.Value *= 1.5F;
                    circleElement.SetAttribute("stroke", "blue");
                }

                // Get path for owl wing
                var wingPath = gElement.QuerySelector("path:nth-child(2)") as SVGPathElement;

                // Apply style attributes to the wing
                wingPath.SetAttribute("stroke-width", "16");
                wingPath.SetAttribute("stroke-dasharray", "2 8");

                document.Save(Path.Combine(OutputDir, "owl-edited.svg"));

                Assert.True(document.QuerySelectorAll("circle").Length > 0);
            }
        }
        [Fact(DisplayName = "Using QuerySelectorAll")]
        public void UsingQuerySelectorAllTest()
        {
            using (var document = new SVGDocument(new Url("https://docs.aspose.com/svg/net/drawing-basics/svg-path-data/owl.svg")))
            {
                // Get root svg element of the document
                var svgElement = document.RootElement;

                // Create a new g element with style attributes
                var gElement = (SVGGElement)document.CreateElementNS(SvgNamespace, "g");
                gElement.SetAttribute("fill", "none");
                gElement.SetAttribute("stroke-width", "2");
                svgElement.AppendChild(gElement);

                // Find all circle elements from the first g element
                NodeList circleNodes = svgElement.QuerySelectorAll("g:first-child > circle");

                // Make square sky-blue eyes
                foreach (Node circleNode in circleNodes)
                {
                    SVGCircleElement circleElement = circleNode as SVGCircleElement;

                    float cx = circleElement.Cx.BaseVal.Value;
                    float cy = circleElement.Cy.BaseVal.Value;
                    float r = circleElement.R.BaseVal.Value;

                    var rectElement = (SVGRectElement)document.CreateElementNS(SvgNamespace, "rect");
                    rectElement.X.BaseVal.Value = cx - r;
                    rectElement.Y.BaseVal.Value = cy - r;
                    rectElement.Width.BaseVal.Value = 3 * r;
                    rectElement.Height.BaseVal.Value = 3 * r;
                    rectElement.SetAttribute("stroke", "SkyBlue");

                    // Add the rectangle element into the second g element and remove the circle element
                    gElement.AppendChild(rectElement);
                    circleElement.Remove();
                }
                // Recolor last rectangle in the second g element
                Element lastRect = gElement.LastElementChild;
                lastRect.SetAttribute("stroke", "red");

                document.Save(Path.Combine(OutputDir, "owl-svg-eyes.svg"));
               
                Assert.True(document.QuerySelectorAll("rect").Length >0);
            }
        }

        [Fact(DisplayName = "Using QuerySelector")]
        public void UsingQuerySelectorTest()
        {
            using (var document = new SVGDocument(Path.Combine(DataDir, "owl-svg-eyes.svg")))
            {
                var svgElement = document.RootElement;

                // Get path for owl body from the first g element
                Element bodyPath = (svgElement.QuerySelector("g:first-child") as SVGGElement).FirstElementChild;
                bodyPath.SetAttribute("stroke", "Teal");

                // Get path for owl wing from the first g element
                var wingPath = svgElement.QuerySelector("g:first-child > path:nth-child(2)") as SVGPathElement;

                // Form new wing path data based on the old
                string d = "";
                foreach (SVGPathSeg pathSeg in wingPath.PathSegList)
                {
                    if (pathSeg is SVGPathSegMovetoAbs)
                    {
                        SVGPathSegMovetoAbs pathSegMovetoAbs = pathSeg as SVGPathSegMovetoAbs;

                        d += string.Format(" M {0} {1}", pathSegMovetoAbs.X, pathSegMovetoAbs.Y);
                    }
                    if (pathSeg is SVGPathSegCurvetoCubicAbs)
                    {
                        SVGPathSegCurvetoCubicAbs pathSegCurvetoCubicAbs = pathSeg as SVGPathSegCurvetoCubicAbs;

                        d += string.Format(
                            " L {0} {1} L {2} {3}",
                            (pathSegCurvetoCubicAbs.X1 + pathSegCurvetoCubicAbs.X2) / 2F,
                            (pathSegCurvetoCubicAbs.Y1 + pathSegCurvetoCubicAbs.Y2) / 2F,
                            pathSegCurvetoCubicAbs.X,
                            pathSegCurvetoCubicAbs.Y
                        );
                    }
                }
                // Set d attribute - new path data formation
                wingPath.SetAttribute("d", d.Trim());
                wingPath.SetAttribute("stroke", "Teal");

                document.Save(Path.Combine(OutputDir, "owl-svg-wing.svg"));
                
                Assert.False(document.QuerySelectorAll("circle").Length > 0);
            }
        }

        [Fact(DisplayName = "Using XPath Query")]
        public void UsingXPathQueryTest()
        {
            using (var document = new SVGDocument(Path.Combine(DataDir, "shapes.svg")))
            {
                //  Evaluate XPath expression
                var xpathResult = document.Evaluate("//rect[@x='120']", document, null, (Dom.XPath.XPathResultType)XPathResultType.Any, null);

                //  Get the next evaluated node
                Element element;
                while ((element = (xpathResult.IterateNext() as Element)) != null)
                {
                    Assert.StartsWith("<rect", element.OuterHTML.Trim());
                    Assert.Matches(@"x\s*=\s*[""']120[""']", element.OuterHTML);
                }                
            }
        }
    }
}
