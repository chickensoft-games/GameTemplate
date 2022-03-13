# Game Template

#### C# Godot game template with Steamworks.NET ready out-of-the-box.

This is a Godot game setup with both C# and Steamworks.NET for both macOS and Windows. You don't need to compile a special version of Godot.

See `GameTemplate.csproj` for more information. It's using MSBuild conditions to determine which libraries to load based on the host platform. Not sure how this plays out when creating a release build with Godot, so feel free to open an issue or a PR if you have suggestions or improvements.

Steamworks.NET can't find the steam libraries on macOS without the `dllmap` entry in the `app.config` file, which is located in the project directory.

You should be able to use `dotnet restore` and `dotnet build` to verify that everything works. Additionally, you should be able to debug the game through Godot as you normally would. Make sure Steam is running or it won't succeed in initializing Steam.

Tested on my M1 Max mac and Windows computer.
