using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.Svg.Tests
{
    public class CreatingLoadingTests : TestsBase
    {
        public CreatingLoadingTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("creating-loading");
        }

        [Fact(DisplayName = "Create an empty SVG document")]
        public void CreateEmptyDocumentTest()
        {
            string documentPath = Path.Combine(OutputDir, "empty.svg");

            using (var document = new SVGDocument())
            {
                // Work with the document
                Assert.Equal("svg", document.DocumentElement.TagName);

                // Save the document to a file
                document.Save(documentPath);
            }

            Assert.True(File.Exists(documentPath));
        }

        [Fact(DisplayName = "Create an SVG document from a string")]
        public void CreateDocumentFromContentStringTest()
        {
            var documentContent = "<svg xmlns=\"http://www.w3.org/2000/svg\"><circle cx=\"50\" cy=\"50\" r=\"40\" /></svg>";

            using (var document = new SVGDocument(documentContent, "."))
            {
                // Work with the document
                WorkWithDocument(document);
            }
        }

        [Fact(DisplayName = "Load an SVG document from a file")]
        public void LoadDocumentFromFileTest()
        {
            string documentPath = Path.Combine(DataDir, "QBezier.svg");

            using (var document = new SVGDocument(documentPath))
            {
                // Work with the document
                WorkWithDocument(document);
            }
        }


        [Fact(DisplayName = "Load an SVG document from a stream")]
        public void LoadDocumentFromStreamTest()
        {
            string documentPath = Path.Combine(DataDir, "QBezier.svg");

            using (var stream = new FileStream(documentPath, FileMode.Open, FileAccess.Read))
            {
                using (var document = new SVGDocument(stream, "."))
                {
                    // Work with the document
                    WorkWithDocument(document);
                }
            }
        }

        [Fact(DisplayName = "Load an SVG document from URL")]
        public void LoadDocumentFromUrlTest()
        {
            var documentUrl = new Url("https://docs.aspose.com/svg/net/drawing-basics/svg-path-data/owl.svg");
            
            using (var document = new SVGDocument(documentUrl))
            {
                // Work with the document
                WorkWithDocument(document);
            }
        }


        [Fact(DisplayName = "Load an SVG document Async")]
        public void LoadDocumentAsyncTest()
        {
            var documentUrl = new Url("https://docs.aspose.com/svg/net/drawing-basics/svg-path-data/owl.svg");
            var documentEvent = new ManualResetEvent(false);

            var document = new SVGDocument();
            
            document.OnReadyStateChange += (sender, ev) =>
            {
                if (document.ReadyState == "complete")
                {
                    // Sets the state of the event to signaled to unblock the main thread
                    documentEvent.Set();
                }
            };

            // Load an SVG document Async
            document.Navigate(documentUrl);
            
            // Blocks the current thread while the document is loading
            documentEvent.WaitOne();

            // Work with the document
            Assert.Equal("svg", document.DocumentElement.TagName);
        }
                
        private void WorkWithDocument(SVGDocument document)
        {
            // Work with document
            Assert.Equal("svg", document.DocumentElement.TagName);
        }

    }
}
