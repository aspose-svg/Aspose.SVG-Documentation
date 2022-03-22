using System.IO;
using Xunit;
using Xunit.Abstractions;
using Aspose.Svg.Dom;

namespace Aspose.Svg.Tests
{
    public class SVGColorsTests : TestsBase
    {
        public SVGColorsTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("svg-colors");
        }


        [Fact(DisplayName = "Change Color of SVG Element Test")]
        public void ChangeColorOfSVGElementTest()
        {
            // Prepare a path to a file loading
            string documentPath = Path.Combine(DataDir, "basic-shapes.svg");

            // Load an SVG document from the file
            var document = new SVGDocument(documentPath);
            
            // Get root svg element of the document
            var svgElement = document.RootElement;            

            // Get circle element for color changing
            var circleElement = svgElement.QuerySelector("circle") as SVGCircleElement;

            // Set a new "fill" attribute value for the circle element
            circleElement.SetAttribute("fill", "blue");

            // Save the SVG document
            document.Save(Path.Combine(OutputDir, "circle-color.svg"));

            Assert.Equal("svg", document.DocumentElement.TagName);
        }


        [Fact(DisplayName = "Change Color of SVG Line Element Test")]
        public void ChangeColorOfSVGLineElementTest()
        {
            // Prepare a path to a file loading
            string documentPath = Path.Combine(DataDir, "basic-shapes.svg");

            // Load an SVG document from the file
            var document = new SVGDocument(documentPath);

            // Get root svg element of the document
            var svgElement = document.RootElement;

            // Get line element to change color
            var lineElement = svgElement.QuerySelector("line") as SVGLineElement;

            // Set a new "stroke" attribute value for the line element
            lineElement.SetAttribute("stroke", "blue");

            // Save the SVG document
            document.Save(Path.Combine(OutputDir, "line-color.svg"));

            Assert.Equal("svg", document.DocumentElement.TagName);
        }


        [Fact(DisplayName = "Change Background Color in SVG Test")]
        public void ChangeBackgroundColorInSVGTest()
        {
            // Set SVG Namespace Url
            string SvgNamespace = "http://www.w3.org/2000/svg";

            string documentPath = Path.Combine(DataDir, "basic-shapes.svg");

            // Load an SVG document from the file
            var document = new SVGDocument(documentPath);
            
            // Get root svg element of the document
            var svgElement = document.RootElement;                

            // Create a rectangle element and set attributes values
            var rectElement = (SVGRectElement)document.CreateElementNS(SvgNamespace, "rect");
            rectElement.X.BaseVal.Value = 3;
            rectElement.Y.BaseVal.Value = 3;
            rectElement.Width.BaseVal.Value = 400;
            rectElement.Height.BaseVal.Value = 400;
            rectElement.SetAttribute("fill", "Salmon");

            // Add the rectangle element as the first child to svg element
            svgElement.InsertBefore(rectElement, svgElement.FirstChild);

            // Save the SVG document
            document.Save(Path.Combine(OutputDir, "change-background-color.svg"));

            Assert.Equal("svg", document.DocumentElement.TagName);
        }


        [Fact(DisplayName = "Change Background and Element Color in SVG Test")]
        public void ChangeBackgroundAndElementColorInSVGTest()
        {
            // Set SVG Namespace Url
            string SvgNamespace = "http://www.w3.org/2000/svg";

            string documentPath = Path.Combine(DataDir, "snowflake-blue.svg");

            // Load an SVG document from the file
            var document = new SVGDocument(documentPath);
            
            // Get root svg element of the document
            var svgElement = document.RootElement;

            // Create a circle element and set attributes values
            var circleElement = (SVGCircleElement)document.CreateElementNS(SvgNamespace, "circle");
            circleElement.Cx.BaseVal.Value = 150F;
            circleElement.Cy.BaseVal.Value = 100F;
            circleElement.R.BaseVal.Value = 150F;
            circleElement.SetAttribute("fill", "#03b6fd");

            // Add the circle element (background) as the first child to svg element
            svgElement.InsertBefore(circleElement, svgElement.FirstChild);

            // Get the first path element to change color
            var snowflakePath = svgElement.QuerySelector("path") as SVGPathElement;

            // Set a new "stroke" attribute value for the path element
            snowflakePath.SetAttribute("stroke", "white");

            // Save the SVG document
            document.Save(Path.Combine(OutputDir, "recolor-svg.svg"));

            Assert.True(File.Exists(Path.Combine(OutputDir, "recolor-svg.svg")));
        }
    }
}
