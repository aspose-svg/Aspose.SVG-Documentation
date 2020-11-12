using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.Svg.Tests
{
    public class SavingDocumentsTests : TestsBase
    {
        public SavingDocumentsTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("saving");
        }

        [Fact(DisplayName = "Save an SVG document to a Url")]
        public void SaveSvgDocumentToUrl()
        {
            var url = new Url(Path.Combine(OutputUrl, "Lineto_out1.svg"), Directory.GetCurrentDirectory());

            using (var document = new SVGDocument(Path.Combine(DataDir, "Lineto.svg")))
            {
                // Work with the document
                
                // Save the document to the Url
                document.Save(url);
            }

            Assert.True(File.Exists(Path.Combine(OutputDir, "Lineto_out1.svg")));
        }

        [Fact(DisplayName = "Save an SVG document to a File")]
        public void SaveSvgDocumentToFile()
        {
            string documentPath = Path.Combine(OutputDir, "Lineto_out2.svg");

            using (var document = new SVGDocument(Path.Combine(DataDir, "Lineto.svg")))
            {
                // Work with the document

                // Save the document to a file
                document.Save(documentPath);
            }

            Assert.True(File.Exists(documentPath));
        }        
    }
}
