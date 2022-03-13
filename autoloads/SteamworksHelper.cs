using Godot;
using Steamworks;
using System;

public class SteamworksHelper : Node {
  public override void _Ready() {
    GD.Print("Steamworks: attempting initialization...");
    try {
      GD.Print("Steam is running: " + SteamAPI.IsSteamRunning());
      if (SteamAPI.Init()) {
        GD.Print("Steamworks initialization succeeded!");
      }
      else {
        GD.Print("Steamworks initialization failed!");
      }
    }
    catch (Exception e) {
      GD.Print("Steamworks initialization threw an exception :O");
      GD.Print(e);
    }
  }

  public override void _ExitTree() {
    // Tell Steam we're done.
    GD.Print("Steamworks: shutting down...");
    try {
      SteamAPI.Shutdown();
      GD.Print("Steamworks shutdown succeeded!");
    }
    catch (Exception e) {
      GD.Print("Steamworks shutdown threw an exception :O");
      GD.Print(e);
    }
  }
}
