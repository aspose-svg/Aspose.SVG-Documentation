---
title: Environment Configuration | .NET
linktitle: Environment Configuration
type: docs
weight: 40
aliases: /net/how-to-work-with-aspose-svg-api/environment-configuration/
lastmod: 2022-01-10
description: In this guide, you will learn how to create various configurations and adapt them to the different environments where the application runs. This can be a custom theme, a runtime service or a web request network service.
keywords: environment configuration, user agent service, runtime service, network service, message handler, custom message handler
---
<link href="./../../style.css" rel="stylesheet" type="text/css" />

The setting of environment configuration is used for various purposes. For example, when you develop an application, you will definitely demand some configuration that can range from runtime service or handle any web requests from the application to injecting custom themes.

The [Aspose.Svg.Services](https://apireference.aspose.com/svg/net/aspose.svg.services) namespace contains a set of interfaces for separated services implementations.This article considers different types of environment configuration services such as **User Agent Service**, **Runtime Service**, and **Network Service**.  Aspose.SVG for .NET provides the [Configuration](https://apireference.aspose.com/svg/net/aspose.svg/configuration) class that  can be used to set the environment where the application is running.

{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-svg/Aspose.SVG-Documentation). You find out about downloading from GitHub and running examples from the [**How to Run the Examples**](http://docs.aspose.com/svg/net/how-to-run-the-tests) section.
{{% /alert %}} 

## **User Agent Service**

The **User Agent Service** allows you to specify a custom user stylesheet, a primary character set for the document, language and fonts settings. You can select your custom style information for a particular document and provide as little or as many environment configuration changes as needed.

The [IUserAgentService](https://apireference.aspose.com/svg/net/aspose.svg.services/iuseragentservice) interface describes a user agent environment. 

 - The `UserStyleSheet` property of the IUserAgentService interface allows specifying style information for a particular document;

 - The `CharSet` property sets the primary character-set for a document. 

   To parse and display an SVG document correctly, the application must know what encoding is using. If the character encoding is not directly specified in the header of the document, Aspose.SVG uses UTF-8, which is defined as the default. However, if you are sure that your SVG document is written using different from UTF-8 encoding, you can specify it manually, as shown in the example above.

 - The `FontsSettings` property is used for the configuration of fonts handling. When you need to use the custom fonts instead of the fonts installed on the OS, you can set the path to your custom folder, as shown in the following code snippet.

 - The `CSSEngineMode` property gets or sets the mode in which CSS engine works.

 - The `Language` property specifies the primary language for the element's contents and for any of the element's attributes that contain text.

Consider an example that illustrates `UserStyleSheet`, `CharSet` and `FontsSettings` properties applying: 

 ```c#
using System.IO;
using Aspose.Svg;
using Aspose.Svg.Services;
using Aspose.Svg.Converters;
using Aspose.Svg.Saving;
...
    
    // Prepare SVG code and save it to a file
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
    
        // Set a custom style parameters for the "circle" and "text" elements
        userAgentService.UserStyleSheet = "circle { fill:silver; }\r\n" +
                                          "text { fill:DarkCyan; font-size:3em; }\r\n";
    
        // Set ISO-8859-1 encoding to parse a document
        userAgentService.CharSet = "ISO-8859-1";
    
        // Set a custom font folder path
        userAgentService.FontsSettings.SetFontsLookupFolder(Path.Combine(DataDir + "fonts"));
    
        // Initialize an SVG document with specified configuration
        using (var document = new SVGDocument(Path.Combine(OutputDir, "user-agent.svg"), configuration))
        {
            // Convert SVG to PDF
            Converter.ConvertSVG(document, new PdfSaveOptions(), Path.Combine(OutputDir, "user-agent.pdf"));
        }
    }

 ```

The figure illustrates the result of  **User Agent Service** applying (b) to the source "user-agent.svg" file (a).

![Rendering of "user-agent.svg" and "user-agent.pdf" files](user-agent.png#center)



## **Runtime Service**

When planning to run your application, you might require a runtime service configuration. This service gives you control over the lifetime of the internal processes. For instance, using [IRuntimeService](https://apireference.aspose.com/net/html/aspose.html.services/iruntimeservice)  you can specify timeouts for JavaScripts. It is important to have such a timeout in case if a script contains an endless loop. The next code snippet demonstrates how to use timeouts.
```c#
using System.IO;
using Aspose.Svg;
using Aspose.Svg.Services;
using Aspose.Svg.Converters;
using Aspose.Svg.Saving;
...
    
    // Prepare SVG code and save it to a file
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
```

The `JavaScriptTimeout` property sets ` TimeSpan`, which limits JavaScript execution time. If the script is executed longer than provided `TimeSpan`, it will be cancelled.  The default value is 1 minute.

## **Network Service**

Modern network environments generate a significant amount of security events and log data via network routers and switches, servers, anti-malware systems, and so on.

Aspose.SVG for .Net offers the [INetworkService](https://apireference.aspose.com/html/net/aspose.html.services/inetworkservice) that is envisioned as a solution to help manage and analyze all this information. Service allows you to control all incoming/outcoming traffic and implement your custom message handlers.  It can be used for different purposes, such as creating a custom caching mechanism, tracing/logging request messages, etc.

### **Create a Custom Message Handler**

Aspose.SVG for .NET offers functionality for custom message handlers creating. Let’s develop a simple custom handler that logs information about unreachable resources. Take the following steps:

1. Use the necessary Namespace, which is the [Aspose.Svg.Net](https://apireference.aspose.com/svg/net/aspose.svg.net). This Namespace is presented by classes and interfaces, which are responsible for helping easy network processing.
2. To create a custom message handler, you need to define your own class that will be derived from the [MessageHandler](https://apireference.aspose.com/svg/net/aspose.svg.net/messagehandler) class. We construct a **LogMessageHandler** class.
3. Override the [Invoke()](https://apireference.aspose.com/svg/net/aspose.svg.net/messagehandler/methods/invoke) method of the MessageHandler class to implement the custom message handler behaviour.

The following example demonstrates how to create **LogMessageHandler** to log information about unreachable resources. 

```c#
using Aspose.Svg.Net;
using System.Collections.Generic;
using System.Net;
...
    
    // Define LogMessageHandler that is derived from the MessageHandler class
    public class LogMessageHandler : MessageHandler
    {
        private List<string> errors = new List<string>();

        public List<string> ErrorMessages
        {
            get { return errors; }
        }
    
        // Override the Invoke() method
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
```
{{% alert color="primary" %}} 
For more information about custom message handlers creation, please see the chapter [**Message Handlers**](https://docs.aspose.com/html/net/message-handlers/).
{{% /alert %}} 

### **Use LogMessageHandler for logging information about unreachable resources**

The following example demonstrates how to use the **LogMessageHandler** class for logging information about unreachable resources.

```c#
using System.IO;
using Aspose.Svg;
using Aspose.Svg.Services;
using Aspose.Svg.Converters;
using Aspose.Svg.Saving;
using Aspose.Svg.Net;
...
    
    // Prepare SVG code and save it to a file
    var code = "<svg xmlns=\"http://www.w3.org/2000/svg\">\r\n" +
               "    <image href=\"https://docs.aspose.com/svg/net/drawing-basics/filters-and-gradients/park.jpg\" width=\"640px\" height=\"480px\" />\r\n" +
               "    <image href=\"https://docs.aspose.com/svg/net/missing1.svg\" width=\"400px\" height=\"300px\" />\r\n" +
               "    <image href=\"https://docs.aspose.com/svg/net/missing2.svg\" width=\"400px\" height=\"300px\" />\r\n" +
               "</svg>\r\n";

    File.WriteAllText(Path.Combine(OutputDir, "network.svg"), code);
    
    // Create an instance of the Configuration class
    using (var configuration = new Configuration())
    {
        // Add LogMessageHandler to the chain of existing message handlers for logging errors
        var networkService = configuration.GetService<INetworkService>();
        
        var logHandler = new LogMessageHandler();
        networkService.MessageHandlers.Add(logHandler);
    
        // Initialize an SVG document with specified configuration
        using (var document = new SVGDocument(Path.Combine(OutputDir, "network.svg"),  configuration))
        {
            // Convert SVG to PNG
            Converter.ConvertSVG(document, new ImageSaveOptions(), Path.Combine(OutputDir, "network.png"));
    
            // Print the List of ErrorMessages
            foreach (string errorMessage in logHandler.ErrorMessages)
            {
                Console.WriteLine(errorMessage);
            }
        }
    }
```

After the example run:

- the created file "network.svg" will be converted to PNG. Only one image is in the file; 
- the List of `ErrorMessages` will be printed:

`File 'https://docs.aspose.com/svg/net/missing1.svg' Not Found`

`File 'https://docs.aspose.com/svg/net/missing2.svg' Not Found`



{{% alert color="primary" %}} 
You can download the complete examples and data files from [**GitHub**](https://github.com/aspose-svg/Aspose.SVG-Documentation). About downloading from GitHub and running examples, you find out from the [**How to Run the Examples**](http://docs.aspose.com/svg/net/how-to-run-the-tests) section.
{{% /alert %}} 

