using Aspose.Svg.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
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
            // Set a full path for an SVG document saving
            var url = new Url(Path.Combine(OutputUrl, "lineto_out1.svg"), Directory.GetCurrentDirectory());

            //  Load the SVG document from a file
            using (var document = new SVGDocument(Path.Combine(DataDir, "lineto.svg")))
            {
                // Work with the document

                // Save the document to the Url
                document.Save(url);
            }

            Assert.True(File.Exists(Path.Combine(OutputDir, "lineto_out1.svg")));
        }


        [Fact(DisplayName = "Save an SVG document to a File")]
        public void SaveSvgDocumentToFile()
        {
            // Prepare a path for an SVG document saving
            string documentPath = Path.Combine(OutputDir, "lineto_out2.svg");

            //  Load the SVG document from a file
            using (var document = new SVGDocument(Path.Combine(DataDir, "lineto.svg")))
            {
                // Work with the document

                // Save the document to a file
                document.Save(documentPath);
            }

            Assert.True(File.Exists(documentPath));
        }


        [Fact(DisplayName = "Save an SVG document to a Loacal File System Storage")]
        public void SaveSvgDocumentToLoacalFileSystemStorage()
        {
            // Prepare a path to a source SVG file  
            string inputPath = Path.Combine(DataDir, "with-external-html.svg");

            // Prepare a full path to an output directory 
            string customOutDir = Path.Combine(Directory.GetCurrentDirectory(), "./../../../../tests-out/saving");

            // Load the SVG document from a file
            using (var doc = new SVGDocument(inputPath))
            {
                // Save SVG with resources
                doc.Save(new LocalFileSystemStorage(customOutDir));
            }

            Assert.True(File.Exists(Path.Combine(customOutDir, "with-external-html.svg")));
        }


        [Fact(DisplayName = "Save an SVG document to a Memory Stream")]
        public void SaveSvgDocumentToMemoryStreams()
        {
            // Prepare a path to a source SVG file
            string inputPath = Path.Combine(DataDir, "with-external-html.svg");

            using (var doc = new SVGDocument(inputPath))
            {
                // Create an instance of the MemoryOutputStorage class and save SVG to memory
                var memoryStorage = new MemoryOutputStorage();
                doc.Save(memoryStorage);

                Output.WriteLine(memoryStorage.GetInfo());
            }                 
        }


        /// <summary>       
        /// saves svg into memory streams.
        /// </summary>
        internal class MemoryOutputStorage : IOutputStorage
        {
            public List<Tuple<OutputStream, string>> Streams;

            public MemoryOutputStorage()
            {
                Streams = new List<Tuple<OutputStream, string>>();
            }

            public OutputStream CreateStream(OutputStreamContext context)
            {
                var normalizedPath = new Url(context.Uri).Pathname;
                var uri = new Url(Path.GetFileName(normalizedPath), "memory:///").Href;
                var outputStream = new OutputStream(new MemoryStream(), uri);
                Streams.Add(Tuple.Create(outputStream, uri));
                return outputStream;
            }

            public void ReleaseStream(OutputStream stream)
            {
                stream.Flush();
            }

            public void PrintInfo()
            {
                foreach (var stream in Streams)
                    Console.WriteLine($"uri:{stream.Item2}, length:{stream.Item1.Length}");
            }

            public string GetInfo()
            {
                string info = "";

                foreach (var stream in Streams)
                {
                    info += $"uri:{stream.Item2}, length:{stream.Item1.Length}";
                    info += "\r\n";
                }

                return info;
            }
        }


        [Fact(DisplayName = "Save an SVG document to a Zip Archive")]
        public void SaveSvgDocumentToZipArchive()
        {
            // Prepare a path to a source SVG file 
            string inputPath = Path.Combine(DataDir, "with-external-html.svg");

            // Prepare a full path to an output zip storage
            var dir = Directory.GetCurrentDirectory();            
            string customArchivePath = Path.Combine(dir, @"..\..\..\..\tests-out\saving\archive.zip");

            // Load the SVG document 
            using (var doc = new SVGDocument(inputPath))
            {
                // Initialize an instance of the ZipStorage class
                using (var zipSrorage = new ZipStorage(customArchivePath))
                {
                    // Save SVG with resources to a ZIP archive
                    doc.Save(zipSrorage);
                }
            }

            Assert.True(File.Exists(Path.Combine(customArchivePath)));
        }


        /// <summary>
        /// saves svg document into zip archive.
        /// </summary>
        internal class ZipStorage : IOutputStorage, IDisposable
        {
            private FileStream zipStream;
            private ZipArchive archive;
            private int streamsCounter;
            private bool initialized;


            public ZipStorage(string name)
            {
                DisposeArchive();
                zipStream = new FileStream(name, FileMode.Create);
                archive = new ZipArchive(zipStream, ZipArchiveMode.Update);
                initialized = false;

            }
            public OutputStream CreateStream(OutputStreamContext context)
            {
                var zipUri = (streamsCounter++ == 0 ? Path.GetFileName(context.Uri) :
                    Path.Combine(Path.GetFileName(Path.GetDirectoryName(context.Uri)), Path.GetFileName(context.Uri)));
                var samplePrefix = String.Empty;
                if (initialized)
                    samplePrefix = "my_";
                else
                    initialized = true;

                var newStream = archive.CreateEntry(samplePrefix + zipUri).Open();
                var outputStream = new OutputStream(newStream, "file:///" + samplePrefix + zipUri);
                return outputStream;
            }
            public void ReleaseStream(OutputStream stream)
            {
                stream.Flush();
                stream.Close();
            }

            private void DisposeArchive()
            {
                if (archive != null)
                {
                    archive.Dispose();
                    archive = null;
                }
                if (zipStream != null)
                {
                    zipStream.Dispose();
                    zipStream = null;
                }
                streamsCounter = 0;
            }

            public void Dispose()
            {
                DisposeArchive();
            }
        }
    }
}
