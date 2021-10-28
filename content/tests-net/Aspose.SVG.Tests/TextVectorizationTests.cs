using Aspose.Svg.Saving;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.Svg.Tests
{
    public class TextVectorizationTests : TestsBase
    {
        public TextVectorizationTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("text-vectorization");
        }

        [Fact(DisplayName = "Text Vectorization Test")]
        public void TextVectorizationTest()
        {
            // Load an SVG document from file
            var document = new SVGDocument(Path.Combine(DataDir, "Text.svg"));

            // Set text elements vectorization 
            var saveOptions = new SVGSaveOptions
            {
                VectorizeText = true
            };

            // Save the SVG document with specified saveOptions
            document.Save(Path.Combine(OutputDir, "Text_vectorized.svg"), saveOptions);
            
            Assert.False(document.QuerySelectorAll("text").Length > 1);
        }
    }
}
