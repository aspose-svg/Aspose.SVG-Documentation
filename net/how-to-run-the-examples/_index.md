---
title: How to Run the Examples
type: docs
weight: 40
url: /net/how-to-run-examples/
---

Examples of using the API features are given as **XUnit tests** that serve to accompany the documentation. The XUnit tests help to attend the documentation and cover the possible uses of the API features. 

{{% alert color="primary" %}} 
For complete tests and data files download, please go to https://github.com/aspose-svg/Aspose.SVG-Documentation
{{% /alert %}}

## **Software Requirements**

Please make sure you meet the following requirements before downloading and running the examples.

1. Visual Studio 2010 or higher
1. NuGet Package Manager installed in Visual Studio. Make sure that the latest NuGet API version is installed in Visual Studio. For details on how to install NuGet package manager please check <https://docs.microsoft.com/en-gb/nuget/install-nuget-client-tools>
1. Go to Tools->Options->NuGet Package Manager->Package Sources and make sure that the option **nuget.org** is checked
1. Example project uses NuGet Automatic Package Restore feature, therefore, you should have an active internet connection. If you do not have an active internet connection on the machine where examples are to be executed please check [Installation](/svg/net/installation/) and manually add a reference to Aspose.SVG.dll in the example project.

## **Download from GitHub**

All tests of Aspose.SVG for .NET documentation are written in C# and hosted on [GitHub](https://github.com/aspose-svg/Aspose.SVG-Documentation). 

 - You can either clone the repository using GitHub client or download the ZIP file from [here](https://github.com/aspose-svg/Aspose.SVG-Documentation/archive/master.zip).

 - Extract the contents of ZIP file to any folder on your computer. All the tests are located in the **tests-net** folder.
 - Use Visual Studio to run XUnit tests. 
 - Open the **Aspose.SVG.Tests.sln** solution file in Visual Studio and build the project.
 - On the first run, the dependencies will automatically be downloaded via NuGet.
 - Run XUnit tests and see their results in *Test Explorer*. 
 - The **tests-data** folder at the root folder of **tests-net** contains input files that XUnit tests use. It is mandatory that you download the **tests-data** folder with the **Aspose.SVG.Tests** project.

Please feel free to reach out using our Forums if you have any issues setting up or running the examples.

### **How You can Run the Tests**
To run the tests, choose *Test > Test Explorer* from the top menu bar.  You can run all the tests in the project, all the tests in a group, or a set of tests that you select. Do one of the following:
 - Select the *Run All* icon to run all the tests in a solution.
 - To run all the tests in a group, choose the *Run* icon and then select the group on the menu.
 - Choose the individual tests that you want to run, open the right-click menu for a selected test and then take *Run Selected Tests*.


After the tests have finished, a green checkmark indicates that a test passed. A red "x" icon indicates that a test failed.

## **Contribute**

If you like to add or improve an example, we encourage you to contribute to the project. All examples and showcase projects in this repository are open source and can be freely used in your own applications.

To contribute, you can fork the repository, edit the source code and create a pull request. We will review the changes and include them in the repository if found helpful.
