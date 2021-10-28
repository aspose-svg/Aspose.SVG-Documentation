using Aspose.Svg.Saving;
using Aspose.Svg.ImageVectorization;
using System;
using System.IO;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.Svg.Tests
{
    public class ImageVectorizationTests : TestsBase
    {
        public ImageVectorizationTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("image-vectorization");
        }

                
        [Fact(DisplayName = "Image Vectorization Test1")]
        public void ImageVectorizationTest1()
        {
            // Initialize an instance of the ImageVectorizer class
            var vectorizer = new ImageVectorizer
            {
                Configuration =
                {
                    TraceSmoother =   new ImageTraceSmoother(1),
                    TraceSimplifier = new ImageTraceSimplifier(0.5f),
                    ColorsLimit = 3
                }
            };

            // Vectorize raster image from the specified file
            using var document = vectorizer.Vectorize(Path.Combine(DataDir, "owl.png"));

            // Save vectorized image as SVG file 
            document.Save(Path.Combine(OutputDir, "olw.svg"));

            Assert.Equal("svg", document.DocumentElement.TagName);
        }


        [Fact(DisplayName = "Image Vectorization Test2")]
        public void ImageVectorizationTest2()
        {
            var vectorizer = new ImageVectorizer
            {
                Configuration =
                {
                    TraceSmoother =   new ImageTraceSmoother(2),
                    TraceSimplifier = new ImageTraceSimplifier(0.1f),
                    ColorsLimit = 2
                }
            };

            using var document = vectorizer.Vectorize(Path.Combine(DataDir, "png-to-svg.png"));
            document.Save(Path.Combine(OutputDir, "png-to-svg.svg"));

            Assert.True(File.Exists(Path.Combine(OutputDir, "png-to-svg.svg")));
        }


        [Fact(DisplayName = "Use of the TraceSimplifier Property")]
        public void UseTraceSimplifierPropertyTest()
        {
            // Initialize an instance of the ImageVectorizer class and specify configuration properties
            var vectorizer1 = new ImageVectorizer
            {
                Configuration =  {
                TraceSimplifier = new ImageTraceSimplifier(0.1f),
                TraceSmoother =   new ImageTraceSmoother(2),
                ColorsLimit = 2
                }
            };

            var vectorizer2 = new ImageVectorizer
            {
                Configuration =  {
                TraceSimplifier = new ImageTraceSimplifier(1),
                TraceSmoother =   new ImageTraceSmoother(2),
                ColorsLimit = 2
                }
            };

            var vectorizer3 = new ImageVectorizer
            {
                Configuration =  {
                TraceSimplifier = new ImageTraceSimplifier(2),
                TraceSmoother =   new ImageTraceSmoother(2),
                ColorsLimit = 2
                }
            };

            // Prepare path for source image file
            string sourcePath = Path.Combine(DataDir, "formats.png");

            // Vectorize raster image from the specified file
            using var document1 = vectorizer1.Vectorize(sourcePath);
            using var document2 = vectorizer2.Vectorize(sourcePath);
            using var document3 = vectorizer3.Vectorize(sourcePath);

            // Save vectorized image as SVG file
            document1.Save(Path.Combine(OutputDir, "formats1.svg"));
            document2.Save(Path.Combine(OutputDir, "formats2.svg"));
            document3.Save(Path.Combine(OutputDir, "formats3.svg"));

            Assert.True(File.Exists(Path.Combine(OutputDir, "formats3.svg")));
        }


        [Fact(DisplayName = "Use of the TraceSmoother Property")]
        public void UseTraceSmootherPropertyTest()
        {
            // Initialize an instance of the ImageVectorizer class and specify configuration properties
            var vectorizer1 = new ImageVectorizer
            {
                Configuration =  {
                TraceSmoother =   new ImageTraceSmoother(0),
                TraceSimplifier = new ImageTraceSimplifier(0.1f),
                ColorsLimit = 2
                }
            };

            var vectorizer2 = new ImageVectorizer
            {
                Configuration =
                {
                    TraceSmoother =   new ImageTraceSmoother(4),
                    TraceSimplifier = new ImageTraceSimplifier(0.1f),
                    ColorsLimit = 2
                }
            };

            var vectorizer3 = new ImageVectorizer
            {
                Configuration =  {
                TraceSmoother =   new ImageTraceSmoother(8),
                TraceSimplifier = new ImageTraceSimplifier(0.1f),
                ColorsLimit = 2
                }
            };

            // Prepare path for source image file
            string sourcePath = Path.Combine(DataDir, "flower.png");

            // Vectorize raster image from the specified file
            using var document1 = vectorizer1.Vectorize(sourcePath);
            using var document2 = vectorizer2.Vectorize(sourcePath);
            using var document3 = vectorizer3.Vectorize(sourcePath);

            // Save vectorized image as SVG file
            document1.Save(Path.Combine(OutputDir, "flower1.svg"));
            document2.Save(Path.Combine(OutputDir, "flower2.svg"));
            document3.Save(Path.Combine(OutputDir, "flower3.svg"));

            Assert.True(document1.QuerySelectorAll("path").Length > 0);
        }


        [Fact(DisplayName = "Use of the PathBuilder Property")]
        public void UsePathBuilderPropertyTest()
        {
            // Initialize an instance of the ImageVectorizer class and specify configuration properties
            var vectorizer1 = new ImageVectorizer
            {
                Configuration =  {
                TraceSmoother =   new ImageTraceSmoother(1),
                TraceSimplifier = new ImageTraceSimplifier(1),
                PathBuilder = new PathBuilder(0),
                ColorsLimit = 2
                }
            };

            var vectorizer3 = new ImageVectorizer
            {
                Configuration =  {
                TraceSmoother =   new ImageTraceSmoother(1),
                TraceSimplifier = new ImageTraceSimplifier(1),
                PathBuilder = new PathBuilder(1),
                ColorsLimit = 2
                }
            };

            // Prepare path for source image file
            string sourcePath = Path.Combine(DataDir, "cheese.png");

            // Vectorize raster image from the specified file
            using var document1 = vectorizer1.Vectorize(sourcePath);
            using var document2 = vectorizer3.Vectorize(sourcePath);

            // Save vectorized image as SVG file
            document1.Save(Path.Combine(OutputDir, "cheese1.svg"));
            document2.Save(Path.Combine(OutputDir, "cheese2.svg"));

            Assert.True(File.Exists(Path.Combine(OutputDir, "cheese2.svg")));
        }

        [Fact(DisplayName = "Photo Vectorization Test")]
        public void PhotoVectorizationTest()
        {
            // Initialize an instance of the ImageVectorizer class
            var vectorizer = new ImageVectorizer
            {
                Configuration =  {
                TraceSmoother =   new ImageTraceSmoother(1),
                TraceSimplifier = new ImageTraceSimplifier(0.3f),
                PathBuilder = new PathBuilder(0.2f),
                ColorsLimit = 25
                }
            };

            // Vectorize raster image from the specified file
            using var document = vectorizer.Vectorize(Path.Combine(DataDir, "horses.jpg"));

            // Prepare an output path for an SVG document saving
            string savePath = Path.Combine(OutputDir, "horses.svg");

            document.Save(savePath);

            Assert.True(File.Exists(savePath));
        }
    }
}

