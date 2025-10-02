<br>
<div style="text-align: center">
    <img alt="Logo" src="https://raw.githubusercontent.com/WarperSan/Unity.Modding.Templates/master/icon.png" height="128"/>
    <h1>Unity.Modding.Templates</h1>
    <div style="display: flex; gap: 1rem; justify-content: center;">
        <a href="https://www.nuget.org/packages/WarperSan.BepInEx.Template"><img alt="NuGet Badge" src="https://img.shields.io/nuget/v/WarperSan.BepInEx.Template.svg"></a>
        <a href="https://www.nuget.org/packages/WarperSan.BepInEx.Template"><img alt="NuGet Version" src="https://img.shields.io/nuget/dt/WarperSan.BepInEx.Template.svg"></a>
        <a href="https://raw.githubusercontent.com/WarperSan/Unity.Modding.Templates/master/LICENSE"><img alt="License: MIT" src="https://img.shields.io/badge/License-MIT-purple.svg"></a>
    </div>
</div>

## Overview

Unity.Modding.Templates is a collection of .NET templates that speeds up the creation of Unity mods.

## Installation
### Using the .NET CLI

You can install the templates directly from NuGet by running the following command:
```bash
dotnet new install WarperSan.BepInEx.Template
```

### Manual Installation

Alternatively, you can manually download the latest release of this project from:
- [NuGet](https://www.nuget.org/packages/WarperSan.BepInEx.Template)
- [GitHub Releases](https://github.com/WarperSan/Unity.Modding.Templates/releases/latest)

You will then be able to install the templates by running this command in the directory containing the downloaded package:
```bash
dotnet new install ./WarperSan.BepInEx.Template.*.nupkg
```

## Usage
### Using an IDE

In your IDE (Visual Studio, Rider, or VS Code), create a new solution and select `Unity Plugin Template`.

From there, adjust the options to fit your project's needs.

### Using the .NET CLI

Once the template is installed, you can create a new project with:
```bash
dotnet new WarperSan.BepInEx.Template -n MyMod
```

Replace `MyMod`with whatever you'd like to name your project.

To see all available options and parameters, run:
```shell
dotnet new WarperSan.BepInEx.Template --help
```

## Contributing

Contributions, issues, and feedback are welcome!

If your community has its own tweaks, feel free to [fork this template](https://github.com/WarperSan/Unity.Modding.Templates/fork) and adapt it to your needs.

## License

This project is licensed under the [MIT License](https://raw.githubusercontent.com/WarperSan/Unity.Modding.Templates/master/LICENSE)