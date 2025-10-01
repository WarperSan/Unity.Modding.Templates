# Unity.Modding.Templates

[![NuGet](https://img.shields.io/nuget/v/WarperSan.BepInEx.Template.svg)](https://www.nuget.org/packages/WarperSan.BepInEx.Template)
[![NuGet Badge](https://img.shields.io/nuget/dt/WarperSan.BepInEx.Template)](https://www.nuget.org/packages/WarperSan.BepInEx.Template)
[![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://raw.githubusercontent.com/WarperSan/Unity.Modding.Templates/master/LICENSE)

## Overview
Template to create your own mods from scratch. It provides an easy .NET template that includes useful features, crucial for any project.

## Installation
### Using the .NET CLI

Install the template directly from NuGet by running:
```shell
dotnet new install WarperSan.BepInEx.Template
```

This command installs the latest version of the template published on NuGet.

### Manual Installation

Alternatively, you can download and install the latest release manually from:
- [NuGet](https://www.nuget.org/packages/WarperSan.BepInEx.Template)
- [GitHub Releases](https://github.com/WarperSan/Unity.Modding.Templates/releases/latest)

## Usage
### Using the .NET CLI

Once the template is installed, you can run the following command to create a new project. You can replace `MyFirstMod` with your mod's name:
```shell
dotnet new WarperSan.BepInEx.Template -n MyFirstMod
```

To see the other options provided in the template, you can use the following command:
```shell
dotnet new WarperSan.BepInEx.Template --help
```

### Using an IDE

Depending on your IDE, this process will be slightly different. You will want to create a new solution, select `Unity Plugin Template`. You can then adjust the options for your needs.

