---
title: How to Run C# Examples
type: docs
weight: 80
aliases: /net/how-to-run-the-examples/
lastmod: "2022-03-20"
---

## **Software Requirements**

Please make sure you meet the following requirements before downloading and running the examples.

1. Visual Studio 2010 or higher
1. NuGet Package Manager installed in Visual Studio. Make sure that the latest NuGet API version is installed in Visual Studio. For details on how to install NuGet package manager please check <https://docs.microsoft.com/en-gb/nuget/install-nuget-client-tools>
1. Go to Tools->Options->NuGet Package Manager->Package Sources and make sure that the option **nuget.org** is checked
1. Example project uses NuGet Automatic Package Restore feature, therefore, you should have an active internet connection. If you do not have an active internet connection on the machine where examples are to be executed please check [Installation](/svg/net/getting-started/installation/) and manually add a reference to Aspose.SVG.dll in the example project.

## **Download from GitHub**

All examples of Aspose.SVG for .NET are hosted on [GitHub](https://github.com/aspose-svg/Aspose.SVG-for-.NET).

- You can either clone the repository using your favorite GitHub client or download the ZIP file from [here](https://github.com/aspose-svg/Aspose.SVG-for-.NET/archive/master.zip).
- Extract the contents of ZIP file to any folder on your computer. All the examples are located in the **Examples** folder.
- There are two Visual Studio solution files, one for Console and the other one is for Web Application.
- The projects are created in Visual Studio 2013, but the solution files are compatible with Visual Studio 2010 SP1 and higher.
- Open the solution file in Visual Studio and build the project.
- On the first run, the dependencies will automatically be downloaded via NuGet.
- **Data** folder at the root folder of **Examples** contains input files that CSharp examples used. It is mandatory that you download the **Data** folder along with the examples project.
- Open RunExamples.cs file, all the examples are called from here.
- Uncomment the examples you want to run from within the project.

Please feel free to reach out using our Forums if you have any issues setting up or running the examples.

## **Contribute**

If you like to add or improve an example, we encourage you to contribute to the project. All examples and showcase projects in this repository are open source and can be freely used in your own applications.

To contribute, you can fork the repository, edit the source code and create a pull request. We will review the changes and include them in the repository if found helpful.
