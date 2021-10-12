using Aspose.Svg.Converters;
using Aspose.Svg.Drawing;
using Aspose.Svg.Rendering;
using Aspose.Svg.Rendering.Image;
using Aspose.Svg.Rendering.Pdf;
using Aspose.Svg.Rendering.Xps;
using Aspose.Svg.Saving;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.Svg.Tests
{
    public class HowToConvertSvgFilesTests : TestsBase
    {
        public HowToConvertSvgFilesTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("converting");
        }

        [Fact(DisplayName = "Using ConvertSVG Method")]
        public void UsingConvertSvgMethod()
        {
            // Initialize an SVG document from a file
            using (var document = new SVGDocument(Path.Combine(DataDir, "svg-to-png.svg")))
            {
                // Create an instance of ImageSaveOptions class
                var pngSaveOptions = new ImageSaveOptions();

                // Convert SVG to PNG
                Converter.ConvertSVG(document, pngSaveOptions, Path.Combine(OutputDir, "svg-to-png.png"));
            }
            Assert.True(File.Exists(Path.Combine(OutputDir, "svg-to-png_1.png")));
        }

        [Fact(DisplayName = "Using RenderTo Method")]
        public void UsingRenderToMethod()
        {
            // Initialize an SVG document from a file
            using (var document = new SVGDocument(Path.Combine(DataDir, "light.svg")))
            {
                // Initialize an instance of ImageRenderingOptions class 
                var pngOptions = new ImageRenderingOptions();

                // Initialize an instance of ImageDevice class and specify the output file to render
                using (var device = new ImageDevice(pngOptions, Path.Combine(OutputDir, "light_out.png")))
                {
                    // Render SVG to PNG
                    document.RenderTo(device);

                    Assert.Equal("svg", document.DocumentElement.TagName);
                }
            }
        }

        [Fact(DisplayName = "Convert SVG to PDF Using ConvertSVG Method")]
        public void ConvertSvgToPdf_UsingConvertSvgMethod()
        {
            // Initialize an SVG document from a file
            using (var document = new SVGDocument(Path.Combine(DataDir, "Lineto.svg")))

            {
                // Initialize an instance of the PdfSaveOptions class
                var saveOptions = new PdfSaveOptions();
                saveOptions.BackgroundColor = Color.Gray;

                // Convert SVG to PDF
                Converter.ConvertSVG(document, saveOptions, Path.Combine(OutputDir, "Lineto.pdf"));
            }
            
            Assert.True(File.Exists(Path.Combine(OutputDir, "Lineto_out.pdf")));
        }

        [Fact(DisplayName = "Convert SVG to PDF Using RenderTo Method")]
        public void ConvertSvgToPdf_UsingRenderToMethod()
        {
            // Initialize an SVG document from a file
            using (var document = new SVGDocument(Path.Combine(DataDir, "light.svg")))
            {
                // Initialize an instance of the PdfRenderingOptions class and set custom PageSetup and JpegQuality properties
                var pdfOptions = new PdfRenderingOptions();
                pdfOptions.PageSetup.AnyPage = new Page(new Drawing.Size(500, 500), new Margin(10, 10, 10, 10));
                pdfOptions.JpegQuality = 10;

                // Initialize an instance of PdfDevice class
                using (IDevice device = new PdfDevice(pdfOptions, Path.Combine(OutputDir, "light_out.pdf")))
                {
                    // Render SVG to PDF, send the document to the rendering device
                    document.RenderTo(device);
                }
            }
            Assert.True(File.Exists(Path.Combine(OutputDir, "light_out.pdf")));
        }

        [Fact(DisplayName = "Convert SVG to XPS Using ConvertSVG Method")]
        public void ConvertSvgToXps_UsingConvertSvgMethod()
        {
            // Initialize an SVG document from a file
            using (var document = new SVGDocument(Path.Combine(DataDir, "owl.svg")))
            {
                // Initialize an instance of XpsSaveOptions class and set BackgroundColor property
                var saveOptions = new XpsSaveOptions();
                saveOptions.BackgroundColor = Color.Gray;

                // Convert SVG to XPS
                Converter.ConvertSVG(document, saveOptions, Path.Combine(OutputDir, "owl_out.xps"));
            }
            Assert.True(File.Exists(Path.Combine(OutputDir, "owl_out.xps")));
        }

        [Fact(DisplayName = "Convert SVG to XPS Using RenderTo Method")]
        public void ConvertSvgToXps_UsingRenderToMethod()
        {
            // Initialize an SVG document from a file
            using (var document = new SVGDocument(Path.Combine(DataDir, "light.svg")))
            {
                // Initialize an instance of the XpsRenderingOptions class and set a custom PageSetup properties
                var xpsRenderingOptions = new XpsRenderingOptions();
                xpsRenderingOptions.PageSetup.AnyPage = new Page(new Drawing.Size(500, 500), new Margin(10, 10, 10, 10));

                // Initialize an instance of XpsDevice class
                using (IDevice device = new XpsDevice(xpsRenderingOptions, Path.Combine(OutputDir, "light_out.xps")))
                {
                    // Render SVG to XPS and send the document to the rendering device
                    document.RenderTo(device);
                }
            }
            Assert.True(File.Exists(Path.Combine(OutputDir, "light_out.xps")));
        }

        
        [Fact(DisplayName = "Convert SVG to JPG Using ConvertSVG Method")]
        public void ConvertSvgToJpg_UsingConvertSVGMethod()
        {
            // Initialize an SVG document from a file
            using (var document = new SVGDocument(Path.Combine(DataDir, "owl-edited.svg")))
            {
                // Initialize ImageSaveOptions 
                var saveOptions = new ImageSaveOptions(ImageFormat.Jpeg);
                
                // Convert SVG to JPG
                Converter.ConvertSVG(document, saveOptions, Path.Combine(OutputDir, "owl-edited.jpg"));
            }
            Assert.True(File.Exists(Path.Combine(OutputDir, "owl-edited_1.jpg")));
        }

        [Fact(DisplayName = "Convert SVG to JPG Using RenderTo Method")]
        public void ConvertSvgToJpg_UsingRenderToMethod()
        {
            // Initialize an SVG document from a file
            using (var document = new SVGDocument(Path.Combine(DataDir, "owl.svg")))
            {
                // Set Format and SmoothingMode for jpgOptions1
                var jpegOptions1 = new ImageRenderingOptions(ImageFormat.Jpeg);
                jpegOptions1.SmoothingMode = SmoothingMode.AntiAlias;

                // Set Format and SmoothingMode for jpgOptions2
                var jpegOptions2 = new ImageRenderingOptions(ImageFormat.Jpeg);
                jpegOptions2.SmoothingMode = SmoothingMode.Default;

                // Initialize an instance of ImageDevice class and specify the output file to render
                using (IDevice device = new ImageDevice(jpegOptions1, Path.Combine(OutputDir, "owl_out1.jpg")))
                {
                    // Render SVG to JPG
                    document.RenderTo(device);
                }
                using (IDevice device = new ImageDevice(jpegOptions2, Path.Combine(OutputDir, "owl_out2.jpg")))
                {
                    document.RenderTo(device);
                }
            }
            Assert.True(File.Exists(Path.Combine(OutputDir, "owl_out2_1.jpg")));
        }

        [Fact(DisplayName = "Convert SVG to PNG Using ConvertSVG Method")]
        public void ConvertSvgToPng_UsingConvertSVGMethod()
        {
            // Prepare an SVG code and save it to a file
            var code = "<svg xmlns='http://www.w3.org/2000/svg'>" +
                       "<circle cx='100' cy='150' r='50' stroke='#2F4F4F' stroke-width='4' fill='#FF7F50' />" +
                       "<circle cx='180' cy='200' r='60' stroke='#2F4F4F' stroke-width='4' fill='#008B8B' />" +
                       "</svg>";
            File.WriteAllText("example.svg", code);

            // Initialize an SVG document from the file
            using (var document = new SVGDocument("example.svg"))
            {
                // Initialize an instance of ImageSaveOptions class and set BackgroundColor property
                var saveOptions = new ImageSaveOptions();
                saveOptions.BackgroundColor = Color.Gainsboro;

                // Convert SVG to PNG
                Converter.ConvertSVG(document, saveOptions, Path.Combine(OutputDir, "output.png"));
            }
            Assert.True(File.Exists(Path.Combine(OutputDir, "output_1.png")));
        }

        [Fact(DisplayName = "Convert SVG to PNG Using RenderTo Method")]
        public void ConvertSvgToPng_UsingRenderToMethod()
        {
            // Prepare a path to a source SVG file
            string documentPath = Path.Combine(DataDir, "snowflake.svg");

            // Initialize an SVG document from the file
            using (var document = new SVGDocument(documentPath))
            {
                // Create the ImageDevice, set image Format and specify output file to render
                using (IDevice device = new ImageDevice(new ImageRenderingOptions(), Path.Combine(OutputDir, "snowflake_out.png")))
                {
                    // Render SVG to PNG
                    document.RenderTo(device);
                }
            }
            Assert.True(File.Exists(Path.Combine(OutputDir, "snowflake_out_1.png")));
        }

        [Fact(DisplayName = "Convert SVG to BMP")]
        public void ConvertSvgToBmp_ImageFormat()
        {
            string documentPath = Path.Combine(DataDir, "conclusion.svg");

            // Initialize an SVG document from a file
            using (var document = new SVGDocument(documentPath))
            {
                // Create the ImageDevice, set image Format and specify output file to render
                using (IDevice device = new ImageDevice(new ImageRenderingOptions(ImageFormat.Bmp), Path.Combine(OutputDir, "conclusion_out.bmp")))
                {
                    // Render SVG to BMP
                    document.RenderTo(device);
                }
            }
            Assert.True(File.Exists(Path.Combine(OutputDir, "conclusion_out_1.bmp")));
        }

            [Fact(DisplayName = "Convert SVG to TIFF")]
        public void ConvertSvgToTiff_Compression()
        {
            // Open source SVG document
            using (var document = new SVGDocument(Path.Combine(DataDir, "conclusion.svg")))
            {
                // Initialize an instance of ImageRenderingOptions class and set Format and Compression properties
                var tiffOptions = new ImageRenderingOptions(ImageFormat.Tiff);
                tiffOptions.Compression = Compression.None;

                // Initialize an instance of ImageDevice class and specify the output file to render
                using (IDevice device = new ImageDevice(tiffOptions, Path.Combine(OutputDir, "conclusion.tiff")))
                {
                    // Render SVG to TIFF
                    document.RenderTo(device);                    
                }
                Assert.True(document.QuerySelectorAll("rect").Length > 0);
            }
        }

        [Fact(DisplayName = "Convert SVG to GIF")]
        public void ConvertSvgToGif_PageSetup()
        {
            // Initialize an SVG document from a file
            using (var document = new SVGDocument(Path.Combine(DataDir, "owl.svg")))
            {
                // Initialize ImageSaveOptions 
                var saveOptions = new ImageSaveOptions(ImageFormat.Gif);
                saveOptions.PageSetup.AnyPage = new Page(new Drawing.Size(400, 600), new Margin(20, 20, 20, 20));
                
                // Convert SVG to GIF
                Converter.ConvertSVG(document, saveOptions, Path.Combine(OutputDir, "owl.gif"));
                
                Assert.True(document.QuerySelectorAll("path").Length > 0);
            }
            Assert.True(File.Exists(Path.Combine(OutputDir, "owl_1.gif")));
        }
    }
}
