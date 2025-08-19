using System;
using Godot;

public partial class KillZone : Area2D
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        myTimer = GetNode<Timer>("Timer");
    }

    private void OnBodyEntered(Node2D body)
    {
        GD.Print("You died!");
        myTimer.Start();
    }

    private void OnTimerTimeout()
    {
        GetTree().ReloadCurrentScene();
    }

    private Timer myTimer = null;
    // myTimer.Timeout += () => GD.Print("Timeout!");
}
