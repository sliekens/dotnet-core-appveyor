# DEPRECATION NOTE
This project targets a preview version of the .NET Core SDK that uses the xproj/project.json project system instead of the newer csproj/vbproj project system. I won't update the samples in this repository to newer SDK versions unless they still support xproj/project.json-style projects.

I plan to set up a new repository with samples for newer SDK versions and VS2017 RTM. A link will be added to this page once that is done.

# dotnet-core-appveyor
[![Build status](https://ci.appveyor.com/api/projects/status/6ntcjnbqnu5wlvmw?svg=true)](https://ci.appveyor.com/project/StevenLiekens/dotnet-core-appveyor)

This repository contains a few .NET Core sample projects and unit tests that are compiled, tested and packaged on AppVeyor.

Points of interest:
 - the appveyor.yml file contains the build script configuration
 - all code projects are based on the Visual Studio 2015 templates, with minor modifications to the project.json files
 - unit tests use a preview version of xUnit 2.2
     - https://web.archive.org/web/20170111122916/https://xunit.github.io/docs/getting-started-dotnet-core.html
     - Note that this is an archived page; instructions for xproj/project.json projects have been removed from the live version.
