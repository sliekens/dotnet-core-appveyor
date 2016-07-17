# dotnet-core-appveyor
[![Build status](https://ci.appveyor.com/api/projects/status/6ntcjnbqnu5wlvmw?svg=true)](https://ci.appveyor.com/project/StevenLiekens/dotnet-core-appveyor)

This repository contains a few .NET Core sample projects and unit tests that are compiled, tested and packaged on AppVeyor.

Points of interest:
 - the appveyor.yml file contains the build script configuration
 - all code projects are based on the Visual Studio templates, with minor modifications to the project.json files
 - unit tests use xUnit
     - https://xunit.github.io/docs/getting-started-dotnet-core.html