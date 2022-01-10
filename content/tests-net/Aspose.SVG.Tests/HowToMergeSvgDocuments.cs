using Aspose.Svg.Rendering;
using Aspose.Svg.Rendering.Image;
using Aspose.Svg.Rendering.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.Svg.Tests
{
    public class HowToMergeSvgDocuments : TestsBase
    {
        public HowToMergeSvgDocuments(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("merging");
        }

        [Fact(DisplayName = "Render an SVG document")]
        public void RenderSvgDocumentToPng()
        {
            using (var document = new SVGDocument(Path.Combine(DataDir, "owl.svg")))
            {
                using (var renderer = new SvgRenderer())
                {
                    string outputDocumentPath = Path.Combine(OutputDir, "owl.png");
                    using (var device = new ImageDevice(outputDocumentPath))
                    {
                        renderer.Render(device, document);
                    }
                }
                Assert.True(File.Exists(Path.Combine(OutputDir, "owl_1.png")));
            }
        }

        [Fact(DisplayName = "Merging SVG documents")]
        public void MergeSvgDocumentsToPdf()
        {
            using (var document1 = new SVGDocument(Path.Combine(DataDir, "owl.svg")))
            using (var document2 = new SVGDocument(Path.Combine(DataDir, "lineto.svg")))
            using (var document3 = new SVGDocument(Path.Combine(DataDir, "conclusion.svg")))
            {
                using (var renderer = new SvgRenderer())
                {
                    string outputDocumentPath = Path.Combine(OutputDir, "result.pdf");
                    using (var device = new PdfDevice(outputDocumentPath))
                    {
                        renderer.Render(device, document1, document2, document3);
                    }
                }
            }
            Assert.True(File.Exists(Path.Combine(OutputDir, "result.pdf")));
        }
    }
}

