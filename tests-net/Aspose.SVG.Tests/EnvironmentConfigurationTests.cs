using Aspose.Svg.Converters;
using Aspose.Svg.Net;
using Aspose.Svg.Saving;
using Aspose.Svg.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Aspose.Svg.Tests
{
    public class LogMessageHandler : MessageHandler
    {
        private List<string> errors = new List<string>();

        public List<string> ErrorMessages
        {
            get { return errors; }
        }

        public override void Invoke(INetworkOperationContext context)
        {
            // Check whether response is OK
            if (context.Response.StatusCode != HttpStatusCode.OK)
            {
                // Set error information
                errors.Add(string.Format("File '{0}' Not Found", context.Request.RequestUri));
            }

            // Invoke the next message handler in the chain
            Next(context);
        }
    }
    public class EnvironmentConfigurationTests : TestsBase
    {
        public EnvironmentConfigurationTests(ITestOutputHelper output) : base(output)
        {
            SetOutputDir("configurations");
        }

        [Fact(DisplayName = "User Agent Service")]
        public void UserAgentServiceTest()
        {
            // Prepare an SVG code and save it to a file
            var code = "<svg xmlns=\"http://www.w3.org/2000/svg\">\r\n" +
                       "    <circle cx=\"40\" cy=\"80\" r=\"30\" />\r\n" +
                       "    <text x=\"80\" y=\"100\">Aspose.SVG</text>\r\n" +
                       "</svg>\r\n";

            File.WriteAllText(Path.Combine(OutputDir, "user-agent.svg"), code);

            // Create an instance of Configuration
            using (var configuration = new Configuration())
            {
                // Get the IUserAgentService
                var userAgentService = configuration.GetService<IUserAgentService>();

                // Set the custom style parameters for the "circle" and "text" elements
                userAgentService.UserStyleSheet = "circle { fill:silver; }\r\n" +
                                                  "text { fill:DarkCyan; font-size:3em; }\r\n";

                // Set ISO-8859-1 encoding to parse the document
                userAgentService.CharSet = "ISO-8859-1";

                // Set custom font folder path
                userAgentService.FontsSettings.SetFontsLookupFolder(Path.Combine(DataDir + "fonts"));

                // Initialize an SVG document with specified configuration
                using (var document = new SVGDocument(Path.Combine(OutputDir, "user-agent.svg"), configuration))
                {
                    // Convert SVG to PDF
                    Converter.ConvertSVG(document, new PdfSaveOptions(), Path.Combine(OutputDir, "user-agent.pdf"));
                   
                    Assert.Equal("svg", document.DocumentElement.TagName);
                }
            }
        }

        [Fact(DisplayName = "Runtime Service Test")]
        public void RuntimeServiceTest()
        {
            // Prepare an SVG code and save it to a file
            var code = "<svg xmlns=\"http://www.w3.org/2000/svg\">\r\n" +
                       "    <script> while(true) {} </script>\r\n" +
                       "    <circle cx=\"40\" cy=\"80\" r=\"30\" />\r\n" +
                       "</svg>\r\n";

            File.WriteAllText(Path.Combine(OutputDir, "runtime.svg"), code);

            // Create an instance of Configuration
            using (var configuration = new Configuration())
            {
                // Limit JS execution time to 5 seconds
                var runtimeService = configuration.GetService<IRuntimeService>();
                runtimeService.JavaScriptTimeout = TimeSpan.FromSeconds(5);
                               
                // Initialize an SVG document with specified configuration
                using (var document = new SVGDocument(Path.Combine(OutputDir, "runtime.svg"), configuration))
                {
                    // Convert SVG to PNG
                    Converter.ConvertSVG(document, new ImageSaveOptions(), Path.Combine(OutputDir, "runtime.png"));
                }
            }

            Assert.True(File.Exists(Path.Combine(OutputDir, "runtime_1.png")));
        }

        [Fact(DisplayName = "Network Service Test")]
        public void NetworkServiceTest()
        {
            // Prepare an SVG code and save it to a file
            var code = "<svg xmlns=\"http://www.w3.org/2000/svg\">\r\n" +
                       "    <image href=\"https://docs.aspose.com/svg/net/drawing-basics/filters-and-gradients/park.jpg\" width=\"640px\" height=\"480px\" />\r\n" +
                       "    <image href=\"https://docs.aspose.com/svg/net/missing1.svg\" width=\"400px\" height=\"300px\" />\r\n" +
                       "    <image href=\"https://docs.aspose.com/svg/net/missing2.svg\" width=\"400px\" height=\"300px\" />\r\n" +
                       "</svg>\r\n";

            File.WriteAllText(Path.Combine(OutputDir, "network.svg"), code);

            // Create an instance of Configuration
            using (var configuration = new Configuration())
            {
                // Add LogMessageHandler to the chain of existing message handlers
                var networkService = configuration.GetService<INetworkService>();
                
                var logHandler = new LogMessageHandler();
                networkService.MessageHandlers.Add(logHandler);

                // Initialize an SVG document with specified configuration
                using (var document = new SVGDocument(Path.Combine(OutputDir, "network.svg"),  configuration))
                {
                    // Convert SVG to PNG
                    Converter.ConvertSVG(document, new ImageSaveOptions(), Path.Combine(OutputDir, "network.png"));                   
                }
                Assert.True(logHandler.ErrorMessages.Count == 2, "two errors expected");
            }
        }
    }
}
